# Using Microsoft Visual Studio Connection Dialog at runtime

In Visual Studio when a developer wants to create strong typed classes for database tables either for the conventional TableAdapter or Entity Framework there is a place in the process where a dialog is displayed as shown below. I will show you how to do this at runtime and a bit more.

![Figure 1](assets/Figure1.jpg)

This code sample will show you the basics of using this dialog by working with the source code. In the next screenshot I have modified the source code so that any time SQL-Server data provider is used and it's my login I get a context menu item that allows me to auto fill the Server Name.

![Figure 2](assets/Figure2.jpg)

That is cool but we will now take advantage of this dialog so that (in this code sample) can create a SQL SELECT statement or create a CSV file for a table.

To demonstrate this I created a simple windows forms project with the following interface to select a server, select a table, select columns. After making these selections pressing "Generate SQL SELECT" you get the following in the second image below.

![Figure 3](assets/Figure3.jpg)

Pressing "Export CSV" takes the SQL SELECT statement and passes it off to a process which uses SQLCMD.EXE. My Exporter class takes information obtained from the Connection Dialog and selections done in the form to create a CSV file.

```csharp
using System; 
using System.Diagnostics; 
using System.Linq; 
 
namespace WindowsFormsApplication1_cs 
{ 
    public class Exporter 
    { 
        public void ToCsv(string ServerName, string DatabaseName, string SelectStatement, string FileName) 
        { 
            string DoubleQuote = ((char)(34)).ToString(); 
            string QueryToExceute = DoubleQuote + SelectStatement + DoubleQuote; 
            string ExportFileName = DoubleQuote + FileName + DoubleQuote; 
 
            var Process = new Process(); 
             
            Process.StartInfo.UseShellExecute = false; 
            Process.StartInfo.RedirectStandardOutput = true; 
            Process.StartInfo.RedirectStandardError = true; 
            Process.StartInfo.CreateNoWindow = true; 
            Process.StartInfo.FileName = "SQLCMD.EXE"; 
            Process.StartInfo.Arguments = "-S " + ServerName + " -d " + DatabaseName + " -E -Q " +  
                QueryToExceute + " -o " + ExportFileName + "  -h-1 -s\",\" -w 700"; 
            Console.WriteLine($"SQLCMD.EXE {Process.StartInfo.Arguments}"); 
            Process.Start(); 
            Process.WaitForExit(); 
 
            if (System.IO.File.Exists(FileName)) 
            { 
                var contents = System.IO.File.ReadAllLines(FileName) 
                    .Where(line => !line.ToLower().Contains("rows affected") && !string.IsNullOrWhiteSpace(line)).ToArray(); 
                System.IO.File.WriteAllLines(FileName, contents); 
            } 
        } 
    } 
} 
```
The command for SQLCMD in this case is
SQLCMD.EXE -S KARENS-PC -d NorthWindAzure -E -Q "SELECT [ProductID],[ProductName],[UnitsInStock] FROM Products" -o "C:\Data\test.csv"  -h-1 -s"," -w 700
Partial contents of the file generate

![Figure 5](assets/Figure5.jpg)

## How to use in your project
Looking at the Visual Studio solution, the highlighted in yellow get compiled. Unload the projects in grey.
Open your Visual Studio solution, add a reference to the DLL created in the solution above and now you can use them.
The project WindowsFormsApplication1_cs shows how to use the dialog and also how to do exporting.

![Figure 6](assets/Figure66.jpg)

## IMPORTANT
Things to watch out for concerning SQLCMD.EXE, if you attempt to create a export file and get error messages the common reason is that there is an authenication issue which you need to figure out the login and security which is outside the scope of this code sample.

Note in Operations class, GetConnection that the optional parameter SaveConfiguration is false, setting it to true will create a xml file names DataConnections.xml which save the last data provider used and will be the default each time until you change it.

![Figure 7](assets/Figure7.jpg)

The two things the connection dialog is good for is when writing code in development and also for when a user at runtime needs to select an alternate server. Needless to say there are many possibilities here.

## Copyrights
As I did not create the classes for the Connection Dialog they are copyrighted to Microsoft as each class has a copyright notice within.

