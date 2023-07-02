using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MySite.AppData
{
	public class Art
	{

        public long ID { get; set; }
        public string URL { get; set; }
        public string LiveURL { get; set; }
        public string Tags { get; set; }
        public string Slug { get; set; }
        public string DataGroup { get; set; }
        public string Heading { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string IMG { get; set; }
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
    }

    public class MyArts
    {
        public static string BASEPATH = "http://localhost:5064";

        private List<Art> MyAllyArts = new List<Art>()
        { 
          new Art()
          {
              ID = 1,
              URL = BASEPATH + "/MyArt/1/Green-Skirt-Girl-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Green-Skirt-Girl-Sticky-Note-Art",
              DataGroup = "[\"all\",\"sticknotes\"]",
              Heading = "Green Skirt Girl - Sticky Note - Art",
              Title = "Green Skirt Girl",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Green-Skirt-Girl.avif",
              Desription = "<p class='Art-Detail-Text'>Welcome to my creative domain, where even a sticky note changes into a spellbinding show-stopper. How about we find the captivating universe of workmanship on sticky notes.</p><p class='Art-Detail-Text'>In this blog entry, I welcome you to dive into the captivating universe of my most recent drawing named \"Green Skirt Young lady\". A young lady wearing a delightful green concealed long skirt and a perfect white top, her multi-concealed earthy colored hair flowing with beauty. Get ready to be spellbound as we investigate the motivation, the interaction, and the sheer magnificence of this craftsmanship piece.</p><p class='Art-Detail-Text'>Each stroke of my pencil was an ongoing source of both pain and joy, cautiously making the many-sided subtleties that rejuvenate this young lady. The white top decorating her reflects virtue, honesty, and a feeling of ethereal excellence. The multi-concealed earthy colored hair is an embroidery of tones, catching the intricacy and uniqueness of the human soul. It murmurs accounts of versatility, development, and the incalculable encounters that shape our lives.</p><p class='Art-Detail-Text'>We should utilize the force of workmanship to elevate, rouse, and the vast potential outcomes that unfurl when innovativeness exceeds all logical limitations.</p><p class='Art-Detail-Text'>Visit [MORE] to investigate a greater amount of my enamoring drawings and leave on an excursion of imaginative articulation.\n",
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
          } 
        };

        public List<Art> GetMyArts(int Count)
        {
            List<Art> Data = new List<Art>();
            Data = MyAllyArts.Take(Count).ToList();
            return Data;
        }

        public Art GetMyArt(long ID)
        {
            Art Data = new Art();
            Data = MyAllyArts.FirstOrDefault(A => A.ID == ID);
            return Data;
        }

        public Art GetMyArt(string Slug)
        {
            Art Data = new Art();
            Data = MyAllyArts.FirstOrDefault(A => A.Slug == Slug);
            return Data;
        }

        public Art GetMyArt(long ID , string Slug)
        {
            Art Data = new Art();
            Data = MyAllyArts.FirstOrDefault(A => A.ID == ID && A.Slug == Slug);
            return Data;
        }

    }

}

