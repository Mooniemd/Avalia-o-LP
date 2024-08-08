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

// Questão 2: Inventário e vetores.
/*
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
*/

// Questão 3: Inventário e peso.
/*List<string> item = [];
List<float> peso = [];

Console.WriteLine("Quantos itens você gostaria de adicionar ao inventário?");
int qntItem = int.Parse(Console.ReadLine()!);

for(int i = 0; i < qntItem; i++){
  Console.WriteLine("Qual item você gostaria de adicionar ao inventário?");
  string? items = Console.ReadLine()!.ToLower();
  Console.WriteLine("Qual o peso do item que você acabou de adicionar?");
  float pesos = float.Parse(Console.ReadLine()!);
  item.Add(items);
  peso.Add(pesos);
}

Console.WriteLine("Esses são os itens em sua mochila:");

for( int i = 0; i < item.Count; i++){
Console.WriteLine($"{item[i]} - {peso[i]}KG");
}
*/

/*Console.WriteLine("Qual slot da mochila você gostaria de checar?");
int slot = int.Parse(Console.ReadLine()!);

if( slot >= 1 && slot <= qntItem){
  Console.WriteLine($"O item {item[slot - 1]} está na sua mochila e tem o peso de {peso[slot - 1]}KG");
} else{
  Console.WriteLine("Esse item não existe na sua mochila...");
}*/

// Questão 4: Batalha de NPC e seleção de classe/arma.
/*Console.WriteLine("Diga-me seu nome, jovem herói!");
string? nome = Console.ReadLine()!;

Console.WriteLine("E qual arma será de sua escolha?");
var armas = new List<string> { "Machado", "Espada", "Adaga"};
var bonusA = new List<int> { 3, 2, 1 };

for(int i = 0; i < armas.Count; i++){
  Console.WriteLine($"{armas[i]} - STR: {bonusA[i]}");
}
string? arma = Console.ReadLine()!.ToLower();

Console.WriteLine("Perfeito, agora qual será sua classe?");
var classes = new List<string> { "Barbaro", "Guerreiro", "Assassino"};
var bonusV = new List<int> { 30, 20, 10};

for(int i = 0; i < classes.Count; i++){
  Console.WriteLine($"{classes[i]} - BHP: {bonusA[i]}");
}
string? classe = Console.ReadLine()!.ToLower();

bool armaExiste = false;
bool classeExiste = false;
int vidaPlayer = 0;
int danoArma = 0;

for(int i = 0; i < armas.Count; i++){
  if (armas[i].ToLower().Equals(arma)){
    armaExiste = true;
    danoArma = bonusA[i];
    break;
  }
}

for(int i = 0; i < classes.Count; i++){
  if (classes[i].ToLower().Equals(classe)){
    classeExiste = true;
    vidaPlayer = bonusV[i] + 100;
    break;
  }
}

if (armaExiste && classeExiste){
  Console.WriteLine($"Ótimo, {nome}, sua arma é: {arma} e sua classe é: {classe}.");
  Console.WriteLine("Agora você deve enfrentar Gerald, o Impiedoso, para salvar nossa vila. Boa sorte jovem herói!");

  string? nomeNPC = "Gerald";
  string? armaNPC = "Espada";
  int vidaNPC = 120;
  int danoArmaNPC = 2;

  Random random = new Random();

  while(vidaPlayer > 0 && vidaNPC > 0){
    int danoPlayer = danoArma + random.Next(0, 30);
    vidaNPC -= danoPlayer;
    Console.WriteLine($"{nome} atinge {nomeNPC} com seu/sua {arma} e deu {danoPlayer} de dano. {nomeNPC} ficou {vidaNPC} de vida!");

    if(vidaNPC <= 0) break;

    int danoNPC = danoArmaNPC + random.Next(0, 30);
    vidaPlayer -= danoNPC;
    Console.WriteLine($"{nomeNPC} atinge {nome} com seu/sua {armaNPC} e deu {danoNPC} de dano. {nome} ficou {vidaPlayer} de vida!");
  }

  if (vidaPlayer > 0 ){
    Console.WriteLine($"{nome} venceu a batalha! Parabéns jovem herói.");
  } else{
    Console.WriteLine($"{nomeNPC} venceu a batalha... Fujam todos, vamos todos morrer!");
  }
} else{
  Console.WriteLine("A classe e/ou a arma que você inseriu não existem!");
}
*/

/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */