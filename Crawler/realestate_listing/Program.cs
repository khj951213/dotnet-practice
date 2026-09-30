using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;
using HtmlAgilityPack;

namespace realestate_listing;

class Program
{
    static async Task Main(string[] args)
    {
        using var handler = new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.All
        };

        using var httpClient = new HttpClient(handler);
        using var request1 = new HttpRequestMessage(HttpMethod.Get, "https://realestate.com.au");

        var kpUidz = string.Empty;
        var kpUidzSsn = string.Empty;
        var xKpsdkCt = string.Empty;
        var ewBkt = string.Empty;
        try
        {
            var response = await httpClient.SendAsync(request1);

            Console.WriteLine("==== SET COOKIES ====");

            if (response.Headers.TryGetValues("Set-Cookie", out var setCookies))
            {
                foreach (var setCookie in setCookies)
                {
                    var mainCookie = setCookie.Split(";")[0] ?? string.Empty;

                    ewBkt = mainCookie.Split("=")[0] == "ew_bkt" ? mainCookie + ";" : string.Empty;
                    if (!string.IsNullOrEmpty(ewBkt))
                    {
                        Console.WriteLine($"1. EW BKT Found!! => {ewBkt}");
                    }

                    kpUidz = mainCookie.Split("=")[0] == "KP_UIDz" ? mainCookie + ";" : string.Empty;
                    if (!string.IsNullOrEmpty(kpUidz))
                    {
                        Console.Write("1. KP UIDz Found!! => ");
                    }

                    if (string.IsNullOrEmpty(kpUidzSsn))
                    {
                        kpUidzSsn = mainCookie.Split("=")[0] == "KP_UIDz-ssn" ? mainCookie + ";" : string.Empty;
                        if (!string.IsNullOrEmpty(kpUidzSsn))
                        {
                            Console.Write("2. KP UIDz SSN Found!! => ");
                        }
                    }

                    Console.WriteLine(mainCookie + ";");
                }
            }
            else
            {
                Console.WriteLine("No set-cookies found");
            }

            if (response.Headers.TryGetValues("X-Kpsdk-Ct", out var xKpsdkCtHeader))
            {
                xKpsdkCt = xKpsdkCtHeader.FirstOrDefault() + ";";
                Console.WriteLine($"X-Kpsdk-CT found => {xKpsdkCt}");
            }

            Console.WriteLine("===== END OF SET COOKIES ====");
        }
        catch (Exception)
        {
            Console.Error.WriteLine("Failed to retreive cookies");
        }

        if (string.IsNullOrEmpty(kpUidz) || string.IsNullOrEmpty(kpUidzSsn))
        {
            Console.Error.WriteLine("Failed to retreive KP UIDz or KP UIDz SSN");
            Console.WriteLine($"KP_UIDz => {kpUidz}");
            Console.WriteLine($"KP_UIDz-ssn => {kpUidzSsn}");
            return;
        }

        using var request2 = new HttpRequestMessage(HttpMethod.Get, "https://realestate.com.au/buy/list-1");
        kpUidz = "KP_UIDz=07l4rXNgXdE7TcCNzFWvYCFl4nWtAsLSN2jlfSygOkXmA7fUD95LQe9DzGrjcBIIp0VNsDEea3b8fImy2pFVK40WEEJSG46yfW3thmewKE1dPIrbQhg3H8s7IXghM7c53PLKHBnzUBoPpdxQ2AVWpOqP8OUO8hWcxgyY37U7FhYDCDtPnWtWgeZkZjULcf3qIHa4JM;";

        kpUidzSsn =
        "KP_UIDz-ssn=07l4rXNgXdE7TcCNzFWvYCFl4nWtAsLSN2jlfSygOkXmA7fUD95LQe9DzGrjcBIIp0VNsDEea3b8fImy2pFVK40WEEJSG46yfW3thmewKE1dPIrbQhg3H8s7IXghM7c53PLKHBnzUBoPpdxQ2AVWpOqP8OUO8hWcxgyY37U7FhYDCDtPnWtWgeZkZjULcf3qIHa4JM;";

