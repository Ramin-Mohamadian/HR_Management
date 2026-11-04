using HR_Management.Domain.Common;

namespace HR_Management.Domain.Entities;

public class LeaveType:BaseDomainEntity
{
    public string Name { get; set; }
    public int DefaultDay { get; set; }

}