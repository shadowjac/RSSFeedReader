# Research: MVP RSS Reader

## Decision: Use an ASP.NET Core Web API backend and a Blazor WebAssembly frontend for the MVP.

**Rationale**: The project stakeholders explicitly selected this stack, and it supports the requested MVP scope while remaining suitable for future enhancements. The backend can manage in-memory subscription state and expose simple API endpoints, while the frontend can present a focused subscription UI without introducing unnecessary complexity.

## Decision: Keep the MVP limited to add-and-list subscriptions only.

**Rationale**: The project goals explicitly define the MVP as a proof-of-concept focused on subscription management. Deferring fetching, parsing, persistence, and removal keeps the first release small, fast to build, and easier to verify.

## Decision: Use basic input validation for feed URLs and clear user feedback.

**Rationale**: The specification requires malformed input to be rejected rather than silently accepted. A simple validation rule and a visible error message are sufficient for the MVP and align with the constitution’s security and maintainability principles.

## Alternatives considered

- Adding feed fetching and parsing in the MVP: rejected because it would expand scope beyond the stated proof-of-concept goals.
- Building a single-page app without a backend: rejected because the provided stack and architecture guidance call for a simple API/frontend split with clear separation of concerns.
- Implementing persistence immediately: rejected because the MVP is explicitly in-memory and local-only.
