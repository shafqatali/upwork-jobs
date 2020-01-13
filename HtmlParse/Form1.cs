using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;
using System.Threading;
using Newtonsoft.Json;

using DataTable = System.Data.DataTable;
using System.Diagnostics;

namespace HtmlParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ofdFile.ShowDialog();
        }

        private void txtFilePath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                ofdFile.ShowDialog();
            }
        }

        private void txtOutputFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutputFolder.Text))
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdOutput.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFolder.Text = fbdOutput.SelectedPath;
            }
        }

        private void ofdFile_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(ofdFile.FileName))
            {
                txtFilePath.Text = ofdFile.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ofdFile.FileName = "";
            ofdFile.Filter = "html files (*.htm)|*.htm|HTML files (*.html)|*.html|All files (*.*)|*.*";
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || string.IsNullOrEmpty(txtOutputFolder.Text))
            {
                MessageBox.Show("Please select input file and output folder first.", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            btnParse.Enabled = false;
            btnParse.Text = " Parsing HTML file ....";
            string fileToParse = txtFilePath.Text;
            if (File.Exists(fileToParse))
            {
                var fileparts = fileToParse.Split('\\');
                var realName = fileparts[fileparts.Length - 1];
                Application.DoEvents();
                List<Data> list = Parse_HTML_File(fileToParse);
                if (list.Count > 0)
                {
                    dgView.AutoGenerateColumns = true;
                    dgView.DataSource = list;

                    for (int c = 0; c < dgView.Columns.Count; c++)
                    {
                        dgView.Columns[c].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    btnParse.Text = " Writing into Excel file ....";
                    string fileName = MakeExcelFile(list, realName);

                    DialogResult dr = MessageBox.Show("HTML File parsed successfully. Open Excel File?", "Output", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe", fileName);
                    }
                }
                else
                {
                    MessageBox.Show("The input file doesn't have required data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("The file doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnParse.Enabled = true;
            btnParse.Text = "&Parse HTML File";
        }

        private List<Data> Parse_HTML_File(string fileName)
        {
            List<Data> listData = new List<Data>();
            try
            {
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(fileName);


                var tableMarkup = doc.DocumentNode.SelectSingleNode("//table");

                HtmlNodeCollection tableRows = tableMarkup.ChildNodes;

                foreach (var row in tableRows)
                {
                    if (row.NodeType == HtmlNodeType.Element)
                    {
                        HtmlNodeCollection tableCols = row.ChildNodes;
                        Data d = new Data();
                        var count = tableCols.Count;
                        if (count >= 4)
                        {
                            int counter = 1;
                            foreach (var col in tableCols)
                            {

                                if (col.NodeType == HtmlNodeType.Element && col.Name == "td" && counter < 4)
                                {
                                    var column = col;
                                    if (counter == 1)
                                    {
                                        string colText = col.InnerText;
                                        try
                                        {
                                            int num = Convert.ToInt32(colText);
                                            d.Id = num + 1;
                                        }
                                        catch (Exception)
                                        {
                                            d.Id = 0;
                                        }
                                    }
                                    if (counter == 2)
                                    {
                                        d.Name = col.InnerHtml;
                                    }
                                    if (counter == 3)
                                    {
                                        d.Uid = col.InnerHtml;
                                    }
                                }
                                counter += 1;
                            }
                        }
                        if (d.Id != 0 && !string.IsNullOrEmpty(d.Name) && !string.IsNullOrEmpty(d.Uid))
                        {
                            listData.Add(d);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to parse data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listData;
        }

        private string WriteCSV(List<Data> list, string realName)
        {
            var json = JsonConvert.SerializeObject(list);
            string fileName = txtOutputFolder.Text + @"\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-" + realName + ".csv";

            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            var lines = new List<string>();

            string[] columnNames = dataTable.Columns
                .Cast<DataColumn>()
                .Select(column => column.ColumnName)
                .ToArray();

            var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            lines.Add(header);

            var valueLines = dataTable.AsEnumerable()
                .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            lines.AddRange(valueLines);

            File.WriteAllLines(fileName, lines);

            return fileName;
        }

        private string MakeExcelFile(List<Data> list, string realName)
        {
            realName = realName.Replace(".htm", "");
            realName = realName.Replace(".html", "");
            var json = JsonConvert.SerializeObject(list);
            string fileName = txtOutputFolder.Text + @"\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-" + realName + ".xlsx";
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            try
            {
                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                var worKbooK = excel.Workbooks.Add(Type.Missing);


                var worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "List";
                int rowcount = 0;

                foreach (DataRow datarow in dataTable.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= dataTable.Columns.Count; i++)
                    {
                        worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();
                    }
                }

                var celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, dataTable.Columns.Count]];
                celLrangE.EntireColumn.AutoFit();
                
                worKbooK.SaveAs(fileName);
                worKbooK.Close();
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            return fileName;
        }
    }

    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }
    }
}

