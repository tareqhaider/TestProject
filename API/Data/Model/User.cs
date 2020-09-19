using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace API.Data.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //public Post Post { get; set; }
        //public int PostId { get;  set; }
        //public Comment Comment{ get; set; }
        //public int CommentId { get; set; }
    }
}
