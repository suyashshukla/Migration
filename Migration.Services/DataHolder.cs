using System;
using System.Collections.Generic;
using System.Text;

namespace Migration.Services
{
    public class DataHolder
    {
        public static string connectionString
        {
            get => "Database = C:\\USERS\\SUYASH.S\\SOURCE\\REPOS\\MIGRATION\\MIGRATION.DATA\\CONTACTSDB.MDF; Server=(localDB)\\MSSQLLocalDB;Integrated Security = True;";
            set => new NotSupportedException();
        }
    }
}
