namespace MyApplication
{
    partial class ContactInformationForm
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
            editButton = new Dtat.Windows.Forms.Button();
            nameTextBlock = new Dtat.Windows.Forms.Label();
            contactLastNameTextBlock = new Dtat.Windows.Forms.Label();
            contactPositionTextBlock = new Dtat.Windows.Forms.Label();
            contactOfficePhoneTextBlock = new Dtat.Windows.Forms.Label();
            contactMobilePhoneTextBlock = new Dtat.Windows.Forms.Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Location = new Point(12, 38);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new Size(63, 15);
            familyLabel.TabIndex = 2;
            familyLabel.Text = "Last Name";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(12, 67);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(50, 15);
            positionLabel.TabIndex = 4;
            positionLabel.Text = "Position";
            // 
            // officePhoneLabel
            // 
            officePhoneLabel.AutoSize = true;
            officePhoneLabel.Location = new Point(12, 95);
            officePhoneLabel.Name = "officePhoneLabel";
            officePhoneLabel.Size = new Size(76, 15);
            officePhoneLabel.TabIndex = 6;
            officePhoneLabel.Text = "Office Phone";
            // 
            // mobileOfficeLabel
            // 
            mobileOfficeLabel.AutoSize = true;
            mobileOfficeLabel.Location = new Point(12, 124);
            mobileOfficeLabel.Name = "mobileOfficeLabel";
            mobileOfficeLabel.Size = new Size(81, 15);
            mobileOfficeLabel.TabIndex = 8;
            mobileOfficeLabel.Text = "Mobile Phone";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(182, 150);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 11;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(12, 150);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 10;
            editButton.Text = "&Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // nameTextBlock
            // 
            nameTextBlock.AutoSize = true;
            nameTextBlock.BorderStyle = BorderStyle.FixedSingle;
            nameTextBlock.Location = new Point(96, 9);
            nameTextBlock.Name = "nameTextBlock";
            nameTextBlock.Size = new Size(40, 17);
            nameTextBlock.TabIndex = 12;
            nameTextBlock.Text = "label1";
            // 
            // contactLastNameTextBlock
            // 
            contactLastNameTextBlock.AutoSize = true;
            contactLastNameTextBlock.BorderStyle = BorderStyle.FixedSingle;
            contactLastNameTextBlock.Location = new Point(96, 38);
            contactLastNameTextBlock.Name = "contactLastNameTextBlock";
            contactLastNameTextBlock.Size = new Size(40, 17);
            contactLastNameTextBlock.TabIndex = 13;
            contactLastNameTextBlock.Text = "label2";
            // 
            // contactPositionTextBlock
            // 
            contactPositionTextBlock.AutoSize = true;
            contactPositionTextBlock.BorderStyle = BorderStyle.FixedSingle;
            contactPositionTextBlock.Location = new Point(96, 67);
            contactPositionTextBlock.Name = "contactPositionTextBlock";
            contactPositionTextBlock.Size = new Size(40, 17);
            contactPositionTextBlock.TabIndex = 14;
            contactPositionTextBlock.Text = "label3";
            // 
            // contactOfficePhoneTextBlock
            // 
            contactOfficePhoneTextBlock.AutoSize = true;
            contactOfficePhoneTextBlock.BorderStyle = BorderStyle.FixedSingle;
            contactOfficePhoneTextBlock.Location = new Point(96, 95);
            contactOfficePhoneTextBlock.Name = "contactOfficePhoneTextBlock";
            contactOfficePhoneTextBlock.Size = new Size(40, 17);
            contactOfficePhoneTextBlock.TabIndex = 15;
            contactOfficePhoneTextBlock.Text = "label4";
            // 
            // contactMobilePhoneTextBlock
            // 
            contactMobilePhoneTextBlock.AutoSize = true;
            contactMobilePhoneTextBlock.BorderStyle = BorderStyle.FixedSingle;
            contactMobilePhoneTextBlock.Location = new Point(96, 124);
            contactMobilePhoneTextBlock.Name = "contactMobilePhoneTextBlock";
            contactMobilePhoneTextBlock.Size = new Size(40, 17);
            contactMobilePhoneTextBlock.TabIndex = 16;
            contactMobilePhoneTextBlock.Text = "label5";
            // 
            // ContactInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 177);
            Controls.Add(contactMobilePhoneTextBlock);
            Controls.Add(contactOfficePhoneTextBlock);
            Controls.Add(contactPositionTextBlock);
            Controls.Add(contactLastNameTextBlock);
            Controls.Add(nameTextBlock);
            Controls.Add(editButton);
            Controls.Add(closeButton);
            Controls.Add(mobileOfficeLabel);
            Controls.Add(officePhoneLabel);
            Controls.Add(positionLabel);
            Controls.Add(familyLabel);
            Controls.Add(nameLabel);
            MaximumSize = new Size(800, 216);
            MinimumSize = new Size(285, 216);
            Name = "ContactInformationForm";
            Text = "Contact Information";
            Load += ContactInformationForm_Load;
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
        private Dtat.Windows.Forms.Button editButton;
        private Dtat.Windows.Forms.Label nameTextBlock;
        private Dtat.Windows.Forms.Label contactLastNameTextBlock;
        private Dtat.Windows.Forms.Label contactPositionTextBlock;
        private Dtat.Windows.Forms.Label contactOfficePhoneTextBlock;
        private Dtat.Windows.Forms.Label contactMobilePhoneTextBlock;
    }
}