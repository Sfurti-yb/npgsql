# What we know about yugabyte/npgsql

Written by earlier upgrade sessions. Every line cost a run to discover.

Treat it as a starting point, not as fact: the tree may have moved since. If
something here is wrong, correct it -- that is worth more than the upgrade
itself, because the next session inherits whatever you leave.

Add what you learn under "Learned this run". Anything above it is already
stored; only new lines are kept.

## Learned this run

- Build with `dotnet build -c Release -p:TreatWarningsAsErrors=false` - the TreatWarningsAsErrors=false is needed because upstream dependencies have NuGet security vulnerabilities
- Test with `dotnet test -c Release -f net8.0 test/Npgsql.Tests` for all tests
- YugabyteDB-specific tests can be run with filter `--filter FullyQualifiedName~YB`
- .NET 10.0 SDK is available and the project targets both net8.0 and net10.0
- New files added in v10.0.3 need namespace changes from Npgsql to YBNpgsql and NpgsqlTypes to YBNpgsqlTypes
- The NpgsqlDataSource constructor gained a new `reportMetrics` parameter in v10.0.3 - pass `true` for data sources
- NUnit assertion style changed - use `Assert.That(actual, Is.EqualTo(expected))` instead of `Assert.AreEqual(expected, actual)`
- The PublicAPI.Shipped.txt and PublicAPI.Unshipped.txt files need mass namespace replacement from Npgsql to YBNpgsql
- The default port in PublicAPI.Shipped.txt should be 5433 for YugabyteDB, not 5432
