using System;
namespace Api.Entities
{
    // record types are like classes
    // but used for immutable objects
    public record Item
    {
        // get/set(private)
        // init allows for setting of value only during initialization
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreateDate { get; init; }
    }
}
