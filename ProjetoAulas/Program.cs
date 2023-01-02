/* 
Console.WriteLine("Primeiro Programa");

//Trabalhando com Variáveis.

int idade = 30;
Console.WriteLine(idade);

string nome = "Lucivaldo";
Console.WriteLine(nome);

decimal valor = 200.99m;
Console.WriteLine(valor);
double valorDouble = 200.99;
Console.WriteLine(valorDouble);
float valorFloat = 200.99f;
Console.WriteLine(valorFloat);

var idadeNova = 34;
Console.WriteLine(idadeNova);

char flag = 'C';
Console.WriteLine(flag);
bool ativo = true;
Console.WriteLine(ativo);

//Constantes - Não pode ser alterado o valor de uma constante que foi atribuida a variável.

const string descricao = "Curso CSHARP";
//descricao = "Curso";
Console.WriteLine(descricao);

//Comentários
// - comentário simples
/* 
Multi lines
Multi lines
*/

// Operadores Aritméticos

/*
var soma = 5+2;
Console.WriteLine(soma);

var numero1 = 1;
var numero2 = 2;
var somar = numero1 + numero2;
Console.WriteLine(somar);

var subtração = numero2 - numero1;
Console.WriteLine(subtração);

var multiplicar = (numero2 * numero1) * 10;
Console.WriteLine(multiplicar);

var dividir = numero1 / numero2;
Console.WriteLine(dividir);
*/

//Operadores relacionais

/*
var numero1 = 1;
var numero2 = 2;

bool igual = numero1 == numero2;
Console.WriteLine(igual);

bool maior = numero1 > numero2;
Console.WriteLine(maior);

bool menor = numero1 < numero2;
Console.WriteLine(menor);

bool menorIgual = numero1 <= numero2;
Console.WriteLine(menorIgual);

bool maiorIgual = numero1 >= numero2;
Console.WriteLine(maiorIgual);

bool diferente = numero1 != numero2;
Console.WriteLine(diferente);
*/

//Operadores Lógicos
/*
var numero1 = 1;
var numero2 = 2;

var eh = numero2 > numero1 && 8 > 7;
Console.WriteLine(eh);

var ou = numero2 > numero1 || 8 > 7;
Console.WriteLine(ou);

var negacao = !(numero2 > 10);
Console.WriteLine(negacao);
*/

// Operador Ternário

/*
var numero1 = 1;
var numero2 = 2;

bool ativo = false;
string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";
Console.WriteLine(status);
*/

// Funções


/*
EscreverNome();

void EscreverNome()
{
var nome = NomeCompleto();
var soma = SomaValores();

Console.WriteLine(nome);
Console.WriteLine(soma);
}

string NomeCompleto()
{
    string primeiroNome = "Lucivaldo";
    string ultimoNoME = "Queiroz";
    return primeiroNome + " " + ultimoNoME;
}

int SomaValores()
{
    return 8+2;
}
*/
/*
var soma = SomaValores(3,5);
Console.WriteLine(soma);

int SomaValores(int a, int b)
{
    return a + b;

}

// var nome = NomeEIdade("Meu nome é Lucivaldo e tenho a seguinte idade: ", 30);
   var nome = NomeEIdade("Lucivaldo", 30);
Console.WriteLine(nome);
string NomeEIdade(string nome, int idade)
{
    //return nome + idade;
    return "Meu nome é " + nome + "e tenho " + idade + " anos";
}
*/

//Array List
/*
using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(1); //0
arrayList.Add("Lucivaldo"); //1
arrayList.Add(true); //2

//Console.WriteLine(arrayList[1]);

arrayList.RemoveAt(1);
//arrayList.Clear();
foreach(var item in arrayList)
{
    Console.WriteLine(item);
}
*/

//Array List tipado

var arrayTipadoNumero = new int[3] {1, 2, 3};

arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

//Array.Resize(ref arrayTipadoNumero, 100);

//arrayTipadoNumero[10] = 100;
/*
foreach(var item in arrayTipadoNumero)
{
    Console.WriteLine(item);
}

var arrayTipadoString = new string[2] {"Rafael", "Almeida"};

arrayTipadoString[0] = "Lucivaldo";
arrayTipadoString[1] = "Queiroz";

foreach(var item in arrayTipadoString)
{
    Console.WriteLine(item);
}
*/

//Lista Genérica
/*
var lista = new List<string>(10)
{
    "Lucivaldo",
    "Queiroz",
};

//lista.Add("Lucivaldo");
//lista.Add("Queiroz");
//lista.Add("Curso");

//var nome = lista[0];

lista.RemoveAt(1);

foreach(var item in lista)
{
    Console.WriteLine(item);
}
*/

// Dicionário
/*
var dicionario = new Dictionary<string, string>()
{
    {"teste", "Teste"},
    {"teste6", "Teste 6"},
};

dicionario.Add("nome", "Lucivaldo");

dicionario["curso"] = "Curso";

var nome = dicionario["nome"];
//Console.WriteLine(nome);

foreach(var item in dicionario)
{
    Console.WriteLine("Valor: " + item.Value + " Chave: " + item.Key);
}
*/

//Queue
/*
var queue = new Queue<string>();
queue.Enqueue("Lucivaldo");
queue.Enqueue("Queiroz");

// FIFO O PRIMEIRO ITEM É O PRIMEIRO A SAIR

//var nome = queue.Peek();
//var nome1 = queue.Peek();

var nome = queue.Dequeue();
var nome1 = queue.Dequeue();

Console.WriteLine(nome);
Console.WriteLine(nome1);

/*
foreach(var item in queue)
{
    Console.WriteLine(item);
}
*/

// LIFO O ULTIMO A ENTRAR É O PRIMEIRO A SAIR DA MINHA LISTA.
/*
var stack = new Stack<string>();
stack.Push("Lucivaldo");
stack.Push("Queiroz");

var nome = stack.Pop();
var nome1 = stack.Pop();
Console.WriteLine(nome);
Console.WriteLine(nome1);

/*
foreach(var item in stack)
{
    Console.WriteLine(item);
}
*/

// IF
/*
var diaDaSemana = 0;
var diaDeTrabalho = false;

if(diaDaSemana == 0 && diaDeTrabalho == true)
{
    Console.WriteLine("Hoje é Domingo");
} else if (diaDaSemana == 0 && diaDeTrabalho == false)
{
     Console.WriteLine("Hoje não é Domingo, mas não é dia de trabalho");
}
else 
{
     Console.WriteLine("Hoje não é Domingo");
}
*/

var diaDaSemana = 10;
if(diaDaSemana == 0)
{
     Console.WriteLine("Hoje é Domingo");
}
else if(diaDaSemana == 1)
{
     Console.WriteLine("Hoje é Segunda");
}
else if(diaDaSemana == 2)
{
     Console.WriteLine("Hoje é terça");
}
else if(diaDaSemana == 3)
{
     Console.WriteLine("Hoje é quarta");
}
else if(diaDaSemana == 4)
{
     Console.WriteLine("Hoje é quinta");
}
else if(diaDaSemana == 5)
{
     Console.WriteLine("Hoje é sexta");
}
else if(diaDaSemana == 6)
{
     Console.WriteLine("Hoje é sabado");
}
else
{
     Console.WriteLine("Dia da semana invalido");
}