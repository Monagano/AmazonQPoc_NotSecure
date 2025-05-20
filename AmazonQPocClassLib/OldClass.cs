using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;

namespace AmazonQPocClassLib
{
    public class OldClass
    {
        public void OldMethod()
        {
            SqlCommand cmd = new SqlCommand(); // 修正対象

            VBCodeProvider provider = new VBCodeProvider();

            VbStrConv vbsc = VbStrConv.Narrow;
            Console.WriteLine(vbsc);
        }
    }
}
