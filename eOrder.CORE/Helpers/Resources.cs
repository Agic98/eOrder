using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace eOrder.CORE
{
    public class Resources
    {
        IStringLocalizer _localizer;

        public static IList<CultureInfo> supportedCultures = new List<CultureInfo>
        {
            new CultureInfo("en-US"),
            new CultureInfo("bs-Latn-BA")
        };

        public Resources(IStringLocalizerFactory localizerFactory)
        {
            _localizer = localizerFactory.Create("Resource", new AssemblyName(typeof(Resources).GetTypeInfo().Assembly.FullName).Name);
        }

        #region Generic messages
        public string MissingAuthorizationHeader => _localizer["MissingAuthorizationHeader"];
        public string InvalidAuthorizationHeader => _localizer["InvalidAuthorizationHeader"];
        public string InvalidUsernameOrPassword => _localizer["InvalidUsernameOrPassword"];
        public string ServerError => _localizer["ServerError"];
        public string PasswordsNotMatching => _localizer["PasswordsNotMatching"];
        public string RatingBetween1And5 => _localizer["RatingBetween1And5"]; 
        #endregion


        #region Data Annotations messages
        public string IdReqField => _localizer["IdReqField"]; 
        public string NameReqField => _localizer["NameReqField"]; 
        public string ReqField => _localizer["ReqField"]; 
        public string ReqFieldMinLength3 => _localizer["ReqFieldMinLength3"]; 
        #endregion
    }
}
