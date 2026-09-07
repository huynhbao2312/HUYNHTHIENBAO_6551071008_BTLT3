namespace BTChuong3_Bai3
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
            label2 = new Label();
            lblHoTen = new Label();
            txtTen = new TextBox();
            txtHo = new TextBox();
            btnHo = new Button();
            btnTen = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 104);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ lót";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 166);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            label2.Click += label2_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.Blue;
            lblHoTen.ForeColor = Color.Yellow;
            lblHoTen.Location = new Point(2, -1);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(797, 68);
            lblHoTen.TabIndex = 2;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(255, 128, 128);
            txtTen.Location = new Point(250, 159);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(252, 27);
            txtTen.TabIndex = 3;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(250, 97);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(252, 27);
            txtHo.TabIndex = 4;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(104, 268);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(168, 67);
            btnHo.TabIndex = 5;
            btnHo.Text = "Họ lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += button1_Click;
            // 
            // btnTen
            // 
            btnTen.Location = new Point(315, 268);
            btnTen.Name = "btnTen";
            btnTen.Size = new Size(168, 67);
            btnTen.TabIndex = 6;
            btnTen.Text = "Tên";
            btnTen.UseVisualStyleBackColor = true;
            btnTen.Click += btnTen_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(529, 268);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(168, 67);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += btnHoTen_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(315, 371);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(168, 67);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoát chương trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(btnTen);
            Controls.Add(btnHo);
            Controls.Add(txtHo);
            Controls.Add(txtTen);
            Controls.Add(lblHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bài tập họ tên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblHoTen;
        private TextBox txtTen;
        private TextBox txtHo;
        private Button btnHo;
        private Button btnTen;
        private Button btnHoTen;
        private Button btnKetThuc;
    }
}
