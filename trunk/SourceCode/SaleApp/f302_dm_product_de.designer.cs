namespace SaleApp
{
    partial class f302_dm_product_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f302_dm_product_de));
            this.m_cbo_category = new System.Windows.Forms.ComboBox();
            this.m_lbl_categories = new System.Windows.Forms.Label();
            this.m_txt_description = new System.Windows.Forms.TextBox();
            this.m_lblproduct_description = new System.Windows.Forms.Label();
            this.m_lblproduct_unit = new System.Windows.Forms.Label();
            this.m_txt_product_name = new System.Windows.Forms.TextBox();
            this.m_lblproduct_name = new System.Windows.Forms.Label();
            this.m_txt_product_code = new System.Windows.Forms.TextBox();
            this.m_lblproduct_code = new System.Windows.Forms.Label();
            this.mlbl_add_product = new System.Windows.Forms.Label();
            this.m_cbo_unit = new System.Windows.Forms.ComboBox();
            this.m_txt_price = new System.Windows.Forms.TextBox();
            this.m_lbl_price = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_txt_image_path = new System.Windows.Forms.TextBox();
            this.m_cmd_browse_img = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_cbo_category
            // 
            this.m_cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_category.FormattingEnabled = true;
            this.m_cbo_category.Location = new System.Drawing.Point(133, 164);
            this.m_cbo_category.Name = "m_cbo_category";
            this.m_cbo_category.Size = new System.Drawing.Size(431, 21);
            this.m_cbo_category.TabIndex = 6;
            // 
            // m_lbl_categories
            // 
            this.m_lbl_categories.AutoSize = true;
            this.m_lbl_categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_categories.Location = new System.Drawing.Point(14, 164);
            this.m_lbl_categories.Name = "m_lbl_categories";
            this.m_lbl_categories.Size = new System.Drawing.Size(67, 13);
            this.m_lbl_categories.TabIndex = 5;
            this.m_lbl_categories.Text = "Thuộc nhóm";
            // 
            // m_txt_description
            // 
            this.m_txt_description.Location = new System.Drawing.Point(133, 350);
            this.m_txt_description.Multiline = true;
            this.m_txt_description.Name = "m_txt_description";
            this.m_txt_description.Size = new System.Drawing.Size(428, 73);
            this.m_txt_description.TabIndex = 12;
            // 
            // m_lblproduct_description
            // 
            this.m_lblproduct_description.AutoSize = true;
            this.m_lblproduct_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_description.Location = new System.Drawing.Point(14, 350);
            this.m_lblproduct_description.Name = "m_lblproduct_description";
            this.m_lblproduct_description.Size = new System.Drawing.Size(34, 13);
            this.m_lblproduct_description.TabIndex = 11;
            this.m_lblproduct_description.Text = "Mô tả";
            // 
            // m_lblproduct_unit
            // 
            this.m_lblproduct_unit.AutoSize = true;
            this.m_lblproduct_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_unit.Location = new System.Drawing.Point(14, 278);
            this.m_lblproduct_unit.Name = "m_lblproduct_unit";
            this.m_lblproduct_unit.Size = new System.Drawing.Size(60, 13);
            this.m_lblproduct_unit.TabIndex = 7;
            this.m_lblproduct_unit.Text = "Đơn vị tính";
            // 
            // m_txt_product_name
            // 
            this.m_txt_product_name.Location = new System.Drawing.Point(131, 235);
            this.m_txt_product_name.Name = "m_txt_product_name";
            this.m_txt_product_name.Size = new System.Drawing.Size(430, 20);
            this.m_txt_product_name.TabIndex = 4;
            // 
            // m_lblproduct_name
            // 
            this.m_lblproduct_name.AutoSize = true;
            this.m_lblproduct_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_name.Location = new System.Drawing.Point(14, 234);
            this.m_lblproduct_name.Name = "m_lblproduct_name";
            this.m_lblproduct_name.Size = new System.Drawing.Size(74, 13);
            this.m_lblproduct_name.TabIndex = 3;
            this.m_lblproduct_name.Text = "Tên hàng hóa";
            // 
            // m_txt_product_code
            // 
            this.m_txt_product_code.Location = new System.Drawing.Point(133, 203);
            this.m_txt_product_code.Name = "m_txt_product_code";
            this.m_txt_product_code.Size = new System.Drawing.Size(149, 20);
            this.m_txt_product_code.TabIndex = 2;
            // 
            // m_lblproduct_code
            // 
            this.m_lblproduct_code.AutoSize = true;
            this.m_lblproduct_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lblproduct_code.Location = new System.Drawing.Point(14, 201);
            this.m_lblproduct_code.Name = "m_lblproduct_code";
            this.m_lblproduct_code.Size = new System.Drawing.Size(70, 13);
            this.m_lblproduct_code.TabIndex = 1;
            this.m_lblproduct_code.Text = "Mã hàng hóa";
            // 
            // mlbl_add_product
            // 
            this.mlbl_add_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.mlbl_add_product.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl_add_product.ForeColor = System.Drawing.Color.Blue;
            this.mlbl_add_product.Location = new System.Drawing.Point(0, 0);
            this.mlbl_add_product.Name = "mlbl_add_product";
            this.mlbl_add_product.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mlbl_add_product.Size = new System.Drawing.Size(605, 36);
            this.mlbl_add_product.TabIndex = 0;
            this.mlbl_add_product.Text = "THÊM HÀNG HÓA";
            this.mlbl_add_product.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_cbo_unit
            // 
            this.m_cbo_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_unit.FormattingEnabled = true;
            this.m_cbo_unit.Location = new System.Drawing.Point(131, 278);
            this.m_cbo_unit.Name = "m_cbo_unit";
            this.m_cbo_unit.Size = new System.Drawing.Size(150, 21);
            this.m_cbo_unit.TabIndex = 8;
            // 
            // m_txt_price
            // 
            this.m_txt_price.Location = new System.Drawing.Point(398, 279);
            this.m_txt_price.Name = "m_txt_price";
            this.m_txt_price.Size = new System.Drawing.Size(163, 20);
            this.m_txt_price.TabIndex = 10;
            this.m_txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_price
            // 
            this.m_lbl_price.AutoSize = true;
            this.m_lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_lbl_price.Location = new System.Drawing.Point(299, 279);
            this.m_lbl_price.Name = "m_lbl_price";
            this.m_lbl_price.Size = new System.Drawing.Size(81, 13);
            this.m_lbl_price.TabIndex = 9;
            this.m_lbl_price.Text = "Giá bán hiện tại";
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
            this.ImageList.Images.SetKeyName(22, "load_upload.png");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_save);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 438);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(605, 36);
            this.m_pnl_out_place_dm.TabIndex = 13;
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
            this.m_cmd_save.Location = new System.Drawing.Point(425, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "&Lưu";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(513, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(103, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(103, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(104, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(104, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(379, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "(*)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(14, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ảnh hàng hóa";
            // 
            // m_txt_image_path
            // 
            this.m_txt_image_path.Location = new System.Drawing.Point(131, 324);
            this.m_txt_image_path.Name = "m_txt_image_path";
            this.m_txt_image_path.Size = new System.Drawing.Size(337, 20);
            this.m_txt_image_path.TabIndex = 15;
            // 
            // m_cmd_browse_img
            // 
            this.m_cmd_browse_img.Location = new System.Drawing.Point(486, 321);
            this.m_cmd_browse_img.Name = "m_cmd_browse_img";
            this.m_cmd_browse_img.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_browse_img.TabIndex = 16;
            this.m_cmd_browse_img.Text = "Browse";
            this.m_cmd_browse_img.UseVisualStyleBackColor = true;
            this.m_cmd_browse_img.Click += new System.EventHandler(this.m_cmd_browse_img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(222, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // f302_dm_product_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_cmd_browse_img);
            this.Controls.Add(this.m_txt_image_path);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_txt_price);
            this.Controls.Add(this.m_lbl_price);
            this.Controls.Add(this.m_cbo_unit);
            this.Controls.Add(this.m_cbo_category);
            this.Controls.Add(this.m_lbl_categories);
            this.Controls.Add(this.m_txt_description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lblproduct_description);
            this.Controls.Add(this.m_lblproduct_unit);
            this.Controls.Add(this.m_txt_product_name);
            this.Controls.Add(this.m_lblproduct_name);
            this.Controls.Add(this.m_txt_product_code);
            this.Controls.Add(this.m_lblproduct_code);
            this.Controls.Add(this.mlbl_add_product);
            this.Name = "f302_dm_product_de";
            this.Text = "F302 -  Cập nhật thông tin  hàng hóa";
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbo_category;
        private System.Windows.Forms.Label m_lbl_categories;
        private System.Windows.Forms.TextBox m_txt_description;
        private System.Windows.Forms.Label m_lblproduct_description;
        private System.Windows.Forms.Label m_lblproduct_unit;
        private System.Windows.Forms.TextBox m_txt_product_name;
        private System.Windows.Forms.Label m_lblproduct_name;
        private System.Windows.Forms.TextBox m_txt_product_code;
        private System.Windows.Forms.Label m_lblproduct_code;
        private System.Windows.Forms.Label mlbl_add_product;
        private System.Windows.Forms.ComboBox m_cbo_unit;
        private System.Windows.Forms.TextBox m_txt_price;
        private System.Windows.Forms.Label m_lbl_price;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_txt_image_path;
        private System.Windows.Forms.Button m_cmd_browse_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}