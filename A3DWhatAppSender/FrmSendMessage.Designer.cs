namespace A3DWhatAppSender
{
    partial class FrmSendMessage
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
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn5 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();
            RadBtnSend = new RadButton();
            radSplitContainer1 = new RadSplitContainer();
            splitPanel1 = new SplitPanel();
            splitPanel2 = new SplitPanel();
            RdGridViewList = new RadGridView();
            ((ISupportInitialize)RadBtnSend).BeginInit();
            ((ISupportInitialize)radSplitContainer1).BeginInit();
            radSplitContainer1.SuspendLayout();
            ((ISupportInitialize)splitPanel1).BeginInit();
            splitPanel1.SuspendLayout();
            ((ISupportInitialize)splitPanel2).BeginInit();
            splitPanel2.SuspendLayout();
            ((ISupportInitialize)RdGridViewList).BeginInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RadBtnSend
            // 
            RadBtnSend.Location = new Point(85, 250);
            RadBtnSend.Name = "RadBtnSend";
            RadBtnSend.Size = new Size(125, 44);
            RadBtnSend.TabIndex = 0;
            RadBtnSend.Text = "Send";
            RadBtnSend.Click += RadBtnSend_Click;
            // 
            // radSplitContainer1
            // 
            radSplitContainer1.Controls.Add(splitPanel1);
            radSplitContainer1.Controls.Add(splitPanel2);
            radSplitContainer1.Dock = DockStyle.Fill;
            radSplitContainer1.IsCleanUpTarget = true;
            radSplitContainer1.Location = new Point(0, 0);
            radSplitContainer1.Name = "radSplitContainer1";
            radSplitContainer1.Padding = new Padding(5);
            // 
            // 
            // 
            radSplitContainer1.RootElement.MinSize = new Size(25, 25);
            radSplitContainer1.Size = new Size(924, 709);
            radSplitContainer1.TabIndex = 2;
            radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            splitPanel1.Controls.Add(RdGridViewList);
            splitPanel1.Location = new Point(0, 0);
            splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            splitPanel1.RootElement.MinSize = new Size(25, 25);
            splitPanel1.Size = new Size(460, 709);
            splitPanel1.SizeInfo.AutoSizeScale = new SizeF(0F, -0.21617648F);
            splitPanel1.SizeInfo.SplitterCorrection = new Size(0, -251);
            splitPanel1.TabIndex = 0;
            splitPanel1.TabStop = false;
            splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            splitPanel2.Controls.Add(RadBtnSend);
            splitPanel2.Location = new Point(464, 0);
            splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            splitPanel2.RootElement.MinSize = new Size(25, 25);
            splitPanel2.Size = new Size(460, 709);
            splitPanel2.SizeInfo.AutoSizeScale = new SizeF(0F, 0.21617645F);
            splitPanel2.SizeInfo.SplitterCorrection = new Size(0, 251);
            splitPanel2.TabIndex = 1;
            splitPanel2.TabStop = false;
            splitPanel2.Text = "splitPanel2";
            // 
            // RdGridViewList
            // 
            RdGridViewList.AllowDrop = true;
            RdGridViewList.BackColor = Color.FromArgb(233, 240, 249);
            RdGridViewList.EnableCustomFiltering = true;
            RdGridViewList.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdGridViewList.ForeColor = Color.Black;
            RdGridViewList.ImeMode = ImeMode.NoControl;
            RdGridViewList.Location = new Point(3, 85);
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
            RdGridViewList.Size = new Size(282, 385);
            RdGridViewList.TabIndex = 3;
            // 
            // FrmSendMessage
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 709);
            Controls.Add(radSplitContainer1);
            Name = "FrmSendMessage";
            Text = "FrmSendMessage";
            ((ISupportInitialize)RadBtnSend).EndInit();
            ((ISupportInitialize)radSplitContainer1).EndInit();
            radSplitContainer1.ResumeLayout(false);
            ((ISupportInitialize)splitPanel1).EndInit();
            splitPanel1.ResumeLayout(false);
            ((ISupportInitialize)splitPanel2).EndInit();
            splitPanel2.ResumeLayout(false);
            ((ISupportInitialize)RdGridViewList.MasterTemplate).EndInit();
            ((ISupportInitialize)RdGridViewList).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadButton RadBtnSend;
        private RadSplitContainer radSplitContainer1;
        private SplitPanel splitPanel1;
        private SplitPanel splitPanel2;
        private RadGridView RdGridViewList;
    }
}