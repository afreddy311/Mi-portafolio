using Portafolio.Models;

namespace Portafolio.Servicios
{ 
    public interface IRepositorioProyectos
{
    List<Proyecto> ObtenerProyectos();
}

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {

                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-commerce realizado en ASP.NET.Core",
                Link = "https://www.nytimes.com/",
                ImagenURL = "/Imagenes/amazon.png "

            },
                new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Pagina de Noticias en React",
                Link = "https://www.amazon.com/",
                ImagenURL = "/Imagenes/nyt.png "

            },new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Red Social para compartir en comunidades",
                Link = "https://www.reddit.com/",
                ImagenURL = " /Imagenes/reddit.png "

            },new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en linea para comprar videojuegos",
                Link = "https://www.store.steampowered.com/",
                ImagenURL = "/Imagenes/steam.png  "

            },
            };
        }

    }
}
