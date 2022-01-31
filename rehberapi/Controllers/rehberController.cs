using Microsoft.AspNetCore.Mvc;
using rehberapi.Context;
using rehberapi.models;
using System.Linq;

namespace rehberapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class rehberController : Controller
    {
        private readonly DataContext _context;
        public rehberController(DataContext dataContext)
        {
            _context = dataContext;
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult GetAll()
        {
            var allgetrehber = _context.Rehbers.ToList();
            return Ok(allgetrehber);
        }
        [HttpGet]
        [Route("getRehberDetails")]
        public IActionResult getRehberDetails(int id)
        {
            var getrehber = _context.Rehbers.Select(x => new { x.UUId, x.ad, x.soyad, x.iletisim,x.konum}).Where(x => x.UUId == id).FirstOrDefault();
            if (getrehber == null)
            {
                return NotFound();
            }
            return Ok(getrehber);
        }
        [HttpPost]
        [Route("addRehber")]
        public IActionResult CreateRehber(rehber rehbers)
        {
            var rehber = new rehber();
            rehber.ad=rehbers.ad;
            rehber.soyad = rehbers.soyad;
            _context.Add(rehber);
            _context.SaveChanges();
            return Ok(rehbers.UUId);
        }
        [HttpPut]
        [Route("addRehberiletisim")]
        public IActionResult addRehberiletism(rehber rehbers,int id)
        {
            var rehberDelete = _context.Rehbers.Where(x => x.UUId == id).FirstOrDefault();
            if (rehberDelete==null)
            {
                return NotFound();
            }
            rehberDelete.iletisim = rehbers.iletisim;
            _context.Update(rehberDelete);
            _context.SaveChanges();
            return Ok(rehbers.UUId);
        }
        [HttpDelete]
        [Route("deleteRehberiletisim")]
        public IActionResult deleteRehberiletism(rehber rehbers, int id)
        {
            var rehberDelete = _context.Rehbers.Where(x => x.UUId == id).FirstOrDefault();
            if (rehberDelete == null)
            {
                return NotFound();
            }
            rehberDelete.iletisim = null;
            _context.Update(rehberDelete);
            _context.SaveChanges();
            return Ok(rehbers.UUId);
        }
        [HttpPut]
        [Route("delRehber")]
        public IActionResult delRehber(int id,rehber rehbers)
        {
            var rehberDelete = _context.Rehbers.Where(x => x.UUId == id).FirstOrDefault();
            if (rehberDelete==null)
            {
                return NotFound();
            }
            rehberDelete.ad = null;
            rehberDelete.soyad=null;
            _context.Rehbers.Update(rehberDelete);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        [Route("updateRehber")]
        public IActionResult UpdateGadget(rehber rehbers,int id)
        {
            var rehberDelete = _context.Rehbers.Where(x => x.UUId == id).FirstOrDefault();
            if (rehberDelete == null)
            {
                return NotFound();
            }
            rehberDelete.ad = rehbers.ad;
            rehberDelete.soyad = rehbers.ad;
            rehberDelete.iletisim = rehbers.ad;
            _context.Rehbers.Update(rehberDelete);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Deleterehber(int id)
        {
            var rehberDelete = _context.Rehbers.Where(x => x.UUId == id).FirstOrDefault();
            if (rehberDelete == null)
            {
                return NotFound();
            }

            _context.Rehbers.Remove(rehberDelete);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
