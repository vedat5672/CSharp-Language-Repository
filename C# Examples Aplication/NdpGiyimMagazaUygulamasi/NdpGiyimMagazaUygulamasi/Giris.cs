namespace NdpGiyimMagazaUygulamasi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giris
    {
        [Key]
        [StringLength(50)]
        public string SessionId { get; set; }

        [StringLength(50)]
        public string KullaniciIsmi { get; set; }

        [StringLength(50)]
        public string Sifre { get; set; }

        [StringLength(50)]
        public string GirisTarih { get; set; }
    }
}
