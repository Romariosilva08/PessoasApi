using PessoasApi.Models;

namespace PessoasApi.Services;

public interface IPessoaService
{
    PagedList<Pessoa> ObterPessoas(int pageNumber, int pageSize, string? filtroNome = null);

}
