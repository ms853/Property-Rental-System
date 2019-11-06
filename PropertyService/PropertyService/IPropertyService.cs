
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace PropertyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPropertyService" in both code and config file together.
    [ServiceContract]
    public interface IPropertyService
    {

        [OperationContract]
        List<Property> SearchPropertyByPostCode(string postCode);

        [OperationContract]
        bool EnterNewProperty(Property p);

        [OperationContract]
        List<Property> GetAllPropertiesForStudents();
    }

    [DataContract]
    public class Property
    {

        //Encapsulate Fields
        [DataMember]
        public int PropertyID
        {
            get;
            set;
        }

        [DataMember]
        public string PropertyName
        {
            get;
            set;
        }

        [DataMember]
        public string Address
        {
            get;
            set;
        }

        [DataMember]
        public string PostCode
        {
            get;
            set;
        }

        [DataMember]
        public string PropertyType
        {
            get;
            set;
        }

        [DataMember]
        public string PropertyPrice
        {
            get;
            set;
        }

        [DataMember]
        public string ResidentStatus
        {
            get;
            set;
        }

        [DataMember]
        public int MaxNoOfOccupancy
        {
            get;
            set;
        }

        [DataMember]
        public bool MultipleOccupancy
        {
            get;
            set;
        }

        [DataMember]
        public string Pets_allowed
        {
            get;
            set;
        }

        [DataMember]
        public string Children_allowed
        {
            get;
            set;
        }

        [DataMember]
        public bool CurrentStatus
        {
            get;
            set;
        }

        [DataMember]
        public string LeaseArrDate
        {
            get;
            set;

        }

        [DataMember]
        public bool IsAvailable

        {
            get;
            set;
        }

        //This method will be responsible for printing the values.
        
        override
        public string ToString()
        {
            return "Property information retrieved from the database: "
                + "\n" + "Property ID: " + PropertyID + "\tProperty Name: " + PropertyName
                + "\tAddress: " + Address + "\nPost Code: " + PostCode + "\n"
                + "Property Type: " + PropertyType + "\tProperty Price: " + PropertyPrice + "\tResidence Status: " + ResidentStatus
                + "\n" + "Maximum Number Of Occupants Allowed: " + MaxNoOfOccupancy + "\tMultiple Occupancy: " + MultipleOccupancy
                + "\nAre Pets Allowed? " + Pets_allowed + "\tAre Children Allowed To Live In This Property? " + Children_allowed + "\n"
                + "Current Status (Whether if it is let/empty): " + CurrentStatus + "\tLease Arrangement Date: " + LeaseArrDate
                + "\tIs the property available? " + IsAvailable;
        }
    }

}
