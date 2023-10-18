using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace MyApplication;

public partial class EditContactForm : System.Windows.Forms.Form
{
    private ContactInformationForm _contactInformationForm;
    public EditContactForm(ContactInformationForm contactInformationForm) : base()
    {

        InitializeComponent();
        _contactInformationForm = contactInformationForm;
    }


    public User? EditContactSelectedContact { get; set; }
    public bool IsSuccess { get; internal set; }

    Persistence.DatabaseContext? databaseContext = null;

    private void EditContactForm_Load(object sender, EventArgs e)
    {
        nameTextBox.Text = EditContactSelectedContact.Name;
        lastNameTextBox.Text = EditContactSelectedContact.LastName;
        positionTextBox.Text = EditContactSelectedContact.Position;
        officePhoneTextBox.Text = EditContactSelectedContact.OfficePhone;
        mobilePhoneTextBox.Text = EditContactSelectedContact.MobilePhone;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        Persistence.DatabaseContext? databaseContext = null;
        try
        {
            databaseContext = new Persistence.DatabaseContext();
            var foundedUser = databaseContext.Users.Where(c => c.Id == EditContactSelectedContact.Id).FirstOrDefault();
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

            databaseContext =
               new Persistence.DatabaseContext();
            databaseContext.Update(entity: foundedUser);
            databaseContext.SaveChanges();

            MessageBox.Show(text: "تغییرات با موفقیت اعمال شد");
            _contactInformationForm.ContactInformationSelectedUser = foundedUser;
            _contactInformationForm.LoadContactInformation();
            _contactInformationForm.RefreshContactInformation();
            this.Dispose();
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

    private void closeButton_Click(object sender, EventArgs e)
    {
        this.Dispose();
        Close();
    }
}
