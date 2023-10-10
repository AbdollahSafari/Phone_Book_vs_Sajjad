using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace MyApplication;

public partial class EditContactForm : Infrastructure.BaseForm
{
    public EditContactForm()
    {
        InitializeComponent();
    }
    public Domain.User? SelectedContact { get; set; }

    Persistence.DatabaseContext? databaseContext = null;

    private void EditContactForm_Load(object sender, EventArgs e)
    {
        nameTextBox.Text = SelectedContact.Name;
        lastNameTextBox.Text = SelectedContact.LastName;
        positionTextBox.Text = SelectedContact.Position;
        officePhoneTextBox.Text = SelectedContact.OfficePhone;
        mobilePhoneTextBox.Text = SelectedContact.MobilePhone;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        try
        {
            databaseContext = new Persistence.DatabaseContext();
            var foundedUser = databaseContext.Users.Where(c => c.Id == SelectedContact.Id).FirstOrDefault();
            if (foundedUser == null)
            {
                Close();
                return;
            }

            foundedUser.Name = nameTextBox.Text;

            foundedUser.LastName = lastNameTextBox.Text;

            foundedUser.Position = positionTextBox.Text;

            foundedUser.OfficePhone = officePhoneTextBox.Text;

            foundedUser.MobilePhone = mobilePhoneTextBox.Text;

            nameTextBox.Text = Infrastructure.Utility
                .FixText(text: nameTextBox.Text);

            lastNameTextBox.Text = Infrastructure.Utility
                .FixText(text: lastNameTextBox.Text);

            positionTextBox.Text = Infrastructure.Utility
                .FixText(text: positionTextBox.Text);

            officePhoneTextBox.Text = Infrastructure.Utility
                .FixText(text: officePhoneTextBox.Text);

            mobilePhoneTextBox.Text = Infrastructure.Utility
                .FixText(text: mobilePhoneTextBox.Text);

            if (nameTextBox.Text == string.Empty
                || lastNameTextBox.Text == string.Empty
                || positionTextBox.Text == string.Empty
                || officePhoneTextBox.Text == string.Empty
                || mobilePhoneTextBox.Text == string.Empty)
            {
                var errorMessage = "لطفا تمامی فیلد ها را تکمیل کنید";
                MessageBox.Show(text: errorMessage);

                nameTextBox.Focus();

                return;
            }

            var errorMessages = string.Empty;

            if (officePhoneTextBox.Text.Length < 5)
            {
                errorMessages = "تلفن دفتر نمی تواند کمتر از 5 رقم باشد";
                officePhoneTextBox.Focus();
            }

            if (mobilePhoneTextBox.Text.Length < 11)
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += Environment.NewLine;
                    errorMessages += "شماره موبایل نمی تواند کمتر از 11 رقم باشد";
                    officePhoneTextBox.Focus();
                }

                else
                {
                    errorMessages = "شماره موبایل نمی تواند کمتر از 11 رقم باشد";

                    mobilePhoneTextBox.Focus();
                }
            }


            if (errorMessages != string.Empty)
            {
                    MessageBox.Show(text: errorMessages);

                return;
            }

            databaseContext.SaveChanges();

            MessageBox.Show(text: "تغییرات با موفقیت اعمال شد");

            Close();

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }
        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }
    }

    private void deleteContactButton_Click(object sender, EventArgs e)
    {
        try
        {
            databaseContext = new Persistence.DatabaseContext();
            var foundedUser = databaseContext.Users.Where(c => c.Id == SelectedContact.Id).FirstOrDefault();
            var dialogResult = MessageBox.Show(
            defaultButton: MessageBoxDefaultButton.Button2,
            text: "آیا از حذف مخاطب اطمینان دارید؟",
            buttons: MessageBoxButtons.YesNo,
            caption: "حذف مخاطب",
            icon: MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                databaseContext.Remove(foundedUser);

                databaseContext.SaveChanges();
                
                Close();

            }

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
        }

        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }

        
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
