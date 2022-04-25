using System;

namespace EncontroRemoto
{
   class Program
   {
       static void Main(string[] args)
       {

          Endereco end = new Endereco();

           end.logradouro = "avenida antonio";
           end.numero = 3398;
           end.complemento = "casa 100";
           end.enderecoComercial = false;

            PessoaFisica novapf = new PessoaFisica();

            novapf.endereco = end;
            novapf.cpf = "01202532687";
            novapf.dataNascimento = new DateTime(1994, 09, 22);
            novapf.nome = "Vinicius Fernandes dos Santos";

            PessoaFisica pf = new PessoaFisica();
            pf.ValidarDataNascimento(pf.dataNascimento);

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if (idadeValida == true)
            {
                Console.WriteLine($"Cadastro Aprovado");
            }
            else
            {
                Console.WriteLine($"Cadastro Não Aprovado");
            }

            //Console.WriteLine(pf.ValidarDataNascimento(novapf.dataNascimento));
            //Console.WriteLine("Rua: " + novapf.endereco.logradouro + ", " + novapf.endereco.numero);
       }
   }
}