namespace RestaurantAK
{
    partial class fMain
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
            Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblogobig2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnItems = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHoadon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblogobig = new System.Windows.Forms.Label();
            this.pnKEdoc = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userControlReportItem1 = new RestaurantAK.UserController.UserControlReportItem();
            this.userControlSanPham1 = new RestaurantAK.UserController.UserControlSanPham();
            this.userControlHoaDon1 = new RestaurantAK.UserController.UserControlHoaDon();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeadder = new System.Windows.Forms.Panel();
            this.btnmmu = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnMiMax = new System.Windows.Forms.PictureBox();
            this.lblogo2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbLogo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelHeadder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmmu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 20;
            bunifuElipse1.TargetControl = this;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pnMenu.Controls.Add(this.lblogobig2);
            this.pnMenu.Controls.Add(this.btnReport);
            this.pnMenu.Controls.Add(this.btnItems);
            this.pnMenu.Controls.Add(this.btnHoadon);
            this.pnMenu.Controls.Add(this.lblogobig);
            this.pnMenu.Controls.Add(this.pnKEdoc);
            this.bunifuTransition1.SetDecoration(this.pnMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(210, 800);
            this.pnMenu.TabIndex = 0;
            // 
            // lblogobig2
            // 
            this.lblogobig2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblogobig2, BunifuAnimatorNS.DecorationType.None);
            this.lblogobig2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogobig2.ForeColor = System.Drawing.Color.White;
            this.lblogobig2.Location = new System.Drawing.Point(86, 66);
            this.lblogobig2.Name = "lblogobig2";
            this.lblogobig2.Size = new System.Drawing.Size(85, 19);
            this.lblogobig2.TabIndex = 2;
            this.lblogobig2.Text = "Restaurant";
            // 
            // btnReport
            // 
            this.btnReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.BorderRadius = 0;
            this.btnReport.ButtonText = "Report ";
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnReport, BunifuAnimatorNS.DecorationType.None);
            this.btnReport.DisabledColor = System.Drawing.Color.Gray;
            this.btnReport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReport.Iconimage")));
            this.btnReport.Iconimage_right = null;
            this.btnReport.Iconimage_right_Selected = null;
            this.btnReport.Iconimage_Selected = null;
            this.btnReport.IconMarginLeft = 5;
            this.btnReport.IconMarginRight = 0;
            this.btnReport.IconRightVisible = false;
            this.btnReport.IconRightZoom = 0D;
            this.btnReport.IconVisible = true;
            this.btnReport.IconZoom = 80D;
            this.btnReport.IsTab = true;
            this.btnReport.Location = new System.Drawing.Point(21, 227);
            this.btnReport.Name = "btnReport";
            this.btnReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnReport.OnHovercolor = System.Drawing.Color.Gray;
            this.btnReport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReport.selected = false;
            this.btnReport.Size = new System.Drawing.Size(180, 45);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report ";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.Textcolor = System.Drawing.Color.White;
            this.btnReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnItems
            // 
            this.btnItems.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItems.BorderRadius = 0;
            this.btnItems.ButtonText = "Sản phẩm";
            this.btnItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnItems, BunifuAnimatorNS.DecorationType.None);
            this.btnItems.DisabledColor = System.Drawing.Color.Gray;
            this.btnItems.Iconcolor = System.Drawing.Color.Transparent;
            this.btnItems.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnItems.Iconimage")));
            this.btnItems.Iconimage_right = null;
            this.btnItems.Iconimage_right_Selected = null;
            this.btnItems.Iconimage_Selected = null;
            this.btnItems.IconMarginLeft = 5;
            this.btnItems.IconMarginRight = 0;
            this.btnItems.IconRightVisible = false;
            this.btnItems.IconRightZoom = 0D;
            this.btnItems.IconVisible = true;
            this.btnItems.IconZoom = 80D;
            this.btnItems.IsTab = true;
            this.btnItems.Location = new System.Drawing.Point(21, 176);
            this.btnItems.Name = "btnItems";
            this.btnItems.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnItems.OnHovercolor = System.Drawing.Color.Gray;
            this.btnItems.OnHoverTextColor = System.Drawing.Color.White;
            this.btnItems.selected = false;
            this.btnItems.Size = new System.Drawing.Size(180, 45);
            this.btnItems.TabIndex = 6;
            this.btnItems.Text = "Sản phẩm";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnItems.Textcolor = System.Drawing.Color.White;
            this.btnItems.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnHoadon
            // 
            this.btnHoadon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnHoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoadon.BorderRadius = 0;
            this.btnHoadon.ButtonText = "Hóa đơn";
            this.btnHoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnHoadon, BunifuAnimatorNS.DecorationType.None);
            this.btnHoadon.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoadon.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoadon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHoadon.Iconimage")));
            this.btnHoadon.Iconimage_right = null;
            this.btnHoadon.Iconimage_right_Selected = null;
            this.btnHoadon.Iconimage_Selected = null;
            this.btnHoadon.IconMarginLeft = 5;
            this.btnHoadon.IconMarginRight = 0;
            this.btnHoadon.IconRightVisible = false;
            this.btnHoadon.IconRightZoom = 0D;
            this.btnHoadon.IconVisible = true;
            this.btnHoadon.IconZoom = 80D;
            this.btnHoadon.IsTab = true;
            this.btnHoadon.Location = new System.Drawing.Point(21, 125);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnHoadon.OnHovercolor = System.Drawing.Color.Gray;
            this.btnHoadon.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHoadon.selected = true;
            this.btnHoadon.Size = new System.Drawing.Size(180, 45);
            this.btnHoadon.TabIndex = 1;
            this.btnHoadon.Text = "Hóa đơn";
            this.btnHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHoadon.Textcolor = System.Drawing.Color.White;
            this.btnHoadon.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.Click += new System.EventHandler(this.btnHoadon_Click);
            // 
            // lblogobig
            // 
            this.bunifuTransition1.SetDecoration(this.lblogobig, BunifuAnimatorNS.DecorationType.None);
            this.lblogobig.Font = new System.Drawing.Font("VNI-HLThuphap", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogobig.ForeColor = System.Drawing.Color.White;
            this.lblogobig.Location = new System.Drawing.Point(8, 5);
            this.lblogobig.Name = "lblogobig";
            this.lblogobig.Size = new System.Drawing.Size(82, 80);
            this.lblogobig.TabIndex = 5;
            this.lblogobig.Text = "AK";
            // 
            // pnKEdoc
            // 
            this.pnKEdoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.bunifuTransition1.SetDecoration(this.pnKEdoc, BunifuAnimatorNS.DecorationType.None);
            this.pnKEdoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnKEdoc.Location = new System.Drawing.Point(202, 0);
            this.pnKEdoc.Name = "pnKEdoc";
            this.pnKEdoc.Size = new System.Drawing.Size(8, 800);
            this.pnKEdoc.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel3.Controls.Add(this.userControlReportItem1);
            this.panel3.Controls.Add(this.userControlSanPham1);
            this.panel3.Controls.Add(this.userControlHoaDon1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panelHeadder);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(210, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 800);
            this.panel3.TabIndex = 2;
            // 
            // userControlReportItem1
            // 
            this.bunifuTransition1.SetDecoration(this.userControlReportItem1, BunifuAnimatorNS.DecorationType.None);
            this.userControlReportItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReportItem1.Location = new System.Drawing.Point(0, 85);
            this.userControlReportItem1.Name = "userControlReportItem1";
            this.userControlReportItem1.Size = new System.Drawing.Size(990, 715);
            this.userControlReportItem1.TabIndex = 6;
            // 
            // userControlSanPham1
            // 
            this.bunifuTransition1.SetDecoration(this.userControlSanPham1, BunifuAnimatorNS.DecorationType.None);
            this.userControlSanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSanPham1.Location = new System.Drawing.Point(0, 85);
            this.userControlSanPham1.Name = "userControlSanPham1";
            this.userControlSanPham1.Size = new System.Drawing.Size(990, 715);
            this.userControlSanPham1.TabIndex = 5;
            // 
            // userControlHoaDon1
            // 
            this.bunifuTransition1.SetDecoration(this.userControlHoaDon1, BunifuAnimatorNS.DecorationType.None);
            this.userControlHoaDon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHoaDon1.Location = new System.Drawing.Point(0, 85);
            this.userControlHoaDon1.Name = "userControlHoaDon1";
            this.userControlHoaDon1.Size = new System.Drawing.Size(990, 715);
            this.userControlHoaDon1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 50);
            this.panel1.TabIndex = 1;
            // 
            // panelHeadder
            // 
            this.panelHeadder.BackColor = System.Drawing.Color.White;
            this.panelHeadder.Controls.Add(this.btnmmu);
            this.panelHeadder.Controls.Add(this.btnMini);
            this.panelHeadder.Controls.Add(this.btnMiMax);
            this.panelHeadder.Controls.Add(this.lblogo2);
            this.panelHeadder.Controls.Add(this.lbLogo);
            this.panelHeadder.Controls.Add(this.btnClose);
            this.bunifuTransition1.SetDecoration(this.panelHeadder, BunifuAnimatorNS.DecorationType.None);
            this.panelHeadder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadder.Location = new System.Drawing.Point(0, 0);
            this.panelHeadder.Name = "panelHeadder";
            this.panelHeadder.Size = new System.Drawing.Size(990, 35);
            this.panelHeadder.TabIndex = 0;
            // 
            // btnmmu
            // 
            this.btnmmu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnmmu, BunifuAnimatorNS.DecorationType.None);
            this.btnmmu.Image = ((System.Drawing.Image)(resources.GetObject("btnmmu.Image")));
            this.btnmmu.Location = new System.Drawing.Point(6, 8);
            this.btnmmu.Name = "btnmmu";
            this.btnmmu.Size = new System.Drawing.Size(26, 20);
            this.btnmmu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmmu.TabIndex = 0;
            this.btnmmu.TabStop = false;
            this.btnmmu.Click += new System.EventHandler(this.btnmmu_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMini, BunifuAnimatorNS.DecorationType.None);
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(878, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(30, 30);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 9;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnMiMax
            // 
            this.btnMiMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMiMax, BunifuAnimatorNS.DecorationType.None);
            this.btnMiMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMiMax.Image")));
            this.btnMiMax.Location = new System.Drawing.Point(914, 2);
            this.btnMiMax.Name = "btnMiMax";
            this.btnMiMax.Size = new System.Drawing.Size(30, 30);
            this.btnMiMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMiMax.TabIndex = 8;
            this.btnMiMax.TabStop = false;
            this.btnMiMax.Click += new System.EventHandler(this.btnMiMax_Click);
            // 
            // lblogo2
            // 
            this.lblogo2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblogo2, BunifuAnimatorNS.DecorationType.None);
            this.lblogo2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogo2.ForeColor = System.Drawing.Color.Black;
            this.lblogo2.Location = new System.Drawing.Point(67, 13);
            this.lblogo2.Name = "lblogo2";
            this.lblogo2.Size = new System.Drawing.Size(85, 19);
            this.lblogo2.TabIndex = 7;
            this.lblogo2.Text = "Restaurant";
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbLogo, BunifuAnimatorNS.DecorationType.None);
            this.lbLogo.Font = new System.Drawing.Font("VNI-HLThuphap", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.Color.Black;
            this.lbLogo.Location = new System.Drawing.Point(33, -3);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(48, 56);
            this.lbLogo.TabIndex = 6;
            this.lbLogo.Text = "AK";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(950, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.MaxAnimationTime = 500;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeadder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnMenu);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelHeadder.ResumeLayout(false);
            this.panelHeadder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmmu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoadon;
        private Bunifu.Framework.UI.BunifuCustomLabel lblogobig2;
        private System.Windows.Forms.Panel pnKEdoc;
        private System.Windows.Forms.Label lblogobig;
        private System.Windows.Forms.Panel panelHeadder;
        private System.Windows.Forms.PictureBox btnmmu;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnItems;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label lbLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblogo2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private UserController.UserControlHoaDon userControlHoaDon1;
        private UserController.UserControlSanPham userControlSanPham1;
        private System.Windows.Forms.PictureBox btnMiMax;
        private System.Windows.Forms.PictureBox btnMini;
        private Bunifu.Framework.UI.BunifuFlatButton btnReport;
        private UserController.UserControlReportItem userControlReportItem1;
    }
}

