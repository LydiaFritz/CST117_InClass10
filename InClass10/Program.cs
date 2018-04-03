

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

            
            string[] allWords = textLine.Split( );

            foreach (string s in allWords)
            {
               
                if (s.Length > 0)
                {
                   
                    string curr = s.ToLower( );

                    while (curr.Length > 0 && !Char.IsLetter( curr[ curr.Length - 1 ] ))
                    {
                        curr = curr.Substring( 0, curr.Length - 1 );
                    }

                    
                    if (curr.Length > 0)
                    {                        
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
