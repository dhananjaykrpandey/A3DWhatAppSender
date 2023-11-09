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
            GridViewTextBoxColumn gridViewTextBoxColumn16 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn17 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn18 = new GridViewTextBoxColumn();
            GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new GridViewCheckBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn19 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn20 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition4 = new TableViewDefinition();
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
            RadBtnSend.Location = new Point(97, 35);
            RadBtnSend.Name = "RadBtnSend";
            RadBtnSend.Size = new Size(88, 23);
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
            radSplitContainer1.Size = new Size(978, 565);
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
            splitPanel1.RootElement.MinSize = new Size(25, 25);
            splitPanel1.Size = new Size(392, 565);
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
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(392, 74);
            radPanel1.TabIndex = 6;
            // 
            // RdBtnSearch
            // 
            RdBtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RdBtnSearch.Location = new Point(281, 35);
            RdBtnSearch.Name = "RdBtnSearch";
            RdBtnSearch.Size = new Size(88, 23);
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
            radLabel2.Location = new Point(2, 3);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(386, 26);
            radLabel2.TabIndex = 5;
            radLabel2.Text = "Select contact from gird or type in serach to find contact ";
            // 
            // RdTxtSearch
            // 
            RdTxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RdTxtSearch.Location = new Point(3, 35);
            RdTxtSearch.Name = "RdTxtSearch";
            RdTxtSearch.NullText = "Enter keyword to serach [press enter after typing]";
            RdTxtSearch.Size = new Size(277, 20);
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
            RdGridViewList.Location = new Point(3, 80);
            // 
            // 
            // 
            RdGridViewList.MasterTemplate.AllowAddNewRow = false;
            RdGridViewList.MasterTemplate.AllowDeleteRow = false;
            RdGridViewList.MasterTemplate.AllowEditRow = false;
            RdGridViewList.MasterTemplate.AllowSearchRow = true;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "Id";
            gridViewTextBoxColumn16.HeaderText = "ID";
            gridViewTextBoxColumn16.IsVisible = false;
            gridViewTextBoxColumn16.Name = "Id";
            gridViewTextBoxColumn16.Width = 19;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "Name";
            gridViewTextBoxColumn17.HeaderText = "Full Name";
            gridViewTextBoxColumn17.Name = "Name";
            gridViewTextBoxColumn17.Width = 262;
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "ContactPhone";
            gridViewTextBoxColumn18.HeaderText = "Contact Phone";
            gridViewTextBoxColumn18.Name = "ContactPhone";
            gridViewTextBoxColumn18.Width = 155;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FieldName = "IsActive";
            gridViewCheckBoxColumn4.HeaderText = "Is Active";
            gridViewCheckBoxColumn4.HeaderTextAlignment = ContentAlignment.MiddleRight;
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "IsActive";
            gridViewCheckBoxColumn4.ReadOnly = true;
            gridViewCheckBoxColumn4.Width = 65;
            gridViewTextBoxColumn19.EnableExpressionEditor = false;
            gridViewTextBoxColumn19.FieldName = "GroupName";
            gridViewTextBoxColumn19.HeaderText = "Group Name";
            gridViewTextBoxColumn19.Name = "GroupName";
            gridViewTextBoxColumn19.Width = 239;
            gridViewTextBoxColumn20.EnableExpressionEditor = false;
            gridViewTextBoxColumn20.FieldName = "ContactEmail";
            gridViewTextBoxColumn20.HeaderText = "Contact Email";
            gridViewTextBoxColumn20.Name = "ContactEmail";
            RdGridViewList.MasterTemplate.Columns.AddRange(new GridViewDataColumn[] { gridViewTextBoxColumn16, gridViewTextBoxColumn17, gridViewTextBoxColumn18, gridViewCheckBoxColumn4, gridViewTextBoxColumn19, gridViewTextBoxColumn20 });
            RdGridViewList.MasterTemplate.EnableAlternatingRowColor = true;
            RdGridViewList.MasterTemplate.EnableCustomFiltering = true;
            RdGridViewList.MasterTemplate.EnableFiltering = true;
            RdGridViewList.MasterTemplate.ViewDefinition = tableViewDefinition4;
            RdGridViewList.Name = "RdGridViewList";
            RdGridViewList.RightToLeft = RightToLeft.No;
            RdGridViewList.Size = new Size(384, 482);
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
            splitPanel2.Location = new Point(396, 0);
            splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            splitPanel2.RootElement.MinSize = new Size(25, 25);
            splitPanel2.Size = new Size(582, 565);
            splitPanel2.SizeInfo.AutoSizeScale = new SizeF(0.09753591F, 0.21617645F);
            splitPanel2.SizeInfo.SplitterCorrection = new Size(95, 251);
            splitPanel2.TabIndex = 1;
            splitPanel2.TabStop = false;
            splitPanel2.Text = "splitPanel2";
            // 
            // radPanel3
            // 
            radPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radPanel3.Location = new Point(9, 323);
            radPanel3.Name = "radPanel3";
            radPanel3.Size = new Size(561, 239);
            radPanel3.TabIndex = 12;
            // 
            // radLabel4
            // 
            radLabel4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel4.Location = new Point(9, 271);
            radLabel4.Name = "radLabel4";
            radLabel4.Size = new Size(90, 18);
            radLabel4.TabIndex = 11;
            radLabel4.Text = "Image Or Video";
            // 
            // radButton3
            // 
            radButton3.Location = new Point(382, 293);
            radButton3.Name = "radButton3";
            radButton3.Size = new Size(88, 23);
            radButton3.TabIndex = 9;
            radButton3.Text = "Search";
            // 
            // radTextBox2
            // 
            radTextBox2.Location = new Point(9, 295);
            radTextBox2.Name = "radTextBox2";
            radTextBox2.Size = new Size(372, 20);
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
            radPanel2.Name = "radPanel2";
            radPanel2.Size = new Size(582, 74);
            radPanel2.TabIndex = 8;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(191, 34);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(88, 23);
            radButton2.TabIndex = 1;
            radButton2.Text = "Send";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(3, 35);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(88, 23);
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
            radLabel3.Location = new Point(2, 3);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(577, 26);
            radLabel3.TabIndex = 5;
            radLabel3.Text = "Select contact from gird or type in serach to find contact ";
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radLabel1.Location = new Point(8, 80);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(52, 18);
            radLabel1.TabIndex = 7;
            radLabel1.Text = "Message";
            // 
            // radTextBox1
            // 
            radTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radTextBox1.Location = new Point(9, 104);
            radTextBox1.Multiline = true;
            radTextBox1.Name = "radTextBox1";
            radTextBox1.NullText = "Enter message to send selected contacts";
            // 
            // 
            // 
            radTextBox1.RootElement.StretchVertically = true;
            radTextBox1.Size = new Size(563, 146);
            radTextBox1.TabIndex = 6;
            // 
            // FrmSendMessage
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 565);
            Controls.Add(radSplitContainer1);
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