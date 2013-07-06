namespace SaleApp
{
    partial class f211_gd_bill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f211_gd_bill));
            this.m_fg_gd_bill_detail = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_gd_bill = new System.Windows.Forms.Label();
            this.m_lbl_bill_seri = new System.Windows.Forms.Label();
            this.m_txt_bill_seri = new System.Windows.Forms.TextBox();
            this.m_lbl_bill_date = new System.Windows.Forms.Label();
            this.m_date_bill_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.m_lbl_tong_tien = new System.Windows.Forms.Label();
            this.m_lbl_amount = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_gd_bill_detail)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_fg_gd_bill_detail
            // 
            this.m_fg_gd_bill_detail.ColumnInfo = resources.GetString("m_fg_gd_bill_detail.ColumnInfo");
            this.m_fg_gd_bill_detail.Location = new System.Drawing.Point(12, 125);
            this.m_fg_gd_bill_detail.Name = "m_fg_gd_bill_detail";
            this.m_fg_gd_bill_detail.Size = new System.Drawing.Size(643, 198);
            this.m_fg_gd_bill_detail.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg_gd_bill_detail.Styles"));
            this.m_fg_gd_bill_detail.TabIndex = 21;
            // 
            // m_lbl_gd_bill
            // 
            this.m_lbl_gd_bill.AutoSize = true;
            this.m_lbl_gd_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_gd_bill.Location = new System.Drawing.Point(197, 24);
            this.m_lbl_gd_bill.Name = "m_lbl_gd_bill";
            this.m_lbl_gd_bill.Size = new System.Drawing.Size(263, 29);
            this.m_lbl_gd_bill.TabIndex = 22;
            this.m_lbl_gd_bill.Text = "GIAO DỊCH BÁN HÀNG";
            // 
            // m_lbl_bill_seri
            // 
            this.m_lbl_bill_seri.AutoSize = true;
            this.m_lbl_bill_seri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_bill_seri.Location = new System.Drawing.Point(441, 78);
            this.m_lbl_bill_seri.Name = "m_lbl_bill_seri";
            this.m_lbl_bill_seri.Size = new System.Drawing.Size(73, 13);
            this.m_lbl_bill_seri.TabIndex = 23;
            this.m_lbl_bill_seri.Text = "Số hóa đơn";
            // 
            // m_txt_bill_seri
            // 
            this.m_txt_bill_seri.Location = new System.Drawing.Point(537, 78);
            this.m_txt_bill_seri.Name = "m_txt_bill_seri";
            this.m_txt_bill_seri.Size = new System.Drawing.Size(100, 20);
            this.m_txt_bill_seri.TabIndex = 24;
            this.m_txt_bill_seri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_bill_date
            // 
            this.m_lbl_bill_date.AutoSize = true;
            this.m_lbl_bill_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_bill_date.Location = new System.Drawing.Point(209, 78);
            this.m_lbl_bill_date.Name = "m_lbl_bill_date";
            this.m_lbl_bill_date.Size = new System.Drawing.Size(87, 13);
            this.m_lbl_bill_date.TabIndex = 25;
            this.m_lbl_bill_date.Text = "Ngày hóa đơn";
            // 
            // m_date_bill_date
            // 
            this.m_date_bill_date.CustomFormat = "dd/MM/yyyy";
            this.m_date_bill_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_date_bill_date.Location = new System.Drawing.Point(312, 75);
            this.m_date_bill_date.Name = "m_date_bill_date";
            this.m_date_bill_date.Size = new System.Drawing.Size(110, 20);
            this.m_date_bill_date.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Thuế";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(480, 347);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_tong_tien
            // 
            this.m_lbl_tong_tien.AutoSize = true;
            this.m_lbl_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_tong_tien.Location = new System.Drawing.Point(361, 389);
            this.m_lbl_tong_tien.Name = "m_lbl_tong_tien";
            this.m_lbl_tong_tien.Size = new System.Drawing.Size(61, 13);
            this.m_lbl_tong_tien.TabIndex = 29;
            this.m_lbl_tong_tien.Text = "Tổng tiền";
            // 
            // m_lbl_amount
            // 
            this.m_lbl_amount.AutoSize = true;
            this.m_lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_amount.Location = new System.Drawing.Point(623, 389);
            this.m_lbl_amount.Name = "m_lbl_amount";
            this.m_lbl_amount.Size = new System.Drawing.Size(14, 13);
            this.m_lbl_amount.TabIndex = 30;
            this.m_lbl_amount.Text = "0";
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 429);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(656, 36);
            this.m_pnl_out_place_dm.TabIndex = 31;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(476, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 12;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(564, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // f211_gd_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(656, 465);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_lbl_amount);
            this.Controls.Add(this.m_lbl_tong_tien);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_date_bill_date);
            this.Controls.Add(this.m_lbl_bill_date);
            this.Controls.Add(this.m_txt_bill_seri);
            this.Controls.Add(this.m_lbl_bill_seri);
            this.Controls.Add(this.m_lbl_gd_bill);
            this.Controls.Add(this.m_fg_gd_bill_detail);
            this.Name = "f211_gd_bill";
            this.Text = "f211 Giao dịch bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg_gd_bill_detail)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg_gd_bill_detail;
        private System.Windows.Forms.Label m_lbl_gd_bill;
        private System.Windows.Forms.Label m_lbl_bill_seri;
        private System.Windows.Forms.TextBox m_txt_bill_seri;
        private System.Windows.Forms.Label m_lbl_bill_date;
        private System.Windows.Forms.DateTimePicker m_date_bill_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label m_lbl_tong_tien;
        private System.Windows.Forms.Label m_lbl_amount;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;

    }
}