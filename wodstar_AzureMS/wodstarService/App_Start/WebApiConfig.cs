using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using wodstarService.DataObjects;
using wodstarService.Models;

namespace wodstarService
{
    public static class WebApiConfig
    {
        public static void Register()
        {
            // Use this class to set configuration options for your mobile service
            ConfigOptions options = new ConfigOptions();

            // Use this class to set WebAPI configuration options
            HttpConfiguration config = ServiceConfig.Initialize(new ConfigBuilder(options));

            // To display errors in the browser during development, uncomment the following
            // line. Comment it out again when you deploy your service for production use.
            // config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            
            //Database.SetInitializer(new wodstarInitializer());
        }
    }

    //Disabled by sbeverly to avoid destroying the existing tables during Publishing to Azure Mobile Service
    //public class wodstarInitializer : ClearDatabaseSchemaIfModelChanges<wodstarContext>
    //{
        //protected override void Seed(wodstarContext context)
        //{
            //List<UserAccount> userAccounts = new List<UserAccount>
            //{
                //new UserAccount { Id = Guid.NewGuid().ToString(), Username = "wodstar_admin", AccountType = "wodstar", FirstName = "Wodstar", LastName = "Admin" }
            //};

            //foreach (UserAccount userAccount in userAccounts)
            //{
                //context.Set<UserAccount>().Add(userAccount);
            //}

            //base.Seed(context);
        //}
    //}
}

