using CoreGraphics;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace Xamarin.Forms.Maps.iOS
{
	public class PinTemplateHelper
	{
		public static UIImage ConvertViewToImage(View view, CGRect size)
		{
			var renderer = Platform.iOS.Platform.CreateRenderer(view);

			renderer.NativeView.Frame = size;

			renderer.NativeView.AutoresizingMask = UIViewAutoresizing.All;
			renderer.NativeView.ContentMode = UIViewContentMode.ScaleToFill;

			renderer.Element.Layout(size.ToRectangle());

			var nativeView = renderer.NativeView;

			nativeView.SetNeedsLayout();

			UIGraphics.BeginImageContextWithOptions(nativeView.Bounds.Size, false, 0);
			nativeView.Layer.RenderInContext(UIGraphics.GetCurrentContext());
			UIImage image = UIGraphics.GetImageFromCurrentImageContext();
			UIGraphics.EndImageContext();

			return image;
		}
	}
}