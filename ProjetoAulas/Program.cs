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
           //AulaClassesSelada();
           //AulaClasseAbstrata();
           //AulaRecord();
           AulaInterface();

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

        private static void AulaClasseAbstrata()
    {
        var cachorro = new Cadastro.Cachorro();
        cachorro.Nome = "Dog";
        cachorro.ImprimirDados();
    }

    private static void AulaRecord()
    {
      //var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
      // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

      //var curso1 = new Cadastro.Curso (1, "Curso");
      //var curso2 = new Cadastro.Curso (1, "Curso");

      var curso1 = new Cadastro.Curso (1, "Curso");
      var curso2 = curso1 with { Descricao = "Teste Novo" };

      //var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
      //var curso2 = curso1;
      //curso2.Descricao = "Teste Teste";
      //var curso2 = new Cadastro.CursoTeste();
      //curso2.Id = curso1.Id;
      //curso2.Descricao = "dESCRICAO";

      Console.WriteLine(curso1.Descricao);
      Console.WriteLine(curso2.Descricao);
        // Console.WriteLine(curso1.Equals (curso2));
       //Console.WriteLine(curso1 == curso2);
    }

    private static void AulaInterface(){
      var notificacaoCliente = new Cadastro.NotificacaoCliente();
      notificacaoCliente.Notificar();
      notificacaoCliente.NotificarOutros();

      Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
      notificacao.Notificar();   
    }

    }
}