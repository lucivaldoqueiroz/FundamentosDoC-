using System;

namespace Application
{
    public class Programa
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

           //AulaClasses();
           AulaPropriedadeSomenteLeitura();

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
    }
}