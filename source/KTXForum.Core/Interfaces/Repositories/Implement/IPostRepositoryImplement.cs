using System;
using System.Collections.Generic;
using System.Linq;
using KTXForum.Core.Interfaces;
using KTXForum.Core.Models.Forum;

namespace KTXForum.Core.Interfaces.Repositories.Implement
{
    public class IPostRepositoryImplement : IPostRepository
    {
        // Simple in-memory store for the implementation.
        private readonly List<Post> _posts = new();

        public List<Post> GetAll()
        {
            // return a copy to protect internal list
            return new List<Post>(_posts);
        }

        public Post GetById(int id)
        {
            return _posts.Find(p => p.postId == id);
        }

        public void Add(Post post)
        {
            if (post == null) throw new ArgumentNullException(nameof(post));

            if (post.postId == 0)
            {
                var nextId = _posts.Count == 0 ? 1 : _posts.Max(p => p.postId) + 1;
                post.postId = nextId;
            }

            _posts.Add(post);
        }

        public void Update(Post post)
        {
            if (post == null) throw new ArgumentNullException(nameof(post));

            var existing = _posts.Find(p => p.postId == post.postId);
            if (existing == null) throw new KeyNotFoundException($"Post with id {post.postId} not found.");

            var idx = _posts.IndexOf(existing);
            _posts[idx] = post;
        }

        public void Delete(int id)
        {
            var existing = _posts.Find(p => p.postId == id);
            if (existing != null)
            {
                _posts.Remove(existing);
            }
        }
    }
}
