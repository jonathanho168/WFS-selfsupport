using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VPerformanceReviewParameter
{
    [Column("PerformanceReviewParametersGUID")]
    public Guid PerformanceReviewParametersGuid { get; set; }

    public int RowVersion { get; set; }

    public string? AutoAddJobCompetencies { get; set; }

    public string? AutoFixedStartDate { get; set; }

    public string? AutoCreationDateOffsetUnits { get; set; }

    public string? AutoOtherParticipationDueDateOffsetDirection { get; set; }

    public string? AutoRepeatFrequencyCode { get; set; }

    [Column("AutoDefaultReviewerPersonGUID")]
    public string? AutoDefaultReviewerPersonGuid { get; set; }

    public string? AllowPublicLoginFlag { get; set; }

    public string? AllowJournalEntries { get; set; }

    public string? Allow360Reviews { get; set; }

    public string? GoalWeightsOverridable { get; set; }

    public string? EmployeeRespondsBeforeReviewer { get; set; }

    public string? AllowRecommendedScore { get; set; }

    public string? AutoScheduledDateOffsetUnits { get; set; }

    public string? AutoOtherParticipationDueDateOffsetFrequencyCode { get; set; }

    public string? GoalQuestionText { get; set; }

    public string? AutoAddEmployeeGoals { get; set; }

    public string? AutoDueDateOffsetFrequencyCode { get; set; }

    public string? AutoScoreReviews { get; set; }

    public string? AutoCreationDateMethod { get; set; }

    public string? ReviewerParticipantCode { get; set; }

    public string? AutoDefaultReviewerPrecedence { get; set; }

    public string? DefaultGoalWeight { get; set; }

    public string? DefaultJobCompetencyWeight { get; set; }

    public string? AllowEmployeeAccessBeforeOthers { get; set; }

    public string? AutoScheduledDateOffsetDirection { get; set; }

    public string? EmployeeRespondsAfterReviewer { get; set; }

    public string? AutoRepeatFrequencyUnits { get; set; }

    public string? EmployeeViewOtherParticipantSummary { get; set; }

    public string? AllowSuggestedComments { get; set; }

    public string? AutoCreationDateOffsetFrequencyCode { get; set; }

    public string? AutoScheduledDateOffsetFrequencyCode { get; set; }

    [Column("AllowManagerViewEEJournalEntries")]
    public string? AllowManagerViewEejournalEntries { get; set; }

    public string? EmployeeParticipantCode { get; set; }

    public string? AllowAdditionalQuestions { get; set; }

    public string? EmployeeParticipantWarningCount { get; set; }

    public string? AutoOtherParticipationDueDateOffsetUnits { get; set; }

    public string? AutoPeriodEndDateOffsetFrequencyCode { get; set; }

    public string? AutoReviewTypeCode { get; set; }

    public string? AutoPeriodEndDateOffsetUnits { get; set; }

    public string? AutoReviewCreationEnabled { get; set; }

    public string? AutoDueDateOffsetUnits { get; set; }

    public string? MaxScore { get; set; }

    public string? EnableWeightedScoring { get; set; }

    public string? IncludeGoalsInFinalPerformanceReviewScore { get; set; }

    public string? AutoDueDateOffsetDirection { get; set; }
}
