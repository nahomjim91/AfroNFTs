using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace AfroNFTs.Models
{
    [Table("admin")]
    internal class Admin: User
    {
        public List<Page> pages { get; set; } = new List<Page>();
    }
}
