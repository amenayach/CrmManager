using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmManager;
using CrmManager.Crm;

namespace CrmManager.Controls
{
    public partial class QueryUC : UserControl
    {

        public Manager Manager { get; set; }

        public QueryUC()
        {
            InitializeComponent();
        }

        public void Exec()
        {
            if (Manager != null && tbQuery.Text.NotEmpty())
            {

                var data = Manager.GetEntity(tbQuery.Text.NullTrimer());

                if (data?.Entities != null && data.Entities.Count > 0)
                {
                    Fill(data.ToDataTable(Manager.GetEntityFields(tbQuery.Text.NullTrimer())));
                }

            }
        }

        public void SetQuery(string initQuery)
        {
            tbQuery.Text = initQuery;
        }

        public void ExecFields()
        {
            Fill(Manager.GetCrmEntityFields(tbQuery.Text.NullTrimer()));
        }

        private void Fill<T>(IList<T> data)
        {
            grd.DataSource = data.ToDataTable();
            if (grd.ColumnCount > 0)
            {
                foreach (DataGridViewColumn grdColumn in grd.Columns)
                {
                    grdColumn.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private void Fill(object data)
        {
            grd.DataSource = data;
            if (grd.ColumnCount > 0)
            {
                foreach (DataGridViewColumn grdColumn in grd.Columns)
                {
                    grdColumn.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }
    }
}
