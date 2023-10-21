namespace SampleFluentValidations.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            IsValid = true;
            ValidationMessage = new List<string>();
        } 
        public bool IsValid { get; set; }
        public List<string>  ValidationMessage { get; set; }
    }
}
