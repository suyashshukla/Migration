using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Migration.Data
{

    [Table("ContactDetails")]
    public class ContactDetails
    {
        [ExplicitKey]
        public int Id { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public int gender { get; set; }

    }
}
