using DemoAjaxPartialView.UI.MVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DemoAjaxPartialView.UI.MVC.Contexto
{
    public class DataContexto:DbContext
    {
        public DataContexto()
            :base("Conexao")
        {

        }

        public DbSet<Wlan> Wlan { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}