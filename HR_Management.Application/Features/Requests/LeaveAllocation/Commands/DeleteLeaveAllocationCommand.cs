using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveAllocation.Commands;

public class DeleteLeaveAllocationCommand:IRequest<Unit>
{
    public int Id { get; set; }
}