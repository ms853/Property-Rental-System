using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace PropertyService
{
    
    // NOTE: In order to launch WCF Test Client for testing this service, please select PropertyService.svc or PropertyService.svc.cs at the Solution Explorer and start debugging.
    public class PropertyService : IPropertyService
    {
       

        //Search property via postcode 
        public List<Property> SearchPropertyByPostCode(string postCode)
        {
            List<Property> propertyList = new List<Property>();

            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                
                //This variable is responsible for running the sql query. 
                MySqlCommand sqlCommand = new MySqlCommand("", connection);
                sqlCommand.Prepare();
                
                //sql query for getting the properties based on the postcode. 
                sqlCommand.CommandText = String.Format("select * from property where property.post_code like '" + postCode + '%' + "' ");
               
                MySqlDataReader mySqlData = sqlCommand.ExecuteReader();

                //read the database and retrieve the data
                //data is set apporpriately and accordingly
                while (mySqlData.Read())
                {
                    if (mySqlData.HasRows)
                    {
                        Property property = new Property()
                        {
                            PropertyName = mySqlData.GetString("property_name"),
                            Address = mySqlData.GetString("property_address"),
                            PostCode = mySqlData.GetString("post_code"),
                            PropertyType = mySqlData.GetString("property_type"),
                            PropertyPrice = mySqlData.GetString("property_price"),
                            MaxNoOfOccupancy = mySqlData.GetInt32("max_no_occupancy"),
                            MultipleOccupancy = mySqlData.GetBoolean("multiple_occupancy"),
                            ResidentStatus = mySqlData.GetString("resident_status"),
                            Pets_allowed = mySqlData.GetString("pets_allowed"),
                            Children_allowed = mySqlData.GetString("children_allowed")
                        };

                        propertyList.Add(property);
                    }
                }

                //close the data reader and connection
                mySqlData.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return propertyList;
        }

        //Method for inserting a new property into the database. 
        public bool EnterNewProperty(Property p)
        {
            bool isAdded = false;
            try
            {
                MySqlConnection connection = GetConnection();
                connection.Open();
                MySqlCommand command = new MySqlCommand("", connection);
                command.Prepare(); 
                command.CommandText = String.Format("INSERT INTO property (property_name, property_address, " +
                    "post_code, property_type, property_price, max_no_occupancy, multiple_occupancy, resident_status, pets_allowed, children_allowed)"
                    + "values (?name_param,?address_param,?post_code_param,?property_type_param,?property_price_param," +
                    "?max_no_occupancy_param,?multiple_occupancy_param,?resident_status_param,?pets_allowed_param,?children_param)");

                command.Parameters.AddWithValue("?name_param", p.PropertyName);
                command.Parameters.AddWithValue("?address_param", p.Address);
                command.Parameters.AddWithValue("?post_code_param", p.PostCode);
                command.Parameters.AddWithValue("?property_type_param", p.PropertyType);
                command.Parameters.AddWithValue("?property_price_param", p.PropertyPrice);
                command.Parameters.AddWithValue("?max_no_occupancy_param", p.MaxNoOfOccupancy);
                command.Parameters.AddWithValue("?multiple_occupancy_param", p.MultipleOccupancy);
                command.Parameters.AddWithValue("?resident_status_param", p.ResidentStatus);
                command.Parameters.AddWithValue("?pets_allowed_param", p.Pets_allowed);
                command.Parameters.AddWithValue("?children_param", p.Children_allowed);

                //Execute insertion query to add the following records to the property table
                command.ExecuteNonQuery();

                //Execute sql command for lettings table.
                
                int pID = Convert.ToInt32(command.LastInsertedId);
                //command.CommandText = String.Format("INSERT INTO lettings values (?cs_param, ?lease_arrange_param, ?is_available_param, ?prop_no_param)");
                string sqlQuery = "INSERT INTO lettings (current_status, lease_arrangement, is_available, property_no) values (?cs_param, ?lease_arrange_param, ?is_available_param, ?prop_no_param)";
                command = new MySqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("?cs_param", p.CurrentStatus);
                command.Parameters.AddWithValue("?lease_arrange_param", p.LeaseArrDate);
                command.Parameters.AddWithValue("?is_available_param", p.IsAvailable);
                command.Parameters.AddWithValue("?prop_no_param", pID);
                

                //Execute insertion query to add the following records to the lettings table.
                command.ExecuteNonQuery();

                //once the new property is added successfully boolean variable is set to true.
                isAdded = true;
                //close connection
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return isAdded;
            }

            return isAdded;
        }

        //This method gets a list of all available properties that can acommodate students.
        public List<Property> GetAllPropertiesForStudents()
        {
            List<Property> avaialbleProperties = new List<Property>();

            try
            {
                MySqlConnection connection = GetConnection();
                //open connection 
                connection.Open();

                
                //mysql command for the property table 
                MySqlCommand myscom = new MySqlCommand("", connection);

                myscom.Prepare();
                myscom.CommandText = String.Format("select * from property where resident_status = 'Student'");

                
                MySqlDataReader reader = myscom.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        Property p = new Property
                        {
                            PropertyID = reader.GetInt32("property_no"),
                            PropertyName = reader.GetString("property_name"),
                            Address = reader.GetString("property_address"),
                            PropertyPrice = reader.GetString("property_price"),
                            PostCode = reader.GetString("post_code"),
                            MaxNoOfOccupancy = reader.GetInt32("max_no_occupancy"),
                            MultipleOccupancy = reader.GetBoolean("multiple_occupancy"),
                            ResidentStatus = reader.GetString("resident_status"),
                            Pets_allowed = reader.GetString("pets_allowed"),
                            Children_allowed = reader.GetString("children_allowed"),
                            PropertyType = reader.GetString("property_type")
                            //CurrentStatus = reader.GetBoolean("current_status"),
                            //LeaseArrDate = reader.GetString("lease_arrangement"),
                            //IsAvailable = reader.GetBoolean("is_available")
                        };

                        avaialbleProperties.Add(p);
                    }
                }

                //mysql command for the lettings table
                MySqlCommand command = new MySqlCommand("", connection);

                command.Prepare();
                command.CommandText = String.Format("select * from lettings where is_available = 1");
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        Property p = new Property();
                        p.CurrentStatus = reader.GetBoolean("current_status");
                        p.LeaseArrDate = reader.GetString("lease_arrangement");
                        p.IsAvailable = reader.GetBoolean("is_available");

                        avaialbleProperties.Add(p);
                    }
                }
                
                
                reader.Close();
                connection.Close();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.HelpLink);
            }

            return avaialbleProperties;
        }


        //Method for establishing connection to the database.
        public static MySqlConnection GetConnection()
        {
            //NOTE - that I am connecting to mysql database locally!
            string connectionString = "server=localhost;user id=root;database=propertyDB;port=3307;password=superman;CharSet=utf8;";

            //Instance for establishing connection 
            MySqlConnection myconnection = new MySqlConnection(connectionString);

            return myconnection;
        }


    }
}
