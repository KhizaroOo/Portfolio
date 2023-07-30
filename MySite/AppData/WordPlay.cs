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
            Tags = "[\"WordPlay\",\"\",]",
            Slug = "Green-Skirt-Girl-Sticky-Note-Art",
            DataGroup = "[\"all\",\"stickynotes\"]",
            Heading = "Green Skirt Girl - Sticky Note - Art",
            Title = "Green Skirt Girl",
            SubTitle = "Sticky Note - Art",
            IMG = "/images/MyArts/Green-Skirt-Girl.avif",
            VIDEO = "",
            Desription = "<p class='Art-Detail-Text'>Welcome to my creative domain, where even a sticky note changes into a spellbinding show-stopper. How about we find the captivating universe of workmanship on sticky notes.</p><p class='Art-Detail-Text'>In this blog entry, I welcome you to dive into the captivating universe of my most recent drawing named \"Green Skirt Young lady\". A young lady wearing a delightful green concealed long skirt and a perfect white top, her multi-concealed earthy colored hair flowing with beauty. Get ready to be spellbound as we investigate the motivation, the interaction, and the sheer magnificence of this craftsmanship piece.</p><p class='Art-Detail-Text'>Each stroke of my pencil was an ongoing source of both pain and joy, cautiously making the many-sided subtleties that rejuvenate this young lady. The white top decorating her reflects virtue, honesty, and a feeling of ethereal excellence. The multi-concealed earthy colored hair is an embroidery of tones, catching the intricacy and uniqueness of the human soul. It murmurs accounts of versatility, development, and the incalculable encounters that shape our lives.</p><p class='Art-Detail-Text'>We should utilize the force of workmanship to elevate, rouse, and the vast potential outcomes that unfurl when innovativeness exceeds all logical limitations.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='https://opensea.io/KhizoOo_'>MORE</a>] to visit my OpenSea account.\n</p>",
            Type = "Art",
            Category = "Sticky Note",
            CreatedOn = "27th JAN 2023",

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

