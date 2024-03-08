using Grpc.Core;
using grpc;
using grpc.Helpers;


namespace grpc.Services;

public class GreeterService : Greeter.GreeterBase
{
    
    private Helper _math;
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
        _math = new Helper();
    }

    public override Task<BaseReply> SayHello(BaseRequest request, ServerCallContext context){
        return Task.FromResult(new BaseReply
        {
            //Message = "Hello " + request.Name
            //Message = request.Name  * 4
            //Message = request.Name  * 4
            Message = _math.Fact(request.Name)

        }) ;
    }
    public override Task<BaseReply> Factorial(BaseRequest request, ServerCallContext context){
        return Task.FromResult(new BaseReply
        {
            //Message = "Hello " + request.Name
            //Message = request.Name  * 4
            //Message = request.Name  * 4
            Message = _math.Fact(request.Name)

        }) ;
    }
}
