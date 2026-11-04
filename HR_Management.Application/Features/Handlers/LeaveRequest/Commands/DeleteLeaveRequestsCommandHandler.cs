using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.Features.Requests.LeaveRequest.Commands;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveRequest.Commands;

public class DeleteLeaveRequestsCommandHandler : IRequestHandler<DeleteLeaveRequestsCommand, Unit>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;

    public DeleteLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteLeaveRequestsCommand request, CancellationToken cancellationToken)
    {
        var deleteLeaveRequest=await _leaveRequestRepository.Get(request.Id);
        await _leaveRequestRepository.Delete(deleteLeaveRequest);
        return Unit.Value;
    }
}