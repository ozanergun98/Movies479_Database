#nullable disable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities
{
    [PrimaryKey(nameof(MovieId), nameof(GenreId))]
    public class MovieGenre
    {
        [Column(Order = 0)]
        public int MovieId {get; set;}//primary key

        public Movie Movie {get; set;}

        [Column(Order = 1)]
        public int GenreId {get; set;}//primary key

        public Genre Genre { get; set; }
    }
}
