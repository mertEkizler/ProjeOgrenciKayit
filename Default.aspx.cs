﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeOgrenciKayit
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLOGRENCILERTableAdapter dt = new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
            dt.OgrenciEkle(TxtAdSoyad.Text, TxtTelefon.Text, TxtMail.Text, DropDownList1.SelectedItem.ToString(), DropDownList2.SelectedItem.ToString());
            
        }
    }
}