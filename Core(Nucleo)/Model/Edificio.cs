﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Nucleo_
{
    public class Edificios
    {
        //id
        //Nombreºº

        string Nombre;
        int ID;

      //Duda preguntar Carlos
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
