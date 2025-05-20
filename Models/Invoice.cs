using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model
{
    [Table("INVOICE_TBL")]
    public class Invoice
    {
        [Key]
        public int invoice_id { get; set; }
        public int? invoice_no { get; set; }
        public string? year_number { get; set; }
        public DateTime? invoice_date { get; set; }
        public string? student_id { get; set; }
        public string? degree_id { get; set; }
        public string? school_id { get; set; }
        public string? field_id { get; set; }
        public string? promotion_id { get; set; }
        public string? stage_id { get; set; }
        public string? group_id { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
        public string? term_no { get; set; }
        public int? exchangerate_id { get; set; }
        public decimal? vat { get; set; }
        public decimal? grand_total { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
        public decimal? totaldollar { get; set; }
        public decimal? totalriel { get; set; }
        public decimal? totalbath { get; set; }
        public decimal? totaldiscount { get; set; }
        public bool? payment { get; set; }
        public bool? check_payment { get; set; }
        public DateTime? date_edit { get; set; }
        public string? edit_by { get; set; }
        public decimal? owe { get; set; }
        public string? owe_reason { get; set; }
        public int? user_id { get; set; }
        public decimal? total_return_amount { get; set; }
        public decimal? return_amount { get; set; }
        public string? return_description { get; set; }
        public decimal? totalother { get; set; }
        public int? payment_method_id { get; set; }
        public decimal? amount_dollar { get; set; }
        public decimal? amount_reil { get; set; }
        public bool? pay_on_app { get; set; }
        //public int INVOICE_ID { get; set; }
        //public int? INVOICE_NO { get; set; }
        //public string? YEAR_NUMBER { get; set; }
        //public DateTime? INVOICE_DATE { get; set; }
        //public string? STUDENT_ID { get; set; }
        //public string? DEGREE_ID { get; set; }
        //public string? SCHOOL_ID { get; set; }
        //public string? FIELD_ID { get; set; }
        //public string? PROMOTION_ID { get; set; }
        //public string? STAGE_ID { get; set; }
        //public string? GROUP_ID { get; set; }
        //public DateTime? STARTDATE { get; set; }
        //public DateTime? ENDDATE { get; set; }
        //public string? TERM_NO { get; set; }
        //public int? EXCHANGERATE_ID { get; set; }
        //public decimal? VAT { get; set; }
        //public decimal? GRAND_TOTAL { get; set; }
        //public string? DESCRIPTION { get; set; }
        //public string? STATUS { get; set; }
        //public decimal? TOTALDOLLAR { get; set; }
        //public decimal? TOTALRIEL { get; set; }
        //public decimal? TOTALBATH { get; set; }
        //public decimal? TOTALDISCOUNT { get; set; }
        //public bool? PAYMENT { get; set; }
        //public bool? CHECK_PAYMENT { get; set; }
        //public DateTime? DATE_EDIT { get; set; }
        //public string? EDIT_BY { get; set; }
        //public decimal? OWE { get; set; }
        //public string? OWE_REASON { get; set; }
        //public int? USER_ID { get; set; }
        //public decimal? TOTAL_RETURN_AMOUNT { get; set; }
        //public decimal? RETURN_AMOUNT { get; set; }
        //public string? RETURN_DESCRIPTION { get; set; }
        //public decimal? TOTALOTHER { get; set; }
        //public int? PAYMENT_METHOD_ID { get; set; }
        //public decimal? AMOUNT_DOLLAR { get; set; }
        //public decimal? AMOUNT_REIL { get; set; }
        //public bool? PAY_ON_APP { get; set; }
    }

}

