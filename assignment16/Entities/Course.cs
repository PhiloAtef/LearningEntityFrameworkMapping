﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment16.Entities
{
    internal class Course
    {
        public int Id { get; set; }

        public int Duration { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
    }
}
