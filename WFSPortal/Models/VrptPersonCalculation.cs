using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WFSPortal.Models;

[Keyless]
public partial class VrptPersonCalculation
{
    [Column("Adjusted Hire Date", TypeName = "datetime")]
    public DateTime? AdjustedHireDate { get; set; }

    [Column("Adjusted Hire Month")]
    public int? AdjustedHireMonth { get; set; }

    [Column("Adjusted Hire Quarter")]
    public int? AdjustedHireQuarter { get; set; }

    [Column("Adjusted Hire Year")]
    public int? AdjustedHireYear { get; set; }

    public int? Age { get; set; }

    [Column("Birth Date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("Birth Month")]
    public int? BirthMonth { get; set; }

    [Column("Birth Quarter")]
    public int? BirthQuarter { get; set; }

    [Column("Birth Year")]
    public int? BirthYear { get; set; }

    [Column("Current Annual Salary", TypeName = "money")]
    public decimal? CurrentAnnualSalary { get; set; }

    [Column("Current Base Pay Frequency Code")]
    [StringLength(15)]
    public string? CurrentBasePayFrequencyCode { get; set; }

    [Column("Current Base Pay Frequency")]
    public string? CurrentBasePayFrequency { get; set; }

    [Column("Current CompaRatio", TypeName = "money")]
    public decimal? CurrentCompaRatio { get; set; }

    [Column("Current Daily Salary", TypeName = "money")]
    public decimal? CurrentDailySalary { get; set; }

    [Column("Current Hourly Salary", TypeName = "money")]
    public decimal? CurrentHourlySalary { get; set; }

    [Column("Current Monthly Salary", TypeName = "money")]
    public decimal? CurrentMonthlySalary { get; set; }

    [Column("Current Pay Amount", TypeName = "money")]
    public decimal? CurrentPayAmount { get; set; }

    [Column("Current Quarterly Salary", TypeName = "money")]
    public decimal? CurrentQuarterlySalary { get; set; }

    [Column("Current Weekly Salary", TypeName = "money")]
    public decimal? CurrentWeeklySalary { get; set; }

    [Column("Latest Hire Date", TypeName = "datetime")]
    public DateTime? LatestHireDate { get; set; }

    [Column("Latest Hire Month")]
    public int? LatestHireMonth { get; set; }

    [Column("Latest Hire Quarter")]
    public int? LatestHireQuarter { get; set; }

    [Column("Latest Hire Year")]
    public int? LatestHireYear { get; set; }

    [Column("Original Hire Date", TypeName = "datetime")]
    public DateTime? OriginalHireDate { get; set; }

    [Column("Original Hire Month")]
    public int? OriginalHireMonth { get; set; }

    [Column("Original Hire Quarter")]
    public int? OriginalHireQuarter { get; set; }

    [Column("Original Hire Year")]
    public int? OriginalHireYear { get; set; }

    [Column("PersonGUID")]
    public Guid PersonGuid { get; set; }

    [Column("Previous Annual Salary", TypeName = "money")]
    public decimal? PreviousAnnualSalary { get; set; }

    [Column("Previous Base Pay Frequency Code")]
    [StringLength(15)]
    public string? PreviousBasePayFrequencyCode { get; set; }

    [Column("Previous Base Pay Frequency")]
    public string? PreviousBasePayFrequency { get; set; }

    [Column("Previous Daily Salary", TypeName = "money")]
    public decimal? PreviousDailySalary { get; set; }

    [Column("Previous Hourly Salary", TypeName = "money")]
    public decimal? PreviousHourlySalary { get; set; }

    [Column("Previous Monthly Salary", TypeName = "money")]
    public decimal? PreviousMonthlySalary { get; set; }

    [Column("Previous Pay Amount", TypeName = "money")]
    public decimal? PreviousPayAmount { get; set; }

    [Column("Previous Quaterly Salary", TypeName = "money")]
    public decimal? PreviousQuaterlySalary { get; set; }

    [Column("Previous Weekly Salary", TypeName = "money")]
    public decimal? PreviousWeeklySalary { get; set; }

    [Column("Seniority Date", TypeName = "datetime")]
    public DateTime? SeniorityDate { get; set; }

    [Column("Seniority Month")]
    public int? SeniorityMonth { get; set; }

    [Column("Seniority Quarter")]
    public int? SeniorityQuarter { get; set; }

    [Column("Seniority Year")]
    public int? SeniorityYear { get; set; }

    [Column("Service Days")]
    public int? ServiceDays { get; set; }

    [Column("Service Months")]
    public int? ServiceMonths { get; set; }

    [Column("Service Years")]
    public int? ServiceYears { get; set; }

    [Column("Termination Date", TypeName = "datetime")]
    public DateTime? TerminationDate { get; set; }

    [Column("Termination Day")]
    public int? TerminationDay { get; set; }

    [Column("Termination Month")]
    public int? TerminationMonth { get; set; }

    [Column("Termination Quarter")]
    public int? TerminationQuarter { get; set; }

    [Column("Termination Year")]
    public int? TerminationYear { get; set; }
}
