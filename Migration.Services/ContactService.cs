using System;
using System.Collections.Generic;
using System.Text;
using Migration.Core;
using Migration.Data;
using PetaPoco.NetCore;
using AutoMapper;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions;
using Newtonsoft.Json;
using Dapper.Contrib.Extensions;

namespace Migration.Services
{
    public class ContactService : IContactService
    {

        AutoMapper.IMapper mapper;
        Database database;
        IDbConnection connection;

        public ContactService(AutoMapper.IMapper mapper, IDbConnection connection)
        {
            this.connection = connection;

            database = new Database(connection);
            this.mapper = mapper;
        }

        public int Delete(int id)
        {
            return 51;
        }

        public IEnumerable<Core.ContactDetails> Get()
        {
            var contactDataPetapoco = connection.Query<Data.ContactDetails>("SELECT * FROM ContactDetails"); //PetaPoco

            var contactDataDapper = connection.GetAll<Data.ContactDetails>(); //Dapper

            return mapper.Map<IEnumerable<Core.ContactDetails>>(contactDataDapper); 
        }

        public Core.ContactDetails Get(int id)
        {
            var contactPetapoco = connection.QueryFirst<Data.ContactDetails>("SELECT * FROM ContactDetails"); //PetaPoco

            var contactDapper = connection.Get<Data.ContactDetails>(1);  //Dapper

            return mapper.Map<Core.ContactDetails>(contactDapper);
        }

        public int Post(Core.ContactDetails contactDetails)
        {

            Data.ContactDetails contact = mapper.Map<Data.ContactDetails>(contactDetails);


            var insertPetapoco = database.Insert(contact); //Petapoco

            var insertDapper = connection.Insert(contact);  //Dapper

            return (int)insertDapper;
        }

        public int Put(Core.ContactDetails contactDetails)
        {
            var contact = mapper.Map<Data.ContactDetails>(contactDetails);

            var updatePetapoco = database.Update(contact);  //PetaPoco

            var updateDapper = connection.Update(contact);  //Dapper    

            return database.Update(contact);
        }
    }
}
