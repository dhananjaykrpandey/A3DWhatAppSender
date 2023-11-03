using A3DFontAwesome;
using A3DWhatAppSender.Classes.Common;
using A3DWhatAppSender.Classes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WK.Libraries.SharpClipboardNS;

namespace A3DWhatAppSender
{
    public partial class FrmUploadContact : RadForm
    {

        List<ContactDetails> contacts;

        public FrmUploadContact()
        {
            InitializeComponent();
            RdBtnSave.Image = IconChar.Save.ToBitmap(color: Color.FromArgb(34, 122, 76), 24);
            RdBtnPaste.Image = IconChar.Paste.ToBitmap(color: Color.FromArgb(63, 68, 30), 24);
            RdBtnAppend.Image = IconChar.Add.ToBitmap(color: Color.FromArgb(11, 162, 235), 24);
            RdBtnReset.Image = IconChar.Remove.ToBitmap(color: Color.FromArgb(223, 45, 32), 24);
            contacts = new List<ContactDetails>();
            RdGridViewList.DataSource = contacts;
        }

        private void FrmUploadContact_Load(object sender, EventArgs e)
        {
            contacts = new List<ContactDetails>();
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
                            if (rowValues.Count == 1)
                            {
                                contactDetails.Name = rowValues[0].ToString();
                            }
                            if (rowValues.Count == 1)
                            {

                            }
                            if (rowValues.Count == 1)
                            {

                            }
                            if (rowValues.Count == 1)
                            {

                            }
                            if (rowValues.Count == 1)
                            {

                            }
                            if (rowValues.Count == 1)
                            {

                            }
                        }





                        contacts.Add(new ContactDetails { Name = rowValues[0] });
                    }

                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void RdBtnAppend_Click(object sender, EventArgs e)
        {

        }

        private void RdBtnSave_Click(object sender, EventArgs e)
        {

        }

        private void RdBtnReset_Click(object sender, EventArgs e)
        {
            contacts = new List<ContactDetails>();
            RdGridViewList.DataSource = contacts;
        }
    }
}
