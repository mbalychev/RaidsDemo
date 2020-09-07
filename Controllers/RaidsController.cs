using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Raids2020.Models;
using Raids2020.Models.Filtering;

namespace Raids2020.Controllers
{
    public class RaidsController : Controller
    {
        RaidsContext context;
        public RaidsController (RaidsContext _context)
        {
            context = _context;
        }
        public IActionResult Index(FilterRaids filter)
        {
            ViewBag.Terrs = new SelectList(context.Terrs.AsNoTracking(),"Id","Name");
            ViewBag.Filter = filter == null ? new FilterRaids() : filter;

            return View(ViewRaids.GetFilteringRaids(context, filter));
        }

        public IActionResult GetRaid(int id)
        {
            ViewBag.Terrs = new SelectList(context.Terrs, "Id", "Name");
            ViewBag.Isp = new SelectList(context.Isps, "Id", "Name");
            Raid raid = context.Raids.Where(x => x.Id == id).Include(x=>x.Acts).Include(x=>x.Orders).Include(x=>x.Protocols).ThenInclude(x=>x.FileProtocols).Include(x=>x.Tasks).Include(x=>x.Risp).ThenInclude(x=>x.Isp).FirstOrDefault();
            return View("Raid", raid);
        }

        public IActionResult EditRaid(Raid raidChange)
        {
            if (ModelState.IsValid)
            {
                context.Raids.Update(raidChange);
                context.SaveChanges();
                return RedirectToAction("GetRaid", new { id = raidChange.Id });
            }
            else
            {
                return RedirectToAction("GetRaid", new { id = raidChange.Id });
            }
        }

        public string AddIsp (int raidId, int ispId)
        {
            //Risp risp = context.Risps.Add(new Risp { IspId = ispId, RaidId = raidId})
            return "Исп добавлен";
        }

        [HttpGet]
        public IActionResult CheckNomer (string nomer)
        {
            Raid raid = context.Raids.Where(x => x.Nomer == nomer).FirstOrDefault();
            if (raid == null)
                return Json(true);
            else
                return Json(false);
            //return context.Raids.Where(x => x.Nomer == nomer).First() == null ? Json(true) : Json(false);
        }

    }
}
