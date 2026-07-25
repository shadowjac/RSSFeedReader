# Data Model: MVP RSS Reader

## Entities

### Subscription

Represents a feed the user wants to follow.

**Fields**
- Id: unique identifier for the subscription
- Url: the feed URL entered by the user
- CreatedAt: timestamp for when the subscription was added

**Validation Rules**
- Url must be present and must be a syntactically valid absolute URL
- Duplicate subscriptions should be prevented in the current session

**Relationships**
- A single user can have multiple subscriptions in the current session
