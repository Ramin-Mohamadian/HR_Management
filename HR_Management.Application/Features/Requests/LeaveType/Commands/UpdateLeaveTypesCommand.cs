using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveType.Commands;

public class UpdateLeaveTypesCommand:IRequest<Unit>
{
    public UpdateLeaveTypesDto UpdateLeaveTypesDto { get; set; }
}       