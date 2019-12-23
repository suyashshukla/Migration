using System;
using System.Collections.Generic;
using System.Text;
using Migration.Core;
using Migration.Data;
using PetaPoco.NetCore;
using AutoMapper;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions;
using Newtonsoft.Json;

namespace Migration.Services
{
    public class ContactService : IContactService
    {
        AutoMapper.IMapper mapper;
        Database database;
        public ContactService(AutoMapper.IMapper mapper)
        {
            IDbConnection connection = new SqlConnection("Database=C:\\USERS\\SUYASH.S\\SOURCE\\REPOS\\MIGRATION\\MIGRATION.DATA\\CONTACTSDB.MDF;Server=(localDB)\\MSSQLLocalDB;" +
                "Integrated Security=True;");

            database = new Database(connection);
            this.mapper = mapper;
        }

        public int Delete(int id)
        {
            return 51;
        }

        public IEnumerable<Core.ContactDetails> Get()
        {
            var contactData = database.Query<Data.ContactDetails>("SELECT * FROM ContactDetails") ;

            return mapper.Map<IEnumerable<Core.ContactDetails>>(contactData);
        }

        public Core.ContactDetails Get(int id)
        {
            var contact = database.Single<Data.ContactDetails>("SELECT * FROM ContactDetails WHERE id=" + id);

            return mapper.Map<Core.ContactDetails>(contact);
        }

        public int Post(Core.ContactDetails contactDetails)
        {
            var contact = mapper.Map<Data.ContactDetails>(contactDetails);

            return database.Insert(contact)==null?0:1;
        }

        public int Put(Core.ContactDetails contactDetails)
        {
            var contact = mapper.Map<Data.ContactDetails>(contactDetails);

            return database.Update(contact);
        }
    }
}
