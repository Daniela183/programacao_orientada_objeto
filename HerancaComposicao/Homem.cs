using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaComposicao
{
    public class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;
        public Homem(ComportamentoAndar andar)
        {
            _comportamentoAndar = andar;
        }
        public void Locomocao()
        {
            Console.Write(nameof(Homem));
            _comportamentoAndar.Andar();
        }
    }
}
