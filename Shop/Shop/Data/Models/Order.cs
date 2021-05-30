using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id{ get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина имени не менее 5 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина имени не менее 10 символов")]
        public string SurName { get; set; }

        [Display(Name = "Введите адресс ")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 20 символов")]
        public string Address { get; set; }

        [Display(Name = "Введите телефон")]
        [DataType(DataType.Password)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина имени не менее 15 символов")]
        public string Phone { get; set; }

        [Display(Name = "Введите e-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не менее 20 символов")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}