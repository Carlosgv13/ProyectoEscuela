using System;

namespace Core_Nucleo_
{


    public class Alumno
    {
        string Nombre;
        int ID;

        public Alumno(string Nombre , int ID)
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

}