using System;
using System.Threading.Tasks;
using Sales.Core.Bus;
using Sales.Core.DomainObjects;

namespace Sales.Catalogo.Domain
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IMediatrHandler _bus;
        private readonly IProdutoRepository _produtoRepository;

        public EstoqueService(IMediatrHandler bus, IProdutoRepository produtoRepository)
        {
            this._bus = bus;
            this._produtoRepository = produtoRepository;
        }
        public async Task<bool> DebitarEstoque(Guid produtoId, int quantidade)
        {
            var produto = await _produtoRepository.ObterPorId(produtoId);

            if (produto == null) return false;

            if (!produto.PossuiEstoque(quantidade)) return false;

            produto.DebitarEstoque(quantidade);

            if (produto.QuantidadeEstoque < 10)
            {
                await _bus.PublicarEvento(new ProdutoAbaixoEstoqueEvent(produto.Id, produto.QuantidadeEstoque));
            }

            _produtoRepository.Atualizar(produto);
            return await _produtoRepository.UnitOfWork.Commit();
        }

        public Task<bool> ReporEstoque(Guid produtoId, int quantidade)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}