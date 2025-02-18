using System; // using System -> funcoes básicas que usa no programa
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ProjetoAulaInicial
{ // namespace -> é o agrupamento de classes / declarando que essa class está dentro do namespace
    internal class Program
    { //class interna -> todo codigo tem de estar dentro do codigo, sendo com o mesmo nome do arquivo por boas praticas

        static void Main(string[] args)
        { //membros da class -> "statica void Main(string[] args)" padrão para ser o código executável

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
// Console.WriteLine(var.ToString("F2",CultureInfo.InvariantCulture));


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
// como usada nessa classe entao usa como "static"
//---------------------------------------------
// tipoFuncao tipoReturn nomeFuncao (tipo arqumento){} 
// tipoFuncao void nomeFuncao(){}


// CLASSES
// Para criar basta ir no icone com o nome do projeto e colocar "nova class"
// Atributo com letra maiuscula (int Idade)
//---------------------------------------------
// NomeClass var; -> definicao da nova variavel
// var= new NomeClass(); -> cria uma nova instancia e atributos vazios
// var.Idade=10;
//---------------------------------------------
// Instancias, nessa nova instancia ele tera o endereco da memoria com o objeto
//---------------------------------------------
// override -> significa que veio de outra Class
// public override Object ToString() -> WriteLine() objeto vira uma string | padronizando o WriteLine
//      return Var+"algo+Var2
//---------------------------------------------
// Membros estaticos ->Nao precisa instanciar, apenas utilizar como uma funcao padrao da linguagem
//      class.NomeFuncao(argumento);
//      Exemplo: Math.Sqrt(var)
//          OBS: Class estatica nao pode ser instanciada
//      Ao criar a class que será estática (utiliza apenas valores jogados a ela)
//     deve ter nos metodos/funcoes -> public static nomeFuncao(){}
//---------------------------------------------
// Tipos 
// public -> significa que pode ser usado em outro arquivo 
//
//---------------------------------------------
// Construtor -> ocorre ao criar a instancia
//      Iniciar valores dos atributos
//      Colocado depois dos atributos
//EX:   Public NomeClass(tipoVar var){
//              Atributo=var;
//      }
//--------------------------------------------
// Sobrecarga -> mais de um metodo com o mesmo nome mudando apenas os argumentos
//EX:   public NomeClass(tipoVar1 var, TipoVar2 var2){
//          Atributo1=var;
//          AAtributo2=var2;
//      }
//--------------------------------------------
// Outra forma de atribuir valores -> quando nao tiver construtor 
// NomeClass var = new NomeClass{
//      Atributo=var
// }
//--------------------------------------------
// THIS
//      ->referencia para o proprio atributo
//      ->reaproveitar construtor
//          EX: public NomeClass(int quantidade){
//                      Quantidade=quantidade;
//              }
//              public NomeClass(int idade,int valor) : this(quantidade){
//                  Idade=idade;
//                  Valor=valor
//              }
//      ->passar o objeto como argumento
//--------------------------------------------
// ENCAPSULAMENTO
// colocar "private" nos atributos que eu nao quero que o usuario mexa de forma livre,
// apenas por meio de metodos.
// private string _nome;  (private fica _var)
// public String GetNome(){ (GET para pegar o valor do atributo)
//      return Nome
// }
// public void SetNome( string nome){ (SET para alterar o atributo)
//  _nome=nome
// }

/*
// PROPERTIES
// no lugar de criar um metodo Get e Set, posso utilizar dessa forma
// public TipoVar NomeVarParaAcesso{
//      set{ atributo = value } // esse value é o valor que sera igualado 
//                                  ao utilizar essa chamada   
//      get{return atributo}
// }

// AUTO PROPERTIES
// no momento da definicao dos atributos da classe, no lugar de ou criar um metodo
// ou definir uma PROPERTIES, posso definir no momento do atributo quais acoes basicas ele pode realizar (get e set puro)
// public TipoVar Atributo{ get;private set} 
// significa que ele pode ser realizado o get normalmente e o set apenas dentro da propria classes

// ORDEM DAS DEFINICOES NA CLASS
// private
// AUTO PROPERTIES
// construtores
// propriedades costumizadas
// outros metodos


// MODIFICADORES DE ACESSOS ATRIBUTOS E METODOS
// public (todos acessam)
// protected internal (propria class, subclasse no projeto,classes do projeto,subclasse fora do projeto)
// internal (propria class, subclasse no projeto e classe no projeto)
// protected (propria class,subclasse no projeto, subclasse fora do projeto)
// private protected (propria class, subclasse no projeto)
// private (propria class)


// MODIFICADORES DE ACESSOS DE CLASS
// public (acesso por qualquer classe)
// sem / internal (acesso dentro do projeto)
// private (quando cria uma class dentro de outra classe, apenas a classe mae tem acesso)
// classe aninhada, por padrao é private

    
 */



/*  NULLABLE -> tipagem de acordo com o que quero, mas posso atribuir nulo, bom para usar para Banco de Dados para armazenar valor nulo
 *  double? x = null; // atribuicao (tipo ? nome = valor;)
 *  ou
 *  Nullable <double> x = null;
    double? y = 2.50;
    Console.WriteLine(x.HasValue); // se é nulo ou tem algo
    Console.WriteLine(x.GetValueOrDefault()); // se tiver algum valor sera ele, se nao sera o valor padrao (0 ou 0.0 ou "")
    Console.WriteLine(y.Value);// proprio valor que tiver, se for nulo da erro tem de verificar antes
*/

/* Vetores
    Tipo[] nome = new Tipo[quantidade];
    Class[] nome= new Class[quantidade];
    OBS:Quando cria o array de Class, ele apenas separa espaco para armazenar em cada indice uma instancia, mas nao inicia, 
    logo para cada posicao quando meche com classe precisa ser instanciada (new Class) e salva no array.
  ------------------------------
    int[] num= new int[12];
    num[0] = 1;
    num[1] = 2;
    num[2] = 3;
   ------------------------------- 
    Produtos[] produtos = new Produtos[2];
    string name = "asd";
    bool value = false;
    produtos[0]=new Produtos(value, name);
    name = "fgh";
    value = true;
    produtos[1]=new Produtos(value, name);


   *Length
       int tamanho=array.Length;


   *Foreach
        foreach(tipo var in vetor){ }
 
 
   *Funcao de vetores
        (INSTANCIANDO A LISTA NA CHAMADA DA FUNCAO)
        public Nome ( int[] numeros){
            numeros[0]=1;
        }
        // nessa ao executar a funcao fica Nome(new int[] { 2,3,4}) -> intancia a lista e ja atribui os valores, de numero variavel
     OU
        (USO DE params NO ESCOPO DA FUNCAO)
        public Nome (params int[] numeros){
            numeros[0]=1;
        }
        // nessa ao executar a funcao fica Nome(2,3,4) -> sendo a quantidade de numero variavel
*/


/* NAO DEVE USAR POR CLEAN CODE
 * Ref serve para como ponteiro no parametro da funcao
 * int a = 10;
 * Calc.dobro(ref a);
 * 
 * na class Calc{
 *  public static dobro ( ref int numero){
 *      numero=numero*2;
 *      }
 *      
 *  Out semelhante,mas a var "a" nao precisa ser inicializado com algum valor e no lugar de "ref" coloca "out"
 */

/*
 * Boxing
 *  crio uma var do tipo Object -> significa que aceita qualquer valor de qualquer tipo e armazena como uma instancia dessa Classe o valor
 *  int x = 10;
 *  Object objeto = x;
 *  (Isso tem um custo de memoria e computação a mais pq faz salvar na heap da memoria como uma nova instancia de classe)
 *  
 * Unboxing
 *  pego o valor do Object e salvo em uma variavel
 *  Object objeto = 10;
 *  int y = (int) objeto;
 */

/* LISTA ENCADEADA
 *  deve ter a biblioteca : "using System.Collections.Generic;
 *  List<tipo> name; // inicia vazia
 *  OU
 *  List<tipo> name= new List<tipo>(); // instanciando a lista
 *  OU
 *  List<tipo> name= new List<tipo>{value1,value2}; // inicializando valores a nova instancia da lista
 * 
 * Comandos:
 *  name.Add(value ou instancia de objeto); //adiciona no final da lista encadeada
 *  name.Insert(position,value ou instancia de objeto); // insere na posição especificada na lista encadeada
 *  
 *  name.Count(); //tamanho da lista
 *  
 *  name.Find(funcao ou funcao lambda [ parametro => condicao percorrendo a lista usando o parametro]); 
 *  // busca o primeiro item que for selcionado para achar
 *  
 *  name.FindLast(funcao ou funcao lambda [ parametro => condicao percorrendo a lista usando o parametro]); 
 *  // busca o ultimo item que for selcionado para achar
 *  
 *  name.FindIndex(funcao ou funcao lambda [ parametro => condicao percorrendo a lista usando o parametro]); 
 *  // busca o indice do ultimo item que for selcionado para achar
 *  
 *  name.FindIndexLast(funcao ou funcao lambda [ parametro => condicao percorrendo a lista usando o parametro]); 
 *  // busca o indice do ultimo item que for selcionado para achar
    
    declara uma nova lista para ter a lista dos itens que passaram no filtro
    List<tipo> listaFiltrado = lista.FindAll(funcao ou funcao lambda [ parametro => condicao percorrendo a lista usando o parametro]);

    name.Remove(value); //excluir a lista com o value (se nao existir nao remove)

    name.RemoveAll(funcao ou funcao lambda [ parametro => condicao percorrendo a lista usando o parametro]); 
    // remove de acordo com a funcao 

    name.RemoveAt(indice); // remove a partir do indice

    name.RemoveRange(a partir daqui, quantos itens(contando com o "a partir daqui") );
 */


/*
 * Matriz
 *  tipo [,] nome = new tipo[linha,coluna];
 *  
 *  nome.Length // quantidade de casas
 *  nome.Rank // numero de linha
    nome.GetLength(0 para linha ou 1 para coluna) // descobre o numero do que estiver no escopo
 */

/* 
 * Var pode ser usada para nao precisar declarar tipo, 
 * contudo pode ter problema de colocar ela recebendo uma outra variavel com outro tipo gerando problemas
 * 
 * Switch-case
 * switch(variavel):
 *  case value:
 *      //algo
 *      breal;
 *  default:
 *      //algo
 *      break;
 *      
 *  Operador ternario
 *  tipo nome = ( condição ) ? valor_se_verdadeiro : valor_se_falso  // atribuo o valor a partir desse if de uma linha
 *  
 */

/* FUNCOES STRINGS
 * OBS: string é imutavel, quando cria a variavel e salva ele não é mudado e sim muda o endereço que ele representa
 * string nome = "texto";
 * string nomeUp= nome.ToUpper(); // tudo maiusculo
 * string nomeUp= nome.ToLower(); // tudo minusculo
 * string nomeUp= nome.Trim(); // tira o espaço em branco no inicio e no final
 * int nomeIndice= nome.IndexOf("letra/nome"); // posicao aonde esta o que procura
 * int nomeUltimoIndie= nome.LastIndexOf("letra/nome"); // ultimo indice com o que procura
 * string subnome= nome.Substring(indice-inicial,quantidade de caracteres); // corta do indice em diante com essa quantidade
 * 
 * string nomeTroca= nome.Replace("quero trocar","quero colocar no lugar"); // trocar caracteres ou string
 * 
 * bool nomeComSem= String.IsNullOrEmpty(nome); // nulo ou com valor padrao vazio
 * bool nomeSemOuBranco= String.IsNullOrWhiteSpace(nome); // nulo ou com espacos em branco
 * 
 */


/* Enum
 * Crio como se fosse uma classe, mas no lugar de class coloco enum
 * enum Name : tipo
 * {    name = value,
 *      name2=value2,
 *      name3= value3
 * }
 * Posso usar ele como tipo para propriedades/atributos das classes
 * string mostraNome = Name.name.ToString(); // converte para string
 * Name qualquer = Enum.parse<Name>("name"); // converte string para enum
    OU
    Name os = (Name)Enum.Parse(typeof(Name), "name");
 */

/* COMPOSIÇÃO (class na class)
 * SIMBOLO DE DIAMANTE PRETO (TODO - PARTE)
 * quando a class tem relação com outra class, se é varios(trabalhadores) com 1(departamento), ou 1(trabalhador) com vários(contratos)
 * EX: uma classe trabalhador está em 1 departamento e pode ter N contratos
 * quando crio o atributo de departamento eu coloco public Departamento DepartamentoPresente ;
 * quando crio o atributo de vários contratos eu crio uma List das classes Contratos que tem relacao comigo
        public List<Contratos> Contratos = new List<Contratos;

 *    OBS: QUANDO FOR PARA MUITOS NAO INCLUO NO CONSTRUTOR POR SER LIST
 *    
 *    OBS : QUANDO TIVER PARA MUITOS É BOM COLOCAR ADD E REMOVE DEVIDO A CLASS SER UM ATRIBUTO LIST
 * 
 */

/* StringBuilder
    dentro da class se eu quiser padronizar a saida de acordo com apenas o write(Class) posso usar o StringBuilder

    public override string ToString(){
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("text ou"+var);// mesma linha
        stringBuilder.AppendLine("text ou"+var); // add em outra linha  
    
        return stringBuilder.ToString(); // para transformar em string para ser mostrado no Console.write(Class);
    }
    
 */

/* HERANÇA
   Classe derivada é declarada assim:
        public class Nome1 : NomePrincipal {}

   Se a classe base tiver um construtor com parâmetros, use : base(...) na classe derivada.
    Exemplo:
     public Nome1(int atributoSubClasse,string atributoSuperClasseNome1, string atributoSuperClasseNome2) : base(atributoNome1, atributoNome2) {}
 
    OBS: protected permite acesso apenas as subclasses e sua propria classe, private apenas sua classe
 */

/*[DownCasting e Upcasting]
Upcasting
(converte da subclasse (classe que herda) para ser do tipo da classe pai)

Conta conta1 = new ContaPoupanca(...);
( classe pai = Conta  , classe filha = ContaPoupanca)

DownCasting
( converte da classe para subclasse)
ContaPoupanca conta2 = (ContaPoupanca)conta1;
ou
ContaPoupanca conta2 = conta1 as ContaPoupanca;
(a classe filho armazena pois "conta1" foi instanciado com essa classe filho, para salvar como classe filho normal é preciso fazer o casting(conversão) )

[Sobreposição,virtual,override]
"virtual" na classe base permitem que sejam sobrescritos em classes derivadas usando "override".
   Exemplo:
   public virtual Nome() {} => Método virtual na classe base.

Classe derivada é declarada assim:
   public class Nome1 : NomePrincipal {}

Para sobrescrever o método na classe derivada:
   public override Nome(...) {
	->refaz a funcao com o jeito que quer
	OU
	->base.Nome(...); 
	-> continua a funcao com mais coisa
	(serve para executar a funcao original e adicionar mais ações a serem feitas)
} => override indica que o método sobrescreveu o da base.

[Classes e métodos selados]
classe selada ela não pode ser herdada
(sealed class NomeClass{} )

método selado evita que método sobreposto possa ser sobreposto novamente
(public sealed override void Nome(){} )

[Polimorfismo]
(crio a variável como classe pai e salvo como classe herdada)
Conta conta1 = new Conta(...)
Conta conta2 = new ContaPoupanca(...)
(dessa forma é usado o mesmo tipo de variável mas as ações de cada variável poderá ser diferente,
mas o nome do método chamado é possivelmente o mesmo)

[Classes Abstratas]
(EM ITALICO NA UML)
(classes que não podem ser instanciadas)
("abstract")
(ela pode ser herdada e sua classe filho pode ser instanciada)
EX: quando crio a classe Conta , mas no banco ou tem ContaPoupanca ou ContaCorrente
então posso criar a classe Conta como abstract e herda criando essas outras duas classes
não permitindo a criação de uma conta sem ser desses dois tipos

(possibilita a criação de uma lista de classes pai para salvar de vários tipos de classes filhas dele
colocando na criação da lista com o tipo da classe pai)
EX: classe abstrata = Conta , filho 1 = ContaPoupanca, filho 2 ContaCorrente
	List<Conta> listaContas = new List<Conta>();
	listaContas.Add(new ContaPoupanca(...));
	listaContas.Add(new ContaCorrente(...));
*/
/* Exception
 * try{}
 * catch(Exception TIPO ou TipoException ou NomeClassException e){ 
 *      Console.Writeln("Erro: "+e.Message); 
 *          -> aparecerá aqui quando for criado pela aplication a mensagem criada
 * }
 * Finally{}
 * 
 * Para criar um exception diferente crio dentro da pasta aonde está a classe relacionado com os possiveis erros
 * crio uma classe: 
 * class DomainException : ApplicationException{
 *  public DomainException(string MensagemQueReceberáAoChamar):base(message){}
 * }
 * 
 * na classe sobre local que pode ter erro eu posso colocar condição no construtor
 * { trow new DomainException("Mensagem"); } ou coloca na funcao normal
 * 
 * pode ser usado nas funcoes da class para evitar várias condições aninhadas no main
 * " trow new DomainException("Mensagem") "
 */

