using Database.Interface;
using Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dil_ki_awaz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API : ControllerBase
    {
        private readonly InterAlbum  _InterAlbum;

        public API(InterAlbum interAlbum)
        {
            _InterAlbum = interAlbum;
        }

        [HttpGet]
        public ActionResult GetAlbum()
        {
            try
            {
                var song = _InterAlbum.GetAlbums();
                return Ok(song);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
            
        }

        [HttpGet]
        [Route("get/new/{sn}")]
        public ActionResult GetSongName(string sn)
        {
            try
            {
                var song = _InterAlbum.GetSongName(sn);
                return Ok(song);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }

        }

        [HttpGet]
        [Route("get/old/new/{sg}")]
        public ActionResult GetSongGener(string sg)
        {
            try
            {
                var song = _InterAlbum.GetSongGener(sg);
                return Ok(song);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }

        }

        [HttpPost]
        public ActionResult AddSong(Album SONG)
        {
            try
            {
                var asong = _InterAlbum.AddSong(SONG);
                return Ok();
            }
            catch( Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
         
    }
}
