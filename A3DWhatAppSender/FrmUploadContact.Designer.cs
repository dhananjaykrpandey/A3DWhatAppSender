namespace A3DWhatAppSender
{
    partial class FrmUploadContact
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
            GridViewTextBoxColumn gridViewTextBoxColumn13 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn14 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn15 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn16 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition4 = new TableViewDefinition();
            radPanel1 = new RadPanel();
            RdBtnReset = new RadButton();
            RdBtnSave = new RadButton();
            radLabel2 = new RadLabel();
            RdBtnAppend = new RadButton();
            RdBtnPaste = new RadButton();
            radLabel1 = new RadLabel();
            RdGridViewList = new RadGridView();
            clipboard = new WK.Libraries.SharpClipboardNS.SharpClipboard(components);
            ((ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            ((ISupportInitialize)RdBtnReset).BeginInit();
            ((ISupportInitialize)RdBtnSave).BeginInit();
            ((ISupportInitialize)radLabel2).BeginInit();
            ((ISupportInitialize)RdBtnAppend).BeginInit();
            ((ISupportInitialize)RdBtnPaste).BeginInit();
            ((ISupportInitialize)radLabel1).BeginInit();
            ((ISupportInitialize)RdGridViewList).BeginInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radPanel1
            // 
            radPanel1.Controls.Add(RdBtnReset);
            radPanel1.Controls.Add(RdBtnSave);
            radPanel1.Controls.Add(radLabel2);
            radPanel1.Controls.Add(RdBtnAppend);
            radPanel1.Controls.Add(RdBtnPaste);
            radPanel1.Controls.Add(radLabel1);
            radPanel1.Dock = DockStyle.Top;
            radPanel1.Location = new Point(0, 0);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(884, 100);
            radPanel1.TabIndex = 0;
            // 
            // RdBtnReset
            // 
            RdBtnReset.BackColor = Color.Transparent;
            RdBtnReset.Cursor = Cursors.Hand;
            RdBtnReset.ForeColor = Color.FromArgb(21, 66, 139);
            RdBtnReset.ImageAlignment = ContentAlignment.MiddleCenter;
            RdBtnReset.Location = new Point(351, 68);
            RdBtnReset.Name = "RdBtnReset";
            RdBtnReset.Size = new Size(151, 24);
            RdBtnReset.TabIndex = 6;
            RdBtnReset.Text = "Reset/Clear Data";
            RdBtnReset.TextAlignment = ContentAlignment.MiddleLeft;
            RdBtnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            RdBtnReset.ThemeName = "Fluent";
            RdBtnReset.Click += RdBtnReset_Click;
            // 
            // RdBtnSave
            // 
            RdBtnSave.BackColor = Color.Transparent;
            RdBtnSave.Cursor = Cursors.Hand;
            RdBtnSave.ForeColor = Color.FromArgb(21, 66, 139);
            RdBtnSave.ImageAlignment = ContentAlignment.MiddleCenter;
            RdBtnSave.Location = new Point(235, 68);
            RdBtnSave.Name = "RdBtnSave";
            RdBtnSave.Size = new Size(110, 24);
            RdBtnSave.TabIndex = 6;
            RdBtnSave.Text = "Save";
            RdBtnSave.TextAlignment = ContentAlignment.MiddleLeft;
            RdBtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            RdBtnSave.ThemeName = "Fluent";
            RdBtnSave.Click += RdBtnSave_Click;
            // 
            // radLabel2
            // 
            radLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Red;
            radLabel2.Location = new Point(9, 41);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(396, 21);
            radLabel2.TabIndex = 4;
            radLabel2.Text = "Note** - Excel file columns should be same order as shown in grid";
            // 
            // RdBtnAppend
            // 
            RdBtnAppend.BackColor = Color.Transparent;
            RdBtnAppend.Cursor = Cursors.Hand;
            RdBtnAppend.ForeColor = Color.FromArgb(21, 66, 139);
            RdBtnAppend.ImageAlignment = ContentAlignment.MiddleCenter;
            RdBtnAppend.Location = new Point(119, 68);
            RdBtnAppend.Name = "RdBtnAppend";
            RdBtnAppend.Size = new Size(110, 24);
            RdBtnAppend.TabIndex = 5;
            RdBtnAppend.Text = "Append";
            RdBtnAppend.TextAlignment = ContentAlignment.MiddleLeft;
            RdBtnAppend.TextImageRelation = TextImageRelation.ImageBeforeText;
            RdBtnAppend.ThemeName = "Fluent";
            RdBtnAppend.Click += RdBtnAppend_Click;
            // 
            // RdBtnPaste
            // 
            RdBtnPaste.BackColor = Color.Transparent;
            RdBtnPaste.Cursor = Cursors.Hand;
            RdBtnPaste.ForeColor = Color.FromArgb(21, 66, 139);
            RdBtnPaste.ImageAlignment = ContentAlignment.MiddleCenter;
            RdBtnPaste.Location = new Point(3, 68);
            RdBtnPaste.Name = "RdBtnPaste";
            RdBtnPaste.Size = new Size(110, 24);
            RdBtnPaste.TabIndex = 4;
            RdBtnPaste.Text = "Paste";
            RdBtnPaste.TextAlignment = ContentAlignment.MiddleLeft;
            RdBtnPaste.TextImageRelation = TextImageRelation.ImageBeforeText;
            RdBtnPaste.ThemeName = "Fluent";
            RdBtnPaste.Click += RdBtnPaste_Click;
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            radLabel1.ForeColor = Color.Blue;
            radLabel1.Location = new Point(3, 3);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(530, 31);
            radLabel1.TabIndex = 3;
            radLabel1.Text = "Copy Data from Excel file and Click Paste/Append Button.";
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
            RdGridViewList.Location = new Point(0, 100);
            // 
            // 
            // 
            RdGridViewList.MasterTemplate.AllowAddNewRow = false;
            RdGridViewList.MasterTemplate.AllowDeleteRow = false;
            RdGridViewList.MasterTemplate.AllowEditRow = false;
            RdGridViewList.MasterTemplate.AllowSearchRow = true;
            RdGridViewList.MasterTemplate.AutoGenerateColumns = false;
            RdGridViewList.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "Id";
            gridViewTextBoxColumn13.HeaderText = "ID";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "Id";
            gridViewTextBoxColumn13.Width = 19;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "Name";
            gridViewTextBoxColumn14.HeaderText = "Full Name";
            gridViewTextBoxColumn14.Name = "Name";
            gridViewTextBoxColumn14.Width = 415;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "ContactPhone";
            gridViewTextBoxColumn15.HeaderText = "Contact Phone";
            gridViewTextBoxColumn15.Name = "ContactPhone";
            gridViewTextBoxColumn15.Width = 222;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FieldName = "IsActive";
            gridViewCheckBoxColumn4.HeaderText = "Is Active";
            gridViewCheckBoxColumn4.HeaderTextAlignment = ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "IsActive";
            gridViewCheckBoxColumn4.ReadOnly = true;
            gridViewCheckBoxColumn4.Width = 90;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "ContactEmail";
            gridViewTextBoxColumn16.HeaderText = "Contact Email";
            gridViewTextBoxColumn16.Name = "ContactEmail";
            gridViewTextBoxColumn16.Width = 139;
            RdGridViewList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn13, gridViewTextBoxColumn14, gridViewTextBoxColumn15, gridViewCheckBoxColumn4, gridViewTextBoxColumn16 });
            RdGridViewList.MasterTemplate.EnableAlternatingRowColor = true;
            RdGridViewList.MasterTemplate.EnableCustomFiltering = true;
            RdGridViewList.MasterTemplate.EnableFiltering = true;
            RdGridViewList.MasterTemplate.ViewDefinition = tableViewDefinition4;
            RdGridViewList.Name = "RdGridViewList";
            RdGridViewList.RightToLeft = RightToLeft.No;
            RdGridViewList.Size = new Size(884, 52);
            RdGridViewList.TabIndex = 3;
            // 
            // clipboard
            // 
            clipboard.MonitorClipboard = true;
            clipboard.ObservableFormats.All = false;
            clipboard.ObservableFormats.Files = false;
            clipboard.ObservableFormats.Images = false;
            clipboard.ObservableFormats.Others = false;
            clipboard.ObservableFormats.Texts = true;
            clipboard.ObserveLastEntry = true;
            clipboard.Tag = null;
            clipboard.ClipboardChanged += sharpClipboard1_ClipboardChanged;
            // 
            // FrmUploadContact
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 152);
            Controls.Add(RdGridViewList);
            Controls.Add(radPanel1);
            Name = "FrmUploadContact";
            Text = "Upload Contact";
            Load += FrmUploadContact_Load;
            ((ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            radPanel1.PerformLayout();
            ((ISupportInitialize)RdBtnReset).EndInit();
            ((ISupportInitialize)RdBtnSave).EndInit();
            ((ISupportInitialize)radLabel2).EndInit();
            ((ISupportInitialize)RdBtnAppend).EndInit();
            ((ISupportInitialize)RdBtnPaste).EndInit();
            ((ISupportInitialize)radLabel1).EndInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).EndInit();
            ((ISupportInitialize)RdGridViewList).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RadPanel radPanel1;
        private RadButton RdBtnAppend;
        private RadButton RdBtnPaste;
        private RadLabel radLabel1;
        private RadLabel radLabel2;
        private RadButton RdBtnReset;
        private RadButton RdBtnSave;
        private RadGridView RdGridViewList;
        private WK.Libraries.SharpClipboardNS.SharpClipboard clipboard;
    }
}