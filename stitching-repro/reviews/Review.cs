using System;

namespace Demo.Reviews
{
    public record Review(int Id, int AuthorId, int Upc, string Body, int NumberOfStars);
}