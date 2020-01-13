using dndb.Cards.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dndb.Cards.FullFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {

            

            var resizer = new ImageMod();
            resizer.StretchCharCard(@"C:\dev\dotnet\dndb.Cards\dndb.Cards\bin\Debug\netcoreapp3.1\downloads\sampleCampaign\Gurandor.png");
            Console.ReadKey(); ;
        }
    }
}
