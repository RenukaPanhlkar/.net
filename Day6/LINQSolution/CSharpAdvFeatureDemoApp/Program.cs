using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvFeatureDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# 3.0 : 
            // annonymous Type
            // partial Class
            // extension method
            // LinQ

            //Annonymous Type
            // ti is a dynamic type

            var instance = new { FirstName="Ravi",
                                 LastName="Tambade",
                                 Age=47,
                                 Email="ravi.tambade@transflower.in",
                                 ContactNumber="9881735801",
                                 CompanyOwner=true
            };

            Console.WriteLine(instance.FirstName + " "+ instance.LastName + " Owner="+ instance.CompanyOwner);
            Console.ReadLine();


        }
    }
}
