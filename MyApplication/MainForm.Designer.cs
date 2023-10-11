namespace MyApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newContactToolStripMenuItem = new ToolStripMenuItem();
            searchContactToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripMenuItem = new ToolStripMenuItem();
            searchContactButton = new Dtat.Windows.Forms.Button();
            newContactButton = new Dtat.Windows.Forms.Button();
            dateTimePicker1 = new DateTimePicker();
            exitButton = new Dtat.Windows.Forms.Button();
            phoneBookDataGridView = new Dtat.Windows.Forms.DataGridView();
            dateTimePicker2 = new DateTimePicker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(807, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newContactToolStripMenuItem, searchContactToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newContactToolStripMenuItem
            // 
            newContactToolStripMenuItem.Name = "newContactToolStripMenuItem";
            newContactToolStripMenuItem.Size = new Size(180, 22);
            newContactToolStripMenuItem.Text = "&New Contact";
            newContactToolStripMenuItem.Click += newContactToolStripMenuItem_Click;
            // 
            // searchContactToolStripMenuItem
            // 
            searchContactToolStripMenuItem.Name = "searchContactToolStripMenuItem";
            searchContactToolStripMenuItem.Size = new Size(180, 22);
            searchContactToolStripMenuItem.Text = "&Search Contact";
            searchContactToolStripMenuItem.Click += searchContactToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, toolStripSeparator2 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(180, 22);
            refreshToolStripMenuItem.Text = "&Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // searchContactButton
            // 
            searchContactButton.Location = new Point(12, 476);
            searchContactButton.Name = "searchContactButton";
            searchContactButton.Size = new Size(75, 23);
            searchContactButton.TabIndex = 0;
            searchContactButton.Text = "&Search Contact";
            searchContactButton.UseVisualStyleBackColor = true;
            searchContactButton.Click += searchContactButton_Click;
            // 
            // newContactButton
            // 
            newContactButton.Location = new Point(93, 476);
            newContactButton.Name = "newContactButton";
            newContactButton.Size = new Size(75, 23);
            newContactButton.TabIndex = 1;
            newContactButton.Text = "&New Contact";
            newContactButton.UseVisualStyleBackColor = true;
            newContactButton.Click += newContactButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Location = new Point(595, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(720, 476);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "E&xit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // phoneBookDataGridView
            // 
            phoneBookDataGridView.AllowUserToAddRows = false;
            phoneBookDataGridView.AllowUserToDeleteRows = false;
            phoneBookDataGridView.AllowUserToResizeRows = false;
            phoneBookDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            phoneBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phoneBookDataGridView.Location = new Point(12, 311);
            phoneBookDataGridView.MultiSelect = false;
            phoneBookDataGridView.Name = "phoneBookDataGridView";
            phoneBookDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            phoneBookDataGridView.RowHeadersVisible = false;
            phoneBookDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            phoneBookDataGridView.RowTemplate.Height = 25;
            phoneBookDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            phoneBookDataGridView.Size = new Size(783, 157);
            phoneBookDataGridView.TabIndex = 7;
            phoneBookDataGridView.CellDoubleClick += phoneBookDataGridView_CellDoubleClick;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(489, 27);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // MainForm
            // 
            AcceptButton = searchContactButton;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = exitButton;
            ClientSize = new Size(807, 511);
            Controls.Add(dateTimePicker2);
            Controls.Add(exitButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(newContactButton);
            Controls.Add(searchContactButton);
            Controls.Add(menuStrip1);
            Controls.Add(phoneBookDataGridView);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1200, 550);
            MinimumSize = new Size(823, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Book";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newContactToolStripMenuItem;
        private ToolStripMenuItem searchContactToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Dtat.Windows.Forms.Button searchContactButton;
        private Dtat.Windows.Forms.Button newContactButton;
        private DateTimePicker dateTimePicker1;
        private Dtat.Windows.Forms.Button exitButton;
        private DateTimePicker dateTimePicker2;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        public Dtat.Windows.Forms.DataGridView phoneBookDataGridView;
    }
}