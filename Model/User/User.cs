using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.User
{
    [Table("user")]
    public class User
    {
        [Key]
        public int id { get; private set; }
        public string? txt_first_name { get; private set; }
        public string? txt_last_name { get; private set; }
        public string? txt_cpf { get; private set; }
        public DateTime dt_birth_date { get; private set; }
        public int vl_age { get; private set; }
        public string? txt_phone_number { get; private set; }
        public string? txt_username { get; private set; }
        public string? txt_email { get; private set; }
        public string? txt_hash_password { get; private set; }

        public User(string txt_first_name, string txt_last_name, string txt_cpf, 
                    DateTime dt_birth_date, int vl_age, string txt_username, 
                    string txt_phone_number, string txt_email, string txt_hash_password)
        {
            this.txt_first_name = txt_first_name ?? throw new ArgumentNullException(nameof(txt_first_name));
            this.txt_last_name = txt_last_name;
            this.txt_cpf = txt_cpf;
            this.dt_birth_date = dt_birth_date;
            this.vl_age = vl_age;
            this.txt_phone_number = txt_phone_number;
            this.txt_username = txt_username;
            this.txt_email = txt_email;
            this.txt_hash_password = txt_hash_password;
        }
    }

    
}