﻿using System.Linq;

namespace Blog.Core.Models.Templating
{
    public class PostFeedDto
    {
        public IQueryable<string> Posts;
    }
}