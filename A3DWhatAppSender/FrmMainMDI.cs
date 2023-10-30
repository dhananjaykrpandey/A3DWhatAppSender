

using Telerik.WinControls.UI.Docking;

namespace A3DWhatAppSender
{
    public partial class FrmMainMDI : RadForm
    {
        public FrmMainMDI()
        {
            InitializeComponent();
            this.RdMainDock.MdiChildrenDockType = DockType.ToolWindow;
            this.RdMainDock.AutoDetectMdiChildren = true;
            // wVWhatsApp.Source = new Uri("https://www.google.com", UriKind.Absolute);
            this.ToolWindowWebBrowser.ToolCaptionButtons = ToolStripCaptionButtons.AutoHide;
            ToolWindowWebBrowser.AllowedDockState = AllowedDockState.AutoHide;
            this.ToolWindowMenu.ToolCaptionButtons = ToolStripCaptionButtons.AutoHide;
            // this.ToolWindowMenu.AllowedDockState = ~AllowedDockState.Floating;
            ToolWindowMenu.AllowedDockState = AllowedDockState.AutoHide;

        }
    }
}
