using System;

namespace EncontroRemoto
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }
        
            public override void PagarImposto(float salario){
            }
    }
}