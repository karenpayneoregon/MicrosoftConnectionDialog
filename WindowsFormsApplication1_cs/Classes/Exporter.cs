using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace WindowsFormsApplication1_cs.Classes
{
    public class Exporter
    {
        public string DataTableToJson(DataTable table) => JsonConvert.SerializeObject(table);

        public void ToJson(string serverName, string databaseName, string selectStatement, string fileName)
        {
            var doubleQuote = ((char)(34)).ToString();
            var queryToExecute = doubleQuote + selectStatement + doubleQuote;
            var exportFileName = doubleQuote + fileName + doubleQuote;

            DataTable table = new DataTable();

            using (var cn = new SqlConnection() {ConnectionString = ""})
            {
                using (var cmd = new SqlCommand() {Connection = cn, CommandText = ""})
                {
                    cn.Open();
                    table.Load(cmd.ExecuteReader());
                    var json = DataTableToJson(table);
                    File.WriteAllText(fileName,json );
                }
            }
        }

        public void ToCsv(string serverName, string databaseName, string selectStatement, string fileName)
        {
            var doubleQuote = ((char)(34)).ToString();
            var queryToExecute = doubleQuote + selectStatement + doubleQuote;
            var exportFileName = doubleQuote + fileName + doubleQuote;

            var process = new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    FileName = "SQLCMD.EXE",
                    Arguments = "-S " + serverName + " -d " + databaseName + " -E -Q " +
                                queryToExecute + " -o " + exportFileName + "  -h-1 -s\",\" -w 700"
                }
            };

            if (Debugger.IsAttached)
            {
                Console.WriteLine($"SQLCMD.EXE {process.StartInfo.Arguments}");
            }
            

            process.Start();
            process.WaitForExit();

            if (System.IO.File.Exists(fileName))
            {
                var contents = System.IO.File.ReadAllLines(fileName)
                    .Where(line => !line.ToLower().Contains("rows affected") && !string.IsNullOrWhiteSpace(line)).ToArray();

                System.IO.File.WriteAllLines(fileName, contents);
            }
        }
    }
}
