// Este é o arquivo principal do programa, que demonstra conceitos de Programação Orientada a Objetos (POO) em C#,
// especificamente abstração, encapsulamento, herança e classes abstratas.
// Ele serve como um exemplo prático para ilustrar como esses conceitos são aplicados em código.
// O programa cria instâncias de classes, chama métodos e exibe resultados no console.
// Isso ajuda a entender como as classes interagem e como os princípios de POO promovem código organizado e reutilizável.

// Importa o namespace 'AbstracaoEncapsulamento.models', que contém as classes definidas no projeto.
// Isso permite o uso das classes Pessoa, ContaCorrente, Aluno, Professor, Conta e Corrente sem precisar do nome completo.
using AbstracaoEncapsulamento.Interfaces;
using AbstracaoEncapsulamento.models;

// Inicia a seção de demonstração de Abstração.
// Abstração em POO significa focar nos aspectos essenciais de um objeto, ignorando detalhes irrelevantes.
// Aqui, a classe Pessoa abstrai o conceito de uma pessoa com nome e idade, permitindo criar objetos sem se preocupar com implementação interna.
Console.WriteLine("---------------------------------------Abstração---------------------------------------");

// Cria uma instância da classe Pessoa chamada 'p1', passando "Lucas" como parâmetro para o construtor.
// Isso demonstra como a abstração permite criar objetos facilmente, fornecendo apenas informações essenciais.
// O construtor com parâmetro define o nome, enquanto outros atributos podem ser definidos separadamente.
Pessoa p1 = new Pessoa("Lucas");

// Define a idade da pessoa 'p1' para 20.
// Isso mostra como propriedades públicas permitem acesso direto aos atributos, parte da abstração.
p1.Idade = 20;

// Chama o método Apresentar() da pessoa 'p1', que exibe uma mensagem no console.
// Esse método abstrai o comportamento de apresentação, encapsulando a lógica de exibição.
// Como é virtual, pode ser sobrescrito em subclasses para comportamentos específicos.
p1.Apresentar();

// Inicia a seção de demonstração de Encapsulamento.
// Encapsulamento protege os dados internos de uma classe, controlando o acesso através de métodos.
// Aqui, a classe ContaCorrente encapsula o saldo, permitindo operações controladas como saque.
Console.WriteLine("---------------------------------------Encapsulamento---------------------------------------");

// Cria uma instância de ContaCorrente chamada 'c1', com número da conta 123 e saldo inicial de 1000.
// O construtor inicializa os atributos, e o saldo é privado, acessível apenas através de métodos públicos.
// Isso demonstra encapsulamento, pois o saldo não pode ser alterado diretamente fora da classe.
ContaCorrente c1 = new ContaCorrente(123, 1000);

// Chama ExibirSaldo() para mostrar o saldo atual da conta 'c1'.
// Esse método encapsula a lógica de exibição, protegendo o acesso direto ao saldo.
c1.ExibirSaldo();

// Chama Sacar(500) para tentar sacar 500 da conta 'c1'.
// O método verifica se há saldo suficiente (encapsulamento), realiza a operação se possível, e atualiza o saldo internamente.
// Isso previne acesso não autorizado ao saldo, mantendo a integridade dos dados.
c1.Sacar(500);

// Exibe o saldo novamente após o saque, mostrando como o encapsulamento mantém o estado consistente.
c1.ExibirSaldo();

// Inicia a seção de demonstração de Herança.
// Herança permite que uma classe (subclasse) herde atributos e métodos de outra (superclasse).
// Aqui, Aluno e Professor herdam de Pessoa, adicionando comportamentos específicos e sobrescrevendo métodos.
Console.WriteLine("---------------------------------------Herança---------------------------------------");

// Cria uma instância de Aluno chamada 'a1', passando "Lucas" para o construtor.
// Como Aluno herda de Pessoa, ele tem acesso aos atributos Nome e Idade, além de Nota.
// O construtor chama o construtor base de Pessoa, demonstrando herança de construtores.
Aluno a1 = new Aluno("Lucas");

// Define a idade de 'a1' para 18.
// Herança permite reutilizar propriedades da classe base.
a1.Idade = 18;

// Define a nota de 'a1' para 8.5.
// Essa propriedade é específica de Aluno, adicionada através de herança.
a1.Nota = 8.5;

// Chama Apresentar() de 'a1', que é sobrescrito em Aluno para incluir a nota.
// Isso mostra polimorfismo: o mesmo método se comporta diferentemente em subclasses.
a1.Apresentar();

// Cria outra instância de Aluno 'a2' usando o construtor padrão (sem parâmetros).
// Isso permite definir atributos manualmente, mostrando flexibilidade.
Aluno a2 = new Aluno();

// Define nome, idade e nota de 'a2'.
a2.Nome = "Maria";
a2.Idade = 17;
a2.Nota = 0;

// Chama Apresentar() para 'a2', exibindo os detalhes.
a2.Apresentar();

// Cria uma instância de Professor 'prof1' com nome "Carlos".
// Professor herda de Pessoa, então tem Nome e Idade, além de Salario.
Professor prof1 = new Professor("Carlos");

// Define idade e salário de 'prof1'.
prof1.Idade = 40;
prof1.Salario = 2000;

// Chama Apresentar() de 'prof1', sobrescrito para incluir salário.
prof1.Apresentar();

// Cria 'prof2' com construtor padrão e define atributos manualmente.
//Professor prof2 = new Professor();
//prof2.Nome = "Ana";
//prof2.Idade = 35;
//prof2.Salario = 1500;

// Chama Apresentar() para 'prof2'.
//prof2.Apresentar();

// Inicia a seção de demonstração de Classe Abstrata Prática.
// Classes abstratas definem métodos que devem ser implementados por subclasses, promovendo abstração.
// Conta é abstrata, com Creditar() abstrato, implementado em Corrente.
Console.WriteLine("---------------------------------------Classe Abstrata Prática---------------------------------------");

// Cria uma instância de Corrente (que herda de Conta) referenciada como Conta 'c'.
// Isso demonstra polimorfismo: 'c' é do tipo Conta, mas aponta para Corrente.
// Permite usar métodos da classe base, mas com implementação específica da subclasse.
Conta c = new Corrente();

// Chama Creditar(500) em 'c', que adiciona 500 ao saldo.
// Como Creditar é abstrato em Conta, a implementação em Corrente é usada.
// Isso mostra como classes abstratas forçam implementação em subclasses.
c.Creditar(500);

// Exibe o saldo após o crédito, mostrando o efeito da operação.
c.ExibirSaldo();

Console.WriteLine("---------------------------------------Interfaces---------------------------------------");
Icalculadora calc = new Calculadora();
Console.WriteLine(calc.multiplicar(2, 6));