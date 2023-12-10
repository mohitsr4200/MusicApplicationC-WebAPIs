using Database.Interface;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.DBcontent;

namespace Database.Repo
{
    public class SongRepo : InterAlbum
    {
        private readonly SongSql _Song;

        public SongRepo ( SongSql _song)
        {
            _Song = _song;
        }
        public List<Album> GetAlbums()
        {
            List<Album> album;
            album = _Song.Album.ToList();
            return album ;
        }

        public Album GetSongGener(string sg)
        {
            var song = _Song.Album.FirstOrDefault(x => x.SongGener == sg);
            return song;
        }


        public Album GetSongName(string sn)
        {
            var song = _Song.Album.FirstOrDefault(x => x.SongName == sn);
            return song;
        }

        Album InterAlbum.AddSong(Album song)
        {
            _Song.Album.Add(song);
            _Song.SaveChanges();
            return song;
        }
    }
}
