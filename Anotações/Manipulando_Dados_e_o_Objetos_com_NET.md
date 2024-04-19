 # Módulo: Manipulando Dados e Objetos com .NET :nerd_face:

<strong>Curso: Propriedades, Métodos e Construtores com C# :construction:</strong>

<p><b>Propriedades</b> são membros que oferecem um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.
</p>

```C#
public class Pessoa
{
    public string Nome {get; set;}
    public int Idade {get; set;}
}
```
No trecho acima é construída duas propriedades para a classe Pessoa, uma do tipo <b>string</b> e outra do tipo <b>inteiro</b> que recebem o nome de "Nome" e "Idade". Como sei que é uma propriedade? porque apresenta o "get" e o "set", sendo o "get" para obter uma informação e o "set" para definir um valor de uma propriedade.

<p><b>Método</b> é um bloco de código, ou trecho, que executa uma determinada tarefa ou ação.

```C#
public void Apresentar()
{
    Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
}
```
Nesse exemplo acima, em complemento ao trecho de código apresentado em Propriedades, caso o usuário tenha digitado "Jaime" para nome e 28 para a idade, seria exibido: Nome: Jaime, Idade: 28.

E como faríamos para chamar/usar esse método? vide exemplo abaixo:

```C#
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Jaime";
p1.Idade = 28;
p1.Apresentar();
```
<p>Para usar esse método eu instancio a classe Pessoa em uma variável, que nesse caso chamei de "p1", e logo após chamei as propriedades Nome e Idade e passei os valores, por fim solicitei a execução do método Apresentar.</p>

<p><b>E como posso validar o GET e o SET?</b><br>
Quando passamos o GET e o SET vazio (vide exemplo em Propriedades), estamos aceitando qualquer valor que seja passado para a propriedade, ou seja, não será validado nenhuma informação, se eu passar nesse exemplo um nome vazio ou idade negativa ele aceitaria, pois não está sendo validado.</p>

<p>Para realizar essa validação eu preciso primeiro criar um campo privado. Essa é uma das propriedades da progração orientada a objetos (POO ou OOP), o encapsulamento, ao qual voçê protege os seus atributos, métodos de modificações externas, a não ser que passe por uma validação, seja ela de propriedades ou métodos</p>

```C#
public class Pessoa
{
    private string _nome;
    public string Nome 
    { 
        get
        {
            return _nome.ToUpper();
        }

        set
        {
            if(value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }
            _nome = value;
        }
    }
}
```
<p>No código acima vemos que foi criado um campo que recebeu o nome de "_nome" e vai armazenar o valor da variável Nome, ou seja, o valor não vai mais ser armazenado na variável Nome, e sim nesse campo "_nome", e o seu tipo agora é privado , ou seja, somenta a própria classe pode fazer alguma modificação no campo "_nome".</p>

<p>O GET agora retorna a entrada do usuário para o campo <b>_nome</b> com o método <b>ToUpper</b> que vai colocar todas as letras em maiúsculo independente da entrada do usuário.</b></p>

<p>O SET agora apresenta uma condição, em quê se o valor recebido nessa entrada do usuário foi vazio, o programa exibirá uma mensagem de erro e se encerrará. Caso não seja vazio, então irá armazenar esse valor no campo <b>_nome.</b></p>

<p><b>Body Expressions</b></p>

Podemos simplificar algumas expressões para facilitar a sua leitura, chamamos de <b>body expression</b>, vamos fazer isso com o nosso GET no exemplo abaixo:</p>

```C#
 public string Nome 
{ 
    get => _nome.ToUpper();
}
```
Esse método é amplamente utilizado quando se tem somente uma linha de argumento como foi o caso desse GET.<br>

<p><b>Validando a Propriedade Idade</b></p>

Vamos utilizar a mesma validação que foi utilizada para a propriedade Nome:<br>

```C#
private int _idade;

public int Idade 
{
    get => _idade;
    set
    {
        if(value < 0)
        {
            throw new ArgumentException("A idade não pode ser menor que zero");
        }
        _idade = value;
     }
}
```
<b>Explicando um pouco mais sobre Método</b>

