using System.Collections;

namespace MODUL9_1302213045
{
    public class Movie
    {
        public String Title { get; set; }
        public String Director { get; set; }
        public String Description { get; set; }
        public List<String> Stars { get; set; }
        public Movie() {
            Stars = new List<String>();
        }
    }
}
