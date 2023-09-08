namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{

    
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

}