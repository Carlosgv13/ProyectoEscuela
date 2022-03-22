using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Actions.Alumno
{
    public class Alumno
    {
        int Id;
        string Nombre;

        public void SetId(int ID)
        {
            this.Id = Id;

        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public int GetId()
        {
            return this.Id;
        }


    }

}