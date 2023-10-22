using CommonLayer;
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
        public DataTable SearchStudents(string search)
        {

            DataTable studentTable = new DataTable();
            studentTable = estudianteData.SearchStudents(search);

            return studentTable;
        }
        public void addEstudiante(Students students)
        {
            estudianteData.addEstudiantes(students);
        }

        public void updateEstudiante(Students students)
        {
            estudianteData.updateEstudiantes(students);
        }

        public void deleteEstudiante(Students students)
        {
            estudianteData.deleteEstudiantes(students);
        }
    }
}
