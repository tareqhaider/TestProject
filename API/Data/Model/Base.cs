﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Model
{
    public class Base
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;

    }
}
