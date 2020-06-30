﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Interfaces
{
    interface IAllPosts
    {
        IEnumerable<Post> Posts { get; }

        Post GetObjectPost(int postId);

        IEnumerable<Post> GetPostByTags(IEnumerable<string> Tags);
    }
}
