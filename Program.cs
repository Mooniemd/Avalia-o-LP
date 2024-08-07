// Questão 1: Nome e seleção de classe.
Console.WriteLine("Por favor herói, me diga seu nome!");
string? nome = Console.ReadLine()!.ToLower();

Console.WriteLine("Também nos diga seu sobrenome!");
string? sobrenome = Console.ReadLine()!.ToLower();

Console.WriteLine("Agora nos informe sua classe, grande herói!");
string? classe = Console.ReadLine()!.ToLower();

string[] classes = ["guerreiro", "druida", "mago", "paladino"];
if( classes.Contains(classe)){
  Console.WriteLine("Bem vindo ao reino de Elbaf, nosso herói " + nome + " " + sobrenome + "! A sua classe é: " + classe);
} else{
  Console.WriteLine("Sua classe não existe, herói. Pare de mentir!");
}

/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */