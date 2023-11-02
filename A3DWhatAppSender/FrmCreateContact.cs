﻿using System;
using System.Linq;
using A3DFontAwesome;
using A3DWhatAppSender.Classes.Common;
using A3DWhatAppSender.Classes.Model;

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
            SetButtonImage();

            Reload();


            ClsUtility._IClsUtility.FormMode = ClsUtility.EnmFormMode.NormalMode;
            FormAction(false);

        }
        private void SetButtonImage()
        {
            CmdBarBtnAdd.Image = IconChar.Add.ToBitmap(Color.FromArgb(20, 49, 214), 24);
            CmdBarBtnEdit.Image = IconChar.Edit.ToBitmap(Color.FromArgb(52, 14, 3), 24);
            CmdBarBtnSave.Image = IconChar.Save.ToBitmap(Color.FromArgb(42, 186, 27), 24);
            CmdBarBtnDelete.Image = IconChar.TrashAlt.ToBitmap(Color.FromArgb(204, 31, 67), 24);
            CmdBarBtnUndo.Image = IconChar.UndoAlt.ToBitmap(Color.FromArgb(30, 243, 192), 24);
            CmbBarBtnUploadExcel.Image = IconChar.FileExcel.ToBitmap(Color.FromArgb(33, 86, 240), 24);
            CmdBarBtnRefresh.Image = IconChar.Refresh.ToBitmap(Color.FromArgb(193, 105, 184), 24);
            //CmdBarBtnMoveFirst.Image = IconChar.FastForward.ToBitmap(Color.FromArgb(33, 86, 240), 24);
            //CmdBarBtnMoveLast.Image = IconChar.FastBackward.ToBitmap(Color.FromArgb(33, 86, 240), 24);
            //CmdBarBtnMoveNext.Image = IconChar.StepForward.ToBitmap(Color.FromArgb(193, 105, 184), 24);
            //CmdBarBtnMovePrevious.Image = A3DFontAwesome.IconChar.StepBackward.ToBitmap(Color.FromArgb(193, 105, 184), 24);
            //CmdBarBtnAdd.Image = A3DFontAwesome.IconChar.Add.ToBitmap(Color.FromArgb(32, 233, 87), 24);
            //CmdBarBtnAdd.Image = A3DFontAwesome.IconChar.Add.ToBitmap(Color.FromArgb(32, 233, 87), 24);
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

                    CmbBarBtnUploadExcel.Enabled = !lValue;
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

                    CmbBarBtnUploadExcel.Enabled = !lValue;
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
                    RdTxtName.Text = r.Name;
                    RdTxtEmail.Text = r.ContactEmail;
                    RdTxtPhoneno.Text = r.ContactPhone;
                    RdTxtRemarks.Text = r.Remarks;
                    RadChkIsActive.Checked = r.IsActive;
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
                    var contactDt = new ContactDetails
                    {
                        Name = RdTxtName.Text,
                        ContactEmail = RdTxtEmail.Text,
                        ContactPhone = RdTxtPhoneno.Text,
                        Remarks = RdTxtRemarks.Text,
                        IsActive = RadChkIsActive.Checked,
                    };
                    switch (ClsUtility._IClsUtility.FormMode)
                    {
                        case ClsUtility.EnmFormMode.AddMode:
                            col.Insert(contactDt);
                            break;
                        case ClsUtility.EnmFormMode.EditMode:
                            col.Update(contactDt);
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
                var col = db.GetCollection<ContactDetails>("ContactDetails");

                RdGridViewList.DataSource = col.Query().ToList();
            }
        }
    }
}
