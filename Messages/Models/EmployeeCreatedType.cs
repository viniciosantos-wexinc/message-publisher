using System.Runtime.Serialization;

namespace Messages.Models;

public enum EmployeeCreatedType
{
    [DataMember(Name = "census_import")]
    census_import = 1,

    [DataMember(Name = "employee_editor")]
    employee_editor,

    [DataMember(Name = "quick_add")]
    quick_add,
}