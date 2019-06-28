using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    public class TimeEntryController
    {
        private readonly ITimeEntryRepository _repository;

        public TimeEntryController(ITimeEntryRepository timeEntryRepository)
        {
            this._repository = timeEntryRepository;
        }

        public ActionResult Read(int timeEntryId)
        {
            if (_repository.Contains(timeEntryId))
            {
                return new OkObjectResult(_repository.Find(timeEntryId));
            }

            return new NotFoundResult();
        }
    }
}