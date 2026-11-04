using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.Features.Requests.LeaveAllocation.Commands;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveAllocation.Commands;

public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;
    public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await _leaveAllocationRepository.Get(request.UpdateLeaveAllocationDto.Id);
        _mapper.Map(request.UpdateLeaveAllocationDto, leaveAllocation);
        await _leaveAllocationRepository.Update(leaveAllocation);
        return Unit.Value;
    }
}