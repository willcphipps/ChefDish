using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ChefDish.Models {
    public class FutureDateAttribute : ValidationAttribute {
        protected override ValidationResult IsValid (object value, ValidationContext validationContext) {
            if (value is DateTime) {
                DateTime compare = (DateTime) value;
                compare.AddYears (18);
                if (compare < DateTime.Now) {
                    return ValidationResult.Success;
                } else {
                    return new ValidationResult ("You are too young to be a cat-chef");
                }
            } else {
                return new ValidationResult ("This is not a valid date");
            }
        }
    }
}