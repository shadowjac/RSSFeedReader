# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-mvp-rss-reader/`

## Phase 1: Setup

- [ ] T001 Create the backend project structure for the MVP under backend/src/
- [ ] T002 Create the frontend project structure for the MVP under frontend/src/
- [ ] T003 Configure local API and frontend ports and enable CORS for the backend
- [ ] T004 Verify routing and remove template demo pages if present in the frontend project

## Phase 2: Foundational

- [ ] T005 Implement the Subscription model in backend/src/Models/Subscription.cs
- [ ] T006 Implement in-memory subscription storage in backend/src/Services/SubscriptionService.cs
- [ ] T007 Implement the POST /api/subscriptions endpoint in backend/src/Controllers/SubscriptionsController.cs
- [ ] T008 Implement the GET /api/subscriptions endpoint in backend/src/Controllers/SubscriptionsController.cs
- [ ] T009 Add basic URL validation and clear error handling in the backend service layer
- [ ] T010 Add a frontend subscription service for API calls in frontend/src/Services/SubscriptionService.cs
- [ ] T011 Implement the main subscriptions page in frontend/src/Pages/Subscriptions.razor
- [ ] T012 Wire the page to the API and display the current subscription list in frontend/src/Pages/Subscriptions.razor

## Phase 3: Validation

- [ ] T013 Manually verify a valid subscription is added and displayed end to end
- [ ] T014 Manually verify malformed input is rejected with a clear message
- [ ] T015 Review the implementation to ensure it stays within MVP scope and does not introduce feed-fetching behavior
