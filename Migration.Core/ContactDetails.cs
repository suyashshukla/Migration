using System;

namespace Migration.Core
{
    public class ContactDetails
    {

        public int Id
        {
            get; set;
        }

        public int gender
        {
            get; set;
        }

        public Phone phone
        {
            get; set;
        }

        public Address address
        {
            get; set;
        }

        public Name name
        {
            get; set;
        }

    }

    public class Phone
    {
        public string primary
        {
            get; set;
        }

        public string alternate
        {
            get; set;
        }
    }

    public class Name
    {

        public string firstName
        {
            get; set;
        }


        public string lastName
        {
            get; set;
        }

    }

    public class Address
    {

        public string houseNo
        {
            get; set;
        }

        public string street
        {
            get; set;
        }

        public string locality
        {
            get; set;
        }

        public string city
        {
            get; set;
        }

        public string pin
        {
            get; set;
        }

    }
}
