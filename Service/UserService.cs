using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model;
using BBU_SYSTEM.Model.Req;
using BBU_SYSTEM.Model.Res;
using BBU_SYSTEM.Respository;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace BBU_SYSTEM.Service
{
	public class UserService : IUser
	{
        private readonly ICampusDbContext _campusDbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UserService(ICampusDbContext campusDbContext, IMapper mapper, IConfiguration configuration)
        {
            this._campusDbContext = campusDbContext;
            this._mapper = mapper;
            this._configuration = configuration;
        }

        public AuthRes login(string campus, AuthReq req)
		{
            var db = _campusDbContext.DbContext(campus);
            var data = db.tbl_user.Where(x => x.user_name == req.username && x.password == req.password).FirstOrDefault();
            if (data == null) return null!;
            AuthRes res = new AuthRes();
            res.user_id = data.user_id;
            res.user_name = data.user_name;
            res.user_group = data.user_group;
            res.password = data.password;
            res.status = data.status;
            res.token = campus +"-"+generateJwtToken(req);
            res.expire_in = DateTime.Now.AddHours(1);
            return res;
		}
        public object register(string campus, UserDto req)
		{
            var dto = _mapper.Map<UserDto, User>(req);
            var db = _campusDbContext.DbContext(campus);
            db.tbl_user.Add(dto);
            db.SaveChanges();
            return getid(campus, dto.user_id); 
		}


        public User getid(string campus, int id)
        {
            var data = _campusDbContext.DbContext(campus).tbl_user.Where(x => x.user_id == id).FirstOrDefault();
            return data!;
        }

        private string generateJwtToken(AuthReq req)
        {
            var cliams = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, req.username!),
                new Claim(JwtRegisteredClaimNames.Jti, req.password!)
            };
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(issuer: _configuration["Jwt:Issuer"],
                                                audience: _configuration["Jwt:Audience"],
                                                claims: cliams,
                                                expires: DateTime.Now.AddHours(1),
                                                signingCredentials: signinCredentials);
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return tokenString;
        }

        [Obsolete]
        public static string EncriptSha256PassWord(string Password)
        {
            try
            {
                var crypt = new SHA256Managed();
                var hash = new StringBuilder();
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(Password));
                foreach (byte theByte in crypto)
                {
                    hash.Append(theByte.ToString("x2"));
                }
                return hash.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}

