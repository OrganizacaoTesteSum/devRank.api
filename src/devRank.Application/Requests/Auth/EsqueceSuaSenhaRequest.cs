﻿using devRank.Application.Abstractions.Contracts;
using devRank.Application.Responses.Auth;

namespace devRank.Application.Requests.Auth;

public record EsqueceSuaSenhaRequest(
    long Id,
    string Senha) : IRequestUseCase<LoginResponse>;