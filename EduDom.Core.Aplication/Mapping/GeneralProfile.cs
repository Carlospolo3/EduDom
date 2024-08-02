using AutoMapper;
using EduDom.Core.Aplication.DTOs.Account;
using EduDom.Core.Aplication.ViewModels.Attendance;
using EduDom.Core.Aplication.ViewModels.District;
using EduDom.Core.Aplication.ViewModels.Estudent;
using EduDom.Core.Aplication.ViewModels.Qualifications;
using EduDom.Core.Aplication.ViewModels.Subjects;
using EduDom.Core.Aplication.ViewModels.User;
using EduDom.Core.Domain.Entities;



namespace EduDom.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            // Student mappings
            CreateMap<Student, StudentViewModels>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            CreateMap<SubjectsSaveViewModels, Student>();

            // Course mappings
            CreateMap<Course, CourseViewModel>();
            CreateMap<CourseSaveViewModels, Course>();

            // Registration mappings
            CreateMap<Registration, RegistrationViewModel>()
                .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.StudentId))
                .ForMember(dest => dest.Course, opt => opt.MapFrom(src => src.CourseId));
            CreateMap<RegistrationSaveViewModels, Registration>();

            // Attendance mappings
            CreateMap<Attendance, AttendanceViewModels>();
            CreateMap<AttendanceSaveViewModels, Attendance>();

            // School mappings
            CreateMap<School, SchoolViewModels>();
            CreateMap<SchoolSaveViewModels, School>();

            // Qualifications mappings
            CreateMap<Qualifications, QualificationsViewModels>();
            CreateMap<QualificationsSaveViewModels, Qualifications>();

            // Subjects mappings
            CreateMap<Subjects, SubjectsViewModels>();
            CreateMap<SubjectsSaveViewModels, Subjects>();

            // Time Class mappings
            CreateMap<Schedule, TimeClassViewModels>();
            CreateMap<TimeClassSaveViewModel, Schedule>();

            // District mappings
            CreateMap<District, DistrictViewModels>();
            CreateMap<DistrictSaveViewModels, District>();

            // Department mappings
            CreateMap<Department, DepartmentViewModels>();
            CreateMap<DepartmentSaveViewModels, Department>();



        }
    }
}
