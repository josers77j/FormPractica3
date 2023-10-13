using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Crud
{
    public class NacionalidadBussines
    {
        NacionalidadData nacionalidadData = new NacionalidadData();

        public DataTable GetNacionalidad()
        {
            DataTable nacionalidadTable = new DataTable();
            nacionalidadTable = nacionalidadData.GetAllNacionalidades();
            return nacionalidadTable;
        }
    }
}
