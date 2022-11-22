using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//namespace CanWeFixItApi.Controllers
namespace CanWeFixItService
{
    [ApiController]
    [Route("v1/instruments")]
    public class InstrumentController : ControllerBase
    {
        private readonly IDatabaseService _database;
        
        public InstrumentController(IDatabaseService database)
        {
            _database = database;
        }
        
        // GET
        public async Task<ActionResult<IEnumerable<Instrument>>> Get()
        {   
            return await Ok(_database.Instruments().Result);
        }
    }
}

//Hello