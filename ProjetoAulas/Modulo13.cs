namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID...: "+ Random.Shared.Next(1,100));
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("-----------------");
        escrever.Close();
    }
}