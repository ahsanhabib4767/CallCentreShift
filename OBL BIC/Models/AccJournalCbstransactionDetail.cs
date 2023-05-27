using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccJournalCbstransactionDetail
    {
        public string ReferenceSysId { get; set; } = null!;
        public decimal TransId { get; set; }
        public int Sl { get; set; }
        public string BranchCode { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string? AccountName { get; set; }
        public string? RelatedAccountNo { get; set; }
        public string? TxnType { get; set; }
        public string? TxnCode { get; set; }
        public string? PurposeCode { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmountBdt { get; set; }
        public decimal? CreditAmountBdt { get; set; }
        public decimal ConverstionRate { get; set; }
        public string? CbsresponseCode { get; set; }
        public string? CbsauthResponse { get; set; }
        public string? CbsrefId { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? AuthorizationDate { get; set; }
        public string? PostedUser { get; set; }
        public string? AuthorizerUser { get; set; }
        public string? Narration { get; set; }
        public string? IsAuthorized { get; set; }
        public string? IsPosted { get; set; }
        public string IsReversal { get; set; } = null!;
    }
}
