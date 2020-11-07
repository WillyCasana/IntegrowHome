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
       // static string cadconexion = @"Server=DESKTOP-4KPFF10\SVR2016;Database=IntegrowHomeData;User Id=sa;Password=sa";
        static string cadconexion = @"Server=198.38.83.200;Database=dratenz_integrowhome;User Id=dratenz_integrowhome;Password=123.INTEGROWhome";
        public static List<BlogEnt> GetBlogList()
        {
            List<BlogEnt> blogListObj = null;


            using(SqlConnection objconn= new SqlConnection(cadconexion))
            {
                blogListObj = objconn.Query<BlogEnt>("usp_GetBlogList", commandType: CommandType.StoredProcedure).ToList();
            }

            return blogListObj;
        }


        public static void BlogRegistrarEntrada(EntradaBlogEnt entrada)
        {
            

            using(SqlConnection objConn = new SqlConnection(cadconexion))
            {
                objConn.Execute("usp_BlogRegEntrada", new { entrada.TituloEntrada, entrada.ImagenEntrada, entrada.FechaEntrada, entrada.DescripcionEntrada }, commandType: CommandType.StoredProcedure);
            }

           
        }


    }
}
