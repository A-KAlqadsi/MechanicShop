namespace MechanicShop.Domain.Common.Results;

public readonly record struct Error
{
    private Error(string code, string description, ErrorKind type)
    {
        Code = code;
        Description = description;
        Type = type;
    }

    public string Code { get; }
    public string Description { get; }
    public ErrorKind Type { get; }

    public static Error Failure(string code = nameof(Failure), string description = "Failure error")
    => new Error(code, description, ErrorKind.Failure);

    public static Error Unexpected(string code = nameof(Unexpected), string description = "Unexpected error")
      => new Error(code, description, ErrorKind.Unexpected);

    public static Error Validation(string code = nameof(Validation), string description = "Validation error")
    => new Error(code, description, ErrorKind.Validation);

    public static Error Conflict(string code = nameof(Conflict), string description = "Conflict error")
    => new Error(code, description, ErrorKind.Conflict);

    public static Error NotFound(string code = nameof(NotFound), string description = "Not Found error")
    => new Error(code, description, ErrorKind.NotFound);

    public static Error Unauthorized(string code = nameof(Unauthorized), string description = "Unauthorized error")
    => new Error(code, description, ErrorKind.Unauthorized);

    public static Error Forbidden(string code = nameof(Forbidden), string description = "Forbidden error")
    => new Error(code, description, ErrorKind.Forbidden);

    public static Error Create(int type, string code, string description)
   => new Error(code, description, (ErrorKind)type);
}