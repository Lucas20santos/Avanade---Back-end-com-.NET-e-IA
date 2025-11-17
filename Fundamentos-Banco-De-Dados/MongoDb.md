# Banco de Dados não relacional

**Banco de dados não relacional:** Banco de dados onde os dados não são armazenados em tabela, e sim em armazenados de maniera não estruturadas ou semi-estruturadas.

## Json

- Semi estruturado
- MongoDb ou Atlas: banco de dados semi estruturado orientado a documentos.

## Comandos para usar o banco de dados, inserir e procurar dados

```js
    use('test');

    db.sales.insertOne({ item: 'test', price: 10 })
    db.sales.insertOne({ item: 'test2', price: 11 })
    db.sales.insertOne({ item: 'test3', price: 12})

    db.sales.find({item: 'test3'})
```
