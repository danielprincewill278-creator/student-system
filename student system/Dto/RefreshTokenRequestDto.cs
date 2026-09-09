namespace student_system.Dto
{
    public class RefreshTokenRequestDto
    {
        public Guid UserId { get; set; } 
        public required string Refreshtoken { get; set; }

    }
}
