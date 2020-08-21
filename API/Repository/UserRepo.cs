using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class UserRepo
    {
        IConfiguration _configuration;
        DynamicParameters parameters = new DynamicParameters();
        public UserRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IEnumerable<ReserveVM>> getUserReserve(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "UserSPReserve";
                parameters.Add("id", id);
                var getId = await connection.QueryAsync<ReserveVM>(procName, parameters, commandType: CommandType.StoredProcedure);
                return getId;
            }
        }
    }
}
