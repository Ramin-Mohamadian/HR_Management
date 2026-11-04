using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveAllocation.Commands;

public class CreateLeaveAllocationCommand:IRequest<int>
{
    public CreateLeaveAllocationDto CreateLeaveAllocation { get; set; }
}