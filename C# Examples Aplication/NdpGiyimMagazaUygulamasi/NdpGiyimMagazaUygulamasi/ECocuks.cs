namespace NdpGiyimMagazaUygulamasi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECocuks
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int SubId { get; set; }

        [StringLength(50)]
        public string Isim { get; set; }

        public virtual Categories Categories { get; set; }
    }
}
