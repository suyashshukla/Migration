using Migration.Core;
using Migration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migration.Services

{
    public interface IContactService
    {

        public IEnumerable<Core.ContactDetails> Get();

        public Core.ContactDetails Get(int id);

        public int Post(Core.ContactDetails contactDetails);

        public int Put(Core.ContactDetails contactDetails);

        public int Delete(int id);

    }
}
