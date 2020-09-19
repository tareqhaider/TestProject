using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.DTO;
using API.Data.Interface;
using API.Data.Model;

namespace API.Data.Repository
{
    public class PostRepository:IPost
    {
        private readonly IPost _context;

        public PostRepository(IPost context)
        {
            _context = context;
        }

        public async Task<Post> CreatePostAsync(PostDto postDto)
        {
            if (postDto == null)
            {
                throw new ArgumentNullException(nameof(postDto));
            }
            return await _context.CreatePostAsync(postDto);
        }

        public async Task<ICollection<Post>> GetAllPostsAsync()
        {
            return await _context.GetAllPostsAsync();
        }

        public async Task<Post> GetPostIdAsync(int id)
        {
            return await _context.GetPostIdAsync(id);
        }

        public async Task<Post> UpdatePostAsync(PostDto postDto)
        {
            return await _context.UpdatePostAsync(postDto);
        }

        public async Task<Post> DeletePostAsync(PostDto postDto)
        {
            return await _context.DeletePostAsync(postDto);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
