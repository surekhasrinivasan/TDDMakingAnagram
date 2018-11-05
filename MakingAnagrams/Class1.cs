using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    public class MakeAnagram
    {
        public static int charactersDeleted(string str1, string str2)
        {
            if(str1 == str2)
            {
                return 0;
            }
            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; j < str2.Length; j++)
                {
                    if(str1[i] != str2[j])
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
    }
}
