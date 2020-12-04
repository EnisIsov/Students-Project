using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsProject.CustomAttributes
{
    public class MacedonianMobilePhoneAttribute : ValidationAttribute
    {
        //+38971555222 => 12 characters.
        private const int MacedonianMobileNumberLength = 12;
        public override bool IsValid(object value)
        {
            var phoneString = value as string;

            var isMacedonian = phoneString.StartsWith("+389");

            if (!isMacedonian) return false;

            if (phoneString.Length != MacedonianMobileNumberLength)
                return false;

            var digitStringPart = phoneString.Substring(1);
            var isDigit = long.TryParse(digitStringPart, out long numberDigits);

            return isDigit;
        }
    }
}