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
    
    public partial class Пользователь
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователь()
        {
            this.Заказ = new HashSet<Заказ>();
            this.Корзина = new HashSet<Корзина>();
        }
    
        public int ID { get; set; }
        public string ФИО { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public string Реквизит { get; set; }
        public string Телефон { get; set; }
        public string Почта { get; set; }
        public int Тип { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Корзина> Корзина { get; set; }
        public virtual Тип_пользователь Тип_пользователь { get; set; }
    }
}
