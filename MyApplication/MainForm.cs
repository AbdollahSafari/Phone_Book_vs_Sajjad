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

public partial class MainForm : System.Windows.Forms.Form
{

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public MainForm() : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        InitializeComponent();
    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private List<User> users;

    private void MainForm_Load(object sender, EventArgs e)
    {
        RefreshContactDataGrid();
    }

    public void RefreshContactDataGrid()
    {
        Persistence.DatabaseContext? databaseContext = null;
        databaseContext = new Persistence.DatabaseContext();
        users = databaseContext.Users.ToList();
        phoneBookDataGridView.DataSource = users;
    }

    private SearchContact? MysearchContact { get; set; }

    private void searchContactButton_Click(object sender, EventArgs e)
    {
        if (MysearchContact == null || MysearchContact.IsDisposed)
        {
            MysearchContact = new SearchContact
            {
                MdiParent = this,
            };
        }

        MysearchContact.Show();

    }
    private NewContact? MynewContact { get; set; }

    private void newContactButton_Click(object sender, EventArgs e)
    {
        if (MynewContact == null || MynewContact.IsDisposed)
        {
            MynewContact = new NewContact(this)
            {
                MdiParent = this,
            };
        }


        MynewContact.Show();


    }

    private void newContactToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MynewContact == null || MynewContact.IsDisposed)
        {
            MynewContact = new NewContact(this)
            {
                MdiParent = this,
                
            };
        }
        MynewContact.Show();
        MynewContact.BringToFront();
        MynewContact.TopMost = true;
        phoneBookDataGridView.SendToBack();
    }

    private void searchContactToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MysearchContact == null || MysearchContact.IsDisposed)
        {
            MysearchContact = new SearchContact
            {
                MdiParent = this,
            };
        }

        MysearchContact.Show();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private ContactInformationForm? MYContactInformationForm { set; get; }
    private void phoneBookDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var selectedUser =
            phoneBookDataGridView.Rows[e.RowIndex].DataBoundItem as User;

        if (selectedUser != null)
        {
            var contactInformationForm = new ContactInformationForm()
            {
                SelectedUser = selectedUser,
                MdiParent = this,
            };

            contactInformationForm.Show();
        }
    }

    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RefreshContactDataGrid();
    }
}
