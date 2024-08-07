// Questão 1: Nome e seleção de classe.
/*Console.WriteLine("Por favor herói, me diga seu nome!");
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
*/

// Questão 2: Inventário e vetores.
List<string> inventario = [];

Console.WriteLine("Quantos itens você gostaria de adicionar ao inventário?");
int qntItem = int.Parse(Console.ReadLine()!);

for(int i = 0; i < qntItem; i++){
  Console.WriteLine("Qual item você gostaria de adicionar ao inventário?");
  string? items = Console.ReadLine()!.ToLower();
  inventario.Add(items);
}

Console.WriteLine("Qual slot da mochila você gostaria de checar?");
int slot = int.Parse(Console.ReadLine()!);

if( slot >= 1 && slot <= qntItem){
  Console.WriteLine($"O item {inventario[slot - 1]} está na sua mochila!");
} else{
  Console.WriteLine("Esse slot de item não existe na sua mochila...");
}


/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */