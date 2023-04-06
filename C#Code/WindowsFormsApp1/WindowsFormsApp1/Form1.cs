using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                                    result_TB.Text += title + "\t ";
                                }
                                result_TB.Text += "\n";
                                firstRow = false;

                            }
                            else
                            {
                                // Adding values to the TB
                                foreach (string value in lineElements)
                                {
                                    result_TB.Text += value + "\t";
                                }
                                result_TB.Text += "\n";

                            }
                        }
                        sr.Close();
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid file! \n -> CSV");
            }

        }

        private void Search_bttn_Click(object sender, EventArgs e)
        {

            //fix selecting the rows
            //checking the layout of programm
            if (Option_combo.SelectedIndex == 2 && QuickSort_radio.Checked)
            {
                //seach the richtextbox and do a quicksort
                //if (result_TB.Text.Contains(search_TB.Text))
                //{
                //    MessageBox.Show("Found!");
                // 
                //    //var source = result_TB.Text;
                //    //List<string> colors = new List<string>();
                //    //using (StreamReader sr = new StreamReader(source))
                //    //{
                //    //    while (!sr.EndOfStream)
                //    //    {
                //    //        string line = sr.ReadLine();
                //    //        colors.Add(line);
                //    //     
                
            }
           
        }
    }
}

