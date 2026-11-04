using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.Requests.LeaveAllocation.Queries;
using MediatR;
namespace HR_Management.Application.Features.Handlers.LeaveAllocation.Queries;
public class GetLeaveAllocationListHandler : IRequestHandler<GetLeaveAllocationListRequest, IEnumerable<LeaveAllocationDto>>
{

    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;
    public GetLeaveAllocationListHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;

    }
    public async Task<IEnumerable<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
    {
        var getlist=await _leaveAllocationRepository.GetAll();
        return _mapper.Map<List<LeaveAllocationDto>>(getlist);
    }
}