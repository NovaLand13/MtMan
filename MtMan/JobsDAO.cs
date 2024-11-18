using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Newtonsoft.Json.Linq;

namespace MtMan
{
    internal class JobsDAO
    {
        string connectionString = "datasource = localhost;port=3306;username=root;password=root;database=mtman;";

        public List<Job> getJobs(int client_ID)
        {
            //start an empty list
            List<Job> returnThese = new List<Job>();

            //connect to database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Define the sql statment to fetch all jobs
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "Select * From job WHERE client_ID = @client_ID";
            command.Parameters.AddWithValue("@client_ID", client_ID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Job j = new Job
                    {
                        ID = reader.GetInt32(0),
                        Amount = reader.GetInt32(1),
                        PaymentType = reader.GetString(2),
                        DateBilled = reader.GetDateTime(3),
                        DatePaid = reader.GetDateTime(4),
                        ServiceDate = reader.GetDateTime(5),
                        Description = reader.GetString(6)
                    };
                    returnThese.Add(j);
                }
            }
            connection.Close();
            return returnThese;
        }

        public List<JObject> getJobsUsingJoin(int client_ID)
        {
            //start an empty list
            List<JObject> returnThese = new List<JObject>();

            //connect to database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Define the sql statment to fetch all jobs
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT Amount, Payment_Type as Payment, Date_Billed as 'Date Billed', Date_Paid as 'Date Paid', Service_Date as 'Service Date', Description FROM `job` JOIN client ON client_ID = client.ID WHERE client_ID = @client_ID";
            command.Parameters.AddWithValue("@client_ID", client_ID);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    JObject newJobs = new JObject();

                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        newJobs.Add(reader.GetName(i).ToString(),reader.GetValue(i).ToString());
                    }

                    returnThese.Add(newJobs);
                }
            }
            connection.Close();
            return returnThese;
        }

    }



    internal class ClientsDAO
    {
        string connectionString = "datasource = localhost;port=3306;username=root;password=root;database=mtman;";

        public List<Client> getAllClients()
        {
            //start an empty list
            List<Client> returnThese = new List<Client>();

            //connect to database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Define the sql statment to fetch all jobs
            MySqlCommand command = new MySqlCommand("Select * From client", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client c = new Client
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Phone_Number = reader.GetString(3),
                        Email = reader.GetString(4)                        
                    };
                    returnThese.Add(c);
                }

            }
            connection.Close();
            return returnThese;
        }

        public List<Client> searchClients(string searchTerm)
        {
            //start an empty list
            List<Client> returnClient = new List<Client>();

            //connect to database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + searchTerm + "%";

            //Define the sql statment to fetch all jobs
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM client WHERE Name LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Client c = new Client
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Phone_Number = reader.GetString(3),
                        Email = reader.GetString(4)
                    };
                    returnClient.Add(c);
                }

            }
            connection.Close();
            return returnClient;
        }

        internal int addClient(Client client)
        {
            
            //connect to database
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //Define the sql statment to fetch all jobs
            MySqlCommand command = new MySqlCommand("INSERT INTO `client`(`Name`, `Address`, `Phone_Number`, `Email`) VALUES (@Name, @Address, @Phone_Number, @Email)", connection);

            command.Parameters.AddWithValue("@Name", client.Name);
            command.Parameters.AddWithValue("@Address", client.Address);
            command.Parameters.AddWithValue("@Phone_Number", client.Phone_Number);
            command.Parameters.AddWithValue("@Email", client.Email);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }
    }
}
