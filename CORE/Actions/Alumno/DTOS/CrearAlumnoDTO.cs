public class CrearAlumnoDTO

    //cAMBIAR GET Y SET 
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

