namespace BKAC.Models
{
    public class User
    {
        public string  Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string FaceImg { get; set; } = string.Empty;  
        public string CCCD { get; set; } = string.Empty;  // Số CCCD
        public string Fingerprint { get; set; } = string.Empty;  // Ảnh vân tay (Có thể lưu dưới dạng đường dẫn file hoặc base64)

        // Khởi tạo Id mặc định là Guid mới khi khởi tạo đối tượng
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
