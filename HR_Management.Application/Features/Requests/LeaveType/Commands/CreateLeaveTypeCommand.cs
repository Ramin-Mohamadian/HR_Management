using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveType.Commands;

public class CreateLeaveTypeCommand:IRequest<int>
{
    public CreateLeaveTypeDto CreateLeaveTypeDto { get; set; }
}