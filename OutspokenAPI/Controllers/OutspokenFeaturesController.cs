using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static Outspoken.Data.IRepositories;
namespace OutspokenAPI
{
	[ApiVersion("1.0")]
	[ControllerName("OutspokenFeatures")]
	[EnableCors("SiteCorsPolicy")]
	[Route("api/v{version:apiVersion}/[controller]")]
	public class OutspokenFeaturesController : Controller
	{
		IApplicationRepository appRepo;
		IApplicationFeaturesRepository appFeaturesRepo;

		public OutspokenFeaturesController(IApplicationRepository appRepository, IApplicationFeaturesRepository appFeaturesRepository)
		{
			appRepo = appRepository;
			appFeaturesRepo = appFeaturesRepository;
		}

		// GET api/v1/outspokenfeatures/:ApplicationId
		[HttpGet]
		public IActionResult Get(int ApplicationId)
		{
			var app = appRepo.GetSingle(ApplicationId);

			return BadRequest(new NotImplementedException());
		}

		[HttpPost]
		// POST api/v1/outspokenfeatures
		public IActionResult Post(string applicationName)
		{
			return BadRequest(new NotImplementedException());
		}
	}
}
