using System;
using System.Collections.Generic;

namespace Demo.Products
{
    public record Product(int Upc, string Name, int Price, int Size, IEnumerable<string> Images);
}