namespace A3DWhatAppSender
{
    partial class FrmGroup
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
            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmGroup));
            RadPageView = new RadPageView();
            RadPageViewPageList = new RadPageViewPage();
            RdGridViewList = new RadGridView();
            RadPageViewPageEntry = new RadPageViewPage();
            radLabel4 = new RadLabel();
            RdTxtID = new RadTextBox();
            radLabel1 = new RadLabel();
            RadChkIsActive = new RadCheckBox();
            RdTxtName = new RadTextBox();
            CmdBar = new RadCommandBar();
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
            ((ISupportInitialize)RadPageView).BeginInit();
            RadPageView.SuspendLayout();
            RadPageViewPageList.SuspendLayout();
            ((ISupportInitialize)RdGridViewList).BeginInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).BeginInit();
            RadPageViewPageEntry.SuspendLayout();
            ((ISupportInitialize)radLabel4).BeginInit();
            ((ISupportInitialize)RdTxtID).BeginInit();
            ((ISupportInitialize)radLabel1).BeginInit();
            ((ISupportInitialize)RadChkIsActive).BeginInit();
            ((ISupportInitialize)RdTxtName).BeginInit();
            ((ISupportInitialize)CmdBar).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RadPageView
            // 
            RadPageView.Controls.Add(RadPageViewPageList);
            RadPageView.Controls.Add(RadPageViewPageEntry);
            RadPageView.Dock = DockStyle.Fill;
            RadPageView.Location = new Point(0, 30);
            RadPageView.Name = "RadPageView";
            RadPageView.SelectedPage = RadPageViewPageList;
            RadPageView.Size = new Size(862, 376);
            RadPageView.TabIndex = 3;
            ((RadPageViewStripElement)RadPageView.GetChildAt(0)).StripButtons = StripViewButtons.None;
            // 
            // RadPageViewPageList
            // 
            RadPageViewPageList.Controls.Add(RdGridViewList);
            RadPageViewPageList.ItemSize = new SizeF(125F, 28F);
            RadPageViewPageList.Location = new Point(10, 37);
            RadPageViewPageList.Name = "RadPageViewPageList";
            RadPageViewPageList.Size = new Size(841, 328);
            RadPageViewPageList.Text = "RadPageViewPageList";
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
            RdGridViewList.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 19;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "GroupName";
            gridViewTextBoxColumn2.HeaderText = "Group Name";
            gridViewTextBoxColumn2.Name = "GroupName";
            gridViewTextBoxColumn2.Width = 820;
            RdGridViewList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2 });
            RdGridViewList.MasterTemplate.EnableAlternatingRowColor = true;
            RdGridViewList.MasterTemplate.EnableCustomFiltering = true;
            RdGridViewList.MasterTemplate.EnableFiltering = true;
            RdGridViewList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            RdGridViewList.Name = "RdGridViewList";
            RdGridViewList.RightToLeft = RightToLeft.No;
            RdGridViewList.Size = new Size(841, 328);
            RdGridViewList.TabIndex = 2;
            // 
            // RadPageViewPageEntry
            // 
            RadPageViewPageEntry.Controls.Add(radLabel4);
            RadPageViewPageEntry.Controls.Add(RdTxtID);
            RadPageViewPageEntry.Controls.Add(radLabel1);
            RadPageViewPageEntry.Controls.Add(RadChkIsActive);
            RadPageViewPageEntry.Controls.Add(RdTxtName);
            RadPageViewPageEntry.ItemSize = new SizeF(132F, 28F);
            RadPageViewPageEntry.Location = new Point(10, 37);
            RadPageViewPageEntry.Name = "RadPageViewPageEntry";
            RadPageViewPageEntry.Size = new Size(841, 328);
            RadPageViewPageEntry.Text = "radPageViewPageEnter";
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
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(40, 56);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(71, 18);
            radLabel1.TabIndex = 2;
            radLabel1.Text = "Group Name";
            // 
            // RadChkIsActive
            // 
            RadChkIsActive.Location = new Point(114, 83);
            RadChkIsActive.Name = "RadChkIsActive";
            RadChkIsActive.Size = new Size(62, 18);
            RadChkIsActive.TabIndex = 5;
            RadChkIsActive.Text = "Is Active";
            // 
            // RdTxtName
            // 
            RdTxtName.Location = new Point(114, 57);
            RdTxtName.MaxLength = 100;
            RdTxtName.Name = "RdTxtName";
            RdTxtName.NullText = "Enter Group name";
            RdTxtName.Size = new Size(389, 20);
            RdTxtName.TabIndex = 1;
            // 
            // CmdBar
            // 
            CmdBar.Dock = DockStyle.Top;
            CmdBar.Location = new Point(0, 0);
            CmdBar.Name = "CmdBar";
            CmdBar.Rows.AddRange(new CommandBarRowElement[] { commandBarRowElement1 });
            CmdBar.Size = new Size(862, 30);
            CmdBar.TabIndex = 2;
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
            CmdBarBtnRefresh.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnRefresh.DisplayName = "commandBarButton1";
            CmdBarBtnRefresh.Image = (Image)resources.GetObject("CmdBarBtnRefresh.Image");
            CmdBarBtnRefresh.Name = "CmdBarBtnRefresh";
            CmdBarBtnRefresh.Text = "Refresh Data";
            CmdBarBtnRefresh.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnRefresh.ToolTipText = "Refresh Data (Ctrl + R)";
            CmdBarBtnRefresh.UseCompatibleTextRendering = false;
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
            // 
            // CmdBarBtnExport
            // 
            CmdBarBtnExport.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnExport.DisplayName = "commandBarButton1";
            CmdBarBtnExport.Image = (Image)resources.GetObject("CmdBarBtnExport.Image");
            CmdBarBtnExport.Name = "CmdBarBtnExport";
            CmdBarBtnExport.Text = "Export To Excle";
            CmdBarBtnExport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            CmdBarBtnExport.ToolTipText = "Export To Excle (Ctrl + L)";
            CmdBarBtnExport.UseCompatibleTextRendering = false;
            CmdBarBtnExport.Visibility = ElementVisibility.Hidden;
            // 
            // FrmGroup
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 406);
            Controls.Add(RadPageView);
            Controls.Add(CmdBar);
            Name = "FrmGroup";
            Text = "Create Group";
            Load += FrmGroup_Load;
            ((ISupportInitialize)RadPageView).EndInit();
            RadPageView.ResumeLayout(false);
            RadPageViewPageList.ResumeLayout(false);
            ((ISupportInitialize)RdGridViewList.MasterTemplate).EndInit();
            ((ISupportInitialize)RdGridViewList).EndInit();
            RadPageViewPageEntry.ResumeLayout(false);
            RadPageViewPageEntry.PerformLayout();
            ((ISupportInitialize)radLabel4).EndInit();
            ((ISupportInitialize)RdTxtID).EndInit();
            ((ISupportInitialize)radLabel1).EndInit();
            ((ISupportInitialize)RadChkIsActive).EndInit();
            ((ISupportInitialize)RdTxtName).EndInit();
            ((ISupportInitialize)CmdBar).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadPageView RadPageView;
        private RadPageViewPage RadPageViewPageList;
        private RadGridView RdGridViewList;
        private RadPageViewPage RadPageViewPageEntry;
        private RadLabel radLabel4;
        private RadTextBox RdTxtID;
        private RadLabel radLabel1;
        private RadCheckBox RadChkIsActive;
        private RadTextBox RdTxtName;
        private RadCommandBar CmdBar;
        private CommandBarRowElement commandBarRowElement1;
        private CommandBarStripElement commandBarStripElement1;
        private CommandBarButton CmdBarBtnAdd;
        private CommandBarButton CmdBarBtnEdit;
        private CommandBarButton CmdBarBtnSave;
        private CommandBarSeparator commandBarSeparator1;
        private CommandBarButton CmdBarBtnDelete;
        private CommandBarButton CmdBarBtnUndo;
        private CommandBarSeparator commandBarSeparator2;
        private CommandBarButton CmdBarBtnRefresh;
        private CommandBarButton CmdBarBtnUploadExcel;
        private CommandBarButton CmdBarBtnExport;
    }
}