using System;
using System.Security.Claims;

public static class IdentityEx
{
    public static int GetUserID(this ClaimsPrincipal Claim)
    {
        if (Claim == null)
        {
            throw new ArgumentNullException("Argument Null Exception");
        }
        return int.Parse(Claim.FindFirst(ClaimTypes.NameIdentifier)?.Value);
    }
}


