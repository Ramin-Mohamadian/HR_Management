using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveRequest.Commands;

public class DeleteLeaveRequestsCommand:IRequest<Unit>
{
    public int Id { get; set; }
}