namespace OBL.BIC.Entity
{
    public class LogerData
    {
        public string UserName { get; set; }
        public string custId { get; set; }
        public decimal amount { get; set; }
        public string transactionCode { get; set; }
        public string branchName { get; set; }
        public string sessionId { get; set; }

    }

//  exp  {
//  "amount": 1699.0,
//  "sessionId": "SSL1016",
//  "branchName": "Dilkusha",
//  "transactionCode": "1234",
//  "custId": "0110000007"
//}
}
