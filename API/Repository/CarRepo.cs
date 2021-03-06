﻿using Dapper;
using API.Repository.Interface;
using API.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace API.Repository
{
    public class CarRepo : ICar
    {
        IConfiguration _configuration;
        DynamicParameters parameters = new DynamicParameters();
        public CarRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int Create(CarVM carVM)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "CarSPInsert";
                parameters.Add("Name", carVM.nm_car);
                parameters.Add("transmition", carVM.transmition);
                parameters.Add("year", carVM.year);
                parameters.Add("price", carVM.price);
                parameters.Add("merkID", carVM.merkID);
                var insert = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return insert;
            }
        }

        public int Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "CarSPDelete";
                parameters.Add("id", id);
                var Delete = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return Delete;
            }
        }

        public async Task<IEnumerable<CarVM>> getAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "CarSPGetAll";
                var getAll = await connection.QueryAsync<CarVM>(procName, commandType: CommandType.StoredProcedure);
                return getAll;
            }
        }

        public CarVM getID(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "CarSPGetID";
                parameters.Add("id", id);
                var getId = connection.Query<CarVM>(procName, parameters, commandType: CommandType.StoredProcedure).SingleOrDefault();
                return getId;
            }
        }

        public int Update(CarVM carVM, int id)
        {
            using (MySqlConnection connection = new MySqlConnection(_configuration.GetConnectionString("myConn")))
            {
                var procName = "CarSPEdit";
                parameters.Add("id", id);
                parameters.Add("name", carVM.nm_car);
                parameters.Add("transmition", carVM.transmition);
                parameters.Add("year", carVM.year);
                parameters.Add("price", carVM.price);
                parameters.Add("merkID", carVM.merkID);
                var Edit = connection.Execute(procName, parameters, commandType: CommandType.StoredProcedure);
                return Edit;
            }
        }

    }
}
