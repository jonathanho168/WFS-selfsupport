using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VLnkPersonBenefitEnrollmentOfferTango
{
    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OfferStartDate { get; set; }

    public int? EmployeeCoverageFlag { get; set; }

    public int? SpousalCoverageFlag { get; set; }

    public int? DependentCoverageFlag { get; set; }

    public int? EmployeeMinimumEssentialCoverageFlag { get; set; }

    public int? EmployeeMinimumValueFlag { get; set; }

    public int? SpousalMinimumEssentialCoverageFlag { get; set; }

    public int? SpousalMinimumValueFlag { get; set; }

    public int? DependentMinimumEssentialCoverageFlag { get; set; }

    public int? DependentMinimumValueFlag { get; set; }

    [Column(TypeName = "money")]
    public decimal? LowestEmployeeContributionAmount { get; set; }
}
