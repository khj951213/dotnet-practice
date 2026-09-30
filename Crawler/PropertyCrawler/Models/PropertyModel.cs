namespace PropertyCrawler.Models;

public class PropertyModel
{
    public string? Description { get; set; }
    public string? ListingId { get; set; }
    public string? Address { get; set; }
    public string? StreetAddress { get; set; }
    public string? Suburb { get; set; }
    public string? State { get; set; }
    public string? Postcode { get; set; }
    public string? Price { get; set; }
    public int? Bedrooms { get; set; }
    public int? Bathrooms { get; set; }
    public int? CarSpaces { get; set; }
    public string? LandSize { get; set; }
    public string? PropertyType { get; set; }
    public string? PageViews { get; set; }
    public string? MainImage { get; set; }
    public string? DetailImage { get; set; }
    public string? Url { get; set; }
    public string? CanoncialUrl { get; set; }
    public string? AgentName { get; set; }
    public string? AgentJobTitle { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTimeOffset? InspectionStart { get; set; }
    public DateTimeOffset? InspectionEnd { get; set; }
    public List<string>? Features { get; set; }
}