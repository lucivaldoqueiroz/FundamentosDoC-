//namespace Cadastro;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }

    public class Produto
    
    {
        private int Id;

        public string Descricao { get; set;}

       // public readonly int Estoque;
       public int Estoque { get; }

        public Produto()
        {
            Estoque = 1;
        }

        public void  ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id {get; set;}

        public string Endereco {get; set;}

        public string Cidade {get; set;}

        public string Cep {get; set;}

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
             Console.WriteLine("Endereço: " + Endereco);
              Console.WriteLine("Cidade: " + Cidade);
               Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;}

        public void ImprimirCPF()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula {get; set;}
    }



}