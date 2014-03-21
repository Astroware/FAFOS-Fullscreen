using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using tiles;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;


namespace FAFOS
{
    public partial class View : Form
    {
        private double screenWidth;
        private double screenHeight;
        MapsForm maps;
        Users user;
        int userid;
        private int screenCenterTop;
        private int screenCenterLeft;
        private int LoginRetryCounter = 0;
        WorkOrder[] orders;
        ContractService[] services;
        private DateTime t1;
        List<Bitmap> piclist = new List<Bitmap>();

        enum Options { NONE, REPORTS, DOCUMENTS, CLIENTS, OPERATIONS };
        int currentOption = (int)Options.NONE;

        delegate void SetSizeCallback(int w, int h, tile T);
        private bool _Authenticated = false;

        public bool Authenticated
        {
            get { return _Authenticated; }
            set { _Authenticated = value; }
        }
        private string _Username = "";

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public View()
        {
            InitializeComponent();

            services = new ContractService[30];
            orders = new WorkOrder[30];


            pnlLogin.Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width / 2 - Convert.ToInt32(pnlLogin.Size.Width) / 2,
                System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height / 2 - Convert.ToInt32(pnlLogin.Size.Height) / 2);

            /*notificationPanel.Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width - Convert.ToInt32(notificationPanel.Size.Width) - 20,
               notificationPanel.Location.Y);*/

            /*pnlUser.Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width - Convert.ToInt32(pnlUser.Size.Width) - 15,
              pnlUser.Location.Y);*/


            /*this.quote.Enter += new System.EventHandler(Tile_Enter);
            this.editQuote.Enter += new System.EventHandler(Tile_Enter);
            this.salesOrder.Enter += new System.EventHandler(Tile_Enter);
            this.editSalesOrder.Enter += new System.EventHandler(Tile_Enter);
            this.convertSalesOrder.Enter += new System.EventHandler(Tile_Enter);
            this.invoice.Enter += new System.EventHandler(Tile_Enter);*/
            /*this.inventory.Enter += new System.EventHandler(Tile_Enter);
            this.purchaseRecord.Enter += new System.EventHandler(Tile_Enter);
            this.payment.Enter += new System.EventHandler(Tile_Enter);
            this.itinerary.Enter += new System.EventHandler(Tile_Enter);
            this.inspection.Enter += new System.EventHandler(Tile_Enter);*/

            /*this.addClient.Enter += new System.EventHandler(Tile_Enter);
            this.editClient.Enter += new System.EventHandler(Tile_Enter);
            this.addContract.Enter += new System.EventHandler(Tile_Enter);
            this.editContract.Enter += new System.EventHandler(Tile_Enter);*/

            /*this.statement.Enter += new System.EventHandler(Tile_Enter);
            this.jobReport.Enter += new System.EventHandler(Tile_Enter);
            this.royaltyFee.Enter += new System.EventHandler(Tile_Enter);
            this.revenueReport.Enter += new System.EventHandler(Tile_Enter);*/
            //  this.allRevenue.Enter += new System.EventHandler(Tile_Enter);

            user = new Users();

            screenWidth = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            screenHeight = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            this.Size = new System.Drawing.Size((int)screenWidth, (int)screenHeight);

            /*this.quote.tileTimer_Interval = 40;
            this.quote.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.editQuote.tileTimer_Interval = 40;
            this.editQuote.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.salesOrder.tileTimer_Interval = 40;
            this.salesOrder.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.editSalesOrder.tileTimer_Interval = 40;
            this.editSalesOrder.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.convertSalesOrder.tileTimer_Interval = 40;
            this.convertSalesOrder.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.invoice.tileTimer_Interval = 40;
            this.invoice.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);*/
            /*this.inventory.tileTimer_Interval = 40;
            this.inventory.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.purchaseRecord.tileTimer_Interval = 40;
            this.purchaseRecord.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.payment.tileTimer_Interval = 40;
            this.payment.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.itinerary.tileTimer_Interval = 40;
            this.itinerary.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.inspection.tileTimer_Interval = 40;
            this.inspection.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);*/

