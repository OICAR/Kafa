using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Models
{
    public class SQLGoogleMapsRepository : IGoogleMapsRepository
    {
        private readonly Google_mapsContext _context;

        public SQLGoogleMapsRepository(Google_mapsContext
         context)
        {
            _context = context;
        }
        public IEnumerable<GoogleMap> GetAllLocations()
        {
            return _context.GoogleMap;
        }

        public GoogleMap Add(GoogleMap googleMap)
        {
            _context.GoogleMap.Add(googleMap);
            _context.SaveChanges();
            return googleMap;
        }
    }
}