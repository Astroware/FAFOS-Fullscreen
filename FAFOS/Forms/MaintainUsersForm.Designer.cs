﻿namespace FAFOS
{
    partial class MaintainUsersForm
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
            this.components = new System.ComponentModel.Container();
            this.Back_Button = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.UploadPicButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.HQButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lNameTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.cnfTxtBox = new System.Windows.Forms.TextBox();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.cellTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.ProvStateBox = new System.Windows.Forms.ComboBox();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homeTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FaxTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SkypeBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PositionTxBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.primUsrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Back_Button.BackgroundImage = global::FAFOS.Properties.Resources.Back2;
            this.Back_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back_Button.FlatAppearance.BorderSize = 0;
            this.Back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_Button.Location = new System.Drawing.Point(11, 12);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(34, 37);
            this.Back_Button.TabIndex = 33;
            this.Back_Button.UseVisualStyleBackColor = false;
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBox.InitialImage = global::FAFOS.Properties.Resources.DefaultProPic;
            this.PicBox.Location = new System.Drawing.Point(413, 5);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(78, 101);
            this.PicBox.TabIndex = 34;
            this.PicBox.TabStop = false;
            // 
            // UploadPicButton
            // 
            this.UploadPicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.UploadPicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadPicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.UploadPicButton.ForeColor = System.Drawing.Color.White;
            this.UploadPicButton.Location = new System.Drawing.Point(374, 112);
            this.UploadPicButton.Name = "UploadPicButton";
            this.UploadPicButton.Size = new System.Drawing.Size(118, 33);
            this.UploadPicButton.TabIndex = 35;
            this.UploadPicButton.Text = "Upload Picture";
            this.UploadPicButton.UseVisualStyleBackColor = false;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.AdminButton.ForeColor = System.Drawing.Color.White;
            this.AdminButton.Location = new System.Drawing.Point(401, 203);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(103, 46);
            this.AdminButton.TabIndex = 37;
            this.AdminButton.Text = "Maintain Franchise Admin";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Visible = false;
            // 
            // HQButton
            // 
            this.HQButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.HQButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.HQButton.ForeColor = System.Drawing.Color.White;
            this.HQButton.Location = new System.Drawing.Point(401, 255);
            this.HQButton.Name = "HQButton";
            this.HQButton.Size = new System.Drawing.Size(103, 49);
            this.HQButton.TabIndex = 38;
            this.HQButton.Text = "Franchisor Options";
            this.HQButton.UseVisualStyleBackColor = false;
            this.HQButton.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.usernameLabel.Location = new System.Drawing.Point(108, 11);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(79, 17);
            this.usernameLabel.TabIndex = 39;
            this.usernameLabel.Text = "UserName:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(111, 27);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(113, 20);
            this.usernameTextBox.TabIndex = 40;
            // 
            // fNameTxtBox
            // 
            this.fNameTxtBox.Location = new System.Drawing.Point(25, 105);
            this.fNameTxtBox.Name = "fNameTxtBox";
            this.fNameTxtBox.Size = new System.Drawing.Size(113, 20);
            this.fNameTxtBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "First Name:";
            // 
            // mNameTxtBox
            // 
            this.mNameTxtBox.Location = new System.Drawing.Point(25, 146);
            this.mNameTxtBox.Name = "mNameTxtBox";
            this.mNameTxtBox.Size = new System.Drawing.Size(110, 20);
            this.mNameTxtBox.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Middle Name:";
            // 
            // lNameTxtBox
            // 
            this.lNameTxtBox.Location = new System.Drawing.Point(163, 105);
            this.lNameTxtBox.Name = "lNameTxtBox";
            this.lNameTxtBox.Size = new System.Drawing.Size(113, 20);
            this.lNameTxtBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(160, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Last Name:";
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Location = new System.Drawing.Point(110, 66);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PasswordChar = '*';
            this.PassTxtBox.Size = new System.Drawing.Size(113, 20);
            this.PassTxtBox.TabIndex = 48;
            this.PassTxtBox.UseSystemPasswordChar = true;
            this.PassTxtBox.TextChanged += new System.EventHandler(this.PassTxtBox_TextChanged);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.PassLabel.Location = new System.Drawing.Point(108, 50);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(73, 17);
            this.PassLabel.TabIndex = 47;
            this.PassLabel.Text = "Password:";
            // 
            // cnfTxtBox
            // 
            this.cnfTxtBox.Location = new System.Drawing.Point(230, 66);
            this.cnfTxtBox.Name = "cnfTxtBox";
            this.cnfTxtBox.PasswordChar = '*';
            this.cnfTxtBox.Size = new System.Drawing.Size(113, 20);
            this.cnfTxtBox.TabIndex = 50;
            this.cnfTxtBox.UseSystemPasswordChar = true;
            this.cnfTxtBox.Visible = false;
            this.cnfTxtBox.TextChanged += new System.EventHandler(this.cnfTxtBox_TextChanged);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.confirmLabel.Location = new System.Drawing.Point(227, 50);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(60, 17);
            this.confirmLabel.TabIndex = 49;
            this.confirmLabel.Text = "Confirm:";
            this.confirmLabel.Visible = false;
            // 
            // cellTextBox
            // 
            this.cellTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellTextBox.Location = new System.Drawing.Point(182, 51);
            this.cellTextBox.Name = "cellTextBox";
            this.cellTextBox.Size = new System.Drawing.Size(133, 23);
            this.cellTextBox.TabIndex = 19;
            this.cellTextBox.TextChanged += new System.EventHandler(this.cellTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addrTextBox);
            this.groupBox2.Controls.Add(this.CountryBox);
            this.groupBox2.Controls.Add(this.ProvStateBox);
            this.groupBox2.Controls.Add(this.CityBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.postalCodeTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(11, 171);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(383, 135);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // addrTextBox
            // 
            this.addrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrTextBox.Location = new System.Drawing.Point(27, 37);
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(138, 23);
            this.addrTextBox.TabIndex = 7;
            this.addrTextBox.TextChanged += new System.EventHandler(this.addrTextBox_TextChanged);
            // 
            // CountryBox
            // 
            this.CountryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Location = new System.Drawing.Point(27, 83);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(82, 25);
            this.CountryBox.TabIndex = 8;
            // 
            // ProvStateBox
            // 
            this.ProvStateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvStateBox.FormattingEnabled = true;
            this.ProvStateBox.Location = new System.Drawing.Point(132, 83);
            this.ProvStateBox.Name = "ProvStateBox";
            this.ProvStateBox.Size = new System.Drawing.Size(105, 25);
            this.ProvStateBox.TabIndex = 9;
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(258, 83);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(98, 25);
            this.CityBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(129, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Province/State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(255, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "City:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.Location = new System.Drawing.Point(185, 37);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.postalCodeTextBox.TabIndex = 14;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.postalCodeTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(185, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Postal Code:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cellTextBox);
            this.groupBox1.Controls.Add(this.homeTxtBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.FaxTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.SkypeBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(11, 315);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(493, 129);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Info";
            // 
            // homeTxtBox
            // 
            this.homeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTxtBox.Location = new System.Drawing.Point(24, 51);
            this.homeTxtBox.Name = "homeTxtBox";
            this.homeTxtBox.Size = new System.Drawing.Size(138, 23);
            this.homeTxtBox.TabIndex = 16;
            this.homeTxtBox.TextChanged += new System.EventHandler(this.homeTxtBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.Location = new System.Drawing.Point(25, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Business Phone:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.Location = new System.Drawing.Point(180, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cell Phone:";
            // 
            // FaxTextBox
            // 
            this.FaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaxTextBox.Location = new System.Drawing.Point(348, 51);
            this.FaxTextBox.Name = "FaxTextBox";
            this.FaxTextBox.Size = new System.Drawing.Size(133, 23);
            this.FaxTextBox.TabIndex = 20;
            this.FaxTextBox.TextChanged += new System.EventHandler(this.FaxTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label11.Location = new System.Drawing.Point(346, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fax:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label13.Location = new System.Drawing.Point(247, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(247, 98);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(163, 23);
            this.EmailTextBox.TabIndex = 23;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label14.Location = new System.Drawing.Point(25, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Skype ID:";
            // 
            // SkypeBox
            // 
            this.SkypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkypeBox.Location = new System.Drawing.Point(24, 98);
            this.SkypeBox.Name = "SkypeBox";
            this.SkypeBox.Size = new System.Drawing.Size(195, 23);
            this.SkypeBox.TabIndex = 26;
            this.SkypeBox.TextChanged += new System.EventHandler(this.SkypeBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label12.Location = new System.Drawing.Point(227, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "Position:";
            // 
            // PositionTxBox
            // 
            this.PositionTxBox.Location = new System.Drawing.Point(230, 27);
            this.PositionTxBox.Name = "PositionTxBox";
            this.PositionTxBox.Size = new System.Drawing.Size(103, 20);
            this.PositionTxBox.TabIndex = 54;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(23)))), ((int)(((byte)(49)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(420, 453);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(68, 35);
            this.SaveButton.TabIndex = 55;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
            this.errProv.RightToLeft = true;
            // 
            // primUsrLabel
            // 
            this.primUsrLabel.AutoSize = true;
            this.primUsrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primUsrLabel.Location = new System.Drawing.Point(407, 86);
            this.primUsrLabel.Name = "primUsrLabel";
            this.primUsrLabel.Size = new System.Drawing.Size(98, 16);
            this.primUsrLabel.TabIndex = 56;
            this.primUsrLabel.Text = "Primary User";
            this.primUsrLabel.Visible = false;
            // 
            // MaintainUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 512);
            this.ControlBox = false;
            this.Controls.Add(this.primUsrLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PositionTxBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cnfTxtBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.lNameTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fNameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.HQButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.UploadPicButton);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.Back_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(10, 200);
            this.Name = "MaintainUsersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MaintainUsers";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button UploadPicButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Button HQButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox fNameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lNameTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTxtBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox cnfTxtBox;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox cellTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.ComboBox ProvStateBox;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox homeTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FaxTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SkypeBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PositionTxBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ErrorProvider errProv;
        private System.Windows.Forms.Label primUsrLabel;
    }
}