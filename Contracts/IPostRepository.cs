using BrandOneCodingSession.Entities;

namespace BrandOneCodingSession.Contracts
{
    public interface IPostRepository
    {
        Task CreateNewPost(Post post);    
    }
}
