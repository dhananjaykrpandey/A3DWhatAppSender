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
            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
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
            radPanel1.Size = new Size(954, 100);
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
            gridViewTextBoxColumn2.Width = 449;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ContactPhone";
            gridViewTextBoxColumn3.HeaderText = "Contact Phone";
            gridViewTextBoxColumn3.Name = "ContactPhone";
            gridViewTextBoxColumn3.Width = 241;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "Is Active";
            gridViewCheckBoxColumn1.HeaderTextAlignment = ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn1.Width = 98;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ContactEmail";
            gridViewTextBoxColumn4.HeaderText = "Contact Email";
            gridViewTextBoxColumn4.Name = "ContactEmail";
            gridViewTextBoxColumn4.Width = 148;
            RdGridViewList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewCheckBoxColumn1, gridViewTextBoxColumn4 });
            RdGridViewList.MasterTemplate.EnableAlternatingRowColor = true;
            RdGridViewList.MasterTemplate.EnableCustomFiltering = true;
            RdGridViewList.MasterTemplate.EnableFiltering = true;
            RdGridViewList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            RdGridViewList.Name = "RdGridViewList";
            RdGridViewList.RightToLeft = RightToLeft.No;
            RdGridViewList.Size = new Size(954, 443);
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
            ClientSize = new Size(954, 543);
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