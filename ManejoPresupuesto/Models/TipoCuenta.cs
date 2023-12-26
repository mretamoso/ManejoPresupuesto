﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength:50, MinimumLength =3, ErrorMessage ="La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name ="Nombre del tipo cuenta")]
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

        /*Probando validaciones por default*/
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [EmailAddress(ErrorMessage ="El campo {0} debe ser un correo valido")]
        public string Email { get; set; }
        [Range(minimum:18, maximum: 80, ErrorMessage ="El valor de {0} debe estar entre {1} y {2}")]
        public int Edad { get; set; }
        [Url(ErrorMessage ="El campo {0} de ser una URL valida")]
        public string URL { get; set; }
        [CreditCard(ErrorMessage ="La tarjeta de credito no es valida")]
        [Display(Name = "Tarjeta de Credito")]
        public string TarjetaDeCredito { get; set; }
    }
}
