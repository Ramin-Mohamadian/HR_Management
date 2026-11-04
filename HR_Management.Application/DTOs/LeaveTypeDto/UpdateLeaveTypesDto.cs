namespace HR_Management.Application.DTOs;

public class UpdateLeaveTypesDto:BaseDto
{
    public string Name { get; set; }
    public int DefaultDay { get; set; }
}