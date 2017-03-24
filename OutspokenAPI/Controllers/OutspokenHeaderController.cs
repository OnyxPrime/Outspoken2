using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static Outspoken.Data.IRepositories;

namespace OutspokenAPI
{
	[ApiVersion( "1.0" )]
	[ControllerName("OutspokenHeaders")]
	[EnableCors("SiteCorsPolicy")]
	[Route( "api/v{version:apiVersion}/[controller]" )]
	public class OutspokenHeaderController : Controller
	{
		
		IApplicationRepository appRepo;
		IApplicationFeaturesRepository appFeatureRepo;

		public OutspokenHeaderController(IApplicationRepository appRepository, IApplicationFeaturesRepository appFeatureRepository){
			appRepo = appRepository;
			appFeatureRepo = appFeatureRepository;
		}

		// GET api/v1/outspokenheaders
        [HttpGet]
		public async Task<IActionResult> Get()
        {
			//var appHeaders = service.GetAll();
			try
			{
				var appHeaders = await appRepo.GetAll();
				//foreach (var app in appHeaders)
				//{
				//	app.NumberOfRequests = (await appFeatureRepo.GetAll()).Where(x => x.ApplicationId == app.Id).Count();
				//}
				return Ok(appHeaders);
			}
			catch (Exception ex)
			{
				return BadRequest();
			}

        }

		// POST api/v1/outspokenheaders
		public async Task<IActionResult> Post(string applicationName)
		{
			if ((await appRepo.GetAll()).Any(x => x.ApplicationName == applicationName))
				return StatusCode(409, "Application name already exists in system");

			appRepo.Add(new Outspoken.Model.ApplicationInformationHeader() { ApplicationName = applicationName });

			return Ok();
		}

	}
}
