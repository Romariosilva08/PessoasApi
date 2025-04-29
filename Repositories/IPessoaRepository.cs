using PessoasApi.Models;

namespace PessoasApi.Repositories;

public interface IPessoaRepository
{
    PagedList<Pessoa> GetPessoas(int pageNumber, int pageSize, string? filtroNome = null);
}
