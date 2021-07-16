# Teste Signa - Gerenciamento de pessoas

Este é o meu teste fullstack para a empresa signa.

## Súmario

- [Overview](#overview)
  - [Desafio](#Desafio)
  - [Screenshot](#screenshot)
- [Desenvolvimento](#desenvolvimento)
  - [Contruido-com](#Contruido-com)
  - [Continuar-Desenvolvimento](#Continuar-Desenvolvimento)



## Overview

### Desafio

- Pede-se a criação de um aplicativo para consultar informações de uma base de dados Sql-Server ou My SQL.
- Não é exigido nenhum layout pré-definido.
- Pode-se optar pelo tipo de aplicativo (Web, Windows Form, etc.)
- Criar uma tabela de nome PESSOA com
    - PESSOA_ID 		INT (pk)
    - NOME_FANTASIA 	VARCHAR(255)
    - CNPJ_CPF 		VARCHAR(20)
- Crie 10 registros fictícios nessa tabela via banco de dados (com informações diferentes).
- Pede-se que seja desenvolvida uma tela com o título “CONSULTA DE NOME FANTASIA”, com os seguintes objetos:
- Um botão “MONTAR LISTA”, que após a tela inicial estar carregada, terá a função de mostrar o nome fantasia de pessoas existentes na tabela “PESSOA”,
- Uma lista montada após o clique do botão “MONTAR LISTA”, onde serão apresentados os registros exibindo a coluna NOME_FANTASIA.
- Um botão “LIMPAR” que após a lista estar preenchida terá a função de apagar os nomes apresentados.
- Uma navegação da linha da lista para a tela de “DETALHE”.
- Criar uma tela de detalhe que mostrará os detalhes do registro selecionado na tela anterior, exibindo os seguintes campos:
  - “Código” = Pessoa_id,
  - “Nome Fantasia” = nome_fantasia,
  - “CNPJ/CPF” = CNPJ_CPF
- Nessa tela de detalhe poderá ser alterado o nome da pessoa somente e deve ter o botão GRAVAR onde irá efetivar a alteração.
- As telas devem possuir um botão Sair/Voltar prevendo a navegação dos mesmos.


### Screenshot

Aqui esta minha aplicação

![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/TELA_INICIAL.png?raw=true)
![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/Lista_Montada.png?raw=true)
![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/Selecionando_Item.png?raw=true)
![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/Detalhes_do_Item.png?raw=true)
![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/Alterando_nome.png?raw=true)
![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/BotaoVoltar.png?raw=true)
![](https://github.com/SDEduardo/testepratico-signa/blob/main/PrintsProjeto/TelaAoVoltar.png?raw=true)


## Desenvolvimento
Comecei criando o banco de dados, depois criei a tabela pessoa, uitilizei auto_increment para facilitar a manutenção dos ids, criei o backend em .net=core criando api. criei a conexao com o banco com o dapper, criei os endpoints de inserção, atualizacao e select nas normas de HTTP REQUEST.
E integrei o backend com o front utilizando html - css - js puro.
Utilizei o postman como tester de endpoint.

### Contruido-com

- Marcações semânticas HTMl
- CSS 3
- Flexbox
- net-core (dapper como conector)
- Mysql


### Continuar-Desenvolvimento

Migrar o front para vue ou react, no backend separar as camadas de model - entity - controller - Business logic,


## Project setup
```
Rodar o banco de dados
```

```
Start na api
```

```
Abrir o frontend (montarlista.html)
```

