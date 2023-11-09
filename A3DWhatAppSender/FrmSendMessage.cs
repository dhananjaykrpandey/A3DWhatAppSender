using A3DWhatAppSender.Classes.Common;

namespace A3DWhatAppSender
{
    public partial class FrmSendMessage : RadForm
    {
        //Messenger? _Messenger = null;

        List<string> messagesContact = new List<string>();
        public FrmSendMessage()
        {
            InitializeComponent();
            messagesContact.AddRange(new string[] { "+971569431781", "+971559604376", "+971589599058" });
        }

        private void RadBtnSend_Click(object sender, EventArgs e)
        {
            //foreach (var item in messagesContact)
            //{
            //    Thread.Sleep(5000);
            //    ClsUtility._IClsUtility._gMessenger.SendMessage(item, "Test Message");
            //}
        }
    }
}
