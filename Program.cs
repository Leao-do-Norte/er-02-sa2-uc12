// See https://aka.ms/new-console-template for more information

// Console.Clear();

// Console.WriteLine("Hello, World!");

using er_02_sa2_uc12.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Angelo Vinicius";
novaPF.cpf = "703.580.584-22";

Console.WriteLine(novaPF.nome);
Console.WriteLine(novaPF.cpf);
Console.WriteLine($"--------------------------------------");

Console.WriteLine($"Nome: {novaPF.nome} CPF: {novaPF.cpf}");
// o sinal $ serve para interpolação
Console.WriteLine($"--------------------------------------");

// usando concatenação:
Console.WriteLine($"--------------------------------------");
Console.WriteLine($"Bem-vindo " + novaPF.nome + " seu CPF é " + novaPF.cpf + " !!!");