        var cookies = "Country=AU;" + ewBkt
            // + "ew_bkt=58;" // site-specific experimentation/audience-bucketing cookie. 
            // + "reauid=a4dff748c44000007be3b56aa503000064c94c00;" // REA visitor identifier
            // + "split_audience=d;" // associated with A/B testing or audience segmentation
            // + "AMCVS_341225BE55BBF7E17F000101%40AdobeOrg=1;" // Adobe experience cloud sending to AMCVS_...@AdobeOrg
            // + "s_ecid=MCMID%7C36105399529759365354128880608849872505;" // Adobe Analytics
            // + "s_cc=true;" // Adobe Analytics cookie for browser supports cookies
            // + "_fbp=fb.2.1790305149962.994579185876387255;" // Meta/Facebook Pixel cookie. It identifies browser fisits for advertising measurement and attribution
            // + "DM_SitId1464=1;" // analytics/audience cookie - digital measurement platform
            // + "DM_SitId1464SecId12708=1;" // tracking system with SitID1465 being a site identifier 
            // + "DM_SitId1464SecId12707=1;"
            // + "_gcl_au=1.1.771773812.1790305150;" // Google ads/Conversion Linker cookie. Used for advertising conversion measurement
            // + "_ga=GA1.1.581918439.1790305150;" // A GA4 property-specific cookie - Google analytics measurement/property configuration
            // + "_cb=RsnXgCEszKdBWLcFT;" // Chartbeat visitor ID.
            // + "_chartbeat2=.1790314627524.1790314627524.1.BdjmapDBiP3OC57HKmBy2VhGDYhFsw.1;" // Chartbeat timing/visit-history cookie
            // + "pageview_counter.srs=5;" // page-view counter
            // + "FCCDCF=%5Bnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B%5B32%2C%22%5B%5C%22e5d4ae4f-72d7-4c74-bae0-0e01e97e5bf9%5C%22%2C%5B1790305150%2C251000000%5D%5D%22%5D%5D%5D;" // google funding choices consent cookie.
            // + "FCNEC=%5B%5B%22AKsRol-xtdt7FOag2KJ2BASbBn5ZpVVUUYINZJkZwy2_C6jIp4_200pah7bdyov2qpRYGP0OC2Hwt5ImJ2S-TL_-yT94n4cfSLcKGujWzmuxmJsGIBxU5KwnunHdURpLuGvSsx1RQuZAKbhiz4S3R3tuxtSix6VJ0A%3D%3D%22%5D%5D;" // Google funding choice/consent management
            // + "_sp_ses.2fe7=*;"
            // + "AMCV_341225BE55BBF7E17F000101%40AdobeOrg=179643557%7CMCIDTS%7C20722%7CMCMID%7C36105399529759365354128880608849872505%7CMCAAMLH-1790930238%7C8%7CMCAAMB-1790930238%7CRKhpRz8krg2tLO6pguXWp5olkAcUniQYPHaMWWgdJ3xzPWQmdj0y%7CMCOPTOUT-1790332638s%7CNONE%7CMCAID%7CNONE%7CvVersion%7C5.5.0;"
            // + "QSI_HistorySession=https%3A%2F%2Fwww.realestate.com.au%2Fadvice%2Fproperty-settlement-tips-buyers%2F%3Fpage%3Drea%3Abuy%3Asrp%26element%3Dcontent_carousel%7Cpage_3%7Cslot_5~1790314628292%7Chttps%3A%2F%2Fwww.realestate.com.au%2F~1790316422843%7Chttps%3A%2F%2Fwww.realestate.com.au%2Fbuy%2F~1790316522704%7Chttps%3A%2F%2Fwww.realestate.com.au%2Fbuy%2Fin-lidcombe%2C%2Bnsw%2B2141%2Flist-1~1790316531598%7Chttps%3A%2F%2Fwww.realestate.com.au%2F~1790325438985;"
            // + "KFC=N6h8ioLYfYQ/UjBN4CntP6DhcN5TyUvil026VQ81QYY=|1790325443300;" // ???
            +
            kpUidz //This is likely part of the site's anti-bot/client-validation system
            + kpUidzSsn
            // + "s_nr30=1790325443677-Repeat;"
            // + "_ga_3J0XCBB972=GS2.1.s1790325438$o3$g1$t1790325443$j55$l0$h0;"
            // + "_sp_id.2fe7=2e2f731c-06d9-4b1c-bb77-f9e2b075e93e.1790305150.3.1790325456.1790316530.131addb2-bcaa-4a5d-8ac6-dbc6688704ca;"
            // + "utag_main=v_id:01a0d680a2370001c6a9b7917ec40506f002f06700bd0$_sn:3$_se:3%3Bexp-session$_ss:0%3Bexp-session$_st:1790327256139%3Bexp-session$ses_id:1790325437917%3Bexp-session$_pn:2%3Bexp-session$vapi_domain:realestate.com.au$dc_visit:1$dc_event:13%3Bexp-session$dc_region:ap-southeast-2%3Bexp-session$ttd_uuid:bbdafc0d-b19d-4a4f-a223-b2e92c467b01%3Bexp-session$adform_uid:5770065559996774620%3Bexp-session$_prevpage:rea%3Ahomepage%3Bexp-1790329056142;"
            // + "s_sq=rea-group-global-live%3D%2526c.%2526a.%2526activitymap.%2526page%253Drea%25253Ahomepage%2526link%253DSearch%2526region%253DheroImage%2526pageIDType%253D1%2526.activitymap%2526.a%2526.c%2526pid%253Drea%25253Ahomepage%2526pidt%253D1%2526oid%253DfunctionJt%252528%252529%25257B%25257D%2526oidt%253D2%2526ot%253DSUBMIT"
            ;

