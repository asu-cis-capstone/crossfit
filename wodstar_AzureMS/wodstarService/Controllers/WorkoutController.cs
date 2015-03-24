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
    public class WorkoutController : TableController<Workout>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            wodstarContext context = new wodstarContext();
            DomainManager = new EntityDomainManager<Workout>(context, Request, Services);
        }

        // GET tables/Workout
        public IQueryable<Workout> GetAllWorkouts()
        {
            return Query();
        }

        // GET tables/Workout/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Workout> GetWorkout(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Workout/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Workout> PatchWorkout(string id, Delta<Workout> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Workout
        public async Task<IHttpActionResult> PostWorkout(Workout workout)
        {
            Workout current = await InsertAsync(workout);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Workout/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteWorkout(string id)
        {
            return DeleteAsync(id);
        }
    }
}