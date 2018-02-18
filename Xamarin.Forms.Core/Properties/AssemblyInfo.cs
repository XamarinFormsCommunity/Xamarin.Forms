using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.StyleSheets;

[assembly: InternalsVisibleTo("iOSUnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Controls")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Design")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS.Classic")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Android")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.FlexLayout.UnitTests")]

[assembly: InternalsVisibleTo("Xamarin.Forms.Core.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Windows.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.macOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Loader")]
// Xamarin.Forms.Loader.dll, Xamarin.Forms.Internals.ResourceLoader.ResourceProvider, kzu@microsoft.com
[assembly: InternalsVisibleTo("Xamarin.Forms.UITest.Validator")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Build.Tasks")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.CarouselView")]
[assembly: Preserve]

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "Xamarin.Forms")]

[assembly: StyleProperty("background-color", typeof(VisualElement), nameof(VisualElement.BackgroundColorProperty))]
[assembly: StyleProperty("background-image", typeof(Page), nameof(Page.BackgroundImageProperty))]
[assembly: StyleProperty("border-color", typeof(IBorderElement), nameof(BorderElement.BorderColorProperty))]
[assembly: StyleProperty("border-radius", typeof(ICornerElement), nameof(CornerElement.CornerRadiusProperty))]
[assembly: StyleProperty("border-width", typeof(Button), nameof(Button.BorderWidthProperty))]
[assembly: StyleProperty("color", typeof(ITextElement), nameof(TextElement.TextColorProperty), Inherited = true)]
[assembly: StyleProperty("direction", typeof(VisualElement), nameof(VisualElement.FlowDirectionProperty), Inherited = true)]
[assembly: StyleProperty("font-family", typeof(IFontElement), nameof(FontElement.FontFamilyProperty), Inherited = true)]
[assembly: StyleProperty("font-size", typeof(IFontElement), nameof(FontElement.FontSizeProperty), Inherited = true)]
[assembly: StyleProperty("font-style", typeof(IFontElement), nameof(FontElement.FontAttributesProperty), Inherited = true)]
[assembly: StyleProperty("height", typeof(VisualElement), nameof(VisualElement.HeightRequestProperty))]
[assembly: StyleProperty("margin", typeof(View), nameof(View.MarginProperty))]
[assembly: StyleProperty("margin-left", typeof(View), nameof(View.MarginLeftProperty))]
[assembly: StyleProperty("margin-top", typeof(View), nameof(View.MarginTopProperty))]
[assembly: StyleProperty("margin-right", typeof(View), nameof(View.MarginRightProperty))]
[assembly: StyleProperty("margin-bottom", typeof(View), nameof(View.MarginBottomProperty))]
[assembly: StyleProperty("min-height", typeof(VisualElement), nameof(VisualElement.MinimumHeightRequestProperty))]
[assembly: StyleProperty("min-width", typeof(VisualElement), nameof(VisualElement.MinimumWidthRequestProperty))]
[assembly: StyleProperty("opacity", typeof(VisualElement), nameof(VisualElement.OpacityProperty))]
[assembly: StyleProperty("padding", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("padding-left", typeof(IPaddingElement), nameof(PaddingElement.PaddingLeftProperty), PropertyOwnerType=typeof(PaddingElement))]
[assembly: StyleProperty("padding-top", typeof(IPaddingElement), nameof(PaddingElement.PaddingTopProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("padding-right", typeof(IPaddingElement), nameof(PaddingElement.PaddingRightProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("padding-bottom", typeof(IPaddingElement), nameof(PaddingElement.PaddingBottomProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("text-align", typeof(ITextAlignmentElement), nameof(TextAlignmentElement.HorizontalTextAlignmentProperty), Inherited = true)]
[assembly: StyleProperty("text-decoration", typeof(IDecorableText), nameof(DecorableTextElement.TextDecorationsProperty))]
[assembly: StyleProperty("visibility", typeof(VisualElement), nameof(VisualElement.IsVisibleProperty), Inherited = true)]
[assembly: StyleProperty("width", typeof(VisualElement), nameof(VisualElement.WidthRequestProperty))]
[assembly: StyleProperty("line-height", typeof(ILineHeightElement), nameof(LineHeightElement.LineHeightProperty), Inherited = true)]

//flex
[assembly: StyleProperty("align-content", typeof(FlexLayout), nameof(FlexLayout.AlignContentProperty))]
[assembly: StyleProperty("align-items", typeof(FlexLayout), nameof(FlexLayout.AlignItemsProperty))]
[assembly: StyleProperty("align-self", typeof(VisualElement), nameof(FlexLayout.AlignSelfProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-direction", typeof(FlexLayout), nameof(FlexLayout.DirectionProperty))]
[assembly: StyleProperty("flex-basis", typeof(VisualElement), nameof(FlexLayout.BasisProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-grow", typeof(VisualElement), nameof(FlexLayout.GrowProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-shrink", typeof(VisualElement), nameof(FlexLayout.ShrinkProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-wrap", typeof(VisualElement), nameof(FlexLayout.WrapProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("justify-content", typeof(FlexLayout), nameof(FlexLayout.JustifyContentProperty))]
[assembly: StyleProperty("order", typeof(VisualElement), nameof(FlexLayout.OrderProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("position", typeof(FlexLayout), nameof(FlexLayout.PositionProperty))]
