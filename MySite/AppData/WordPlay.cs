using System;
namespace MySite.AppData
{
	
    public class WordPlay
    {
        public long ID { get; set; }
        public string URL { get; set; }
        public string SITE_URL { get; set; }
        public string LiveURL { get; set; }
        public string Tags { get; set; }
        public string Slug { get; set; }
        public string DataGroup { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string IMG { get; set; }
        public string VIDEO { get; set; }
        public string Desription { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string CreatedOn { get; set; }

        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string YouTube { get; set; }
        public string OpenSea { get; set; }
        public string Twitter { get; set; }
        public string TikTok { get; set; }
        public string LinkedIn { get; set; }
        public string Pinterest { get; set; }
        public string Snapchat { get; set; }

        public long PreviousWorkID { get; set; }
        public long NextWorkID { get; set; }

        // PENDINGS
        public long ModuleID { get; set; }
    }

    public class MyWordPlays
    {
        public static string BASEPATH = "http://localhost:5064";

    private List<Module> Modules = new List<Module>()
    {
        new Module(){ ID = 1 , Title = "Landing Page To Display" },
        new Module(){ ID = 2 , Title = "Landing Page Listing" },
        new Module(){ ID = 3 , Title = "Complete Listing Page" },
        new Module(){ ID = 4 , Title = "Detail Page" },
    };

    private List<WordPlay> MyAllWordPlays = new List<WordPlay>()
    {
        new WordPlay()
        {
            ID = 1,
            URL = BASEPATH + "/MyWordPlay/1/How-Blockchain-Works",
            SITE_URL = "/MyWordPlay/1/How-Blockchain-Works",
            Tags = "[\"WordPlay\",\"InfoGraphic\",]",
            Slug = "How-Blockchain-Works",
            DataGroup = "[\"all\",\"technology\"]",
            Heading = "How Blockchain Works - Blockchain - Wordplay",
            Title = "Green Skirt Girl",
            SubTitle = "Sticky Note - Art",
            IMG = "/images/MyTech/Blockchain/How-Blockchain-Works.jpg",
            VIDEO = "",
            Desription = "",
            Type = "Wordplay",
            Category = "Technologies",
            CreatedOn = "30th JUL 2023",

            Facebook = "",
            Instagram = "",
            LinkedIn = "",
            YouTube = "",
            OpenSea = "",
            Twitter = "",
            TikTok = "",
            Pinterest = "",
            Snapchat = "",

            PreviousWorkID = 0,
            NextWorkID = 2
        },
    };

    public List<WordPlay> GetMyTechs(int Count)
    {
        List<WordPlay> Data = new List<WordPlay>();
        Data = MyAllWordPlays.Take(Count).ToList();
        return Data;
    }

    public WordPlay GetMyArt(long ID)
    {
        WordPlay Data = new WordPlay();
        Data = MyAllWordPlays.FirstOrDefault(A => A.ID == ID);
        return Data;
    }

    public WordPlay GetMyArt(string Slug)
    {
        WordPlay Data = new WordPlay();
        Data = MyAllWordPlays.FirstOrDefault(A => A.Slug == Slug);
        return Data;
    }

    public WordPlay GetMyArt(long ID, string Slug)
    {
        WordPlay Data = new WordPlay();
        Data = MyAllWordPlays.FirstOrDefault(A => A.ID == ID && A.Slug == Slug);
        return Data;
    }

    }

}

