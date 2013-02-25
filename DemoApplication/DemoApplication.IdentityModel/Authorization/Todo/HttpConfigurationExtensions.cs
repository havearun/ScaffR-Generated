/*
 * Copyright (c) Dominick Baier.  All rights reserved.
 * see license.txt
 */

namespace DemoApplication.IdentityModel.Authorization.Todo
{
    using System.Web.Http;
    using System.Web.Http.Filters;

    public static class HttpConfigurationExtensions
    {
        public static void SetAuthorizationManager(this HttpConfiguration configuration, IAuthorizationManager manager)
        {
            configuration.Properties[ApiAuthorizeAttribute.PropertyName] = manager;
        }

        public static void SetAuthorizationFilter(this HttpConfiguration configuration, IAuthorizationFilter filter)
        {
            configuration.Filters.Add(filter);
        }
    }
}
