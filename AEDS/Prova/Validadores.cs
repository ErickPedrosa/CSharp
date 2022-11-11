using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prova
{
    public class Validadores
    {
        public static bool ValidaURL(string url)
        {

            Regex regex = new Regex(@"(http(s)?://)?((w){3}(\.))?[a-z0-9]+(\.com)(\.br)?", RegexOptions.IgnoreCase);

            var combinou = regex.Match(url);
            var match = combinou.Value;


            if (combinou.Success && url == match)
            {
                //Console.WriteLine("url no formato válido.");
                return true;
            }
            else
            {
                //Console.WriteLine("url inválido.");
                return false;
            }
        }

        public static bool ValidaEmail(string email)
        {
            Regex regex = new Regex(@"[a-z0-9]+@[a-z]+(.com)(.br)?", RegexOptions.IgnoreCase);

            var combinou = regex.Match(email);
            if (combinou.Success)
            {
                //Console.WriteLine("email no formato válido.");
                return true;
            }
            else
            {
                //Console.WriteLine("email inválido.");
                return false;
            }

        }

    }
}
