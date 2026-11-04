using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveRequest.Commands;

public class UpdateLeaveRequestsCommand:IRequest<Unit>
{
    public int Id { get; set; }
    public ChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto { get; set; }
    public UpdateLeaveRequestDto  UpdateLeaveRequestDto { get; set; }
}