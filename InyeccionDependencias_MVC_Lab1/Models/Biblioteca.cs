namespace InyeccionDependencias_MVC_Lab1.Models
{
    public class Biblioteca : ISingleton
    {
        public readonly string name;
        //public Books ibooks { get; set; }
        //public List<Sucursales> _sucursales { get; set; }

        public Biblioteca()
        {
            this.name = "BIBLIOTECA DREAMS";
            //this.ibooks = ibooks;
            //_sucursales = sucursales;
        }

    }
}
