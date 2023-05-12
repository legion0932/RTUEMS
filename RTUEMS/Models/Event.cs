using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace RTUEMS.Models
{
    public enum VenueType
{
    WellnessAndHealthBuilding,
    UniversityGymnasium,
    Stage,
    LibraryBuilding,
    EstolasBuilding,
    RAndDBuilding,
    SnagahBuilding,
    Quadrangle
}
    public enum DepartmentType
    {
        CEAT,
        CBET,
        CAS,
        CED,
        IPERS
    }
    public enum CourseType
    {
        //CEAT
        BSArchitecture,
        BSComputerEngineering,
        BSElectricalEngineering,
        BSElectronicsEngineering,
        BSIndustrialEngineering,
        BSInformationTechnology,
        BSInstrumentationandControlEngineering,
        BSMechanicalEngineering,
        BSCivilEngineering,
        BSMechatronicsEngineering,
        //CBET
        BSAccountancy,
        BSEntrepreneurship,
        BSOfficeAdministration,
        BSBusinessAdministrationMajorinOperationManagement,
        BSBusinessAdministrationMajorinMarketingManagement,
        BSBusinessAdministrationMajorinFinancialManagement,
        BSBusinessAdministrationMajorinHumanResourceDevelopmentManagement,
        //CAS
        BSPsychology,
        BArtsinPoliticalScience,
        BSStatistics,
        BSBiology,
        BSAstronomy,
        //CED
        BSEducationMajorinEnglish,
        BSEducationMajorinMath,
        BSEducationMajorinSciences,
        BSEducationMajorinSocialStudies,
        BSEducationMajorinFilipino,
        BachelororTechnicalVocationalTeacherEducationMajorinAnimation,
        BachelororTechnicalVocationalTeacherEducationMajorinComputerSystemServicing,
        BachelororTechnicalVocationalTeacherEducationMajorinVisualGraphicDesign,
        BachelororTechnicalVocationalTeacherEducationMajorinGarmentsFashionandDesign,
        BachelororTechnicalVocationalTeacherEducationMajorinElectronicsTechnology,
        BachelororTechnicalVocationalTeacherEducationMajorinWeldingandFabricationsTechnology,
        //IPERS
        BSPhysicalEducation
    }

    public enum YearType
    {
        [Display(Name = "First Year")]
        first,
        [Display(Name = "Second Year")]
        second,
        [Display(Name = "Third Year")]
        third,
        [Display(Name = "First Year")]
        fourth,
        [Display(Name = "First Year")]
        fifth
    }

    public class Event
    {

        public int? Id { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "The email address is not valid.")]
        public string? Email { get; set; }
        [Display(Name = "Event Name")]
        [Required]
        [StringLength(100)]
        public string? EventName { get; set; }
        [Display(Name = "Event Type")]
        [Required]
        [StringLength(100)]
        public string? EventType { get; set; }
        [Display(Name = "Name of Organizer")]
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Display(Name = "DeparmentHeadName")]
        [Required]
        [StringLength(100)]
        public string? DepartmentHeadName { get; set; }
        [Display(Name = "Department Name")]
        [Required]
        [StringLength(100)]
        public string? DepartmentName { get; set; }
        [Required(ErrorMessage = "Please select a venue.")]
        public VenueType? Venue { get; set; }
        [Display(Name = "Date and Time")]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy h:mm tt}")]
        public DateTime? VenueTime { get; set; }
        [Display(Name = "Member Count")]
        [Required]
        [Range(0, 999)]
        public int MemberCount { get; set; }

    }

    public class Member
    {

        public int? Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "First name must only contain letters and spaces")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Last name must only contain letters and spaces")]
        public string? LastName { get; set; }
        public string? BlockSection { get; set; }
        public YearType? Year { get; set; }
        [RegularExpression(@"^\d{4}-\d{6}$", ErrorMessage = "StudentNumber should be in the format 'yyyy-######'")]
        [Display(Name = "Student Number")]
        public string? StudentNumber { get; set; }
        public DepartmentType? Department { get; set; }
        public CourseType? Courses { get; set; }
        [DataType(System.ComponentModel.DataAnnotations.DataType.EmailAddress)]
        [RegularExpression(@"^\d{4}-\d{6}@rtu\.edu\.ph$",
        ErrorMessage = "The Institutional Email field must be a valid email address in the format 'xxxx-yyyyyy@rtu.edu.ph'.")]
        public string? InstitutionalEmail { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone number is required")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber, ErrorMessage = "Please enter a valid phone number")]
        public string? Phone { get; set; }
        public string? EventName { get; set; }
    }


}


    
