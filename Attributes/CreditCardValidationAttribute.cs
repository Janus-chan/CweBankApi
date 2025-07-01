using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CweBankApi.Attributes
{
    public class CreditCardValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is not string cc) return false;
            return Regex.IsMatch(cc, @"^\d{4}-?\d{4}-?\d{4}-?\d{4}$");
        }
    }
}