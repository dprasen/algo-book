using System;

namespace AlgoBook
{
    public static class BinaryGap
    {

        public static int GetBinaryGap(int number)
        {
            string bin = Convert.ToString(number, 2);
            int bg    = 0;
            int maxBg = 0 ;
          
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                { 
                    if (bg > maxBg)
                    {
                        maxBg = bg;
                    }
                    bg = 0;

                }
               else
               {
                  bg++;
                }
            
            }

            return maxBg;
		
        }
    }
}