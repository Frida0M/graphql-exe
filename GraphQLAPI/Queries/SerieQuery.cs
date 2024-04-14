using GrapQLAPI.Models;

namespace GrapQLAPI.Queries;

public class SerieQuery {
	public Serie GetSerie() {
		return new Serie {
			Name = "One piece",
            ReleaseDate = DateTime.UtcNow.AddDays(-10),
            Platforms = new List<Platform>{
                new()
                {
                    Name = "CrunchyRoll",
                    Followers = 1000
                },
                new()
                {
                    Name = "Netflix",
                    Followers = 2000
                }
            }
		};
	}
    public List<Serie> GetSeries() {
        return new List<Serie> {
            new Serie {
                Name = "Anne with an E",
                ReleaseDate = DateTime.UtcNow.AddDays(-80),
                Platforms = new List<Platform>{
                    new()
                    {
                        Name = "Cuevana",
                        Followers = 7000
                    },
                    new()
                    {
                        Name = "Netflix",
                        Followers = 12000
                    }
                }
            },
            new Serie {
                Name = "Spy x Family",
                ReleaseDate = DateTime.UtcNow.AddDays(-300),
                Platforms = new List<Platform>{
                    new()
                    {
                        Name = "CrunchyRoll",
                        Followers = 3000
                    },
                    new()
                    {
                        Name = "Netflix",
                        Followers = 5000
                    }
                }
            }
        };
    }
    public Serie GetSeriesById(int id) {
        var series = new List<Serie> {
            new Serie {
                Name = "Anne with an E",
                ReleaseDate = DateTime.UtcNow.AddDays(-80),
                Platforms = new List<Platform>{
                    new()
                    {
                        Name = "Cuevana",
                        Followers = 7000
                    },
                    new()
                    {
                        Name = "Netflix",
                        Followers = 12000
                    }
                }
            },
            new Serie {
                Name = "Spy x Family",
                ReleaseDate = DateTime.UtcNow.AddDays(-300),
                Platforms = new List<Platform>{
                    new()
                    {
                        Name = "CrunchyRoll",
                        Followers = 3000
                    },
                    new()
                    {
                        Name = "Netflix",
                        Followers = 5000
                    }
                }
            }
        };
        return series[id];
    }
}



// GetSeries => Retornar listado de series estaticas o si quieren usar un list y hacer un foreach adentro del metodo
// GetSeriesById(int paramName) => el objeto con el id que estoy solicitando
		//Crear una coleccion en memoria con un identificador numerico (List, Array, Dictionary)