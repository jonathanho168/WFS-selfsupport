using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VRegistrationParameter
{
    [Column("RegistrationParametersGUID")]
    public Guid RegistrationParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? EmailRegisterBody { get; set; }

    public string? AssignManagersToManagerRoles { get; set; }

    public string? IdentificationField { get; set; }

    public string? EmailRegisterBodyForWindowsAuthUsers { get; set; }

    public string? EmailRegisterSubject { get; set; }

    public string? AssignManagersToEmployeeRoles { get; set; }

    public string? AssignUsersMobilePortalAccess { get; set; }

    public string? PasswordResetExpirationMinutes { get; set; }

    public string? EmailRegisterBodyForDeferredAuthUsers { get; set; }
}
