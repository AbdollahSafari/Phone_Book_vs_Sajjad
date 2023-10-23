namespace MyApplication
{
    partial class SearchContact
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
            searchButton = new Dtat.Windows.Forms.Button();
            searchDataGridView = new Dtat.Windows.Forms.DataGridView();
            searchByFamilyLabel = new Dtat.Windows.Forms.Label();
            searchByFamilyTextBox = new Dtat.Windows.Forms.TextBox();
            closeButton = new Dtat.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(12, 273);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "S&earch";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchDataGridView
            // 
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(12, 35);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.RowHeadersVisible = false;
            searchDataGridView.RowTemplate.Height = 25;
            searchDataGridView.Size = new Size(345, 232);
            searchDataGridView.TabIndex = 2;
            searchDataGridView.CellDoubleClick += searchDataGridView_CellDoubleClick;
            // 
            // searchByFamilyLabel
            // 
            searchByFamilyLabel.AutoSize = true;
            searchByFamilyLabel.Location = new Point(12, 9);
            searchByFamilyLabel.Name = "searchByFamilyLabel";
            searchByFamilyLabel.Size = new Size(45, 15);
            searchByFamilyLabel.TabIndex = 0;
            searchByFamilyLabel.Text = "&Search ";
            // 
            // searchByFamilyTextBox
            // 
            searchByFamilyTextBox.Location = new Point(63, 6);
            searchByFamilyTextBox.MaxLength = 11;
            searchByFamilyTextBox.Name = "searchByFamilyTextBox";
            searchByFamilyTextBox.PlaceholderText = "Search By Name Or LastName";
            searchByFamilyTextBox.Size = new Size(294, 23);
            searchByFamilyTextBox.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(232, 273);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // SearchContact
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(361, 308);
            Controls.Add(closeButton);
            Controls.Add(searchByFamilyTextBox);
            Controls.Add(searchByFamilyLabel);
            Controls.Add(searchButton);
            Controls.Add(searchDataGridView);
            MaximumSize = new Size(800, 347);
            MinimumSize = new Size(377, 347);
            Name = "SearchContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search Contact";
            Load += SearchContact_Load;
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Button searchButton;
        private Dtat.Windows.Forms.DataGridView searchDataGridView;
        private Dtat.Windows.Forms.Label searchByFamilyLabel;
        private Dtat.Windows.Forms.TextBox searchByFamilyTextBox;
        private Dtat.Windows.Forms.Button closeButton;
    }
}