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
    public class UserAccountController : TableController<UserAccount>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            wodstarContext context = new wodstarContext();
            DomainManager = new EntityDomainManager<UserAccount>(context, Request, Services);
        }

        // GET tables/UserAccount
        public IQueryable<UserAccount> GetAllUserAccounts()
        {
            return Query();
        }

        // GET tables/UserAccount/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserAccount> GetUserAccount(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/UserAccount/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserAccount> PatchUserAccount(string id, Delta<UserAccount> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/UserAccount
        public async Task<IHttpActionResult> PostUserAccount(UserAccount user)
        {
            UserAccount current = await InsertAsync(user);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/UserAccount/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserAccount(string id)
        {
            return DeleteAsync(id);
        }
    }
}