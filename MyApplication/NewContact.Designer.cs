namespace MyApplication
{
    partial class NewContact
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
            saveButton = new Dtat.Windows.Forms.Button();
            resetButton = new Dtat.Windows.Forms.Button();
            cancelButton = new Dtat.Windows.Forms.Button();
            mobilePhoneTextBox = new Dtat.Windows.Forms.TextBox();
            officePhoneTextBox = new Dtat.Windows.Forms.TextBox();
            administrativePositionTextBox = new Dtat.Windows.Forms.TextBox();
            familyTextBox = new Dtat.Windows.Forms.TextBox();
            nameTextBox = new Dtat.Windows.Forms.TextBox();
            nameLabel = new Dtat.Windows.Forms.Label();
            familyLabel = new Dtat.Windows.Forms.Label();
            administrativePositionLabel = new Dtat.Windows.Forms.Label();
            officePhoneLabel = new Dtat.Windows.Forms.Label();
            mobilePhoneLabel = new Dtat.Windows.Forms.Label();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(99, 151);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "&Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(180, 151);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 11;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(261, 151);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // mobilePhoneTextBox
            // 
            mobilePhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mobilePhoneTextBox.Location = new Point(99, 122);
            mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            mobilePhoneTextBox.Size = new Size(237, 23);
            mobilePhoneTextBox.TabIndex = 9;
            // 
            // officePhoneTextBox
            // 
            officePhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            officePhoneTextBox.Location = new Point(99, 93);
            officePhoneTextBox.Name = "officePhoneTextBox";
            officePhoneTextBox.Size = new Size(237, 23);
            officePhoneTextBox.TabIndex = 7;
            // 
            // administrativePositionTextBox
            // 
            administrativePositionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            administrativePositionTextBox.Location = new Point(99, 64);
            administrativePositionTextBox.Name = "administrativePositionTextBox";
            administrativePositionTextBox.Size = new Size(237, 23);
            administrativePositionTextBox.TabIndex = 5;
            // 
            // familyTextBox
            // 
            familyTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            familyTextBox.Location = new Point(99, 35);
            familyTextBox.Name = "familyTextBox";
            familyTextBox.Size = new Size(237, 23);
            familyTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(99, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(237, 23);
            nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "&Name";
            // 
            // familyLabel
            // 
            familyLabel.AutoSize = true;
            familyLabel.Location = new Point(12, 38);
            familyLabel.Name = "familyLabel";
            familyLabel.Size = new Size(42, 15);
            familyLabel.TabIndex = 2;
            familyLabel.Text = "&Family";
            // 
            // administrativePositionLabel
            // 
            administrativePositionLabel.AutoSize = true;
            administrativePositionLabel.Location = new Point(12, 67);
            administrativePositionLabel.Name = "administrativePositionLabel";
            administrativePositionLabel.Size = new Size(50, 15);
            administrativePositionLabel.TabIndex = 4;
            administrativePositionLabel.Text = "&Position";
            // 
            // officePhoneLabel
            // 
            officePhoneLabel.AutoSize = true;
            officePhoneLabel.Location = new Point(12, 96);
            officePhoneLabel.Name = "officePhoneLabel";
            officePhoneLabel.Size = new Size(76, 15);
            officePhoneLabel.TabIndex = 6;
            officePhoneLabel.Text = "&Office Phone";
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new Point(12, 125);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new Size(81, 15);
            mobilePhoneLabel.TabIndex = 8;
            mobilePhoneLabel.Text = "&Mobile Phone";
            // 
            // NewContact
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(342, 181);
            Controls.Add(mobilePhoneLabel);
            Controls.Add(officePhoneLabel);
            Controls.Add(administrativePositionLabel);
            Controls.Add(familyLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(familyTextBox);
            Controls.Add(administrativePositionTextBox);
            Controls.Add(officePhoneTextBox);
            Controls.Add(mobilePhoneTextBox);
            Controls.Add(cancelButton);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            MaximumSize = new Size(800, 246);
            MinimumSize = new Size(358, 220);
            Name = "NewContact";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Contact";
            Load += NewContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Dtat.Windows.Forms.Button saveButton;
        private Dtat.Windows.Forms.Button resetButton;
        private Dtat.Windows.Forms.Button cancelButton;
        private Dtat.Windows.Forms.TextBox mobilePhoneTextBox;
        private Dtat.Windows.Forms.TextBox officePhoneTextBox;
        private Dtat.Windows.Forms.TextBox administrativePositionTextBox;
        private Dtat.Windows.Forms.TextBox familyTextBox;
        private Dtat.Windows.Forms.TextBox nameTextBox;
        private Dtat.Windows.Forms.Label nameLabel;
        private Dtat.Windows.Forms.Label familyLabel;
        private Dtat.Windows.Forms.Label administrativePositionLabel;
        private Dtat.Windows.Forms.Label officePhoneLabel;
        private Dtat.Windows.Forms.Label mobilePhoneLabel;
    }
}