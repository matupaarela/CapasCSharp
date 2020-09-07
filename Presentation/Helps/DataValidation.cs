using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Helps
{
    public class DataValidation
    {
        private ValidationContext validationContext;
        private List<ValidationResult> validationResults;
        private bool Valid;
        private string Msg;

        public DataValidation(object instance)
        {
            validationContext = new ValidationContext(instance);
            validationResults = new List<ValidationResult>();
            Valid = Validator.TryValidateObject(instance, validationContext, validationResults, true);
        }

        public bool Validate()
        {
            if (!Valid)
            {
                foreach(ValidationResult result in validationResults)
                {
                    Msg += result.ErrorMessage + "\n";
                }
                System.Windows.Forms.MessageBox.Show(Msg);
            }
            return Valid;
        }
    }
}
