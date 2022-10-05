using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.EstudoPiloto
{
    internal class Piloto
    {
        //Proprieadade automática
        //Encapsulamento
        //set get
        // Propriedade é privada
        //get e set é público
        //Encapsulamento

        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        //void - retorno vazio (procedimento - lógica de programação)

        public String GerarNomeCompletoMaiusculo ()
        {
            return $"{Nome} {Sobrenome}".ToUpper();
        }
        public string GerarNomeCompletoMinusculo()
        {
            return $"{Nome}{Sobrenome}".ToLower();
        }
    }
}
