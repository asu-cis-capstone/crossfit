using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using wodstarService.DataObjects;
using wodstarService.Models;

namespace wodstarService.Controllers
{
    public class UserSubscriptionController : TableController<UserSubscription>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            wodstarContext context = new wodstarContext();
            DomainManager = new EntityDomainManager<UserSubscription>(context, Request, Services);
        }

        // GET tables/UserSubscription
        public IQueryable<UserSubscription> GetAllUserSubscriptions()
        {
            return Query();
        }

        // GET tables/UserSubscription/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserSubscription> GetUserSubscription(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/UserSubscription/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserSubscription> PatchUserSubscription(string id, Delta<UserSubscription> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/UserSubscription
        public async Task<IHttpActionResult> PostUserSubscription(UserSubscription subscription)
        {
            UserSubscription current = await InsertAsync(subscription);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/UserSubscription/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserSubscription(string id)
        {
            return DeleteAsync(id);
        }
    }
}