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

            // 使用Dapper查询时，如果数据库字段采用snake_case命名法（如 user_name），但对应的实体类字段采用驼峰命名法（如UserName），
            // 查出来的字段数据无法绑定到相应的属性上，要解决此方法可以设置如下属性，参考文章如下
            //https://andrewlock.net/using-snake-case-column-names-with-dapper-and-postgresql/
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
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
                return conn.Query<BookViewModel>("SELECT * FROM public.book").AsList();
            }
        }
    }
}
