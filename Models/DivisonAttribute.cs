using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnnuitetCalculator.Models
{
    public class DivisonAttribute : CompareAttribute
    {
        public DivisonAttribute(string otherProperty) : base(otherProperty)
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(OtherProperty);
            object otherValue = property.GetValue(validationContext.ObjectInstance);
            if (value.GetType() != otherValue.GetType() || value.GetType() != typeof(short)) {
                return new ValidationResult("Incompatible types");
            }
            short valueShort = (short)value;
            short otherValueShort = (short)otherValue;

            if (valueShort % otherValueShort > 0)
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }
    }
}
