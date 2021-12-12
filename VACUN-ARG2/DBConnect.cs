using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VACUN_ARG2
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server="localhost";
        private string database = "vacun-arg";
        private string uid = "root";
        private string password = "test1234";

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            
            string connectionString;

            connectionString = $"SERVER={this.server};DATABASE={this.database};UID={this.uid};PASSWORD={this.password};";

            this.connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Insert(String query)
        {
            int n = 0;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try {
                    n = cmd.ExecuteNonQuery(); 
                }
                catch(MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                this.CloseConnection();
            }
            return n > 0 ? true : false;
        }

        public DataTable Select(String query)
        {
            DataTable results = new DataTable("result");

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                using (MySqlDataReader reader = cmd.ExecuteReader())
                    results.Load(reader);
                this.CloseConnection();
            }

            return results;
        }

        public bool Update(String query)
        {
            int n = 0;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    n = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                this.CloseConnection();
            }

            return n > 0 ? true : false;
        }
    }
}
