using BusinessCardHolder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardHolder
{
    public class SearchEngineFirm
    {
        /// <summary>
        /// All words will be search separetly
        /// </summary>
        public List<Firm> SearchFirmAnyWord(string[] Terms)
        {
            using (var context = new BusinessCardContext())
            {
                var query = from p in context.Firm
                           where (Terms.Any(x => p.Name.Contains(x)) ||
                           (Terms.Any(x => p.City.Contains(x))) ||
                           (Terms.Any(x => p.Street.Contains(x))))
                           select p;
                return query.ToList();
            }
        }

        /// <summary>
        /// All words will be used to find single result
        /// </summary>
        public List<Firm> SearchFirmAnyWord(string name, string city, string street)
        {
            using (var context = new BusinessCardContext())
            {
                var list = new List<Firm>();
                if (string.IsNullOrWhiteSpace(name))
                    name = "";
                if (string.IsNullOrWhiteSpace(city))
                    city = "";
                if (string.IsNullOrWhiteSpace(street))
                    street = "";
                name = name.Replace(" ", String.Empty);
                city = city.Replace(" ", String.Empty);
                street = street.Replace(" ", String.Empty);

                foreach (var firm in context.Firm)
                {
                    if (firm.Name.Contains(name) && firm.City.Contains(city) && firm.Street.Contains(street))
                    {
                        list.Add(firm);
                    }  
                }
                //list.Union(list);
                return list;
            }
        }


        /// <summary>
        /// All words must be matched
        /// </summary>
        public List<Firm> SearchFirmAllWords(string[] Terms)
        {
            using (var context = new BusinessCardContext())
            {
                var query = from p in context.Firm
                            where (Terms.Any(x => p.Name.Contains(x)) &&
                            (Terms.Any(x => p.City.Contains(x))) &&
                            (Terms.Any(x => p.Street.Contains(x))))
                            select p;
                return query.ToList();
            }
        }

        public List<Firm> SearchFirmByName(string name)
        {
            name = name.Replace(" ", String.Empty);
            using(var context = new BusinessCardContext())
            {
                var list = context.Firm.Where(x => x.Name.Contains(name)).ToList();
                return list;
            }
        }

        

    }
}