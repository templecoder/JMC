using System;
using System.Collections.Generic;
using System.Text;

namespace JamminsApp
{
    public static class JamminsAppExtensions
    {
        public static string PrintKGBAsciiArt()
        {
            return @" _   _______ ______                            _      ______ _____ _   _______ ___________ 
| | / /  __ \| ___ \                          | |     |  ___|_   _| \ | |  _  \  ___| ___ \
| |/ /| |  \/| |_/ /     __ _  __ _  ___ _ __ | |_    | |_    | | |  \| | | | | |__ | |_/ /
|    \| | __ | ___ \    / _` |/ _` |/ _ \ '_ \| __|   |  _|   | | | . ` | | | |  __||    / 
| |\  \ |_\ \| |_/ /   | (_| | (_| |  __/ | | | |_    | |    _| |_| |\  | |/ /| |___| |\ \ 
\_| \_/\____/\____/     \__,_|\__, |\___|_| |_|\__|   \_|    \___/\_| \_/___/ \____/\_| \_|
                               __/ |                                                       
                              |___/                                                        ";
        }

        public static string PrintOrangeJuiceCatalogArt()
        {
            return @" _   _                              _____                 _       _                           ______ 
| | | |                            |  _  |               (_)     (_)                         _|  _  \
| |_| | __ _ _ __  _ __  _   _     | | | |_ __ __ _ _ __  _ _   _ _  ___ ___ _ __ _   _     (_) | | |
|  _  |/ _` | '_ \| '_ \| | | |    | | | | '__/ _` | '_ \| | | | | |/ __/ _ \ '__| | | |      | | | |
| | | | (_| | |_) | |_) | |_| |    \ \_/ / | | (_| | | | | | |_| | | (_|  __/ |  | |_| |     _| |/ / 
\_| |_/\__,_| .__/| .__/ \__, |     \___/|_|  \__,_|_| |_| |\__,_|_|\___\___|_|   \__, |    (_)___/  
            | |   | |     __/ |                         _/ |                       __/ |             
            |_|   |_|    |___/                         |__/                       |___/              ";

        }

        public static void PrintEmptyLines(int amountOfLines)
        {
            for (int i = 0; i < amountOfLines; i++)
            {
                Console.WriteLine();
            }
        }
    }
}

