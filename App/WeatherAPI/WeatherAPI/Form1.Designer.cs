namespace WeatherAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_request = new System.Windows.Forms.Button();
            this.richTextBox_data = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_maxTemperature = new System.Windows.Forms.Label();
            this.label_minTemperature = new System.Windows.Forms.Label();
            this.label_province = new System.Windows.Forms.Label();
            this.label_station = new System.Windows.Forms.Label();
            this.label_temperature = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_station = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_request);
            this.tabPage1.Controls.Add(this.richTextBox_data);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_request
            // 
            this.button_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_request.Location = new System.Drawing.Point(688, 6);
            this.button_request.Name = "button_request";
            this.button_request.Size = new System.Drawing.Size(91, 35);
            this.button_request.TabIndex = 1;
            this.button_request.Text = "request";
            this.button_request.UseVisualStyleBackColor = true;
            this.button_request.Click += new System.EventHandler(this.Button_request_Click);
            // 
            // richTextBox_data
            // 
            this.richTextBox_data.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox_data.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_data.Name = "richTextBox_data";
            this.richTextBox_data.Size = new System.Drawing.Size(633, 446);
            this.richTextBox_data.TabIndex = 0;
            this.richTextBox_data.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label_maxTemperature);
            this.tabPage2.Controls.Add(this.label_minTemperature);
            this.tabPage2.Controls.Add(this.label_province);
            this.tabPage2.Controls.Add(this.label_station);
            this.tabPage2.Controls.Add(this.label_temperature);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBox_station);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(423, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "อุณหภูมิสูงสุด";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "อุณหภูมิต่ำสุด";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_maxTemperature
            // 
            this.label_maxTemperature.Location = new System.Drawing.Point(391, 417);
            this.label_maxTemperature.Name = "label_maxTemperature";
            this.label_maxTemperature.Size = new System.Drawing.Size(431, 28);
            this.label_maxTemperature.TabIndex = 28;
            this.label_maxTemperature.Text = "Temperature Max Value";
            this.label_maxTemperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_minTemperature
            // 
            this.label_minTemperature.Location = new System.Drawing.Point(391, 312);
            this.label_minTemperature.Name = "label_minTemperature";
            this.label_minTemperature.Size = new System.Drawing.Size(431, 28);
            this.label_minTemperature.TabIndex = 29;
            this.label_minTemperature.Text = "Temperature Min Value";
            this.label_minTemperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_province
            // 
            this.label_province.Location = new System.Drawing.Point(391, 42);
            this.label_province.Name = "label_province";
            this.label_province.Size = new System.Drawing.Size(431, 28);
            this.label_province.TabIndex = 30;
            this.label_province.Text = "Temperature Value";
            this.label_province.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_station
            // 
            this.label_station.Location = new System.Drawing.Point(391, 124);
            this.label_station.Name = "label_station";
            this.label_station.Size = new System.Drawing.Size(431, 28);
            this.label_station.TabIndex = 31;
            this.label_station.Text = "Temperature Value";
            this.label_station.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_temperature
            // 
            this.label_temperature.Location = new System.Drawing.Point(391, 213);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(431, 28);
            this.label_temperature.TabIndex = 32;
            this.label_temperature.Text = "Temperature Value";
            this.label_temperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(391, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(427, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "สถานี";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "อุณหภูมิ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "จังหวัด";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox_station
            // 
            this.listBox_station.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_station.FormattingEnabled = true;
            this.listBox_station.ItemHeight = 20;
            this.listBox_station.Location = new System.Drawing.Point(3, 3);
            this.listBox_station.Name = "listBox_station";
            this.listBox_station.Size = new System.Drawing.Size(382, 446);
            this.listBox_station.TabIndex = 25;
            this.listBox_station.SelectedIndexChanged += new System.EventHandler(this.ListBox_station_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 485);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weather API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_maxTemperature;
        private System.Windows.Forms.Label label_minTemperature;
        private System.Windows.Forms.Label label_province;
        private System.Windows.Forms.Label label_station;
        private System.Windows.Forms.Label label_temperature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_station;
        private System.Windows.Forms.Button button_request;
    }
}

