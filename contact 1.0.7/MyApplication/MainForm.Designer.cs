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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            searchContactButton = new Dtat.Windows.Forms.Button();
            newContactButton = new Dtat.Windows.Forms.Button();
            timePicker = new DateTimePicker();
            exitButton = new Dtat.Windows.Forms.Button();
            phoneBookDataGridView = new Dtat.Windows.Forms.DataGridView();
            monthCalendar = new MonthCalendar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).BeginInit();
            SuspendLayout();
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
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(694, 27);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(101, 23);
            timePicker.TabIndex = 5;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            phoneBookDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phoneBookDataGridView.Location = new Point(12, 12);
            phoneBookDataGridView.MultiSelect = false;
            phoneBookDataGridView.Name = "phoneBookDataGridView";
            phoneBookDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            phoneBookDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            phoneBookDataGridView.RowHeadersVisible = false;
            phoneBookDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            phoneBookDataGridView.RowTemplate.Height = 25;
            phoneBookDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            phoneBookDataGridView.Size = new Size(389, 458);
            phoneBookDataGridView.TabIndex = 7;
            phoneBookDataGridView.CellDoubleClick += phoneBookDataGridView_CellDoubleClick;
            // 
            // monthCalendar
            // 
            monthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthCalendar.FirstDayOfWeek = Day.Saturday;
            monthCalendar.Location = new Point(413, 62);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowWeekNumbers = true;
            monthCalendar.TabIndex = 8;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AcceptButton = searchContactButton;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = exitButton;
            ClientSize = new Size(807, 511);
            Controls.Add(monthCalendar);
            Controls.Add(phoneBookDataGridView);
            Controls.Add(searchContactButton);
            Controls.Add(newContactButton);
            Controls.Add(exitButton);
            Controls.Add(timePicker);
            MaximumSize = new Size(823, 550);
            MinimumSize = new Size(823, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Book";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)phoneBookDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Dtat.Windows.Forms.Button searchContactButton;
        private Dtat.Windows.Forms.Button newContactButton;
        private DateTimePicker timePicker;
        private Dtat.Windows.Forms.Button exitButton;
        public Dtat.Windows.Forms.DataGridView phoneBookDataGridView;
        public MonthCalendar monthCalendar;
        private System.Windows.Forms.Timer timer1;
    }
}