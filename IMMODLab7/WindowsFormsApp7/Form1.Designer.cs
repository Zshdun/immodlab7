namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AvgDistanceLabel = new System.Windows.Forms.Label();
            this.SickPeopleCntLabel = new System.Windows.Forms.Label();
            this.AmbulancesCntLabel = new System.Windows.Forms.Label();
            this.EstimatedWaitingTimeLabel = new System.Windows.Forms.Label();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.HospitalCntLabel = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.BudgetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(669, 37);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click_1);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(669, 106);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(255, 250);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Время ожидания скорой помощи";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(340, 321);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // AvgDistanceLabel
            // 
            this.AvgDistanceLabel.AutoSize = true;
            this.AvgDistanceLabel.Location = new System.Drawing.Point(580, 47);
            this.AvgDistanceLabel.Name = "AvgDistanceLabel";
            this.AvgDistanceLabel.Size = new System.Drawing.Size(13, 13);
            this.AvgDistanceLabel.TabIndex = 3;
            this.AvgDistanceLabel.Text = "--";
            // 
            // SickPeopleCntLabel
            // 
            this.SickPeopleCntLabel.AutoSize = true;
            this.SickPeopleCntLabel.Location = new System.Drawing.Point(580, 79);
            this.SickPeopleCntLabel.Name = "SickPeopleCntLabel";
            this.SickPeopleCntLabel.Size = new System.Drawing.Size(13, 13);
            this.SickPeopleCntLabel.TabIndex = 4;
            this.SickPeopleCntLabel.Text = "--";
            // 
            // AmbulancesCntLabel
            // 
            this.AmbulancesCntLabel.AutoSize = true;
            this.AmbulancesCntLabel.Location = new System.Drawing.Point(580, 120);
            this.AmbulancesCntLabel.Name = "AmbulancesCntLabel";
            this.AmbulancesCntLabel.Size = new System.Drawing.Size(13, 13);
            this.AmbulancesCntLabel.TabIndex = 5;
            this.AmbulancesCntLabel.Text = "--";
            // 
            // EstimatedWaitingTimeLabel
            // 
            this.EstimatedWaitingTimeLabel.AutoSize = true;
            this.EstimatedWaitingTimeLabel.Location = new System.Drawing.Point(580, 153);
            this.EstimatedWaitingTimeLabel.Name = "EstimatedWaitingTimeLabel";
            this.EstimatedWaitingTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.EstimatedWaitingTimeLabel.TabIndex = 6;
            this.EstimatedWaitingTimeLabel.Text = "--";
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Location = new System.Drawing.Point(580, 190);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(13, 13);
            this.BudgetLabel.TabIndex = 7;
            this.BudgetLabel.Text = "--";
            // 
            // HospitalCntLabel
            // 
            this.HospitalCntLabel.AutoSize = true;
            this.HospitalCntLabel.Location = new System.Drawing.Point(582, 222);
            this.HospitalCntLabel.Name = "HospitalCntLabel";
            this.HospitalCntLabel.Size = new System.Drawing.Size(13, 13);
            this.HospitalCntLabel.TabIndex = 8;
            this.HospitalCntLabel.Text = "--";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(219, 129);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextBox.TabIndex = 9;
            this.AreaTextBox.Text = "450";
            // 
            // BudgetTextBox
            // 
            this.BudgetTextBox.Location = new System.Drawing.Point(45, 129);
            this.BudgetTextBox.Name = "BudgetTextBox";
            this.BudgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.BudgetTextBox.TabIndex = 10;
            this.BudgetTextBox.Text = "300000";
            this.BudgetTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Площадь города (км^2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Изначальный бюджет(тыс.р.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Средняя дистанция до больницы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество вызовов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Кол-во машин скорой помощи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Время ожидания скорой помощи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Бюджет";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Кол-во больниц";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 583);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BudgetTextBox);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.HospitalCntLabel);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.EstimatedWaitingTimeLabel);
            this.Controls.Add(this.AmbulancesCntLabel);
            this.Controls.Add(this.SickPeopleCntLabel);
            this.Controls.Add(this.AvgDistanceLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label AvgDistanceLabel;
        private System.Windows.Forms.Label SickPeopleCntLabel;
        private System.Windows.Forms.Label AmbulancesCntLabel;
        private System.Windows.Forms.Label EstimatedWaitingTimeLabel;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.Label HospitalCntLabel;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.TextBox BudgetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

