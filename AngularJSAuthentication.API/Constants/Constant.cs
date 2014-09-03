using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSAuthentication.API.Constants
{
    public class Constant
    {
        public const string faceBookProviderName = "Facebook";
        public const string facebookAppID = "1451891955093018";
        public const string facebookAppSecret = "2f94fdc64cc30c46bc45b72393a1b7c5";
        public const string facebookAppToken = @"1451891955093018|XrSPS8BAxXIr6S8xR6M1JTcNQ8Y";

        public const string googleProviderName = "Google";
        public const string googleClientID = "685649963644-nojbflg56ib77957agol1pg14fpi6l7b.apps.googleusercontent.com";
        public const string googleClientSecret = "YA5t6CP6UKe_GQ6223fzam8e";

        public static Dictionary<string, string> DicVerifyTokenEndPoints = new Dictionary<string, string>()
            {
                {"Facebook",@"https://graph.facebook.com/debug_token?input_token={0}&access_token="+facebookAppToken},
                {"Google",@"https://www.googleapis.com/oauth2/v1/tokeninfo?access_token={0}"}

            };
        
    }
}