using BrandOneCodingSession.Contracts;
using BrandOneCodingSession.Entities;
using BrandOneCodingSession.Infrasatructure;

namespace BrandOneCodingSession.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;
        public async Task CreateNewPost(Post post)
        {
           await _context.Posts.AddAsync(post);
            _context.SaveChanges();
        }
    }
}
