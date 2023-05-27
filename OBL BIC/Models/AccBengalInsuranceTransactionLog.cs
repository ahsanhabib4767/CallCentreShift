using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccBengalInsuranceTransactionLog
    {
        public int Id { get; set; }
        public string TranNo { get; set; } = null!;
        public DateTime TranDate { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public string BankCode { get; set; } = null!;
        public int? BranchId { get; set; }
        public string BranchCode { get; set; } = null!;
        public int? PaymentType { get; set; }
        public string? ChequeNo { get; set; }
        public decimal? ChequeAmount { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string? ForMonth { get; set; }
        public int? ForYear { get; set; }
        public string? InstitueId { get; set; }
        public bool? IsService { get; set; }
        public int? ServiceId { get; set; }
        public string? VendorBranchCode { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? PaymentCurrencyFor { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public decimal? ConvertionRate { get; set; }
        public decimal? BillAmount { get; set; }
        public decimal? MinAmount { get; set; }
        public decimal? DelayChargeAmount { get; set; }
        public decimal? PaneltyAmount { get; set; }
        public decimal? ProcessFeeAmount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal TotalPaymentAmount { get; set; }
        public string? PostedUserId { get; set; }
        public DateTime? PostingDate { get; set; }
        public string? AuthorizationUserId { get; set; }
        public DateTime? AuthDate { get; set; }
        public string? StatusId { get; set; }
        public bool? IsPosted { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsSmsgenerate { get; set; }
        public string? Note { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        
        public string? SessionID { get; set; }
        //RefConfirmNo,RefVerifyConfirmNo
        public string? RefConfirmNo { get; set; }
        public string? RefVerifyConfirmNo { get; set; }
        //
        public decimal? TillDateAmount { get; set; }
        public string? CustomerType    { get; set; }

        public string? BengalSlNo { get; set; }
        public string? BranchName { get; set; }
    }
}
