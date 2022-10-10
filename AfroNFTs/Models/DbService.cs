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
        DbSet<NFTsClass> nftTB { get; set; }    
        DbSet<Admin> adminTB { get; set; }
        DbSet<Page> pageTB { get; set; }
        DbSet<NormalUser> normalUserTB { get; set; }

    }
}
