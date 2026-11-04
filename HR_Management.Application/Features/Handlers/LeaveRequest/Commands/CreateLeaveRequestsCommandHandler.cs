using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.Features.Requests.LeaveRequest.Commands;
using MediatR;
namespace HR_Management.Application.Features.Handlers.LeaveRequest.Commands;

public class CreateLeaveRequestsCommandHandler : IRequestHandler<CreateLeaveRequestsCommand, int>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;
    // private readonly IEmailSender _emailSender;
    public CreateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
        // _emailSender = emailSender;
    }


    public async Task<int> Handle(CreateLeaveRequestsCommand request, CancellationToken cancellationToken)
    {
        var createLeaveRequest = _mapper.Map<Domain.Entities.LeaveRequest>(request.CreateLeaveRequest);
        createLeaveRequest=await _leaveRequestRepository.Add(createLeaveRequest);

        // var email = new Email
        // {
        //     To = "raminmohamadian2020@gmail.com",
        //     Subject = "this is Test",
        //     Body = "Idot have idea"
        // };
        //
        // try
        // {
        //     await _emailSender.SendEmail(email);
        // }
        // catch (Exception ex)
        // {
        //     //log
        //     throw;
        // }
        return createLeaveRequest.Id;
    }
}