/* Write a program that enters file name along with its full file 
 * path (e.g. C:\WINDOWS\win.ini), reads its contents and prints 
 * it on the console. Find in MSDN how to use 
 * System.IO.File.ReadAllText(…). Be sure to catch all possible 
 * exceptions and print user-friendly error messages.
 * */

using System;
using System.IO;
using System.Security;
using System.Text;

namespace FileReadOnConsole
{
    class FileReadOnConsole
    {
        public static string Path()
        {
            string path = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(path));
            return path;
        }

        static void Main()
        {
            try
            {
                Path();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("You've entered only a "+
                    "directory. Try with a specific file");
                Path();
            }
            catch (System.IO.DriveNotFoundException)
            {
                Console.WriteLine("Please check if this"+
                    " is the right directory");
                Path();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("System returns no result."+
                    " Please, make sure what is the exact"+
                    " file name");
                Path();
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Please, reenter directory");
                Path();
            }
            catch (IOException)
            {
                Console.WriteLine("System reached the file. "+
                    "There is a problem while opening it." + 
                    "Please, reffer to User's manual.");
                Path();
            }
            catch (SecurityException)
            {
                Console.WriteLine("You have permissions to "+
                    "open other files. Please contact your" +
                    "system administrator for more information.");
                Path();
            }
        }
    }
}
