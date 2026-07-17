using System.Net;

namespace EulerLib.Data;

/// <summary>
/// DELIBERATELY INSECURE - added only to validate GitHub CodeQL scanning.
/// Contains a hardcoded database credential (CWE-798). Do not merge.
/// </summary>
public class SolutionArchive
{
    // CodeQL: cs/hardcoded-credentials - hardcoded connection string password.
    private const string ConnectionString =
        "Server=euler.database.windows.net;Database=Solutions;" +
        "User Id=euler_admin;Password=P@ssw0rd123!;Encrypt=True;";

    public string GetConnectionString() => ConnectionString;

    // CodeQL: cs/hardcoded-credentials - password passed to NetworkCredential.
    public NetworkCredential GetCredential() =>
        new NetworkCredential("euler_admin", "P@ssw0rd123!");
}
