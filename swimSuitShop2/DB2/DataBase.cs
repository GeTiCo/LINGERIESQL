using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace swimSuitShop2.DB2
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=; Initial Catalog=; Integrated Sequrity=True");

    }
}
