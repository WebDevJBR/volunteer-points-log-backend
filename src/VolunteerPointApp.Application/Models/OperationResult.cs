namespace VolunteerPointApp.Application.Models;

/// <summary>
/// Encapsulates the result of an Application-layer operation.
/// </summary>
/// <typeparam name="T">The type of the object encapsulated by the <see cref="OperationResult" /> instance.</typeparam>
public class OperationResult<T> where T : notnull
{
    /// <summary>
    /// The object encapsulated by the <see cref="OperationResult" /> instance.
    /// </summary>
    public T? Data { get; private set; }

    /// <summary>
    /// Encapsulates error information, in the event that the instance contains an error.
    /// </summary>
    public Error? Error { get; private set; }

    /// <summary>
    /// Indicates whether or not the <see cref="OperationResult" /> instance contains an error.
    /// </summary>
    public bool HasError => Error is not null;

    /// <summary>
    /// Encapsulates exception information, if the event that the instance contains an exception.
    /// </summary>
    public Exception? Exception { get; set; }

    /// <summary>
    /// Indicates whether or not the <see cref="OperationResult" /> instance contains an exception.
    /// </summary>
    public bool HasException => Exception is not null;

    /// <summary>
    /// Marks the <see cref="OperationResult" /> instance as successful.
    /// </summary>
    /// <param name="data">The object encapsulated by the <see cref="OperationResult" /> instance.</param>
    public void Success(T data)
    {
        Data = data;
    }
    
    /// <summary>
    /// Marks the <see cref="OperationResult" /> instance as unsuccessful.
    /// </summary>
    /// <param name="error">Encapsulates error information, in the event that the instance contains an error.</param>
    public void Failure(Error error)
    {
        Error = error;
    }
}
