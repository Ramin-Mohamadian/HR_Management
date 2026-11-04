using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.Requests.LeaveRequest.Queries;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveRequest.Queries;
public class GetLeaveRequestsListHandler : IRequestHandler<GetLeaveRequestsListRequest, List<LeaveRequestDto>>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;
    public GetLeaveRequestsListHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }
    public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestsListRequest request, CancellationToken cancellationToken)
    {
        var listleave=await _leaveRequestRepository.GetAll();
        return _mapper.Map<List<LeaveRequestDto>>(listleave);
    }
}