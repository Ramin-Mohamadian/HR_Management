using AutoMapper;
using HR_Management.Application.DTOs;
using HR_Management.Domain.Entities;

namespace HR_Management.Application.Profiles;

public class MyProfiles:Profile
{
    public MyProfiles()
    {
        CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        CreateMap<LeaveType,CreateLeaveTypeDto>().ReverseMap();
        CreateMap<LeaveType, UpdateLeaveTypesDto>().ReverseMap();
        CreateMap<LeaveRequest, ChangeLeaveRequestApprovalDto>().ReverseMap();
        CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
        CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();
    }
}