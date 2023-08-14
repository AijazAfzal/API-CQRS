namespace DDD.Prac.Model.Response
{
    public class ApiResponse 
    { 
    public int Id { get; set; }
    public bool IsSuccess { get; set; } = false;
    public string Message { get; set; }
    private ApiResponse(int id, bool isSuccess, string message)
    {
        Id = id;
        IsSuccess = isSuccess;
        Message = message;
    }
    public static ApiResponse ResponseMessages(int id, bool isSuccess, string message)
    {
        return new(id, isSuccess, message);
    }
}
}
