namespace Modulo12;

public class TrabalhandoComException
{
    public void AulaGerandoException()
    {
       while(true)
       {
        try{
             Console.Write("Informe um numero: ");
        var numero = Console.ReadLine();
        var resultado = 500 / int.Parse(numero);
        Console.WriteLine("Resultado: " + resultado);
        }
        catch(DivideByZeroException exception){
            Console.WriteLine("Ocorreu um erro de divisão ! " + exception.Message);
            Console.WriteLine("Stack " + exception.StackTrace);
        }
        catch(Exception exception){
            Console.WriteLine("Ocorreu um erro ! " + exception.Message);
            Console.WriteLine("Stack " + exception.StackTrace);
        }
        
       }

    }
}