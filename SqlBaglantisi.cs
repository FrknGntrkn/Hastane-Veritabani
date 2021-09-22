using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class SqlBaglantisi
    {

        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-Q87MGS4;Initial Catalog=Hastane_Proje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }



    }
}
