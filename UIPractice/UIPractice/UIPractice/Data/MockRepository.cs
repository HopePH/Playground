using System;
using System.Collections.Generic;
using System.Text;

namespace UIPractice.Data
{
    public static class MockRepository
    {
        public static IList<Movie> Movies { get; set; } = new List<Movie>();

        static MockRepository()
        {
            var newmovie = new Movie()
            {
                Title = "Avengers: Endgame",
                ReleaseDate = "April 22, 2019 ",
                AudienceScore = 99,
                TomatoScore = 99,
                Info = "Avengers: Endgame was widely anticipated, and Disney backed the film with extensive marketing campaigns. It premiered in Los Angeles on April 22, 2019, and was theatrically released in the United States on April 26, 2019, in IMAX and 3D. The film received praise for its direction, acting, musical score, visual effects, and emotional weight, with critics lauding its culmination of the 22-film story. It has grossed over $2.79 billion worldwide, surpassing Infinity War's entire theatrical run in just eleven days and breaking numerous box office records, including becoming the highest-grossing film of all time, overtaking Avatar.",
                PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/0d/Avengers_Endgame_poster.jpg",
                BackDropUrl = "https://cdn3.movieweb.com/i/article/FxwKBgi7qHFlC9PXha44MEnWqBowgi/798:50/Avengers-Endgame-Poster-Whatever-It-Takes.jpg",
                Cast = new List<CastMember>()
                {
                    new CastMember() {Name = "Robert Downey Jr.", Role = "Iron Man", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Robert_Downey_Jr_2014_Comic_Con_%28cropped%29.jpg/330px-Robert_Downey_Jr_2014_Comic_Con_%28cropped%29.jpg"},
                    new CastMember() {Name = "Chris Evans", Role = "Captain America", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Chris_Evans_SDCC_2014.jpg/330px-Chris_Evans_SDCC_2014.jpg"},
                    //new CastMember() {Name = "", Role = "", ImageUrl = ""},
                    new CastMember() {Name = "Mark Ruffalo", Role = "Hulk", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Mark_Ruffalo_in_2017_by_Gage_Skidmore.jpg/330px-Mark_Ruffalo_in_2017_by_Gage_Skidmore.jpg"}
                }
            };

            Movies.Add(newmovie);
        }
    }

    public class Movie
    {
        public string Title { get; set; }

        public string ReleaseDate { get; set; }

        public int AudienceScore { get; set; }

        public int TomatoScore { get; set; }

        public string Info { get; set; }

        public List<CastMember> Cast {get; set;}

        public string PosterUrl { get; set;}

        public string BackDropUrl { get; set; }

    }

    public class CastMember
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public string ImageUrl { get; set; }
    }
}