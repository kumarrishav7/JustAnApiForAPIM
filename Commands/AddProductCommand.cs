using MediatR;

namespace JustAnApiForAPIMIntegration.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
