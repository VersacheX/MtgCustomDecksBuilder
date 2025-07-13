using Bobj;
using BObj.Dto;
using BObj.External;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Schema;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace God
{
    class Program
    {
        static HttpClient AddSpellbookHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-language", "en-US,en;q=0.9");
            client.DefaultRequestHeaders.Add("origin", "https://commanderspellbook.com");
            client.DefaultRequestHeaders.Add("priority", "u=1, i");
            client.DefaultRequestHeaders.Add("referer", "https://commanderspellbook.com/");
            client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not)A;Brand\";v=\"99\", \"Microsoft Edge\";v=\"127\", \"Chromium\";v=\"127\"");
            client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
            client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
            client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
            client.DefaultRequestHeaders.Add("sec-fetch-site", "same-site");
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/127.0.0.0 Safari/537.36 Edg/127.0.0.0");

            return client;
        }

        static async Task Main(string[] args)
        {
            #region SET UP THE DB CONTEXT FOR GOD MODE - DO NOT DELETE
            //SET UP THE DB CONTEXT
            var host = CreateHostBuilder(new string[0]).Build();

            using var scope = host.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<MtgCustomDecksBuilderContext>();
            #endregion



            var deckRuleCriterion = dbContext.DeckRuleCriteria
                .Include(d => d.GameFormatFkNavigation)
                .Include(d => d.DeckRuleCriteriaAllowedSets)
                    .ThenInclude(allowedSet => allowedSet.MtgSetFkNavigation)
                .Include(d => d.DeckRuleCriteriaSetTypes)
                    .ThenInclude(setType => setType.SetTypeFkNavigation)
                .First();
            EdhrecDto dto = await EdhrecApi.SourceEdhRecData(new EdhrecApi.EdhrecSearchCriteria()
            {
                CommanderName = "Nicol Bolas",
                Homebrew = HomebrewDto.FromEntity(deckRuleCriterion)
            }, null);
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<MtgCustomDecksBuilderContext>(options =>
                    {
                        options.UseSqlServer("Data Source=DESKTOP-3K6IPDC;Initial Catalog=MtgCustomDecksBuilder;Integrated Security=True;Trust Server Certificate=True");
#if DEBUG
                        //options.EnableSensitiveDataLogging(); // Enable sensitive data logging
                        //options.EnableDetailedErrors(); // Enable detailed error messages
#endif
                    });
                });
    }
}