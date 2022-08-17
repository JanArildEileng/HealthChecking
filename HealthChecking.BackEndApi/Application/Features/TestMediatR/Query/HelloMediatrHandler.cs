﻿using MediatR;


namespace HealthChecking.BackEndApi.Application.Features.TestMediatR.Query;

public class HelloMediatr : IRequest<string> { }

public class HelloMediatrHandler : IRequestHandler<HelloMediatr, string>
{
    public Task<string> Handle(HelloMediatr request, CancellationToken cancellationToken)
    {
        return Task.FromResult("Hello fra HelloMediatr");
    }
}
