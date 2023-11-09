using System;
using System.Linq;
using A3DFontAwesome;
using A3DWhatAppSender.Classes.Common;
using A3DWhatAppSender.Classes.Model;

using Telerik.WinControls.UI;

namespace A3DWhatAppSender
{
    public partial class FrmCreateContact : RadForm
    {

        BindingSource _BindingSource = new BindingSource();
        public FrmCreateContact()
        {
            InitializeComponent();

            RadPageViewStripElement el = RadPageView.ViewElement as RadPageViewStripElement;
            el.ItemContainer.Visibility = ElementVisibility.Collapsed;

            commandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            SetButtonImage();

            Reload();


            ClsUtility._IClsUtility.FormMode = ClsUtility.EnmFormMode.NormalMode;
            FormAction(false);

        }

        private void SetButtonImage()
        {
            CmdBarBtnAdd.Image = IconChar.Add.ToBitmap(Color.FromArgb(20, 49, 214), 24);
            CmdBarBtnAdd.ShowKeyboardCues = true;
            CmdBarBtnAdd.UseMnemonic = true;
            CmdBarBtnAdd.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.Control, Keys.N));



            CmdBarBtnEdit.Image = IconChar.Edit.ToBitmap(Color.FromArgb(52, 14, 3), 24);
            CmdBarBtnEdit.ShowKeyboardCues = true;
            CmdBarBtnEdit.UseMnemonic = true;
            CmdBarBtnEdit.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.Control, Keys.E));
            CmdBarBtnSave.Image = IconChar.Save.ToBitmap(Color.FromArgb(42, 186, 27), 24);
            CmdBarBtnSave.ShowKeyboardCues = true;
            CmdBarBtnSave.UseMnemonic = true;
            CmdBarBtnSave.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.Control, Keys.S));
            CmdBarBtnDelete.Image = IconChar.TrashAlt.ToBitmap(Color.FromArgb(204, 31, 67), 24);
            CmdBarBtnDelete.ShowKeyboardCues = true;
            CmdBarBtnDelete.UseMnemonic = true;
            CmdBarBtnDelete.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.Delete));
            CmdBarBtnUndo.Image = IconChar.UndoAlt.ToBitmap(Color.FromArgb(30, 243, 192), 24);
            CmdBarBtnUndo.ShowKeyboardCues = true;
            CmdBarBtnUndo.UseMnemonic = true;
            CmdBarBtnUndo.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.Control, Keys.Z));
            CmdBarBtnUploadExcel.Image = IconChar.FileExcel.ToBitmap(Color.FromArgb(33, 86, 240), 24);
            CmdBarBtnUploadExcel.ShowKeyboardCues = true;
            CmdBarBtnUploadExcel.UseMnemonic = true;
            CmdBarBtnUploadExcel.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.F10));
            CmdBarBtnRefresh.Image = IconChar.Refresh.ToBitmap(Color.FromArgb(193, 105, 184), 24);
            CmdBarBtnExport.ShowKeyboardCues = true;
            CmdBarBtnExport.UseMnemonic = true;
            CmdBarBtnRefresh.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.F5));
            CmdBarBtnExport.Image = IconChar.FileExport.ToBitmap(Color.FromArgb(32, 233, 87), 24);
            CmdBarBtnExport.ShowKeyboardCues = true;
            CmdBarBtnExport.UseMnemonic = true;
            CmdBarBtnExport.Shortcuts.Add(new Telerik.WinControls.RadShortcut(Keys.F12));

            //CmdBarBtnMoveFirst.Image = IconChar.FastForward.ToBitmap(Color.FromArgb(33, 86, 240), 24);
            //CmdBarBtnMoveLast.Image = IconChar.FastBackward.ToBitmap(Color.FromArgb(33, 86, 240), 24);
            //CmdBarBtnMoveNext.Image = IconChar.StepForward.ToBitmap(Color.FromArgb(193, 105, 184), 24);
            //CmdBarBtnMovePrevious.Image = A3DFontAwesome.IconChar.StepBackward.ToBitmap(Color.FromArgb(193, 105, 184), 24);
            //CmdBarBtnAdd.Image = A3DFontAwesome.IconChar.Add.ToBitmap(Color.FromArgb(32, 233, 87), 24);
            //CmdBarBtnAdd.Image = A3DFontAwesome.IconChar.Add.ToBitmap(Color.FromArgb(32, 233, 87), 24);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.N:
                    CmdBarBtnAdd.Focus();
                    CmdBarBtnAdd.PerformClick();
                    break;
                case Keys.Control | Keys.E:
                    CmdBarBtnEdit.Focus();
                    CmdBarBtnEdit.PerformClick();
                    break;
                case Keys.Delete:
                    CmdBarBtnDelete.Focus();
                    CmdBarBtnDelete.PerformClick();
                    break;
                case Keys.Control | Keys.S:
                    CmdBarBtnSave.Focus();
                    CmdBarBtnSave.PerformClick();
                    break;
                case Keys.Control | Keys.Z:
                    CmdBarBtnUndo.Focus();
                    CmdBarBtnUndo.PerformClick();
                    break;
                case Keys.F5:
                    CmdBarBtnRefresh.Focus();
                    CmdBarBtnRefresh.PerformClick();
                    break;
                case Keys.F10:
                    CmdBarBtnExport.Focus();
                    CmdBarBtnExport.PerformClick();
                    break;
                case Keys.F12:
                    CmdBarBtnUploadExcel.Focus();
                    CmdBarBtnUploadExcel.PerformClick();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormAction(bool lValue)
        {

            //if (ClsUtility._IClsUtility.FormMode==ClsUtility.EnmFormMode.AddMode || ClsUtility._IClsUtility.FormMode == ClsUtility.EnmFormMode.EditMode) 
            //{ }

            switch (ClsUtility._IClsUtility.FormMode)
            {
                case ClsUtility.EnmFormMode.AddMode:
                case ClsUtility.EnmFormMode.EditMode:
                    RdTxtEmail.Enabled = lValue;
                    RdTxtName.Enabled = lValue;
                    RdTxtPhoneno.Enabled = lValue;
                    RdTxtRemarks.Enabled = lValue;
                    RadChkIsActive.Enabled = lValue;

                    CmdBarBtnUploadExcel.Enabled = !lValue;
                    CmdBarBtnAdd.Enabled = !lValue;
                    CmdBarBtnEdit.Enabled = !lValue;
                    CmdBarBtnSave.Enabled = lValue;
                    CmdBarBtnUndo.Enabled = lValue;
                    CmdBarBtnDelete.Enabled = !lValue;
                    CmdBarBtnRefresh.Enabled = !lValue;
                    //CmdBarBtnMoveFirst.Enabled = !lValue;
                    //CmdBarBtnMoveLast.Enabled = lValue;
                    //CmdBarBtnMoveNext.Enabled = lValue;
                    //CmdBarBtnMovePrevious.Enabled = !lValue;
                    RadPageView.SelectedPage = RadPageViewPageEntry;
                    break;

                default:
                    RdTxtEmail.Enabled = lValue;
                    RdTxtName.Enabled = lValue;
                    RdTxtPhoneno.Enabled = lValue;
                    RdTxtRemarks.Enabled = lValue;
                    RadChkIsActive.Enabled = lValue;

                    CmdBarBtnUploadExcel.Enabled = !lValue;
                    CmdBarBtnAdd.Enabled = !lValue;
                    CmdBarBtnEdit.Enabled = !lValue;
                    CmdBarBtnSave.Enabled = lValue;
                    CmdBarBtnUndo.Enabled = lValue;
                    CmdBarBtnDelete.Enabled = !lValue;
                    CmdBarBtnRefresh.Enabled = !lValue;

                    //CmdBarBtnMoveFirst.Enabled = !lValue;
                    //CmdBarBtnMoveLast.Enabled = lValue;
                    //CmdBarBtnMoveNext.Enabled = lValue;
                    //CmdBarBtnMovePrevious.Enabled = !lValue;
                    RadPageView.SelectedPage = RadPageViewPageList;
                    break;
            }
        }
        private void FrmCreateContact_Load(object sender, EventArgs e)
        {
            SetButtonImage();
        }
        private void ClearForm()
        {
            RdTxtName.Text = string.Empty;
            RdTxtEmail.Text = string.Empty;
            RdTxtPhoneno.Text = string.Empty;
            RdTxtRemarks.Text = string.Empty;
            RadChkIsActive.Checked = false;
        }
        private void CmdBarBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClsUtility._IClsUtility.FormMode = ClsUtility.EnmFormMode.AddMode;
                FormAction(true);
                ClearForm();
                RdTxtID.Text = string.Empty;
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void CmdBarBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ClsUtility._IClsUtility.FormMode = ClsUtility.EnmFormMode.EditMode;
                FormAction(true);
                var id = RdGridViewList.CurrentRow.Cells[0].Value;
                using (var db = new LiteDB.LiteDatabase(Path.Combine(Application.StartupPath, "A3DWhatsapp.db")))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<ContactDetails>("ContactDetails");
                    var r = col.FindOne(x => x.Id == Convert.ToInt32(id));
                    RdTxtID.Text = id.ToString();
                    RdTxtName.Text = r.Name;
                    RdTxtEmail.Text = r.ContactEmail;
                    RdTxtPhoneno.Text = r.ContactPhone;
                    RdTxtRemarks.Text = r.Remarks;
                    RadChkIsActive.Checked = r.IsActive;


                    var colGroupContact = db.GetCollection<GroupContact>("GroupContact").Query().Where(x => x.ContactDetailsId == r.Id).ToList();

                    foreach (var item in colGroupContact)
                    {
                        var vItem = RdChkDDGroup.Items.Where(x => Convert.ToInt32(x.Tag) == item.GroupDetailId).FirstOrDefault();
                        if (vItem != null)
                        {
                            RadCheckedListDataItem dataItem = vItem as RadCheckedListDataItem;
                            if (dataItem != null) { dataItem.Checked = true; }
                        }
                    }
                }



            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void CmdBarBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new LiteDB.LiteDatabase(Path.Combine(Application.StartupPath, "A3DWhatsapp.db")))
                {
                    // Get a collection (or create, if doesn't exist)
                    var col = db.GetCollection<ContactDetails>("ContactDetails");
                    var colGroupContact = db.GetCollection<GroupContact>("GroupContact");
                    List<GroupContact> groupContacts = new List<GroupContact>();
                    var contactDt = new ContactDetails
                    {
                        Name = RdTxtName.Text,
                        ContactEmail = RdTxtEmail.Text,
                        ContactPhone = RdTxtPhoneno.Text,
                        Remarks = RdTxtRemarks.Text,
                        IsActive = RadChkIsActive.Checked == true ? true : false,
                    };



                    switch (ClsUtility._IClsUtility.FormMode)
                    {
                        case ClsUtility.EnmFormMode.AddMode:
                            col.Insert(contactDt);
                            foreach (var c in RdChkDDGroup.CheckedItems)
                            {
                                groupContacts.Add(new GroupContact { GroupDetailId = Convert.ToInt32(c.Tag), ContactDetailsId = contactDt.Id });
                            }
                            colGroupContact.InsertBulk(groupContacts);
                            break;
                        case ClsUtility.EnmFormMode.EditMode:

                            contactDt.Id = Convert.ToInt32(RdTxtID.Text);
                            // Get a collection (or create, if doesn't exist)
                            var colGroupContactDelete = db.GetCollection<GroupContact>("GroupContact").DeleteMany(x => x.ContactDetailsId == Convert.ToInt32(contactDt.Id));

                            col.Update(contactDt);

                            foreach (var c in RdChkDDGroup.CheckedItems)
                            {
                                groupContacts.Add(new GroupContact { GroupDetailId = Convert.ToInt32(c.Tag), ContactDetailsId = contactDt.Id });
                            }
                            colGroupContact.InsertBulk(groupContacts);


                            break;

                    }



                    ClsMessage._IClsMessage.showSaveMessage();
                    ClsUtility._IClsUtility.FormMode = ClsUtility.EnmFormMode.NormalMode;
                    FormAction(false);
                    RdGridViewList.DataSource = col;
                }
                Reload();
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void CmdBarBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClsMessage._IClsMessage.showAskDeleteMessage() == DialogResult.Yes)
                {
                    var id = RdGridViewList.CurrentRow.Cells[0].Value;
                    using (var db = new LiteDB.LiteDatabase(Path.Combine(Application.StartupPath, "A3DWhatsapp.db")))
                    {
                        // Get a collection (or create, if doesn't exist)
                        var colGroupContactDelete = db.GetCollection<GroupContact>("GroupContact").DeleteMany(x => x.ContactDetailsId == Convert.ToInt32(id));

                        // Get a collection (or create, if doesn't exist)
                        var col = db.GetCollection<ContactDetails>("ContactDetails").DeleteMany(x => x.Id == Convert.ToInt32(id));

                        ClsMessage._IClsMessage.showDeleteMessage();

                    }
                    Reload();
                }
            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }
        }

        private void CmdBarBtnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                ClsUtility._IClsUtility.FormMode = ClsUtility.EnmFormMode.NormalMode;
                FormAction(false);

            }
            catch (Exception ex)
            {

                ClsMessage._IClsMessage.ProjectExceptionMessage(ex);
            }

        }

        private void CmbBarBtnUploadExcel_Click(object sender, EventArgs e)
        {

        }

        private void CmdBarBtnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            using (var db = new LiteDB.LiteDatabase(Path.Combine(Application.StartupPath, "A3DWhatsapp.db")))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<ContactDetails>("ContactDetails").Query().ToList();
                var colGroup = db.GetCollection<GroupDetail>("GroupDetail").Query().ToList();

                foreach (var item in col)
                {
                    var UserGrpName = db.GetCollection<GroupContact>("GroupContact").Query().Where(x => x.ContactDetailsId == item.Id).ToList();


                    List<string> GroupNameContact = new();
                    foreach (var Groupitem in UserGrpName)
                    {

                        var GrpName = colGroup.Where(x => x.Id == Groupitem.GroupDetailId).FirstOrDefault();

                        GroupNameContact.Add(GrpName.GroupName);
                    }
                    if (GroupNameContact.Count > 0)
                    {
                        item.GroupName = string.Join(",", GroupNameContact);
                    }

                }
                RdChkDDGroup.Items.Clear();

                RdGridViewList.DataSource = col;
                foreach (var VItem in colGroup)
                {
                    RadCheckedListDataItem dataItem = new RadCheckedListDataItem();
                    dataItem.Text = VItem.GroupName;
                    dataItem.Tag = VItem.Id;
                    RdChkDDGroup.Items.Add(dataItem);

                }

            }
        }

        private void RdChkDDGroup_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
        {
            bool itemChecked = ((RadCheckedListDataItem)args.VisualItem.Data).Checked;
            if (itemChecked)
            {
                args.VisualItem.ForeColor = Color.Green;
            }
            else
            {
                args.VisualItem.ForeColor = Color.Red;
            }
        }

        private void RdChkDDGroup_Leave(object sender, EventArgs e)
        {
            RdChkDDGroup.Popup.ClosePopup(RadPopupCloseReason.CloseCalled);
        }
    }
}
