using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
static void Main(string[] args)
 {
string s = Console.ReadLine();
int A = 0;
int C = 0;
int G  = 0;
int T = 0;


foreach(char c in s)
{ 
   if(c == 'A')
   {
    A++;
   }
  else if(c == 'C')
    {
     C++;
    }
  else if(c == 'G')
    {
      G++;
     }
   else if(c == 'T')
     {
       T++;
     }
}
Console.WriteLine(A + " " + C + " " + G + " " + T);

}
}
