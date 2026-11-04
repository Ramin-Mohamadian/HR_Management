using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.Requests.LeaveAllocation.Queries;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveAllocation.Queries;

public class GetLeaveAllocationHandler : IRequestHandler<GetLeaveAllocationRequest, LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;
    public GetLeaveAllocationHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;

    }
    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationRequest request, CancellationToken cancellationToken)
    {
        var leaveAllocatin=await _leaveAllocationRepository.Get(request.Id);
        return _mapper.Map<LeaveAllocationDto>(leaveAllocatin); 
    }
}