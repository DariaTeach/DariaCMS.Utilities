using System;
using System.Collections.Generic;
using System.Text;

namespace DariaCMS.Utilities.Normalizer
{
    /// <summary>
    /// Forbiden Subdomain Names
    /// </summary>
    public static class ForbiddenSubDomainName
    {
        public static List<string> DomainNames()
        {
            return new List<string>(new List<string>{
                "admin",
                "user",
                "mail",
                "password",
                "webmail",
                "api",
                "www",
                "mssql",
                "ipv4",
                "ipv6",
                "ftp",
                "lists"
            });
        }
    }
}
