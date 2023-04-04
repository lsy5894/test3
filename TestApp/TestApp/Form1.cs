using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> x = new List<string>();
        List<String> y = new List<string>();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ".csv files (*.csv)|*.csv";
            openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName; StreamReader file = new StreamReader(filename);
                DataTable table = new DataTable();

                table.Columns.Add("A");
                table.Columns.Add("B");

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');
                    table.Rows.Add(data[0], data[1]);

                    x.Add(data[0]);
                    y.Add(data[1]);

                    chart1.Series[0].Points.AddXY(Double.Parse(data[0]), Double.Parse(data[1]));

                }
                gridControl1.DataSource = table;

            }
       
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
