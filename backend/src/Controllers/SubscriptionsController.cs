using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Backend.Models;
using RSSFeedReader.Backend.Services;

namespace RSSFeedReader.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionService _subscriptionService = new();

    [HttpGet]
    public ActionResult<IReadOnlyList<Subscription>> Get()
    {
        return Ok(_subscriptionService.GetSubscriptions());
    }

    [HttpPost]
    public ActionResult<Subscription> Post([FromBody] SubscriptionRequest request)
    {
        try
        {
            var created = _subscriptionService.AddSubscription(request.Url);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}

public class SubscriptionRequest
{
    public string Url { get; set; } = string.Empty;
}
