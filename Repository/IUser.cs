using System;
using BBU_SYSTEM.DTO;
using BBU_SYSTEM.Model.Req;
using BBU_SYSTEM.Model.Res;

namespace BBU_SYSTEM.Respository
{
	public interface IUser
	{ 
        public AuthRes login(string campus, AuthReq req); 
        public object register(string campus, UserDto req);
    }
}

