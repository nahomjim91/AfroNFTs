using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfroNFTs.Models
{
    internal class Page

    {
        public int PageId { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public byte [] pageImage { get; set; } 

        public List<NFTsClass> nfts;

    }
}
