using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SneakerShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(7)]
        [Required(ErrorMessage = "Длина имени не менее 7 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина имени не менее 10 символов")]
        public string Surname { get; set; }

        [Display(Name = "Введите Адресс")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина имени не менее 25 символов")]
        public string Adress { get; set; }

        [Display(Name = "Введите Телефон")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина имени не менее 14 символов")]
        public string Phone { get; set; }
        public int SneakerSizeOrder { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails{ get; set; }
    }
}