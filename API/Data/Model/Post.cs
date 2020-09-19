using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace API.Data.Model
{
    public class Post : Base
    {
        public ICollection<Comment> Comments { get; set; }
    }
}
