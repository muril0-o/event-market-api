using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model.User;
using Repository;
using View;

namespace Controllers
{
    [ApiController]
    [Route("api/v1/user")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add(UserViewModel userViewModel)
        {
            var user = new User(
                userViewModel.txt_first_name,
                userViewModel.txt_last_name,
                userViewModel.txt_cpf,
                userViewModel.dt_birth_date,
                userViewModel.vl_age,
                userViewModel.txt_username,
                userViewModel.txt_phone_number,
                userViewModel.txt_email,
                userViewModel.txt_hash_password
            );
            
            _userRepository.Add(user);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = _userRepository.Get();

            return Ok(user);
        }
    }
}