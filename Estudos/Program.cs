using Estudos.Interfaces;
using Estudos.Models;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

Pessoa pessoaUm = new Pessoa();

pessoaUm.Nome = "João";
pessoaUm.Idade = 25;
pessoaUm.Sobrenome = "Silva";
pessoaUm.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

//Convertendo tipos de variáveis
int num = Convert.ToInt32("5");
int num2 = int.Parse("10");
int num3 = 55;
string paraString = num3.ToString();

Calculadora calc = new Calculadora();
calc.Dividir(10,2);
calc.Somar(5,5);
calc.Subtrair(20,10);
calc.Multiplicar(6,6);
calc.Potencia(5,3);
calc.Cosseno(30);
calc.Seno(30);
calc.Tangente(30);

//Arrays
int [] arrayInteiros = new int[3];
arrayInteiros[0]= 72;
arrayInteiros[1]= 34;
arrayInteiros[2]= 29;

for(int contador = 0; contador < arrayInteiros.Length; contador++){
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o array com FOREACH = ");
foreach(int valor in arrayInteiros){
    Console.WriteLine(valor);
}

//Listas
List<string> nomes = new List<string>();
nomes.Add("Maria Aparecida");
nomes.Add("João Marcelo");
nomes.Add("Pedro");
nomes.Add("Joana");
Console.WriteLine("Lista de Nomes:");
foreach(string nomi in nomes){
    Console.WriteLine($"--> {nomi}");
}

//Classes e métodos
Curso curso = new Curso();
curso.Nome = "Ciência da Computação";
curso.Alunos = new List<Pessoa>();
curso.AdicionarAluno(pessoaUm);
int quantidadeAlunos = curso.QtdAlunos();
Console.WriteLine($"Quantidade de alunos no curso de {curso.Nome} = {quantidadeAlunos}");

Pessoa pessoaDois = new Pessoa();
pessoaDois.Nome = "Marielle";
pessoaDois.Idade = 19;
pessoaDois.Sobrenome = "Costa";

curso.AdicionarAluno(pessoaDois);
curso.ListarAlunos();

Pessoa pessoaTres = new Pessoa("Vallentina", "Nobrega");
curso.AdicionarAluno(pessoaTres);
curso.ListarAlunos();


//Formatações

double porcentagem = .5021;
Console.WriteLine(porcentagem.ToString("P")); //--> formatação de porcentagem

int numero = 123456;
Console.WriteLine(numero.ToString("###-###")); //-->formatação personalizada

//Leitura de um arquivo

string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
foreach(string linha in linhas){
    Console.WriteLine(linha);
}

//Filas
Queue<int> fila = new Queue<int>();
fila.Enqueue(4);
fila.Enqueue(3);
fila.Enqueue(2);
fila.Enqueue(1);
Console.WriteLine("FILA:");
foreach(int item in fila){
    Console.WriteLine($"- {item}");
}
fila.Dequeue();

//Pilha
Stack<int> pilha = new Stack<int>();
pilha.Push(10);
pilha.Push(6);
pilha.Push(4);
Console.WriteLine("PILHA:");
foreach(int item in pilha){
    Console.WriteLine($"- {item}");
}
pilha.Pop();

//Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>(); //<chave, valor>
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");
estados.Add("AM", "Amazônia");
estados.Add("ES", "Espírito Santo");
Console.WriteLine("Dicionário:");
foreach(KeyValuePair<string, string> item in estados){
    Console.WriteLine($"- {item}");
}
Console.WriteLine("------------------------");
estados.Remove("SP");
foreach(var item in estados){
    Console.WriteLine($"* {item.Key} = {item.Value}");
}
string chave = "BA";
if(estados.ContainsKey(chave)){
    Console.WriteLine($"Valor existente: {chave}");
}else{
    Console.WriteLine($"Valor ainda não cadastrado: {chave}");
}
Console.WriteLine(estados["MG"]);

//Tuplas --> 3 formas de criar

(int Id, string Nome, string Sobrenome) tuplaUser = (5, "Carly", "Jepsen"); //mais recomendada
Console.WriteLine($"{tuplaUser.Id}--> {tuplaUser.Nome}");
ValueTuple<int, string, string> tuplaUser2 = (6, "Dua", "Lipa");
Console.WriteLine($"{tuplaUser2.Item1}--> {tuplaUser2.Item2}");
var outraTupla = Tuple.Create(7, "Sabrinna", "Noca");
Console.WriteLine($"{outraTupla}");

//Tuplas em métodos
LeituraArquivo leitura = new LeituraArquivo();
var (sucesso, linhasArquivo, quantidadeLinhas) = leitura.LerArquivo("Arquivos/arquivoLeitura.txt");
if(sucesso){
    Console.WriteLine($"Quantidade de linhas = {quantidadeLinhas}");
    foreach(string linha in linhasArquivo){
        Console.WriteLine(linha);
    }
}else{
    Console.WriteLine("Não leu o arquivo :(");
}

//Desconstrutor
Pessoa pessoaDesconstruida = new Pessoa("Leonarde", "Reis");
(string nome, string sobrenome) = pessoaDesconstruida;

//Serialização --> transmitir o objeto --> comum ser em JSON
Venda v1 = new Venda(1, "Arroz", 25.00M, dataAtual);
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
Console.WriteLine(serializado);
File.WriteAllText("Arquivos/vendas.json",serializado);

Venda v2 = new Venda(1, "Feijão", 21.50M, dataAtual);
List<Venda> listaVendas = new List<Venda>();
listaVendas.Add(v1);
listaVendas.Add(v2);
string listaSerializada = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/listaVendas.json",listaSerializada);

//Deserialização
string conteudoArquivo = File.ReadAllText("Arquivos/listaVendas.json");
List<Venda> listaExterna = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
foreach(Venda venda in listaExterna){
    Console.WriteLine($"Id: {venda.Id}  --  Produto: {venda.Produto}  --  Preço: {venda.Preco}");
}

//Polimorfismo 

Aluno a1 = new Aluno("Maurício", "de Souza");
a1.Nota = 8;
a1.Apresentar();

//Classe abstrata

Corrente contaCorrente = new Corrente();
contaCorrente.Creditar(50.00M);
contaCorrente.ExibirSaldo();

//Interface

ICalculadora calculadore = new Calculadora();
int somass = calculadore.Somar(5, 7);

