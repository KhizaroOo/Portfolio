using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MySite.AppData
{
	public class Art
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
              SITE_URL = "/MyArt/1/Green-Skirt-Girl-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Green-Skirt-Girl-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Green Skirt Girl - Sticky Note - Art",
              Title = "Green Skirt Girl",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Green-Skirt-Girl.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my creative domain, where even a sticky note changes into a spellbinding show-stopper. How about we find the captivating universe of workmanship on sticky notes.</p><p class='Art-Detail-Text'>In this blog entry, I welcome you to dive into the captivating universe of my most recent drawing named \"Green Skirt Young lady\". A young lady wearing a delightful green concealed long skirt and a perfect white top, her multi-concealed earthy colored hair flowing with beauty. Get ready to be spellbound as we investigate the motivation, the interaction, and the sheer magnificence of this craftsmanship piece.</p><p class='Art-Detail-Text'>Each stroke of my pencil was an ongoing source of both pain and joy, cautiously making the many-sided subtleties that rejuvenate this young lady. The white top decorating her reflects virtue, honesty, and a feeling of ethereal excellence. The multi-concealed earthy colored hair is an embroidery of tones, catching the intricacy and uniqueness of the human soul. It murmurs accounts of versatility, development, and the incalculable encounters that shape our lives.</p><p class='Art-Detail-Text'>We should utilize the force of workmanship to elevate, rouse, and the vast potential outcomes that unfurl when innovativeness exceeds all logical limitations.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
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
          new Art()
          {
              ID = 2,
              URL = BASEPATH + "/MyArt/2/Bearded-Man-Sticky-Note-Art",
              SITE_URL = "/MyArt/2/Bearded-Man-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Bearded-Man-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Bearded Man - Sticky Note - Art",
              Title = "Bearded Man",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Bearded-Man.avif",
              VIDEO = "",
              Desription = @"<p class='Art-Detail-Text'>Discover the beauty in my latest artistic creation. A remarkable drawing of a bearded man on a sticky note. Through intricate strokes and masterful shading.</p><p class='Art-Detail-Text'>In this drawing, the bearded man's facial hair serves as an emblem of wisdom, strength, and rugged individuality. Every pen stroke delicately captures the coarse texture of the beard, revealing the dedication and patience required to nurture such an impressive growth.</p><p class='Art-Detail-Text'>My carefully crafted lines bring life to the bearded man's expressive eyes, exuding a sense of wisdom and experience. His eyes hint at hidden stories and invite viewers to imagine the adventures and knowledge he carries within.</p><p class='Art-Detail-Text'>Rendered on a humble sticky note, this art piece challenges the boundaries of creativity, reminding us that true artistry transcends the limitations of canvas or size. It is a testament to my ability to transform the ordinary into the extraordinary, turning a mundane office supply into a window to a world of imagination.</p><p class='Art-Detail-Text'>Allow this remarkable bearded man to captivate your senses, beckoning you to delve deeper into the realms of human complexity. Explore the power of a single artwork to tell a thousand tales, and join us on our website as we celebrate the fusion of art and inspiration.\ <p class=""Art-Detail-Text"">Visit[<a class=""L-C"" href=""/MyWorkFlow-MyArtfulness"">MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "1st FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 1,
              NextWorkID = 3
          },
          new Art()
          {
              ID = 3,
              URL = BASEPATH + "/MyArt/3/Midnight-Muse-Sticky-Note-Art",
              SITE_URL = "/MyArt/3/Midnight-Muse-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Midnight-Muse-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Midnight Muse - Sticky Note - Art",
              Title = "Midnight Muse",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Midnight-Muse.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>The phrase \"Midnight\" evokes a sense of mystery and darkness, which contrasts with her radiant beauty.</p><p class='Art-Detail-Text'>The word \"Muse\" typically refers to a source of inspiration, and in this case, her beauty could be seen as inspiring others around her.</p><p class='Art-Detail-Text'>Overall, the title \"Midnight Muse\" conveys a sense of intrigue, beauty, and inspiration, making it a suitable title for the given context.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "3rd FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 2,
              NextWorkID = 4
          },
          new Art()
          {
              ID = 4,
              URL = BASEPATH + "/MyArt/4/Fire-Heart-Sticky-Note-Art",
              SITE_URL = "/MyArt/4/Fire-Heart-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Fire-Heart-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Fire Heart - Sticky Note - Art",
              Title = "Fire Heart",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Fire-Heart.avif",
              VIDEO = "/images/MyArts/Fire-Heart.mp4",
              Desription = "<p class='Art-Detail-Text'>This art belongs to a lovely story of a young boy and a beautiful girl with some magical abilities.</p><p class='Art-Detail-Text'>Here is the story which i named “Fire Heart”\n \nOnce upon a time, in a small village tucked away in the rolling hills of a distant land, there lived a young boy named Kian. Kian was a simple boy, born into a family of farmers. He had a passion for tending the fields and caring for the livestock, but there was always something missing in his life.</p><p class='Art-Detail-Text'>One day, as he was walking through the fields, he saw a girl standing in the distance. She was unlike anyone he had ever seen before. She had fiery red hair, and her eyes sparkled like embers. Kian was immediately smitten.</p><p class='Art-Detail-Text'>The girl's name was Aria, and she too was from the village. But Aria was special. She possessed the power of fire, a rare and wondrous gift that she struggled to control. Kian was fascinated by her, and he found himself drawn to her like a lover.</p><p class='Art-Detail-Text'>Despite her fiery nature, Aria was shy and hesitant to open up to Kian. But as they spent more time together, they began to develop a deep connection. Kian's gentle nature and unwavering support made Aria feel safe and loved, and she slowly began to let down her guard.</p><p class='Art-Detail-Text'>As their relationship blossomed, Aria's powers began to grow stronger. She learned to harness her fiery energy, using it to light up the night sky and warm the hearts of those around her. Kian was always there to support her, never once flinching in the face of her powerful flames.</p><p class='Art-Detail-Text'>Together, Kian and Aria faced many challenges, but their love never wavered. They were a perfect match, a simple boy and a girl with the power of fire. And in the end, their love burned brighter than any flame, lighting up the sky for all to see.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "7th FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 3,
              NextWorkID = 5
          },
          new Art()
          {
              ID = 5,
              URL = BASEPATH + "/MyArt/5/Junior-Professor-Sticky-Note-Art",
              SITE_URL = "/MyArt/5/Junior-Professor-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Junior-Professor-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Junior Professor - Sticky Note - Art",
              Title = "Junior Professor",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Junior-Professor.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>A captivating cartoon depiction of a Junior Professor. Which is carefully sketched on a sticky note. In this charming creation, education meets playfulness, and wisdom is delivered with a smile.</p><p class='Art-Detail-Text'>On this small canvas, every line and curve comes alive, revealing the artist's ability to infuse personality into every stroke. From the carefully tousled hair to the endearing bow tie, this Junior Professor becomes an embodiment of the passion and dedication that fuel the pursuit of academia.</p><p class='Art-Detail-Text'>In a world that often takes itself too seriously, this delightful artwork reminds us that learning should be a joyful journey. The Junior Professor's mischievous grin and raised eyebrow invite us to approach education with a playful spirit, encouraging us to explore, question, and embrace new ideas.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "11th FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 4,
              NextWorkID = 6
          },
          new Art()
          {
              ID = 6,
              URL = BASEPATH + "/MyArt/6/Colorful-Elephant-Sticky-Note-Art",
              SITE_URL = "/MyArt/6/Colorful-Elephant-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Colorful-Elephant-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Colorful Elephant - Sticky Note - Art",
              Title = "Colorful Elephant",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Colorful-Elephant.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>This stunning artwork captures the majesty and grace of these magnificent creatures, using vibrant hues and intricate details to create a truly mesmerizing image.</p><p class='Art-Detail-Text'>Whether you're a lover of animals, art, or simply appreciate the finer things in life, a colorful elephant painting is sure to brighten up any space.</p><p class='Art-Detail-Text'>Rendered on a tiny sticky note, this artwork defies the boundaries of conventional canvases, proving that true artistry knows no limitations. It invites us to see the extraordinary in the ordinary, turning a simple office supply into a portal to a world where imagination reigns supreme.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "16th FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 5,
              NextWorkID = 7
          },
          new Art()
          {
              ID = 7,
              URL = BASEPATH + "/MyArt/7/Peak-Perfection-Sticky-Note-Art",
              SITE_URL = "/MyArt/7/Peak-Perfection-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Peak-Perfection-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Peak Perfection - Sticky Note - Art",
              Title = "Peak Perfection",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Peak-Perfection.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>A charming house perched at the summit of a majestic mountain, drawn on a sticky note. This miniature artwork effortlessly transports you to a world of serenity and natural beauty.</p><p class='Art-Detail-Text'>\"Peak Perfection\" is The Splendor of Living on a Mountain.</p><p class='Art-Detail-Text'>Allow the vision of this mountain retreat to transport you to a place of serenity, and discover the transformative power of art on the most unexpected canvas.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "19th FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 6,
              NextWorkID = 8
          },
          new Art()
          {
              ID = 8,
              URL = BASEPATH + "/MyArt/8/The-Spot-Sticky-Note-Art",
              SITE_URL = "/MyArt/8/The-Spot-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "The-Spot-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "The Spot - Sticky Note - Art",
              Title = "The Spot",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/The-Spot.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Beautifully built houses on a large tree. ‘The Spot’ is the place of healers.</p><p class='Art-Detail-Text'>This could refer to a hidden or secret location that people go to for various reasons. It could be a spot where people go to relax, a spot where people go to hide, or even a spot where people go to party.</p><p class='Art-Detail-Text'>Drawing on a humble sticky note, this art piece challenges the boundaries of creativity</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "26th FEB 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 7,
              NextWorkID = 9
          },
          new Art()
          {
              ID = 9,
              URL = BASEPATH + "/MyArt/9/Young-Girl-vs-Dark-Wind-Sticky-Note-Art",
              SITE_URL = "/MyArt/9/Young-Girl-vs-Dark-Wind-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Young-Girl-vs-Dark-Wind-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Young Girl vs Dark Wind - Sticky Note - Art",
              Title = "Young Girl vs Dark Wind",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Young-Girl-vs-Dark-Wind.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>This art belongs to a beautiful story named “Young Girl vs Dark Wind”. So here is the story.</p><p class='Art-Detail-Text'>In a village, there lived a young girl named Mia. She was a curious and kind-hearted girl with a love for animals. One day, while exploring the nearby woods, she stumbled upon a wounded bird with a broken wing. Mia's heart filled with compassion, and she gently picked up the bird, vowing to help it.</p><p class='Art-Detail-Text'>Mia took the bird home and made a cozy nest for it. She carefully splinted its wing and provided food and water. Day by day, the bird grew stronger under Mia's tender care. As it healed, they formed a special bond.</p><p class='Art-Detail-Text'>One evening, as Mia sat near the window, a soft melody filled the air. The bird, now able to fly, perched on her windowsill and chirped joyfully. Mia understood that the bird was saying goodbye. With a bittersweet feeling, she opened the window, allowing the bird to soar into the sky.</p><p class='Art-Detail-Text'>Months passed, and Mia missed her feathery friend. But one sunny morning, as she strolled through the woods, she heard a familiar chirping. There, in a clearing, stood the bird, surrounded by other creatures Mia had helped over time. They had come together to thank her for her kindness.</p><p class='Art-Detail-Text'>Overwhelmed with joy, Mia realized that her acts of compassion had created a community of grateful animals. From that day forward, Mia continued her mission, caring for and protecting the wildlife around her. And the village, inspired by her selflessness, joined her in creating a harmonious world where kindness and love thrived.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "1st MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 8,
              NextWorkID = 10
          },
          new Art()
          {
              ID = 10,
              URL = BASEPATH + "/MyArt/10/Portal-To-The-Past-Sticky-Note-Art",
              SITE_URL = "/MyArt/9/Portal-To-The-Past-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Portal-To-The-Past-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Portal To The Past - Sticky Note - Art",
              Title = "Portal To The Past",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Portal-To-The-Past.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>This art belongs to a beautiful story named “Portal To The Past”. So here is the story.</p><p class='Art-Detail-Text'>In a village, there lived a young girl named Mia. She was a curious and kind-hearted girl with a love for animals. One day, while exploring the nearby woods, she stumbled upon a wounded bird with a broken wing. Mia's heart filled with compassion, and she gently picked up the bird, vowing to help it.</p><p class='Art-Detail-Text'>Mia took the bird home and made a cozy nest for it. She carefully splinted its wing and provided food and water. Day by day, the bird grew stronger under Mia's tender care. As it healed, they formed a special bond.</p><p class='Art-Detail-Text'>One evening, as Mia sat near the window, a soft melody filled the air. The bird, now able to fly, perched on her windowsill and chirped joyfully. Mia understood that the bird was saying goodbye. With a bittersweet feeling, she opened the window, allowing the bird to soar into the sky.</p><p class='Art-Detail-Text'>Months passed, and Mia missed her feathery friend. But one sunny morning, as she strolled through the woods, she heard a familiar chirping. There, in a clearing, stood the bird, surrounded by other creatures Mia had helped over time. They had come together to thank her for her kindness.</p><p class='Art-Detail-Text'>Overwhelmed with joy, Mia realized that her acts of compassion had created a community of grateful animals. From that day forward, Mia continued her mission, caring for and protecting the wildlife around her. And the village, inspired by her selflessness, joined her in creating a harmonious world where kindness and love thrived.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "3rd MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 9,
              NextWorkID = 11
          },
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

