using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Reviews
{
    public class ReviewRepository
    {
        private readonly Dictionary<int, Review> _reviews;

        public ReviewRepository()
        {
            _reviews = new Review[]
            {
                new Review(1, 1, 1, "Love it!",5),
                new Review(2, 1, 2, "Too expensive.",1),
                new Review(3, 2, 3, "Could be better.",3),
                new Review(4, 2, 1, "Prefer something else.",1)
            }.ToDictionary(t => t.Id);
        }

        public IEnumerable<Review> GetReviews() =>
            _reviews.Values.OrderBy(t => t.Id);

        public IEnumerable<Review> GetReviewsByProductId(int upc) =>
            _reviews.Values.OrderBy(t => t.Id).Where(t => t.Upc == upc);

        public IEnumerable<Review> GetReviewsByAuthorId(int authorId) =>
            _reviews.Values.OrderBy(t => t.Id).Where(t => t.AuthorId == authorId);

        public Review GetReview(int id) => _reviews[id];
    }
}