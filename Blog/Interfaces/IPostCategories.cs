﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interfaces
{
    public interface IPostCategories
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
