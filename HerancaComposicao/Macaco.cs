using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaComposicao
{
    public class Macaco : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;

        public Macaco(ComportamentoAndar comportamentoAndar)
        {
            _comportamentoAndar = comportamentoAndar;
        }

        public void Locomocao()
        {
            Console.Write(nameof( Macaco));
            _comportamentoAndar.Andar();
        }
    }
}
