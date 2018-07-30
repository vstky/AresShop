using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carts.Models.OrderModel
{
    public class Ship
    {
        /// <summary>
        /// 收貨人姓名
        /// </summary>
        [Required]
        [Display(Name = "Recipient name")]
        [StringLength(30, ErrorMessage = "{0} should be at least {2} character"
            , MinimumLength = 2)] //字元長度8~256
        public string RecieverName { get; set; }

        /// <summary>
        /// 收貨人電話
        /// </summary>
        [Required]
        [Display(Name = "Recipient phone")]
        [StringLength(15, ErrorMessage = "{0} should be at least {2} character"
            , MinimumLength = 8)] //字元長度8~15
        public string RecieverPhone { get; set; }

        /// <summary>
        /// 收貨人住址
        /// </summary>
        [Required]
        [Display(Name = "Recipient address")]
        [StringLength(256, ErrorMessage = "{0} should be at least {2} character"
            , MinimumLength = 8)] //字元長度8~256
        public string RecieverAddress { get; set; }
    }
}