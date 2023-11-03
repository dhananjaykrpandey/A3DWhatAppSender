

using A3DFontAwesome;
using A3DWhatAppSender.Classes.Common;
using System.Reflection;
using System.Web;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Core;

namespace A3DWhatAppSender
{
    public partial class FrmMainMDI : RadForm
    {
        /// <summary>
        /// 
        /// </summary>
        //Messenger? _Messenger = null;
        public FrmMainMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.RdMainDock.MdiChildrenDockType = DockType.ToolWindow;
            this.RdMainDock.AutoDetectMdiChildren = true;
            //wVWhatsApp.Source = new Uri("https://web.whatsapp.com/", UriKind.Absolute);
            this.ToolWindowWebBrowser.ToolCaptionButtons = ToolStripCaptionButtons.AutoHide;
            ToolWindowWebBrowser.AllowedDockState = AllowedDockState.AutoHide;
            this.ToolWindowMenu.ToolCaptionButtons = ToolStripCaptionButtons.AutoHide;
            // this.ToolWindowMenu.AllowedDockState = ~AllowedDockState.Floating;
            ToolWindowMenu.AllowedDockState = AllowedDockState.AutoHide;
            imageList1.Images.Add(A3DFontAwesome.IconChar.Whatsapp.ToBitmap(color: Color.Green, 36));
            imageList1.Images.Add(A3DFontAwesome.IconChar.SignIn.ToBitmap(color: Color.FromArgb(127, 0, 51), 36));
            imageList1.Images.Add(A3DFontAwesome.IconChar.UserAlt.ToBitmap(color: Color.DarkOliveGreen, 36));
            imageList1.Images.Add(A3DFontAwesome.IconChar.Users.ToBitmap(color: Color.RebeccaPurple, 36));
            imageList1.Images.Add(A3DFontAwesome.IconChar.MailBulk.ToBitmap(color: Color.FromArgb(208, 47, 87), 36));
            imageList1.Images.Add(A3DFontAwesome.IconChar.PeopleGroup.ToBitmap(color: Color.FromArgb(27, 148, 11), 36));
            ToolWindowWebBrowser.Close();
            RadBtnLogout.Enabled = false;
            RadBtnLogin.Enabled = false;

            Icon = System.Drawing.Icon.FromHandle(A3DFontAwesome.IconChar.Whatsapp.ToBitmap(Color.FromArgb(32, 233, 87), 48).GetHicon());
            Text = ClsMessage._IClsMessage.ProjectName;
        }

        private void FrmMainMDI_Load(object sender, EventArgs e)
        {

        }

