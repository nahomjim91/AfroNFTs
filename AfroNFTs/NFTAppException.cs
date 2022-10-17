using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AfroNFTs
{
    public class NFTAppException : Exception
    {
       public NFTAppException(string info): base(info)
        {
            //MessageBox.Show(info);
        }
    }
}
