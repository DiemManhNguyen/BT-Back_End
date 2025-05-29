// Models/User.cs
using System.ComponentModel.DataAnnotations;

public class User
{
    [Required(ErrorMessage = "Không được để trống!")]
    [Display(Name = "Mã sinh viên")]
    public string StudentId { get; set; }

    [Required(ErrorMessage = "Không được để trống!")]
    [StringLength(20, MinimumLength = 6, ErrorMessage = "Tài khoản từ 6 - 20 ký tự")]
    [Display(Name = "Tài khoản")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Không được để trống!")]
    [DataType(DataType.Password)]
    [Display(Name = "Mật khẩu")]
    public string Password { get; set; }

    [Display(Name = "Điện thoại")]
    public string Phone { get; set; }

    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    [Display(Name = "Email")]
    public string Email { get; set; }
}