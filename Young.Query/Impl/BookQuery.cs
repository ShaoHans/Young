using DapperExtensions;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Young.Application.ViewModels;

namespace Young.Application.Impl
{
    public class BookQuery : IBookQuery
    {
        private readonly string _connString;

        public BookQuery(string connString)
        {
            _connString = connString;
        }

        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(_connString);
        }

        public List<BookViewModel> GetAll()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                return conn.Query<BookViewModel>("SELECT * FROM public.\"Book\"").AsList();
            }
        }
    }
}
