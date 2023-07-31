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

    private List<WordPlay> MyAllWordPlays = new List<WordPlay>()
    {
        new WordPlay()
        {
            ID = 1,
            URL = BASEPATH + "/MyWordPlay/Blockchain/How-Blockchain-Works",
            SITE_URL = "/MyWordPlay/Blockchain/How-Blockchain-Works",
            Tags = "[\"WordPlay\",\"InfoGraphic\", \"Blockchain\"]",
            Slug = "How-Blockchain-Works",
            DataGroup = "[\"all\",\"technology\"]",
            Heading = "How Blockchain Works - Blockchain - Wordplay",
            Title = "How Blockchain Works",
            SubTitle = "Blockchain - Wordplay",
            IMG = "/images/MyWordplay/Blockchain/How-Blockchain-Works.jpg",
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

    public List<WordPlay> GetMyWordPlays(int Count)
    {
        List<WordPlay> Data = new List<WordPlay>();
        Data = MyAllWordPlays.Take(Count).ToList();
        return Data;
    }

    public WordPlay GetMyWordPlay(long ID)
    {
        WordPlay Data = new WordPlay();
        Data = MyAllWordPlays.FirstOrDefault(A => A.ID == ID);
        return Data;
    }

    public WordPlay GetMyWordPlay(string Slug)
    {
        WordPlay Data = new WordPlay();
        Data = MyAllWordPlays.FirstOrDefault(A => A.Slug == Slug);
        return Data;
    }

    public WordPlay GetMyWordPlay(long ID, string Slug)
    {
        WordPlay Data = new WordPlay();
        Data = MyAllWordPlays.FirstOrDefault(A => A.ID == ID && A.Slug == Slug);
        return Data;
    }

    }

}

