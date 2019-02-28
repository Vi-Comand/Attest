//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StaffPortfolioDto", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class StaffPortfolioDto : object
    {
        
        private ServiceReference2.AcademicDegreeInfo[] AcademicAwardsDataField;
        
        private ServiceReference2.EducationInfo[] EducationDataField;
        
        private ServiceReference2.MainPositionInfo MainPositionField;
        
        private ServiceReference2.OrganizationInfo OrganizationDataField;
        
        private ServiceReference2.PersonDataInfo PersonDataField;
        
        private ServiceReference2.StaffMethodicalActivityInfo[] StaffMethodicalActivityDataField;
        
        private ServiceReference2.PortfolioFiles[] StaffPortfolioFilesDataField;
        
        private ServiceReference2.StaffRetrainingInfo[] StaffRetrainingsDataField;
        
        private ServiceReference2.StaffTrainingsInfo[] StaffTrainingsDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.AcademicDegreeInfo[] AcademicAwardsData
        {
            get
            {
                return this.AcademicAwardsDataField;
            }
            set
            {
                this.AcademicAwardsDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.EducationInfo[] EducationData
        {
            get
            {
                return this.EducationDataField;
            }
            set
            {
                this.EducationDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.MainPositionInfo MainPosition
        {
            get
            {
                return this.MainPositionField;
            }
            set
            {
                this.MainPositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.OrganizationInfo OrganizationData
        {
            get
            {
                return this.OrganizationDataField;
            }
            set
            {
                this.OrganizationDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.PersonDataInfo PersonData
        {
            get
            {
                return this.PersonDataField;
            }
            set
            {
                this.PersonDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.StaffMethodicalActivityInfo[] StaffMethodicalActivityData
        {
            get
            {
                return this.StaffMethodicalActivityDataField;
            }
            set
            {
                this.StaffMethodicalActivityDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.PortfolioFiles[] StaffPortfolioFilesData
        {
            get
            {
                return this.StaffPortfolioFilesDataField;
            }
            set
            {
                this.StaffPortfolioFilesDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.StaffRetrainingInfo[] StaffRetrainingsData
        {
            get
            {
                return this.StaffRetrainingsDataField;
            }
            set
            {
                this.StaffRetrainingsDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.StaffTrainingsInfo[] StaffTrainingsData
        {
            get
            {
                return this.StaffTrainingsDataField;
            }
            set
            {
                this.StaffTrainingsDataField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MainPositionInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class MainPositionInfo : object
    {
        
        private System.Nullable<System.DateTime> AttestDateField;
        
        private string CategoryField;
        
        private string PositionField;
        
        private string WorkerCategoryField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> AttestDate
        {
            get
            {
                return this.AttestDateField;
            }
            set
            {
                this.AttestDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category
        {
            get
            {
                return this.CategoryField;
            }
            set
            {
                this.CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Position
        {
            get
            {
                return this.PositionField;
            }
            set
            {
                this.PositionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkerCategory
        {
            get
            {
                return this.WorkerCategoryField;
            }
            set
            {
                this.WorkerCategoryField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrganizationInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class OrganizationInfo : object
    {
        
        private string AddressField;
        
        private string EmailField;
        
        private string FullNameField;
        
        private string HeadFullNameField;
        
        private string MunicipalityField;
        
        private string PhoneNumberField;
        
        private string ShortNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName
        {
            get
            {
                return this.FullNameField;
            }
            set
            {
                this.FullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HeadFullName
        {
            get
            {
                return this.HeadFullNameField;
            }
            set
            {
                this.HeadFullNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Municipality
        {
            get
            {
                return this.MunicipalityField;
            }
            set
            {
                this.MunicipalityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumberField;
            }
            set
            {
                this.PhoneNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShortName
        {
            get
            {
                return this.ShortNameField;
            }
            set
            {
                this.ShortNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDataInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class PersonDataInfo : object
    {
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName
        {
            get
            {
                return this.MiddleNameField;
            }
            set
            {
                this.MiddleNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AcademicDegreeInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class AcademicDegreeInfo : object
    {
        
        private string AcademicDegreeField;
        
        private string AcademicTitleField;
        
        private ServiceReference2.AwardDocumentDto AwardDocumentField;
        
        private string SpecialityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AcademicDegree
        {
            get
            {
                return this.AcademicDegreeField;
            }
            set
            {
                this.AcademicDegreeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AcademicTitle
        {
            get
            {
                return this.AcademicTitleField;
            }
            set
            {
                this.AcademicTitleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.AwardDocumentDto AwardDocument
        {
            get
            {
                return this.AwardDocumentField;
            }
            set
            {
                this.AwardDocumentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speciality
        {
            get
            {
                return this.SpecialityField;
            }
            set
            {
                this.SpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducationInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class EducationInfo : object
    {
        
        private ServiceReference2.CompletionDocumentDto CompletionDocumentField;
        
        private string MunicipalityField;
        
        private string OrganizationField;
        
        private ServiceReference2.YearsPeriodDto PeriodField;
        
        private string QualificationField;
        
        private string SpecialityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.CompletionDocumentDto CompletionDocument
        {
            get
            {
                return this.CompletionDocumentField;
            }
            set
            {
                this.CompletionDocumentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Municipality
        {
            get
            {
                return this.MunicipalityField;
            }
            set
            {
                this.MunicipalityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Organization
        {
            get
            {
                return this.OrganizationField;
            }
            set
            {
                this.OrganizationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.YearsPeriodDto Period
        {
            get
            {
                return this.PeriodField;
            }
            set
            {
                this.PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Qualification
        {
            get
            {
                return this.QualificationField;
            }
            set
            {
                this.QualificationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speciality
        {
            get
            {
                return this.SpecialityField;
            }
            set
            {
                this.SpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StaffMethodicalActivityInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class StaffMethodicalActivityInfo : object
    {
        
        private string HostingAddressField;
        
        private string ImplementedInField;
        
        private int LevelField;
        
        private int ParticipationField;
        
        private ServiceReference2.YearsPeriodDto PeriodField;
        
        private string ProductNameField;
        
        private string WorkNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HostingAddress
        {
            get
            {
                return this.HostingAddressField;
            }
            set
            {
                this.HostingAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImplementedIn
        {
            get
            {
                return this.ImplementedInField;
            }
            set
            {
                this.ImplementedInField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Level
        {
            get
            {
                return this.LevelField;
            }
            set
            {
                this.LevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Participation
        {
            get
            {
                return this.ParticipationField;
            }
            set
            {
                this.ParticipationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.YearsPeriodDto Period
        {
            get
            {
                return this.PeriodField;
            }
            set
            {
                this.PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this.ProductNameField;
            }
            set
            {
                this.ProductNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkName
        {
            get
            {
                return this.WorkNameField;
            }
            set
            {
                this.WorkNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PortfolioFiles", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class PortfolioFiles : object
    {
        
        private string DescriptionField;
        
        private byte[] FileField;
        
        private System.Nullable<ServiceReference2.FileCategory> FileCategoryField;
        
        private string OriginalFileNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<ServiceReference2.FileCategory> FileCategory
        {
            get
            {
                return this.FileCategoryField;
            }
            set
            {
                this.FileCategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalFileName
        {
            get
            {
                return this.OriginalFileNameField;
            }
            set
            {
                this.OriginalFileNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StaffRetrainingInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class StaffRetrainingInfo : ServiceReference2.StaffCommonTrainingInfo
    {
        
        private string NoteField;
        
        private string QualificationField;
        
        private int RetrainingTypeField;
        
        private string SpecialityField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Note
        {
            get
            {
                return this.NoteField;
            }
            set
            {
                this.NoteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Qualification
        {
            get
            {
                return this.QualificationField;
            }
            set
            {
                this.QualificationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RetrainingType
        {
            get
            {
                return this.RetrainingTypeField;
            }
            set
            {
                this.RetrainingTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speciality
        {
            get
            {
                return this.SpecialityField;
            }
            set
            {
                this.SpecialityField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StaffTrainingsInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class StaffTrainingsInfo : ServiceReference2.StaffCommonTrainingInfo
    {
        
        private ServiceReference2.VisitForm FormField;
        
        private ServiceReference2.Level LevelField;
        
        private string ThemeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.VisitForm Form
        {
            get
            {
                return this.FormField;
            }
            set
            {
                this.FormField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.Level Level
        {
            get
            {
                return this.LevelField;
            }
            set
            {
                this.LevelField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Theme
        {
            get
            {
                return this.ThemeField;
            }
            set
            {
                this.ThemeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AwardDocumentDto", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class AwardDocumentDto : object
    {
        
        private System.DateTime AwardDateField;
        
        private int DocTypeField;
        
        private string NumberField;
        
        private string OrganizationField;
        
        private string SeriesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime AwardDate
        {
            get
            {
                return this.AwardDateField;
            }
            set
            {
                this.AwardDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DocType
        {
            get
            {
                return this.DocTypeField;
            }
            set
            {
                this.DocTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Organization
        {
            get
            {
                return this.OrganizationField;
            }
            set
            {
                this.OrganizationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Series
        {
            get
            {
                return this.SeriesField;
            }
            set
            {
                this.SeriesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompletionDocumentDto", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class CompletionDocumentDto : object
    {
        
        private string DocNameField;
        
        private System.Nullable<ServiceReference2.EducDocumentType> DocTypeField;
        
        private System.Nullable<System.DateTime> IssueDateField;
        
        private string NumberField;
        
        private string RegNumberField;
        
        private string SeriesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocName
        {
            get
            {
                return this.DocNameField;
            }
            set
            {
                this.DocNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<ServiceReference2.EducDocumentType> DocType
        {
            get
            {
                return this.DocTypeField;
            }
            set
            {
                this.DocTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> IssueDate
        {
            get
            {
                return this.IssueDateField;
            }
            set
            {
                this.IssueDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number
        {
            get
            {
                return this.NumberField;
            }
            set
            {
                this.NumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegNumber
        {
            get
            {
                return this.RegNumberField;
            }
            set
            {
                this.RegNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Series
        {
            get
            {
                return this.SeriesField;
            }
            set
            {
                this.SeriesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YearsPeriodDto", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class YearsPeriodDto : object
    {
        
        private int EndField;
        
        private int StartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int End
        {
            get
            {
                return this.EndField;
            }
            set
            {
                this.EndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Start
        {
            get
            {
                return this.StartField;
            }
            set
            {
                this.StartField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EducDocumentType", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public enum EducDocumentType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        TrainingCertificate = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PreprofessionalArtsMasteringCertificate = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AnotherEducationDocument = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AnotherTrainingDocument = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecondaryGeneralEducationCertificate = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecondaryBasicEducationCertificate = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecondaryProfEducationDiploma = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BachelorDegree = 22,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SpecialistDiploma = 23,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MasterDegree = 24,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PostgraduateDiploma = 25,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ResidencyCompletionDiploma = 26,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InternshipAssistantCompletionDiploma = 27,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProfessionalDevelopmentCertificate = 31,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ProfessionalRetrainingDiploma = 32,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WorkerCertificate = 33,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PersonsWithDisabilitiesEducationCertificate = 41,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileCategory", Namespace="http://schemas.datacontract.org/2004/07/NetCity.Common.ObjectModel.Nhibernate.Use" +
        "rs.Attestation.Basic")]
    public enum FileCategory : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AttestApplication = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PrevAttestCopy = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Section1 = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Section2 = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Section3 = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Section4 = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Section5 = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PersonalInfoAgreement = 8,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StaffCommonTrainingInfo", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference2.StaffTrainingsInfo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference2.StaffRetrainingInfo))]
    public partial class StaffCommonTrainingInfo : object
    {
        
        private ServiceReference2.CompletionDocumentDto CompletionDocumentField;
        
        private System.Nullable<int> HoursField;
        
        private string OrganizationField;
        
        private ServiceReference2.DatesPeriodDto PeriodField;
        
        private string PlaceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.CompletionDocumentDto CompletionDocument
        {
            get
            {
                return this.CompletionDocumentField;
            }
            set
            {
                this.CompletionDocumentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Hours
        {
            get
            {
                return this.HoursField;
            }
            set
            {
                this.HoursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Organization
        {
            get
            {
                return this.OrganizationField;
            }
            set
            {
                this.OrganizationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference2.DatesPeriodDto Period
        {
            get
            {
                return this.PeriodField;
            }
            set
            {
                this.PeriodField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DatesPeriodDto", Namespace="http://schemas.datacontract.org/2004/07/NetCity.WebServices.StaffPortfolioService" +
        ".Model")]
    public partial class DatesPeriodDto : object
    {
        
        private System.Nullable<System.DateTime> EndField;
        
        private System.DateTime StartField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> End
        {
            get
            {
                return this.EndField;
            }
            set
            {
                this.EndField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Start
        {
            get
            {
                return this.StartField;
            }
            set
            {
                this.StartField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VisitForm", Namespace="http://schemas.datacontract.org/2004/07/NetCity.Common.ObjectModel.Nhibernate.Eve" +
        "nts")]
    public enum VisitForm : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FullTime = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Distance = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FullTimeDistance = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Extramural = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Level", Namespace="http://schemas.datacontract.org/2004/07/NetCity.Common.ObjectModel.Nhibernate.Use" +
        "rs.Attestation.Basic")]
    public enum Level : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Municipal = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Region = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Federation = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        International = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.StaffPortfolioService")]
    public interface StaffPortfolioService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StaffPortfolioService/GetStaffInfoBySnils", ReplyAction="http://tempuri.org/StaffPortfolioService/GetStaffInfoBySnilsResponse")]
        System.Threading.Tasks.Task<ServiceReference2.MsgGetStaffInfoResponse> GetStaffInfoBySnilsAsync(ServiceReference2.MsgGetStaffInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MsgGetStaffInfoRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MsgGetStaffInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Snils;
        
        public MsgGetStaffInfoRequest()
        {
        }
        
        public MsgGetStaffInfoRequest(string Snils)
        {
            this.Snils = Snils;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MsgGetStaffInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MsgGetStaffInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference2.StaffPortfolioDto staffPortfolio;
        
        public MsgGetStaffInfoResponse()
        {
        }
        
        public MsgGetStaffInfoResponse(ServiceReference2.StaffPortfolioDto staffPortfolio)
        {
            this.staffPortfolio = staffPortfolio;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface StaffPortfolioServiceChannel : ServiceReference2.StaffPortfolioService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class StaffPortfolioServiceClient : System.ServiceModel.ClientBase<ServiceReference2.StaffPortfolioService>, ServiceReference2.StaffPortfolioService
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StaffPortfolioServiceClient() : 
                base(StaffPortfolioServiceClient.GetDefaultBinding(), StaffPortfolioServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_StaffPortfolioService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaffPortfolioServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(StaffPortfolioServiceClient.GetBindingForEndpoint(endpointConfiguration), StaffPortfolioServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaffPortfolioServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StaffPortfolioServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaffPortfolioServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StaffPortfolioServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StaffPortfolioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference2.MsgGetStaffInfoResponse> ServiceReference2.StaffPortfolioService.GetStaffInfoBySnilsAsync(ServiceReference2.MsgGetStaffInfoRequest request)
        {
            return base.Channel.GetStaffInfoBySnilsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.MsgGetStaffInfoResponse> GetStaffInfoBySnilsAsync(string Snils)
        {
            ServiceReference2.MsgGetStaffInfoRequest inValue = new ServiceReference2.MsgGetStaffInfoRequest();
            inValue.Snils = Snils;
            return ((ServiceReference2.StaffPortfolioService)(this)).GetStaffInfoBySnilsAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_StaffPortfolioService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_StaffPortfolioService))
            {
                return new System.ServiceModel.EndpointAddress("https://krd.rso23.ru:444/WebServices/WS/StaffPortfolioService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return StaffPortfolioServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_StaffPortfolioService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return StaffPortfolioServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_StaffPortfolioService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_StaffPortfolioService,
        }
    }
}
