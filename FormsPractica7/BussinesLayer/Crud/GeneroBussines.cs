using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Crud
{
    public class GeneroBussines
    {
        GeneroData generoData = new GeneroData();

        public DataTable GetGenero()
        {
            DataTable generoTable = new DataTable();

            generoTable = generoData.GetAllgenero();
            return generoTable;
        }
    }
}
