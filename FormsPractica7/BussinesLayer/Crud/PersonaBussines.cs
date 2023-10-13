using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Crud
{
    public class PersonaBussines
    {
        PersonaData personaData = new PersonaData();    

        public DataTable GetPersona()
        {
            DataTable personaTable = new DataTable();
            personaTable = personaData.GetAllPersonas();    
            return personaTable;
        }
    }
}
