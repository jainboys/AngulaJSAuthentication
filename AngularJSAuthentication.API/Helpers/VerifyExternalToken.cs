using AngularJSAuthentication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AngularJSAuthentication.API.Helpers
{
    public interface VerifyExternalToken
    {
        async Task<ParsedExternalAccessToken> VerifyExternalAccessToken(string provider, string accessToken);
    }
}