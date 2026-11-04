using HR_Management.Domain.Entities;

namespace HR_Management.Application.Contract;

public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
{
    Task ChangeApprovalStatus(LeaveRequest request, bool? ApprovalStatus);
}