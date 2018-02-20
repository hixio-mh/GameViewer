using System.Collections.Generic;

namespace Lab3.Model
{

    public class Games
    {
        public List<GamesModel> games { get; set; }
        public Games()
        {
            games = new List<GamesModel>();
        }
    }

    public class GamesModel
    {
        public string Name { get; set; }

        public ShortDescription shortDescription { get; set; }
        public FullDescription fullDescription { get; set; }
       
    }

    public class ShortDescription
    {
        public string Genre { get; set; }
        public string Company { get; set; }
        public string Year { get; set; }
        public string SmallIco { get; set; }
    }

    public class FullDescription
    {
        public string Platform { get; set; }
        public string BigIco { get; set; }
        public string Link { get; set; }
    }
}
