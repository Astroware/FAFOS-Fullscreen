using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace FAFOS
{
    class Quote
    {
        public string get(String id)
        {
             String connString = FAFOS.Properties.Settings.Default.FAFOS;
            SqlConnection con = new SqlConnection(connString);

            con.Open();
            SqlCommand command = new SqlCommand("SELECT service_address_id FROM Quote WHERE quote_id = " + id, con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            String serviceAddressId = reader[0].ToString();
            reader.Close();
            con.Close();
            return serviceAddressId;
        }
        public DataTable getStuff(String id)
        {
            String connString = FAFOS.Properties.Settings.Default.FAFOS;
            DataTable d = new DataTable();
            // DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connString);

            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Quote WHERE quote_id = " + id, con);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            //SqlDataReader reader = command.ExecuteReader();
            try
            {
                adap.Fill(d);
            }

            catch (Exception e)
            { }
            // d.Tables.Add(dt);
            con.Close();
            return d;
        }

        public string set(String franchiseeUserId, String serviceAddress, String tax, String total)
        {
             String connString = FAFOS.Properties.Settings.Default.FAFOS;
            SqlConnection con = new SqlConnection(connString);
            string id;
            con.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [Quote] (date_issued, valid_until, tax_rate, "
                + "total, franchisee_user_id, service_address_id) VALUES"
                + "(NULL, NULL, " + tax + ", " + total + ", " + franchiseeUserId + ", " + serviceAddress + ") "
                + "SELECT SCOPE_IDENTITY()", con);

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            id = reader[0].ToString();

            reader.Close();
            con.Close();

            return id;
        }

        public void update(String quoteId, String franchiseeUserId, String serviceAddress, String tax, String total)
        {
             String connString = FAFOS.Properties.Settings.Default.FAFOS;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand command = new SqlCommand("UPDATE [Quote] SET total = " + total + ", "//tax_rate = NULL, "
                /*+ "franchisee_user_id = " + franchiseeUserId + "," */+ " service_address_id = " + serviceAddress// + ", date_start = '" + dateStart + "', date_end = '" + dateEnd
                + " WHERE quote_id = " + quoteId, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public DataTable getInProgress(String userid)
        {
             String connString = FAFOS.Properties.Settings.Default.FAFOS;
            DataTable d = new DataTable();
            SqlConnection con = new SqlConnection(connString);

            con.Open();
            SqlCommand command = new SqlCommand("SELECT Quote.quote_id FROM Quote WHERE NOT EXISTS "
                + "(SELECT quote_id FROM Sales_Order WHERE Sales_Order.quote_id = Quote.quote_id) "+
                "AND franchisee_user_id IN (SELECT user_id FROM [User] WHERE franchisee_id = " +
                "(SELECT franchisee_id FROM [User] WHERE user_id = "+userid+ "))", con);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            try
            {
                adap.Fill(d);
            }
            catch (Exception e)
            { }
            con.Close();
            return d;
        }

        public DataSet getDone(String userid)
        {
             String connString = FAFOS.Properties.Settings.Default.FAFOS;
            DataSet dt = new DataSet();
            SqlConnection con = new SqlConnection(connString);

            con.Open();
            SqlCommand command = new SqlCommand(" SELECT convert(varchar,Quote.date_issued,107) + ', ' + Client.account_name + ', ' + Service_Address.address, "
 +" Quote.quote_id AS varchar"
  +" FROM Service_Address,Quote, Client  "
   +" where Service_Address.service_address_id = Quote.service_address_id AND "
   +" Client.client_contract_id = Service_Address.client_contract_id AND"
   + " quote_id NOT IN (SELECT quote_id FROM Invoice) " +
                "AND Quote.franchisee_user_id IN (SELECT user_id FROM [User] WHERE franchisee_id = " +
                "(SELECT franchisee_id FROM [User] WHERE user_id = " + userid + "))", con);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            adap.Fill(dt);

            con.Close();
            return dt;
        }
    }
}
