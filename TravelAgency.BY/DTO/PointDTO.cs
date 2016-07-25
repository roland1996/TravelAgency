using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.BL.DTO
{
    public class PointDTO
    {
        public double X { get; set; }
        public double Y { get; set; }
        public PointDTO(string line)
        {
            string[] point = line.Split(',');
            X = double.Parse(point[0].Replace('.',','));//point[0];
            Y = double.Parse(point[1].Replace('.', ','));
        }
    }
}
