# Repository Patter e Unit of Work
Pequeno projeto prático utilizando tais patterns. 

## Repository Pattern
Padrão de projeto que visa isolar a camada de acesso a dados, da camada de negócios. Encapsulando lógica de acesso a dados em um só lugar, impulsionando o
uso da Injeçao de Dependencia.

## Unit of Work
Utilizamos o Unit of Work quando necessário fazer transações de dados. Ou seja, quando precisamos que vários dados sejam persistidos no banco. Na demo, temos a model Order e o Customer, dentro da nossa regra de negócio uma Order pertence obrigatóriamente a um Customer, então não podemos ter Order salva sem Customer. Implementamos a Interface UnitOfWork para suprir essa demanda.

