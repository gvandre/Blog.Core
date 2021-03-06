﻿using Blog.Core.Caching.Caching;
using Blog.Core.DAL.Posts;
using Blog.Core.Metadata;

namespace Blog.Core.Utils
{
    public class InitialStateCreator
    {
        private readonly IPostCache _cache;
        private readonly IPostStore _store;
        private readonly IMetadataProcessor _metadata;

        public InitialStateCreator(IPostCache cache, IPostStore store, IMetadataProcessor metadata)
        {
            _cache = cache;
            _store = store;
            _metadata = metadata;
        }

        // BAD
        public async void Init()
        {
            var posts = _store.GetAllPostsWithNames();
            var postsWithMeta =  await _metadata.GetMetadataForPosts(posts);
            _cache.Store(postsWithMeta);
        }
    }
}