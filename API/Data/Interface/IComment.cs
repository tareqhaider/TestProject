using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.DTO;
using API.Data.Model;

namespace API.Data.Interface
{
    public interface IComment
    {
        Task<Comment> CreateCommentAsync(CommentDto commentDto);
        Task<ICollection<Comment>> GetAllCommentsAsync();
        Task<Comment> GetCommentIdAsync(int id);
        Task<Comment> UpdateCommentAsync(CommentDto commentDto);
        Task<Comment> DeleteCommentAsync(CommentDto commentDto);
        bool SaveChanges();

    }
}
