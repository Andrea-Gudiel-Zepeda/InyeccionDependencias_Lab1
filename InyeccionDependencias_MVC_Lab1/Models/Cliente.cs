namespace InyeccionDependencias_MVC_Lab1.Models
{
    public class Cliente : IScoped
    {
        public readonly int Id;

        public Cliente()
        {
            Id = new Random().Next(10000);
        }
    }
}
