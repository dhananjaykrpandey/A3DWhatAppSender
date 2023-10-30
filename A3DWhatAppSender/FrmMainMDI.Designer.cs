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
            RdMainDock = new Telerik.WinControls.UI.Docking.RadDock();
            ToolWindowWebBrowser = new Telerik.WinControls.UI.Docking.ToolWindow();
            wVWhatsApp = new Microsoft.Web.WebView2.WinForms.WebView2();
            ToolTabStripMenu = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            ToolWindowMenu = new Telerik.WinControls.UI.Docking.ToolWindow();
            documentContainerMain = new Telerik.WinControls.UI.Docking.DocumentContainer();
            ToolTabStripWebBrowser = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            radPanelhEADER = new RadPanel();
            ((ISupportInitialize)RdMainDock).BeginInit();
            RdMainDock.SuspendLayout();
            ToolWindowWebBrowser.SuspendLayout();
            ((ISupportInitialize)wVWhatsApp).BeginInit();
            ((ISupportInitialize)ToolTabStripMenu).BeginInit();
            ToolTabStripMenu.SuspendLayout();
            ((ISupportInitialize)documentContainerMain).BeginInit();
            ((ISupportInitialize)ToolTabStripWebBrowser).BeginInit();
            ToolTabStripWebBrowser.SuspendLayout();
            ((ISupportInitialize)radPanelhEADER).BeginInit();
            ((ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // RdMainDock
            // 
            RdMainDock.ActiveWindow = ToolWindowWebBrowser;
            RdMainDock.Controls.Add(ToolTabStripMenu);
            RdMainDock.Controls.Add(documentContainerMain);
            RdMainDock.Controls.Add(ToolTabStripWebBrowser);
            RdMainDock.Dock = DockStyle.Fill;
            RdMainDock.IsCleanUpTarget = true;
            RdMainDock.Location = new Point(0, 47);
            RdMainDock.MainDocumentContainer = documentContainerMain;
            RdMainDock.Name = "RdMainDock";
            // 
            // 
            // 
            RdMainDock.RootElement.MinSize = new Size(25, 25);
            RdMainDock.Size = new Size(1134, 729);
            RdMainDock.TabIndex = 0;
            RdMainDock.TabStop = false;
            // 
            // ToolWindowWebBrowser
            // 
            ToolWindowWebBrowser.Caption = null;
            ToolWindowWebBrowser.Controls.Add(wVWhatsApp);
            ToolWindowWebBrowser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToolWindowWebBrowser.Location = new Point(1, 24);
            ToolWindowWebBrowser.Name = "ToolWindowWebBrowser";
            ToolWindowWebBrowser.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            ToolWindowWebBrowser.Size = new Size(387, 693);
            ToolWindowWebBrowser.Text = "A3D What's App Web";
            // 
            // wVWhatsApp
            // 
            wVWhatsApp.AllowExternalDrop = true;
            wVWhatsApp.CreationProperties = null;
            wVWhatsApp.DefaultBackgroundColor = Color.White;
            wVWhatsApp.Dock = DockStyle.Fill;
            wVWhatsApp.Location = new Point(0, 0);
            wVWhatsApp.Name = "wVWhatsApp";
            wVWhatsApp.Size = new Size(387, 693);
            wVWhatsApp.TabIndex = 0;
            wVWhatsApp.ZoomFactor = 1D;
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
            ToolTabStripMenu.Size = new Size(200, 719);
            ToolTabStripMenu.SizeInfo.AutoSizeScale = new SizeF(-0.305825233F, 0F);
            ToolTabStripMenu.TabIndex = 1;
            ToolTabStripMenu.TabStop = false;
            // 
            // ToolWindowMenu
            // 
            ToolWindowMenu.Caption = null;
            ToolWindowMenu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToolWindowMenu.Location = new Point(1, 24);
            ToolWindowMenu.Name = "ToolWindowMenu";
            ToolWindowMenu.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            ToolWindowMenu.Size = new Size(198, 693);
            ToolWindowMenu.Text = "A3D What's App Sender";
            // 
            // documentContainerMain
            // 
            documentContainerMain.Name = "documentContainerMain";
            // 
            // 
            // 
            documentContainerMain.RootElement.MinSize = new Size(25, 25);
            documentContainerMain.SizeInfo.AbsoluteSize = new Size(437, 200);
            documentContainerMain.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            documentContainerMain.SizeInfo.SplitterCorrection = new Size(-189, 0);
            documentContainerMain.TabIndex = 2;
            // 
            // ToolTabStripWebBrowser
            // 
            ToolTabStripWebBrowser.Controls.Add(ToolWindowWebBrowser);
            ToolTabStripWebBrowser.Location = new Point(740, 5);
            ToolTabStripWebBrowser.Name = "ToolTabStripWebBrowser";
            // 
            // 
            // 
            ToolTabStripWebBrowser.RootElement.MinSize = new Size(25, 25);
            ToolTabStripWebBrowser.SelectedIndex = 0;
            ToolTabStripWebBrowser.Size = new Size(389, 719);
            ToolTabStripWebBrowser.SizeInfo.AbsoluteSize = new Size(389, 200);
            ToolTabStripWebBrowser.SizeInfo.SplitterCorrection = new Size(189, 0);
            ToolTabStripWebBrowser.TabIndex = 2;
            ToolTabStripWebBrowser.TabStop = false;
            // 
            // radPanelhEADER
            // 
            radPanelhEADER.Dock = DockStyle.Top;
            radPanelhEADER.Location = new Point(0, 0);
            radPanelhEADER.Name = "radPanelhEADER";
            radPanelhEADER.Size = new Size(1134, 47);
            radPanelhEADER.TabIndex = 1;
            // 
            // FrmMainMDI
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 776);
            Controls.Add(RdMainDock);
            Controls.Add(radPanelhEADER);
            Name = "FrmMainMDI";
            Text = "FrmMainMDI";
            ((ISupportInitialize)RdMainDock).EndInit();
            RdMainDock.ResumeLayout(false);
            ToolWindowWebBrowser.ResumeLayout(false);
            ((ISupportInitialize)wVWhatsApp).EndInit();
            ((ISupportInitialize)ToolTabStripMenu).EndInit();
            ToolTabStripMenu.ResumeLayout(false);
            ((ISupportInitialize)documentContainerMain).EndInit();
            ((ISupportInitialize)ToolTabStripWebBrowser).EndInit();
            ToolTabStripWebBrowser.ResumeLayout(false);
            ((ISupportInitialize)radPanelhEADER).EndInit();
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
        private RadPanel radPanelhEADER;
        private Microsoft.Web.WebView2.WinForms.WebView2 wVWhatsApp;
    }
}