using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.BL.DTO
{
    public class CountryDTO
    {
        public string Name { get; set; }
        public List<PointDTO> Points { get; set; }
        public CountryDTO(string name,List<PointDTO>points)
        {
            Name = name;
            Points = points;
        }
    }
}
    