namespace Core_Nucleo_;

<<<<<<< Updated upstream:CORE/Actions/Escuela/Escuela.cs
public class Escuela
 {
        string Nombre;
        int ID;

        public Escuela(string Nombre , int ID)
        {
            this.Nombre = Nombre;
            this.ID = ID;
        }
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SetID(int Id)
        {
            this.ID = Id;
        }
        public string GetNombre()
        {
            return this.Nombre;
        }
        public int GetID()
        {
            return this.ID;

        }
        
    
 }

=======
namespace Core_Nucleo_
{


    public class Alumno
    {
        

        public string Nombre { get; set; }
        public int ID { get; set; }


    }
}
>>>>>>> Stashed changes:Alumno.cs
