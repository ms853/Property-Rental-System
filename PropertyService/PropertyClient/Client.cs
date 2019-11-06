using System;
//using PropertyClient.ServiceReference1;
using PropertyClient.UOServiceReference;

namespace PropertyClient
{
    class Client
    {
        static void Main(string[] args)
        {
            
            //This is a client object, that will be used to invoke the service methods created in web service. 
            ServiceReference1.PropertyServiceClient rentServiceClient = new ServiceReference1.PropertyServiceClient();

            //Web service object for converting postcode to uppercase
            UpperOperatorPortTypeClient clientUpper = new UOServiceReference.UpperOperatorPortTypeClient("UpperOperatorSOAP12port_http");

            //while loop then have a switching case for the following options. 
            do
            {
                Console.WriteLine("Welcome to Mike's Rental Service \n Please choose the following options:");
                
                Console.WriteLine("Press 'a' to search a property");
                Console.WriteLine("Press 'b' to enter a new property");
                Console.WriteLine("Press 'c' to show available student lets");
                Console.WriteLine("Type stop to exit this program");
                Console.WriteLine("Write a letter to the corresponding option you want to pick.");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "a":
                          Console.WriteLine("Enter the postcode to search for properties: ");
                          string post_code = Console.ReadLine();
                          post_code = clientUpper.upper(post_code);
                          Console.WriteLine("Upper Case Post code -> " + post_code);
                        
                        ServiceReference1.Property[] propertyList = rentServiceClient.SearchPropertyByPostCode(post_code);
                        
                        Console.WriteLine("Here are the list of properties with the postcode you have provided!");
                        foreach (ServiceReference1.Property prop in propertyList) //Iterating through the list and assigning all the values to the properties accordingly.
                        {
                            Console.WriteLine("Property Number: " + prop.PropertyID + "\n");
                            Console.WriteLine("Property Name: " + prop.PropertyName + "\n");
                            Console.WriteLine("Property Price: " + prop.PropertyPrice + '\n');
                            Console.WriteLine("Property Address: " + prop.Address + "\n");
                            Console.WriteLine("Property Post Code: " + prop.PostCode + "\n");
                            Console.WriteLine("Property Type: " + prop.PropertyType + "\n");
                            Console.WriteLine("Resident Status: " + prop.ResidentStatus + "\n");
                            Console.WriteLine("Multiple Occupancy? " + prop.MultipleOccupancy + "\n");
                            Console.WriteLine("Maximum Number Of Occupants: " + prop.MaxNoOfOccupancy + "\n");
                            Console.WriteLine("Is property available to Students?" + prop.IsAvailable + "\n");
                            Console.WriteLine("Are pets allowed in the property? " + prop.Pets_allowed + "\n");
                            Console.WriteLine("Are children allowed in that property? " + prop.Children_allowed + "\n");
                            Console.WriteLine("Is the property leased? " + prop.CurrentStatus + "\n");
                            Console.WriteLine("Lease Arrangement Date: " + prop.LeaseArrDate + "\n");

                        }      
                        break;
                        
                    case "b":
                        ServiceReference1.Property p = new ServiceReference1.Property();
                        
                        Console.WriteLine("Enter a new property.\n");
                        
                        Console.WriteLine("\nEnter Property Name");
                        p.PropertyName = Console.ReadLine();
                        Console.WriteLine("\nEnter Property Address");
                        p.Address = Console.ReadLine();
                        Console.WriteLine("\nEnter Property Postcode");
                        string  p_code = Console.ReadLine();
                        p.PostCode = clientUpper.upper(p_code); 
                        Console.WriteLine("\nEnter Property Type");
                        p.PropertyType = Console.ReadLine();
                        Console.WriteLine("\nEnter Property Price");
                        p.PropertyPrice = Console.ReadLine();
                        Console.WriteLine("\nEnter the Max Number Of Occupancy for this property");
                        p.MaxNoOfOccupancy = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nIs this property allowed to have multiple occupancy? (True/False)");
                        p.MultipleOccupancy = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter the allowed resident status for this property. (Student/Non-Student)");
                        p.ResidentStatus = Console.ReadLine();
                        Console.WriteLine("\nAre pets allowed in this property? (yes/no)");
                        p.Pets_allowed = Console.ReadLine();
                        Console.WriteLine("\nAre children allowed to live in this property? (yes/no)");
                        p.Children_allowed = Console.ReadLine();
                        Console.WriteLine("\nWhat is the current status of this property? Has it been leased? (empty - false/let - true)");
                        p.CurrentStatus = Boolean.Parse(Console.ReadLine());
                        Console.WriteLine("\nEnter the lease arrangement date for this property? Otherwise, specify n/a");
                        p.LeaseArrDate = Console.ReadLine();
                        Console.WriteLine("\nIs this property available to students? (false - no, true - yes)");
                        p.IsAvailable = Boolean.Parse(Console.ReadLine());

                        Console.WriteLine(rentServiceClient.EnterNewProperty(p)); //calling the service method to add a new property.
                        Console.WriteLine("The property which you provided the information for has been added successfully to the database.");
                        break;

                    case "c":
                        Console.WriteLine("Here are all the available student properties\n");
                        ServiceReference1.Property[] studentPropList = rentServiceClient.GetAllPropertiesForStudents();

                        foreach (ServiceReference1.Property studentProp in studentPropList)
                        {
                            Console.WriteLine("Property Number: " + studentProp.PropertyID + "\n");
                            Console.WriteLine("Property Name: " + studentProp.PropertyName + "\n");
                            Console.WriteLine("Property Price: " + studentProp.PropertyPrice + '\n');
                            Console.WriteLine("Property Address: " + studentProp.Address + "\n");
                            Console.WriteLine("Property Post Code: " + studentProp.PostCode + "\n");
                            Console.WriteLine("Property Type: " + studentProp.PropertyType + "\n");
                            Console.WriteLine("Resident Status: " + studentProp.ResidentStatus + "\n");
                            Console.WriteLine("Multiple Occupancy? " + studentProp.MultipleOccupancy + "\n");
                            Console.WriteLine("Maximum Number Of Occupants: " + studentProp.MaxNoOfOccupancy + "\n");
                            Console.WriteLine("Is property available to Students?" + studentProp.IsAvailable + "\n");
                            Console.WriteLine("Are pets allowed in the property? " + studentProp.Pets_allowed + "\n");
                            Console.WriteLine("Are children allowed in that property? " + studentProp.Children_allowed + "\n");
                            Console.WriteLine("Is the property leased? " + studentProp.CurrentStatus + "\n");
                            Console.WriteLine("Lease Arrangement Date: " + studentProp.LeaseArrDate + "\n");

                        }

                        break;

                    default:
                            Console.WriteLine("Mike's Rental Company, find the property for you!");
                        break;
                }

            }
            while (!Console.ReadLine().Equals("stop"));
            
        }
    }
}
