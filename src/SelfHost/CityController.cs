using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApp1
{
    public class CityController : ApiController
    {
        private List<CityInfo> CityInfos = new List<CityInfo>
        {
            new CityInfo{Id=1,Name="Tehran",Population=9382000, },
            new CityInfo{Id=2,Name="Isfahan",Population=2219000,},
            new CityInfo{Id=3,Name="Rasht",Population=731000, }
        };

        [HttpGet]
        public IEnumerable<CityInfo> GetAllCity()
        {
            return CityInfos;
        }
    }

    public class CityInfo
    {
        public short Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
