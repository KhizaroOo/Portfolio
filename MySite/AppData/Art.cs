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
              Title = "Young Girl<br />vs<br />Dark Wind",
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
              SITE_URL = "/MyArt/10/Portal-To-The-Past-Sticky-Note-Art",
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
          new Art()
          {
              ID = 11,
              URL = BASEPATH + "/MyArt/11/Little-Angel-Sticky-Note-Art",
              SITE_URL = "/MyArt/11/Little-Angel-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Little-Angel-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Little Angel - Sticky Note - Art",
              Title = "Little Angel",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Little-Angel.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my artistic world, where imagination takes flight on the tiniest of canvases. As a drawing artist, I find joy in creating intricate and meaningful art. In this blog post, I want to share with you a heartfelt drawing I made.A tribute to my beloved NIECE with majestic wings and curly hair.</p><p class='Art-Detail-Text'>The paper's limitations only fueled my creativity, challenging me to express intricate details and emotions within a confined space. This artwork holds a special place in my heart as it is dedicated to my beloved niece.</p><p class='Art-Detail-Text'>A visual testament to the power of art and the love that inspires it. May it remind you of the precious bonds you hold with your own loved ones and the infinite possibilities that unfold when creativity knows no boundaries.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "5th MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 10,
              NextWorkID = 12
          },
          new Art()
          {
              ID = 12,
              URL = BASEPATH + "/MyArt/12/Aurora-Sticky-Note-Art",
              SITE_URL = "/MyArt/12/Aurora-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Aurora-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Aurora - Sticky Note - Art",
              Title = "Aurora",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Aurora.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my artistic world, where imagination takes flight on the tiniest of canvases. As a drawing artist, I find joy in creating intricate and meaningful art. In this blog post, I want to share with you a heartfelt drawing I made. A tribute to my beloved Aurora.</p><p class='Art-Detail-Text'>Meet Aurora, a captivating vision of grace and elegance. With a name derived from the ethereal lights that dance across the night sky, Aurora embodies a radiant charm that effortlessly captures hearts.</p><p class='Art-Detail-Text'>Blessed with an enchanting smile and eyes that hold a universe of warmth, Aurora possesses a timeless beauty that transcends fleeting trends. Her presence illuminates every room, drawing others in with an irresistible magnetism.</p><p class='Art-Detail-Text'>But Aurora's allure extends beyond her physical appearance. Her spirit is as luminous as the dawn itself. With a heart full of kindness and compassion, she spreads positivity and uplifts those around her. Her gentle words and empathetic nature create a safe haven for others to find solace and support.</p><p class='Art-Detail-Text'>Aurora's love for the arts is a testament to her creativity and imagination. Whether it's painting, writing, or dancing, she effortlessly expresses herself, infusing every stroke, word, and step with a touch of magic.</p><p class='Art-Detail-Text'>As a true adventurer at heart, Aurora embraces the wonders of the natural world. She finds solace in the whispering winds, delights in the vibrant colors of blooming flowers, and seeks inspiration within the embrace of nature's embrace.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "7th MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 11,
              NextWorkID = 13
          },
          new Art()
          {
              ID = 13,
              URL = BASEPATH + "/MyArt/13/A-Treehouse-Dream-Sticky-Note-Art",
              SITE_URL = "/MyArt/13/A-Treehouse-Dream-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "A-Treehouse-Dream-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "A Treehouse Dream - Sticky Note - Art",
              Title = "A Treehouse Dream",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/A-Treehouse-Dream.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my artistic world, where imagination takes flight on the tiniest of canvases. As a drawing artist, I find joy in creating intricate and meaningful art. In this blog post, I want to share with you a heartfelt drawing I made. A sketch of a Treehouse which I can dream of.</p><p class='Art-Detail-Text'>At first glance, the drawing captures the essence of childhood fantasies.Every stroke and line tells a story, as the treehouse stands as a sanctuary of adventure and secret hideaways. The leaves of the tree sway gently, as if whispering tales of childhood dreams and endless possibilities.</p><p class='Art-Detail-Text'>The beauty of sticky note art lies in its simplicity and accessibility. Through this unique medium, the artist has transformed an ordinary office supply into a captivating piece of visual storytelling. The limitations of the sticky note's size have only fueled the artist's creativity, resulting in a charming and evocative creation.</p><p class='Art-Detail-Text'>Beyond its visual appeal, the treehouse holds symbolic meaning. It represents the resilience and boundless imagination of childhood. It reminds us to embrace our inner child and cherish the wonder of simpler times.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "13th MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 12,
              NextWorkID = 14
          },
          new Art()
          {
              ID = 14,
              URL = BASEPATH + "/MyArt/14/Find-Positive-In-Everything-Sticky-Note-Art",
              SITE_URL = "/MyArt/14/Find-Positive-In-Everything-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Find-Positive-In-Everything-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Find Positive In Everything - Sticky Note - Art",
              Title = "Find Positive In Everything",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Find-Positive-In-Everything.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my artistic world, where sticky notes transform into captivating pieces of art that carry profound messages. As a drawing artist, I find inspiration in the simplest of things, using sticky notes as my canvas to spread positivity and embrace the beauty found in everyday life. In this post, I want to share a particular artwork titled \"Find-Positive-In-Everything\" where three winners emerge, and an unexpected twist unfolds, revealing the incredible power of a positive mindset. \"Find-Positive-In-Everything\" is a vibrant and expressive piece created on a sticky note.</p><p class='Art-Detail-Text'>The third-place winner becomes the focal point of the artwork's unique twist. Unlike conventional scenarios, this contestant doesn't feel disappointed or overshadowed by securing the third position. On the contrary, an overwhelming sense of positivity radiates from their smile, surpassing the first and second-place winners.</p><p class='Art-Detail-Text'>This artwork serves as a powerful reminder of the impact positivity can have on our lives. While others might perceive the third position as a setback, the exuberant character redefines the notion of winning. Their contagious positivity elevates the entire competition, shifting the focus from mere rankings to celebrating personal growth, resilience, and a genuine appreciation for the journey itself.</p><p class='Art-Detail-Text'>Through the eyes of the third-place winner, we witness the transformative power of a positive mindset. Their ability to find joy and gratitude in every situation is a testament to the idea that true fulfillment and happiness lie within our perspectives, rather than external achievements.</p><p class='Art-Detail-Text'>\"Find-Positive-In-Everything\" inspires viewers to reflect on their own lives and embrace the philosophy of finding positivity in every aspect, regardless of the outcome. It encourages us to shift our focus from comparisons and self-criticism to a mindset that fosters personal growth, resilience, and a genuine appreciation for life's journey.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "18th MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 13,
              NextWorkID = 15
          },
          new Art()
          {
              ID = 15,
              URL = BASEPATH + "/MyArt/15/Love-Day-Sticky-Note-Art",
              SITE_URL = "/MyArt/15/Love-Day-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Love-Day-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Love Day - Sticky Note - Art",
              Title = "Love Day",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Love-Day.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Love Day, also known as Valentine's Day, is a special occasion that celebrates love and affection. As a drawing artist, I find joy in capturing the essence of this day through my unique art. In this post, I want to share with you the beauty and charm of my drawings on sticky notes, specifically created to celebrate the 14th of February, Love Day.</p><p class='Art-Detail-Text'>Sticky note art is a captivating form of expression that combines simplicity and creativity. The small canvas of a sticky note allows me to convey heartfelt messages and emotions with just a few strokes of a pen or marker.</p><p class='Art-Detail-Text'>Love Day is a time to celebrate the beauty of love, and my sticky note art offers a delightful and heartfelt way to express those sentiments. Whether it's through adorable illustrations or personalized drawings, my aim is to bring joy and warmth to people's hearts on this special day. Let my art be a small token of love that can brighten someone's day and serve as a reminder of the love that surrounds us all.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "21st MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 14,
              NextWorkID = 16
          },
          new Art()
          {
              ID = 16,
              URL = BASEPATH + "/MyArt/16/Cat-In-The-Coffee-Mug-Sticky-Note-Art",
              SITE_URL = "/MyArt/16/Cat-In-The-Coffee-Mug-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Cat-In-The-Coffee-Mug-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Cat In The Coffee Mug - Sticky Note - Art",
              Title = "Cat In The Coffee Mug",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Cat-In-The-Coffee-Mug.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to the enchanting realm of sticky note artistry, where creativity knows no bounds. As a passionate drawing artist, I invite you to embark on a journey through my captivating collection of drawings created on sticky notes. In this post, I delve into a series of four mesmerizing images that showcase the magical transformation of a coffee mug into a gateway to a whimsical world. Prepare to be amazed as we unveil the hidden wonders within these small adhesive canvases.</p><p class='Art-Detail-Text'>Cats and coffee are two of the most beloved things in the world, and what could be better than combining them in a single mug? A cat in a coffee mug is a fun and creative way to show your love for both your furry friend and your favorite hot beverage.</p><p class='Art-Detail-Text'>Rendered with precise lines and delicate shading, the mug stands prominently on the sticky note.</p><p class='Art-Detail-Text'>As your eyes shift to the second image, you discover a delightful surprise. Nestled within the confines of the mug, small ears emerge, hinting at something beyond the ordinary. These tiny ears pique your curiosity and invite you to explore the unexpected secrets hidden within the Coffee Mug.</p><p class='Art-Detail-Text'>The third image unveils a captivating twist in the story. The small ears now reveal their true nature—they belong to a black cat. With meticulous strokes and a touch of mystique, the cat's ears materialize.</p><p class='Art-Detail-Text'>\nFinally, as you gaze at the fourth and final image, the narrative reaches its climax. The coffee cup tumbles and a beautiful black color small cat comes out from the Coffee Mug. </p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "23rd MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 15,
              NextWorkID = 17
          },
          new Art()
          {
              ID = 17,
              URL = BASEPATH + "/MyArt/17/Embracing-Joy-Sticky-Note-Art",
              SITE_URL = "/MyArt/17/Embracing-Joy-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "Embracing-Joy-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "Embracing Joy - Sticky Note - Art",
              Title = "Embracing Joy",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/Embracing-Joy.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my artistic world, where sticky notes become a canvas for spreading happiness and positivity! As a drawing artist, I find inspiration in the simplest of things. Through my drawings, I capture the essence of joy, using colorful emojis to express different happy moods.</p><p class='Art-Detail-Text'>Imagine a world where happiness is as easy as peeling a sticky note and sticking it to your heart. With my sticky note drawings, I aim to bring a smile to your face and uplift your spirits.</p><p class='Art-Detail-Text'>Emojis have become a universal language of emotions, transcending barriers and conveying feelings with simplicity and clarity. By using emojis in my sticky note drawings, I aim to connect with people on a deeper level, speaking directly to their hearts. Whether it's a simple thumbs-up, a gleeful face, or a dancing figure and many more, these emojis encapsulate the essence of happiness and positivity.</p><p class='Art-Detail-Text'>Through my art, I invite you to embrace joy as a powerful catalyst for happiness and positivity in your life. Each sticky note drawing is a gentle reminder to seek moments of joy, even in the smallest of things.</p><p class='Art-Detail-Text'>In a world that often feels chaotic and overwhelming, embracing joy becomes a conscious choice.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "25th MARCH 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 15,
              NextWorkID = 17
          },
          new Art()
          {
              ID = 18,
              URL = BASEPATH + "/MyArt/18/I-Believe-I-Can-Fly-Sticky-Note-Art",
              SITE_URL = "/MyArt/18/I-Believe-I-Can-Fly-Sticky-Note-Art",
              Tags = "[\"Art\",\"Sticky-Note\",]",
              Slug = "I-Believe-I-Can-Fly-Sticky-Note-Art",
              DataGroup = "[\"all\",\"stickynotes\"]",
              Heading = "I Believe I Can Fly - Sticky Note - Art",
              Title = "I Believe I Can Fly",
              SubTitle = "Sticky Note - Art",
              IMG = "/images/MyArts/I-Believe-I-Can-Fly.avif",
              VIDEO = "",
              Desription = "<p class='Art-Detail-Text'>Welcome to my artistic world, where I transform the ordinary into something extraordinary. As a drawing artist, I find inspiration in everyday objects and moments, and I bring them to life on sticky notes and canvas. In this post, I invite you to explore one of my unique creations. A drawing on a sticky note titled \"I Believe I Can Fly\".</p><p class='Art-Detail-Text'>In \"I Believe I Can Fly,\" I wanted to capture a sense of whimsy and imagination. The drawing depicts a weed cigarette with wings, symbolizing the idea that even the simplest things can inspire us to reach new heights. The wings represent the power of belief and the boundless potential within each of us.</p><p class='Art-Detail-Text'>I started with a humble sticky note, which provided a small canvas for my imagination to take flight. Using a combination of vibrant markers, I carefully sketched the weed cigarette with attention to detail, bringing it to life with intricate patterns and textures. The addition of the wings was a whimsical touch, adding a sense of magic and freedom to the artwork.</p><p class='Art-Detail-Text'>I want to deliver this message through my art in this post. \"I Believe I Can Fly\" conveys a message of empowerment and self-belief. It reminds us that no matter our circumstances, we have the ability to soar beyond limitations and embrace our dreams. The simple act of believing in ourselves can give us the courage to overcome obstacles and achieve greatness.</p><p class='Art-Detail-Text'>Visit [<a class='L-C' href='/MyWorkFlow-MyArtfulness'>MORE</a>] to step into a world where creativity dances with imagination. Where colors come alive. Art whispers its secrets.\n</p>",
              Type = "Art",
              Category = "Sticky Note",
              CreatedOn = "2nd APRIL 2023",

              Facebook = "",
              Instagram = "",
              LinkedIn = "",
              YouTube = "",
              OpenSea = "",
              Twitter = "",
              TikTok = "",
              Pinterest = "",
              Snapchat = "",

              PreviousWorkID = 17,
              NextWorkID = 19
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

