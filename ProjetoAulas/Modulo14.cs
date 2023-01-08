namespace Modulo14;

public class TrabalhandoComLinq
{

public void AulaWhere()
{
 /*   string nomeCompleto = "Rafael Almeida";

    Func<char, bool> filtro = c => c == 'A';
    //var resultado = nomeCompleto.Where(filtro);
    //var resultado = nomeCompleto.Where(p => p == 'A');

    var resultado = from c in nomeCompleto where c == 'e' select c;

    foreach(var letra in resultado)
    {
        Console.WriteLine(letra);
    }*/

    var numeros = new int[] {10, 6, 5, 50, 15, 2};
    var resultado = numeros.Where(p => p >= 10);
    foreach (var numero in resultado)
    {
        Console.WriteLine(numero);
    }
}

}