<p>No <b>Método</b> nós temos as seguintes características:</p>

```C#
public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }
}
```
<p>Nesse exemplo, o método <b>AdicionarAluno()</b> não tem um retorno, ou seja, ele só executa uma ação de adicionar a lista de Alunos, nesse caso, quando eu não tenho um retorno ou não preciso adicionar um retorno, eu coloco a palavra <b>void</b>, que significa <b>vazio</b>. Para entender melhor, veja o exemplo abaixo:</p>

```C#
// Método que não retorna valor (void)
public void ExibirMensagem()
{
    Console.WriteLine("Esta é uma mensagem de exemplo.");
}

// Método que retorna um valor (int)
public int Somar(int a, int b)
{
    return a + b;
}
```
<p> Após o "void" temos o nome do método, que nesse caso é "AdicionarAluno",e após o nome temos os seus argumentos/parâmetros, que foram a lista Pessoa, que nesse caso é a Lista da classe Pessoa, e logo após o nome de uma variável que vai instanciar essa pessoa, que no caso foi chamada de aluno.</p>

### Construtores

<p> Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler.</p>

```C#
public Pessoa()
{

}

//EXEMPLO 2:
public Pessoa(string nome, string sobrenome)
{
    Nome = nome;
    Sobrenome = sobrenome;
}
```
Curso finalizado!<br>
___
## Manipulando Valores com C#

<p><B> Concatenação de string:</b></p>

Podemos fazer a concatenação (que é a junção de duas strings) de algumas formas, como nesses 2 exemplos abaixo:

```C#
public void ListarAlunos()
{
    Console.WriteLine($"Alunos do curso de: {Nome}");

    for (int count = 0; count < Alunos.Count; count++)
    {
        //Exemplo 1:
        string texto = "N° "+ count +" - "+ Alunos[count].NomeCompleto;

        //Exemplo 2:
        string texto = $"N° {count} - {Alunos[count].NomeCompleto}";
        Console.WriteLine(texto);
    }
}
```
<p>Ambos exemplos estão corretos, porém o <b>Exemplo 2</b> apresenta uma visualização melhor, mais fácil de ler.<br>
No <b>Exemplo 2</b> foi usado o símbolo de $ antes de iniciar a string, esse símbolo representa uma interpolação, que é quando vamos criar uma única string e colocar váriáveis dentro dela, através do símbolo de {}, ou seja, tudo que está dentro das chaves não é lido de maneira literal, mas sim o seu conteúdo, o valor da variável, se não inciarmos com o $ toda a string é lida de maneira literal.</p>

<p><b> Ajustando Numeração: </b></p>

<p> No exemplo que estamos utilizando, ao executar o código, aparece da seguinte forma:

```
N° 0 - JAIME MOREIRA DOS SANTOS JUNIOR
N° 1 - ANTÔNIO FERREIRA DOS SANTOS
```
Se analizarmos a lógica dessa lista, estaria incorreto, já que deveria ser aluno n°1, n°2,n°3 etc, e não aluno n°0, não existe aluno número zero. Logo, para resolver isso realizamos a seguinte alteração no código somente para melhorar essa saída do programa:

```C#
public void ListarAlunos()
{
    Console.WriteLine($"Alunos do curso de: {Nome}");

    for (int count = 0; count < Alunos.Count; count++)
    {
        string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
        Console.WriteLine(texto);
    }
}
```
Adicionamos o "+ 1" em {count + 1} para que na exibição, ao invês de iniciar em zero, se inicie em 1.

<p><b> Formatando Valores Monetários:</b></p>

<p> Para formatarmos valores como moeda utilizamos os seguintes elementos:

```C#
double valorMonetario = 1580.40M;

Console.WriteLine($"{valorMonetario:C}");
```

<p> No exemplo acima, após o valor informado temos a letra M, isso se faz necessário sempre que temos uma variável do tipo double, a letra C que está dentro das chaves, após a varipavel, está informando para o sistema que se trata de valor monetário e o sistema ira utilizar a moeda local, ao qual o sistema da máquina está configurado. A saída para o código acima seria:

```C#
R$ 1.580,40
```

