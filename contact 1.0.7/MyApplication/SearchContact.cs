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
using Domain;
using Microsoft.EntityFrameworkCore;

namespace MyApplication;

public partial class SearchContact : System.Windows.Forms.Form
{
    public static SearchContact? ActiveInstance { get; private set; }
    private List<User> users;
    private MainForm _mainForm;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public SearchContact(MainForm mainForm) : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    {
        _mainForm = mainForm;
        InitializeComponent();
        ActiveInstance = this;
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
        this.Dispose();
        Close();
    }

    private void searchButton_Click(object sender, EventArgs e)
    {
        Search();
    }

    private void Search()
    {
        Persistence.DatabaseContext? databaseContext = null;

        try
        {
            databaseContext =
                new DatabaseContext();

            searchByFamilyTextBox.Text =
                 Infrastructure.Utility
                 .FixText(text: searchByFamilyTextBox.Text);

            List<User> users;

            if (searchByFamilyTextBox.Text == string.Empty)
            {
                users = databaseContext.Users.ToList();
            }
            else
            {

                users =
                    databaseContext.Users
                    .Where(current => current.Name != null && current.LastName != null &&
                        current.LastName.ToLower().Contains(searchByFamilyTextBox.Text.ToLower()) ||
                        current.Name.ToLower().Contains(searchByFamilyTextBox.Text.ToLower()))
                    .ToList()
                    ;
            }

            searchDataGridView.DataSource = users;

            searchByFamilyTextBox.SelectAll();
            searchByFamilyTextBox.Focus();
        }
        catch (System.Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(text: ex.Message);

            searchByFamilyTextBox.Focus();
        }
        finally
        {
            databaseContext?.Dispose();
            databaseContext = null;
        }
    }

    private void SearchContact_Load(object sender, EventArgs e)
    {
        RefreshContactDataGrid();
    }
    public async void RefreshContactDataGrid()
    {
        Persistence.DatabaseContext? databaseContext = null;
        databaseContext = new Persistence.DatabaseContext();
        users = await databaseContext.Users.ToListAsync();
        searchDataGridView.DataSource = users;
        _mainForm.RefreshContactDataGrid();
    }
    //public void EditContact(User user)
    //{
    //    var editForm = new EditContactForm()
    //    { EditContactSelectedContact = user };
    //    editForm.Closed += EditForm_Closed;
    //    editForm.MdiParent = this;
    //    editForm.ShowDialog();
    //}

    //private void EditForm_Closed(object? sender, EventArgs e)
    //{
    //    if (sender is EditContactForm editForm && editForm.IsSuccess)
    //    {
    //        RefreshContactDataGrid();
    //    }
    //}
    private ContactInformationForm? MyContactInformationForm { get; set; }
    private void searchDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {

        if (e.RowIndex >= 0)
        {
            var searchContactSelectedContact =
                searchDataGridView.Rows[e.RowIndex].DataBoundItem as User;


            if (MyContactInformationForm == null || MyContactInformationForm.IsDisposed)
            {
                MyContactInformationForm = new ContactInformationForm(null, this)
                {
                    ContactInformationSelectedUser = searchContactSelectedContact,
                };
            }
            MyContactInformationForm.ShowDialog();
        }
    }

}