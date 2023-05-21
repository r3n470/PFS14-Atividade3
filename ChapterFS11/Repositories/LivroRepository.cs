using ChapterFS11.Contexts;
using ChapterFS11.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterFS11.Repositories
{
    public class LivroRepository
    {
        private readonly Sqlcontext _context;
        public LivroRepository(Sqlcontext context)

        {
            _context = context;    
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

    }
}
