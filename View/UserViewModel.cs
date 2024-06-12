using System.ComponentModel.DataAnnotations;

namespace View
{
    public class UserViewModel
    {
        public string txt_first_name { get; private set; }
        public string txt_last_name { get; private set; }
        public string txt_cpf { get; private set; }
        public DateTime dt_birth_date { get; private set; }
        public int vl_age { get; private set; }
        public string txt_phone_number { get; private set; }
        public string txt_username { get; private set; }
        public string txt_email { get; private set; }
        public string txt_hash_password { get; private set; }
    }
}