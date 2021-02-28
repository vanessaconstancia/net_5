using System;
using TopLevelExemplo;

Console.WriteLine("Aplicação console sem o método main");

//Mesmo utilizando Top Levels Statement ainda é possivel utilizar o 'args' que se encontra no escopo 
foreach(var argumento in args)
{
    Console.WriteLine($"Argumento: {argumento}");
}

FuncaoLocal();

//Chamando uma função local, recurso disponível desde o C# 7.0
void FuncaoLocal()
{
    Console.WriteLine("Output da funcao Local");
}

//Instanciando uma classe e obtendo uma propriedade
var teste = new ClasseComum();
Console.WriteLine(teste.Propriedade);

var teste1 = new ClasseTopLevel();
Console.WriteLine(teste1.Propriedade);

var teste2 = new ClasseSemNamespace();
Console.WriteLine(teste2.Propriedade);
 
class ClasseTopLevel
{
public string Propriedade { get => "Classe Top level"; }

 }