using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sales.Catalogo.Domain;
using Sales.Core.Data;

namespace Sales.Catalogo.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly CatalogoContext _context;

        public ProdutoRepository(CatalogoContext context)
        {
            this._context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public Task<IEnumerable<Categoria>> ObterCategorias()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}