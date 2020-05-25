namespace Kolokwium_cs
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_rysuj = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_max = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.trackBar_xmin = new System.Windows.Forms.TrackBar();
            this.trackBar_xmax = new System.Windows.Forms.TrackBar();
            this.label_graniceXmin = new System.Windows.Forms.Label();
            this.label_graniceXmax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_xmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_xmax)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(-1, -2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(584, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_rysuj
            // 
            this.button_rysuj.Location = new System.Drawing.Point(589, 406);
            this.button_rysuj.Name = "button_rysuj";
            this.button_rysuj.Size = new System.Drawing.Size(199, 32);
            this.button_rysuj.TabIndex = 1;
            this.button_rysuj.Text = "rysuj";
            this.button_rysuj.UseVisualStyleBackColor = true;
            this.button_rysuj.Click += new System.EventHandler(this.button_rysuj_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(138, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Algorytm Hornera (x0=n)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Funkcja potęgowa (x^n)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(152, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sinus przesunięty (sin(x+n))";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wartość argumentu n:";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(597, 132);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(104, 20);
            this.textBox_n.TabIndex = 8;
            this.textBox_n.Text = "0";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(594, 169);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(107, 13);
            this.label_max.TabIndex = 9;
            this.label_max.Text = "Wartość max dla (-; -)";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(594, 192);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(104, 13);
            this.label_min.TabIndex = 10;
            this.label_min.Text = "Wartość min dla (-; -)";
            // 
            // trackBar_xmin
            // 
            this.trackBar_xmin.LargeChange = 10;
            this.trackBar_xmin.Location = new System.Drawing.Point(595, 291);
            this.trackBar_xmin.Maximum = -1;
            this.trackBar_xmin.Minimum = -200;
            this.trackBar_xmin.Name = "trackBar_xmin";
            this.trackBar_xmin.Size = new System.Drawing.Size(92, 45);
            this.trackBar_xmin.TabIndex = 11;
            this.trackBar_xmin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_xmin.Value = -1;
            this.trackBar_xmin.Scroll += new System.EventHandler(this.trackBar_xmin_Scroll);
            // 
            // trackBar_xmax
            // 
            this.trackBar_xmax.LargeChange = 10;
            this.trackBar_xmax.Location = new System.Drawing.Point(691, 291);
            this.trackBar_xmax.Maximum = 200;
            this.trackBar_xmax.Minimum = 1;
            this.trackBar_xmax.Name = "trackBar_xmax";
            this.trackBar_xmax.Size = new System.Drawing.Size(92, 45);
            this.trackBar_xmax.TabIndex = 13;
            this.trackBar_xmax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_xmax.Value = 1;
            this.trackBar_xmax.Scroll += new System.EventHandler(this.trackBar_xmax_Scroll);
            // 
            // label_graniceXmin
            // 
            this.label_graniceXmin.AutoSize = true;
            this.label_graniceXmin.Location = new System.Drawing.Point(604, 275);
            this.label_graniceXmin.Name = "label_graniceXmin";
            this.label_graniceXmin.Size = new System.Drawing.Size(13, 13);
            this.label_graniceXmin.TabIndex = 14;
            this.label_graniceXmin.Text = "1";
            // 
            // label_graniceXmax
            // 
            this.label_graniceXmax.AutoSize = true;
            this.label_graniceXmax.Location = new System.Drawing.Point(760, 275);
            this.label_graniceXmax.Name = "label_graniceXmax";
            this.label_graniceXmax.Size = new System.Drawing.Size(13, 13);
            this.label_graniceXmax.TabIndex = 15;
            this.label_graniceXmax.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Granice przedziału";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(589, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 103);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybór funkcji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_graniceXmin);
            this.Controls.Add(this.label_graniceXmax);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBar_xmax);
            this.Controls.Add(this.trackBar_xmin);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_rysuj);
            this.Name = "Form1";
            this.Text = "Wykres funkcji";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_xmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_xmax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_rysuj;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.TrackBar trackBar_xmin;
        private System.Windows.Forms.TrackBar trackBar_xmax;
        private System.Windows.Forms.Label label_graniceXmin;
        private System.Windows.Forms.Label label_graniceXmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

