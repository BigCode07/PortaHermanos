//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FullProgram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Legajo
    {
        public int Id { get; set; }
        public int Legajo1 { get; set; }
        public string Apeynom { get; set; }
        public int Dni { get; set; }
        public int IdEstado { get; set; }
        public string Imagen { get; set; }
        public string Usuario { get; set; }
        public System.DateTime FCarga { get; set; }
        public int Caja { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
