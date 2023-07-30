# API-Pagamentos

Essa API foi desenvolvida para realizar um teste prático em .NET 7, a ideia é que por ela seja autorizado as transações de pagamentos online.

## Tecnologias Utilizadas

* .NET 7


## Configuração

1. Clone o repositório:

```
git clone https://github.com/theus26/API-Payaments
```

2. Acesse o diretório do projeto:

```
cd seu-repositorio
```

3. Execute os seguintes comandos para restaurar as dependências e iniciar a API:

```
dotnet restore
dotnet run
```

4. Acesse a API em http://localhost:porta, onde "porta" é a porta configurada para a sua API.

## Funcionalidades

A API tem por funcionalidade validar o pagamento, e retorna se o pagamento foi ACEITO ou REJEITADO.

ela por sua vez, sera consumida por outra API, então verifique a porta para chamar o endereço correto na outra API.


Exemplo:

* `POST /api/Payament/compras`: Valida Compras do usuario.




