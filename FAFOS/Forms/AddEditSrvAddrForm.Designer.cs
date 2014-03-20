namespace FAFOS
{
    partial class AddEditSrvAddrForm
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TermsView = new System.Windows.Forms.DataGridView();
            this.TermID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.recurBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EffectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Add_Service_Button = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TermsView)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.Cancel_Button.FlatAppearance.BorderSize = 0;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(511, 210);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(98, 46);
            this.Cancel_Button.TabIndex = 59;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            // 
            // Ok_Button
            // 
            this.Ok_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.Ok_Button.FlatAppearance.BorderSize = 0;
            this.Ok_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ok_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Ok_Button.ForeColor = System.Drawing.Color.White;
            this.Ok_Button.Location = new System.Drawing.Point(406, 210);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(98, 46);
            this.Ok_Button.TabIndex = 31;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Address:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.AddressLabel.Location = new System.Drawing.Point(82, 9);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(98, 17);
            this.AddressLabel.TabIndex = 63;
            this.AddressLabel.Text = "<No Address>";
            // 
            // TermsView
            // 
            this.TermsView.AllowUserToAddRows = false;
            this.TermsView.AllowUserToDeleteRows = false;
            this.TermsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TermsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TermID,
            this.serviceBox,
            this.recurBox,
            this.EffectDate,
            this.note,
            this.removeButton});
            this.TermsView.Location = new System.Drawing.Point(12, 55);
            this.TermsView.Name = "TermsView";
            this.TermsView.Size = new System.Drawing.Size(597, 150);
            this.TermsView.TabIndex = 64;
            this.TermsView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TermsView_CellValueChanged);
            this.TermsView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TermsView_DataError);
            // 
            // TermID
            // 
            this.TermID.HeaderText = "ID";
            this.TermID.Name = "TermID";
            this.TermID.ReadOnly = true;
            this.TermID.Visible = false;
            // 
            // serviceBox
            // 
            this.serviceBox.HeaderText = "Service";
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Width = 150;
            // 
            // recurBox
            // 
            this.recurBox.HeaderText = "Recurrence";
            this.recurBox.Name = "recurBox";
            // 
            // EffectDate
            // 
            this.EffectDate.HeaderText = "Effective Date";
            this.EffectDate.Name = "EffectDate";
            this.EffectDate.ReadOnly = true;
            this.EffectDate.Width = 120;
            // 
            // note
            // 
            this.note.HeaderText = "Notes";
            this.note.Name = "note";
            this.note.Width = 290;
            // 
            // removeButton
            // 
            this.removeButton.HeaderText = "Remove";
            this.removeButton.Name = "removeButton";
            this.removeButton.Width = 90;
            // 
            // Add_Service_Button
            // 
            this.Add_Service_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.Add_Service_Button.FlatAppearance.BorderSize = 0;
            this.Add_Service_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Service_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Add_Service_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Service_Button.Location = new System.Drawing.Point(511, 24);
            this.Add_Service_Button.Name = "Add_Service_Button";
            this.Add_Service_Button.Size = new System.Drawing.Size(98, 25);
            this.Add_Service_Button.TabIndex = 65;
            this.Add_Service_Button.Text = "Add Service";
            this.Add_Service_Button.UseVisualStyleBackColor = false;
            this.Add_Service_Button.Click += new System.EventHandler(this.Add_Service_Button_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(239, 29);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(123, 20);
            this.DatePicker.TabIndex = 66;
            this.DatePicker.Value = new System.DateTime(2013, 4, 4, 0, 0, 0, 0);
            this.DatePicker.Visible = false;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // AddEditSrvAddrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(621, 267);
            this.ControlBox = false;
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.Add_Service_Button);
            this.Controls.Add(this.TermsView);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Ok_Button);
            this.Name = "AddEditSrvAddrForm";
            this.Text = "Edit Service Address";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.TermsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.DataGridView TermsView;
        private System.Windows.Forms.Button Add_Service_Button;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermID;
        private System.Windows.Forms.DataGridViewComboBoxColumn serviceBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn recurBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewButtonColumn removeButton;
    }
}