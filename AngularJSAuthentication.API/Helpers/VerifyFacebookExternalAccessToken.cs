using AngularJSAuthentication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AngularJSAuthentication.API.Helpers
{
    public class VerifyFacebookExternalAccessToken : VerifyExternalToken
    {
        public async Task<ParsedExternalAccessToken> VerifyExternalAccessToken(string provider, string accessToken)
        {


        }
    }
}