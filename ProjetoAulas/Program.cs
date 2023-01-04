using System;

namespace Application
{
    public class Programa
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

           //AulaClasses();
           //AulaPropriedadeSomenteLeitura();
           //AulaHeranca();
           //Funcionario();
           AulaClassesSelada();

        }

        private static void AulaClasses()
        {
             var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
           Console.WriteLine(resultado);

           var produto = new Cadastro.Produto();
           produto.SetId(1);
           produto.Descricao = "Teclado";
           produto.ImprimirDescricao();
           Console.WriteLine(produto.GetId());
        }

         private static void AulaPropriedadeSomenteLeitura()
        {
           

           var produto = new Cadastro.Produto();
           produto.Descricao = "Mouse";
           //produto.Estoque = 1;
           Console.WriteLine(produto.Estoque);

        }

        private static void AulaHeranca()
        {
         var pessoaFisica = new Cadastro.PessoaFisica();
         pessoaFisica.Id = 1;
         pessoaFisica.Endereco = "Endereço Teste";
         pessoaFisica.Cidade = "Cidade Teste";
         pessoaFisica.Cep = "1234567";
         pessoaFisica.CPF = "12345678912";

         pessoaFisica.ImprimirDados();
         pessoaFisica.ImprimirCPF();
         
        }

         private static void Funcionario()
        {
         var funcionario = new Cadastro.Funcionario();
         funcionario.Id = 1;
         funcionario.Endereco = "Endereço Teste";
         funcionario.Cidade = "Cidade Teste";
         funcionario.Cep = "1234567";
         funcionario.CPF = "123456789124";

         funcionario.ImprimirDados();
         funcionario.ImprimirCPF();
         
        }

         private static void AulaClassesSelada()
        {
         /*var configuracao = new Cadastro.Configuracao();
         configuracao.Host = "localhost";
*/
         var configuracao = new Cadastro.Configuracao
         {
            Host = "localhost"
         };

         Console.WriteLine(configuracao.Host);
        }

    }
}