using Newtonsoft.Json;
using System.Data;

namespace MtgCustomDecksBuilder.Server.Tools
{
    public static class DataConversion
    {
        public static string SerializeJsonListFromDataTable(DataTable dt)
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dt.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    if(!col.ColumnName.ToLower().Contains("pwd") && !col.ColumnName.ToLower().Contains("password"))
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }

            return JsonConvert.SerializeObject(rows);
        }

        public static string SerializeJsonObjectFromDataTable(DataTable dt)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();

            if (dt.Rows?.Count > 0)
            {
                DataRow dr = dt.Rows[0] as DataRow;

                foreach (DataColumn col in dt.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
            }

            return JsonConvert.SerializeObject(row);
        }
    }
}
