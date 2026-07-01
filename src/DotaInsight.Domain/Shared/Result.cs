namespace DotaInsight.Domain.Shared;

public class Result<T>
{
    private Result()
    {
        
    }
    
    private bool IsSuccess { get; set; }
    private T Value { get; set; }
    private string? Error { get; set; }
    
    public static void Success(T value)
    {
        
    }
    
    public static void Failure(string error)
    {

    }
}