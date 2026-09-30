using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PropertyCrawler.Models;

namespace PropertyCrawler.Controls;

public sealed partial class PropertyCard : UserControl
{
    public PropertyCard()
    {
        InitializeComponent();
    }

    public PropertyModel? Property
    {
        get => (PropertyModel?)GetValue(PropertyProperty);
        set => SetValue(PropertyProperty, value);
    }

    public static readonly DependencyProperty PropertyProperty =
        DependencyProperty.Register(
            nameof(Property),
            typeof(PropertyModel),
            typeof(PropertyCard),
            new PropertyMetadata(null)
        );
}