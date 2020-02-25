using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojao2000
{
    class conexao
    {
        public static string conector()
        {
            return
          @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Silvio Florentino\source\repos\lojao2000\lojao2000\dblojao2000.mdf;Integrated Security=True";
        }
    }
}
