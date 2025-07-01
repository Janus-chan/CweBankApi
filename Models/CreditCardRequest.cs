using System.ComponentModel.DataAnnotations;

namespace CweBankApi.Models
{
    public class CreditCardRequest
    {
        public string CustomerName { get; set; }        
        public string Email { get; set; }               
        public string Address { get; set; }             
        public string Metadata { get; set; }            

        [CreditCardValidation]
        public string CreditCardNumber { get; set; }    
    }
}