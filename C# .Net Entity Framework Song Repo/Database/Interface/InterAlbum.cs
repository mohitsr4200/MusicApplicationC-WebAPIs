using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Interface
{
    public interface InterAlbum
    {
        List<Album> GetAlbums();

        Album GetSongName(string sn);
        Album GetSongGener(string sg);
        Album AddSong(Album song);

    }
}
