using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLoadMenuSubMenu.Data
{
    public class MenuService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public MenuService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<MenuInfo>> GetMenuData()
        {
            IEnumerable<MenuInfo> menuInfos;

            using (var conn= new SqlConnection(_configuration.Value))
            {
                const string query = @"Select * From MenuInfo";

                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                try
                {
                    menuInfos = await conn.QueryAsync<MenuInfo>(query);
                }
                catch(Exception ex)
                {
                    throw ex;
                }

                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            
            return menuInfos;
        }
    }
}
