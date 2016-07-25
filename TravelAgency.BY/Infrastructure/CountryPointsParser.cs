using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TravelAgency.BL.DTO;
namespace TravelAgency.BL.Infrastructure
{
    public class CountryPointsParser
    {
        public List<CountryDTO> load(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<CountryDTO> countriesResult = new List<CountryDTO>();
            string kek = "";
            while (kek != null)
            {
                kek = sr.ReadLine();
                if (kek != null)
                {
                    countriesResult.Add(parser(kek));
                }
            }
            return countriesResult;
        }
        public CountryDTO parser(string line)
        {
            string pattern = @"\s";
            string[] temp = Regex.Split(line, pattern);
            List<PointDTO> points = new List<PointDTO>();
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] != "")
                {
                    points.Add(new PointDTO(temp[i]));
                }
            }
            CountryDTO country = new CountryDTO(temp[0], points);
            return country;

        }
    }
}
