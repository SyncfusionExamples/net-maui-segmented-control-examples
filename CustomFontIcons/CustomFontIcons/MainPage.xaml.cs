using Syncfusion.Maui.Buttons;
using System.Collections.ObjectModel;

namespace CustomFontIcons
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<SfSegmentItem> SegmentItems { get; set; }

        public MainPage()
        {
            InitializeComponent();

            SegmentItems = new ObservableCollection<SfSegmentItem>()
            {
                new SfSegmentItem(){ Text = "Walk", ImageSource = new FontImageSource()
                {
                    Glyph="\uE705", FontFamily= "Segemented-UG-Icons", Color=Colors.Black,
                }},

                 new SfSegmentItem(){ Text = "Bike", ImageSource = new FontImageSource()
                {
                    Glyph="\uE708", FontFamily= "Segemented-UG-Icons", Color=Colors.Black,
                }},

                  new SfSegmentItem(){ Text = "Car", ImageSource = new FontImageSource()
                {
                    Glyph="\uE706", FontFamily= "Segemented-UG-Icons", Color=Colors.Black,
                }},

                   new SfSegmentItem(){ Text = "Bus", ImageSource = new FontImageSource()
                {
                    Glyph="\uE707", FontFamily= "Segemented-UG-Icons", Color=Colors.Black,
                }},
            };

            this.segmentedControl.ItemsSource = SegmentItems;
        }


    }
}