        Console.WriteLine($"Sending cookie: {cookies}");

        request2.Headers.TryAddWithoutValidation("cookie", cookies);
        request2.Headers.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/153.0.0.0 Safari/537.36");
        request2.Headers.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
        request2.Headers.TryAddWithoutValidation("Accept-Language", "en-AU,en;q=0.9");
        // request2.Headers.TryAddWithoutValidation("Referer", "https://www.realestate.com.au");
        request2.Headers.TryAddWithoutValidation("Connection", "keep-alive");
        request2.Headers.TryAddWithoutValidation("Upgrade-Insecure-Requests", "1");
        request2.Headers.TryAddWithoutValidation("sec-ch-ua", "\"Chromium\";v=\"153\", \"Not)A;Brand\";v=\"8\"");
        request2.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
        request2.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "\"Windows\"");
        // request.Headers.TryAddWithoutValidation("X-Kpsdk-Ct", "07L5fE3OLBNy0ln0ZUPDkgsy65wJcryWGhVcMGLGwUUSvBhBUtHI49UQFquIX4uvuOvMesBGfnuiykfzHWt5UN3NrrFy1BfzYfYY4DIUoexPNaTFxQphysM5yuxD4Xc4AYIqy2PPwVdsv6O0birSqwE2z2ygAEWWmyOROSiEpc4J3hpeQUwq4ZZ7wWd4lksMQvz610");
        // request.Headers.TryAddWithoutValidation("X-Kpsdk-R", "1-BwB7A1Y");

        var properties = new List<Property>();

        try
        {
            var response = await httpClient.SendAsync(request2);
            var body = await response.Content.ReadAsStringAsync();
            await File.WriteAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "result.html"), body);

            var doc = new HtmlDocument();
            doc.LoadHtml(body);

            var propertyCards = doc.DocumentNode.SelectNodes("//article[@data-testid='ResidentialCard']");

            if (propertyCards == null)
            {
                Console.WriteLine("No properties found.");
                return;
            }


            foreach (var card in propertyCards)
            {
                var property = new Property()
                {
                    Price = card.SelectSingleNode(".//span[contains(@class, 'property-price')]")?.InnerText.Trim(),
                    Address = card.SelectSingleNode(".//h2[contains(@class, 'residential-card__address-heading')]/a")?.InnerText?.Trim(),
                    Url = card.SelectSingleNode(".//h2[contains(@class, 'residential-card__address-heading')]/a")?.GetAttributeValue("href", ""),
                    MainImage = card.SelectSingleNode(".//div[@data-testid='PropertyImage']")?.GetAttributeValue("data-url", ""),
                    AgentName = card.SelectSingleNode(".//div[contains(@class, 'agent')]")?.GetAttributeValue("aria-label", "").Replace("Agent ", ""),
                };

                if (string.IsNullOrEmpty(property.Url)) continue;

                try
                {
                    using var request3 = new HttpRequestMessage(
        HttpMethod.Get,
        "https://realestate.com.au/" + property.Url
    );

                    var response2 = await httpClient.SendAsync(request3);
                    response2.EnsureSuccessStatusCode();

                    var body2 = await response2.Content.ReadAsStringAsync();

                    var doc2 = new HtmlDocument();
                    doc2.LoadHtml(body2);

                    var htmlDirectory = Path.Join(
                        Directory.GetCurrentDirectory(),
                        "html"
                    );

                    Directory.CreateDirectory(htmlDirectory);

                    var safeAddress = !string.IsNullOrEmpty(property.Address) 
                        ? string.Join("_", property.Address.Split(Path.GetInvalidFileNameChars()))
                        : property.Address;

                    var htmlFilePath = Path.Join(htmlDirectory, $"{safeAddress}.html");

                    await File.WriteAllTextAsync(htmlFilePath, body2);

                    // Meta description
                    property.Description = doc2.DocumentNode
                        .SelectSingleNode("//meta[@name='description']")
                        ?.GetAttributeValue("content", null);

                    // Main property image
                    property.DetailImage = doc2.DocumentNode
                        .SelectSingleNode("//meta[@property='og:image']")
                        ?.GetAttributeValue("content", null);

                    // Canonical URL
                    property.CanoncialUrl = doc2.DocumentNode
                        .SelectSingleNode("//link[@rel='canonical']")
                        ?.GetAttributeValue("href", null);

                    // --------------------------------------------------
                    // Basic HTML property attributes
                    // --------------------------------------------------

                    property.Price = doc2.DocumentNode
                        .SelectSingleNode("//span[contains(@class,'property-price')]")
                        ?.InnerText
                        .Trim();

                    var featureList = doc2.DocumentNode
                        .SelectSingleNode("//ul[contains(@class,'property-info__primary-features')]");

                    if (featureList != null)
                    {
                        property.Bedrooms = ExtractNumberFromAria(
                            featureList,
                            "bedroom"
                        );

                        property.Bathrooms = ExtractNumberFromAria(
                            featureList,
                            "bathroom"
                        );

                        property.CarSpaces = ExtractNumberFromAria(
                            featureList,
                            "car space"
                        );

                        var landNode = featureList.SelectSingleNode(
                            ".//li[contains(@aria-label,'land size')]"
                        );

                        property.LandSize = landNode?
                            .GetAttributeValue("aria-label", "")
                            .Replace("land size", "", StringComparison.OrdinalIgnoreCase)
                            .Trim();
                    }

                    // --------------------------------------------------
                    // Property features
                    // --------------------------------------------------

                    var featureNodes = doc2.DocumentNode.SelectNodes(
                        "//*[@data-testid='all-property-features-section']//p"
                    );

                    if (featureNodes != null)
                    {
                        property.Features = featureNodes
                            .Select(x => HtmlEntity.DeEntitize(x.InnerText).Trim())
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Distinct()
                            .ToList();
                    }

                    // --------------------------------------------------
                    // JSON-LD
                    // --------------------------------------------------

                    var jsonLdNodes = doc2.DocumentNode.SelectNodes(
                        "//script[@type='application/ld+json']"
                    );

                    if (jsonLdNodes != null)
                    {
                        foreach (var node in jsonLdNodes)
                        {
                            try
                            {
                                using var json = JsonDocument.Parse(node.InnerText);

                                if (json.RootElement.ValueKind != JsonValueKind.Array)
                                    continue;

                                foreach (var item in json.RootElement.EnumerateArray())
                                {
                                    if (!item.TryGetProperty("@type", out var typeElement))
                                        continue;

                                    var type = typeElement.GetString();

                                    // Address
                                    if (type == "Residence")
                                    {
                                        if (item.TryGetProperty("address", out var address))
                                        {
                                            property.Suburb = GetString(address, "addressLocality");
                                            property.State = GetString(address, "addressRegion");
                                            property.Postcode = GetString(address, "postalCode");
                                            property.StreetAddress = GetString(address, "streetAddress");
                                        }
                                    }

                                    // Inspection
                                    if (type == "Event")
                                    {
                                        property.InspectionStart =
                                            GetDateTimeOffset(item, "startDate");

                                        property.InspectionEnd =
                                            GetDateTimeOffset(item, "endDate");
                                    }
                                }
                            }
                            catch
                            {
                                // Ignore malformed JSON-LD block
                            }
                        }
                    }

                    // --------------------------------------------------
                    // ArgonautExchange
                    // --------------------------------------------------

                    var argonautNode = doc2.DocumentNode
                        .SelectSingleNode("//script[contains(text(),'window.ArgonautExchange')]");

                    if (argonautNode != null)
                    {
                        var script = HtmlEntity.DeEntitize(argonautNode.InnerText);

                        const string prefix = "window.ArgonautExchange =";

                        var startIndex = script.IndexOf(
                            prefix,
                            StringComparison.Ordinal
                        );

                        if (startIndex >= 0)
                        {
                            var jsonText = script[(startIndex + prefix.Length)..]
                                .Trim()
                                .TrimEnd(';');

                            using var argonautJson = JsonDocument.Parse(jsonText);

                            if (argonautJson.RootElement
                                .TryGetProperty(
                                    "resi-property_listing-experience-web",
                                    out var listingExperience)
                                &&
                                listingExperience.TryGetProperty(
                                    "urqlClientCache",
                                    out var cacheElement))
                            {
                                var cacheJsonText = cacheElement.GetString();

                                if (!string.IsNullOrWhiteSpace(cacheJsonText))
                                {
                                    using var cacheJson =
                                        JsonDocument.Parse(cacheJsonText);

                                    foreach (var cacheEntry in cacheJson.RootElement
                                        .EnumerateObject())
                                    {
                                        if (!cacheEntry.Value.TryGetProperty(
                                            "data",
                                            out var dataElement))
                                        {
                                            continue;
                                        }

                                        var dataJsonText = dataElement.GetString();

                                        if (string.IsNullOrWhiteSpace(dataJsonText))
                                            continue;

                                        using var dataJson =
                                            JsonDocument.Parse(dataJsonText);

                                        ExtractListingData(
                                            dataJson.RootElement,
                                            property
                                        );
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }

                Console.WriteLine($"Price:       {property.Price}");
                Console.WriteLine($"Address:     {property.Address}");
                Console.WriteLine($"URL:         {property.Url}");
                Console.WriteLine($"Canonical:   {property.CanoncialUrl}");
                Console.WriteLine($"Image:       {property.MainImage}");
                Console.WriteLine($"DetailImage: {property.DetailImage}");
                Console.WriteLine($"Agent:       {property.AgentName}");
                Console.WriteLine($"Description: {property.Description}");

                properties.Add(property);
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }

        var propertiesText = JsonSerializer.Serialize(properties, new JsonSerializerOptions() { WriteIndented = true });
        var now = DateOnly.FromDateTime(DateTime.Now).ToString();
        var jsonFilePath = Path.Join(Directory.GetCurrentDirectory(), "json", $"{now}.json");
        await File.WriteAllTextAsync(jsonFilePath, propertiesText);
    }

    static int? ExtractNumberFromAria(
    HtmlNode parent,
    string keyword)
    {
        var node = parent.SelectSingleNode(
            $".//li[contains(@aria-label,'{keyword}')]"
        );

        var aria = node?.GetAttributeValue("aria-label", null);

        if (string.IsNullOrWhiteSpace(aria))
            return null;

        var numberText = new string(
            aria.TakeWhile(char.IsDigit).ToArray()
        );

        return int.TryParse(numberText, out var value)
            ? value
            : null;
    }

    static string? GetString(
    JsonElement element,
    string propertyName)
    {
        return element.TryGetProperty(
            propertyName,
            out var value)
            ? value.GetString()
            : null;
    }

    static DateTimeOffset? GetDateTimeOffset(
    JsonElement element,
    string propertyName)
    {
        if (!element.TryGetProperty(
            propertyName,
            out var value))
        {
            return null;
        }

        return DateTimeOffset.TryParse(
            value.GetString(),
            out var result)
            ? result
            : null;
    }
    static void ExtractListingData(
        JsonElement element,
        Property property)
    {
        if (element.ValueKind == JsonValueKind.Object)
        {
            // Listing ID
            if (element.TryGetProperty("listingId", out var listingId))
            {
                property.ListingId ??= listingId.GetString();
            }

            if (element.TryGetProperty("id", out var id))
            {
                var idValue = id.GetString();

                if (!string.IsNullOrWhiteSpace(idValue)
                    && idValue.All(char.IsDigit)
                    && idValue.Length >= 8)
                {
                    property.ListingId ??= idValue;
                }
            }

            // Coordinates
            if (element.TryGetProperty(
                "latitude",
                out var latitude)
                &&
                latitude.ValueKind == JsonValueKind.Number)
            {
                property.Latitude ??= latitude.GetDouble();
            }

            if (element.TryGetProperty(
                "longitude",
                out var longitude)
                &&
                longitude.ValueKind == JsonValueKind.Number)
            {
                property.Longitude ??= longitude.GetDouble();
            }

            // Agent
            if (element.TryGetProperty("jobTitle", out var jobTitle)
                &&
                element.TryGetProperty("name", out var agentName))
            {
                property.AgentName ??= agentName.GetString();
                property.AgentJobTitle ??= jobTitle.GetString();
            }

            // Page views
            if (element.TryGetProperty(
                "pageViews",
                out var pageViews))
            {
                if (pageViews.TryGetProperty(
                    "display",
                    out var display))
                {
                    property.PageViews ??= display.GetString();
                }
            }

            // Walk child properties
            foreach (var child in element.EnumerateObject())
            {
                ExtractListingData(
                    child.Value,
                    property
                );
            }
        }
        else if (element.ValueKind == JsonValueKind.Array)
        {
            foreach (var child in element.EnumerateArray())
            {
                ExtractListingData(
                    child,
                    property
                );
            }
        }
    }
}



public class Property
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
