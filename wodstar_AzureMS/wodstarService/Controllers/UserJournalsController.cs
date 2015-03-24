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
    public class UserJournalController : TableController<UserJournal>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            wodstarContext context = new wodstarContext();
            DomainManager = new EntityDomainManager<UserJournal>(context, Request, Services);
        }

        // GET tables/UserJournal
        public IQueryable<UserJournal> GetAllUserJournals()
        {
            return Query();
        }

        // GET tables/UserJournal/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserJournal> GetUserJournal(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/UserJournal/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserJournal> PatchUserJournal(string id, Delta<UserJournal> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/UserJournal
        public async Task<IHttpActionResult> PostUserJournal(UserJournal journal)
        {
            UserJournal current = await InsertAsync(journal);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/UserJournal/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserJoural(string id)
        {
            return DeleteAsync(id);
        }
    }
}