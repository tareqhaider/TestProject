using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.DTO
{
    public class CommentDto
    {
        public string Description { get; set; }

        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
    }
}
