using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveType.Commands;

public class DeleteLeaveTypesCommand:IRequest<Unit>
{
    public int Id { get; set; }
}