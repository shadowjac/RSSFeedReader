# Quickstart: MVP RSS Reader

## Prerequisites
- .NET SDK installed
- A local terminal with access to the repository

## Setup
1. Restore dependencies for the backend and frontend projects.
2. Start the API on the configured local port.
3. Start the Blazor frontend and ensure it points to the API endpoint.

## Validation Scenarios
1. Open the frontend in a browser.
2. Enter a valid feed URL and submit it.
3. Confirm the subscription appears in the list immediately.
4. Enter a malformed URL and confirm the app shows a clear validation message.
5. Refresh the UI and confirm the current session list remains available.
