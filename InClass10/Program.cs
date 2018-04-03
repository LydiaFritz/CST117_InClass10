

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass10
{
    class Program
    {
        static void Main( string[] args )
        {
            StreamReader sr = new StreamReader( "input.in" );
            String textLine = sr.ReadToEnd( );
            int ct_lkf = 0;

            //split into words
            string[] allWords = textLine.Split( );

            foreach (string s in allWords)
            {
                //make sure word is not empty
                if (s.Length > 0)
                {
                    //strip off ending non-alphas
                    string curr = s.ToLower( );

                    while (curr.Length > 0 && !Char.IsLetter( curr[ curr.Length - 1 ] ))
                    {
                        curr = curr.Substring( 0, curr.Length - 1 );
                    }

                    //Console.WriteLine(curr);
                    if (curr.Length > 0)
                    {
                        //look at last letter
                        if (curr[ curr.Length - 1 ] == 'e' ||
                            curr[ curr.Length - 1 ] == 't')
                            ct_lkf++;
                    }
                }
            }
            Console.WriteLine( "There are " + ct_lkf + " words that end in \'e\' or \'t\'" );

        }
    }
}
