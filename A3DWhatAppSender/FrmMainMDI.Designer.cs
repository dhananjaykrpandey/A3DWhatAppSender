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
            RadTreeNode radTreeNode6 = new RadTreeNode();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmMainMDI));
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
            radRichTextEditor1 = new RichTextBox();
            radPictureBox1 = new RadPictureBox();
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
            ((ISupportInitialize)radPictureBox1).BeginInit();
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
            RdMainDock.Size = new Size(1288, 720);
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
            ToolWindowMenu.Size = new Size(198, 684);
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
            radTreeNode2.Text = "Open Web Login";
            radTreeNode3.ImageIndex = 2;
            radTreeNode3.Name = "mnuItemCreateContact";
            radTreeNode3.Tag = "FrmCreateContact";
            radTreeNode3.Text = "Create Contact";
            radTreeNode4.ImageIndex = 3;
            radTreeNode4.Name = "mnuItemUploadContact";
            radTreeNode4.Tag = "FrmUploadContact";
            radTreeNode4.Text = "Upload Contact";
            radTreeNode5.ImageIndex = 5;
            radTreeNode5.Name = "mnuItemGroup";
            radTreeNode5.Tag = "FrmGroup";
            radTreeNode5.Text = "Create Group";
            radTreeNode6.ImageIndex = 4;
            radTreeNode6.Name = "mnuItemSendMessage";
            radTreeNode6.Tag = "FrmSendMessage";
            radTreeNode6.Text = "Send Message";
            radTreeNode1.Nodes.AddRange(new RadTreeNode[] { radTreeNode2, radTreeNode3, radTreeNode4, radTreeNode5, radTreeNode6 });
            radTreeNode1.Text = "A3D What's App Sender";
            RadTreeViewMenu.Nodes.AddRange(new RadTreeNode[] { radTreeNode1 });
            RadTreeViewMenu.RightToLeft = RightToLeft.No;
            RadTreeViewMenu.ShowLines = true;
            RadTreeViewMenu.ShowNodeToolTips = true;
            RadTreeViewMenu.Size = new Size(198, 684);
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
            ToolTabStripMenu.Size = new Size(200, 710);
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
            ToolTabStripWebBrowser.Location = new Point(1013, 5);
            ToolTabStripWebBrowser.Name = "ToolTabStripWebBrowser";
            // 
            // 
            // 
            ToolTabStripWebBrowser.RootElement.MinSize = new Size(25, 25);
            ToolTabStripWebBrowser.SelectedIndex = 0;
            ToolTabStripWebBrowser.Size = new Size(270, 710);
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
            ToolWindowWebBrowser.Size = new Size(268, 684);
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
            radSplitContainer1.Size = new Size(268, 684);
            radSplitContainer1.TabIndex = 1;
            radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            splitPanel1.Controls.Add(radRichTextEditor1);
            splitPanel1.Controls.Add(radPictureBox1);
            splitPanel1.Location = new Point(0, 0);
            splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            splitPanel1.RootElement.MinSize = new Size(25, 25);
            splitPanel1.Size = new Size(268, 193);
            splitPanel1.SizeInfo.AutoSizeScale = new SizeF(0F, -0.21617648F);
            splitPanel1.SizeInfo.SplitterCorrection = new Size(0, -251);
            splitPanel1.TabIndex = 0;
            splitPanel1.TabStop = false;
            splitPanel1.Text = "splitPanel1";
            // 
            // radRichTextEditor1
            // 
            radRichTextEditor1.Dock = DockStyle.Fill;
            radRichTextEditor1.Location = new Point(0, 0);
            radRichTextEditor1.Name = "radRichTextEditor1";
            radRichTextEditor1.Size = new Size(268, 193);
            radRichTextEditor1.TabIndex = 1;
            radRichTextEditor1.Text = resources.GetString("radRichTextEditor1.Text");
            // 
            // radPictureBox1
            // 
            radPictureBox1.Location = new Point(2, 3);
            radPictureBox1.Name = "radPictureBox1";
            radPictureBox1.Size = new Size(29, 33);
            radPictureBox1.TabIndex = 0;
            radPictureBox1.Visible = false;
            // 
            // splitPanel2
            // 
            splitPanel2.Controls.Add(RadTextBoxLog);
            splitPanel2.Location = new Point(0, 197);
            splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            splitPanel2.RootElement.MinSize = new Size(25, 25);
            splitPanel2.Size = new Size(268, 487);
            splitPanel2.SizeInfo.AutoSizeScale = new SizeF(0F, 0.21617645F);
            splitPanel2.SizeInfo.SplitterCorrection = new Size(0, 251);
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
            RadTextBoxLog.Size = new Size(268, 487);
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
            ClientSize = new Size(1288, 720);
            Controls.Add(RdMainDock);
            KeyPreview = true;
            Name = "FrmMainMDI";
            Text = "FrmMainMDI";
            WindowState = FormWindowState.Maximized;
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
            ((ISupportInitialize)radPictureBox1).EndInit();
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
        private SplitPanel splitPanel2;
        private RadTextBox RadTextBoxLog;
        private RichTextBox radRichTextEditor1;
    }
}