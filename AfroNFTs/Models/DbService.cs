using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace AfroNFTs.Models
{
    internal class DbService : DbContext
    {
       public DbSet<NFTsClass> nftTB { get; set; }    
       public DbSet<Admin> adminTB { get; set; }
       public DbSet<Page> pageTB { get; set; }
       public DbSet<NormalUser> normalUserTB { get; set; }

    }
}
