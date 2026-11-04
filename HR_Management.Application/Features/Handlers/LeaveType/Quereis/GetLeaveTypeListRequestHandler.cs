using AutoMapper;
using HR_Management.Application.Contract;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.Requests.LeaveType.Quereis;
using MediatR;

namespace HR_Management.Application.Features.Handlers.LeaveType.Quereis;

public class GetLeaveTypeListRequestHandler:IRequestHandler<GetLeaveTypeListRequest,List<LeaveTypeDto>>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;
    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }
    
    
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var listLeaveType = await _leaveTypeRepository.GetAll();
        return _mapper.Map<List<LeaveTypeDto>>(listLeaveType);
    }
}