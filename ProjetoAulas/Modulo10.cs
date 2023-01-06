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
        Console.WriteLine(linha.Substring(0, 6));
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

    public void AulaContains()
    {
        string nomeArquivo = "2012_12_01_backup.bak";
        if (nomeArquivo.Contains("backup_teste"))
        {
            Console.WriteLine("Palavra Encontrada");
        }
        else
        {
            Console.WriteLine("Palavra não encontrada");
        }
        //Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));
    }

    public void AulaTrim()
    {
        string teste = "**Lucivaldo Queiroz**";

        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));

    }

    public void AulaStartWithEndsWith()
    {
        string teste = "Curso cSharp";

        Console.WriteLine("INICIO: " + teste.StartsWith("Curso"));
        Console.WriteLine("FINAL: " + teste.EndsWith("Csharp02"));

    }


}