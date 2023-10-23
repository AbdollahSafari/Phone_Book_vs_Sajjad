using Domain;
using Persistence;
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

public partial class ContactInformationForm : Infrastructure.BaseForm
{
    public User? ContactInformationSelectedUser { get; set; }

    private MainForm _mainForm;
    private SearchContact _searchContact;
    public ContactInformationForm(MainForm mainForm, SearchContact searchContact)
    {
        InitializeComponent();
        _mainForm = mainForm;
        _searchContact = searchContact;
    }



    private void closeButton_Click(object sender, EventArgs e)
    {
        this.Dispose();
        Close();
    }

    private void ContactInformationForm_Load(object sender, EventArgs e)
    {
        LoadContactInformation();
    }

    private EditContactForm? MyEditeContactForm { get; set; }
    private void editButton_Click(object sender, EventArgs e)
    {
        if (MyEditeContactForm == null || MyEditeContactForm.IsDisposed)
        {
            MyEditeContactForm = new EditContactForm(this)
            {
                EditContactSelectedContact = ContactInformationSelectedUser,
            };
        }
        MyEditeContactForm.ShowDialog();

    }
    DatabaseContext? databaseContext = null;
    private void deleteContactButton_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show(
        defaultButton: MessageBoxDefaultButton.Button2,
        text: "آیا از حذف مخاطب اطمینان دارید؟",
        buttons: MessageBoxButtons.YesNo,
        caption: "حذف مخاطب",
        icon: MessageBoxIcon.Question
        );
        if (dialogResult == DialogResult.Yes)
        {
            try
            {
                databaseContext = new();
                var foundedUser = databaseContext.Users.Where(c => c.Id == ContactInformationSelectedUser.Id).FirstOrDefault();
                databaseContext.Remove(foundedUser);
                databaseContext.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            finally 
            {
                databaseContext?.Dispose();
            }
            if (_mainForm is not null)
            {
                _mainForm.RefreshContactDataGrid();
            }
            this.Dispose();
            CloseInformationForm();
        }
       
    }
    private void CloseInformationForm()
    {
        if (_mainForm is not null)
        {
            _mainForm.RefreshContactDataGrid();
        }
        if (_searchContact is not null)
        {
            _searchContact.RefreshContactDataGrid();
        }
        this.Dispose();
        Close();
    }
    public void RefreshContactInformation()
    {
        if (_mainForm is not null)
        {
            _mainForm.RefreshContactDataGrid(); 
        }

        if (_searchContact is not null)
        {
            _searchContact.RefreshContactDataGrid();
        }
    }
    public void LoadContactInformation()
    {
        nameTextBlock.Text = ContactInformationSelectedUser.Name;
        contactLastNameTextBlock.Text = ContactInformationSelectedUser.LastName;
        contactPositionTextBlock.Text = ContactInformationSelectedUser.Position;
        contactOfficePhoneTextBlock.Text = ContactInformationSelectedUser.OfficePhone;
        contactMobilePhoneTextBlock.Text = ContactInformationSelectedUser.MobilePhone;
    }
}
