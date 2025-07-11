using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_PTTK.Utils
{
    public static class DataTableUtils
    {
        public static List<T> ToList<T>(this DataTable table) where T : new()
        {
            List<T> list = [];
            foreach (DataRow row in table.Rows)
            {
                T obj = new T();
                foreach (PropertyInfo prop in typeof(T).GetProperties())
                {
                    if (table.Columns.Contains(prop.Name) && row[prop.Name] != DBNull.Value)
                    {
                        prop.SetValue(obj, Convert.ChangeType(row[prop.Name], prop.PropertyType));
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
