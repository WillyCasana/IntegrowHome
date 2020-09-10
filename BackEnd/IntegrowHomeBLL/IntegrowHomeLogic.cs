using IntegrowHomeBOL;
using IntegrowHomeDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace IntegrowHomeBLL
{
    public static class IntegrowHomeLogic
    {
        public static List<BlogEnt> GetBlogList()
        {
           

            return IntegrowHomeDb.GetBlogList();

        

        }
    }
}
