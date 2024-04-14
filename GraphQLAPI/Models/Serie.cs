namespace GrapQLAPI.Models;

public class Serie {
 	public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Platform> Platforms { get; set; }
}