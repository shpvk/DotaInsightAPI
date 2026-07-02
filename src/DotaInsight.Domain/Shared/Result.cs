namespace DotaInsight.Domain.Shared;

public class Result<T>
{
    // EF core
    private Result()
    {
        
    }
    
    public bool IsSuccess { get; private set; }

    public bool IsFailure => !IsSuccess;
    public T? Value { get; private set; } 
    public string? Error { get; private set; }
    
    public static Result<T> Success(T value)
    {
        return new Result<T>
        {
            IsSuccess = true,
            Value = value,
            Error = null
        };
    }
    
    public static Result<T> Failure(string error)
    {
        if (string.IsNullOrEmpty(error))
        {
            return new Result<T>
            {
                IsSuccess = false,
                Value = default,
                Error = "Error cannot be empty"
            };
        }
        
        return new Result<T>
        {
            IsSuccess = false,
            Value = default,
            Error = error
        };
    }
}