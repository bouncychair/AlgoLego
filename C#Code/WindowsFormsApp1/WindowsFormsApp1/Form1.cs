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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insert_bttn_Click(object sender, EventArgs e)
        {
            //open the filedialog for searching for .csv file
            FileDialog fd = new OpenFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv",
            };
            if (fd.ShowDialog().Equals(DialogResult.OK))
            {
                DataTable dt = new DataTable();
                try
                {
                    using (StreamReader sr = new StreamReader(fd.FileName))
                    {

                        // Will tell if it is the first row
                        bool firstRow = true;
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] lineElements = line.Split(',');

                            if (firstRow)
                            {
                                // The first row defines the column names
                                foreach (string title in lineElements)
                                {
                                    dt.Columns.Add(title);
                                }

                                firstRow = false;
                            }
                            else
                            {
                                // Adding values to the DataTable
                                dt.Rows.Add(lineElements);
                            }
                        }
                    }
                    legoSets.DataSource = dt;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid file!");
            }

        }
    }
}
