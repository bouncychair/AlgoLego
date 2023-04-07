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
                            string[] fields = line.Split(',');

                            if (fields.Length > 0)
                            {
                                colorsName.Add(fields[1]);
                            }
                        }
                        //colorsName.Add(data);                   
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
                Boolean found = false;
                string target = colorNameInput.Text;

                for(int i = 0; i < colorsName.Count; i++)
                {
                    if (colorsName[i] == target){ //if the list index contains the word we are searching for
                        result_TB.Text = target + " color name found at index " + i.ToString();
                        found = true; //found it then set the flag found to true
                        break; //exit from the loop
                    }
                }
                if (!found)
                {
                    result_TB.Text = "Color name not found !";
                }
            }

            if (BinarySearch_radio.Checked)
            {
                int low = 0;
                int high = colorsName.Count - 1;
                int middle;
                string target = colorNameInput.Text;
                Boolean found = false;

                List<Tuple<string, int>> colors = new List<Tuple<string, int>>();

                // add to the list the colors name with their original indexes
                for (int i = 0; i < colorsName.Count; i++)
                {
                    Tuple<string, int> tuple = Tuple.Create(colorsName[i], i);
                    colors.Add(tuple);
                }

                // list is sorted based on the color name
                colors.Sort((a, b) => string.Compare(a.Item1, b.Item1));


                while (low <= high)
                {
                    middle = (low + high) / 2;

                    if (string.Compare(colors[middle].Item1, target) < 0)
                    {
                        low = middle + 1;
                    }
                    else if (string.Compare(colors[middle].Item1, target) > 0)
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        result_TB.Text = target + " color name found at index " + colors[middle].Item2.ToString();
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result_TB.Text = "Color name not found !";
                }
            }
           
        }

        private void LinearSearch_radio_CheckedChanged(object sender, EventArgs e)
        {
            //
        }
    }
}

