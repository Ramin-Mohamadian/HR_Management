using HR_Management.Application.DTOs;
using MediatR;

namespace HR_Management.Application.Features.Requests.LeaveAllocation.Queries;

public class GetLeaveAllocationListRequest:IRequest<IEnumerable<LeaveAllocationDto>>
{

}