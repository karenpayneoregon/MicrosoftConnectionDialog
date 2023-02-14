using System;
using System.Diagnostics;
using System.Linq;

namespace WindowsFormsApplication1_cs.Classes
{
    public class Exporter
    {
        public void ToCsv(string serverName, string databaseName, string selectStatement, string fileName)
        {
            var doubleQuote = ((char)(34)).ToString();
            var queryToExceute = doubleQuote + selectStatement + doubleQuote;
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
                                queryToExceute + " -o " + exportFileName + "  -h-1 -s\",\" -w 700"
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
