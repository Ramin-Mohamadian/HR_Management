using System.Runtime;
using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveType.Quereis;

public class GetLeaveTypeLByIdtRequest:IRequest<LeaveTypeDto>
{
    public int Id { get; set; }
}