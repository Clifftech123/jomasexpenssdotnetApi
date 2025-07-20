

namespace jomasexpenssdotnetApi.Src.Domain.Contracts
{
    /// <summary>
    /// UserRegistrationRequest is a DTO for user registration operations.
    /// It includes properties for first name, last name, email, password, and gender.
    /// </summary>

    public class UserRegistrationRequest
    {

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

    }

    /// <summary>
    /// UserLoginRequest is a DTO for user login operations.
    /// It includes properties for email and password.
    /// </summary>

    public class UserLoginRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }

    /// <summary>
    /// UserLoginResponse is a DTO for user login responses.
    /// It includes the access token for the logged-in user.
    /// </summary>
    public class UserLoginResponse
    {
        public string AccessToken { get; set; } = string.Empty;
    }


    /// <summary>
    /// UserResponse is a DTO for user information returned in API responses.
    /// </summary>
    public class UserResponse
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }


    /// <summary>
    /// UpdateUserRequest is a DTO for updating user information.
    /// It allows partial updates to the user's first name, last name, email, and gender.
    /// </summary>
    public class UpdateUserRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Password { get; set; }

    }

}