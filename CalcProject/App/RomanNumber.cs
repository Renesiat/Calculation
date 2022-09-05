using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.App
{
    public class RomanNumber
    {
        public static int Parse(String s)
        {
            char[] d = { 'I','V','X','L','C','D'};
            int[] v = { 1, 5, 10, 50, 100, 500, 1000 };
            int pos = 1;
            int ind=Array.IndexOf(d, s[pos]);
            if(ind==-1)
            {
                throw new ArgumentException($"Invalid digit'{s[pos]}'");
            }
            int res = v[ind];
            ind = Array.IndexOf(d, s[pos - 1]);
            if(ind==-1)
            {
                throw new ArgumentException("in");
            }
            if (v[ind] < res) res -= v[ind];
            else res += v[ind];
            
           
            return res;
        }
        
    }
}
