using MediatR;

namespace JustAnApiForAPIMIntegration.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
