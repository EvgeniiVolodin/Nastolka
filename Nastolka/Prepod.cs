//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nastolka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prepod
    {
        public int Id { get; set; }
        public string Ima { get; set; }
        public string Familia { get; set; }
        public string IdKyrs { get; set; }
        public string Telefon { get; set; }
    
        public virtual FormKyrsov FormKyrsov { get; set; }
        public virtual Kyrsi Kyrsi { get; set; }
    }
}
