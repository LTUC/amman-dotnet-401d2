using DependencyInjectionLifetimes.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace DependencyInjectionLifetimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IScopedService scoped1;
        private readonly IScopedService scoped2;

        private readonly ITransientService transient1;
        private readonly ITransientService transient2;


        private readonly ISingletonService singleton1;
        private readonly ISingletonService singleton2;

        public ValuesController(IScopedService scopedService,
            IScopedService scopedService2,
            ITransientService transientService,
            ITransientService transientService2,
            ISingletonService singletonService,
            ISingletonService singletonService2)
        {
            scoped1 =  scopedService;
            scoped2 = scopedService2;
            transient1 = transientService;
            transient2 = transientService2;
            singleton1 = singletonService;
            singleton2 = singletonService2;
        }

        [HttpGet]
        public ActionResult Index()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Transient 1 : {transient1.GetGuid()} \n");
            stringBuilder.Append($"Transient 2 : {transient2.GetGuid()} \n \n");

            stringBuilder.Append($"Scoped 1 : {scoped1.GetGuid()} \n");
            stringBuilder.Append($"Scoped 2 : {scoped2.GetGuid()} \n \n");

            stringBuilder.Append($"Singleton 1 : {singleton1.GetGuid()} \n");
            stringBuilder.Append($"Singleton 2 : {singleton2.GetGuid()} \n \n");

            return Ok(stringBuilder.ToString());
        }

    }
}
