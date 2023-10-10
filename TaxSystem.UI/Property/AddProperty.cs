using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;

namespace TaxSystem.UI.Property
{
    public partial class AddProperty : XtraForm
    {
        private Domain.Entities.Owners thisOwner;
        public AddProperty()
        {
            InitializeComponent();

            TxtOwner.Properties.DataSource = Application.Owners.GetAll();
        }

        private void TxtOwner_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtOwner.EditValue != null)
            {
                thisOwner = (Domain.Entities.Owners)TxtOwner.EditValue;
                TxtOwnerName.Text = thisOwner.FirstName;
            }
        }

        private void BtnSelectPerson_Click(object sender, EventArgs e)
        {
            Owners.ListOwners owner = new Owners.ListOwners();
            if (owner.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                thisOwner = owner.thisOwner;
            }
            owner.Dispose();
            TxtOwner.Text = thisOwner.FirstName;
            TxtOwnerName.Text = thisOwner.FirstName;
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Validated())
            {
                if (EntryType == 0)
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
                        PropertyOwnerId = thisOwner.Id
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
                        PropertyOwnerId = thisOwner.Id
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
            if (TxtLocation.Text.Length == 0)
            {
                TxtLocation.ErrorText = "موقیعت حتمي دی";
                result = false;
            }
            else
            {
                TxtLocation.ErrorText = string.Empty;
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

            if (thisOwner == null)
            {
                TxtOwner.ErrorText = "مالک انتخاب کړئ";
                result = false;
            }
            else
            {
                TxtOwner.ErrorText = string.Empty;
            }

            if (TxtOwnerName.Text.Length > 0)
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

            if (TxtPhoneNo.Text.Length > 0)
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
            return result;

        }
    }
}