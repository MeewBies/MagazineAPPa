//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagazineAPP.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Товар_корзина
    {
        public int ID { get; set; }
        public int ID_Товар { get; set; }
        public int ID_Корзина { get; set; }
        public int Цена { get; set; }
        public int Колличество { get; set; }
    
        public virtual Корзина Корзина { get; set; }
        public virtual Товар Товар { get; set; }
    }
}
