using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Crud
{
    public class ManagerBussines
    {
        ManagerData managerData = new ManagerData();

    public DataTable GetManagers()
        {
            DataTable managersTable = new DataTable();

            managersTable = managerData.GetAllManagers();
            return managersTable;
        }

        public void AddManager(string firstName, string lastName)
        {
            managerData.AddManager(firstName, lastName);
        }

        public void UpdateManager(int id, string firstName, string lastName)
        {
            managerData.UpdateManager(id, firstName, lastName);
        }

        public void DeleteManager(int id)
        {
            managerData.DeleteManager(id);
        }
    }
}
