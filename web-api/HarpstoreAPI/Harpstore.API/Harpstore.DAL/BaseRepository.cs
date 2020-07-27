using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Harpstore.DAL
{
    public class BaseRepository 
    {
        protected IDbConnection conn;
        public BaseRepository()
        {
            string connectString = @"Data Source=quangss\sqlexpress;Initial Catalog=QN-Harpstore;Integrated Security=True";
            conn = new SqlConnection(connectString);
        }
    }
}
