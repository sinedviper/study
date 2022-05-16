﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Business.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace WebApi.Controllers {
    [Route("api/[controller]")]
    [AllowAnonymous]
    //здесь мы описываем процесс входа на сайт через api
    public class LoginController : Controller {
        private readonly IConfiguration config;

        public LoginController(IConfiguration config) {
            this.config = config;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UserDto user) {
            UserDto resultUser = AuthenticateUser(user);

            if (resultUser != null) {
                var token = GenerateJsonWebToken(resultUser);

                return Ok(token);
            }

            return Unauthorized();
        }

        private object GenerateJsonWebToken(UserDto user) {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:SecretKey"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[] {
                new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email, user.Email),
                new Claim("fullname", user.FullName),
                new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: config["Jwt:Issuer"],
                audience: config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserDto AuthenticateUser(UserDto user) {
            var users = new UserDto[] {
                new UserDto {
                    Email = "test1Email",
                    FullName ="test1FullName",
                    Password = "test1Password",
                    Username = "test1Username"
                },
                new UserDto {
                    Email = "test2Email",
                    FullName ="test2FullName",
                    Password = "test2Password",
                    Username = "test2Username"
                },
                new UserDto {
                    Email = "test3Email",
                    FullName ="test3FullName",
                    Password = "test3Password",
                    Username = "test3Username"
                },
                new UserDto {
                    Email = "test4Email",
                    FullName ="test4FullName",
                    Password = "test4Password",
                    Username = "test4Username"
                },
                new UserDto {
                    Email = "test5Email",
                    FullName ="test5FullName",
                    Password = "test5Password",
                    Username = "test5Username"
                },
                new UserDto {
                    Email = "test6Email",
                    FullName ="test6FullName",
                    Password = "test6Password",
                    Username = "test6Username"
                }
            };

            var foundUser = users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);

            if (foundUser != null) {
                return new UserDto {
                    Email = foundUser.Email,
                    FullName = foundUser.FullName,
                    Username = foundUser.Username
                };
            }
            return null;
        }
    }
}