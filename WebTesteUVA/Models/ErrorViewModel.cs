namespace WebTesteUVA.Models
{
    //Classe respons�vel por modelar uma view de erro. 
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}