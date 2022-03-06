using System;
using System.Collections;
using System.Text;

namespace MorseCode
{
    class Program
    {
        // Morse code translation
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name0 = Console.ReadLine().ToUpper();
            string nameMorse0 = "";

            foreach (char letter0 in name0)
            {
                nameMorse0 += Convert.ToString(tableMorse[letter0]);
            }
            Console.WriteLine("Your name in Morse: {0}", nameMorse0);
            Console.ReadLine();
        }

        static Hashtable tableMorse = new Hashtable()
    { {'A',".-"   },
      {'B',"-..." },
      {'C',"-.-." },
      {'D',"-.."  },
      {'E', "."   },
      {'F',"..-." },
      {'G',"--."  },
      {'H',"...." },
      {'I',".."   },
      {'J',".---" },
      {'K',"-.-"  },
      {'L',".-.." },
      {'M',"--"   },
      {'N',"-."   },
      {'O',"---"  },
      {'P',".--." },
      {'Q',"--.-" },
      {'R', ".-." },
      {'S', "..." },
      {'T',"-"    },
      {'U',"..-"  },
      {'V',"...-" },
      {'W',".--"  },
      {'X',"-..-" },
      {'Y',"-.--" },
      {'Z',"--.." },
      {'0',"-----"},
      {'1',".----"},
      {'2',"..---"},
      {'3',"...--"},
      {'4',"....-"},
      {'5',"....."},
      {'6',"-...."},
      {'7',"--..."},
      {'8',"---.."},
      {'9',"----."}
    };
    }
}