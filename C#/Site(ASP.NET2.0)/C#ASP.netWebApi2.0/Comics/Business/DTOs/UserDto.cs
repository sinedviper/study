﻿namespace Business.DTOs {
    //здесь поисываем параметры для входа через api
    public class UserDto {
        public string Username { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Password { get; set; }
    }
}
