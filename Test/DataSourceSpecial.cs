using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Test
{
    public class DataSourceSpecial
    {
        public static DataTable CreateSource(DataGridView productTable, Dictionary<string, string> scrapeData)
        {
            var table = new DataTable();
            table.Columns.Add("DrawNo", typeof(int));
            if (productTable.Rows.Count <= 1)
            {
                var count = productTable.RowCount;
                table.Columns.Add("Results_0", typeof(string));

                if (count != 0)
                {
                    count = count - 1;
                }
                ++count;
                foreach (var item in scrapeData)
                {
                    var row = table.NewRow();
                    row["DrawNo"] = item.Key;
                    row["Results_0"] = item.Value;
                    table.Rows.Add(row);
                }
                return table;
            }
            else
            {
                var columnCount = productTable.Rows[0].Cells.Count - 1;
                productTable.Columns.Add("Results_" + columnCount, "Results_" + columnCount);
                var drawNoList = productTable.Rows.Count-1;
                var addColumnNo = productTable.Rows[0].Cells.Count;
                for (var i = 0; i < drawNoList; i++)
                {
                    productTable.Rows[i].Cells[addColumnNo - 1].Value = "test";
                    //var result = scrapeData[drawNo];
                }
                return (DataTable)(productTable.DataSource); ;
            }

        }

    }
}
