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

namespace MyApplication;

public partial class SearchContact : Infrastructure.BaseForm
{
    private List<User> users;
    private MainForm mainForm;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public SearchContact()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    {
        InitializeComponent();
        mainForm = new MainForm();
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
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
                new Persistence.DatabaseContext();

            searchByFamilyTextBox.Text =
                 Infrastructure.Utility
                 .FixText(text: searchByFamilyTextBox.Text);

            System.Collections.Generic.List<Domain.User> users;

            if (searchByFamilyTextBox.Text == string.Empty)
            {
                users =
                    databaseContext.Users
                    .ToList()
                    ;
            }
            else
            {

                users =
                    databaseContext.Users
                    .Where(current => current.Name != null && current.LastName != null &&
                        current.LastName.ToLower().Contains(searchByFamilyTextBox.Text.ToLower()))
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
        Persistence.DatabaseContext? databaseContext = null;

        databaseContext = new Persistence.DatabaseContext();

        users = databaseContext.Users.ToList();

        searchDataGridView.DataSource = users;

        searchDataGridView.Update();
        searchDataGridView.Refresh();


    }
    private void searchDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var selectedUser =
           searchDataGridView.Rows[e.RowIndex].DataBoundItem as
           Domain.User;

        if (selectedUser != null)
        {
            var contactInformationForm = new ContactInformationForm()
            {
                SelectedUser = selectedUser,
            };

            contactInformationForm.ShowDialog();

        }
    }

}