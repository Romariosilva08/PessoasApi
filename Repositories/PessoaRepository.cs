using PessoasApi.Models;
using System.Linq;

namespace PessoasApi.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly List<Pessoa> _pessoas = new()
        {
            new Pessoa { Cpf = "111.111.111-11", Nome = "Ana Silva", Genero = "Feminino", Endereco = "Rua das Flores, 100", Idade = 28, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "222.222.222-22", Nome = "Carlos Oliveira", Genero = "Masculino", Endereco = "Av. Paulista, 200", Idade = 35, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "333.333.333-33", Nome = "Marina Souza", Genero = "Feminino", Endereco = "Rua XV de Novembro, 300", Idade = 22, Municipio = "Curitiba", Estado = "PR" },
            new Pessoa { Cpf = "444.444.444-44", Nome = "João Santos", Genero = "Masculino", Endereco = "Rua da Praia, 400", Idade = 40, Municipio = "Rio de Janeiro", Estado = "RJ" },
            new Pessoa { Cpf = "555.555.555-55", Nome = "Carla Costa", Genero = "Feminino", Endereco = "Av. Brasil, 500", Idade = 31, Municipio = "Belo Horizonte", Estado = "MG" },
            new Pessoa { Cpf = "666.666.666-66", Nome = "Pedro Almeida", Genero = "Masculino", Endereco = "Rua dos Pinheiros, 600", Idade = 27, Municipio = "Porto Alegre", Estado = "RS" },
            new Pessoa { Cpf = "777.777.777-77", Nome = "Fernanda Lima", Genero = "Feminino", Endereco = "Rua das Palmeiras, 700", Idade = 29, Municipio = "Salvador", Estado = "BA" },
            new Pessoa { Cpf = "888.888.888-88", Nome = "Ricardo Pereira", Genero = "Masculino", Endereco = "Av. Afonso Pena, 800", Idade = 45, Municipio = "Belo Horizonte", Estado = "MG" },
            new Pessoa { Cpf = "999.999.999-99", Nome = "Juliana Barbosa", Genero = "Feminino", Endereco = "Rua Dom Pedro II, 900", Idade = 33, Municipio = "Brasília", Estado = "DF" },
            new Pessoa { Cpf = "101.101.101-10", Nome = "Lucas Mendes", Genero = "Masculino", Endereco = "Rua Sete de Setembro, 101", Idade = 26, Municipio = "Fortaleza", Estado = "CE" },
            new Pessoa { Cpf = "202.202.202-20", Nome = "Laura Pereira", Genero = "Feminino", Endereco = "Rua do Sol, 200", Idade = 30, Municipio = "Recife", Estado = "PE" },
            new Pessoa { Cpf = "303.303.303-30", Nome = "Mateus Rodrigues", Genero = "Masculino", Endereco = "Av. do Trabalhador, 300", Idade = 27, Municipio = "Manaus", Estado = "AM" },
            new Pessoa { Cpf = "404.404.404-40", Nome = "Aline Costa", Genero = "Feminino", Endereco = "Rua das Andorinhas, 400", Idade = 34, Municipio = "Salvador", Estado = "BA" },
            new Pessoa { Cpf = "505.505.505-50", Nome = "Ricardo Ferreira", Genero = "Masculino", Endereco = "Rua da Liberdade, 500", Idade = 38, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "606.606.606-60", Nome = "Mariana Almeida", Genero = "Feminino", Endereco = "Rua da Paz, 600", Idade = 29, Municipio = "Curitiba", Estado = "PR" },
            new Pessoa { Cpf = "707.707.707-70", Nome = "Fernando Oliveira", Genero = "Masculino", Endereco = "Av. Rio Branco, 700", Idade = 41, Municipio = "Porto Alegre", Estado = "RS" },
            new Pessoa { Cpf = "808.808.808-80", Nome = "Gabriela Souza", Genero = "Feminino", Endereco = "Rua dos Três Irmãos, 800", Idade = 25, Municipio = "Belo Horizonte", Estado = "MG" },
            new Pessoa { Cpf = "909.909.909-90", Nome = "Felipe Santos", Genero = "Masculino", Endereco = "Av. do Contorno, 900", Idade = 32, Municipio = "Rio de Janeiro", Estado = "RJ" },
            new Pessoa { Cpf = "1010.1010.10-10", Nome = "Simone Barbosa", Genero = "Feminino", Endereco = "Rua Boa Vista, 1010", Idade = 39, Municipio = "Brasília", Estado = "DF" },
            new Pessoa { Cpf = "1111.1111.11-11", Nome = "Gustavo Lima", Genero = "Masculino", Endereco = "Rua São João, 1111", Idade = 29, Municipio = "Fortaleza", Estado = "CE" },
            new Pessoa { Cpf = "1212.1212.12-12", Nome = "Eliane Santos", Genero = "Feminino", Endereco = "Rua Vinte e Cinco de Março, 1212", Idade = 27, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "1313.1313.13-13", Nome = "Roberto Costa", Genero = "Masculino", Endereco = "Av. Getúlio Vargas, 1313", Idade = 33, Municipio = "Salvador", Estado = "BA" },
            new Pessoa { Cpf = "1414.1414.14-14", Nome = "Tatiane Lima", Genero = "Feminino", Endereco = "Rua das Palmeiras, 1414", Idade = 40, Municipio = "Curitiba", Estado = "PR" },
            new Pessoa { Cpf = "1515.1515.15-15", Nome = "Júlio Souza", Genero = "Masculino", Endereco = "Av. Presidente Vargas, 1515", Idade = 34, Municipio = "Porto Alegre", Estado = "RS" },
            new Pessoa { Cpf = "1616.1616.16-16", Nome = "Renata Alves", Genero = "Feminino", Endereco = "Rua São Sebastião, 1616", Idade = 28, Municipio = "Rio de Janeiro", Estado = "RJ" },
            new Pessoa { Cpf = "1717.1717.17-17", Nome = "Carlos Eduardo", Genero = "Masculino", Endereco = "Av. Beira Mar, 1717", Idade = 36, Municipio = "Belo Horizonte", Estado = "MG" },
            new Pessoa { Cpf = "1818.1818.18-18", Nome = "Ricardo Costa", Genero = "Masculino", Endereco = "Rua dos Navegantes, 1818", Idade = 29, Municipio = "São Paulo", Estado = "SP" },
            new Pessoa { Cpf = "1919.1919.19-19", Nome = "Tatiane Martins", Genero = "Feminino", Endereco = "Rua da Vitória, 1919", Idade = 25, Municipio = "Recife", Estado = "PE" },
            new Pessoa { Cpf = "2020.2020.20-20", Nome = "Fernando Silva", Genero = "Masculino", Endereco = "Rua dos Pintores, 2020", Idade = 38, Municipio = "Curitiba", Estado = "PR" },
            new Pessoa { Cpf = "2121.2121.21-21", Nome = "Mariana Costa", Genero = "Feminino", Endereco = "Av. Das Américas, 2121", Idade = 32, Municipio = "Salvador", Estado = "BA" },
           
        };


        public PagedList<Pessoa> GetPessoas(int pageNumber, int pageSize, string? filtroNome = null)
        {
            var query = _pessoas.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filtroNome))
            {
                query = query.Where(p => p.Nome.Contains(filtroNome, StringComparison.OrdinalIgnoreCase));
            }

            var totalRecords = query.Count();
            var paginatedPessoas = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PagedList<Pessoa>(paginatedPessoas, totalRecords, pageNumber, pageSize);
        }
    }
}
