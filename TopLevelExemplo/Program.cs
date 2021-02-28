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
var teste = new ClasseTeste();
Console.WriteLine(teste.Nome);