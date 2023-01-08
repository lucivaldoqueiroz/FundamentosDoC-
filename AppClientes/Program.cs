namespace AppClientes;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Menu();
            Console.ReadKey();
        }
    }

    static void Menu()
    {
        Console.Clear();
        
        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cadastrar Cliente");
        Console.WriteLine("2 - Exibir Clientes");
        Console.WriteLine("3 - Exibir Clientes");
        Console.WriteLine("4 - Excluir Clientes");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("--------------------");
    }
}
