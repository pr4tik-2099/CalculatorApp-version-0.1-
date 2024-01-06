namespace CalculatorApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Num1_txt = new TextBox();
            Num2_txt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Ans_lbl = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 102);
            label1.Name = "label1";
            label1.Size = new Size(52, 22);
            label1.TabIndex = 0;
            label1.Text = "Num 1\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(363, 102);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 1;
            label2.Text = "Num 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Honeydew;
            label3.Location = new Point(75, 9);
            label3.Name = "label3";
            label3.Size = new Size(355, 56);
            label3.TabIndex = 2;
            label3.Text = "CALCULATOR";
            // 
            // Num1_txt
            // 
            Num1_txt.BorderStyle = BorderStyle.FixedSingle;
            Num1_txt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Num1_txt.Location = new Point(85, 138);
            Num1_txt.Name = "Num1_txt";
            Num1_txt.Size = new Size(125, 34);
            Num1_txt.TabIndex = 3;
            // 
            // Num2_txt
            // 
            Num2_txt.BorderStyle = BorderStyle.FixedSingle;
            Num2_txt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Num2_txt.Location = new Point(292, 138);
            Num2_txt.Name = "Num2_txt";
            Num2_txt.Size = new Size(125, 34);
            Num2_txt.TabIndex = 4;
            Num2_txt.KeyPress += Num2_txt_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(143, 208);
            button1.Name = "button1";
            button1.Size = new Size(70, 53);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Eras Demi ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(219, 208);
            button2.Name = "button2";
            button2.Size = new Size(70, 53);
            button2.TabIndex = 6;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(295, 208);
            button3.Name = "button3";
            button3.Size = new Size(70, 53);
            button3.TabIndex = 7;
            button3.Text = "/";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(295, 267);
            button4.Name = "button4";
            button4.Size = new Size(70, 53);
            button4.TabIndex = 10;
            button4.Text = " √x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(219, 267);
            button5.Name = "button5";
            button5.Size = new Size(70, 53);
            button5.TabIndex = 9;
            button5.Text = " x²";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(143, 267);
            button6.Name = "button6";
            button6.Size = new Size(70, 53);
            button6.TabIndex = 8;
            button6.Text = "x";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Ans_lbl
            // 
            Ans_lbl.AutoSize = true;
            Ans_lbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Ans_lbl.Location = new Point(196, 347);
            Ans_lbl.Name = "Ans_lbl";
            Ans_lbl.Size = new Size(40, 46);
            Ans_lbl.TabIndex = 11;
            Ans_lbl.Text = "0";
            // 
            // button7
            // 
            button7.BackColor = Color.Cyan;
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(196, 425);
            button7.Name = "button7";
            button7.Size = new Size(108, 38);
            button7.TabIndex = 12;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(501, 475);
            Controls.Add(button7);
            Controls.Add(Ans_lbl);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Num2_txt);
            Controls.Add(Num1_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Num1_txt;
        private TextBox Num2_txt;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label Ans_lbl;
        private Button button7;
    }
}