namespace BTChuong3_Bai5
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
            label1 = new Label();
            txtNhapTen = new TextBox();
            radRed = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            chkBold = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label2 = new Label();
            lblLapTrinh = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(106, 9);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(655, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(106, 122);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 24);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Green;
            radioButton2.Location = new Point(106, 174);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 24);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Green";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Blue;
            radioButton3.Location = new Point(106, 224);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(59, 24);
            radioButton3.TabIndex = 4;
            radioButton3.Text = "Blue";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(106, 278);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(65, 24);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "Black";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.Location = new Point(539, 138);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(100, 24);
            chkBold.TabIndex = 6;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            checkBox2.Location = new Point(539, 200);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(121, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "Nghiêng Italic";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            checkBox3.Location = new Point(539, 265);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(99, 24);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "Gạch chân";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 387);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 9;
            label2.Text = "Lập trình bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = SystemColors.ButtonShadow;
            lblLapTrinh.Location = new Point(129, 387);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(437, 25);
            lblLapTrinh.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(572, 370);
            button1.Name = "button1";
            button1.Size = new Size(145, 55);
            button1.TabIndex = 11;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(chkBold);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radRed);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private RadioButton radRed;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private CheckBox chkBold;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label2;
        private Label lblLapTrinh;
        private Button button1;
    }
}
