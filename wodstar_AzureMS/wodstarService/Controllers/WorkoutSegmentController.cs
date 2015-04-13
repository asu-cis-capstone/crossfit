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
    public class WorkoutSegmentController : TableController<WorkoutSegment>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            wodstarContext context = new wodstarContext();
            DomainManager = new EntityDomainManager<WorkoutSegment>(context, Request, Services);
        }

        // GET tables/Movement
        public IQueryable<WorkoutSegment> GetAllMovements()
        {
            return Query();
        }

        // GET tables/Movement/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<WorkoutSegment> GetMovementSegment(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Movement/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<WorkoutSegment> PatchMovementSegment(string id, Delta<WorkoutSegment> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Movement
        public async Task<IHttpActionResult> PostMovementSegment(WorkoutSegment movementSegment)
        {
            WorkoutSegment current = await InsertAsync(movementSegment);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Movement/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMovementSegment(string id)
        {
            return DeleteAsync(id);
        }
    }
}