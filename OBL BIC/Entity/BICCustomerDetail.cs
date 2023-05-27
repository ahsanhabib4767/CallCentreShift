using Newtonsoft.Json;

namespace OBL.BIC.Entity
{
    public class BICCustomerDetail
    {

        
      

        public class Root
        {
            public string res { get; set; }
            public string sessionId { get; set; }
            public string custId { get; set; }

            public string custName { get; set; }
            public string semesterName { get; set; }
            public double amount { get; set; }
            public string errorMsg { get; set; }
            public string refConfirmationNo { get; set; }
            public string verifyConfirmationNo { get; set; }
            
        }
        
    }

}
