using AngleSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace dndb.Cards.Parser
{
    public class CharacterLoader
    {
        private DirectoryInfo _campaignDownloadDir;
        private string _campaign;
        public CharacterLoader(string campaign)
        {
            _campaign = campaign;
            SetupDownloadPath(campaign);
        }

        private void SetupDownloadPath(string campaign)
        {
            DirectoryInfo downloadDir = new DirectoryInfo("downloads");
            if (!downloadDir.Exists)
            {
                downloadDir.Create();
            }
            _campaignDownloadDir = downloadDir.GetDirectories().FirstOrDefault(x => x.Name == campaign);

            if (_campaignDownloadDir==null)
            {
                _campaignDownloadDir = downloadDir.CreateSubdirectory(campaign);
            }
            
        }
        public List<string> GetDownloadedImagePaths()
        {
            return _campaignDownloadDir.GetFiles("*.png")
                .Select(x=>x.FullName)
                .ToList();
        }

        /**
            example see below, og:image is the card image with the background rendered on the ddb

                <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# article: http://ogp.me/ns/article#">
                <meta charset="UTF-8">
                <title>Gurandor - D&amp;D Beyond </title>
                <meta name="description" content="" />
                <meta name="theme-color" content="#121212" />

                <!-- Responsive Meta Tag -->
                <meta name="viewport" content="width=device-width, initial-scale = 1.0, maximum-scale=1.0, user-scalable=no" />

                <link rel="shortcut icon" href="https://media-waterdeep.cursecdn.com/avatars/thumbnails/104/378/32/32/636511944060210307.png" />
                <link rel="search" href="https://www.dndbeyond.com/opensearch.xml" type="application/opensearchdescription+xml" title="Gurandor - D&amp;D Beyond"/>

                <!-- Links -->
                <!-- Meta Properties -->
                <meta property="og:title" content="Gurandor" />
                <meta property="og:site_name" content="D&D Beyond" />
                <meta property="og:type" content="website" />
                <meta property="og:url" content="/characters/7577901" />
                <meta property="og:description" content="D&D Beyond Character Sheet" />
                <meta property="og:image" content="https://media-waterdeep.cursecdn.com/avatars/8151/124/637128849452544732.jpeg" />
                <meta property="twitter:image" content="https://media-waterdeep.cursecdn.com/avatars/8151/124/637128849452544732.jpeg" />
                <meta name="twitter:card" content="summary_large_image" />
                <meta name="twitter:site" content="D&D Beyond" />
                <meta name="twitter:title" content="Gurandor" />
                <meta name="twitter:description" content="D&D Beyond Character Sheet" />
        **/



        public async Task LoadSingleCharacterAsync(string url)
        {
            try
            {
                var config = Configuration.Default.WithDefaultLoader();
                var address = url;
                var context = BrowsingContext.New(config);
                var document = await context.OpenAsync(address);

                var ogImageSelector = "meta[property=og\\:image]";

                var ogElement = document.Head.QuerySelector(ogImageSelector);
                var ogImageUrl = ogElement.GetAttribute("content");


                //<meta property="og:title" content="Gurandor" />
                var ogTitleSelector = "meta[property=og\\:title]";
                var ogTitleElement = document.Head.QuerySelector(ogTitleSelector);
                var ogTitle = ogTitleElement.GetAttribute("content");
                var downloadPath = Path.Combine(_campaignDownloadDir.FullName, ogTitle + ".png");

                using (var client = new HttpClient())
                using (var file = new FileStream(path: downloadPath, FileMode.OpenOrCreate))
                {
                    var response = await client.GetAsync(ogImageUrl);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var memstream = await response.Content.ReadAsStreamAsync();
                        await memstream.CopyToAsync(file);
                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
            

        }
    }
}
