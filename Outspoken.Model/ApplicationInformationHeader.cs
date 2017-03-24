using System;
using System.Collections.Generic;

namespace Outspoken.Model
{
	public class ApplicationInformationHeader : IEntityBase
	{
		public int Id {get; set;}
		public string ApplicationName {get;set;}
		public string ApplicationDescription {get;set;}
		public int NumberOfRequests { get; set; }
		public List<ApplicationFeatureRequest> FeatureRequests { get; set; }
	}
}
