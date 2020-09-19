using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.DTO;
using API.Data.Interface;
using API.Data.Model;

namespace API.Data.Repository
{
    public class CommentRepository : ApplicationDbContext
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Comment> CreateCommentAsync(CommentDto commentDto)
        {
            Comment item = new Comment
            {
                UserId = commentDto.UserId,
                PostId = commentDto.PostId,
                Description = commentDto.Description
            };
            return await _context.CreateCommentAsync();
        }

        public async Task<ICollection<Comment>> GetAllCommentsAsync()
        {
            return await _context.GetAllCommentsAsync();
        }

        public async Task<Comment> GetCommentIdAsync(int id)
        {
            return await _context.GetCommentIdAsync(id);
        }

        public async Task<Comment> UpdateCommentAsync(CommentDto commentDto)
        {
            return await _context.UpdateCommentAsync(commentDto);
        }

        public async Task<Comment> DeleteCommentAsync(CommentDto commentDto)
        {
            return await _context.DeleteCommentAsync(commentDto);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
