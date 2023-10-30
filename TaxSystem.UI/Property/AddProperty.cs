using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;

namespace TaxSystem.UI.Property
{
    public partial class AddProperty : XtraForm
    {
        public AddProperty()
        {
            InitializeComponent();
            TxtPropertyLevel.Properties.DataSource = Application.Settings.GetLevels();
            TxtPaymentPeriod.Properties.DataSource = Application.Settings.GetPaymentPeriods();
        }
        private Domain.Entities.PropertyInfo info;
        private Domain.Entities.Owners ownerInfo;
        public AddProperty(Domain.Entities.PropertyInfo info)
        {
            InitializeComponent();
            TxtPropertyLevel.Properties.DataSource = Application.Settings.GetLevels();
            TxtPaymentPeriod.Properties.DataSource = Application.Settings.GetPaymentPeriods();
            this.info = info;
            Text = info.Location;
            PhoneNo.PageEnabled = false;
            TxtBlock.Text = info.Block;
            TxtDistrict.Text = info.District;
            TxtLongtitude.Text = info.Longtitude;
            TxtLantitude.Text = info.Lantitude;
            TxtCurrentTax.Text = info.TaxAmount.ToString();
            TxtEast.Text = info.East;
            TxtWest.Text = info.West;
            TxtNorth.Text = info.North;
            TxtSouth.Text = info.South;
            TxtPropertyLevel.EditValue = info.PropertyLevelId;
            TxtParcel.Text = info.Parcel;
            TxtLocation.Text = info.Location;
            TxtPaymentPeriod.EditValue = info.PaymentPeriodId;

            ownerInfo = info.Owner;
            TxtFirstName.Text = ownerInfo.FirstName;
            TxtLastName.Text = ownerInfo.LastName;
            TxtFatherName.Text = ownerInfo.FatherName;
            TxtGrandFatherName.Text = ownerInfo.GrandFatherName;
            TxtNationalID.Text = ownerInfo.NationalID;
            TxtSavePage.Text = ownerInfo.PageNo;
            TxtJuldNo.Text = ownerInfo.JuldNo;
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validated())
            {
                if (EntryType == 0)
                {
                    if (info != null)
                    {
                        info.Block = TxtBlock.Text;
                        info.District = TxtDistrict.Text;
                        info.East = TxtEast.Text;
                        info.Lantitude = TxtLantitude.Text;
                        info.Location = TxtLocation.Text;
                        info.Longtitude = TxtLongtitude.Text;
                        info.North = TxtNorth.Text;
                        info.Parcel = TxtParcel.Text;
                        info.South = TxtSouth.Text;
                        info.West = TxtWest.Text;
                        info.PropertyOwnerId = (int)ownerInfo.Id;
                        info.PropertyLevelId = (int)TxtPropertyLevel.EditValue;
                        info.TaxAmount = int.Parse(TxtCurrentTax.Text);
                        info.PaymentPeriodId = (int)TxtPaymentPeriod.EditValue;
                        bool Updated = Application.Property.UpdateProperty(info);
                        if (Updated)
                        {
                            Defaults.SucccessMessageBox();
                            Close();
                        }
                        else
                        {
                            Defaults.ErrorMessageBox();
                        }
                    }
                    else
                    {
                        Domain.Entities.PropertyInfo info = new Domain.Entities.PropertyInfo()
                        {
                            Block = TxtBlock.Text,
                            District = TxtDistrict.Text,
                            East = TxtEast.Text,
                            Lantitude = TxtLantitude.Text,
                            Location = TxtLocation.Text,
                            Longtitude = TxtLongtitude.Text,
                            North = TxtNorth.Text,
                            Parcel = TxtParcel.Text,
                            South = TxtSouth.Text,
                            West = TxtWest.Text,
                            PropertyOwnerId = (int)ownerInfo.Id,
                            PropertyLevelId = (int)TxtPropertyLevel.EditValue,
                            TaxAmount = int.Parse(TxtCurrentTax.Text),
                            PaymentPeriodId = (int)TxtPaymentPeriod.EditValue
                        };
                        bool Added = Application.Property.AddProperty(info);
                        if (Added)
                        {
                            Defaults.SucccessMessageBox();
                            Close();
                        }
                        else
                        {
                            Defaults.ErrorMessageBox();
                        }
                    }
                }
                else
                {
                    Domain.Entities.PropertyInfo info = new Domain.Entities.PropertyInfo()
                    {
                        Block = TxtBlock.Text,
                        District = TxtDistrict.Text,
                        East = TxtEast.Text,
                        Lantitude = TxtLantitude.Text,
                        Location = TxtLocation.Text,
                        Longtitude = TxtLongtitude.Text,
                        North = TxtNorth.Text,
                        Parcel = TxtParcel.Text,
                        South = TxtSouth.Text,
                        West = TxtWest.Text,
                        PropertyOwnerId = (int)ownerInfo.Id,
                        PropertyLevelId = (int)TxtPropertyLevel.EditValue,
                        TaxAmount = int.Parse(TxtCurrentTax.Text),
                        PaymentPeriodId = (int)TxtPaymentPeriod.EditValue
                    };
                    Domain.Entities.CurrentOwners currentOwners = new Domain.Entities.CurrentOwners()
                    {
                        IsCurrent = true,
                        Name = TxtOwnerName.Text,
                        Phone = TxtPhoneNo.Text
                    };
                    bool Added = Application.Property.AddProperty(info, currentOwners);
                    if (Added)
                    {
                        Defaults.SucccessMessageBox();
                        Close();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
            }
        }
        /// <summary>
        /// 1 only for OwnerInfo, 2 for both OwnerInfo and OwnerPhones
        /// </summary>
        private byte EntryType = 0;
        private new bool Validated()
        {
            bool result = true;
            EntryType = 0;
            if (ownerInfo == null)
            {
                result = false;
            }
            if (TxtLocation.Text.Length == 0)
            {
                TxtLocation.ErrorText = "موقیعت حتمي دی";
                result = false;
            }
            else
            {
                TxtLocation.ErrorText = string.Empty;
            }

            if (TxtCurrentTax.Text.Length == 0)
            {
                TxtCurrentTax.ErrorText = "محصول وټاکئ";
                result = false;
            }
            else if (int.Parse(TxtCurrentTax.Text) <= 0)
            {
                TxtCurrentTax.ErrorText = "محصول وټاکئ";
                result = false;
            }
            else
            {
                TxtCurrentTax.ErrorText = string.Empty;
            }

            if (TxtPropertyLevel.EditValue == null)
            {
                TxtPropertyLevel.ErrorText = "د ملکیت درجه وټاکئ";
                result = false;
            }
            else
            {
                TxtPropertyLevel.ErrorText = string.Empty;
            }

            if (TxtLongtitude.Text.Length == 0)
            {
                TxtLongtitude.ErrorText = "طول البلد حتمي دی";
                result = false;
            }
            else
            {
                TxtLongtitude.ErrorText = string.Empty;
            }

            if (TxtLantitude.Text.Length == 0)
            {
                TxtLantitude.ErrorText = "عرض البلد حتمي دی";
                result = false;
            }
            else
            {
                TxtLantitude.ErrorText = string.Empty;
            }

            if (TxtNorth.Text.Length == 0)
            {
                TxtNorth.ErrorText = "شمالي اړخ حتمي دی";
                result = false;
            }
            else
            {
                TxtNorth.ErrorText = string.Empty;
            }

            if (TxtSouth.Text.Length == 0)
            {
                TxtSouth.ErrorText = "جنوبي اړخ حتمي دی";
                result = false;
            }
            else
            {
                TxtSouth.ErrorText = string.Empty;
            }

            if (TxtWest.Text.Length == 0)
            {
                TxtWest.ErrorText = "لوېدیځ اړخ حتمي دی";
                result = false;
            }
            else
            {
                TxtWest.ErrorText = string.Empty;
            }

            if (TxtEast.Text.Length == 0)
            {
                TxtEast.ErrorText = "ختیځ اړخ حتمي دی";
                result = false;
            }
            else
            {
                TxtEast.ErrorText = string.Empty;
            }

            if (TxtDistrict.Text.Length == 0)
            {
                TxtDistrict.ErrorText = "ناحیه حتمي ده";
                result = false;
            }
            else
            {
                TxtDistrict.ErrorText = string.Empty;
            }

            if (TxtBlock.Text.Length == 0)
            {
                TxtBlock.ErrorText = "بلاک حتمي دی";
                result = false;
            }
            else
            {
                TxtBlock.ErrorText = string.Empty;
            }

            if (TxtParcel.Text.Length == 0)
            {
                TxtParcel.ErrorText = "پارسل حتمي دی";
                result = false;
            }
            else
            {
                TxtParcel.ErrorText = string.Empty;
            }

            if (TxtPaymentPeriod.EditValue == null)
            {
                TxtPaymentPeriod.ErrorText = "د تادیې د وکړي دوره حتمي ده";
                result = false;
            }
            else
            {
                TxtPaymentPeriod.ErrorText = string.Empty;
            }


            if (TxtOwnerName.Text.Length > 0 && info == null)
            {
                if (TxtPhoneNo.Text.Length == 0)
                {
                    TxtPhoneNo.ErrorText = "د موبایل شمېره حتمي ده";
                    result = false;
                }
                else
                {
                    TxtPhoneNo.ErrorText = string.Empty;
                }
            }

            if (TxtPhoneNo.Text.Length > 0 && info == null)
            {
                if (TxtOwnerName.Text.Length == 0)
                {
                    TxtOwnerName.ErrorText = "د اوسني مالک نوم حتمي دی";
                    result = false;
                }
                else
                {
                    TxtOwnerName.ErrorText = string.Empty;
                }
            }

            if (TxtOwnerName.Text.Length > 0 && TxtPhoneNo.Text.Length > 0)
            {
                EntryType = 1;
            }

            if (!result)
            {
                Defaults.MessageBox("!هیله ده فورم اصلاح کړئ");
            }
            return result;
        }

        private void TxtSearchKeywords_Leave(object sender, EventArgs e)
        {
            TxtSearchKeywords.ErrorText = string.Empty;
            if (TxtSearchKeywords.Text.Length > 0)
            {
                Domain.Entities.Owners owner = Application.Owners.GetByIdOrNationalId(TxtSearchKeywords.Text);
                if (owner != null)
                {
                    ownerInfo = owner;
                    TxtFirstName.Text = ownerInfo.FirstName;
                    TxtLastName.Text = ownerInfo.LastName;
                    TxtFatherName.Text = ownerInfo.FatherName;
                    TxtGrandFatherName.Text = ownerInfo.GrandFatherName;
                    TxtNationalID.Text = ownerInfo.NationalID;
                    TxtSavePage.Text = ownerInfo.PageNo;
                    TxtJuldNo.Text = ownerInfo.JuldNo;
                }
                else
                {
                    TxtSearchKeywords.ErrorText = "مالک نه سو پیدا";
                }
            }
            else
            {
                TxtSearchKeywords.ErrorText = "خانه خالي مه پرېږئ";
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            Owners.ListOwners owner = new Owners.ListOwners();
            if (owner.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ownerInfo = owner.OwnerInfo;
                TxtFirstName.Text = ownerInfo.FirstName;
                TxtLastName.Text = ownerInfo.LastName;
                TxtFatherName.Text = ownerInfo.FatherName;
                TxtGrandFatherName.Text = ownerInfo.GrandFatherName;
                TxtNationalID.Text = ownerInfo.NationalID;
                TxtSavePage.Text = ownerInfo.PageNo;
                TxtJuldNo.Text = ownerInfo.JuldNo;
            }
            owner.Dispose();
        }
    }
}