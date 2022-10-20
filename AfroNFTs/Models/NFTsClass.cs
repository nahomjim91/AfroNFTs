using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AfroNFTs.Models
{
    
    public class NFTsClass
    {
        public string userType { get; set; }
        public int NFtsClassId { get; set; }

        private byte[] _NftsPicture;

        public bool isAvelebel { get; set; }     
        public byte[] NftsPicture
        {
            get { return _NftsPicture; }
            set { _NftsPicture = value;  }
        }

        private int _IDNFTs;

        public int IDNFTs
        {
            get { return _IDNFTs; }
            set { _IDNFTs = value; }
        }

        private int _OwnerID;

        public int OwnerID
        {
            get { return _OwnerID; }
            set { _OwnerID = value; }
        }



        private string _NFTsName;

        public string NFTsName
        {
            get { return _NFTsName; }
            set { _NFTsName = value; }
        }

        private string _Group;

        public string Group
        {
            get { return _Group; }
            set { _Group = value; }
        }


        private string _description;

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }


        private double _NFTsprice;

        public double NFTsprice
        {
            get { return _NFTsprice; }
            set { _NFTsprice = value; }
        }

        private double _NFTsRate;

        //public Page ownerPage;
        public double NFTsRate
        {
            get { return _NFTsRate; }
            set { _NFTsRate = value; }
        }

       public NFTsClass()
        {
            //IdNFTs++;
        }
       private static List<NFTsClass> _nftsClass = new List<NFTsClass>();
        public void save ()
        {
            _nftsClass.Add(this);
            MessageBox.Show("save");
            DbService dbService = new DbService();
            dbService.nftTB.Add(this);
            dbService.SaveChanges();
        }
        public static List<NFTsClass> getAllNFTs()
        {
            return _nftsClass;
        }

        public int pageId { get; set; }

    }

}
