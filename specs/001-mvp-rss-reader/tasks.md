# Tasks: MVP RSS Reader

**Input**: Design documents from `/specs/001-mvp-rss-reader/`

**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

**Organization**: Tasks are grouped by user story so each story can be implemented and validated independently.

## Format: `[ID] [P?] [Story] Description`

- **[P]**: Can run in parallel (different files, no dependencies)
- **[Story]**: Which user story this task belongs to (US1 or US2)
- Include exact file paths in descriptions

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [ ] T001 Create the backend project structure under backend/src/ and backend/tests/
- [ ] T002 Create the frontend project structure under frontend/src/ and frontend/tests/
- [ ] T003 [P] Configure local API and frontend ports and enable CORS in backend/src/Program.cs
- [ ] T004 [P] Verify routing and remove default template demo pages from frontend/src/Pages/ and frontend/src/Shared/

**Checkpoint**: The app shell is ready for the MVP backend and frontend work.

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that must be complete before user story work can begin

- [ ] T005 Create the Subscription model in backend/src/Models/Subscription.cs
- [ ] T006 Create in-memory subscription storage in backend/src/Services/SubscriptionService.cs
- [ ] T007 Implement backend create/list subscription operations in backend/src/Controllers/SubscriptionsController.cs
- [ ] T008 Add URL validation and clear error handling in backend/src/Services/SubscriptionService.cs
- [ ] T009 Create the frontend API client in frontend/src/Services/SubscriptionService.cs
- [ ] T010 Configure frontend API base URL wiring in frontend/src/Program.cs

**Checkpoint**: The backend and frontend can now support subscription management end to end.

---

## Phase 3: User Story 1 - Add a feed subscription (Priority: P1) 🎯 MVP

**Goal**: Allow a user to enter a feed URL and add it to the current session subscription list.

**Independent Test**: A user can open the app, enter a valid URL, submit it, and see the subscription appear in the visible list.

### Implementation for User Story 1

- [ ] T011 [P] [US1] Implement the add-subscription form UI in frontend/src/Pages/Subscriptions.razor
- [ ] T012 [US1] Wire form submission to the backend create endpoint in frontend/src/Pages/Subscriptions.razor
- [ ] T013 [US1] Show validation and success feedback for empty or malformed input in frontend/src/Pages/Subscriptions.razor

**Checkpoint**: User Story 1 is fully functional and independently testable.

---

## Phase 4: User Story 2 - Review the current subscriptions list (Priority: P2)

**Goal**: Let a user view the subscriptions they have already added during the current session.

**Independent Test**: A user can open the app, add one or more subscriptions, and clearly see the list of subscriptions that have been captured.

### Implementation for User Story 2

- [ ] T014 [P] [US2] Load existing subscriptions from the backend on page load in frontend/src/Pages/Subscriptions.razor
- [ ] T015 [US2] Render the current subscriptions list in frontend/src/Pages/Subscriptions.razor
- [ ] T016 [US2] Refresh the visible list immediately after a new subscription is added in frontend/src/Pages/Subscriptions.razor

**Checkpoint**: User Story 2 is fully functional and independently testable.

---

## Phase 5: Polish & Cross-Cutting Concerns

**Purpose**: Improvements that affect the whole MVP experience

- [ ] T017 Review the implementation to ensure it stays within MVP scope and does not introduce feed-fetching behavior
- [ ] T018 Manually validate that a valid URL is added and appears in the list end to end
- [ ] T019 Manually validate that malformed input is rejected with a clear message

---

## Dependencies & Execution Order

### Phase Dependencies

- **Setup (Phase 1)**: No dependencies
- **Foundational (Phase 2)**: Depends on Setup completion and blocks all story work
- **User Stories (Phases 3-4)**: Depend on Foundational completion
- **Polish (Phase 5)**: Depends on the story work being complete

### User Story Dependencies

- **User Story 1 (P1)**: Can start after Foundational and does not depend on User Story 2
- **User Story 2 (P2)**: Can start after Foundational and should be independently testable

### Parallel Opportunities

- Setup tasks T003 and T004 can run in parallel
- Story tasks T011 and T014 can be worked on in parallel if the team has capacity
- The implementation and validation tasks in Phase 5 can be completed after both stories are done

---

## Implementation Strategy

### MVP First

1. Complete Phase 1 and Phase 2
2. Implement User Story 1 and validate it independently
3. Implement User Story 2 and validate it independently
4. Finish the polish and validation tasks

### Incremental Delivery

1. Add backend storage and API support
2. Add the ability to submit a new subscription
3. Add the ability to review the existing subscription list
4. Validate the flow manually and keep the scope limited to the MVP
