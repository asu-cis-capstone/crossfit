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
    public class MovementController : TableController<Movement>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            wodstarContext context = new wodstarContext();
            DomainManager = new EntityDomainManager<Movement>(context, Request, Services);
        }

        // GET tables/Movement
        public IQueryable<Movement> GetAllMovements()
        {
            return Query();
        }

        // GET tables/Movement/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Movement> GetMovement(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Movement/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Movement> PatchMovement(string id, Delta<Movement> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Movement
        public async Task<IHttpActionResult> PostMovement(Movement user)
        {
            Movement current = await InsertAsync(user);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Movement/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMovement(string id)
        {
            return DeleteAsync(id);
        }
    }
}