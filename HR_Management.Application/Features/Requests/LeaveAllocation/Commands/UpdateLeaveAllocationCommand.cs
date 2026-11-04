using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveAllocation.Commands;

public class UpdateLeaveAllocationCommand:IRequest<Unit>
{
    public UpdateLeaveAllocationDto UpdateLeaveAllocationDto { get; set; }
}