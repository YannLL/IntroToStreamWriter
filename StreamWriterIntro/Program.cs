using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //define array variable
            string[] names = new string[5]; //<== array to hold the names

            // Take 5 string inputs => store them in an array 
            Console.WriteLine("Enter 5 names to write to a .txt file:");

            for(int i=0; i<5; i++)
            {
                names[i] = Console.ReadLine();
            }

            //write array in text file

            using (StreamWriter sw = new StreamWriter(@"names.txt"))  // <== file + location in args. @ symbol indicates current dir.
            {
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine(names[i]);
                }
            }

            //sw.close();

            /*In the end you must close the text file to free it up (e.g so other users can read-write in it).
                If you don't close the file, your changes won't be saved!!!
                You can close the file by using sw.Close(); at the end of your code
                
             Or for a smoother approach, you can put your streamwriter in "using" tags as above
             "using" tags will automatically close and dispose of the streamwriter once finished*/
        }
    }
}
