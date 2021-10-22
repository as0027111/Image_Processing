namespace HW1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Sobel_BTN = new System.Windows.Forms.Button();
            this.Sobel_Y_BTN = new System.Windows.Forms.Button();
            this.Sobel_X_BTN = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Overlap_Btn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.transformed_Btn = new System.Windows.Forms.Button();
            this.origin_Btn = new System.Windows.Forms.Button();
            this.registration_Btn = new System.Windows.Forms.Button();
            this.registration_label = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gray";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "R channel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "G channel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(201, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "B channel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Mean";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(167, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "median";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(108, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Equaliztion";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1181, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Undo";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1089, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(557, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(1073, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. RGB Extration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(1073, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 60);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.Smooth Filter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(1073, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 60);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3.Histogram Equalization";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(117, 439);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(300, 176);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(667, 439);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(300, 176);
            this.chart2.SuppressExceptions = true;
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Location = new System.Drawing.Point(1073, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 60);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4.Threshold";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 22);
            this.textBox2.TabIndex = 1;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(167, 21);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Threshold";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Sobel_BTN);
            this.groupBox5.Controls.Add(this.Sobel_Y_BTN);
            this.groupBox5.Controls.Add(this.Sobel_X_BTN);
            this.groupBox5.Location = new System.Drawing.Point(1073, 399);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 71);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "5.Sobel Detection";
            // 
            // Sobel_BTN
            // 
            this.Sobel_BTN.Location = new System.Drawing.Point(201, 26);
            this.Sobel_BTN.Name = "Sobel_BTN";
            this.Sobel_BTN.Size = new System.Drawing.Size(75, 23);
            this.Sobel_BTN.TabIndex = 2;
            this.Sobel_BTN.Text = "Combined";
            this.Sobel_BTN.UseVisualStyleBackColor = true;
            this.Sobel_BTN.Click += new System.EventHandler(this.Sobel_BTN_Click);
            // 
            // Sobel_Y_BTN
            // 
            this.Sobel_Y_BTN.Location = new System.Drawing.Point(108, 26);
            this.Sobel_Y_BTN.Name = "Sobel_Y_BTN";
            this.Sobel_Y_BTN.Size = new System.Drawing.Size(75, 23);
            this.Sobel_Y_BTN.TabIndex = 1;
            this.Sobel_Y_BTN.Text = "Vertical";
            this.Sobel_Y_BTN.UseVisualStyleBackColor = true;
            this.Sobel_Y_BTN.Click += new System.EventHandler(this.Sobel_Y_BTN_Click);
            // 
            // Sobel_X_BTN
            // 
            this.Sobel_X_BTN.Location = new System.Drawing.Point(16, 26);
            this.Sobel_X_BTN.Name = "Sobel_X_BTN";
            this.Sobel_X_BTN.Size = new System.Drawing.Size(75, 23);
            this.Sobel_X_BTN.TabIndex = 0;
            this.Sobel_X_BTN.Text = "Horizonal";
            this.Sobel_X_BTN.UseVisualStyleBackColor = true;
            this.Sobel_X_BTN.Click += new System.EventHandler(this.Sobel_X_BTN_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Overlap_Btn);
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Location = new System.Drawing.Point(1073, 484);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(291, 60);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "6. Overlap";
            // 
            // Overlap_Btn
            // 
            this.Overlap_Btn.Location = new System.Drawing.Point(167, 21);
            this.Overlap_Btn.Name = "Overlap_Btn";
            this.Overlap_Btn.Size = new System.Drawing.Size(75, 23);
            this.Overlap_Btn.TabIndex = 1;
            this.Overlap_Btn.Text = "Overlap";
            this.Overlap_Btn.UseVisualStyleBackColor = true;
            this.Overlap_Btn.Click += new System.EventHandler(this.Overlap_Btn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(50, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button11);
            this.groupBox7.Location = new System.Drawing.Point(1073, 559);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(291, 60);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "7.8-adjacency";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(108, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 21;
            this.button11.Text = "8-adjacency";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.transformed_Btn);
            this.groupBox8.Controls.Add(this.origin_Btn);
            this.groupBox8.Controls.Add(this.registration_Btn);
            this.groupBox8.Location = new System.Drawing.Point(1073, 635);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(291, 70);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "8.Registration";
            // 
            // transformed_Btn
            // 
            this.transformed_Btn.Location = new System.Drawing.Point(108, 25);
            this.transformed_Btn.Name = "transformed_Btn";
            this.transformed_Btn.Size = new System.Drawing.Size(75, 23);
            this.transformed_Btn.TabIndex = 23;
            this.transformed_Btn.Text = "Transformed";
            this.transformed_Btn.UseVisualStyleBackColor = true;
            this.transformed_Btn.Click += new System.EventHandler(this.transformed_Btn_Click);
            // 
            // origin_Btn
            // 
            this.origin_Btn.Location = new System.Drawing.Point(16, 25);
            this.origin_Btn.Name = "origin_Btn";
            this.origin_Btn.Size = new System.Drawing.Size(75, 23);
            this.origin_Btn.TabIndex = 22;
            this.origin_Btn.Text = "Origin";
            this.origin_Btn.UseVisualStyleBackColor = true;
            this.origin_Btn.Click += new System.EventHandler(this.origin_Btn_Click);
            // 
            // registration_Btn
            // 
            this.registration_Btn.Location = new System.Drawing.Point(201, 25);
            this.registration_Btn.Name = "registration_Btn";
            this.registration_Btn.Size = new System.Drawing.Size(75, 23);
            this.registration_Btn.TabIndex = 0;
            this.registration_Btn.Text = "Registration";
            this.registration_Btn.UseVisualStyleBackColor = true;
            this.registration_Btn.Click += new System.EventHandler(this.registration_Btn_Click);
            // 
            // registration_label
            // 
            this.registration_label.AutoSize = true;
            this.registration_label.Location = new System.Drawing.Point(555, 484);
            this.registration_label.Name = "registration_label";
            this.registration_label.Size = new System.Drawing.Size(33, 12);
            this.registration_label.TabIndex = 22;
            this.registration_label.Text = "label1";
            this.registration_label.Visible = false;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(1274, 56);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(75, 23);
            this.Save_Btn.TabIndex = 23;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 754);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.registration_label);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Sobel_BTN;
        private System.Windows.Forms.Button Sobel_Y_BTN;
        private System.Windows.Forms.Button Sobel_X_BTN;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Overlap_Btn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button registration_Btn;
        private System.Windows.Forms.Button origin_Btn;
        private System.Windows.Forms.Button transformed_Btn;
        private System.Windows.Forms.Label registration_label;
        private System.Windows.Forms.Button Save_Btn;
    }
}

