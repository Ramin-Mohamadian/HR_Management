using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveRequest.Queries;

public class GetLeaveRequestsRequest:IRequest<LeaveRequestDto>
{
    public int Id { get; set; }
}