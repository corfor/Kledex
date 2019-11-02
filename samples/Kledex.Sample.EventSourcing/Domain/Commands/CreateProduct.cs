﻿using Kledex.Domain;

namespace Kledex.Sample.EventSourcing.Domain.Commands
{
    public class CreateProduct : DomainCommand<Product, bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
