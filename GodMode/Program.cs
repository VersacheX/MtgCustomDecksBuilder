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
            //await CrawlSpellbook();
            //SET UP THE DB CONTEXT
            var host = CreateHostBuilder(new string[0]).Build();

            using var scope = host.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<MtgCustomDecksBuilderContext>();
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

        static async Task CrawlSpellbook()
        {

            using (var client = new HttpClient())
            {
                AddSpellbookHeaders(client);

                string[] cardsAlreadyInDeck = new string[]
                            {
                                "Lonis, Cryptozoologist", "Academy Manufactor", "Adrix and Nev, Twincasters", "An Offer You Can't Refuse",
                                "Arcane Signet", "Archaeomancer", "Beast Within", "Birthing Pod", "Bootleggers' Stash", "Brainstorm",
                                "Breeding Pool", "Command Tower", "Conjurer's Closet", "Counterspell", "Crystal Shard", "Cultivate",
                                "Deadeye Navigator", "Dreamroot Cascade", "Eldritch Evolution", "Erdwal Illuminator", "Eternal Witness",
                                "Fabricate", "Farhaven Elf", "Flooded Grove", "Forest", "Ghostly Flicker", "Gilded Lotus", "Hinterland Harbor",
                                "Idol of Oblivion", "Inspiring Statuary", "Island", "Jaheira, Friend of the Forest", "Krosan Grip",
                                "Mechanized Production", "Mystical Tutor", "Nature's Claim", "Nature's Lore", "Negate", "Neoform", "Nettlecyst",
                                "Noxious Revival", "Oko, Thief of Crowns", "Panharmonicon", "Peregrine Drake", "Pongify", "Reclamation Sage",
                                "Regrowth", "Rejuvenating Springs", "Reliquary Tower", "Repudiate // Replicate", "Second Harvest", "Shimmer Dragon",
                                "Shrieking Drake", "Simic Growth Chamber", "Snapcaster Mage", "Sol Ring", "Solve the Equation", "Spellseeker",
                                "Talisman of Curiosity", "Tamiyo's Journal", "Tamiyo's Safekeeping", "Temporal Manipulation", "Thassa, Deep-Dwelling",
                                "Thought Monitor", "Thought Vessel", "Thoughtcast", "Three Visits", "Time Warp", "Tireless Provisioner",
                                "Tireless Tracker", "Universal Surveillance", "Urza, Lord High Artificer", "Wavesifter", "Wood Elves",
                                "Worldly Tutor", "Yavimaya Coast", "Dream Stalker", "Walk the Aeons"
                            };

                var jsonData = new
                {
                    commanders = new string[] { },
                    main = cardsAlreadyInDeck
                };
                string jsonString = JsonSerializer.Serialize(jsonData);
                //var jsonData = "{\"commanders\":[],\"main\":[\"Lonis, Cryptozoologist\",\"Academy Manufactor\",\"Adrix and Nev, Twincasters\",\"An Offer You Can't Refuse\",\"Arcane Signet\",\"Archaeomancer\",\"Beast Within\",\"Birthing Pod\",\"Bootleggers' Stash\",\"Brainstorm\",\"Breeding Pool\",\"Command Tower\",\"Conjurer's Closet\",\"Counterspell\",\"Crystal Shard\",\"Cultivate\",\"Deadeye Navigator\",\"Dreamroot Cascade\",\"Eldritch Evolution\",\"Erdwal Illuminator\",\"Eternal Witness\",\"Fabricate\",\"Farhaven Elf\",\"Flooded Grove\",\"Forest\",\"Ghostly Flicker\",\"Gilded Lotus\",\"Hinterland Harbor\",\"Idol of Oblivion\",\"Inspiring Statuary\",\"Island\",\"Jaheira, Friend of the Forest\",\"Krosan Grip\",\"Mechanized Production\",\"Mystical Tutor\",\"Nature's Claim\",\"Nature's Lore\",\"Negate\",\"Neoform\",\"Nettlecyst\",\"Noxious Revival\",\"Oko, Thief of Crowns\",\"Panharmonicon\",\"Peregrine Drake\",\"Pongify\",\"Reclamation Sage\",\"Regrowth\",\"Rejuvenating Springs\",\"Reliquary Tower\",\"Repudiate // Replicate\",\"Second Harvest\",\"Shimmer Dragon\",\"Shrieking Drake\",\"Simic Growth Chamber\",\"Snapcaster Mage\",\"Sol Ring\",\"Solve the Equation\",\"Spellseeker\",\"Talisman of Curiosity\",\"Tamiyo's Journal\",\"Tamiyo's Safekeeping\",\"Temporal Manipulation\",\"Thassa, Deep-Dwelling\",\"Thought Monitor\",\"Thought Vessel\",\"Thoughtcast\",\"Three Visits\",\"Time Warp\",\"Tireless Provisioner\",\"Tireless Tracker\",\"Universal Surveillance\",\"Urza, Lord High Artificer\",\"Wavesifter\",\"Wood Elves\",\"Worldly Tutor\",\"Yavimaya Coast\",\"Dream Stalker\",\"Walk the Aeons\"]}";

                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync("https://backend.commanderspellbook.com/find-my-combos", content);
                var responseString = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseString))
                {
                    #region Get included and almost included sections of Spellbook results
                    JsonElement root = doc.RootElement;
                    JsonElement results = root.GetProperty("results");
                    JsonElement includedArray = results.GetProperty("included");

                    var includedList = JsonSerializer.Deserialize<List<Included>>(includedArray.GetRawText());

                    if (includedList == null)
                    {
                        throw new Exception("Failed to parse the included array.");
                    }

                    JsonElement almostIncludedArray = results.GetProperty("almostIncluded");
                    var almostIncludedList = JsonSerializer.Deserialize<List<Included>>(almostIncludedArray.GetRawText());
                    if (almostIncludedList == null)
                    {
                        throw new Exception("Failed to parse the almost Included array.");
                    }
                    #endregion

                    //Get Distinct cards from the list
                    var almostIncludedCardNames = almostIncludedList
                        .SelectMany(included => included.Uses.Select(use => use.Card.Name))
                        .Distinct()
                        .ToList();



                    //SET UP THE DB CONTEXT
                    var host = CreateHostBuilder(new string[0]).Build();

                    using var scope = host.Services.CreateScope();
                    var dbContext = scope.ServiceProvider.GetRequiredService<MtgCustomDecksBuilderContext>();
                    /////////////////////////////////////////////////////////////////////////////
                    // Step 2: Perform the complex filtering in-memory
                    var distinctMtgCards = dbContext.MtgCards
                        .Include(card => card.MtgCardLegalities)
                        .Include(card => card.MtgCardSets)
                            .ThenInclude(cardSet => cardSet.MtgSetFkNavigation)
                        .Where(card => almostIncludedCardNames.Contains(card.Name))
                        .GroupBy(card => card.Name)
                        .Select(group => MtgCardDto.FromEntity(group.First()))
                        .ToList();


                    // Step 3: Further filter the cards as needed
                    var filteredCards = distinctMtgCards
                        .Where(card => !cardsAlreadyInDeck.Contains(card.Name))
                        .ToList();


                    // FILTER BY HOMEBREW
                    var selectedHomebrew = dbContext.DeckRuleCriteria
                        .Include(drc => drc.GameFormatFkNavigation)
                        .Include(drc => drc.DeckRuleCriteriaAllowedSets)
                            .ThenInclude(allowedSet => allowedSet.MtgSetFkNavigation)
                        .Include(drc => drc.DeckRuleCriteriaSetTypes)
                            .ThenInclude(setType => setType.SetTypeFkNavigation)
                        .AsEnumerable()
                        .Select(drc => HomebrewDto.FromEntity(drc))
                        .FirstOrDefault();

                    var legalCards = filteredCards
                        .Where(card => selectedHomebrew.IsCardLegal(card))
                        .ToList();

                    foreach (var card in legalCards)
                    {
                        Console.WriteLine($"Name: {card.Name}, Set Type: {card.MtgCardSets.First().SetType} - {string.Concat(card.MtgCardSets.Select(x => x.SetName))}");
                    }
                }
            }
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