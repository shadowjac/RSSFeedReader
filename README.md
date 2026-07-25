RSSFeedReader
===============

A minimal RSS reader reference project demonstrating a .NET backend and a Blazor frontend.

Project layout
-------------

- backend/: .NET Web API project (backend/src)
- frontend/: Blazor WebAssembly / Blazor hybrid frontend (frontend/src)
- specs/: specification, plan, tasks and checklists for the 001-mvp-rss-reader feature

Tech stack
----------

- .NET 10 (net10.0)
- C# (ASP.NET Web API for backend, Blazor for frontend)

Prerequisites
-------------

- .NET 10 SDK (dotnet) installed and on PATH
- Git (recommended)

Quick start
-----------

1) Restore & build everything

```bash
dotnet restore
dotnet build
```

2) Run the backend

```bash
cd backend/src
dotnet run
```

The backend exposes the subscriptions API at https://localhost:7283/api/subscriptions (port may vary in your environment).

3) Run the frontend

```bash
cd frontend/src
dotnet run
```

The frontend will start and connect to the backend when configured to do so (see `frontend/src/Properties/launchSettings.json`).

API examples
------------

List subscriptions (GET):

```bash
curl -k -s https://localhost:7283/api/subscriptions
```

Add a subscription (POST):

```bash
curl -k -s -X POST https://localhost:7283/api/subscriptions \
	-H 'Content-Type: application/json' \
	-d '{"url":"https://example.com/feed"}'
```

Tests
-----

Run unit tests for the backend:

```bash
cd backend/tests
dotnet test
```

Where to find important files
-----------------------------

- Backend project: [backend/src](backend/src)
- Frontend project: [frontend/src](frontend/src)
- API controller for subscriptions: [backend/src/Controllers/SubscriptionsController.cs](backend/src/Controllers/SubscriptionsController.cs)
- Subscription model: [backend/src/Models/Subscription.cs](backend/src/Models/Subscription.cs)
- Backend service implementation: [backend/src/Services/SubscriptionService.cs](backend/src/Services/SubscriptionService.cs)
- Tests: [backend/tests](backend/tests)
- Feature spec and tasks: [specs/001-mvp-rss-reader](specs/001-mvp-rss-reader)

Contributing
------------

Contributions are welcome. Please open issues or pull requests and follow the existing code style.

License
-------

See the repository license if present. If none is present, ask the maintainers to add one.

Notes
-----

- This README is intentionally minimal — use `specs/001-mvp-rss-reader` for design details, tasks, and checklists.
