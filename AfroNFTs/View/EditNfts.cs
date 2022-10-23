using AfroNFTs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfroNFTs.View
{
    public partial class EditNfts : Form
    {
        int id;
        bool pageType;
        public EditNfts(bool pageType ,int id)
        {
            InitializeComponent();
            this.id = id;
            this.pageType = pageType;
        }

        private void EditBtn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameNFTS.Text) || string.IsNullOrEmpty(txtPriceNFTs.Text))
            {
                if (string.IsNullOrEmpty(txtNameNFTS.Text)) {
                    errorProvider1.SetError(txtNameNFTS, "reiqired");
                    return;
                }
                    
                if (string.IsNullOrEmpty(txtPriceNFTs.Text)) { 
                    errorProvider1.SetError(txtPriceNFTs, "reiqired");
                    return;
                }
                if (double.Parse(txtPriceNFTs.Text) < 0)
                {
                    errorProvider1.SetError(txtPriceNFTs, "priceisLess0!");
                    return;
                }
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string conStr = ConfigurationManager.ConnectionStrings["DbService"].ConnectionString;

                    using (var con = new SqlConnection(conStr))
                    {
                        var sql = "UPDATE  NFTsClasses SET NFTsName ='"+ txtNameNFTS.Text + "',NFTsprice = "+ double.Parse( txtPriceNFTs.Text) + " where NFtsClassId = " + id;
                        con.Open();
                        var cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                        Program.main.OpenchildFrom(new PreposOfPage( pageType, id), sender);
                    }
                    }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Program.main.OpenchildFrom(new PreposOfPage(pageType, id), sender);
                }
            }
        }
    }
}
