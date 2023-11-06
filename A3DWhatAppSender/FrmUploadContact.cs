using A3DFontAwesome;
using A3DWhatAppSender.Classes.Common;
using A3DWhatAppSender.Classes.Model;

namespace A3DWhatAppSender
{
    public partial class FrmUploadContact : RadForm
    {

        BindingList<ContactDetails> contacts;

        public FrmUploadContact()
        {
            InitializeComponent();
            RdBtnSave.Image = IconChar.Save.ToBitmap(color: Color.FromArgb(34, 122, 76), 24);
            RdBtnPaste.Image = IconChar.Paste.ToBitmap(color: Color.FromArgb(63, 68, 30), 24);
            RdBtnAppend.Image = IconChar.Add.ToBitmap(color: Color.FromArgb(11, 162, 235), 24);
            RdBtnReset.Image = IconChar.Remove.ToBitmap(color: Color.FromArgb(223, 45, 32), 24);
            contacts = new BindingList<ContactDetails>();
            RdGridViewList.DataSource = contacts;
        }

        private void FrmUploadContact_Load(object sender, EventArgs e)
        {
            contacts = new BindingList<ContactDetails>();
        }

        private void sharpClipboard1_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            try
            {
                //if (e.ContentType == SharpClipboard.ContentTypes.Text)
                //{
                //    // Get the cut/copied text.
                //  MessageBox.Show(clipboard.ClipboardText);
                //}

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdBtnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                contacts = new BindingList<ContactDetails>();
                if (clipboard.ClipboardText.Length > 0)
                {
                    string[] dataRows = clipboard.ClipboardText.Split('\n');
                    List<string> commaSeparatedData = new List<string>();
                    foreach (string row in dataRows)
                    {
                        string[] rowValues = row.Split('\t');
                        commaSeparatedData.Add(string.Join(",", rowValues));
                    }
                    foreach (var vItemData in commaSeparatedData)
                    {

                        List<string> rowValues = vItemData.Split(Convert.ToChar(",")).ToList();
                        if (rowValues.Count > 0)
                        {
                            ContactDetails contactDetails = new();
                            if (rowValues.Count >= 0)
                            {
                                contactDetails.Name = rowValues[0] != null && string.IsNullOrEmpty(rowValues[0]) == false ? rowValues[0].ToString().Trim() : "";
                                if (contactDetails.Name == "") { continue; }
                            }
                            if (rowValues.Count >= 1)
                            {
                                contactDetails.ContactPhone = rowValues[1] != null && string.IsNullOrEmpty(rowValues[1]) == false ? rowValues[1].ToString().Trim() : "";
                            }
                            if (rowValues.Count >= 3)
                            {
                                contactDetails.ContactEmail = rowValues[3] != null && string.IsNullOrEmpty(rowValues[3]) == false ? rowValues[3].ToString().Trim() : "";
                            }
                            contactDetails.IsActive = true;
                            if (IsDuplicate(contactDetails, contacts) == false) { contacts.Add(contactDetails); }
                        }
                    }

                }
                RdGridViewList.DataSource = contacts;
                RdGridViewList.Update();
                RdGridViewList.Refresh();
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdBtnAppend_Click(object sender, EventArgs e)
        {
            try
            {

                if (clipboard.ClipboardText.Length > 0)
                {
                    string[] dataRows = clipboard.ClipboardText.Split('\n');
                    List<string> commaSeparatedData = new List<string>();
                    foreach (string row in dataRows)
                    {
                        string[] rowValues = row.Split('\t');
                        commaSeparatedData.Add(string.Join(",", rowValues));
                    }
                    foreach (var vItemData in commaSeparatedData)
                    {

                        List<string> rowValues = vItemData.Split(Convert.ToChar(",")).ToList();
                        if (rowValues.Count > 0)
                        {
                            ContactDetails contactDetails = new();
                            if (rowValues.Count >= 0)
                            {
                                contactDetails.Name = rowValues[0] != null && string.IsNullOrEmpty(rowValues[0]) == false ? rowValues[0].ToString().Trim() : "";
                                if (contactDetails.Name == "") { continue; }
                            }
                            if (rowValues.Count >= 1)
                            {
                                contactDetails.ContactPhone = rowValues[1] != null && string.IsNullOrEmpty(rowValues[1]) == false ? rowValues[1].ToString().Trim() : "";
                            }
                            if (rowValues.Count >= 3)
                            {
                                contactDetails.ContactEmail = rowValues[3] != null && string.IsNullOrEmpty(rowValues[3]) == false ? rowValues[3].ToString().Trim() : "";
                            }
                            contactDetails.IsActive = true;
                            if (IsDuplicate(contactDetails, contacts) == false) { contacts.Add(contactDetails); }
                        }
                    }

                }
                RdGridViewList.DataSource = contacts;
                RdGridViewList.Update();
                RdGridViewList.Refresh();
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private bool IsDuplicate(ContactDetails contactDetails, BindingList<ContactDetails> contactDetailsList)
        {
            try
            {
                var isExists = contactDetailsList.Where(x => x.Name.ToUpper() == contactDetails.Name.ToUpper() && x.ContactPhone.ToString() == contactDetails.ContactPhone.ToString() && x.ContactEmail == contactDetails.ContactEmail).Any();
                return isExists;
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
                return false;
            }
        }

        private void RdBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(Path.Combine(Application.StartupPath, "A3DWhatsapp.db")))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<ContactDetails>("ContactDetails");
                    col.Insert(contacts);
                    ClsMessage._IClsMessage.showSaveMessage();
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdBtnReset_Click(object sender, EventArgs e)
        {
            contacts = new BindingList<ContactDetails>();
            RdGridViewList.DataSource = contacts;
        }
    }
}
