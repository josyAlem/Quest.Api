﻿using AutoMapper;
using Quest.Api.Common.Request;
using Quest.Api.Common.Response;
using Quest.Api.Services.Interfaces;
using Studio.Auth.Auth0.Interfaces;
using Studio.Auth.Auth0.Models;
using System;
using System.Threading.Tasks;

namespace Quest.Api.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IAuth0Service _auth0Service;

        public AuthService(IAuth0Service auth0Service, IMapper mapper)
        {
            _auth0Service = auth0Service;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            try
            {
                Auth0LoginRequest auth0loginRequest = _mapper.Map<Auth0LoginRequest>(loginRequest);
                var authresponse = await _auth0Service.Login(auth0loginRequest);
                LoginResponse loginResponse = _mapper.Map<LoginResponse>(authresponse);


                return loginResponse;
            }
            catch  {
                throw;
            }
        }

        public async Task<RefreshTokenResponse> Refresh(RefreshTokenRequest refreshTokenRequest)
        {
            Auth0RefreshTokenRequest auth0refreshTokenRequest = _mapper.Map<Auth0RefreshTokenRequest>(refreshTokenRequest);
            var authresponse = await _auth0Service.Refresh(auth0refreshTokenRequest);

            RefreshTokenResponse refreshResponse = _mapper.Map<RefreshTokenResponse>(authresponse);

            return refreshResponse;
        }

        public async Task<SignupResponse> SignUp(SignupRequest signupRequest)
        {
            Auth0SignupRequest auth0signupRequest = _mapper.Map<Auth0SignupRequest>(signupRequest);
            var authresponse = await _auth0Service.SignUp(auth0signupRequest);

            SignupResponse loginResponse = _mapper.Map<SignupResponse>(authresponse);

            return loginResponse;
        }
    }
}
