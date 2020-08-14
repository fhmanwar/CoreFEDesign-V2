using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class ChartRepo
    {
        IConfiguration _configuration;
        DynamicParameters parameters = new DynamicParameters();
        public ChartRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<PieChartVM>> getPie()
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "ChartSPPie";
                var getAll = await connection.QueryAsync<PieChartVM>(procName, commandType: CommandType.StoredProcedure);
                return getAll;
            }
        }

        public async Task<IEnumerable<LineChartVM>> getLine()
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "ChartSPLine";
                var getAll = await connection.QueryAsync<LineChartVM>(procName, commandType: CommandType.StoredProcedure);
                return getAll;
            }
        }
    }
}
