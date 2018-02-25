using System.Collections.ObjectModel;
using Xamarin.Forms.Maps;

namespace Xamarin.Forms.Controls.GalleryPages.BindableMap
{
	public class BindableMapViewModel : BindableObject
	{
		private ObservableCollection<Pin> _pins;

		public BindableMapViewModel()
		{
			LoadPins();
		}

		public ObservableCollection<Pin> Pins
		{
			get { return _pins; }
			set
			{
				_pins = value;
				OnPropertyChanged();
			}
		}

		private void LoadPins()
		{
			Pins = new ObservableCollection<Pin>();

			Pins.Add(new Pin
			{
				Type = PinType.Place,
				Position = new Position(41.890202, 12.492049),
				Label = "Colosseum",
				Address = "Piazza del Colosseo, 00184 Rome, Province of Rome, Italy"
			});

			Pins.Add(new Pin
			{
				Type = PinType.Place,
				Position = new Position(41.898652, 12.476831),
				Label = "Pantheon",
				Address = "Piazza della Rotunda, 00186 Rome, Province of Rome, Italy"
			});

			Pins.Add(new Pin
			{
				Type = PinType.Place,
				Position = new Position(41.903209, 12.454545),
				Label = "Sistine Chapel",
				Address = "Piazza della Rotunda, 00186 Rome, Province of Rome, Italy"
			});
		}
	}
}
