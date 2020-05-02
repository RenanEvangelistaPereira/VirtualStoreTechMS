using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.techms.Gateway
{
    public class ChavesIntegracoes
    {
        private String _chave;

        public string Chave
        {
            get => _chave;
            set
            {
                if (String.IsNullOrEmpty(value) || )
                {
                    _chave = value;
                }
                else
                {
                    throw new ArgumentException("Valor fornecido é inválido");
                }
            }
        }
    }
}
