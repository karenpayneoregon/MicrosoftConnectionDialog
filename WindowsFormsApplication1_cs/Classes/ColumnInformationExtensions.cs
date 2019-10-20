using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApplication1_cs.Classes
{
    public static class ColumnInformationExtensions
    {
        public static string SelectStatement(this List<ColumnInformation> sender, string tableName)
        {
            if (sender.Count == 0)
            {
                return $"SELECT * FROM {tableName}";
            }
            else
            {
                return "SELECT " + string.Join(",", sender.Select(col => $"[{col.Name}]").ToArray()) + $" FROM {tableName}";
            }
        }
    }
}

