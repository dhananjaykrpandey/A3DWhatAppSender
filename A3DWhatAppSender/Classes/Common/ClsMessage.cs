using Telerik.Windows.Documents.Spreadsheet.FormatProviders.TextBased.Core;

namespace A3DWhatAppSender.Classes.Common
{

    public class ClsMessage
    {
        private static ClsMessage _iClsMessage = null;
        public ClsMessage()

        {

        }
        public static ClsMessage _IClsMessage
        {
            get
            {
                if (_iClsMessage == null)
                {
                    _iClsMessage = new ClsMessage();
                }
                return _iClsMessage;
            }

        }

        public readonly string ProjectName = "A3D What's App Message Sender System";

        public void showMessage(string msg, RadMessageIcon Icon = RadMessageIcon.Info)
        {
           RadMessageBox.Show(msg, ProjectName, MessageBoxButtons.OK, Icon);
        }
        public void ProjectExceptionMessage(string msg)
        {
            RadMessageBox.Show(msg, ProjectName, MessageBoxButtons.OK, RadMessageIcon.Error);
        }
        public void ProjectExceptionMessage(Exception msg)
        {
            string innerex = "";
            if (msg.InnerException != null)
            {
                innerex = msg.InnerException.ToString();
            }
            RadMessageBox.Show(msg + Environment.NewLine + innerex, ProjectName, MessageBoxButtons.OK, RadMessageIcon.Error);
        }
        public DialogResult showQuestionMessage(string msg)
        {
            return RadMessageBox.Show(msg, ProjectName, MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }
        public void showSaveMessage()
        {
            RadMessageBox.Show("Record save successfully!", ProjectName, MessageBoxButtons.OK, RadMessageIcon.Info);
        }
        public void showDeleteMessage()
        {
            RadMessageBox.Show("Record deleted successfully!", ProjectName, MessageBoxButtons.OK, RadMessageIcon.Info);
        }
        public DialogResult showAskDeleteMessage()
        {
            return RadMessageBox.Show("Are you sure want to delete this record?", ProjectName, MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }
        public DialogResult showAskExitMessage()
        {
            return RadMessageBox.Show("Are you sure want to exit?", ProjectName, MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }
        public DialogResult showAskDiscardMessage()
        {
            return RadMessageBox.Show("Are you sure want to discard changes?", ProjectName, MessageBoxButtons.YesNo,RadMessageIcon.Question);
        }
    }
}