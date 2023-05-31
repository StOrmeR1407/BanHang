namespace BanHang
{
    partial class Main
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.NhanVien = new System.Windows.Forms.TabPage();
            this.DoiTac = new System.Windows.Forms.TabPage();
            this.GiaoDich = new System.Windows.Forms.TabPage();
            this.HangHoa = new System.Windows.Forms.TabPage();
            this.TongQuan = new System.Windows.Forms.TabPage();
            this.Container = new System.Windows.Forms.Panel();
            this.HangHoa_table = new System.Windows.Forms.DataGridView();
            this.Search_tb = new System.Windows.Forms.RichTextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.infohang_pn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tenhang_tb = new System.Windows.Forms.RichTextBox();
            this.mahang_tb = new System.Windows.Forms.TextBox();
            this.macongty_tb = new System.Windows.Forms.TextBox();
            this.maloaihang_tb = new System.Windows.Forms.TextBox();
            this.soluong_tb = new System.Windows.Forms.TextBox();
            this.donvitinh_tb = new System.Windows.Forms.TextBox();
            this.giahang_tb = new System.Windows.Forms.TextBox();
            this.Close_infohang_btn = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.HangHoa.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoa_table)).BeginInit();
            this.infohang_pn.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.TongQuan);
            this.MainTab.Controls.Add(this.HangHoa);
            this.MainTab.Controls.Add(this.GiaoDich);
            this.MainTab.Controls.Add(this.DoiTac);
            this.MainTab.Controls.Add(this.NhanVien);
            this.MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.ItemSize = new System.Drawing.Size(200, 50);
            this.MainTab.Location = new System.Drawing.Point(11, 33);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1723, 858);
            this.MainTab.TabIndex = 0;
            // 
            // NhanVien
            // 
            this.NhanVien.BackColor = System.Drawing.Color.White;
            this.NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhanVien.Location = new System.Drawing.Point(4, 54);
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Size = new System.Drawing.Size(1735, 789);
            this.NhanVien.TabIndex = 4;
            this.NhanVien.Text = "     Nhân Viên     ";
            // 
            // DoiTac
            // 
            this.DoiTac.Location = new System.Drawing.Point(4, 54);
            this.DoiTac.Name = "DoiTac";
            this.DoiTac.Size = new System.Drawing.Size(1735, 568);
            this.DoiTac.TabIndex = 3;
            this.DoiTac.Text = "     Đối Tác     ";
            this.DoiTac.UseVisualStyleBackColor = true;
            // 
            // GiaoDich
            // 
            this.GiaoDich.Location = new System.Drawing.Point(4, 54);
            this.GiaoDich.Name = "GiaoDich";
            this.GiaoDich.Size = new System.Drawing.Size(1735, 568);
            this.GiaoDich.TabIndex = 2;
            this.GiaoDich.Text = "     Giao Dịch     ";
            this.GiaoDich.UseVisualStyleBackColor = true;
            // 
            // HangHoa
            // 
            this.HangHoa.Controls.Add(this.infohang_pn);
            this.HangHoa.Controls.Add(this.comboBox1);
            this.HangHoa.Controls.Add(this.button3);
            this.HangHoa.Controls.Add(this.button2);
            this.HangHoa.Controls.Add(this.button1);
            this.HangHoa.Controls.Add(this.Search_btn);
            this.HangHoa.Controls.Add(this.Search_tb);
            this.HangHoa.Controls.Add(this.HangHoa_table);
            this.HangHoa.Location = new System.Drawing.Point(4, 54);
            this.HangHoa.Name = "HangHoa";
            this.HangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.HangHoa.Size = new System.Drawing.Size(1715, 800);
            this.HangHoa.TabIndex = 1;
            this.HangHoa.Text = "     Hàng Hoá     ";
            this.HangHoa.UseVisualStyleBackColor = true;
            // 
            // TongQuan
            // 
            this.TongQuan.Location = new System.Drawing.Point(4, 54);
            this.TongQuan.Name = "TongQuan";
            this.TongQuan.Padding = new System.Windows.Forms.Padding(3);
            this.TongQuan.Size = new System.Drawing.Size(1735, 709);
            this.TongQuan.TabIndex = 0;
            this.TongQuan.Text = "     Tổng Quan     ";
            this.TongQuan.UseVisualStyleBackColor = true;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Container.Controls.Add(this.MainTab);
            this.Container.Location = new System.Drawing.Point(1, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1745, 903);
            this.Container.TabIndex = 1;
            // 
            // HangHoa_table
            // 
            this.HangHoa_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HangHoa_table.Location = new System.Drawing.Point(410, 83);
            this.HangHoa_table.Name = "HangHoa_table";
            this.HangHoa_table.RowHeadersWidth = 62;
            this.HangHoa_table.RowTemplate.Height = 28;
            this.HangHoa_table.Size = new System.Drawing.Size(1303, 691);
            this.HangHoa_table.TabIndex = 0;
            this.HangHoa_table.SelectionChanged += new System.EventHandler(this.HangHoa_table_SelectionChanged);
            // 
            // Search_tb
            // 
            this.Search_tb.Location = new System.Drawing.Point(410, 16);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(490, 50);
            this.Search_tb.TabIndex = 1;
            this.Search_tb.Text = "";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(920, 16);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(56, 50);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "button1";
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1325, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1416, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1503, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1588, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 6;
            // 
            // infohang_pn
            // 
            this.infohang_pn.Controls.Add(this.Close_infohang_btn);
            this.infohang_pn.Controls.Add(this.giahang_tb);
            this.infohang_pn.Controls.Add(this.donvitinh_tb);
            this.infohang_pn.Controls.Add(this.soluong_tb);
            this.infohang_pn.Controls.Add(this.maloaihang_tb);
            this.infohang_pn.Controls.Add(this.macongty_tb);
            this.infohang_pn.Controls.Add(this.mahang_tb);
            this.infohang_pn.Controls.Add(this.tenhang_tb);
            this.infohang_pn.Controls.Add(this.label7);
            this.infohang_pn.Controls.Add(this.label6);
            this.infohang_pn.Controls.Add(this.label5);
            this.infohang_pn.Controls.Add(this.label4);
            this.infohang_pn.Controls.Add(this.label3);
            this.infohang_pn.Controls.Add(this.label2);
            this.infohang_pn.Controls.Add(this.label1);
            this.infohang_pn.Location = new System.Drawing.Point(6, 83);
            this.infohang_pn.Name = "infohang_pn";
            this.infohang_pn.Size = new System.Drawing.Size(398, 530);
            this.infohang_pn.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Hàng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã Công Ty";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã Loại Hàng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giá Hàng";
            // 
            // tenhang_tb
            // 
            this.tenhang_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tenhang_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenhang_tb.Location = new System.Drawing.Point(19, 145);
            this.tenhang_tb.Name = "tenhang_tb";
            this.tenhang_tb.Size = new System.Drawing.Size(362, 83);
            this.tenhang_tb.TabIndex = 8;
            this.tenhang_tb.Text = "";
            // 
            // mahang_tb
            // 
            this.mahang_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mahang_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mahang_tb.Location = new System.Drawing.Point(202, 59);
            this.mahang_tb.Name = "mahang_tb";
            this.mahang_tb.Size = new System.Drawing.Size(179, 28);
            this.mahang_tb.TabIndex = 8;
            // 
            // macongty_tb
            // 
            this.macongty_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.macongty_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.macongty_tb.Location = new System.Drawing.Point(202, 271);
            this.macongty_tb.Name = "macongty_tb";
            this.macongty_tb.Size = new System.Drawing.Size(179, 28);
            this.macongty_tb.TabIndex = 15;
            // 
            // maloaihang_tb
            // 
            this.maloaihang_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maloaihang_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maloaihang_tb.Location = new System.Drawing.Point(202, 320);
            this.maloaihang_tb.Name = "maloaihang_tb";
            this.maloaihang_tb.Size = new System.Drawing.Size(179, 28);
            this.maloaihang_tb.TabIndex = 16;
            // 
            // soluong_tb
            // 
            this.soluong_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soluong_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.soluong_tb.Location = new System.Drawing.Point(202, 364);
            this.soluong_tb.Name = "soluong_tb";
            this.soluong_tb.Size = new System.Drawing.Size(179, 28);
            this.soluong_tb.TabIndex = 17;
            // 
            // donvitinh_tb
            // 
            this.donvitinh_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.donvitinh_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.donvitinh_tb.Location = new System.Drawing.Point(202, 410);
            this.donvitinh_tb.Name = "donvitinh_tb";
            this.donvitinh_tb.Size = new System.Drawing.Size(179, 28);
            this.donvitinh_tb.TabIndex = 18;
            // 
            // giahang_tb
            // 
            this.giahang_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.giahang_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giahang_tb.Location = new System.Drawing.Point(202, 454);
            this.giahang_tb.Name = "giahang_tb";
            this.giahang_tb.Size = new System.Drawing.Size(179, 28);
            this.giahang_tb.TabIndex = 19;
            // 
            // Close_infohang_btn
            // 
            this.Close_infohang_btn.BackColor = System.Drawing.Color.White;
            this.Close_infohang_btn.Location = new System.Drawing.Point(358, 3);
            this.Close_infohang_btn.Name = "Close_infohang_btn";
            this.Close_infohang_btn.Size = new System.Drawing.Size(37, 40);
            this.Close_infohang_btn.TabIndex = 8;
            this.Close_infohang_btn.Text = "x";
            this.Close_infohang_btn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Close_infohang_btn.UseVisualStyleBackColor = false;
            this.Close_infohang_btn.Click += new System.EventHandler(this.Close_infohang_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1747, 903);
            this.Controls.Add(this.Container);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainLoad);
            this.MainTab.ResumeLayout(false);
            this.HangHoa.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HangHoa_table)).EndInit();
            this.infohang_pn.ResumeLayout(false);
            this.infohang_pn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage TongQuan;
        private System.Windows.Forms.TabPage HangHoa;
        private System.Windows.Forms.TabPage GiaoDich;
        private System.Windows.Forms.TabPage DoiTac;
        private System.Windows.Forms.TabPage NhanVien;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.RichTextBox Search_tb;
        private System.Windows.Forms.DataGridView HangHoa_table;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel infohang_pn;
        private System.Windows.Forms.RichTextBox tenhang_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox giahang_tb;
        private System.Windows.Forms.TextBox donvitinh_tb;
        private System.Windows.Forms.TextBox soluong_tb;
        private System.Windows.Forms.TextBox maloaihang_tb;
        private System.Windows.Forms.TextBox macongty_tb;
        private System.Windows.Forms.TextBox mahang_tb;
        private System.Windows.Forms.Button Close_infohang_btn;
    }
}