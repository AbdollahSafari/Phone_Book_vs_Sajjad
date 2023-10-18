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

public partial class MainForm : System.Windows.Forms.Form
{
    public static MainForm? ActiveInstance { get; private set; }
    private System.Threading.Timer _timer;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public MainForm() : base()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        InitializeComponent();
        ActiveInstance = this;

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private List<User> users;

    private void MainForm_Load(object sender, EventArgs e)
    {
        RefreshContactDataGrid();
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        timer1.Interval = (1 * 1000);
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Start();

    }

    public async void RefreshContactDataGrid()
    {
        Persistence.DatabaseContext? databaseContext = null;
        databaseContext = new Persistence.DatabaseContext();
        users = await databaseContext.Users.ToListAsync();
        phoneBookDataGridView.DataSource = users;
    }

    private SearchContact? MysearchContact { get; set; }

    private void searchContactButton_Click(object sender, EventArgs e)
    {
        if (MysearchContact == null || MysearchContact.IsDisposed)
        {
            MysearchContact = new SearchContact(this)
            {

            };
        }

        MysearchContact.ShowDialog();

    }

    private NewContact? MynewContact { get; set; }

    private void newContactButton_Click(object sender, EventArgs e)
    {
        if (MynewContact == null || MynewContact.IsDisposed)
        {
            MynewContact = new NewContact(this)
            {

            };
        }
        MynewContact.ShowDialog();
    }

    private ContactInformationForm? MyContactInformationForm { get; set; }
    private void phoneBookDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var mainFormSelectedUser =
                phoneBookDataGridView.Rows[e.RowIndex].DataBoundItem as User;


            if (MyContactInformationForm == null || MyContactInformationForm.IsDisposed)
            {
                MyContactInformationForm = new ContactInformationForm(this, null)
                {
                    ContactInformationSelectedUser = mainFormSelectedUser,
                };
            }
            MyContactInformationForm.ShowDialog();

        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        timePicker.Value = DateTime.Now;
        timePicker.Enabled = true;
        timePicker.Update();
        timePicker.Refresh();
    }


}
