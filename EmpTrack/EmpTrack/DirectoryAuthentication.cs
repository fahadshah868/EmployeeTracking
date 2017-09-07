using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpTrack
{
    class DirectoryAuthentication
    {
        //public static string clientId = "e013caa6-be6e-4a16-8e09-37e9a79b332b";
        //public static string commonAuthority = "https://login.microsoftonline.com/common/";
        //public static Uri returnUri = new Uri("https://demo-redirect");
        //const string graphResourceUri = "https://graph.windows.net";
        //public static string graphApiVersion = "2013-11-08";

        //public static async Task<List<User>> SearchByAlias(string alias, IPlatformParameters parent) // add this param
        //{
        //    AuthenticationResult authResult = null;
        //    JObject jResult = null;
        //    List<User> results = new List<User>();

        //    try
        //    {
        //        // To avoid the user consent page, input the values for your registered application above,
        //        // comment out the if statement immediately below, and replace the commonAuthority parameter
        //        // with https://login.microsoftonline.com/common/<your.tenant.domain.com>
        //        AuthenticationContext authContext = new AuthenticationContext(commonAuthority);
        //        if (authContext.TokenCache.ReadItems().Count() > 0)
        //            authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().First().Authority);
        //        authResult = await authContext.AcquireTokenAsync(graphResourceUri, clientId, returnUri, parent);
        //    }
        //    catch (Exception ee)
        //    {
        //        results.Add(new User { error = ee.Message });
        //        return results;
        //    }

        //}
    }
}
