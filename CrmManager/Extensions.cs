using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;

namespace CrmManager
{
    public static class Extensions
    {

        public static DataTable ToDataTable(this EntityCollection entityCollection, List<Tuple<string, AttributeTypeCode?>> fields)
        {
            DataTable dTable = new DataTable();
            int iElement = 0;

            if (entityCollection.Entities.Count == 0)
            {
                return new DataTable();
            }

            //Defining the ColumnName for the datatable
            for (iElement = 0; iElement <= fields.Count - 1; iElement++)
            {
                string columnName = fields.ElementAt(iElement).Item1;
                dTable.Columns.Add(columnName);
            }

            foreach (Entity entity in entityCollection.Entities)
            {
                DataRow dRow = dTable.NewRow();
                for (int i = 0; i <= entity.Attributes.Count - 1; i++)
                {
                    string colName = entity.Attributes.Keys.ElementAt(i);
                    dRow[colName] = entity.Attributes.Values.ElementAt(i);
                }
                dTable.Rows.Add(dRow);
            }
            return dTable;
        }

        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            if (data.Count == 0)
            {
                return new DataTable();
            }

            DataTable dataTable = new DataTable();

            //Defining the ColumnName for the datatable
            var properties = typeof(T).GetProperties().ToList();

            properties.ForEach(m =>
            {
                dataTable.Columns.Add(m.Name);
            });

            foreach (var record in data)
            {
                DataRow dataRow = dataTable.NewRow();

                properties.ForEach(m =>
                {
                    dataRow[m.Name] = m.GetValue(record);
                });

                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        public static string SplitterByUnderscore(this string strToSplit)
        {
            if (string.IsNullOrEmpty(strToSplit)) return strToSplit;

            var res = CleanByChar(strToSplit, '_');

            res = CleanByChar(res, ' ');

            return res;
        }

        public static string GetDotnetType(this AttributeTypeCode? attributeTypeCode)
        {
            switch (attributeTypeCode)
            {
                case AttributeTypeCode.BigInt:
                    return "long";
                case AttributeTypeCode.Boolean:
                    return "bool";
                case AttributeTypeCode.DateTime:
                    return "DateTime";
                case AttributeTypeCode.Decimal:
                    return "decimal";
                case AttributeTypeCode.Double:
                    return "double";
                case AttributeTypeCode.Integer:
                    return "int";
                case AttributeTypeCode.Lookup:
                    return "Guid";
                case AttributeTypeCode.Money:
                    return "decimal";
                case AttributeTypeCode.State:
                    return "int";
                case AttributeTypeCode.Status:
                    return "int";
                case AttributeTypeCode.String:
                    return "string";
                case AttributeTypeCode.Uniqueidentifier:
                    return "Guid";
                default:
                    return "string";
            }
        }

        private static string CleanByChar(string strToSplit, char character)
        {
            var res = string.Empty;

            var spl = strToSplit.Split(character);

            foreach (var str in spl)
            {
                if (!string.IsNullOrEmpty(str))
                    res += str.Length > 1 ? str[0].ToString().ToUpper() + str.Substring(1) : str;
            }
            return res;
        }
    }
}
