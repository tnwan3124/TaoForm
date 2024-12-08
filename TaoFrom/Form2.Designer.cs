namespace TaoFrom
{
    partial class Form2
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
            txtMSNV = new TextBox();
            txtTenNV = new TextBox();
            txtLuongCB = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(318, 77);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(277, 27);
            txtMSNV.TabIndex = 0;
            txtMSNV.TextChanged += txtMSNV_TextChanged;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(318, 146);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(277, 27);
            txtTenNV.TabIndex = 1;
            txtTenNV.TextChanged += txtTenNV_TextChanged;
            // 
            // txtLuongCB
            // 
            txtLuongCB.Location = new Point(318, 222);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(277, 27);
            txtLuongCB.TabIndex = 2;
            txtLuongCB.TextChanged += txtLuongCB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 16);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 3;
            label1.Text = "Thông Tin Nhân Viên";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(106, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 69);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(475, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(156, 69);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 84);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 6;
            label2.Text = "Mã Số Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 153);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 229);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 8;
            label4.Text = "Lương Cơ Bản";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtLuongCB);
            Controls.Add(txtTenNV);
            Controls.Add(txtMSNV);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMSNV;
        private TextBox txtTenNV;
        private TextBox txtLuongCB;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}