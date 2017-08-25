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


    }
}
