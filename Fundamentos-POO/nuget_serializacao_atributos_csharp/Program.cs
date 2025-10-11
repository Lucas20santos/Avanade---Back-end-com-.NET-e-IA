using nuget_serializacao_atributo_csharp.Models;
using Newtonsoft.Json;

List<Pessoa> listaPessoa = new List<Pessoa>();

Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Sobrenome = "Santos";
p1.idade = 33;
p1.apresentar();

Pessoa p2 = new()
{
    Nome = "Maria",
    Sobrenome = "Santos",
    idade = 34
};

listaPessoa.Add(p1);
listaPessoa.Add(p2);

string serializacao = JsonConvert.SerializeObject(listaPessoa, Formatting.Indented);
File.WriteAllText("lista_pessoa.json", serializacao);
