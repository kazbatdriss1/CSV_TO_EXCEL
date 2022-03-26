using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace CSV_TO_EXCEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr a, int b, int c, int d);

        private void GradientPanel_TOP_MouseHover(object sender, EventArgs e)
        {          
        }

        private void GradientPanel_TOP_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Columns.Clear();
        }
        DataTable dt = new DataTable();

        private void Buttonimport_Click(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    TextBoxchemin.Text = openFile.FileName;
                    dt.Clear();
                    /*dt.Columns.Add("Date");
                    dt.Columns.Add("Client");
                    dt.Columns.Add("Document");
                    dt.Columns.Add("Référence");*/
                    dt.Columns.Add("Produit");
                    dt.Columns.Add("Qte");
                    dt.Columns.Add("PU_HT");
                    dt.Columns.Add("PT_HT");
                    dt.Columns.Add("PT_TTC");
                    using (var reader = new StreamReader(TextBoxchemin.Text))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (line.Contains(';'))
                            {
                                var values = line.Split(';');
                                dt.Rows.Add(new object[] { values[4], values[5], values[6], values[7], values[8] });
                            }
                            else if (line.Contains(','))
                            {
                                var values = line.Split(',');
                                dt.Rows.Add(new object[] { values[4], values[5], values[6], values[7], values[8] });
                            }
                        }
                    }
                    DataGridView1.DataSource = dt;
                }
            }
            catch (Exception E)
            {
                dt.Columns.Clear();
                MessageBox.Show(E.Message);
            }
        }
        private void TextBoxchemin_TextChanged(object sender, EventArgs e)
        {
        }

        private void ButtonImprimer_Excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application apps = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = apps.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Explorted from Gridview";

            for(int i =1 ;i< DataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < DataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            //workbook.SaveAs("D:\\OUTPUT.xls",Type.Missing,Type.Missing,Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            apps.Quit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
