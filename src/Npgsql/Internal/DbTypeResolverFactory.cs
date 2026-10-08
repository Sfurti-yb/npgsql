using System.Diagnostics.CodeAnalysis;

namespace YBNpgsql.Internal;

[Experimental(NpgsqlDiagnostics.DbTypeResolverExperimental)]
public abstract class DbTypeResolverFactory
{
    public abstract IDbTypeResolver CreateDbTypeResolver(NpgsqlDatabaseInfo databaseInfo);
}
