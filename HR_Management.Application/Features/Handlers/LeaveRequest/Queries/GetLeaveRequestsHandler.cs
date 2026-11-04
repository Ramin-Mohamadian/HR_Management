using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.Requests.LeaveRequest.Queries;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveRequest.Queries;

public class GetLeaveRequestsHandler : IRequestHandler<GetLeaveRequestsRequest, LeaveRequestDto>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;
    public GetLeaveRequestsHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }
    public async Task<LeaveRequestDto> Handle(GetLeaveRequestsRequest request, CancellationToken cancellationToken)
    {
        var leavereuest=await _leaveRequestRepository.Get(request.Id);
        return _mapper.Map<LeaveRequestDto>(leavereuest);
    }
}