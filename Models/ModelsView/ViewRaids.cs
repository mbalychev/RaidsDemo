using Microsoft.EntityFrameworkCore;
using Raids2020.Models.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raids2020.Models
{
    public class ViewRaids 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">контекст данных</param>
        /// <returns>все рейды, без фильтрации</returns>
        public static List<Raid> GetRaids(RaidsContext context)
        {
            List <Raid> raids = new List<Raid>(context.Raids.Include(x=>x.Terr).AsNoTracking().Take(10).ToList());
            return raids;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">контекст данных</param>
        /// <param name="id">номер ид рейда</param>
        /// <returns>акты соотв.рейда</returns>
        public static List<Act> GetRaidActs(RaidsContext context, int id)
        {
            Raid raid = context.Raids.Include(x => x.Acts).AsNoTracking().FirstOrDefault(x=>x.Id == id);
            List<Act> acts = raid.Acts.ToList();
            return acts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">контекст данных</param>
        /// <param name="filter">класс параметров фильтра</param>
        /// <returns>списо рейдов, кот соответсвуют параметрам фильтра</returns>
        public static List<Raid> GetFilteringRaids(RaidsContext context, FilterRaids filter)
        {
            List<Raid> raids = context.Raids.Include(x => x.Terr).Where(x => x.Start >= filter.Start && x.Stop <= filter.Stop).AsNoTracking().ToList();
            if (filter.TerrId != 0 )
            {
                raids = raids.Where(x => x.TerrId == filter.TerrId).ToList();
            }
            if (filter.NomerRaid != "" && filter.NomerRaid != null)
            {
                raids = raids.Where(x=>x.Nomer.Contains(filter.NomerRaid)).ToList();
            }
            switch(filter.Sort) 
            {
                case "order":
                        raids = raids.OrderBy(x => x.NumberInt).ToList();
                    break;
                case "stop":
                    raids = raids.OrderBy(x => x.Stop).ToList();
                    break;
                case "terr":
                    raids = raids.OrderBy(x => x.TerrId).ToList();
                    break;
                default:
                        raids = raids.OrderBy(x => x.Start).ToList();
                    break;
            }
            
            return raids;
        }
    }
}
