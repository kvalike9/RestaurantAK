namespace RestaurantAK.UserController
{
    partial class UserControlReportItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlReportItem));
            this.dtpkEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpkStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnThanhToan = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpkEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpkEnd.BorderRadius = 0;
            this.dtpkEnd.ForeColor = System.Drawing.Color.White;
            this.dtpkEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkEnd.FormatCustom = null;
            this.dtpkEnd.Location = new System.Drawing.Point(612, 4);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(225, 36);
            this.dtpkEnd.TabIndex = 7;
            this.dtpkEnd.Value = new System.DateTime(2019, 4, 29, 9, 22, 28, 333);
            // 
            // dtpkStart
            // 
            this.dtpkStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpkStart.BorderRadius = 0;
            this.dtpkStart.ForeColor = System.Drawing.Color.White;
            this.dtpkStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkStart.FormatCustom = null;
            this.dtpkStart.Location = new System.Drawing.Point(37, 4);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(225, 36);
            this.dtpkStart.TabIndex = 6;
            this.dtpkStart.Value = new System.DateTime(2019, 4, 29, 9, 22, 28, 333);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.reportViewer1.IsDocumentMapWidthFixed = true;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RestaurantAK.ReportItem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(37, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 466);
            this.reportViewer1.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.ActiveBorderThickness = 1;
            this.btnThanhToan.ActiveCornerRadius = 20;
            this.btnThanhToan.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhToan.ActiveForecolor = System.Drawing.Color.White;
            this.btnThanhToan.ActiveLineColor = System.Drawing.Color.Silver;
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThanhToan.BackColor = System.Drawing.Color.Silver;
            this.btnThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.BackgroundImage")));
            this.btnThanhToan.ButtonText = "Tạo báo cáo";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThanhToan.IdleBorderThickness = 1;
            this.btnThanhToan.IdleCornerRadius = 20;
            this.btnThanhToan.IdleFillColor = System.Drawing.Color.White;
            this.btnThanhToan.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThanhToan.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThanhToan.Location = new System.Drawing.Point(366, -1);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(138, 44);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // UserControlReportItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtpkEnd);
            this.Controls.Add(this.dtpkStart);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UserControlReportItem";
            this.Size = new System.Drawing.Size(874, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker dtpkEnd;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkStart;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnThanhToan;
    }
}
