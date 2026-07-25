# Subscription API Contract

## Endpoints

### POST /api/subscriptions
Adds a new subscription to the current in-memory list.

**Request Body**
```json
{
  "url": "https://example.com/feed"
}
```

**Responses**
- 200 OK: returns the created subscription
- 400 Bad Request: returns an error when the URL is empty or malformed

### GET /api/subscriptions
Returns all subscriptions currently stored in memory.

**Responses**
- 200 OK: returns an array of subscriptions
