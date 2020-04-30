using System.Collections.Generic;

namespace WebApplication2.Models
{
    public interface IGoogleMapsRepository
    {
         IEnumerable<GoogleMap> GetAllLocations();
         GoogleMap Add(GoogleMap employee);
    }
}