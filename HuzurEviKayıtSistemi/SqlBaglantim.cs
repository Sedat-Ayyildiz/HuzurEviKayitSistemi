﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HuzurEviKayıtSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=SEDATAYYILDIZ;Initial Catalog=HuzureviOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
