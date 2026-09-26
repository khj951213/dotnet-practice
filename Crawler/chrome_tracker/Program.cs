using Microsoft.Playwright;

namespace chrome_tracker;

public class Program
{
    public static async Task Main(string[] args)
    {
        using var playwright = await Playwright.CreateAsync();

        // 이미 실행 중인 Chrome에 연결
        var browser = await playwright.Chromium.ConnectOverCDPAsync(
            "http://localhost:9222"
        );

        Console.WriteLine("Connected to Chrome");

        var context = browser.Contexts.FirstOrDefault();

        if (context == null)
        {
            Console.WriteLine("No browser context found.");
            return;
        }

        var page = context.Pages.FirstOrDefault();

        if (page == null)
        {
            page = await context.NewPageAsync();
        }

        Console.WriteLine($"Current URL: {page.Url}");

        // 페이지 이동 감지
        page.FrameNavigated += async (_, frame) =>
        {
            if (frame != page.MainFrame)
                return;

            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine($"Navigated: {frame.Url}");

            try
            {
                Console.WriteLine(
                    $"Title: {await page.TitleAsync()}"
                );
            }
            catch
            {
            }
        };

        while (true)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine($"URL: {page.Url}");

                string title = await page.TitleAsync();

                Console.WriteLine($"Title: {title}");

                await Task.Delay(3000);
            }
            catch
            {
                await Task.Delay(1000);
            }
        }
    }
}