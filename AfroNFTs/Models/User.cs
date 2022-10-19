using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AfroNFTs.Models
{
    
   

    internal abstract class User
    {
        
        [Key()]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

     //   [Key()]
        public string email { get; set; }
        public string password { get; set; }
        public decimal balance { get; set; }
        public int generatedNumber { get; set; }
    }
}
