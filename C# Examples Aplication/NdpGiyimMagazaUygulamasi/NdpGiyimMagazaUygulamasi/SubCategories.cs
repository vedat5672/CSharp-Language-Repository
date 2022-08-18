namespace NdpGiyimMagazaUygulamasi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SubCategories
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Isim { get; set; }
    }
}
