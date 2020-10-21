using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PHP.Functions
{
    public class GenerateCSV
    {
        public static void ListViewToCSV(ListView listView, ListView totalsListView, string filePath)
        {
            // Write sales data ListView
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            // Write totals data ListView
            result.Append('\n');
            WriteCSVRow(result, totalsListView.Columns.Count, i => totalsListView.Columns[i].Width > 0, i => totalsListView.Columns[i].Text);
            
            //export data rows
            foreach (ListViewItem listItem in totalsListView.Items)
                WriteCSVRow(result, totalsListView.Columns.Count, i => totalsListView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append(String.Format("\"{0}\"", columnValue(i)));
            }
            result.AppendLine();
        }
    }
}
