using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("invoice_detail_tbl")]
    public class InvoiceDetail
    {
        [Key]
        public int invoice_detail_id { get; set; }
        public int? invoice_id { get; set; }
        public int? product_id { get; set; }
        public int? qty { get; set; }
        public string? qty_note { get; set; }
        public decimal? price { get; set; }
        public string? note { get; set; }
        public decimal? vat { get; set; }
        public decimal? p_dollar { get; set; }
        public decimal? p_riel { get; set; }
        public decimal? p_bath { get; set; }
        public decimal? discount { get; set; }
        public decimal? owe { get; set; }
        public int? category_id { get; set; }
        public decimal? other { get; set; }
    }
}

