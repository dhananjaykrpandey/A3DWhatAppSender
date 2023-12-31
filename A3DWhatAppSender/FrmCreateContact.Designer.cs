﻿using A3DFontAwesome;

namespace A3DWhatAppSender
{
    partial class FrmCreateContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn5 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
            RadValidationRule radValidationRule1 = new RadValidationRule();
            RadValidationRule radValidationRule2 = new RadValidationRule();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmCreateContact));
            RdTxtName = new RadTextBox();
            RdTxtPhoneno = new RadTextBox();
            contactDetailsBindingSource = new BindingSource(components);
            RdGridViewList = new RadGridView();
            RadPageView = new RadPageView();
            RadPageViewPageList = new RadPageViewPage();
            RadPageViewPageEntry = new RadPageViewPage();
            radLabel7 = new RadLabel();
            radLabel6 = new RadLabel();
            RdChkDDGroup = new RadCheckedDropDownList();
            radLabel4 = new RadLabel();
            RdTxtID = new RadTextBox();
            radLabel5 = new RadLabel();
            RdTxtRemarks = new RadTextBox();
            radLabel3 = new RadLabel();
            radLabel2 = new RadLabel();
            RdTxtEmail = new RadTextBox();
            radLabel1 = new RadLabel();
            RadChkIsActive = new RadCheckBox();
            radValidationProvider1 = new RadValidationProvider(components);
            commandBarRowElement1 = new CommandBarRowElement();
            commandBarStripElement1 = new CommandBarStripElement();
            CmdBarBtnAdd = new CommandBarButton();
            CmdBarBtnEdit = new CommandBarButton();
            CmdBarBtnSave = new CommandBarButton();
            commandBarSeparator1 = new CommandBarSeparator();
            CmdBarBtnDelete = new CommandBarButton();
            CmdBarBtnUndo = new CommandBarButton();
            commandBarSeparator2 = new CommandBarSeparator();
            CmdBarBtnRefresh = new CommandBarButton();
            CmdBarBtnUploadExcel = new CommandBarButton();
            CmdBarBtnExport = new CommandBarButton();
            CmdBar = new RadCommandBar();
            ((ISupportInitialize)RdTxtName).BeginInit();
            ((ISupportInitialize)RdTxtPhoneno).BeginInit();
            ((ISupportInitialize)contactDetailsBindingSource).BeginInit();
            ((ISupportInitialize)RdGridViewList).BeginInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).BeginInit();
            ((ISupportInitialize)RadPageView).BeginInit();
            RadPageView.SuspendLayout();
            RadPageViewPageList.SuspendLayout();
            RadPageViewPageEntry.SuspendLayout();
            ((ISupportInitialize)radLabel7).BeginInit();
            ((ISupportInitialize)radLabel6).BeginInit();
            ((ISupportInitialize)RdChkDDGroup).BeginInit();
            ((ISupportInitialize)radLabel4).BeginInit();
            ((ISupportInitialize)RdTxtID).BeginInit();
            ((ISupportInitialize)radLabel5).BeginInit();
            ((ISupportInitialize)RdTxtRemarks).BeginInit();
            ((ISupportInitialize)radLabel3).BeginInit();
            ((ISupportInitialize)radLabel2).BeginInit();
            ((ISupportInitialize)RdTxtEmail).BeginInit();
            ((ISupportInitialize)radLabel1).BeginInit();
            ((ISupportInitialize)RadChkIsActive).BeginInit();
            ((ISupportInitialize)radValidationProvider1).BeginInit();
            ((ISupportInitialize)CmdBar).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RdTxtName
            // 
            RdTxtName.Location = new Point(114, 57);
            RdTxtName.MaxLength = 100;
            RdTxtName.Name = "RdTxtName";
            RdTxtName.NullText = "Enter contact person name";
            RdTxtName.Size = new Size(389, 20);
            RdTxtName.TabIndex = 1;
            radValidationProvider1.SetValidationRule(RdTxtName, radValidationRule1);
            // 
            // RdTxtPhoneno
            // 
            RdTxtPhoneno.Location = new Point(114, 83);
            RdTxtPhoneno.MaxLength = 13;
            RdTxtPhoneno.Name = "RdTxtPhoneno";
            RdTxtPhoneno.NullText = "Enter contact person mobile/phone number";
            RdTxtPhoneno.Size = new Size(389, 20);
            RdTxtPhoneno.TabIndex = 2;
            radValidationProvider1.SetValidationRule(RdTxtPhoneno, radValidationRule2);
            // 
            // RdGridViewList
            // 
            RdGridViewList.AllowDrop = true;
            RdGridViewList.BackColor = Color.FromArgb(233, 240, 249);
            RdGridViewList.Dock = DockStyle.Fill;
            RdGridViewList.EnableCustomFiltering = true;
            RdGridViewList.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdGridViewList.ForeColor = Color.Black;
            RdGridViewList.ImeMode = ImeMode.NoControl;
            RdGridViewList.Location = new Point(0, 0);
            // 
            // 
            // 
            RdGridViewList.MasterTemplate.AllowAddNewRow = false;
            RdGridViewList.MasterTemplate.AllowDeleteRow = false;
            RdGridViewList.MasterTemplate.AllowEditRow = false;
            RdGridViewList.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 19;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Full Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 262;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ContactPhone";
            gridViewTextBoxColumn3.HeaderText = "Contact Phone";
            gridViewTextBoxColumn3.Name = "ContactPhone";
            gridViewTextBoxColumn3.Width = 155;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "Is Active";
            gridViewCheckBoxColumn1.HeaderTextAlignment = ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn1.Width = 65;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "GroupName";
            gridViewTextBoxColumn4.HeaderText = "Group Name";
            gridViewTextBoxColumn4.Name = "GroupName";
            gridViewTextBoxColumn4.Width = 239;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ContactEmail";
            gridViewTextBoxColumn5.HeaderText = "Contact Email";
            gridViewTextBoxColumn5.Name = "ContactEmail";
            RdGridViewList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewCheckBoxColumn1, gridViewTextBoxColumn4, gridViewTextBoxColumn5 });
            RdGridViewList.MasterTemplate.EnableAlternatingRowColor = true;
            RdGridViewList.MasterTemplate.EnableCustomFiltering = true;
            RdGridViewList.MasterTemplate.EnableFiltering = true;
            RdGridViewList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            RdGridViewList.Name = "RdGridViewList";
            RdGridViewList.RightToLeft = RightToLeft.No;
            RdGridViewList.Size = new Size(1013, 266);
            RdGridViewList.TabIndex = 2;
            // 
            // RadPageView
            // 
            RadPageView.Controls.Add(RadPageViewPageList);
            RadPageView.Controls.Add(RadPageViewPageEntry);
            RadPageView.Dock = DockStyle.Fill;
            RadPageView.Location = new Point(0, 30);
            RadPageView.Name = "RadPageView";
            RadPageView.SelectedPage = RadPageViewPageEntry;
            RadPageView.Size = new Size(1052, 266);
            RadPageView.TabIndex = 1;
            ((RadPageViewStripElement)RadPageView.GetChildAt(0)).StripButtons = StripViewButtons.None;
            // 
            // RadPageViewPageList
            // 
            RadPageViewPageList.Controls.Add(RdGridViewList);
            RadPageViewPageList.ItemSize = new SizeF(125F, 28F);
            RadPageViewPageList.Location = new Point(10, 37);
            RadPageViewPageList.Name = "RadPageViewPageList";
            RadPageViewPageList.Size = new Size(1013, 266);
            RadPageViewPageList.Text = "RadPageViewPageList";
            // 
            // RadPageViewPageEntry
            // 
            RadPageViewPageEntry.Controls.Add(radLabel7);
            RadPageViewPageEntry.Controls.Add(radLabel6);
            RadPageViewPageEntry.Controls.Add(RdChkDDGroup);
            RadPageViewPageEntry.Controls.Add(radLabel4);
            RadPageViewPageEntry.Controls.Add(RdTxtID);
            RadPageViewPageEntry.Controls.Add(radLabel5);
            RadPageViewPageEntry.Controls.Add(RdTxtRemarks);
            RadPageViewPageEntry.Controls.Add(radLabel3);
            RadPageViewPageEntry.Controls.Add(radLabel2);
            RadPageViewPageEntry.Controls.Add(RdTxtEmail);
            RadPageViewPageEntry.Controls.Add(RdTxtPhoneno);
            RadPageViewPageEntry.Controls.Add(radLabel1);
            RadPageViewPageEntry.Controls.Add(RadChkIsActive);
            RadPageViewPageEntry.Controls.Add(RdTxtName);
            RadPageViewPageEntry.ItemSize = new SizeF(132F, 28F);
            RadPageViewPageEntry.Location = new Point(10, 37);
            RadPageViewPageEntry.Name = "RadPageViewPageEntry";
            RadPageViewPageEntry.Size = new Size(1031, 218);
            RadPageViewPageEntry.Text = "radPageViewPageEnter";
            // 
            // radLabel7
            // 
            radLabel7.Location = new Point(40, 246);
            radLabel7.Name = "radLabel7";
            radLabel7.Size = new Size(42, 18);
            radLabel7.TabIndex = 8;
            radLabel7.Text = "Groups";
            // 
            // radLabel6
            // 
            radLabel6.Location = new Point(40, 220);
            radLabel6.Name = "radLabel6";
            radLabel6.Size = new Size(70, 18);
            radLabel6.TabIndex = 5;
            radLabel6.Text = "Active Status";
            // 
            // RdChkDDGroup
            // 
            RdChkDDGroup.Location = new Point(114, 244);
            RdChkDDGroup.Name = "RdChkDDGroup";
            RdChkDDGroup.Size = new Size(389, 20);
            RdChkDDGroup.TabIndex = 7;
            radValidationProvider1.SetValidationRule(RdChkDDGroup, null);
            RdChkDDGroup.VisualListItemFormatting += RdChkDDGroup_VisualListItemFormatting;
            RdChkDDGroup.Leave += RdChkDDGroup_Leave;
            // 
            // radLabel4
            // 
            radLabel4.Location = new Point(40, 30);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(16, 18);
            radLabel4.TabIndex = 6;
            radLabel4.Text = "Id";
            // 
            // RdTxtID
            // 
            RdTxtID.Enabled = false;
            RdTxtID.Location = new Point(114, 31);
            RdTxtID.MaxLength = 100;
            RdTxtID.Name = "RdTxtID";
            RdTxtID.NullText = "ID";
            RdTxtID.ReadOnly = true;
            RdTxtID.Size = new Size(140, 20);
            RdTxtID.TabIndex = 0;
            radValidationProvider1.SetValidationRule(RdTxtID, null);
            // 
            // radLabel5
            // 
            radLabel5.Location = new Point(40, 135);
            radLabel5.Name = "radLabel5";
            radLabel5.Size = new Size(49, 18);
            radLabel5.TabIndex = 4;
            radLabel5.Text = "Remarks";
            // 
            // RdTxtRemarks
            // 
            RdTxtRemarks.Location = new Point(114, 136);
            RdTxtRemarks.MaxLength = 1000;
            RdTxtRemarks.Multiline = true;
            RdTxtRemarks.Name = "RdTxtRemarks";
            RdTxtRemarks.NullText = "Enter remarks";
            // 
            // 
            // 
            RdTxtRemarks.RootElement.StretchVertically = true;
            RdTxtRemarks.Size = new Size(389, 78);
            RdTxtRemarks.TabIndex = 4;
            radValidationProvider1.SetValidationRule(RdTxtRemarks, null);
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(40, 108);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(33, 18);
            radLabel3.TabIndex = 4;
            radLabel3.Text = "Email";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(40, 82);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(66, 18);
            radLabel2.TabIndex = 4;
            radLabel2.Text = "Contact No.";
            // 
            // RdTxtEmail
            // 
            RdTxtEmail.Location = new Point(114, 109);
            RdTxtEmail.MaxLength = 100;
            RdTxtEmail.Name = "RdTxtEmail";
            RdTxtEmail.NullText = "Enter contact person email address";
            RdTxtEmail.Size = new Size(389, 20);
            RdTxtEmail.TabIndex = 3;
            radValidationProvider1.SetValidationRule(RdTxtEmail, null);
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(40, 56);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(57, 18);
            radLabel1.TabIndex = 2;
            radLabel1.Text = "Full Name";
            // 
            // RadChkIsActive
            // 
            RadChkIsActive.Location = new Point(114, 220);
            RadChkIsActive.Name = "RadChkIsActive";
            RadChkIsActive.Size = new Size(62, 18);
            RadChkIsActive.TabIndex = 5;
            RadChkIsActive.Text = "Is Active";
            // 
            // radValidationProvider1
            // 
            radValidationRule1.Controls.Add(RdTxtName);
            radValidationRule1.ToolTipText = "Contact person phone name cannot be blank";
            radValidationRule1.Value = "";
            radValidationRule2.Controls.Add(RdTxtPhoneno);
            radValidationRule2.ToolTipText = "Contact person phone number cannot be blank";
            radValidationRule2.Value = "";
            radValidationProvider1.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] { radValidationRule1, radValidationRule2 });
            // 
            // commandBarRowElement1
            // 
            commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarRowElement1.MinSize = new Size(25, 25);
            commandBarRowElement1.Name = "commandBarRowElement1";
            commandBarRowElement1.Strips.AddRange(new CommandBarStripElement[] { commandBarStripElement1 });
            commandBarRowElement1.Text = "";
            commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarStripElement1.DisplayName = "commandBarStripElement1";
            commandBarStripElement1.Items.AddRange(new RadCommandBarBaseItem[] { CmdBarBtnAdd, CmdBarBtnEdit, CmdBarBtnSave, commandBarSeparator1, CmdBarBtnDelete, CmdBarBtnUndo, commandBarSeparator2, CmdBarBtnRefresh, CmdBarBtnUploadExcel, CmdBarBtnExport });
            commandBarStripElement1.Name = "commandBarStripElement1";
            commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarStripElement1.UseCompatibleTextRendering = false;
            // 
            // CmdBarBtnAdd
            // 
            CmdBarBtnAdd.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnAdd.DisplayName = "commandBarButton1";
            CmdBarBtnAdd.Image = (Image)resources.GetObject("CmdBarBtnAdd.Image");
            CmdBarBtnAdd.KeyTip = "CTRL+N";
            CmdBarBtnAdd.Name = "CmdBarBtnAdd";
            CmdBarBtnAdd.Text = "Add New Record";
            CmdBarBtnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnAdd.ToolTipText = "Add New Record (Ctrl + N)";
            CmdBarBtnAdd.UseCompatibleTextRendering = false;
            CmdBarBtnAdd.Click += CmdBarBtnAdd_Click;
            // 
            // CmdBarBtnEdit
            // 
            CmdBarBtnEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnEdit.DisplayName = "commandBarButton2";
            CmdBarBtnEdit.Image = (Image)resources.GetObject("CmdBarBtnEdit.Image");
            CmdBarBtnEdit.Name = "CmdBarBtnEdit";
            CmdBarBtnEdit.Text = "Edit Record";
            CmdBarBtnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnEdit.ToolTipText = "Edit Record  (Ctrl + E)";
            CmdBarBtnEdit.UseCompatibleTextRendering = false;
            CmdBarBtnEdit.Click += CmdBarBtnEdit_Click;
            // 
            // CmdBarBtnSave
            // 
            CmdBarBtnSave.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnSave.DisplayName = "commandBarButton3";
            CmdBarBtnSave.Image = (Image)resources.GetObject("CmdBarBtnSave.Image");
            CmdBarBtnSave.Name = "CmdBarBtnSave";
            CmdBarBtnSave.Text = "Save Chagnes";
            CmdBarBtnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnSave.ToolTipText = "Save Chagnes  (Ctrl + S)";
            CmdBarBtnSave.UseCompatibleTextRendering = false;
            CmdBarBtnSave.Click += CmdBarBtnSave_Click;
            // 
            // commandBarSeparator1
            // 
            commandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarSeparator1.DisplayName = "commandBarSeparator1";
            commandBarSeparator1.Name = "commandBarSeparator1";
            commandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarSeparator1.UseCompatibleTextRendering = false;
            commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // CmdBarBtnDelete
            // 
            CmdBarBtnDelete.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnDelete.DisplayName = "commandBarButton4";
            CmdBarBtnDelete.Image = (Image)resources.GetObject("CmdBarBtnDelete.Image");
            CmdBarBtnDelete.Name = "CmdBarBtnDelete";
            CmdBarBtnDelete.Text = "Delete Record";
            CmdBarBtnDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnDelete.ToolTipText = "Delete Record  (Ctrl + D)";
            CmdBarBtnDelete.UseCompatibleTextRendering = false;
            CmdBarBtnDelete.Click += CmdBarBtnDelete_Click;
            // 
            // CmdBarBtnUndo
            // 
            CmdBarBtnUndo.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnUndo.DisplayName = "commandBarButton5";
            CmdBarBtnUndo.Image = (Image)resources.GetObject("CmdBarBtnUndo.Image");
            CmdBarBtnUndo.Name = "CmdBarBtnUndo";
            CmdBarBtnUndo.Text = "Undo Changes";
            CmdBarBtnUndo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnUndo.ToolTipText = "Undo Changes  (Ctrl + Z)";
            CmdBarBtnUndo.UseCompatibleTextRendering = false;
            CmdBarBtnUndo.Click += CmdBarBtnUndo_Click;
            // 
            // commandBarSeparator2
            // 
            commandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarSeparator2.DisplayName = "commandBarSeparator2";
            commandBarSeparator2.Name = "commandBarSeparator2";
            commandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            commandBarSeparator2.UseCompatibleTextRendering = false;
            commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // CmdBarBtnRefresh
            // 
            CmdBarBtnRefresh.DisplayName = "commandBarButton1";
            CmdBarBtnRefresh.Image = (Image)resources.GetObject("CmdBarBtnRefresh.Image");
            CmdBarBtnRefresh.Name = "CmdBarBtnRefresh";
            CmdBarBtnRefresh.Text = "Refresh Data";
            CmdBarBtnRefresh.ToolTipText = "Refresh Data (Ctrl + R)";
            CmdBarBtnRefresh.Click += CmdBarBtnRefresh_Click;
            // 
            // CmdBarBtnUploadExcel
            // 
            CmdBarBtnUploadExcel.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnUploadExcel.DisplayName = "commandBarButton6";
            CmdBarBtnUploadExcel.Image = (Image)resources.GetObject("CmdBarBtnUploadExcel.Image");
            CmdBarBtnUploadExcel.Name = "CmdBarBtnUploadExcel";
            CmdBarBtnUploadExcel.Text = "Upload Excel";
            CmdBarBtnUploadExcel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnUploadExcel.ToolTipText = "Export Excel  (Ctrl + O)";
            CmdBarBtnUploadExcel.UseCompatibleTextRendering = false;
            CmdBarBtnUploadExcel.Visibility = ElementVisibility.Hidden;
            CmdBarBtnUploadExcel.Click += CmbBarBtnUploadExcel_Click;
            // 
            // CmdBarBtnExport
            // 
            CmdBarBtnExport.DisplayName = "commandBarButton1";
            CmdBarBtnExport.Image = (Image)resources.GetObject("CmdBarBtnExport.Image");
            CmdBarBtnExport.Name = "CmdBarBtnExport";
            CmdBarBtnExport.Text = "Export To Excle";
            CmdBarBtnExport.ToolTipText = "Export To Excle (Ctrl + L)";
            CmdBarBtnExport.Visibility = ElementVisibility.Hidden;
            // 
            // CmdBar
            // 
            CmdBar.Dock = DockStyle.Top;
            CmdBar.Location = new Point(0, 0);
            CmdBar.Name = "CmdBar";
            CmdBar.Rows.AddRange(new CommandBarRowElement[] { commandBarRowElement1 });
            CmdBar.Size = new Size(1052, 30);
            CmdBar.TabIndex = 0;
            // 
            // FrmCreateContact
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 296);
            Controls.Add(RadPageView);
            Controls.Add(CmdBar);
            KeyPreview = true;
            Name = "FrmCreateContact";
            Text = "Create Contact";
            Load += FrmCreateContact_Load;
            ((ISupportInitialize)RdTxtName).EndInit();
            ((ISupportInitialize)RdTxtPhoneno).EndInit();
            ((ISupportInitialize)contactDetailsBindingSource).EndInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).EndInit();
            ((ISupportInitialize)RdGridViewList).EndInit();
            ((ISupportInitialize)RadPageView).EndInit();
            RadPageView.ResumeLayout(false);
            RadPageViewPageList.ResumeLayout(false);
            RadPageViewPageEntry.ResumeLayout(false);
            RadPageViewPageEntry.PerformLayout();
            ((ISupportInitialize)radLabel7).EndInit();
            ((ISupportInitialize)radLabel6).EndInit();
            ((ISupportInitialize)RdChkDDGroup).EndInit();
            ((ISupportInitialize)radLabel4).EndInit();
            ((ISupportInitialize)RdTxtID).EndInit();
            ((ISupportInitialize)radLabel5).EndInit();
            ((ISupportInitialize)RdTxtRemarks).EndInit();
            ((ISupportInitialize)radLabel3).EndInit();
            ((ISupportInitialize)radLabel2).EndInit();
            ((ISupportInitialize)RdTxtEmail).EndInit();
            ((ISupportInitialize)radLabel1).EndInit();
            ((ISupportInitialize)RadChkIsActive).EndInit();
            ((ISupportInitialize)radValidationProvider1).EndInit();
            ((ISupportInitialize)CmdBar).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadGridView RdGridViewList;
        private RadPageView RadPageView;
        private RadPageViewPage RadPageViewPageList;
        private RadPageViewPage RadPageViewPageEntry;
        private RadCheckBox RadChkIsActive;
        private RadTextBox RdTxtName;
        private RadLabel radLabel1;
        private RadLabel radLabel3;
        private RadLabel radLabel2;
        private RadTextBox RdTxtEmail;
        private RadTextBox RdTxtPhoneno;
        private RadLabel radLabel5;
        private RadTextBox RdTxtRemarks;
        private RadValidationProvider radValidationProvider1;
        private BindingSource contactDetailsBindingSource;
        private RadLabel radLabel4;
        private RadTextBox RdTxtID;
        private CommandBarRowElement commandBarRowElement1;
        private CommandBarStripElement commandBarStripElement1;
        private CommandBarButton CmdBarBtnAdd;
        private CommandBarButton CmdBarBtnEdit;
        private CommandBarButton CmdBarBtnSave;
        private CommandBarSeparator commandBarSeparator1;
        private CommandBarButton CmdBarBtnDelete;
        private CommandBarButton CmdBarBtnUndo;
        private CommandBarSeparator commandBarSeparator2;
        private CommandBarButton CmdBarBtnUploadExcel;
        private RadCommandBar CmdBar;
        private CommandBarButton CmdBarBtnRefresh;
        private CommandBarButton CmdBarBtnExport;
        private RadLabel radLabel7;
        private RadLabel radLabel6;
        private RadCheckedDropDownList RdChkDDGroup;
    }
}