namespace MyApplication
{
    partial class EditContactForm
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
            nameLabel = new Dtat.Windows.Forms.Label();
            familyLabel = new Dtat.Windows.Forms.Label();
            positionLabel = new Dtat.Windows.Forms.Label();
            officePhoneLabel = new Dtat.Windows.Forms.Label();
            mobileOfficeLabel = new Dtat.Windows.Forms.Label();
            closeButton = new Dtat.Windows.Forms.Button();
            saveButton = new Dtat.Windows.Forms.Button();
            nameTextBox = new Dtat.Windows.Forms.TextBox();
            lastNameTextBox = new Dtat.Windows.Forms.TextBox();
            positionTextBox = new Dtat.Windows.Forms.TextBox();
            officePhoneTextBox = new Dtat.Windows.Forms.TextBox();
            mobilePhoneTextBox = new Dtat.Windows.Forms.TextBox();
            deleteContactButton = new Dtat.Windows.Forms.Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(7, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Location = new Point(7, 38);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new Size(63, 15);
            familyLabel.TabIndex = 2;
            familyLabel.Text = "Last Name";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(7, 67);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(50, 15);
            positionLabel.TabIndex = 4;
            positionLabel.Text = "Position";
            // 
            // officePhoneLabel
            // 
            officePhoneLabel.AutoSize = true;
            officePhoneLabel.Location = new Point(7, 95);
            officePhoneLabel.Name = "officePhoneLabel";
            officePhoneLabel.Size = new Size(76, 15);
            officePhoneLabel.TabIndex = 6;
            officePhoneLabel.Text = "Office Phone";
            // 
            // mobileOfficeLabel
            // 
            mobileOfficeLabel.AutoSize = true;
            mobileOfficeLabel.Location = new Point(7, 124);
            mobileOfficeLabel.Name = "mobileOfficeLabel";
            mobileOfficeLabel.Size = new Size(81, 15);
            mobileOfficeLabel.TabIndex = 8;
            mobileOfficeLabel.Text = "Mobile Phone";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(256, 150);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 12;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(94, 150);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(94, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(237, 23);
            nameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lastNameTextBox.Location = new Point(94, 35);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(237, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // positionTextBox
            // 
            positionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            positionTextBox.Location = new Point(94, 63);
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(237, 23);
            positionTextBox.TabIndex = 5;
            // 
            // officePhoneTextBox
            // 
            officePhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            officePhoneTextBox.Location = new Point(94, 92);
            officePhoneTextBox.Name = "officePhoneTextBox";
            officePhoneTextBox.Size = new Size(237, 23);
            officePhoneTextBox.TabIndex = 7;
            // 
            // mobilePhoneTextBox
            // 
            mobilePhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mobilePhoneTextBox.Location = new Point(94, 121);
            mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            mobilePhoneTextBox.Size = new Size(237, 23);
            mobilePhoneTextBox.TabIndex = 9;
            // 
            // deleteContactButton
            // 
            deleteContactButton.Location = new Point(175, 150);
            deleteContactButton.Name = "deleteContactButton";
            deleteContactButton.Size = new Size(75, 23);
            deleteContactButton.TabIndex = 11;
            deleteContactButton.Text = "&Delete";
            deleteContactButton.UseVisualStyleBackColor = true;
            deleteContactButton.Click += deleteContactButton_Click;
            // 
            // EditContactForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(336, 177);
            Controls.Add(deleteContactButton);
            Controls.Add(mobilePhoneTextBox);
            Controls.Add(officePhoneTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(saveButton);
            Controls.Add(closeButton);
            Controls.Add(mobileOfficeLabel);
            Controls.Add(officePhoneLabel);
            Controls.Add(positionLabel);
            Controls.Add(familyLabel);
            Controls.Add(nameLabel);
            MaximumSize = new Size(800, 216);
            MinimumSize = new Size(352, 216);
            Name = "EditContactForm";
            Text = "Edit or Delete Contact";
            Load += EditContactForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Label nameLabel;
        private Dtat.Windows.Forms.Label familyLabel;
        private Dtat.Windows.Forms.Label positionLabel;
        private Dtat.Windows.Forms.Label officePhoneLabel;
        private Dtat.Windows.Forms.Label mobileOfficeLabel;
        private Dtat.Windows.Forms.Button closeButton;
        private Dtat.Windows.Forms.Button saveButton;
        private Dtat.Windows.Forms.TextBox nameTextBox;
        private Dtat.Windows.Forms.TextBox lastNameTextBox;
        private Dtat.Windows.Forms.TextBox positionTextBox;
        private Dtat.Windows.Forms.TextBox officePhoneTextBox;
        private Dtat.Windows.Forms.TextBox mobilePhoneTextBox;
        private Dtat.Windows.Forms.Button deleteContactButton;
    }
}