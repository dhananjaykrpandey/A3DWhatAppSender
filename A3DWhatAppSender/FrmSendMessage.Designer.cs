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
            radPanel1 = new RadPanel();
            RdBtnSearch = new RadButton();
            radLabel2 = new RadLabel();
            RdTxtSearch = new RadTextBox();
            RdGridViewList = new RadGridView();
            splitPanel2 = new SplitPanel();
            radPanel3 = new RadPanel();
            radLabel4 = new RadLabel();
            radButton3 = new RadButton();
            radTextBox2 = new RadTextBox();
            radPanel2 = new RadPanel();
            radButton2 = new RadButton();
            radButton1 = new RadButton();
            radLabel3 = new RadLabel();
            radLabel1 = new RadLabel();
            radTextBox1 = new RadTextBox();
            ((ISupportInitialize)RadBtnSend).BeginInit();
            ((ISupportInitialize)radSplitContainer1).BeginInit();
            radSplitContainer1.SuspendLayout();
            ((ISupportInitialize)splitPanel1).BeginInit();
            splitPanel1.SuspendLayout();
            ((ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            ((ISupportInitialize)RdBtnSearch).BeginInit();
            ((ISupportInitialize)radLabel2).BeginInit();
            ((ISupportInitialize)RdTxtSearch).BeginInit();
            ((ISupportInitialize)RdGridViewList).BeginInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).BeginInit();
            ((ISupportInitialize)splitPanel2).BeginInit();
            splitPanel2.SuspendLayout();
            ((ISupportInitialize)radPanel3).BeginInit();
            ((ISupportInitialize)radLabel4).BeginInit();
            ((ISupportInitialize)radButton3).BeginInit();
            ((ISupportInitialize)radTextBox2).BeginInit();
            ((ISupportInitialize)radPanel2).BeginInit();
            radPanel2.SuspendLayout();
            ((ISupportInitialize)radButton2).BeginInit();
            ((ISupportInitialize)radButton1).BeginInit();
            ((ISupportInitialize)radLabel3).BeginInit();
            ((ISupportInitialize)radLabel1).BeginInit();
            ((ISupportInitialize)radTextBox1).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RadBtnSend
            // 
            RadBtnSend.Location = new Point(873, 315);
            RadBtnSend.Margin = new Padding(27, 27, 27, 27);
            RadBtnSend.Name = "RadBtnSend";
            RadBtnSend.Size = new Size(792, 207);
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
            radSplitContainer1.Padding = new Padding(45, 45, 45, 45);
            // 
            // 
            // 
            radSplitContainer1.RootElement.MinSize = new Size(0, 0);
            radSplitContainer1.Size = new Size(2585, 1117);
            radSplitContainer1.SplitterWidth = 36;
            radSplitContainer1.TabIndex = 2;
            radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            splitPanel1.Controls.Add(radPanel1);
            splitPanel1.Controls.Add(RdGridViewList);
            splitPanel1.Location = new Point(0, 0);
            splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            splitPanel1.RootElement.MinSize = new Size(0, 0);
            splitPanel1.Size = new Size(1026, 1117);
            splitPanel1.SizeInfo.AutoSizeScale = new SizeF(-0.09753594F, -0.21617648F);
            splitPanel1.SizeInfo.SplitterCorrection = new Size(-95, -251);
            splitPanel1.TabIndex = 0;
            splitPanel1.TabStop = false;
            splitPanel1.Text = "splitPanel1";
            // 
            // radPanel1
            // 
            radPanel1.Controls.Add(RdBtnSearch);
            radPanel1.Controls.Add(radLabel2);
            radPanel1.Controls.Add(RdTxtSearch);
            radPanel1.Dock = DockStyle.Top;
            radPanel1.Location = new Point(0, 0);
            radPanel1.Margin = new Padding(27, 27, 27, 27);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(1026, 666);
            radPanel1.TabIndex = 6;
            // 
            // RdBtnSearch
            // 
            RdBtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RdBtnSearch.Location = new Point(27, 315);
            RdBtnSearch.Margin = new Padding(27, 27, 27, 27);
            RdBtnSearch.Name = "RdBtnSearch";
            RdBtnSearch.Size = new Size(792, 207);
            RdBtnSearch.TabIndex = 1;
            RdBtnSearch.Text = "Search";
            // 
            // radLabel2
            // 
            radLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel2.AutoSize = false;
            radLabel2.BorderVisible = true;
            radLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radLabel2.ForeColor = Color.Red;
            radLabel2.Location = new Point(18, 27);
            radLabel2.Margin = new Padding(27, 27, 27, 27);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(972, 234);
            radLabel2.TabIndex = 5;
            radLabel2.Text = "Select contact from gird or type in serach to find contact ";
            // 
            // RdTxtSearch
            // 
            RdTxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RdTxtSearch.Location = new Point(27, 315);
            RdTxtSearch.Margin = new Padding(27, 27, 27, 27);
            RdTxtSearch.Name = "RdTxtSearch";
            RdTxtSearch.NullText = "Enter keyword to serach [press enter after typing]";
            RdTxtSearch.Size = new Size(1977, 59);
            RdTxtSearch.TabIndex = 5;
            // 
            // RdGridViewList
            // 
            RdGridViewList.AllowDrop = true;
            RdGridViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RdGridViewList.BackColor = Color.FromArgb(233, 240, 249);
            RdGridViewList.EnableCustomFiltering = true;
            RdGridViewList.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            RdGridViewList.ForeColor = Color.Black;
            RdGridViewList.ImeMode = ImeMode.NoControl;
            RdGridViewList.Location = new Point(27, 720);
            RdGridViewList.Margin = new Padding(27, 27, 27, 27);
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
            gridViewTextBoxColumn1.Width = 171;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Full Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 2358;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ContactPhone";
            gridViewTextBoxColumn3.HeaderText = "Contact Phone";
            gridViewTextBoxColumn3.Name = "ContactPhone";
            gridViewTextBoxColumn3.Width = 1395;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "Is Active";
            gridViewCheckBoxColumn1.HeaderTextAlignment = ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn1.MinWidth = 180;
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.ReadOnly = true;
            gridViewCheckBoxColumn1.Width = 585;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "GroupName";
            gridViewTextBoxColumn4.HeaderText = "Group Name";
            gridViewTextBoxColumn4.Name = "GroupName";
            gridViewTextBoxColumn4.Width = 2151;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "ContactEmail";
            gridViewTextBoxColumn5.HeaderText = "Contact Email";
            gridViewTextBoxColumn5.Name = "ContactEmail";
            gridViewTextBoxColumn5.Width = 450;
            RdGridViewList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewCheckBoxColumn1, gridViewTextBoxColumn4, gridViewTextBoxColumn5 });
            RdGridViewList.MasterTemplate.EnableAlternatingRowColor = true;
            RdGridViewList.MasterTemplate.EnableCustomFiltering = true;
            RdGridViewList.MasterTemplate.EnableFiltering = true;
            RdGridViewList.MasterTemplate.ViewDefinition = tableViewDefinition1;
            RdGridViewList.Name = "RdGridViewList";
            RdGridViewList.RightToLeft = RightToLeft.No;
            RdGridViewList.Size = new Size(954, 370);
            RdGridViewList.TabIndex = 3;
            // 
            // splitPanel2
            // 
            splitPanel2.Controls.Add(radPanel3);
            splitPanel2.Controls.Add(radLabel4);
            splitPanel2.Controls.Add(radButton3);
            splitPanel2.Controls.Add(radTextBox2);
            splitPanel2.Controls.Add(radPanel2);
            splitPanel2.Controls.Add(radLabel1);
            splitPanel2.Controls.Add(radTextBox1);
            splitPanel2.Location = new Point(1062, 0);
            splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            splitPanel2.RootElement.MinSize = new Size(0, 0);
            splitPanel2.Size = new Size(1523, 1117);
            splitPanel2.SizeInfo.AutoSizeScale = new SizeF(0.09753591F, 0.21617645F);
            splitPanel2.SizeInfo.SplitterCorrection = new Size(95, 251);
            splitPanel2.TabIndex = 1;
            splitPanel2.TabStop = false;
            splitPanel2.Text = "splitPanel2";
            // 
            // radPanel3
            // 
            radPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radPanel3.Location = new Point(81, -1061);
            radPanel3.Margin = new Padding(27, 27, 27, 27);
            radPanel3.Name = "radPanel3";
            radPanel3.Size = new Size(1334, 2151);
            radPanel3.TabIndex = 12;
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel4.Location = new Point(81, 2439);
            radLabel4.Margin = new Padding(27, 27, 27, 27);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(268, 54);
            radLabel4.TabIndex = 11;
            radLabel4.Text = "Image Or Video";
            // 
            // radButton3
            // 
            radButton3.Location = new Point(3438, 2637);
            radButton3.Margin = new Padding(27, 27, 27, 27);
            radButton3.Name = "radButton3";
            radButton3.Size = new Size(792, 207);
            radButton3.TabIndex = 9;
            radButton3.Text = "Search";
            // 
            // radTextBox2
            // 
            radTextBox2.Location = new Point(81, 2655);
            radTextBox2.Margin = new Padding(27, 27, 27, 27);
            radTextBox2.Name = "radTextBox2";
            radTextBox2.Size = new Size(3348, 59);
            radTextBox2.TabIndex = 10;
            // 
            // radPanel2
            // 
            radPanel2.Controls.Add(radButton2);
            radPanel2.Controls.Add(radButton1);
            radPanel2.Controls.Add(radLabel3);
            radPanel2.Controls.Add(RadBtnSend);
            radPanel2.Dock = DockStyle.Top;
            radPanel2.Location = new Point(0, 0);
            radPanel2.Margin = new Padding(27, 27, 27, 27);
            radPanel2.Name = "radPanel2";
            radPanel2.Size = new Size(1523, 666);
            radPanel2.TabIndex = 8;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(1719, 306);
            radButton2.Margin = new Padding(27, 27, 27, 27);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(792, 207);
            radButton2.TabIndex = 1;
            radButton2.Text = "Send";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(27, 315);
            radButton1.Margin = new Padding(27, 27, 27, 27);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(792, 207);
            radButton1.TabIndex = 1;
            radButton1.Text = "Search";
            // 
            // radLabel3
            // 
            radLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radLabel3.AutoSize = false;
            radLabel3.BorderVisible = true;
            radLabel3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radLabel3.ForeColor = Color.Red;
            radLabel3.Location = new Point(18, 27);
            radLabel3.Margin = new Padding(27, 27, 27, 27);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(1478, 234);
            radLabel3.TabIndex = 5;
            radLabel3.Text = "Select contact from gird or type in serach to find contact ";
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.Location = new Point(72, 720);
            radLabel1.Margin = new Padding(27, 27, 27, 27);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(156, 54);
            radLabel1.TabIndex = 7;
            radLabel1.Text = "Message";
            // 
            // radTextBox1
            // 
            radTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTextBox1.Location = new Point(81, 936);
            radTextBox1.Margin = new Padding(27, 27, 27, 27);
            radTextBox1.Multiline = true;
            radTextBox1.Name = "radTextBox1";
            radTextBox1.NullText = "Enter message to send selected contacts";
            // 
            // 
            // 
            radTextBox1.RootElement.StretchVertically = true;
            radTextBox1.Size = new Size(1352, 1314);
            radTextBox1.TabIndex = 6;
            // 
            // FrmSendMessage
            // 
            AutoScaleBaseSize = new Size(20, 48);
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2585, 1117);
            Controls.Add(radSplitContainer1);
            Margin = new Padding(9, 10, 9, 10);
            Name = "FrmSendMessage";
            Text = "FrmSendMessage";
            ((ISupportInitialize)RadBtnSend).EndInit();
            ((ISupportInitialize)radSplitContainer1).EndInit();
            radSplitContainer1.ResumeLayout(false);
            ((ISupportInitialize)splitPanel1).EndInit();
            splitPanel1.ResumeLayout(false);
            ((ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            radPanel1.PerformLayout();
            ((ISupportInitialize)RdBtnSearch).EndInit();
            ((ISupportInitialize)radLabel2).EndInit();
            ((ISupportInitialize)RdTxtSearch).EndInit();
            ((ISupportInitialize)RdGridViewList.MasterTemplate).EndInit();
            ((ISupportInitialize)RdGridViewList).EndInit();
            ((ISupportInitialize)splitPanel2).EndInit();
            splitPanel2.ResumeLayout(false);
            splitPanel2.PerformLayout();
            ((ISupportInitialize)radPanel3).EndInit();
            ((ISupportInitialize)radLabel4).EndInit();
            ((ISupportInitialize)radButton3).EndInit();
            ((ISupportInitialize)radTextBox2).EndInit();
            ((ISupportInitialize)radPanel2).EndInit();
            radPanel2.ResumeLayout(false);
            ((ISupportInitialize)radButton2).EndInit();
            ((ISupportInitialize)radButton1).EndInit();
            ((ISupportInitialize)radLabel3).EndInit();
            ((ISupportInitialize)radLabel1).EndInit();
            ((ISupportInitialize)radTextBox1).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RadButton RadBtnSend;
        private RadSplitContainer radSplitContainer1;
        private SplitPanel splitPanel1;
        private SplitPanel splitPanel2;
        private RadGridView RdGridViewList;
        private RadPanel radPanel1;
        private RadLabel radLabel2;
        private RadTextBox RdTxtSearch;
        private RadButton RdBtnSearch;
        private RadTextBox radTextBox1;
        private RadLabel radLabel1;
        private RadPanel radPanel2;
        private RadButton radButton2;
        private RadButton radButton1;
        private RadLabel radLabel3;
        private RadPanel radPanel3;
        private RadLabel radLabel4;
        private RadButton radButton3;
        private RadTextBox radTextBox2;
    }
}