﻿using API.Repository.Interface;
using API.ViewModels;
using BC = BCrypt.Net.BCrypt;
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
    public class AccountRepo : IAccount
    {
        IConfiguration _configuration;
        DynamicParameters parameters = new DynamicParameters();
        public AccountRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int Create(AccountVM accountVM)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "AccountSPInsert";
                parameters.Add("name", accountVM.name);
                parameters.Add("uname", accountVM.Uname);
                parameters.Add("mail", accountVM.mail);
                parameters.Add("pass", BC.HashPassword(accountVM.pass));
                parameters.Add("access", accountVM.access);
                parameters.Add("addr", accountVM.addr);
                parameters.Add("phone", accountVM.phone);
                var insert = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return insert;
            }
        }

        public int Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "AccountSPDelete";
                parameters.Add("id", id);
                var Delete = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return Delete;
            }
        }

        public async Task<IEnumerable<AccountVM>> getAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "AccountSPGetAll";
                var getAll = await connection.QueryAsync<AccountVM>(procName, commandType: CommandType.StoredProcedure);
                return getAll;
            }
        }

        public AccountVM getID(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "AccountSPGetID";
                parameters.Add("id", id);
                var getId = connection.Query<AccountVM>(procName, parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();
                return getId;
            }
        }

        public int Update(AccountVM accountVM, int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var account = getID(id);
                var procName = "AccountSPEdit";
                parameters.Add("id", id);
                parameters.Add("name", accountVM.name);
                parameters.Add("uname", accountVM.Uname);
                parameters.Add("mail", accountVM.mail);
                if (accountVM.pass != null)
                {
                    parameters.Add("pass", BC.HashPassword(accountVM.pass));
                }
                else
                {
                    parameters.Add("pass", account.pass);
                }
                parameters.Add("access", accountVM.access);
                parameters.Add("addr", accountVM.addr);
                parameters.Add("phone", accountVM.phone);
                var Edit = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return Edit;
            }
        }
    }
}
