using Dapper;
using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Duplicate_Encoder
{
    public class DataSyncJob : IJob
    {
        private SqlConnection _conn = new SqlConnection(@"Data Source=.\sqlserver2017;Initial Catalog=KMBDB;Persist Security Info=True;User ID=sa;Password=kl314275;Timeout=200");
        void IJob.Execute()
        {
            List<dynamic> dt = this._conn.Query(@"select *  FROM [VD_ONE_DATA_BUF]").ToList();

            Console.WriteLine($"This is DataSyncService submmit...:There are {dt.Count} rows in VD_ONE_DATA_BUF");
        }
    }
}
