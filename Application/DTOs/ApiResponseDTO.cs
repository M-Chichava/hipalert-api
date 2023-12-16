using System.Net;
namespace Application.DTOs
{
    public class ApiResponseDTO
    {
         public HttpStatusCode StatusCode { get; set; }
         public string ErrorMessage { get; set; }
    }
}