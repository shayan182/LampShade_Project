using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace _0_Framework.Application
{
    public class FileRequiredAttribute : ValidationAttribute , IClientModelValidator
    {

        public override bool IsValid(object value)
        {
            var file = value as IFormFile;
            if (file == null )
                return false;
            
            return file.Length != 0;
        }
        public void AddValidation(ClientModelValidationContext context)
        {
            //context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-fileRequired", ErrorMessage);
        }

    }
}
