namespace TaoFrom
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
            lvDS = new ListView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDong = new Button();
            SuspendLayout();
            // 
            // lvDS
            // 
            lvDS.Location = new Point(12, 12);
            lvDS.Name = "lvDS";
            lvDS.Size = new Size(584, 426);
            lvDS.TabIndex = 0;
            lvDS.UseCompatibleStateImageBehavior = false;
            lvDS.SelectedIndexChanged += lvDS_SelectedIndexChanged;
            lvDS.DoubleClick += lvDS_DoubleClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(624, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 49);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(624, 127);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(164, 49);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(624, 212);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 49);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(624, 293);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(164, 49);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lvDS);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvDS;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDong;
    }
}
