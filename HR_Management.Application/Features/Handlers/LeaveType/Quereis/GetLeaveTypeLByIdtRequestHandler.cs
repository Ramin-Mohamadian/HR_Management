using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.Requests.LeaveType.Quereis;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveType.Quereis;

public class GetLeaveTypeLByIdtRequestHandler : IRequestHandler<GetLeaveTypeLByIdtRequest, LeaveTypeDto>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public GetLeaveTypeLByIdtRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<LeaveTypeDto> Handle(GetLeaveTypeLByIdtRequest request, CancellationToken cancellationToken)
    {
        var leaveType = await _leaveTypeRepository.Get(request.Id);
        return _mapper.Map<LeaveTypeDto>(leaveType);
    }
}