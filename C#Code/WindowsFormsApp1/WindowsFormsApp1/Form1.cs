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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> colorsName = new List<string>();
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
                    using (StreamReader reader = new StreamReader(fd.FileName))
                    {
                        string data = "";

                        // Read file contents line by line
                        //ignore the first line of the csv file(name the column name)
                        string headerLine = reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] columns = line.Split(',');
                            string value = columns[1];
                            data += value + "\n";
                        }
                        colorsName.Add(data);                   
                    }
                    statusFile.Text = "File loaded !";

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

            if (LinearSearch_radio.Checked)
            {
                //Insert code here for linear search
                foreach(String name in colorsName)
                {
                    result_TB.Text += name;
                }
            }

            if (BinarySearch_radio.Checked)
            {
                //Inset code here for binary search
                result_TB.Text = "Binary Search!";
            }
           
        }

        private void LinearSearch_radio_CheckedChanged(object sender, EventArgs e)
        {
            //
        }
    }
}

