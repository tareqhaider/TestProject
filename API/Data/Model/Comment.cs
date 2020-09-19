using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Model
{
    public class Comment : Base
    {
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public Post Post { get; set; }
        public int PostId { get; set; }

    }
}