        private void RadTreeViewMenu_NodeMouseDoubleClick(object sender, RadTreeViewEventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(e.Node.Text) && e.Node.Text != "") && (!string.IsNullOrEmpty(e.Node.Tag.ToString()) && e.Node.Tag.ToString() != ""))
                {
                    OpenForm(e.Node.Text, e.Node.Tag.ToString(), e.Node.ImageIndex);
                }
                else if ((!string.IsNullOrEmpty(e.Node.Text) && e.Node.Text != "") && (e.Node.Text.ToUpper() == "LOG OUT & EXIST"))
                {

                    DialogResult dgRsult = MessageBox.Show(this, "Do you want exit or log out?" + Environment.NewLine + "Click Yes for exit No for Log Out.", ClsMessage._IClsMessage.ProjectName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                    switch (dgRsult)
                    {
                        case DialogResult.Yes:
                            Application.Exit();
                            break;
                        case DialogResult.No:
                            Application.Restart();
                            break;
                    }
                }
                else if ((!string.IsNullOrEmpty(e.Node.Text) && e.Node.Text != "") && (e.Node.Text.ToUpper() == "LOGIN"))
                {
                    ////wVWhatsApp.Source = new Uri("https://web.whatsapp.com/", UriKind.Absolute);
                    //var message = "Hello";
                    //var number = "+971569431781";
                    //string Url = $"https://web.whatsapp.com/send?phone={number}&text={HttpUtility.UrlEncode(message)}&type=phone_number&app_absent=1";
                    //wVWhatsApp.CoreWebView2.Navigate (Url);
                    //wVWhatsApp.ExecuteScriptAsync("document.getElementsByName('send')[0].click();");
                    RadTextBoxLog.AppendText("starting driver..." + Environment.NewLine);
                    ToolWindowWebBrowser.Show();
                    ClsUtility._IClsUtility._gMessenger = new Messenger(false);
                    ClsUtility._IClsUtility._gMessenger.IsLogin = false;
                    RadTextBoxLog.AppendText("driver started." + Environment.NewLine);
                    ClsUtility._IClsUtility._gMessenger.OnQRReady += Messenger_OnQRReady;
                    RadBtnLogin.Enabled = true;
                }
            }
            catch (Exception ex)
            {


                ClsMessage._IClsMessage.ProjectExceptionMessage(ex.Message);
            }
        }
        private void Messenger_OnQRReady(Image qrbmp)
        {
            radPictureBox1.Image = qrbmp;
            RadTextBoxLog.Invoke(() => RadTextBoxLog.AppendText("please scan the QR code using your Whatsapp mobile app to continue login." + Environment.NewLine));

            ClsMessage._IClsMessage.showMessage("please scan the QR code using your Whatsapp mobile app to continue login." + Environment.NewLine);
        }
        public RadForm TryGetFormByName(string frmname)
        {
            var formType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(a => a.BaseType == typeof(RadForm) && a.Name == frmname);

            if (formType == null) // If there is no form with the given frmname
                return null;

            return (RadForm)Activator.CreateInstance(formType);
        }


        public bool IsFormOpen(Type frm, RadDock _RadMDIDock, out HostWindow _HostWindow)
        {

            var vObjForm = _RadMDIDock.DocumentManager.DocumentArray;

            foreach (var item in vObjForm)
            {
                var vItem = (HostWindow)item;
                if (vItem.MdiChild.GetType().Name.ToUpper() == frm.Name.ToUpper())
                {
                    _HostWindow = vItem;
                    return true;
                }

            }
            _HostWindow = null;
            return false;

        }

        private void OpenForm(string strMenuName, string strFormName, int ImgIndex)
        {
            RadForm _RadForm = new RadForm();
            _RadForm = TryGetFormByName(strFormName);
            HostWindow _HostWindowForm = null;
            if (ClsUtility._IClsUtility.IsFormOpen(_RadForm.GetType(), RdMainDock, out _HostWindowForm))
            {
                _HostWindowForm.ActivateAsMdiChild();
                _RadForm.Activate();
                RdMainDock.ActivateWindow(_HostWindowForm);
                RdMainDock.ActivateMdiChild(_RadForm);

            }
            else
            {
                //obj = new Form();
                // _RadForm = TryGetFormByName(strFormName);

                Bitmap icon = (Bitmap)imageList1.Images[ImgIndex];

                _RadForm.Icon = System.Drawing.Icon.FromHandle(icon.GetHicon());
                _RadForm.MdiParent = this;
                _RadForm.Show();
                _RadForm.Activate();
                RdMainDock.ActivateMdiChild(_RadForm);
                ClsUtility._IClsUtility.IsFormOpen(_RadForm.GetType(), RdMainDock, out _HostWindowForm);
                _HostWindowForm.Image = icon;


            }
        }

        public void radDockBody_DockWindowClosing(object sender, DockWindowCancelEventArgs e)
        {
            if (e.NewWindow.Text.ToUpper() == "Start Page".ToUpper())
            {
                e.Cancel = true;
            }
        }

        private void FrmMainMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClsUtility._IClsUtility._gMessenger?.IsLogin == true)
            {
                ClsUtility._IClsUtility._gMessenger?.Logout();
                ClsUtility._IClsUtility._gMessenger.IsLogin = false;

            }

            ClsUtility._IClsUtility._gMessenger?.Dispose();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ClsUtility._IClsUtility._gMessenger?.Login();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //RadTextBoxLog.AppendLine(e.Error.ToString());
            }
            else
            {
                //button1.Enabled = true;
                //button2.Enabled = true;
                //button3.Enabled = true;
                RadBtnLogout.Enabled = true;
            }
        }

        private void RadBtnLogin_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void RadBtnLogout_Click(object sender, EventArgs e)
        {
            if (ClsUtility._IClsUtility._gMessenger?.IsLogin == true)
            {
                ClsUtility._IClsUtility._gMessenger?.Logout();
                ClsUtility._IClsUtility._gMessenger.IsLogin = false;

            }
        }
    }
}
