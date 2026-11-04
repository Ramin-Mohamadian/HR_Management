namespace HR_Management.Application.DTOs;


public class LeaveRequestListDto : BaseDto
{
    public LeaveTypeDto leaveType { get; set; }
    public DateTime DateRequested { get; set; }
    public bool? Aporived { get; set; }

}