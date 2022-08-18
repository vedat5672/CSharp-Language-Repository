namespace NdpGiyimMagazaUygulamasi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Uruns
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int SubId { get; set; }

        [StringLength(50)]
        public string Marka { get; set; }

        public decimal? Fiyat { get; set; }

        public bool? UrunVarmı { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }

        [StringLength(50)]
        public string Beden { get; set; }

        [StringLength(50)]
        public string ImagePath { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
