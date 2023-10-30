namespace A3DWhatAppSender
{
    partial class FrmMainMDI
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
            RadTreeNode radTreeNode1 = new RadTreeNode();
            RadTreeNode radTreeNode2 = new RadTreeNode();
            RadTreeNode radTreeNode3 = new RadTreeNode();
            RadTreeNode radTreeNode4 = new RadTreeNode();
            RadTreeNode radTreeNode5 = new RadTreeNode();
            RdMainDock = new Telerik.WinControls.UI.Docking.RadDock();
            ToolWindowMenu = new Telerik.WinControls.UI.Docking.ToolWindow();
            RadTreeViewMenu = new RadTreeView();
            imageList1 = new ImageList(components);
            ToolTabStripMenu = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            documentContainerMain = new Telerik.WinControls.UI.Docking.DocumentContainer();
            ToolTabStripWebBrowser = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            ToolWindowWebBrowser = new Telerik.WinControls.UI.Docking.ToolWindow();
            radSplitContainer1 = new RadSplitContainer();
            splitPanel1 = new SplitPanel();
            radSplitContainer2 = new RadSplitContainer();
            splitPanel3 = new SplitPanel();
            radPictureBox1 = new RadPictureBox();
            splitPanel4 = new SplitPanel();
            RadBtnLogout = new RadButton();
            RadBtnLogin = new RadButton();
            splitPanel2 = new SplitPanel();
            RadTextBoxLog = new RadTextBox();
            backgroundWorker1 = new BackgroundWorker();
            ((ISupportInitialize)RdMainDock).BeginInit();
            RdMainDock.SuspendLayout();
            ToolWindowMenu.SuspendLayout();
            ((ISupportInitialize)RadTreeViewMenu).BeginInit();
            ((ISupportInitialize)ToolTabStripMenu).BeginInit();
            ToolTabStripMenu.SuspendLayout();
            ((ISupportInitialize)documentContainerMain).BeginInit();
            ((ISupportInitialize)ToolTabStripWebBrowser).BeginInit();
            ToolTabStripWebBrowser.SuspendLayout();
            ToolWindowWebBrowser.SuspendLayout();
            ((ISupportInitialize)radSplitContainer1).BeginInit();
            radSplitContainer1.SuspendLayout();
            ((ISupportInitialize)splitPanel1).BeginInit();
            splitPanel1.SuspendLayout();
            ((ISupportInitialize)radSplitContainer2).BeginInit();
            radSplitContainer2.SuspendLayout();
            ((ISupportInitialize)splitPanel3).BeginInit();
            splitPanel3.SuspendLayout();
            ((ISupportInitialize)radPictureBox1).BeginInit();
            ((ISupportInitialize)splitPanel4).BeginInit();
            splitPanel4.SuspendLayout();
            ((ISupportInitialize)RadBtnLogout).BeginInit();
            ((ISupportInitialize)RadBtnLogin).BeginInit();
            ((ISupportInitialize)splitPanel2).BeginInit();
            splitPanel2.SuspendLayout();
            ((ISupportInitialize)RadTextBoxLog).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RdMainDock
            // 
            RdMainDock.ActiveWindow = ToolWindowMenu;
            RdMainDock.BackgroundImage = Properties.Resources.A3D256;
            RdMainDock.BackgroundImageLayout = ImageLayout.Center;
            RdMainDock.Controls.Add(ToolTabStripMenu);
            RdMainDock.Controls.Add(documentContainerMain);
            RdMainDock.Controls.Add(ToolTabStripWebBrowser);
            RdMainDock.Dock = DockStyle.Fill;
            RdMainDock.IsCleanUpTarget = true;
            RdMainDock.Location = new Point(0, 0);
            RdMainDock.MainDocumentContainer = documentContainerMain;
            RdMainDock.Name = "RdMainDock";
            // 
            // 
            // 
            RdMainDock.RootElement.MinSize = new Size(25, 25);
            RdMainDock.Size = new Size(846, 375);
            RdMainDock.TabIndex = 0;
            RdMainDock.TabStop = false;
            // 
            // ToolWindowMenu
            // 
            ToolWindowMenu.Caption = null;
            ToolWindowMenu.Controls.Add(RadTreeViewMenu);
            ToolWindowMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToolWindowMenu.Location = new Point(1, 24);
            ToolWindowMenu.Name = "ToolWindowMenu";
            ToolWindowMenu.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            ToolWindowMenu.Size = new Size(198, 339);
            ToolWindowMenu.Text = "A3D What's App Sender";
            // 
            // RadTreeViewMenu
            // 
            RadTreeViewMenu.BackColor = Color.FromArgb(233, 240, 249);
            RadTreeViewMenu.Dock = DockStyle.Fill;
            RadTreeViewMenu.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            RadTreeViewMenu.ForeColor = Color.Black;
            RadTreeViewMenu.ImageList = imageList1;
            RadTreeViewMenu.Location = new Point(0, 0);
            RadTreeViewMenu.Name = "RadTreeViewMenu";
            radTreeNode1.Expanded = true;
            radTreeNode1.ImageIndex = 0;
            radTreeNode1.Name = "mnuItemMain";
            radTreeNode2.ImageIndex = 1;
            radTreeNode2.Name = "mnuItemLogin";
            radTreeNode2.Tag = "";
            radTreeNode2.Text = "Login";
            radTreeNode3.ImageIndex = 2;
            radTreeNode3.Name = "mnuItemCreateContact";
            radTreeNode3.Tag = "FrmCreateContact";
            radTreeNode3.Text = "Create Contact";
            radTreeNode4.ImageIndex = 3;
            radTreeNode4.Name = "mnuItemUploadContact";
            radTreeNode4.Tag = "FrmUploadContact";
            radTreeNode4.Text = "Upload Contact";
            radTreeNode5.ImageIndex = 4;
            radTreeNode5.Name = "mnuItemSendMessage";
            radTreeNode5.Tag = "FrmSendMessage";
            radTreeNode5.Text = "Send Message";
            radTreeNode1.Nodes.AddRange(new RadTreeNode[] { radTreeNode2, radTreeNode3, radTreeNode4, radTreeNode5 });
            radTreeNode1.Text = "A3D What's App Sender";
            RadTreeViewMenu.Nodes.AddRange(new RadTreeNode[] { radTreeNode1 });
            RadTreeViewMenu.RightToLeft = RightToLeft.No;
            RadTreeViewMenu.ShowLines = true;
            RadTreeViewMenu.ShowNodeToolTips = true;
            RadTreeViewMenu.Size = new Size(198, 339);
            RadTreeViewMenu.SpacingBetweenNodes = -1;
            RadTreeViewMenu.TabIndex = 0;
            RadTreeViewMenu.NodeMouseDoubleClick += RadTreeViewMenu_NodeMouseDoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // ToolTabStripMenu
            // 
            ToolTabStripMenu.Controls.Add(ToolWindowMenu);
            ToolTabStripMenu.Location = new Point(5, 5);
            ToolTabStripMenu.Name = "ToolTabStripMenu";
            // 
            // 
            // 
            ToolTabStripMenu.RootElement.MinSize = new Size(25, 25);
            ToolTabStripMenu.SelectedIndex = 0;
            ToolTabStripMenu.Size = new Size(200, 365);
            ToolTabStripMenu.SizeInfo.AutoSizeScale = new SizeF(-0.2596154F, 0F);
            ToolTabStripMenu.TabIndex = 1;
            ToolTabStripMenu.TabStop = false;
            // 
            // documentContainerMain
            // 
            documentContainerMain.BackgroundImageLayout = ImageLayout.Center;
            documentContainerMain.Name = "documentContainerMain";
            // 
            // 
            // 
            documentContainerMain.RootElement.MinSize = new Size(25, 25);
            documentContainerMain.SizeInfo.AbsoluteSize = new Size(358, 200);
            documentContainerMain.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainerMain.SizeInfo.SplitterCorrection = new Size(-70, 0);
            documentContainerMain.TabIndex = 2;
            // 
            // ToolTabStripWebBrowser
            // 
            ToolTabStripWebBrowser.Controls.Add(ToolWindowWebBrowser);
            ToolTabStripWebBrowser.Location = new Point(571, 5);
            ToolTabStripWebBrowser.Name = "ToolTabStripWebBrowser";
            // 
            // 
            // 
            ToolTabStripWebBrowser.RootElement.MinSize = new Size(25, 25);
            ToolTabStripWebBrowser.SelectedIndex = 0;
            ToolTabStripWebBrowser.Size = new Size(270, 365);
            ToolTabStripWebBrowser.SizeInfo.AbsoluteSize = new Size(270, 200);
            ToolTabStripWebBrowser.SizeInfo.SplitterCorrection = new Size(70, 0);
            ToolTabStripWebBrowser.TabIndex = 2;
            ToolTabStripWebBrowser.TabStop = false;
            // 
            // ToolWindowWebBrowser
            // 
            ToolWindowWebBrowser.Caption = null;
            ToolWindowWebBrowser.Controls.Add(radSplitContainer1);
            ToolWindowWebBrowser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToolWindowWebBrowser.Location = new Point(1, 24);
            ToolWindowWebBrowser.Name = "ToolWindowWebBrowser";
            ToolWindowWebBrowser.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            ToolWindowWebBrowser.Size = new Size(268, 339);
            ToolWindowWebBrowser.Text = "A3D What's App Web";
            // 
            // radSplitContainer1
            // 
            radSplitContainer1.Controls.Add(splitPanel1);
            radSplitContainer1.Controls.Add(splitPanel2);
            radSplitContainer1.Dock = DockStyle.Fill;
            radSplitContainer1.IsCleanUpTarget = true;
            radSplitContainer1.Location = new Point(0, 0);
            radSplitContainer1.Name = "radSplitContainer1";
            radSplitContainer1.Orientation = Orientation.Horizontal;
            radSplitContainer1.Padding = new Padding(5);
            // 
            // 
            // 
            radSplitContainer1.RootElement.MinSize = new Size(25, 25);
            radSplitContainer1.Size = new Size(268, 339);
            radSplitContainer1.TabIndex = 1;
            radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            splitPanel1.Controls.Add(radSplitContainer2);
            splitPanel1.Location = new Point(0, 0);
            splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            splitPanel1.RootElement.MinSize = new Size(25, 25);
            splitPanel1.Size = new Size(268, 143);
            splitPanel1.SizeInfo.AutoSizeScale = new SizeF(0F, -0.07349399F);
            splitPanel1.SizeInfo.SplitterCorrection = new Size(0, -26);
            splitPanel1.TabIndex = 0;
            splitPanel1.TabStop = false;
            splitPanel1.Text = "splitPanel1";
            // 
            // radSplitContainer2
            // 
            radSplitContainer2.Controls.Add(splitPanel3);
            radSplitContainer2.Controls.Add(splitPanel4);
            radSplitContainer2.Dock = DockStyle.Fill;
            radSplitContainer2.IsCleanUpTarget = true;
            radSplitContainer2.Location = new Point(0, 0);
            radSplitContainer2.Name = "radSplitContainer2";
            radSplitContainer2.Padding = new Padding(5);
            // 
            // 
            // 
            radSplitContainer2.RootElement.MinSize = new Size(25, 25);
            radSplitContainer2.Size = new Size(268, 143);
            radSplitContainer2.TabIndex = 1;
            radSplitContainer2.TabStop = false;
            // 
            // splitPanel3
            // 
            splitPanel3.Controls.Add(radPictureBox1);
            splitPanel3.Location = new Point(0, 0);
            splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            splitPanel3.RootElement.MinSize = new Size(25, 25);
            splitPanel3.Size = new Size(167, 143);
            splitPanel3.SizeInfo.AutoSizeScale = new SizeF(0.134464741F, 0F);
            splitPanel3.SizeInfo.SplitterCorrection = new Size(51, 0);
            splitPanel3.TabIndex = 0;
            splitPanel3.TabStop = false;
            splitPanel3.Text = "splitPanel3";
            // 
            // radPictureBox1
            // 
            radPictureBox1.Dock = DockStyle.Fill;
            radPictureBox1.Location = new Point(0, 0);
            radPictureBox1.Name = "radPictureBox1";
            radPictureBox1.Size = new Size(167, 143);
            radPictureBox1.TabIndex = 0;
            // 
            // splitPanel4
            // 
            splitPanel4.Controls.Add(RadBtnLogout);
            splitPanel4.Controls.Add(RadBtnLogin);
            splitPanel4.Location = new Point(171, 0);
            splitPanel4.Name = "splitPanel4";
            // 
            // 
            // 
            splitPanel4.RootElement.MinSize = new Size(25, 25);
            splitPanel4.Size = new Size(97, 143);
            splitPanel4.SizeInfo.AutoSizeScale = new SizeF(-0.134464741F, 0F);
            splitPanel4.SizeInfo.SplitterCorrection = new Size(-51, 0);
            splitPanel4.TabIndex = 1;
            splitPanel4.TabStop = false;
            splitPanel4.Text = "splitPanel4";
            // 
            // RadBtnLogout
            // 
            RadBtnLogout.Location = new Point(3, 56);
            RadBtnLogout.Name = "RadBtnLogout";
            RadBtnLogout.Size = new Size(104, 24);
            RadBtnLogout.TabIndex = 1;
            RadBtnLogout.Text = "Logout";
            RadBtnLogout.Click += RadBtnLogout_Click;
            // 
            // RadBtnLogin
            // 
            RadBtnLogin.Location = new Point(2, 14);
            RadBtnLogin.Name = "RadBtnLogin";
            RadBtnLogin.Size = new Size(104, 24);
            RadBtnLogin.TabIndex = 0;
            RadBtnLogin.Text = "Login";
            RadBtnLogin.Click += RadBtnLogin_Click;
            // 
            // splitPanel2
            // 
            splitPanel2.Controls.Add(RadTextBoxLog);
            splitPanel2.Location = new Point(0, 147);
            splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            splitPanel2.RootElement.MinSize = new Size(25, 25);
            splitPanel2.Size = new Size(268, 192);
            splitPanel2.SizeInfo.AutoSizeScale = new SizeF(0F, 0.07349396F);
            splitPanel2.SizeInfo.SplitterCorrection = new Size(0, 26);
            splitPanel2.TabIndex = 1;
            splitPanel2.TabStop = false;
            splitPanel2.Text = "splitPanel2";
            // 
            // RadTextBoxLog
            // 
            RadTextBoxLog.Dock = DockStyle.Fill;
            RadTextBoxLog.Location = new Point(0, 0);
            RadTextBoxLog.Multiline = true;
            RadTextBoxLog.Name = "RadTextBoxLog";
            // 
            // 
            // 
            RadTextBoxLog.RootElement.StretchVertically = true;
            RadTextBoxLog.Size = new Size(268, 192);
            RadTextBoxLog.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // FrmMainMDI
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 375);
            Controls.Add(RdMainDock);
            Name = "FrmMainMDI";
            Text = "FrmMainMDI";
            FormClosing += FrmMainMDI_FormClosing;
            Load += FrmMainMDI_Load;
            ((ISupportInitialize)RdMainDock).EndInit();
            RdMainDock.ResumeLayout(false);
            ToolWindowMenu.ResumeLayout(false);
            ((ISupportInitialize)RadTreeViewMenu).EndInit();
            ((ISupportInitialize)ToolTabStripMenu).EndInit();
            ToolTabStripMenu.ResumeLayout(false);
            ((ISupportInitialize)documentContainerMain).EndInit();
            ((ISupportInitialize)ToolTabStripWebBrowser).EndInit();
            ToolTabStripWebBrowser.ResumeLayout(false);
            ToolWindowWebBrowser.ResumeLayout(false);
            ((ISupportInitialize)radSplitContainer1).EndInit();
            radSplitContainer1.ResumeLayout(false);
            ((ISupportInitialize)splitPanel1).EndInit();
            splitPanel1.ResumeLayout(false);
            ((ISupportInitialize)radSplitContainer2).EndInit();
            radSplitContainer2.ResumeLayout(false);
            ((ISupportInitialize)splitPanel3).EndInit();
            splitPanel3.ResumeLayout(false);
            ((ISupportInitialize)radPictureBox1).EndInit();
            ((ISupportInitialize)splitPanel4).EndInit();
            splitPanel4.ResumeLayout(false);
            ((ISupportInitialize)RadBtnLogout).EndInit();
            ((ISupportInitialize)RadBtnLogin).EndInit();
            ((ISupportInitialize)splitPanel2).EndInit();
            splitPanel2.ResumeLayout(false);
            splitPanel2.PerformLayout();
            ((ISupportInitialize)RadTextBoxLog).EndInit();
            ((ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.Docking.RadDock RdMainDock;
        private Telerik.WinControls.UI.Docking.ToolTabStrip ToolTabStripMenu;
        private Telerik.WinControls.UI.Docking.ToolWindow ToolWindowMenu;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainerMain;
        private Telerik.WinControls.UI.Docking.ToolTabStrip ToolTabStripWebBrowser;
        private Telerik.WinControls.UI.Docking.ToolWindow ToolWindowWebBrowser;
        private RadTreeView RadTreeViewMenu;
        private ImageList imageList1;
        private RadPictureBox radPictureBox1;
        private BackgroundWorker backgroundWorker1;
        private RadSplitContainer radSplitContainer1;
        private SplitPanel splitPanel1;
        private RadSplitContainer radSplitContainer2;
        private SplitPanel splitPanel3;
        private SplitPanel splitPanel4;
        private SplitPanel splitPanel2;
        private RadButton RadBtnLogin;
        private RadButton RadBtnLogout;
        private RadTextBox RadTextBoxLog;
    }
}