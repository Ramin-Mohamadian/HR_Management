using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveType.Quereis;

public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
{
    
}