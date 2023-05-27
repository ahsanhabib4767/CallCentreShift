using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class DicDistrictInformation
    {
        public string Id { get; set; } = null!;
        public int? Twcode { get; set; }
        public string Name { get; set; } = null!;
        public string DivisionId { get; set; } = null!;
        public string CountryId { get; set; } = null!;
        public string? Trans { get; set; }
        public string? Favorite { get; set; }
        public string? Extcode { get; set; }
    }
}
