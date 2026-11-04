using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveRequest.Commands;

public class CreateLeaveRequestsCommand:IRequest<int>
{
    public CreateLeaveRequestDto  CreateLeaveRequest { get; set; }
}