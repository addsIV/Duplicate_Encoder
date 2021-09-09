using Dapper;
using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
namespace Duplicate_Encoder
{
    public class TestJob : IJob
    {
        private SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MainConnectionString"].ToString());

        void IJob.Execute()
        {
            List<dynamic> dt = this._conn.Query(@"select *  FROM [VISIBLE_DATA]").ToList();

            Console.WriteLine($"This is TestService submmit...:There are {dt.Count} rows in VISIBLE_DATA");
        }
    }
}
