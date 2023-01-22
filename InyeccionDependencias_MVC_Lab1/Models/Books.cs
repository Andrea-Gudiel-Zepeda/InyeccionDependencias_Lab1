
namespace InyeccionDependencias_MVC_Lab1.Models
{
    public interface IScoped
    {
    }

    public interface ITransient
    {
        public void datos(string author, string title);
    }

    public interface ISingleton
    {
        
    }

    public class Books : ITransient
    {
        public string name_Author { get; set; }
        public string title { get; set; }


        public Books()
        {
            name_Author = "Hanya Yanigahara";
            this.title = "Tan poca vida";
        }

        public void datos(string author, string title)
        {
            name_Author = author;
            this.title = title;
        }
    }
}
