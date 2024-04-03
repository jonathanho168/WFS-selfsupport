using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VApplicantParameter
{
    [Column("ApplicantParametersGUID")]
    public Guid ApplicantParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? TrackingStatusOpen { get; set; }

    public string? CandidatePortalDisplayUrl { get; set; }

    public string? CandidateShowCandidateApplicationStatus { get; set; }

    public string? AttachmentsFileSizeByteLimit { get; set; }

    public string? CandidateEnableSearchHistory { get; set; }
}
