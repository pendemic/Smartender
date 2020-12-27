using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Smartender.DATA.EF//.Metadata
{
    public class AlcoholMetadata
    {
        public string Type { get; set; }
        public int ID { get; set; }
    }
    [MetadataType(typeof(AlcoholMetadata))]
    public partial class Alcohol { }
    
    public class CocktailMetadata
    {
        public string Name { get; set; }
        public int DrinkID { get; set; }
        public int AlcReqID { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
    }
    [MetadataType(typeof(CocktailMetadata))]
    public partial class Cocktail { }
}
