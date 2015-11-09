﻿namespace QUYDX_INVENTORY.NGHIEP_VU
{
    partial class f400_phieu_chuyen_kho
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
            if(disposing && (components != null))
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_danh_sach_phieu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_lap_phieu = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.m_txt_so_phieu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_dat_ngay_chung_tu = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_sle_nhan_vien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_so_phieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_chung_tu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_chung_tu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_danh_sach_phieu);
            this.panelControl1.Controls.Add(this.m_cmd_lap_phieu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 397);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(602, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // m_cmd_danh_sach_phieu
            // 
            this.m_cmd_danh_sach_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_danh_sach_phieu.Image = global::QUYDX_INVENTORY.Properties.Resources.address_book;
            this.m_cmd_danh_sach_phieu.Location = new System.Drawing.Point(99, 2);
            this.m_cmd_danh_sach_phieu.Name = "m_cmd_danh_sach_phieu";
            this.m_cmd_danh_sach_phieu.Size = new System.Drawing.Size(168, 36);
            this.m_cmd_danh_sach_phieu.TabIndex = 1;
            this.m_cmd_danh_sach_phieu.Text = "Danh sách phiếu";
            // 
            // m_cmd_lap_phieu
            // 
            this.m_cmd_lap_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_lap_phieu.Image = global::QUYDX_INVENTORY.Properties.Resources.blue_tag;
            this.m_cmd_lap_phieu.Location = new System.Drawing.Point(2, 2);
            this.m_cmd_lap_phieu.Name = "m_cmd_lap_phieu";
            this.m_cmd_lap_phieu.Size = new System.Drawing.Size(97, 36);
            this.m_cmd_lap_phieu.TabIndex = 0;
            this.m_cmd_lap_phieu.Text = "Lập phiếu";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Thông tin phiếu nhập";
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(815, 163);
            this.layoutControlGroup2.Text = "Thông tin phiếu xuất kho";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Thông tin phiếu nhập";
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup2";
            this.layoutControlGroup3.Size = new System.Drawing.Size(815, 163);
            this.layoutControlGroup3.Text = "Thông tin phiếu xuất kho";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.CustomizationFormText = "Số chứng từ";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem1.Text = "Số phiếu xuất";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.CustomizationFormText = "Ngày chứng từ";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem2.Text = "Ngày xuất kho";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.CustomizationFormText = "Nhập vào kho";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem8.Text = "Kho xuất";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(98, 13);
            this.layoutControlItem8.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.CustomizationFormText = "Nhân viên nhập";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem3.Text = "Nhân viên xuất kho";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(98, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.CustomizationFormText = "Khách hàng";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(791, 24);
            this.layoutControlItem5.Text = "Khách hàng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(98, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_sle_nhan_vien);
            this.layoutControl1.Controls.Add(this.m_dat_ngay_chung_tu);
            this.layoutControl1.Controls.Add(this.m_txt_so_phieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(602, 397);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(602, 397);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // m_txt_so_phieu
            // 
            this.m_txt_so_phieu.Location = new System.Drawing.Point(111, 43);
            this.m_txt_so_phieu.Name = "m_txt_so_phieu";
            this.m_txt_so_phieu.Size = new System.Drawing.Size(467, 20);
            this.m_txt_so_phieu.StyleController = this.layoutControl1;
            this.m_txt_so_phieu.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.m_txt_so_phieu;
            this.layoutControlItem4.CustomizationFormText = "Số phiếu";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(558, 24);
            this.layoutControlItem4.Text = "Số phiếu";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 13);
            // 
            // m_dat_ngay_chung_tu
            // 
            this.m_dat_ngay_chung_tu.EditValue = null;
            this.m_dat_ngay_chung_tu.Location = new System.Drawing.Point(111, 67);
            this.m_dat_ngay_chung_tu.Name = "m_dat_ngay_chung_tu";
            this.m_dat_ngay_chung_tu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_ngay_chung_tu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_dat_ngay_chung_tu.Size = new System.Drawing.Size(467, 20);
            this.m_dat_ngay_chung_tu.StyleController = this.layoutControl1;
            this.m_dat_ngay_chung_tu.TabIndex = 7;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.m_dat_ngay_chung_tu;
            this.layoutControlItem6.CustomizationFormText = "Ngày chuyển kho";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(558, 24);
            this.layoutControlItem6.Text = "Ngày chuyển kho";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(83, 13);
            // 
            // m_sle_nhan_vien
            // 
            this.m_sle_nhan_vien.Location = new System.Drawing.Point(111, 91);
            this.m_sle_nhan_vien.Name = "m_sle_nhan_vien";
            this.m_sle_nhan_vien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.m_sle_nhan_vien.Properties.DisplayMember = "TEN_NHAN_VIEN";
            this.m_sle_nhan_vien.Properties.NullText = "--Chọn nhân viên--";
            this.m_sle_nhan_vien.Properties.ValueMember = "ID";
            this.m_sle_nhan_vien.Properties.View = this.searchLookUpEdit1View;
            this.m_sle_nhan_vien.Size = new System.Drawing.Size(467, 20);
            this.m_sle_nhan_vien.StyleController = this.layoutControl1;
            this.m_sle_nhan_vien.TabIndex = 8;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_NHAN_VIEN,
            this.TEN_NHAN_VIEN,
            this.SDT});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MA_NHAN_VIEN
            // 
            this.MA_NHAN_VIEN.Caption = "Mã nhân viên";
            this.MA_NHAN_VIEN.FieldName = "MA_NHAN_VIEN";
            this.MA_NHAN_VIEN.Name = "MA_NHAN_VIEN";
            this.MA_NHAN_VIEN.Visible = true;
            this.MA_NHAN_VIEN.VisibleIndex = 0;
            this.MA_NHAN_VIEN.Width = 160;
            // 
            // TEN_NHAN_VIEN
            // 
            this.TEN_NHAN_VIEN.Caption = "Tên nhân viên";
            this.TEN_NHAN_VIEN.FieldName = "TEN_NHAN_VIEN";
            this.TEN_NHAN_VIEN.Name = "TEN_NHAN_VIEN";
            this.TEN_NHAN_VIEN.Visible = true;
            this.TEN_NHAN_VIEN.VisibleIndex = 1;
            this.TEN_NHAN_VIEN.Width = 457;
            // 
            // SDT
            // 
            this.SDT.Caption = "SĐT";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 2;
            this.SDT.Width = 461;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.m_sle_nhan_vien;
            this.layoutControlItem7.CustomizationFormText = "Nhân viên";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(558, 286);
            this.layoutControlItem7.Text = "Nhân viên";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "Thông tin phiếu";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(582, 377);
            this.layoutControlGroup4.Text = "Thông tin phiếu";
            // 
            // f400_phieu_chuyen_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 437);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "f400_phieu_chuyen_kho";
            this.Text = "F400 - PHIẾU CHUYỂN KHO";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_so_phieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_chung_tu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_dat_ngay_chung_tu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_sle_nhan_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_danh_sach_phieu;
        private DevExpress.XtraEditors.SimpleButton m_cmd_lap_phieu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit m_txt_so_phieu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit m_dat_ngay_chung_tu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SearchLookUpEdit m_sle_nhan_vien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MA_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    }
}