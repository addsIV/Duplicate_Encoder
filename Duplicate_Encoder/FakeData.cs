using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Duplicate_Encoder
{
    class FakeData
    {
        public static void BulkInsertHelper(DataTable dt, string dvname)
        {
            string connectstring = ConfigurationManager.ConnectionStrings["MainConnectionString"].ToString();
            try
            {
                using (SqlConnection _cn = new SqlConnection(connectstring))
                {
                    SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(connectstring, SqlBulkCopyOptions.UseInternalTransaction);
                    sqlbulkcopy.DestinationTableName = dvname;
                    sqlbulkcopy.WriteToServer(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string POSTinsertFakeData_Rain()
        {
            try
            {
                DataTable tmpdt = new DataTable();
                tmpdt.Columns.Add("ID", typeof(SqlGuid));
                tmpdt.Columns.Add("DEV_ID", typeof(SqlGuid));
                tmpdt.Columns.Add("TIME");
                tmpdt.Columns.Add("YEAR");
                tmpdt.Columns.Add("MONTH");
                tmpdt.Columns.Add("DAY");
                tmpdt.Columns.Add("HOUR");
                tmpdt.Columns.Add("MINUTE");
                tmpdt.Columns.Add("RAIN_PERIOD");
                tmpdt.Columns.Add("RAIN_PERIOD_HOUR");
                tmpdt.Columns.Add("RAIN_COUNT");
                tmpdt.Columns.Add("EVENT_LEVEL");
                tmpdt.Columns.Add("MESSAGE");
                tmpdt.Columns.Add("POS1");
                tmpdt.Columns.Add("POS2");
                tmpdt.Columns.Add("MILEAGE");
                tmpdt.Columns.Add("OWNER_USR_NO");
                tmpdt.Columns.Add("OWNER_GRP_NO");
                tmpdt.Columns.Add("ADD_DT");
                tmpdt.Columns.Add("MDY_USR_NO");
                tmpdt.Columns.Add("MDY_DT");
                tmpdt.Columns.Add("IP_NM");
                tmpdt.Columns.Add("CP_NM");

                DateTime startDate = new DateTime(2021, 6, 21);
                var rng = new Random();
                while (startDate < DateTime.Now)
                {
                    DataRow tmpdr = tmpdt.NewRow();
                    var qq = Guid.NewGuid();
                    tmpdr["ID"] = qq;
                    tmpdr["DEV_ID"] = new SqlGuid("472b8459-ebac-4627-983b-14883d04b483");
                    tmpdr["TIME"] = startDate;
                    tmpdr["YEAR"] = startDate.Year;
                    tmpdr["MONTH"] = startDate.Month;
                    tmpdr["DAY"] = startDate.Day;
                    tmpdr["HOUR"] = startDate.Hour;
                    tmpdr["MINUTE"] = startDate.Minute;
                    int RAIN_PERIOD = rng.Next(0, 250);
                    tmpdr["RAIN_PERIOD"] = RAIN_PERIOD;
                    int RAIN_PERIOD_HOUR = rng.Next(0, 250) * 60;
                    tmpdr["RAIN_PERIOD_HOUR"] = RAIN_PERIOD_HOUR;
                    int RAIN_COUNT = rng.Next(0, 1000);
                    tmpdr["RAIN_COUNT"] = RAIN_COUNT;
                    int EVENT_LEVEL = rng.Next(0, 5);
                    tmpdr["EVENT_LEVEL"] = EVENT_LEVEL;
                    string temp = string.Format("{0}日{1}時{2}分，時段降雨量{3}公厘，累積降雨量{4}公厘，豪雨級數{5}", startDate.Day, startDate.Hour, startDate.Minute, RAIN_PERIOD, RAIN_COUNT, EVENT_LEVEL);
                    tmpdr["MESSAGE"] = temp;
                    tmpdr["POS1"] = "E";
                    tmpdr["POS2"] = "1K+890";
                    tmpdt.Rows.Add(tmpdr);

                    startDate = startDate.AddMinutes(1);
                }

                BulkInsertHelper(tmpdt, "RAIN_DATA");

                return "done!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string POSTinsertFakeData_Wind()
        {
            try
            {
                DataTable tmpdt = new DataTable();
                tmpdt.Columns.Add("ID", typeof(SqlGuid));
                tmpdt.Columns.Add("DEV_ID", typeof(SqlGuid));
                tmpdt.Columns.Add("TIME");
                tmpdt.Columns.Add("YEAR");
                tmpdt.Columns.Add("MONTH");
                tmpdt.Columns.Add("DAY");
                tmpdt.Columns.Add("HOUR");
                tmpdt.Columns.Add("MINUTE");
                tmpdt.Columns.Add("VISIBLE");
                tmpdt.Columns.Add("WINDDIRECTION_AVR");
                tmpdt.Columns.Add("WINDSPEED_INS");
                tmpdt.Columns.Add("WINDDIRECTION_INS");
                tmpdt.Columns.Add("EVENT_LEVEL");
                tmpdt.Columns.Add("MESSAGE");
                tmpdt.Columns.Add("POS1");
                tmpdt.Columns.Add("POS2");
                tmpdt.Columns.Add("MILEAGE");
                tmpdt.Columns.Add("OWNER_USR_NO");
                tmpdt.Columns.Add("OWNER_GRP_NO");
                tmpdt.Columns.Add("ADD_DT");
                tmpdt.Columns.Add("MDY_USR_NO");
                tmpdt.Columns.Add("MDY_DT");
                tmpdt.Columns.Add("IP_NM");
                tmpdt.Columns.Add("CP_NM");

                string[] direction = new string[] { "東", "南", "西", "北", "東北", "東南", "西北", "西南", "北北東", "東北東", "東南東", "南南東", "南南西", "西南西", "西北西", "北北西" };

                DateTime startDate = new DateTime(2021, 6, 19);
                var rng = new Random();
                while (startDate < DateTime.Now)
                {
                    DataRow tmpdr = tmpdt.NewRow();
                    var qq = Guid.NewGuid();
                    tmpdr["ID"] = qq;
                    tmpdr["DEV_ID"] = new SqlGuid("A79251CC-9BC2-47CE-BB40-57D9A388AC30");
                    tmpdr["TIME"] = startDate;
                    tmpdr["YEAR"] = startDate.Year;
                    tmpdr["MONTH"] = startDate.Month;
                    tmpdr["DAY"] = startDate.Day;
                    tmpdr["HOUR"] = startDate.Hour;
                    tmpdr["MINUTE"] = startDate.Minute;
                    int WINDSPEED_AVR = rng.Next(0, 10);
                    tmpdr["WINDSPEED_AVR"] = WINDSPEED_AVR;
                    int dice = rng.Next(0, 15);
                    tmpdr["WINDDIRECTION_AVR"] = direction[dice];
                    int WINDSPEED_INS = rng.Next(0, 10);
                    tmpdr["WINDSPEED_INS"] = WINDSPEED_INS;
                    dice = rng.Next(0, 15);
                    tmpdr["WINDDIRECTION_INS"] = direction[dice];
                    int EVENT_LEVEL = rng.Next(0, 5);
                    tmpdr["EVENT_LEVEL"] = EVENT_LEVEL;
                    string temp = string.Format("{0}日{1}時{2}分，平均風速{3}公尺/秒，平均風向{4}，最大瞬間風速{5}公尺 / 秒，最大瞬間風向{6}，風力級數{7}", startDate.Day, startDate.Hour, startDate.Minute, WINDSPEED_AVR, tmpdr["WINDDIRECTION_AVR"], WINDSPEED_INS, tmpdr["WINDDIRECTION_INS"], EVENT_LEVEL);
                    tmpdr["MESSAGE"] = temp;
                    tmpdr["POS1"] = "E";
                    tmpdr["POS2"] = "1K+890";
                    tmpdt.Rows.Add(tmpdr);

                    startDate = startDate.AddMinutes(1);
                }

                BulkInsertHelper(tmpdt, "WIND_DATA");

                return "done!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string POSTinsertFakeData_Visible()
        {
            try
            {
                DataTable tmpdt = new DataTable();
                tmpdt.Columns.Add("ID", typeof(SqlGuid));
                tmpdt.Columns.Add("DEV_ID", typeof(SqlGuid));
                tmpdt.Columns.Add("TIME");
                tmpdt.Columns.Add("YEAR");
                tmpdt.Columns.Add("MONTH");
                tmpdt.Columns.Add("DAY");
                tmpdt.Columns.Add("HOUR");
                tmpdt.Columns.Add("MINUTE");
                tmpdt.Columns.Add("VISIBLE");
                tmpdt.Columns.Add("EVENT_LEVEL");
                tmpdt.Columns.Add("MESSAGE");
                tmpdt.Columns.Add("POS1");
                tmpdt.Columns.Add("POS2");
                tmpdt.Columns.Add("MILEAGE");
                tmpdt.Columns.Add("OWNER_USR_NO");
                tmpdt.Columns.Add("OWNER_GRP_NO");
                tmpdt.Columns.Add("ADD_DT");
                tmpdt.Columns.Add("MDY_USR_NO");
                tmpdt.Columns.Add("MDY_DT");
                tmpdt.Columns.Add("IP_NM");

                DateTime startDate = new DateTime(2021, 8, 26);
                var rng = new Random();
                while (startDate < DateTime.Now)
                {
                    DataRow tmpdr = tmpdt.NewRow();
                    var qq = Guid.NewGuid();
                    tmpdr["ID"] = qq;
                    tmpdr["DEV_ID"] = new SqlGuid("472b8459-ebac-4627-983b-14883d04b483");
                    tmpdr["TIME"] = startDate;
                    tmpdr["YEAR"] = startDate.Year;
                    tmpdr["MONTH"] = startDate.Month;
                    tmpdr["DAY"] = startDate.Day;
                    tmpdr["HOUR"] = startDate.Hour;
                    tmpdr["MINUTE"] = startDate.Minute;
                    int VISIBLE = rng.Next(0, 1000);
                    tmpdr["VISIBLE"] = VISIBLE;
                    int EVENT_LEVEL = rng.Next(0, 5);
                    tmpdr["EVENT_LEVEL"] = EVENT_LEVEL;
                    string temp = string.Format("{0}日{1}時{2}分，能見距離{3}公尺，濃霧級數{4}", startDate.Day, startDate.Hour, startDate.Minute, VISIBLE, EVENT_LEVEL);
                    tmpdr["MESSAGE"] = temp;
                    tmpdr["POS1"] = "W";
                    tmpdr["POS2"] = "3K+695";
                    tmpdt.Rows.Add(tmpdr);

                    startDate = startDate.AddMinutes(1);
                }

                BulkInsertHelper(tmpdt, "VISIBLE_DATA");

                return "done!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
