# DotaInsightAPI

DotaInsightAPI is an ASP.NET Core Web API for Dota 2 meta analytics.

The MVP focuses on:

- counter pick recommendations against a selected enemy hero;
- synergy recommendations for a selected allied hero;
- importing public match data from OpenDota;
- storing raw and normalized match data in PostgreSQL;
- calculating aggregate scores for fast API reads.

## Planned Structure

The project is planned as a small multi-project backend solution:

- `Api` - HTTP endpoints, Swagger/OpenAPI, request/response contracts.
- `Application` - use cases and application services.
- `Domain` - scoring rules and core analytics logic.
- `Infrastructure` - EF Core, PostgreSQL, OpenDota client, background jobs.
- `Tests` - unit and integration tests.

## MVP API

Planned endpoints:

- `GET /api/heroes`
- `GET /api/heroes/{heroId}/counters?limit=10`
- `GET /api/heroes/{heroId}/synergies?limit=10`
- `POST /api/import/matches/run`

Authentication, frontend, role/lane analytics, and full draft analysis are out of scope for the first MVP.
