using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace MyDotNetApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            var jsonData = System.IO.File.ReadAllText("Data/sampledata.json");
            var data = JsonSerializer.Deserialize<SampleData>(jsonData);
            Message = data?.Message ?? "No message";
        }
    }

    public class SampleData
    {
        public string Message { get; set; } = string.Empty;

        public string Date { get; set; } = string.Empty;

    }
}
