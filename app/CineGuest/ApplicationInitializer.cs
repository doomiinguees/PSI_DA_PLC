using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CineGuest
{
    public class ApplicationInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            IList<Categoria> defaultCategorias = new List<Categoria>();

            defaultCategorias.Add(new Categoria { nome = "Comédia" });
            defaultCategorias.Add(new Categoria { nome = "Ficção Cientifica" });
            defaultCategorias.Add(new Categoria { nome = "Terror" });
            defaultCategorias.Add(new Categoria { nome = "Romance" });
            defaultCategorias.Add(new Categoria { nome = "Ação" });
            defaultCategorias.Add(new Categoria { nome = "Thriller" });
            defaultCategorias.Add(new Categoria { nome = "Drama" });
            defaultCategorias.Add(new Categoria { nome = "Mistério" });
            defaultCategorias.Add(new Categoria { nome = "Crime" });
            defaultCategorias.Add(new Categoria { nome = "Aventura" });
            defaultCategorias.Add(new Categoria { nome = "Fantasia" });
            defaultCategorias.Add(new Categoria { nome = "Animação" });

            base.Seed(context);
        }
    }
}
