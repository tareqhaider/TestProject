using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.DTO;
using API.Data.Model;

namespace API.Data.Interface
{
    public interface IPost
    {
        Task<Post> CreatePostAsync(PostDto postDto);
        Task<ICollection<Post>> GetAllPostsAsync();
        Task<Post> GetPostIdAsync(int id);
        Task<Post> UpdatePostAsync(PostDto postDto);
        Task<Post> DeletePostAsync(PostDto postDto);
        bool SaveChanges();
    }
}
