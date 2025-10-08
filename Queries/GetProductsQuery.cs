using MediatR;

namespace JustAnApiForAPIMIntegration.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;

    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
