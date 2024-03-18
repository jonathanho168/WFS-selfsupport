using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLoginParameter
{
    [Column("LoginParametersGUID")]
    public Guid LoginParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? PasswordMinimumNumbers { get; set; }

    public string? MaxLogDays { get; set; }

    public string? PasswordMinimumSpecialCharacters { get; set; }

    public string? PasswordExpirationFrequencyUnits { get; set; }

    public string? PasswordMinimumLength { get; set; }

    public string? PasswordLockoutEmail { get; set; }

    [Column("DeferredAuthenticationURL")]
    public string? DeferredAuthenticationUrl { get; set; }

    public string? DisplayForgotPassword { get; set; }

    public string? AllowSamePasswordAsUserIdFlag { get; set; }

    public string? PasswordMinimumLetters { get; set; }

    public string? MaxUnsuccessfulAttempts { get; set; }

    public string? PasswordExpirationFrequency { get; set; }
}
