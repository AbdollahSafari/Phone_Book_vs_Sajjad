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
    public Domain.User? SelectedUser { get; set; }
    private MainForm mainForm;
    public ContactInformationForm()
    {
        InitializeComponent();
        mainForm = new MainForm();
    }


    private void closeButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ContactInformationForm_Load(object sender, EventArgs e)
    {
        nameTextBlock.Text = SelectedUser.Name;
        contactLastNameTextBlock.Text = SelectedUser.LastName;
        contactPositionTextBlock.Text = SelectedUser.Position;
        contactOfficePhoneTextBlock.Text = SelectedUser.OfficePhone;
        contactMobilePhoneTextBlock.Text = SelectedUser.MobilePhone;
    }

    private EditContactForm? MyEditeContactForm { get; set; }
    private void editButton_Click(object sender, EventArgs e)
    {
        if (MyEditeContactForm == null || MyEditeContactForm.IsDisposed)
        {
            MyEditeContactForm = new EditContactForm
            {
                SelectedContact = SelectedUser,
            };
        }
        MyEditeContactForm.Show();
        Close();
    }
}
