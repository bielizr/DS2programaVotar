using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automação02_CalculaDesconto
{
    public class Desconto
    {
        //Define se vai ou não ter desconto(valores >=350 têm desconto
        public bool recebeDesconto(float valor)
        {
            return (valor >= 350);
        }
    }
}
