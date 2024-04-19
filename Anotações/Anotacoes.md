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
Módulo Finalizado!