using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyApplication;

public partial class NewContact : System.Windows.Forms.Form
{
    private MainForm _mainForm;
    public NewContact(MainForm form) : base()
    {
        _mainForm = form;
        InitializeComponent();
        this.BringToFront();
        this.UpdateZOrder();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }
    public void ResetForm()
    {
        nameTextBox.Text = string.Empty;
        familyTextBox.Text = string.Empty;
        administrativePositionTextBox.Text = string.Empty;
        officePhoneTextBox.Text = string.Empty;
        mobilePhoneTextBox.Text = string.Empty;
        nameTextBox.Focus();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        nameTextBox.Text =
            Infrastructure.Utility
            .FixText(text: nameTextBox.Text);

        familyTextBox.Text =
            Infrastructure.Utility
            .FixText(text: familyTextBox.Text);

        administrativePositionTextBox.Text =
            Infrastructure.Utility
            .FixText(text: administrativePositionTextBox.Text);

        officePhoneTextBox.Text =
            Infrastructure.Utility
            .FixText(text: officePhoneTextBox.Text);

        mobilePhoneTextBox.Text =
            Infrastructure.Utility
            .FixText(text: mobilePhoneTextBox.Text);

        if (nameTextBox.Text == string.Empty
            || familyTextBox.Text == string.Empty
            || administrativePositionTextBox.Text == string.Empty
            || officePhoneTextBox.Text == string.Empty
            || mobilePhoneTextBox.Text == string.Empty)
        {
            var errorMessage =
                "لطفا تمامی فیلد ها را تکمیل کنید";

            System.Windows.Forms.MessageBox.Show(text: errorMessage);

            nameTextBox.Focus();

            return;
        }

        var errorMessages = string.Empty;

        if (officePhoneTextBox.Text.Length < 5)
        {
            errorMessages =
                "تلفن دفتر نمی تواند کمتر از 5 رقم باشد";

            officePhoneTextBox.Focus();

        }

        if (mobilePhoneTextBox.Text.Length < 11)
        {
            if (errorMessages != string.Empty)
            {
                errorMessages +=
                    System.Environment.NewLine;

                errorMessages +=
                    "شماره موبایل نمی تواند کمتر از 11 رقم باشد";

                officePhoneTextBox.Focus();
            }

            else
            {
                errorMessages =
                "شماره موبایل نمی تواند کمتر از 11 رقم باشد";

                mobilePhoneTextBox.Focus();
            }
        }


        if (errorMessages != string.Empty)
        {
            System.Windows.Forms
                .MessageBox.Show(text: errorMessages);

            return;
        }

        var newUser = new Domain.User();

        newUser.Name = nameTextBox.Text;

        newUser.LastName = familyTextBox.Text;

        newUser.Position = administrativePositionTextBox.Text;

        newUser.OfficePhone = officePhoneTextBox.Text;

        newUser.MobilePhone = mobilePhoneTextBox.Text;

        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext =
                new Persistence.DatabaseContext();
            databaseContext.Add(entity: newUser);
            databaseContext.SaveChanges();
            MessageBox.Show(text: "مخاطب اضافه گردید");
            _mainForm.RefreshContactDataGrid();
            Close();

        }
        catch (System.Exception ex)
        {
            System.Windows.Forms.MessageBox
                .Show(text: $"Error: {ex.Message}");
        }
        finally
        {
            databaseContext?.Dispose();
        }

    }

    private void NewContact_Load(object sender, EventArgs e)
    {

    }
}
