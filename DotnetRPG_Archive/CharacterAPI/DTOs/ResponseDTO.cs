namespace CharacterAPI.DTOs
{
    public class ResponseDTO<T>
    {
        public T? Data { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public bool Success { get; set; } = true;
    }
}
