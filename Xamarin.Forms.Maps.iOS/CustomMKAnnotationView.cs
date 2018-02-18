using MapKit;

#if __MOBILE__
namespace Xamarin.Forms.Maps.iOS
#else
namespace Xamarin.Forms.Maps.MacOS
#endif
{
	public class CustomMKAnnotationView : MKAnnotationView
	{
		public string Id { get; set; }

		public CustomMKAnnotationView(IMKAnnotation annotation, string id)
			: base(annotation, id)
		{
		}
	}
}