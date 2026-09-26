using System.Net;
using System.Security.Cryptography.X509Certificates;
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
        using var request = new HttpRequestMessage(HttpMethod.Get, "https://realestate.com.au/buy/list-1");

        var cookies = "Country=AU;"
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
            + "KP_UIDz=06gyeJZJDZyE8h773OdBmqVWf1gszb8rSJOt7YNXzSNlFOH6pj8nmbsGfRBaKs5IkuCA3ihAcB2E8qzKbx4j48CPsrh1GISikivatIG1bTCf5pto4qyO87oveCYxl9ZWREOChskHtlYpti28pUbhgc3dwf2YYy1g3q3kVInbefiyonm3gtG0t8ix4GmmpwP32lsjji;" //This is likely part of the site's anti-bot/client-validation system
            // + "KP_UIDz-ssn=06gyeJZJDZyE8h773OdBmqVWf1gszb8rSJOt7YNXzSNlFOH6pj8nmbsGfRBaKs5IkuCA3ihAcB2E8qzKbx4j48CPsrh1GISikivatIG1bTCf5pto4qyO87oveCYxl9ZWREOChskHtlYpti28pUbhgc3dwf2YYy1g3q3kVInbefiyonm3gtG0t8ix4GmmpwP32lsjji;"
            // + "s_nr30=1790325443677-Repeat;"
            // + "_ga_3J0XCBB972=GS2.1.s1790325438$o3$g1$t1790325443$j55$l0$h0;"
            // + "_sp_id.2fe7=2e2f731c-06d9-4b1c-bb77-f9e2b075e93e.1790305150.3.1790325456.1790316530.131addb2-bcaa-4a5d-8ac6-dbc6688704ca;"
            // + "utag_main=v_id:01a0d680a2370001c6a9b7917ec40506f002f06700bd0$_sn:3$_se:3%3Bexp-session$_ss:0%3Bexp-session$_st:1790327256139%3Bexp-session$ses_id:1790325437917%3Bexp-session$_pn:2%3Bexp-session$vapi_domain:realestate.com.au$dc_visit:1$dc_event:13%3Bexp-session$dc_region:ap-southeast-2%3Bexp-session$ttd_uuid:bbdafc0d-b19d-4a4f-a223-b2e92c467b01%3Bexp-session$adform_uid:5770065559996774620%3Bexp-session$_prevpage:rea%3Ahomepage%3Bexp-1790329056142;"
            // + "s_sq=rea-group-global-live%3D%2526c.%2526a.%2526activitymap.%2526page%253Drea%25253Ahomepage%2526link%253DSearch%2526region%253DheroImage%2526pageIDType%253D1%2526.activitymap%2526.a%2526.c%2526pid%253Drea%25253Ahomepage%2526pidt%253D1%2526oid%253DfunctionJt%252528%252529%25257B%25257D%2526oidt%253D2%2526ot%253DSUBMIT"
            ;
  
        request.Headers.TryAddWithoutValidation("cookie", cookies);

        request.Headers.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36");
        request.Headers.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
        request.Headers.TryAddWithoutValidation("Accept-Language", "en-AU,en;q=0.9");
        request.Headers.TryAddWithoutValidation("Referer", "https://www.realestate.com.au");
        request.Headers.TryAddWithoutValidation("Connection", "keep-alive");
        request.Headers.TryAddWithoutValidation("Upgrade-Insecure-Requests", "1");
        request.Headers.TryAddWithoutValidation("sec-ch-ua", "\"Chromium\";v=\"127\", \"Not)A;Brand\";v=\"99\"");
        request.Headers.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
        request.Headers.TryAddWithoutValidation("sec-ch-ua-platform", "\"Windows\"");
        // request.Headers.TryAddWithoutValidation("X-Kpsdk-Ct", "07L5fE3OLBNy0ln0ZUPDkgsy65wJcryWGhVcMGLGwUUSvBhBUtHI49UQFquIX4uvuOvMesBGfnuiykfzHWt5UN3NrrFy1BfzYfYY4DIUoexPNaTFxQphysM5yuxD4Xc4AYIqy2PPwVdsv6O0birSqwE2z2ygAEWWmyOROSiEpc4J3hpeQUwq4ZZ7wWd4lksMQvz610");
        // request.Headers.TryAddWithoutValidation("X-Kpsdk-R", "1-BwB7A1Y");



        try
        {
            var response = await httpClient.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            await File.WriteAllTextAsync(Path.Combine(Directory.GetCurrentDirectory(), "result.html"), body);

            var doc = new HtmlDocument();
            doc.LoadHtml(body);

            string? streetAddress = null;
            string? suburb = null;
            string? state = null;
            string? postcode = null;
            string? description = null;
            string? detailImage = null;
            string? canonicalUrl = null;

            var propertyCards = doc.DocumentNode.SelectNodes("//article[@data-testid='ResidentialCard']");

            if (propertyCards == null)
            {
                Console.WriteLine("No properties found.");
                return;
            }

            foreach (var card in propertyCards)
            {
                var price = card
                    .SelectSingleNode(".//span[contains(@class, 'property-price')]")
                    ?.InnerText
                    .Trim();

                var addressNode = card.SelectSingleNode(
                    ".//h2[contains(@class, 'residential-card__address-heading')]/a"
                );

                var address = addressNode?
                    .InnerText
                    .Trim();

                var href = addressNode?
                    .GetAttributeValue("href", "");

                var image = card
                    .SelectSingleNode(".//div[@data-testid='PropertyImage']")
                    ?.GetAttributeValue("data-url", "");

                var agent = card
                    .SelectSingleNode(".//div[contains(@class, 'agent')]")
                    ?.GetAttributeValue("aria-label", "")
                    .Replace("Agent ", "");

                try
                {
                    using var request2 = new HttpRequestMessage(HttpMethod.Get, "https://realestate.com.au/" + href);
                    var response2 = await httpClient.SendAsync(request2);
                    response2.EnsureSuccessStatusCode();
                    var body2 = await response2.Content.ReadAsStringAsync();
                    var doc2 = new HtmlDocument();
                    doc2.LoadHtml(body2);

                    // Meta description
                    description = doc2.DocumentNode
                        .SelectSingleNode("//meta[@name='description']")
                        ?.GetAttributeValue("content", null);

                    // Main property image
                    detailImage = doc2.DocumentNode
                        .SelectSingleNode("//meta[@property='og:image']")
                        ?.GetAttributeValue("content", null);

                    // Canonical URL
                    canonicalUrl = doc2.DocumentNode
                        .SelectSingleNode("//link[@rel='canonical']")
                        ?.GetAttributeValue("href", null);

                    //here
                    

                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }

                Console.WriteLine($"Price:       {price}");
                Console.WriteLine($"Address:     {address}");
                Console.WriteLine($"Street:      {streetAddress}");
                Console.WriteLine($"Suburb:      {suburb}");
                Console.WriteLine($"State:       {state}");
                Console.WriteLine($"Postcode:    {postcode}");
                Console.WriteLine($"URL:         {href}");
                Console.WriteLine($"Canonical:   {canonicalUrl}");
                Console.WriteLine($"Image:       {image}");
                Console.WriteLine($"DetailImage: {detailImage}");
                Console.WriteLine($"Agent:       {agent}");
                Console.WriteLine($"Description: {description}");
            }

        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }
}

public class Property
{
    public string? ListingId { get; set; }

    public string? Address { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Price { get; set; }

    public int? Bedrooms { get; set; }

    public int? Bathrooms { get; set; }

    public int? CarSpaces { get; set; }

    public double? LandSize { get; set; }

    public string? PropertyType { get; set; }

    public string? MainImage { get; set; }

    public string? Url { get; set; }

    public string? AgentName { get; set; }
}
