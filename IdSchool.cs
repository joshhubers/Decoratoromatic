
public class IdSchool : IIdentfiable
{
  private School _base;

  public IdSchool() { _base = new School(); }

  public IdSchool(School baseClass) { _base = baseClass; }
      
  public Guid Id
  {
    get
    {
      return _base.Id;
    }
    set
    {
      _base.Id = value;
    }
  }

  public int? schoolId
  {
    get
    {
      return _base.schoolId;
    }
    set
    {
      _base.schoolId = value;
    }
  }

  public string stateOrganizationId
  {
    get
    {
      return _base.stateOrganizationId;
    }
    set
    {
      _base.stateOrganizationId = value;
    }
  }

  public string nameOfInstitution
  {
    get
    {
      return _base.nameOfInstitution;
    }
    set
    {
      _base.nameOfInstitution = value;
    }
  }

  public string shortNameOfInstitution
  {
    get
    {
      return _base.shortNameOfInstitution;
    }
    set
    {
      _base.shortNameOfInstitution = value;
    }
  }

  public string webSite
  {
    get
    {
      return _base.webSite;
    }
    set
    {
      _base.webSite = value;
    }
  }

  public string operationalStatusType
  {
    get
    {
      return _base.operationalStatusType;
    }
    set
    {
      _base.operationalStatusType = value;
    }
  }

  public string type
  {
    get
    {
      return _base.type;
    }
    set
    {
      _base.type = value;
    }
  }

  public string charterStatusType
  {
    get
    {
      return _base.charterStatusType;
    }
    set
    {
      _base.charterStatusType = value;
    }
  }

  public string titleIPartASchoolDesignationType
  {
    get
    {
      return _base.titleIPartASchoolDesignationType;
    }
    set
    {
      _base.titleIPartASchoolDesignationType = value;
    }
  }

  public string administrativeFundingControlDescriptor
  {
    get
    {
      return _base.administrativeFundingControlDescriptor;
    }
    set
    {
      _base.administrativeFundingControlDescriptor = value;
    }
  }

  public string administrativeFundingControlType
  {
    get
    {
      return _base.administrativeFundingControlType;
    }
    set
    {
      _base.administrativeFundingControlType = value;
    }
  }

  public School_localEducationAgency localEducationAgencyReference
  {
    get
    {
      return _base.localEducationAgencyReference;
    }
    set
    {
      _base.localEducationAgencyReference = value;
    }
  }

  public List<School_educationOrganizationAddress> addresses
  {
    get
    {
      return _base.addresses;
    }
    set
    {
      _base.addresses = value;
    }
  }

  public List<School_educationOrganizationCategory> educationOrganizationCategories
  {
    get
    {
      return _base.educationOrganizationCategories;
    }
    set
    {
      _base.educationOrganizationCategories = value;
    }
  }

  public List<School_educationOrganizationIdentificationCode> identificationCodes
  {
    get
    {
      return _base.identificationCodes;
    }
    set
    {
      _base.identificationCodes = value;
    }
  }

  public List<School_educationOrganizationInstitutionTelephone> institutionTelephones
  {
    get
    {
      return _base.institutionTelephones;
    }
    set
    {
      _base.institutionTelephones = value;
    }
  }

  public List<School_educationOrganizationInternationalAddress> internationalAddresses
  {
    get
    {
      return _base.internationalAddresses;
    }
    set
    {
      _base.internationalAddresses = value;
    }
  }

  public List<School_schoolCategory> schoolCategories
  {
    get
    {
      return _base.schoolCategories;
    }
    set
    {
      _base.schoolCategories = value;
    }
  }

  public List<School_schoolGradeLevel> gradeLevels
  {
    get
    {
      return _base.gradeLevels;
    }
    set
    {
      _base.gradeLevels = value;
    }
  }

  }
}
      
