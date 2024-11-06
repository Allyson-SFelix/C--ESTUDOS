using System; // using System -> funcoes básicas que usa no programa
using System.Runtime.CompilerServices;

namespace ProjetoAulaInicial { // namespace -> é o agrupamento de classes / declarando que essa class está dentro do namespace
    internal class Program { //class interna -> todo codigo tem de estar dentro do codigo, sendo com o mesmo nome do arquivo por boas praticas

        static void Main(string[] args) { //membros da class -> "statica void Main(string[] args)" padrão para ser o código executável
            
            Console.WriteLine("Hello");// print
            
            
        }
    }
}



// SOBRE A ESTRUTURA
// sub pasta
//      o arquivo de config
//      tem o codigo do programa
//      bin e obj armazena o compilado 


// VISUAL STUDIO CONFIGS/ATALHOS
// identacao ctrl+K+D
// executacao ctrl+F5
// para abrir no visual code basta abrir pelo arquivo .sln
//------------------------------------------
// Debuggin coloca o endPoint clicando F9
// debugin comeca com o F5 -> andar o passo F10(executando e pulando a funcao)
// para entrar na funcao F11
// interromper shift+F5 ou no botao de interromper
// é mostrado nas telas sobre o programa em execucao (Var´s,memoria,etc)
// sera mostrado de forma destacada a linha em execucao



// TIPAGEM
// sbyte -> 1 byte (negativo e positivo)
// byte -> 1 byte (positivo)
// short -> 2 bytes
// int
// float (colocar f na frente -> 4.5f)
// double (4.5)
// long
// char (aspas simples -> 'a')
// string ( "dentro de aspas duplas") -> IMUTAVEL
// bool
//--------------------------------------------
// Descobrir maior e menor -> tipo.MinValue ou tipo.MaxValue



// SAIDA DE DADOS
// Console.WriteLine(); -> quebra de linha
// Console.Write(); -> nao da espaco
// texto no write:
//  Console.WriteLine("Nome:{0}/n idade:{1} /n saldo:{2:F2}",nome,idade,saldo);
// Console.WriteLine($"Nome: {varNome} \n Idade: {varIdade))
// Console.WriteLine("Nome: "+nome+"\nIdade: "+idade)
//---------------------------------------------
// numero de casas -> Console.WriteLine(var.ToString("F2"));
// para colocar ponto no lugar de virgula:
// Console.WriteLine(var.ToString("F2",CuntureInfor.InvarianteCulture));


// INCREMENTO E DECREMENTO
// int a = 10
// int b = a++
// b=10 e a=11
//---------------------------------------------
// int a = 10
// int b = ++a
// b=11 e a=11


// CONVERSAO
// implicita: (QUANDO É POSSIVEL EM RELAÇAO DO TAMANHO E DO CONTEUDO)
// de float para double
// explicita: (FORCO A CONVERSAO) OBS DE FLUTUANTES PARA STRING FICA SEM O DECIMO
// string nome= "A"
// int nameNumber=(int)nome
//--------------------------------------------
// int a = 2
// int b = 5
// double resultado= (float)b/a 


// ENTRADA DE DADOS DO TECLADO
// var=Console.ReadLine() -> le até o Enter e retornado como string
// para pegar por espaco do console (.Split):
//      string linha=Console.ReadLine();
//      string[] vetor= linha.Split(' ');
//          -> corta e armazena em cada indice de acordo com o metodo de corte que coloquei,nesse caso por espaco
//      string nome1=vetor[0];
//      string nome2=vetor[1];
//-----------------------------------------------
// receber de outro tipo -> tipo.Parse(Console.ReadLine())
// int numero=int.Parse(Console.ReadLine())
//      -> deve ser digitado um numero com o tipo especificado, caso nao da erro

// caso eu queira receber a virgula como ponto
//      float var=float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)


// OPERADORES LOGICOS
// e &&   ou ||   nao !


// CONDICIONAIS
// if  -  else if  - else

// WHILE -> while(condicao){}

// FOR -> for(inicio,condicao,incremento){}


// FUNCOES
// OBS: As funcoes das classes se chamam "metodos"
// colocado dentro da classe do programa inicializado e fora da classe executavel
//---------------------------------------------
// tipoFuncao tipoReturn nomeFuncao (tipo arqumento){} 


