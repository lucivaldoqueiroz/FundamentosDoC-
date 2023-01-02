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