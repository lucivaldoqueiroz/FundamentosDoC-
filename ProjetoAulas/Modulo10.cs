namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

       public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

       public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(0,6));
    }

        public void AulaRange()
    {
        string nomeArquivo = "2012_12_01_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }
}