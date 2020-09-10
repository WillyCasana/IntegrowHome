using IntegrowHomeBOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace IntegrowHomeDAL
{
    public static class IntegrowHomeDb
    {
        static string cadconexion = @"Server=DESKTOP-4KPFF10\SVR2016;Database=IntegrowHomeData;User Id=sa;Password=sa";

        public static List<BlogEnt> GetBlogList()
        {
            List<BlogEnt> blogListObj = null;


            using(SqlConnection objconn= new SqlConnection(cadconexion))
            {
                blogListObj = objconn.Query<BlogEnt>("usp_GetBlogList", commandType: CommandType.StoredProcedure).ToList();
            }

            return blogListObj;
        }


    }
}
