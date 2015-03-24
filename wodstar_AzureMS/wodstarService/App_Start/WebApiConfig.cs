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
            
            Database.SetInitializer(new wodstarInitializer());
            //Database.SetInitializer<wodstarContext>(null);
        }
    }

    public class wodstarInitializer : ClearDatabaseSchemaIfModelChanges<wodstarContext>
    //public class wodstarInitializer : CreateDatabaseIfNotExists<wodstarContext>
    {
        protected override void Seed(wodstarContext context)
        {
            //List<TodoItem> todoItems = new List<TodoItem>
            //{
                //new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
                //new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            //};

            //foreach (TodoItem todoItem in todoItems)
            //{
                //context.Set<TodoItem>().Add(todoItem);
            //}

            base.Seed(context);
        }
    }
}

