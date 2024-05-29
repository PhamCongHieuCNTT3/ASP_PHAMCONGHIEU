using PCH_lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PCH_lesson06.Controllers
{
    public class PCHSongController : Controller
    {
        private static List<PCHSong> PCHSongs = new List<PCHSong>()
        {
            new PCHSong{Id=221090037,PCHTitle="Lê Hoàng Long",PCHAuthor="K22CNT3",PCHArtist="NTU",PCHYearRelease="2004"},
            new PCHSong{Id=1,PCHTitle="Lê Hoàng Long",PCHAuthor="K22CNT3",PCHArtist="NTU",PCHYearRelease="2004"},
        };
        // GET: PCHSong
        public ActionResult Index()
        {
            return View(PCHSongs);
        }
        public ActionResult PCHCreate()
        {
            var PCHSong = new PCHSong();
            return View(PCHSong);
        }
    }
}