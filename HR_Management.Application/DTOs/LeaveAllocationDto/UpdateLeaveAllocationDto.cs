namespace HR_Management.Application.DTOs;

public class UpdateLeaveAllocationDto:BaseDto
{
    public int NumberOfDays { get; set; }
    public LeaveTypeDto LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public int Priod { get; set; }
}