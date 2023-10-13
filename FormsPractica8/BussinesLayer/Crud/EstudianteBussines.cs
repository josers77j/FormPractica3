using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Crud
{
    public class EstudianteBussines
    {
        EstudianteData estudianteData = new EstudianteData();

        public DataTable getEstudiante()
        {
            DataTable estudianteTable  = new DataTable();
            estudianteTable = estudianteData.getAllEstudiantes();
            return estudianteTable;
        }

        public void addEstudiante(string nombreEstudiante, string apellidoEstudiante, string telefonoEstudiante, string ciudadEstuiante)
        {
            estudianteData.addEstudiantes(nombreEstudiante,apellidoEstudiante,telefonoEstudiante,ciudadEstuiante);
        }

        public void updateEstudiante(int codigoEstudiante, string nombreEstudiante, string apellidoEstudiante, string telefonoEstudiante, string ciudadEstuiante)
        {
            estudianteData.updateEstudiantes(codigoEstudiante,nombreEstudiante, apellidoEstudiante, telefonoEstudiante, ciudadEstuiante);
        }

        public void deleteEstudiante(int codigoEstudiante)
        {
            estudianteData.deleteEstudiantes(codigoEstudiante);
        }
    }
}
