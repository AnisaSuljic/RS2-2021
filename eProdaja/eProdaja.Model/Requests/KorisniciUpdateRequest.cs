using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class KorisniciUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string Ime { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string Prezime { get; set; }

        public string Telefon { get; set; }


        public bool? Status { get; set; }

    }
}
