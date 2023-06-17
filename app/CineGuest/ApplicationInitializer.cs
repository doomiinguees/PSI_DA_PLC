using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CineGuest
{
    public class ApplicationContextInitializer : CreateDatabaseIfNotExists<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            IList<Categoria> defaultCategorias = new List<Categoria>();

            defaultCategorias.Add(new Categoria { Id = 1, Nome = "Comédia" });
            defaultCategorias.Add(new Categoria { Id = 2, Nome = "Ficção Cientifica" });
            defaultCategorias.Add(new Categoria { Id = 3, Nome = "Terror" });
            defaultCategorias.Add(new Categoria { Id = 4, Nome = "Romance" });
            defaultCategorias.Add(new Categoria { Id = 5, Nome = "Ação" });
            defaultCategorias.Add(new Categoria { Id = 6, Nome = "Trhiller" });
            defaultCategorias.Add(new Categoria { Id = 7, Nome = "Drama" });
            defaultCategorias.Add(new Categoria { Id = 8, Nome = "Mistério" });
            defaultCategorias.Add(new Categoria { Id = 9, Nome = "Crime" });
            defaultCategorias.Add(new Categoria { Id = 10, Nome = "Aventura" });
            defaultCategorias.Add(new Categoria { Id = 11, Nome = "Fantasia" });
            defaultCategorias.Add(new Categoria { Id = 12, Nome = "Animação" });


            context.Categorias.AddRange(defaultCategorias);

            IList<Cliente> defaultCliente = new List<Cliente>();

            defaultCliente.Add(new Cliente { Id = 1, Nome = "Anónimo", Rua = " ", Localidade = " ", CodPostal = " ", NIF = 000000000 });

            context.Clientes.AddRange(defaultCliente);
            base.Seed(context);
        }
    }
}