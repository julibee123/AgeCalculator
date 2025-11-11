namespace AgeCalculator
{
    partial class AgeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeForm));
            dateTimePicker1 = new DateTimePicker();
            btnCalcAge = new Button();
            panel1 = new Panel();
            labBdayD = new Label();
            labBdayY = new Label();
            dateTimePicker2 = new DateTimePicker();
            labBdayM = new Label();
            dateTimePicker3 = new DateTimePicker();
            panel2 = new Panel();
            labPanelY = new Panel();
            label3 = new Label();
            labPanelD = new Panel();
            label2 = new Label();
            labPanelM = new Panel();
            label1 = new Label();
            labAgeM = new Label();
            labAgeD = new Label();
            labAgeY = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            labPanelY.SuspendLayout();
            labPanelD.SuspendLayout();
            labPanelM.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker1.Checked = false;
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(23, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(52, 38);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // btnCalcAge
            // 
            btnCalcAge.Cursor = Cursors.Hand;
            btnCalcAge.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcAge.Location = new Point(278, 223);
            btnCalcAge.Name = "btnCalcAge";
            btnCalcAge.Size = new Size(207, 65);
            btnCalcAge.TabIndex = 1;
            btnCalcAge.Text = "Calculate Age";
            btnCalcAge.UseVisualStyleBackColor = true;
            btnCalcAge.Click += btnCalcAge_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(labBdayD);
            panel1.Controls.Add(labBdayY);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(labBdayM);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dateTimePicker3);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 157);
            panel1.TabIndex = 2;
            panel1.Click += panel1_Click;
            // 
            // labBdayD
            // 
            labBdayD.AutoSize = true;
            labBdayD.Cursor = Cursors.Hand;
            labBdayD.Font = new Font("Poppins", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labBdayD.ForeColor = SystemColors.ButtonFace;
            labBdayD.Location = new Point(293, -2);
            labBdayD.Name = "labBdayD";
            labBdayD.Size = new Size(174, 177);
            labBdayD.TabIndex = 0;
            labBdayD.Text = "31";
            labBdayD.Click += bDay_Click;
            // 
            // labBdayY
            // 
            labBdayY.AutoSize = true;
            labBdayY.Cursor = Cursors.Hand;
            labBdayY.Font = new Font("Poppins", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labBdayY.ForeColor = SystemColors.ButtonFace;
            labBdayY.Location = new Point(473, -2);
            labBdayY.Name = "labBdayY";
            labBdayY.Size = new Size(319, 177);
            labBdayY.TabIndex = 0;
            labBdayY.Text = "2025";
            labBdayY.Click += bYear_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker2.Checked = false;
            dateTimePicker2.Cursor = Cursors.Hand;
            dateTimePicker2.CustomFormat = " ";
            dateTimePicker2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(293, 119);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(52, 38);
            dateTimePicker2.TabIndex = 0;
            dateTimePicker2.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // labBdayM
            // 
            labBdayM.AutoSize = true;
            labBdayM.Cursor = Cursors.Hand;
            labBdayM.Font = new Font("Poppins", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labBdayM.ForeColor = SystemColors.ButtonFace;
            labBdayM.Location = new Point(0, -2);
            labBdayM.Name = "labBdayM";
            labBdayM.Size = new Size(253, 177);
            labBdayM.TabIndex = 0;
            labBdayM.Text = "SEP";
            labBdayM.Click += bMonth_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarTitleForeColor = Color.AliceBlue;
            dateTimePicker3.Checked = false;
            dateTimePicker3.Cursor = Cursors.Hand;
            dateTimePicker3.CustomFormat = " ";
            dateTimePicker3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(492, 119);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(52, 38);
            dateTimePicker3.TabIndex = 0;
            dateTimePicker3.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(labPanelY);
            panel2.Controls.Add(labPanelD);
            panel2.Controls.Add(labPanelM);
            panel2.Controls.Add(labAgeM);
            panel2.Controls.Add(labAgeD);
            panel2.Controls.Add(labAgeY);
            panel2.Location = new Point(0, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 195);
            panel2.TabIndex = 3;
            // 
            // labPanelY
            // 
            labPanelY.BackColor = Color.SlateBlue;
            labPanelY.Controls.Add(label3);
            labPanelY.Location = new Point(32, 111);
            labPanelY.Name = "labPanelY";
            labPanelY.Size = new Size(180, 65);
            labPanelY.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(-19, -15);
            label3.Name = "label3";
            label3.Size = new Size(222, 106);
            label3.TabIndex = 4;
            label3.Text = "Years";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labPanelD
            // 
            labPanelD.BackColor = Color.SlateBlue;
            labPanelD.Controls.Add(label2);
            labPanelD.Location = new Point(571, 111);
            labPanelD.Name = "labPanelD";
            labPanelD.Size = new Size(161, 65);
            labPanelD.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(-19, -15);
            label2.Name = "label2";
            label2.Size = new Size(201, 106);
            label2.TabIndex = 4;
            label2.Text = "Days";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labPanelM
            // 
            labPanelM.BackColor = Color.SlateBlue;
            labPanelM.Controls.Add(label1);
            labPanelM.Location = new Point(278, 111);
            labPanelM.Name = "labPanelM";
            labPanelM.Size = new Size(230, 65);
            labPanelM.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-19, -15);
            label1.Name = "label1";
            label1.Size = new Size(275, 106);
            label1.TabIndex = 4;
            label1.Text = "Months";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labAgeM
            // 
            labAgeM.AutoSize = true;
            labAgeM.Font = new Font("Poppins", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labAgeM.ForeColor = SystemColors.ButtonFace;
            labAgeM.Location = new Point(292, -10);
            labAgeM.Name = "labAgeM";
            labAgeM.Size = new Size(140, 177);
            labAgeM.TabIndex = 1;
            labAgeM.Text = "0";
            labAgeM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labAgeD
            // 
            labAgeD.AutoSize = true;
            labAgeD.Font = new Font("Poppins", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labAgeD.ForeColor = SystemColors.ButtonFace;
            labAgeD.Location = new Point(571, -10);
            labAgeD.Name = "labAgeD";
            labAgeD.Size = new Size(140, 177);
            labAgeD.TabIndex = 2;
            labAgeD.Text = "0";
            labAgeD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labAgeY
            // 
            labAgeY.AutoSize = true;
            labAgeY.Font = new Font("Poppins", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labAgeY.ForeColor = SystemColors.ButtonFace;
            labAgeY.ImageAlign = ContentAlignment.MiddleLeft;
            labAgeY.Location = new Point(12, -10);
            labAgeY.Name = "labAgeY";
            labAgeY.Size = new Size(140, 177);
            labAgeY.TabIndex = 3;
            labAgeY.Text = "0";
            labAgeY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(0, 306);
            panel3.Name = "panel3";
            panel3.Size = new Size(781, 62);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(340, 2);
            label4.Name = "label4";
            label4.Size = new Size(92, 60);
            label4.TabIndex = 5;
            label4.Text = "Age";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumSlateBlue;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(781, 62);
            panel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(23, 2);
            label5.Name = "label5";
            label5.Size = new Size(744, 60);
            label5.TabIndex = 6;
            label5.Text = "Birthday (Click on the date below to set it!)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(781, 559);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCalcAge);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AgeForm";
            Text = "Age Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            labPanelY.ResumeLayout(false);
            labPanelY.PerformLayout();
            labPanelD.ResumeLayout(false);
            labPanelD.PerformLayout();
            labPanelM.ResumeLayout(false);
            labPanelM.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnCalcAge;
        private Panel panel1;
        private Label labBdayM;
        private Label labBdayD;
        private Label labBdayY;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Panel panel2;
        private Label labAgeM;
        private Label labAgeD;
        private Label labAgeY;
        private Label label1;
        private Panel labPanelY;
        private Label label3;
        private Panel labPanelD;
        private Label label2;
        private Panel labPanelM;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label5;
    }
}
