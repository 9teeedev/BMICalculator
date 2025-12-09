namespace BMICalculator
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            ResultTextBMI = new TextBox();
            ResultDetailBMI = new TextBox();
            label5 = new Label();
            ResultBMI = new TextBox();
            button1 = new Button();
            label3 = new Label();
            HeightInput = new TextBox();
            label2 = new Label();
            WeightInput = new TextBox();
            label1 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ResultTextBMI);
            groupBox1.Controls.Add(ResultDetailBMI);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(ResultBMI);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(HeightInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(WeightInput);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(144, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(848, 601);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BMI Calculator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 346);
            label4.Name = "label4";
            label4.Size = new Size(61, 16);
            label4.TabIndex = 9;
            label4.Text = "ผลทดสอบ :";
            // 
            // ResultTextBMI
            // 
            ResultTextBMI.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultTextBMI.Location = new Point(87, 369);
            ResultTextBMI.Name = "ResultTextBMI";
            ResultTextBMI.ReadOnly = true;
            ResultTextBMI.Size = new Size(656, 26);
            ResultTextBMI.TabIndex = 8;
            // 
            // ResultDetailBMI
            // 
            ResultDetailBMI.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultDetailBMI.Location = new Point(87, 429);
            ResultDetailBMI.Multiline = true;
            ResultDetailBMI.Name = "ResultDetailBMI";
            ResultDetailBMI.ReadOnly = true;
            ResultDetailBMI.Size = new Size(656, 147);
            ResultDetailBMI.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 282);
            label5.Name = "label5";
            label5.Size = new Size(102, 16);
            label5.TabIndex = 7;
            label5.Text = "ค่า BMI ของคุณคือ :";
            // 
            // ResultBMI
            // 
            ResultBMI.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultBMI.Location = new Point(87, 305);
            ResultBMI.Name = "ResultBMI";
            ResultBMI.ReadOnly = true;
            ResultBMI.Size = new Size(656, 26);
            ResultBMI.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(87, 217);
            button1.Name = "button1";
            button1.Size = new Size(656, 41);
            button1.TabIndex = 5;
            button1.Text = "Calculate BMI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 135);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 4;
            label3.Text = "ส่วนสูง :";
            // 
            // HeightInput
            // 
            HeightInput.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeightInput.Location = new Point(87, 158);
            HeightInput.Name = "HeightInput";
            HeightInput.Size = new Size(656, 26);
            HeightInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 16);
            label2.TabIndex = 2;
            label2.Text = "น้ำหนัก :";
            // 
            // WeightInput
            // 
            WeightInput.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeightInput.Location = new Point(87, 94);
            WeightInput.Name = "WeightInput";
            WeightInput.Size = new Size(656, 26);
            WeightInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 28);
            label1.Name = "label1";
            label1.Size = new Size(322, 25);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวนค่าดัชนีมวลกาย - BMI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 410);
            label6.Name = "label6";
            label6.Size = new Size(64, 16);
            label6.TabIndex = 9;
            label6.Text = "รายละเอียด :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 638);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BMI Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label3;
        private TextBox HeightInput;
        private Label label2;
        private TextBox WeightInput;
        private Label label1;
        private Label label4;
        private TextBox ResultTextBMI;
        private Label label5;
        private TextBox ResultBMI;
        private Label label6;
        private TextBox ResultDetailBMI;
    }
}
