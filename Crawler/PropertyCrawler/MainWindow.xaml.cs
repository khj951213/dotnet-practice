using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PropertyCrawler.Models;
using System.Collections.ObjectModel;

namespace PropertyCrawler;

public sealed partial class MainWindow : Window
{
    public ObservableCollection<PropertyModel> FeaturedProperties { get; } = new();
    public ObservableCollection<PropertyModel> OtherProperties { get; } = new();
    public ObservableCollection<PropertyModel> FilteredOtherProperties { get; } = new();

    public MainWindow()
    {
        InitializeComponent();
        LoadSampleProperties();
        RefreshFilteredProperties();
        UpdatePropertyCount();
    }

    private void LoadSampleProperties()
    {
        FeaturedProperties.Clear();
        OtherProperties.Clear();

        FeaturedProperties.Add(new PropertyModel
        {
            Address = "2 Walton Avenue, Clearview SA 5085",
            Price = "Contact Agent",
            MainImage =
                "https://i2.au.reastatic.net/800x600/15aa4584277c86f9318023594cba24f92aa1e630f4e8dcb3549396679b395fe6/image.jpg",
            Bedrooms = 3,
            Bathrooms = 1,
            CarSpaces = 2,
            LandSize = "750 m²"
        });

        FeaturedProperties.Add(new PropertyModel
        {
            Address = "55A Fairview Terrace, Clearview SA 5085",
            Price = "$970,000 - $1,060,000",
            MainImage =
                "https://i2.au.reastatic.net/800x600/e10ae0c9937c2a0589cc38c8637952d132f6b291f4d6fbc0c45325d6ffb643ee/image.jpg",
            Bedrooms = 4,
            Bathrooms = 2,
            CarSpaces = 2,
            LandSize = "308 m²"
        });

        FeaturedProperties.Add(new PropertyModel
        {
            Address = "2A Eddy Street, Enfield SA",
            Price = "$880,000 - $930,000",
            MainImage =
                "https://i2.au.reastatic.net/800x600/2c1c097dfe54339cb85668c06bcc5ecd44855a2e37e29bfac505505db20b51a9/image.jpg",
            Bedrooms = 3,
            Bathrooms = 2,
            CarSpaces = 1,
            LandSize = "349 m²"
        });

        FeaturedProperties.Add(new PropertyModel
        {
            Address = "18 Mansfield Road, Northfield SA",
            Price = "$970,000 - $985,000",
            Bedrooms = 3,
            Bathrooms = 2,
            CarSpaces = 2,
            LandSize = "369 m²"
        });

        OtherProperties.Add(new PropertyModel
        {
            Address = "10 Example Street, Adelaide SA",
            Price = "$850,000",
            Bedrooms = 3,
            Bathrooms = 2,
            CarSpaces = 1,
            LandSize = "420 m²"
        });

        OtherProperties.Add(new PropertyModel
        {
            Address = "22 Example Road, Prospect SA",
            Price = "$1,100,000",
            Bedrooms = 4,
            Bathrooms = 2,
            CarSpaces = 2,
            LandSize = "550 m²"
        });

        OtherProperties.Add(new PropertyModel
        {
            Address = "7 Example Avenue, Clearview SA",
            Price = "$795,000",
            Bedrooms = 3,
            Bathrooms = 1,
            CarSpaces = 2,
            LandSize = "610 m²"
        });
    }

    private void RefreshFilteredProperties(string? searchText = null)
    {
        FilteredOtherProperties.Clear();

        IEnumerable<PropertyModel> query = OtherProperties;

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            searchText = searchText.Trim();

            query = query.Where(property =>
                (property.Address?.Contains(
                    searchText,
                    StringComparison.OrdinalIgnoreCase) ?? false)
                ||
                (property.Price?.Contains(
                    searchText,
                    StringComparison.OrdinalIgnoreCase) ?? false)
            );
        }

        foreach (var property in query)
        {
            FilteredOtherProperties.Add(property);
        }
    }

    private void SearchBox_TextChanged(
        AutoSuggestBox sender,
        AutoSuggestBoxTextChangedEventArgs args)
    {
        RefreshFilteredProperties(sender.Text);
    }

    private void RefreshButton_Click(
        object sender,
        RoutedEventArgs e)
    {
        LoadSampleProperties();

        SearchBox.Text = string.Empty;

        RefreshFilteredProperties();

        UpdatePropertyCount();
    }

    private void UpdatePropertyCount()
    {
        var total =
            FeaturedProperties.Count +
            OtherProperties.Count;

        PropertyCountText.Text =
            $"{total} properties";
    }
}