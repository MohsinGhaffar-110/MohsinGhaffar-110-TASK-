using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MohsinGhaffar_110_TASK_.Models
{
    public class OrderModel
    {
        public string storename { get; set; }

        public string DsQty { get; set; }

        [Key]
        public string itemprice { get; set; }
    }
}