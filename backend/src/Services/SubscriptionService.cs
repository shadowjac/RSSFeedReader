using System.Collections.ObjectModel;
using RSSFeedReader.Backend.Models;

namespace RSSFeedReader.Backend.Services;

public class SubscriptionService
{
    private readonly List<Subscription> _subscriptions = [];

    public Subscription AddSubscription(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            throw new ArgumentException("Subscription URL must be a valid absolute URL.", nameof(url));
        }

        if (!Uri.TryCreate(url, UriKind.Absolute, out var parsedUri) ||
            (parsedUri.Scheme != Uri.UriSchemeHttp && parsedUri.Scheme != Uri.UriSchemeHttps))
        {
            throw new ArgumentException("Subscription URL must be a valid absolute URL.", nameof(url));
        }

        if (_subscriptions.Any(subscription => string.Equals(subscription.Url, url, StringComparison.OrdinalIgnoreCase)))
        {
            throw new ArgumentException("A subscription with this URL already exists.", nameof(url));
        }

        var subscription = new Subscription
        {
            Url = parsedUri.ToString()
        };

        _subscriptions.Add(subscription);
        return subscription;
    }

    public IReadOnlyList<Subscription> GetSubscriptions()
    {
        return new ReadOnlyCollection<Subscription>(_subscriptions);
    }
}
