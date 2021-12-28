using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WForm001
{

    public class DbAppContext : DbContext
    {

        public DbSet<PO_TEL_VID_CONNECT> pO_TEL_VID_CONNECTs { get; set; }

        public DbSet<PO_TEL_OPERATOR> pO_TEL_OPERATORs { get; set; }


        public DbAppContext() : base() //base(@"initial catalog=C:\SSG\PROJECTs\TELET\DB4TELEFONE\sampd_cexs.fdb;data source=localhost;user id=sysdba;password=masterkey;pooling=True")
        {

        }

        public DbAppContext(string stringConnectionToSqlServer) : base(stringConnectionToSqlServer)
        {

        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<PO_TEL_OPERATOR>()
            .HasOne<PO_TEL_VID_CONNECT>(s => s.Id)
            .WithMany(g => g.pO_TEL_OPERATORs)
            .HasForeignKey(s => s.IdOfConnectType);
            */
            modelBuilder.Entity<PO_TEL_VID_CONNECT>().HasMany(c => (ICollection<PO_TEL_VID_CONNECT>)c.pO_TEL_OPERATORs);
        }


    }


}
