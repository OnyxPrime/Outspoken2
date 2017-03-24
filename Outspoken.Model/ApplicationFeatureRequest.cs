using System;
namespace Outspoken.Model
{
	public class ApplicationFeatureRequest : IEntityBase
	{
		public int Id { get; set; }
		public int ApplicationId { get; set; }
		public string FeatureTitle { get; set; }
		public string FeatureDescription { get; set; }

		//public int ApplicationInformationHeaderId { get; set; }
		public ApplicationInformationHeader ApplicationInformationHeader { get; set; }

	}
}
