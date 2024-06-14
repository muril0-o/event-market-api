using System.ComponentModel.DataAnnotations;

namespace View
{
    public class UserViewModel
    {
        [Required]
        public string? txt_first_name { get; set;}
        [Required]
        public string? txt_last_name { get; set; }
        [Required]
        public string? txt_cpf { get;  set; }
        [Required]
        public DateTime dt_birth_date { get; set;} 
        [Required]
        public int vl_age { get; set; }
        [Required]
        public string? txt_phone_number { get; set; }
        [Required]
        public string? txt_username { get; set; }
        [Required]
        public string? txt_email { get; set; }
        [Required]
        public string? txt_hash_password { get; set; }
    }
}