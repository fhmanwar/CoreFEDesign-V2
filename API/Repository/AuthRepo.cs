using BC = BCrypt.Net.BCrypt;
using API.ViewModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace API.Repository
{
    public class AuthRepo
    {
        IConfiguration _configuration;
        DynamicParameters parameters = new DynamicParameters();
        public AuthRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int Register(AccountVM accountVM)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "AuthSPRegis";
                parameters.Add("name", accountVM.name);
                parameters.Add("uname", accountVM.Uname);
                parameters.Add("mail", accountVM.mail);
                parameters.Add("pass", BC.HashPassword(accountVM.pass));
                var insert = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return insert;
            }
        }

        public AccountVM Login(string uname)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "AuthSPLogin";
                parameters.Add("uname", uname);
                var getId = connection.Query<AccountVM>(procName, parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();
                return getId;
            }
        }
    }
}
