namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuickSort_radio = new System.Windows.Forms.RadioButton();
            this.BubbleSort_radio = new System.Windows.Forms.RadioButton();
            this.LinearSearch_radio = new System.Windows.Forms.RadioButton();
            this.BinarySearch_radio = new System.Windows.Forms.RadioButton();
            this.Search_bttn = new System.Windows.Forms.Button();
            this.insert_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Option_combo = new System.Windows.Forms.ComboBox();
            this.result_TB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // QuickSort_radio
            // 
            this.QuickSort_radio.AutoSize = true;
            this.QuickSort_radio.Location = new System.Drawing.Point(476, 148);
            this.QuickSort_radio.Margin = new System.Windows.Forms.Padding(2);
            this.QuickSort_radio.Name = "QuickSort_radio";
            this.QuickSort_radio.Size = new System.Drawing.Size(72, 17);
            this.QuickSort_radio.TabIndex = 0;
            this.QuickSort_radio.TabStop = true;
            this.QuickSort_radio.Text = "QuickSort";
            this.QuickSort_radio.UseVisualStyleBackColor = true;
            // 
            // BubbleSort_radio
            // 
            this.BubbleSort_radio.AutoSize = true;
            this.BubbleSort_radio.Location = new System.Drawing.Point(476, 184);
            this.BubbleSort_radio.Margin = new System.Windows.Forms.Padding(2);
            this.BubbleSort_radio.Name = "BubbleSort_radio";
            this.BubbleSort_radio.Size = new System.Drawing.Size(77, 17);
            this.BubbleSort_radio.TabIndex = 1;
            this.BubbleSort_radio.TabStop = true;
            this.BubbleSort_radio.Text = "BubbleSort";
            this.BubbleSort_radio.UseVisualStyleBackColor = true;
            // 
            // LinearSearch_radio
            // 
            this.LinearSearch_radio.AutoSize = true;
            this.LinearSearch_radio.Location = new System.Drawing.Point(476, 223);
            this.LinearSearch_radio.Margin = new System.Windows.Forms.Padding(2);
            this.LinearSearch_radio.Name = "LinearSearch_radio";
            this.LinearSearch_radio.Size = new System.Drawing.Size(88, 17);
            this.LinearSearch_radio.TabIndex = 2;
            this.LinearSearch_radio.TabStop = true;
            this.LinearSearch_radio.Text = "LinearSearch";
            this.LinearSearch_radio.UseVisualStyleBackColor = true;
            this.LinearSearch_radio.CheckedChanged += new System.EventHandler(this.LinearSearch_radio_CheckedChanged);
            // 
            // BinarySearch_radio
            // 
            this.BinarySearch_radio.AutoSize = true;
            this.BinarySearch_radio.Location = new System.Drawing.Point(476, 262);
            this.BinarySearch_radio.Margin = new System.Windows.Forms.Padding(2);
            this.BinarySearch_radio.Name = "BinarySearch_radio";
            this.BinarySearch_radio.Size = new System.Drawing.Size(88, 17);
            this.BinarySearch_radio.TabIndex = 3;
            this.BinarySearch_radio.TabStop = true;
            this.BinarySearch_radio.Text = "BinarySearch";
            this.BinarySearch_radio.UseVisualStyleBackColor = true;
            // 
            // Search_bttn
            // 
            this.Search_bttn.Location = new System.Drawing.Point(476, 342);
            this.Search_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.Search_bttn.Name = "Search_bttn";
            this.Search_bttn.Size = new System.Drawing.Size(87, 37);
            this.Search_bttn.TabIndex = 4;
            this.Search_bttn.Text = "Search";
            this.Search_bttn.UseVisualStyleBackColor = true;
            this.Search_bttn.Click += new System.EventHandler(this.Search_bttn_Click);
            // 
            // insert_bttn
            // 
            this.insert_bttn.Location = new System.Drawing.Point(45, 418);
            this.insert_bttn.Margin = new System.Windows.Forms.Padding(2);
            this.insert_bttn.Name = "insert_bttn";
            this.insert_bttn.Size = new System.Drawing.Size(56, 19);
            this.insert_bttn.TabIndex = 6;
            this.insert_bttn.Text = "Insert";
            this.insert_bttn.UseVisualStyleBackColor = true;
            this.insert_bttn.Click += new System.EventHandler(this.insert_bttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LEGO ALGORITHMS";
            // 
            // Option_combo
            // 
            this.Option_combo.FormattingEnabled = true;
            this.Option_combo.Items.AddRange(new object[] {
            "ArrayList",
            "LinkedList",
            "BinaryTree"});
            this.Option_combo.Location = new System.Drawing.Point(476, 80);
            this.Option_combo.Margin = new System.Windows.Forms.Padding(2);
            this.Option_combo.Name = "Option_combo";
            this.Option_combo.Size = new System.Drawing.Size(153, 21);
            this.Option_combo.TabIndex = 10;
            // 
            // result_TB
            // 
            this.result_TB.Location = new System.Drawing.Point(45, 80);
            this.result_TB.Margin = new System.Windows.Forms.Padding(2);
            this.result_TB.Name = "result_TB";
            this.result_TB.Size = new System.Drawing.Size(414, 324);
            this.result_TB.TabIndex = 9;
            this.result_TB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 462);
            this.Controls.Add(this.Option_combo);
            this.Controls.Add(this.result_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert_bttn);
            this.Controls.Add(this.Search_bttn);
            this.Controls.Add(this.BinarySearch_radio);
            this.Controls.Add(this.LinearSearch_radio);
            this.Controls.Add(this.BubbleSort_radio);
            this.Controls.Add(this.QuickSort_radio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton QuickSort_radio;
        private System.Windows.Forms.RadioButton BubbleSort_radio;
        private System.Windows.Forms.RadioButton LinearSearch_radio;
        private System.Windows.Forms.RadioButton BinarySearch_radio;
        private System.Windows.Forms.Button Search_bttn;
        private System.Windows.Forms.Button insert_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Option_combo;
        private System.Windows.Forms.RichTextBox result_TB;
    }
}

