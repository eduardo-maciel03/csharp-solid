# SOLID
Cinco princípios da programação orientada a objetos que facilitam no desenvolvimento de softwares, 
tornando-os fáceis de manter e estender. Esses princípios podem ser aplicados a qualquer linguagem de POO.

## S — Single Responsiblity Principle (Princípio da responsabilidade única)
"Uma classe deve ter um, e somente um, motivo para mudar."

Esse princípio declara que uma classe deve ser especializada em um único assunto e possuir apenas uma responsabilidade dentro do software, 
ou seja, a classe deve ter uma única tarefa ou ação para executar.

Violação do SRP pode causar:
  - Dificuldade de compreensão.
  - Dificuldade de manutenção.
  - Dificuldade de reuso.

## O — Open-Closed Principle (Princípio Aberto-Fechado)
"Softwares vão sempre evoluindo, por isso evolua seu código junto, não o substitua."

O Princípio Aberto-Fechado declara que entidades de software (classes, módulos, funções, etc.) devem estar ABERTAS para extensão, mas FECHADAS para modificação, 
ou seja, quando novos comportamentos e recursos precisam ser adicionados no software, devemos estender e não alterar o código fonte original.

## L — Liskov Substitution Principle (Princípio da substituição de Liskov)
O princípio da substituição de Liskov foi introduzido por Barbara Liskov em sua conferência “Data abstraction” em 1987. A definição formal de Liskov diz que:

"Se para cada objeto o1 do tipo S há um objeto o2 do tipo T de forma que, para todos os programas P definidos em termos de T, 
o comportamento de P é inalterado quando o1 é substituído por o2 então S é um subtipo de T."

Um exemplo mais simples e de fácil compreensão dessa definição. Seria:

"Se S é um subtipo de T, então os objetos do tipo T, em um programa, 
podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa."

Em outras palavras, define que, uma classe derivada deve ser substituível por sua classe base.

Abstrações não devem depender de detalhes, detalhes devem depender de abstrações.

Exemplos de violação do LSP:
  - Sobrescrever/implementar um método que não faz nada;
  - Lançar uma exceção inesperada;
  - Retornar valores de tipos diferentes da classe base;

## I — Interface Segregation Principle (Princípio da Segregação da Interface)
"Clientes não devem ser forçados a depender de interfaces que eles não usam."

Em outras palavras, uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar.

Esse princípio basicamente diz que é melhor criar interfaces mais específicas ao invés de termos uma única interface genérica, 
pois, interfaces que tem muitos comportamentos, geralmente se espalham pelo sistema trazendo complexidade e dificuldade de manutenção ao código.

## D — Dependency Inversion Principle (Princípio da inversão da dependência)
"Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações."

O princípio da inversão de dependência diz que devemos depender de abstrações (interfaces) ao invés de implementações (classes concretas) 
a fim de ter um menor acoplamento entre as camadas do sistema.

Embora esteja relacionado a DI (Dependency Injection) e IoC (Inversion of Control) o DIP é diferente em diversos aspectos.
DI (Dependency Injection) é uma técnica que auxilia na implementação de outro princípio de design chamado IoC. 
O DIP se relaciona diretamente com DI, pois podemos usufruir da técnica para gerar dependências (Neste caso de abstrações).

## Conclusão
A sistemática dos princípios SOLID tornam o software mais robusto, escalável e flexível, deixando-o tolerante a mudanças, 
facilitando a implementação de novos requisitos para a evolução e manutenção do sistema.
