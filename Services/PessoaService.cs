using PessoasApi.Models;
using PessoasApi.Repositories;

namespace PessoasApi.Services;

public class PessoaService : IPessoaService
{
    private readonly IPessoaRepository _pessoaRepository;

    public PessoaService(IPessoaRepository pessoaRepository)
    {
        _pessoaRepository = pessoaRepository;
    }

    public PagedList<Pessoa> ObterPessoas(int pageNumber, int pageSize, string? filtroNome = null)
    {
        return _pessoaRepository.GetPessoas(pageNumber, pageSize, filtroNome);
    }
}
