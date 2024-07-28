using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class SqlBaglantsi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-NCL6B1V\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
