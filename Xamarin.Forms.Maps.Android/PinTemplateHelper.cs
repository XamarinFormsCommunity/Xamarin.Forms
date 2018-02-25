using Android.Content;
using Android.Gms.Maps.Model;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using AView = Android.Views;

namespace Xamarin.Forms.Maps.Android
{
	public class PinTemplateHelper
	{
		public static BitmapDescriptor ConvertViewToBitmapDescriptor(View view, Context context)
		{
			var viewRenderer = Platform.Android.Platform.CreateRendererWithContext(view, context);
			Platform.Android.Platform.SetRenderer(view, viewRenderer);

			var nativeView = viewRenderer.View;
			var otherView = new FrameLayout(nativeView.Context);

			otherView.SetBackgroundColor(Color.Red.ToAndroid());

			nativeView.LayoutParameters = new FrameLayout.LayoutParams(48, 48);
			otherView.AddView(nativeView);

			otherView.SetLayerType(LayerType.Hardware, null);
			otherView.DrawingCacheEnabled = true;

			otherView.Measure(AView.View.MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified),
						AView.View.MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified));
			otherView.Layout(0, 0, 48, 48);
			otherView.BuildDrawingCache(true);

			Bitmap bitmap = Bitmap.CreateBitmap(otherView.GetDrawingCache(true));
			otherView.DrawingCacheEnabled = false;

			return BitmapDescriptorFactory.FromBitmap(bitmap);
		}
	}
}