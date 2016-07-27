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
        public bool breaker { get; set; }
        public PointDTO(string line)
        {
            string[] point = line.Split(',');
            breaker = false;
            if(point[0].Contains("M")||point[0].Contains("L"))
            {
                breaker = true;
                point[0]=point[0].Replace('M', ' ').Trim();
                point[1]=point[1].Replace('L', ' ').Trim();
                point[1] = point[1].Replace('M', ' ').Trim();
                point[0] = point[0].Replace('L', ' ').Trim();
            }
            X = double.Parse(point[0].Replace('.',','));//point[0];
            Y = double.Parse(point[1].Replace('.', ','));
        }
    }
}
