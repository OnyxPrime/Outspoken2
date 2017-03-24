using System;
namespace OutspokenAPI
{
	public class SimpleServiceLocator
	{
		private IDataService dataService;
		public IDataService DataService{
			get { 
				if (dataService == null)
					dataService = new TestApplicationDataservice();
				return dataService;
			}
		}

		private SimpleServiceLocator()
		{
		}

		private static SimpleServiceLocator locator;

		public static SimpleServiceLocator Locator { 
			get{

				if (locator == null)
					locator = new SimpleServiceLocator();

				return locator;
			}
		}
	}
}