            /*this.addClient.tileTimer_Interval = 40;
            this.addClient.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.editClient.tileTimer_Interval = 40;
            this.editClient.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.addContract.tileTimer_Interval = 40;
            this.addContract.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.editContract.tileTimer_Interval = 40;
            this.editContract.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);

            this.statement.tileTimer_Interval = 40;
            this.statement.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.royaltyFee.tileTimer_Interval = 40;
            this.royaltyFee.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.jobReport.tileTimer_Interval = 40;
            this.jobReport.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);
            this.revenueReport.tileTimer_Interval = 40;
            this.revenueReport.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);*/
            //  this.allRevenue.tileTimer_Interval = 40;
            //  this.allRevenue.RaisetileTimer_Elapsed += new System.Timers.ElapsedEventHandler(RaisetileTimer_Elapsed);

            //FireAlertLogo.Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width - 350, 40);

            //Astroware.Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width - 250,
            //    System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height - 100);
            
            //Exit_btn.Location = new Point(System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width - 430,
            //System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height - 160);


        }

        public void Notifications()
        {
            DataTable dt2 = new ClientContract().getServices(userid.ToString());
            serviceNotification.Text = "";
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt2.Rows[i][2]) == DateTime.Today)
                {
                    String service = dt2.Rows[i][0].ToString();
                    serviceNotification.Text += "\n" + service + " needs to be completed by today at ";
                    serviceNotification.Text += dt2.Rows[i][4].ToString() + ", " + dt2.Rows[i][5].ToString() + "\n";
                }
            }
            if (serviceNotification.Text == "")
                serviceNotification.Text = "None";




            DataTable dt = new Payment().getNotPaid(userid);
            paymentNotification.Text = "";
            for (int i = 2; i < dt.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dt.Rows[i][2]) == DateTime.Today)
                {
                    String name = new Client().getName(new ClientContract().getClient(new SalesOrder().getSAddress(new Invoice().getSalesOrderID(dt.Rows[i][0].ToString()).ToString())));
                    paymentNotification.Text += "\n" + name + " has an outstanding balance of ";

                    DataTable payments = new Payment().getAmount(dt.Rows[i][0].ToString());
                    double total = 0;
                    for (int j = 0; j < payments.Rows.Count; j++)
                    {
                        total += Convert.ToDouble(payments.Rows[j][2]);

                    }
                    paymentNotification.Text += "$" + String.Format("{0:0.00}", Math.Round(Convert.ToDouble(dt.Rows[i][3].ToString()) - total, 2))
                        + " on invoice #" + dt.Rows[i][0].ToString() + "\n";
                }
            }
            if (paymentNotification.Text == "")
                paymentNotification.Text = "None";
        }


        public void Tile_Enter(object sender, EventArgs e)
        {

            tile _tile = (tile)sender;
            _tile.tileWidth = 200;
            _tile.tileHieght = 30;
            _tile.Tag = "0";

            screenCenterLeft = (int)((screenWidth / 2) - (_tile.tileWidth / 2));
            screenCenterTop = (int)((screenHeight / 2) - (_tile.tileHieght / 2));

            _tile.XScale = ((int)(formWidth - _tile.tileWidth) / 15);
            _tile.YScale = ((int)(formHeight - _tile.tileHieght) / 15);




            this.Controls[_tile.Name].BringToFront();

            _tile.timerStart();


        }


        private void RaisetileTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            tile _tile = (tile)sender;
            TileSizeControl(_tile.tileWidth + _tile.XScale, _tile.tileHieght + _tile.YScale, _tile);
        }

        public void TileSizeControl(int w, int h, tile T)
        {
            SetSizeCallback d = new SetSizeCallback(SetSize);
            this.Invoke(d, new object[] { w, h, T });
        }


        public void SetSize(int w, int h, tile T)
        {

            if (T.Tag.Equals("0")) // move to the center
            {
                //  T.Resize = new System.Drawing.Size(300, 300);
                T.playMovie();
                if (T.Left < screenCenterLeft)
                {
                    T.Left += (int)(screenWidth - T.tileWidth) / 20;

                }
                else
                    if (T.Left > screenCenterLeft)
                    {
                        T.Left -= (int)(screenWidth - T.tileWidth) / 20;
                    }
                if (T.Top < screenCenterTop)
                {
                    T.Top += (int)(screenHeight - T.tileHieght) / 20;

                }
                else
                    if (T.Top > screenCenterTop)
                    {
                        T.Top -= (int)(screenHeight - T.tileHieght) / 20;
                    }

                if ((T.Top <= screenCenterTop + T.tileHieght && T.Top >= screenCenterTop - T.tileHieght)
                    && (T.Left <= screenCenterLeft + T.tileWidth && T.Left >= screenCenterLeft - T.tileWidth))
                {
                    T.Tag = "1";
                    t1 = DateTime.Now;
                }
            }
            else if (T.Tag.Equals("1"))  // finish flip 
            {
                TimeSpan elapsed = DateTime.Now - t1;
                if (elapsed.Milliseconds >= 100)
                {
                    T.Tag = "2";
                    T.tileTimer_Interval = 1;
                }
            }
            else if (T.Tag.Equals("2")) // expand
            {
                T.Resize = new System.Drawing.Size(w, h);

                T.Left = (int)((screenWidth / 2) - (T.tileWidth / 2));
                T.Top = (int)((screenHeight / 2) - (T.tileHieght / 2));

                if (T.Top <= 0)
                {
                    T.Tag = "3";
                    t1 = DateTime.Now;
                }
            }
            else if (T.Tag.Equals("3")) // wait 1 second
            {

                TimeSpan elapsed = DateTime.Now - t1;
                if (elapsed.Seconds >= 1)
                {
                    T.Tag = "4";
                    T.tileTimer_Interval = 40;
                }
            }
            else if (T.Tag.Equals("4")) // load the desired form
            {

                T.timerStop();
                T.Tag = "0";

                this.Exit_btn.Focus();
                MaintainClientController c = new MaintainClientController();
                SalesOrderController my_controller = new SalesOrderController(userid.ToString());
                // replace the following line by calling a method in the controller with a parameter (T.Name + "_form")
                // that method should has if statment to decide which form to be opened.
                if (T.Name == "invoice")
                {
                    InvoiceForm invoice_form = new InvoiceForm(userid);
                    invoice_form.Show();
                }
                else if (T.Name == "quote")
                {
                    QuoteController qc = new QuoteController(userid.ToString());
                    qc.quote(1);
                }
                else if (T.Name == "editQuote")
                {
                    QuoteController qc = new QuoteController(userid.ToString());
                    qc.quote(2);
                }
                else if (T.Name == "salesOrder")
                {
                    my_controller.salesOrder(1);
                    //payment_form.Show();
                }
                else if (T.Name == "convertSalesOrder")
                {
                    my_controller.salesOrder(2);
                    //payment_form.Show();
                }
                else if (T.Name == "editSalesOrder")
                {
                    my_controller.salesOrder(3);
                    //payment_form.Show();
                }
                else if (T.Name == "payment")
                {
                    PaymentForm payment_form = new PaymentForm(userid);
                    payment_form.Show();
                }
                else if (T.Name == "inventory")
                {
                    InventoryForm form = new InventoryForm(userid);
                    form.Show();
                    /*MapsForm form = new MapsForm();
                    form.Show();*/
                }
                else if (T.Name == "purchaseRecord")
                {
                    PurchaseRecord form = new PurchaseRecord(userid);
                    form.Show();
                    // T.timerStop();

                }
                else if (T.Name == "itinerary")
                {
                    MapsForm form = new MapsForm(userid, orders, services);


                    form.Show();
                }
                else if (T.Name == "addClient")
                {
                    c.New_client_button_Click(T, userid);
                }
                else if (T.Name == "editClient")
                {
                    c.Edit_Client_Button_Click(T, userid);
                }
                else if (T.Name == "addContract")
                {
                    c.Add_contract_Button_Click(T, userid);
                }
                else if (T.Name == "editContract")
                {
                    c.Edit_contract_Button_Click(T, userid);
                }
                else if (T.Name == "statement")
                {
                    Statements form = new Statements(userid);
                    form.Show();
                }
                else if (T.Name == "royaltyFee")
                {
                    RoyaltyFeeCollection form = new RoyaltyFeeCollection(userid.ToString());
                    form.Show();
                }
                else if (T.Name == "inspection")
                {
                    InspectionForm form = new InspectionForm(userid.ToString());
                    form.Show();
                }
                else if (T.Name == "revenueReport")
                {
                    ReportsController r = new ReportsController(userid.ToString());
                    r.report(1);
                    //  Report form = new InspectionForm(userid.ToString());
                    // form.Show();
                }
                T.tileReset();
                T.showFrame(0);

            }
        }


        public double formWidth
        {
            get { return screenWidth; }
        }

        public double formHeight
        {
            get { return screenHeight; }
        }


        private void View_Load(object sender, EventArgs e)
        {
            this.txtUsername.Focus();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

            //if (Login())
            //{
            userid = 1;
            pnlLogin.Visible = false;
            this.Exit_btn.Focus();

            Exit.Visible = true;
            Logout.Visible = true;
            UserSettings.Visible = true;
            menuStrip1.Visible = true;
            Notification.Visible = true;
            /*quote.Visible = true;
            editQuote.Visible = true;
            salesOrder.Visible = true;
            editSalesOrder.Visible = true;
            convertSalesOrder.Visible = true;
            invoice.Visible = true;*/

            /*inventory.Visible = true;
            purchaseRecord.Visible = true;
            payment.Visible = true;
            itinerary.Visible = true;
            inspection.Visible = true;*/

            /*addClient.Visible = true;
            addContract.Visible = true;
            editClient.Visible = true;
            editContract.Visible = true;

            statement.Visible = true;
            jobReport.Visible = true;
            revenueReport.Visible = true;
            royaltyFee.Visible = true;
            if (!user.checkAdmin(userid))
                royaltyFee.Visible = false;*/
            //   allRevenue.Visible = true;
            RedBar.Visible = true;
            sidepanel.Visible = true;
            syncAndroid.Visible = true;
            syncHQ.Visible = true;
            Watermark.Visible = true;
            Watermark.SendToBack();
            Operation.Visible = true;
            Document.Visible = true;
            Client.Visible = true;
            Report.Visible = true;
            Astroware.Visible = false;
            Sedge.Visible = false;
            //label9.Visible = true;


            lblUsername.Visible = false;
            txtUsername.Visible = false;
            lblPassword.Visible = false;
            txtPassword.Visible = false;
            Login_btn.Visible = false;
            /*Logout_btn.Visible = true;
            userSettings.Visible = true;*/
            lblUserInfo.Visible = true;
            //notificationPanel.Visible = true;
            profilePic.Visible = true;
            //pnlUser.Visible = true;


            try
            {
                piclist = MUser.LoadImages();
            }
            catch (Exception)
            {

                piclist.Add(FAFOS.Properties.Resources.DefaultProPic);
                MUser.SaveImages(piclist);
            }

            this.profilePic.BackgroundImage = piclist[MUser.GetPicID(userid.ToString())];// FAFOS.Properties.Resources.Shades;
            this.profilePic.BackgroundImageLayout = ImageLayout.Stretch;


            lblUserInfo.Text = "Welcome\n " + user.getName(userid);


            /*quote.tileLocation = quote.Location;
            quote.tileWidth = 200;
            quote.tileHieght = 30;
            editQuote.tileLocation = editQuote.Location;
            editQuote.tileWidth = 200;
            editQuote.tileHieght = 30;
            salesOrder.tileLocation = salesOrder.Location;
            convertSalesOrder.tileLocation = convertSalesOrder.Location;
            editSalesOrder.tileLocation = editSalesOrder.Location;

            invoice.tileLocation = invoice.Location;*/
            /*inventory.tileLocation = inventory.Location;
            purchaseRecord.tileLocation = purchaseRecord.Location;
            payment.tileLocation = payment.Location;
            itinerary.tileLocation = itinerary.Location;
            inspection.tileLocation = inspection.Location;*/

            /*addClient.tileLocation = addClient.Location;
            editClient.tileLocation = editClient.Location;
            addContract.tileLocation = addContract.Location;
            editContract.tileLocation = editContract.Location;

            statement.tileLocation = statement.Location;
            jobReport.tileLocation = jobReport.Location;
            revenueReport.tileLocation = revenueReport.Location;
            royaltyFee.tileLocation = royaltyFee.Location;*/
            //   allRevenue.tileLocation = allRevenue.Location;

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

            /*quote.setMovie(path + "\\Resources\\Quote1.swf");
            editQuote.setMovie(path + "\\Resources\\EditQuote.swf");
            salesOrder.setMovie(path + "\\Resources\\CreateSalesOrder1.swf");
            editSalesOrder.setMovie(path + "\\Resources\\EditSalesOrder1.swf");
            convertSalesOrder.setMovie(path + "\\Resources\\ConvertSalesOrder1.swf");
            invoice.setMovie(path + "\\Resources\\Invoice1.swf");*/

            /*inventory.setMovie(path + "\\Resources\\Inventory1.swf");
            purchaseRecord.setMovie(path + "\\Resources\\PurchaseRecord.swf");
            payment.setMovie(path + "\\Resources\\payment1.swf");
            itinerary.setMovie(path + "\\Resources\\itinerary1.swf");
            inspection.setMovie(path + "\\Resources\\Inspection.swf");*/

            /*addClient.setMovie(path + "\\Resources\\addClient1.swf");
            addContract.setMovie(path + "\\Resources\\addContract1.swf");
            editClient.setMovie(path + "\\Resources\\editClient1.swf");
            editContract.setMovie(path + "\\Resources\\editContract1.swf");

            statement.setMovie(path + "\\Resources\\Statements.swf");
            jobReport.setMovie(path + "\\Resources\\JobReports.swf");
            revenueReport.setMovie(path + "\\Resources\\RevenueReports.swf");
            royaltyFee.setMovie(path + "\\Resources\\RoyaltyFee.swf");*/
            //  allRevenue.setMovie(path + "\\Resources\\TotalRevenue.swf");

            /*quote.Visible = false;
            editQuote.Visible = false;
            salesOrder.Visible = false;
            editSalesOrder.Visible = false;
            convertSalesOrder.Visible = false;

            invoice.Visible = false;*/
            /*inventory.Visible = false;
            purchaseRecord.Visible = false;
            payment.Visible = false;
            itinerary.Visible = false;
            inspection.Visible = false;*/

            /*addClient.Visible = false;
            addContract.Visible = false;
            editClient.Visible = false;
            editContract.Visible = false;

            statement.Visible = false;
            jobReport.Visible = false;
            revenueReport.Visible = false;
            royaltyFee.Visible = false;*/
            // allRevenue.Visible = false;

            //Notifications();
            //}

        }

        public bool Login()
        {
            if (LoginRetryCounter < 2)
            {
                if (txtPassword.Text.Length > 0 && txtUsername.Text.Length > 0)
                {
                    if (UserAuthenticated(txtUsername.Text, txtPassword.Text))
                    {
                        Authenticated = true;
                        lblUserInfo.Text = "Welcome\n " + user.getName(userid);

                        return true;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Username or Password not recognised");
                        txtPassword.Text = "";
                        LoginRetryCounter++; // increment retry counter
                        return false;
                    }
                }
                else // password or username is empty
                {
                    System.Windows.Forms.MessageBox.Show("You need to enter both a username and a password to continue");
                    LoginRetryCounter++;
                    return false;
                }
            }
            else // too many attempts
            {
                System.Windows.Forms.MessageBox.Show("You have failed to remember your details \n Contact Administration for further instructions");
                System.Windows.Forms.Application.Exit();
                return false;
            }
        }


        private bool UserAuthenticated(string p, string p_2)
        {
            if (user.check(p, p_2))
            {
                userid = user.getId(p);
                return true;
            }
            return false;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            /*quote.Visible = false;
            editQuote.Visible = false;
            salesOrder.Visible = false;
            editSalesOrder.Visible = false;
            convertSalesOrder.Visible = false;
            invoice.Visible = false;*/

            Logout.Visible = false;
            UserSettings.Visible = false;
            RedBar.Visible = false;
            sidepanel.Visible = false;
            Watermark.Visible = false;
            EditQuote.Visible = false;
            Quote.Visible = false;
            SalesOrder.Visible = false;
            EditSalesOrder.Visible = false;
            ConvertSalesOrder.Visible = false;
            Invoice.Visible = false;

            Itinerary.Visible = false;
            Inventory.Visible = false;
            PurchaseRecord.Visible = false;
            Payment.Visible = false;
            Inspection.Visible = false;

            AddClient.Visible = false;
            EditClient.Visible = false;
            AddContract.Visible = false;
            EditContract.Visible = false;

            Statement.Visible = false;
            RevenueReport.Visible = false;
            RoyaltyFee.Visible = false;

            Operation.Visible = false;
            Document.Visible = false;
            Client.Visible = false;
            Report.Visible = false;
            Astroware.Visible = true;
            Sedge.Visible = true;

            menuStrip1.Visible = false;
            /*inventory.Visible = false;
            purchaseRecord.Visible = false;
            payment.Visible = false;
            itinerary.Visible = false;
            inspection.Visible = false;*/

            /*addClient.Visible = false;
            addContract.Visible = false;
            editClient.Visible = false;
            editContract.Visible = false;

            statement.Visible = false;
            jobReport.Visible = false;
            revenueReport.Visible = false;
            royaltyFee.Visible = false;*/
            // allRevenue.Visible = false;

            syncAndroid.Visible = false;
            syncHQ.Visible = false;

            //label9.Visible = false;
            //pnlUser.Visible = false;

            lblUsername.Visible = true;
            txtUsername.Visible = true;
            lblPassword.Visible = true;
            txtPassword.Visible = true;
            pnlLogin.Visible = true;


            Login_btn.Visible = true;
            /*Logout_btn.Visible = false;
            userSettings.Visible = false;*/
            lblUserInfo.Visible = false;
            profilePic.Visible = false;
            notificationPanel.Visible = false;
            Exit.Visible = false;
            Notification.Visible = false;
            lblUserInfo.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            userid = 0;
        }

        private void userSettings_Click(object sender, EventArgs e)
        {
            MaintainUsersForm form = new MaintainUsersForm(userid, MUser.GetPicID(userid.ToString()));
            form.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Operation_MouseHover(object sender, EventArgs e)
        {

        }

        private void Operation_Click(object sender, EventArgs e)
        {

        }

        private void Document_MouseHover(object sender, EventArgs e)
        {

        }

        private void Client_MouseHover(object sender, EventArgs e)
        {

        }

        private void Report_Enter(object sender, EventArgs e)
        {

        }

        private void Report_MouseEnter(object sender, EventArgs e)
        {
            if (currentOption != (int)Options.REPORTS)
            {
                setReportsVisible(true);
            }
        }

        private void Document_MouseEnter(object sender, EventArgs e)
        {
            if (currentOption != (int)Options.DOCUMENTS)
            {
                setDocumentsVisible(true);
            }
        }

        private void Client_MouseEnter(object sender, EventArgs e)
        {
            if (currentOption != (int)Options.CLIENTS)
            {
                setClientsVisible(true);
            }
        }

        private void Operation_MouseEnter(object sender, EventArgs e)
        {
            if (currentOption != (int)Options.OPERATIONS)
            {
                setOperationsVisible(true);
            }
        }

        private void inspection_Load(object sender, EventArgs e)
        {

        }

        private void itinerary_Load(object sender, EventArgs e)
        {

        }

        private void editQuote_Load(object sender, EventArgs e)
        {

        }

        //Operations
        //
        private void Itinerary_Click(object sender, EventArgs e)
        {
            MapsForm form = new MapsForm(userid, orders, services);
            form.Show();
        }

        private void itineraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapsForm form = new MapsForm(userid, orders, services);
            form.Show();
        }

        private void ItineraryTT_Popup(object sender, PopupEventArgs e)
        {
            //ItineraryTT.SetToolTip(Itinerary, "This gives you a list of Itinerary");
            //ItineraryTT.Show("List of Stuff", Itinerary);
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            InventoryForm form = new InventoryForm(userid);
            form.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm form = new InventoryForm(userid);
            form.Show();
        }

        private void PurchaseRecord_Click(object sender, EventArgs e)
        {
            PurchaseRecord form = new PurchaseRecord(userid);
            form.Show();
        }

        private void purchaseRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseRecord form = new PurchaseRecord(userid);
            form.Show();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            PaymentForm payment_form = new PaymentForm(userid);
            payment_form.Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm payment_form = new PaymentForm(userid);
            payment_form.Show();
        }

        private void Inspection_Click(object sender, EventArgs e)
        {
            InspectionForm form = new InspectionForm(userid.ToString());
            form.Show();
        }

        private void inspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InspectionForm form = new InspectionForm(userid.ToString());
            form.Show();
        }
        //Operations
        //


        //Documents
        //
        private void Quote_Click(object sender, EventArgs e)
        {
            QuoteController qc = new QuoteController(userid.ToString());
            qc.quote(1);
        }

        private void createQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuoteController qc = new QuoteController(userid.ToString());
            qc.quote(1);
        }

        private void EditQuote_Click(object sender, EventArgs e)
        {
            QuoteController qc = new QuoteController(userid.ToString());
            qc.quote(2);
        }

        private void editQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuoteController qc = new QuoteController(userid.ToString());
            qc.quote(2);
        }

        private void SalesOrder_Click(object sender, EventArgs e)
        {
            //Creating the Sales order controller. Was in tile call but must be moved here to allow proper initialization
            SalesOrderController my_controller = new SalesOrderController(userid.ToString());

            my_controller.salesOrder(1);
            //payment_form.Show();
        }

        private void createSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating the Sales order controller. Was in tile call but must be moved here to allow proper initialization
            SalesOrderController my_controller = new SalesOrderController(userid.ToString());

            my_controller.salesOrder(1);
            //payment_form.Show();
        }

        private void EditSalesOrder_Click(object sender, EventArgs e)
        {
            //Creating the Sales order controller. Was in tile call but must be moved here to allow proper initialization
            SalesOrderController my_controller = new SalesOrderController(userid.ToString());

            my_controller.salesOrder(3);
            //payment_form.Show();
        }

        private void editSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating the Sales order controller. Was in tile call but must be moved here to allow proper initialization
            SalesOrderController my_controller = new SalesOrderController(userid.ToString());

            my_controller.salesOrder(3);
            //payment_form.Show();
        }

        private void ConvertSalesOrder_Click(object sender, EventArgs e)
        {
            //Creating the Sales order controller. Was in tile call but must be moved here to allow proper initialization
            SalesOrderController my_controller = new SalesOrderController(userid.ToString());

            my_controller.salesOrder(2);
            //payment_form.Show();

        }

        private void convertSalesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creating the Sales order controller. Was in tile call but must be moved here to allow proper initialization
            SalesOrderController my_controller = new SalesOrderController(userid.ToString());

            my_controller.salesOrder(2);
            //payment_form.Show();
        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice_form = new InvoiceForm(userid);
            invoice_form.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice_form = new InvoiceForm(userid);
            invoice_form.Show();
        }
        //Documents
        //

        //Client
        //
        private void AddClient_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile _tile = new tile();
            _tile.Name = "addClient";
            c.New_client_button_Click(_tile, userid);
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile _tile = new tile();
            _tile.Name = "addClient";
            c.New_client_button_Click(_tile, userid);
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile T = new tile();
            T.Name = "editClient";
            c.Edit_Client_Button_Click(T, userid);
        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile T = new tile();
            T.Name = "editClient";
            c.Edit_Client_Button_Click(T, userid);
        }

        private void AddContract_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile T = new tile();
            T.Name = "addContract";
            c.Add_contract_Button_Click(T, userid);
        }

        private void addContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile T = new tile();
            T.Name = "addContract";
            c.Add_contract_Button_Click(T, userid);
        }

        private void EditContract_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile T = new tile();
            T.Name = "editContract";
            c.Edit_contract_Button_Click(T, userid);
        }

        private void editContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainClientController c = new MaintainClientController();
            tile T = new tile();
            T.Name = "editContract";
            c.Edit_contract_Button_Click(T, userid);
        }
        //Client
        //

        //Reports
        //
        private void Statement_Click(object sender, EventArgs e)
        {
            Statements form = new Statements(userid);
            form.Show();
        }

        private void statementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statements form = new Statements(userid);
            form.Show();
        }

        private void RoyaltyFee_Click(object sender, EventArgs e)
        {
            RoyaltyFeeCollection form = new RoyaltyFeeCollection(userid.ToString());
            form.Show();
        }

        private void royaltyFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoyaltyFeeCollection form = new RoyaltyFeeCollection(userid.ToString());
            form.Show();
        }

        private void JobReport_Click(object sender, EventArgs e)
        {

        }

        private void jobReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RevenueReport_Click(object sender, EventArgs e)
        {
            ReportsController r = new ReportsController(userid.ToString());
            r.report(1);
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsController r = new ReportsController(userid.ToString());
            r.report(1);
        }
        //Reports
        //

        private void quoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Document_Click(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
      
        }

        private void UserSettings_Click_2(object sender, EventArgs e)
        {
            MaintainUsersForm form = new MaintainUsersForm(userid, MUser.GetPicID(userid.ToString()));
            form.Show();
        }

        private void syncAndroid_Click(object sender, EventArgs e)
        {

        }

        private void syncHQ_Click(object sender, EventArgs e)
        {

        }

        private void Notification_MouseEnter(object sender, EventArgs e)
        {
            Notifications();
            notificationPanel.Visible = true;
        }

        private void Notification_MouseLeave(object sender, EventArgs e)
        {
            notificationPanel.Visible = false;
        }

        private void View_MouseMove(object sender, MouseEventArgs e)
        {
            switch (currentOption)
            {
                case (int)Options.NONE:
                    return;
                case (int)Options.OPERATIONS:
                    if ((e.Y < Operation.Top) || (e.X < Operation.Left) || (e.X > Operation.Right) || (e.Y > Inspection.Bottom))
                    {
                        setOperationsVisible(false);
                    }
                    break;
                case (int)Options.DOCUMENTS:
                    if ((e.Y < Document.Top) || (e.X < Document.Left) || (e.X > Document.Right) || (e.Y > Invoice.Bottom))
                    {
                        setDocumentsVisible(false);
                    }
                    break;
                case (int)Options.CLIENTS:
                    if ((e.Y < Client.Top) || (e.X < Client.Left) || (e.X > Client.Right) || (e.Y > EditContract.Bottom))
                    {
                        setClientsVisible(false);
                    }
                    break;
                case (int)Options.REPORTS:
                    if ((e.Y < Report.Top) || (e.X < Report.Left) || (e.X > Report.Right) || (e.Y > RoyaltyFee.Bottom))
                    {
                        setReportsVisible(false);
                    }
                    break;
                default:
                    Console.WriteLine("Error in switch statement");
                    break;
            }
        }

        private void setOperationsVisible(Boolean visible)
        {
            if (visible == true)
            {
                setDocumentsVisible(false);
                setClientsVisible(false);
                setReportsVisible(false);

                this.Operation.BackColor = Color.LightPink;

                Itinerary.Visible = true;
                Inventory.Visible = true;
                PurchaseRecord.Visible = true;
                Payment.Visible = true;
                Inspection.Visible = true;

                currentOption = (int)Options.OPERATIONS;
            }

            else
            {
                this.Operation.BackColor = Color.White;

                Itinerary.Visible = false;
                Inventory.Visible = false;
                PurchaseRecord.Visible = false;
                Payment.Visible = false;
                Inspection.Visible = false;

                currentOption = (int)Options.NONE;
            }
        }

        private void setDocumentsVisible(Boolean visible)
        {
            if (visible == true)
            {
                setOperationsVisible(false);
                setClientsVisible(false);
                setReportsVisible(false);

                this.Document.BackColor = Color.LightPink;

                Quote.Visible = true;
                EditQuote.Visible = true;
                SalesOrder.Visible = true;
                EditSalesOrder.Visible = true;
                ConvertSalesOrder.Visible = true;
                Invoice.Visible = true;

                currentOption = (int)Options.DOCUMENTS;
            }

            else
            {
                this.Document.BackColor = Color.White;

                Quote.Visible = false;
                EditQuote.Visible = false;
                SalesOrder.Visible = false;
                EditSalesOrder.Visible = false;
                ConvertSalesOrder.Visible = false;
                Invoice.Visible = false;

                currentOption = (int)Options.NONE;
            }
        }

        private void setClientsVisible(Boolean visible)
        {
            if (visible == true)
            {
                setOperationsVisible(false);
                setDocumentsVisible(false);
                setReportsVisible(false);

                this.Client.BackColor = Color.LightPink;

                AddClient.Visible = true;
                EditClient.Visible = true;
                AddContract.Visible = true;
                EditContract.Visible = true;

                currentOption = (int)Options.CLIENTS;
            }

            else
            {
                this.Client.BackColor = Color.White;

                AddClient.Visible = false;
                EditClient.Visible = false;
                AddContract.Visible = false;
                EditContract.Visible = false;

                currentOption = (int)Options.NONE;
            }
        }

        private void setReportsVisible(Boolean visible)
        {
            if (visible == true)
            {
                setOperationsVisible(false);
                setDocumentsVisible(false);
                setClientsVisible(false);

                this.Report.BackColor = Color.LightPink;

                Statement.Visible = true;
                RevenueReport.Visible = true;
                RoyaltyFee.Visible = true;

                currentOption = (int)Options.REPORTS;
            }

            else
            {
                this.Report.BackColor = Color.White;

                Statement.Visible = false;
                RevenueReport.Visible = false;
                RoyaltyFee.Visible = false;

                currentOption = (int)Options.NONE;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}