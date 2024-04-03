using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WFSPortal.Models;

public partial class Epicorhcmcmu2024Context : DbContext
{
    public Epicorhcmcmu2024Context()
    {
    }

    public Epicorhcmcmu2024Context(DbContextOptions<Epicorhcmcmu2024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AaDirectDep> AaDirectDeps { get; set; }

    public virtual DbSet<AhrJobTg> AhrJobTgs { get; set; }

    public virtual DbSet<AhrReliasEmployeeSsn> AhrReliasEmployeeSsns { get; set; }

    public virtual DbSet<Dc401k> Dc401ks { get; set; }

    public virtual DbSet<DcBasePayReason> DcBasePayReasons { get; set; }

    public virtual DbSet<DcClearance> DcClearances { get; set; }

    public virtual DbSet<DcConfigLinkTable> DcConfigLinkTables { get; set; }

    public virtual DbSet<DcCostCenter> DcCostCenters { get; set; }

    public virtual DbSet<DcDepartment> DcDepartments { get; set; }

    public virtual DbSet<DcDependent> DcDependents { get; set; }

    public virtual DbSet<DcDriverInfo> DcDriverInfos { get; set; }

    public virtual DbSet<DcForeignKey> DcForeignKeys { get; set; }

    public virtual DbSet<DcFsjuneAbsence> DcFsjuneAbsences { get; set; }

    public virtual DbSet<DcFswphoursWeek> DcFswphoursWeeks { get; set; }

    public virtual DbSet<DcFswpjobcode> DcFswpjobcodes { get; set; }

    public virtual DbSet<DcGradeCode> DcGradeCodes { get; set; }

    public virtual DbSet<DcHireDate> DcHireDates { get; set; }

    public virtual DbSet<DcHsa> DcHsas { get; set; }

    public virtual DbSet<DcJobCategory> DcJobCategories { get; set; }

    public virtual DbSet<DcJobCode> DcJobCodes { get; set; }

    public virtual DbSet<DcLocation> DcLocations { get; set; }

    public virtual DbSet<DcOrgUnitCode> DcOrgUnitCodes { get; set; }

    public virtual DbSet<DcOrgUnitLevel> DcOrgUnitLevels { get; set; }

    public virtual DbSet<DcPerson> DcPeople { get; set; }

    public virtual DbSet<DcPersonAbsence> DcPersonAbsences { get; set; }

    public virtual DbSet<DcPersonAddress> DcPersonAddresses { get; set; }

    public virtual DbSet<DcPersonBasePay> DcPersonBasePays { get; set; }

    public virtual DbSet<DcPersonBenefit> DcPersonBenefits { get; set; }

    public virtual DbSet<DcPersonDirectDep> DcPersonDirectDeps { get; set; }

    public virtual DbSet<DcPersonEmergency> DcPersonEmergencies { get; set; }

    public virtual DbSet<DcPersonJob> DcPersonJobs { get; set; }

    public virtual DbSet<DcPersonLocation> DcPersonLocations { get; set; }

    public virtual DbSet<DcPersonPerformance> DcPersonPerformances { get; set; }

    public virtual DbSet<DcPersonPhone> DcPersonPhones { get; set; }

    public virtual DbSet<DcPersonStatus> DcPersonStatuses { get; set; }

    public virtual DbSet<DcPersonTerm> DcPersonTerms { get; set; }

    public virtual DbSet<DcPersonTimeGroup> DcPersonTimeGroups { get; set; }

    public virtual DbSet<DcPersonal> DcPersonals { get; set; }

    public virtual DbSet<DcPosition> DcPositions { get; set; }

    public virtual DbSet<DcPositionJobTitle> DcPositionJobTitles { get; set; }

    public virtual DbSet<DcProject> DcProjects { get; set; }

    public virtual DbSet<DcSupervisor> DcSupervisors { get; set; }

    public virtual DbSet<DcTimeGroup> DcTimeGroups { get; set; }

    public virtual DbSet<DcTimeGroupTimeType> DcTimeGroupTimeTypes { get; set; }

    public virtual DbSet<DcTimeType> DcTimeTypes { get; set; }

    public virtual DbSet<DcVolLife> DcVolLives { get; set; }

    public virtual DbSet<DcWorkersComp> DcWorkersComps { get; set; }

    public virtual DbSet<DcWorkersCompUpdate> DcWorkersCompUpdates { get; set; }

    public virtual DbSet<Lnk6bvWAdp10001> Lnk6bvWAdp10001s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10002> Lnk6bvWAdp10002s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10003> Lnk6bvWAdp10003s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10004> Lnk6bvWAdp10004s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10005> Lnk6bvWAdp10005s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10006> Lnk6bvWAdp10006s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10007> Lnk6bvWAdp10007s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10008> Lnk6bvWAdp10008s { get; set; }

    public virtual DbSet<Lnk6bvWAdp10008CrTableHold> Lnk6bvWAdp10008CrTableHolds { get; set; }

    public virtual DbSet<Lnk6bvWAdptime100027> Lnk6bvWAdptime100027s { get; set; }

    public virtual DbSet<Lnk6bvWAdptime100028> Lnk6bvWAdptime100028s { get; set; }

    public virtual DbSet<Lnk834HdData834hm> Lnk834HdData834hms { get; set; }

    public virtual DbSet<Lnk834HdData834ml> Lnk834HdData834mls { get; set; }

    public virtual DbSet<Lnk834HdData834uhc> Lnk834HdData834uhcs { get; set; }

    public virtual DbSet<Lnk834HdData834upmc> Lnk834HdData834upmcs { get; set; }

    public virtual DbSet<Lnk834HdData834vba> Lnk834HdData834vbas { get; set; }

    public virtual DbSet<Lnk834InsData834hm> Lnk834InsData834hms { get; set; }

    public virtual DbSet<Lnk834InsData834ml> Lnk834InsData834mls { get; set; }

    public virtual DbSet<Lnk834InsData834uhc> Lnk834InsData834uhcs { get; set; }

    public virtual DbSet<Lnk834InsData834upmc> Lnk834InsData834upmcs { get; set; }

    public virtual DbSet<Lnk834InsData834vba> Lnk834InsData834vbas { get; set; }

    public virtual DbSet<Lnk834W50102000Dmg> Lnk834W50102000Dmgs { get; set; }

    public virtual DbSet<Lnk834W50102000Dtp336> Lnk834W50102000Dtp336s { get; set; }

    public virtual DbSet<Lnk834W50102000In> Lnk834W50102000Ins { get; set; }

    public virtual DbSet<Lnk834W50102000N3> Lnk834W50102000N3s { get; set; }

    public virtual DbSet<Lnk834W50102000N4> Lnk834W50102000N4s { get; set; }

    public virtual DbSet<Lnk834W50102000Nm1> Lnk834W50102000Nm1s { get; set; }

    public virtual DbSet<Lnk834W50102000Per> Lnk834W50102000Pers { get; set; }

    public virtual DbSet<Lnk834W50102000Ref0f> Lnk834W50102000Ref0fs { get; set; }

    public virtual DbSet<Lnk834W50102300Dtp348> Lnk834W50102300Dtp348s { get; set; }

    public virtual DbSet<Lnk834W50102300Dtp349> Lnk834W50102300Dtp349s { get; set; }

    public virtual DbSet<Lnk834W50102300Hd> Lnk834W50102300Hds { get; set; }

    public virtual DbSet<Lnk834W50102300Ref1l> Lnk834W50102300Ref1ls { get; set; }

    public virtual DbSet<Lnk834W5010Bgn> Lnk834W5010Bgns { get; set; }

    public virtual DbSet<Lnk834W5010G> Lnk834W5010Gs { get; set; }

    public virtual DbSet<Lnk834W5010Ge> Lnk834W5010Ges { get; set; }

    public virtual DbSet<Lnk834W5010Iea> Lnk834W5010Ieas { get; set; }

    public virtual DbSet<Lnk834W5010Isa> Lnk834W5010Isas { get; set; }

    public virtual DbSet<Lnk834W5010N1payer> Lnk834W5010N1payers { get; set; }

    public virtual DbSet<Lnk834W5010N1sponser> Lnk834W5010N1sponsers { get; set; }

    public virtual DbSet<Lnk834W5010Se> Lnk834W5010Ses { get; set; }

    public virtual DbSet<Lnk834W5010St> Lnk834W5010Sts { get; set; }

    public virtual DbSet<Lnk834W834hm0001> Lnk834W834hm0001s { get; set; }

    public virtual DbSet<Lnk834W834hm0002> Lnk834W834hm0002s { get; set; }

    public virtual DbSet<Lnk834W834hm0003> Lnk834W834hm0003s { get; set; }

    public virtual DbSet<Lnk834W834hm0004> Lnk834W834hm0004s { get; set; }

    public virtual DbSet<Lnk834W834hm1000> Lnk834W834hm1000s { get; set; }

    public virtual DbSet<Lnk834W834hm1001> Lnk834W834hm1001s { get; set; }

    public virtual DbSet<Lnk834W834hm2000> Lnk834W834hm2000s { get; set; }

    public virtual DbSet<Lnk834W834hm2001> Lnk834W834hm2001s { get; set; }

    public virtual DbSet<Lnk834W834hm2006> Lnk834W834hm2006s { get; set; }

    public virtual DbSet<Lnk834W834hm2100> Lnk834W834hm2100s { get; set; }

    public virtual DbSet<Lnk834W834hm2101> Lnk834W834hm2101s { get; set; }

    public virtual DbSet<Lnk834W834hm2102> Lnk834W834hm2102s { get; set; }

    public virtual DbSet<Lnk834W834hm2103> Lnk834W834hm2103s { get; set; }

    public virtual DbSet<Lnk834W834hm2104> Lnk834W834hm2104s { get; set; }

    public virtual DbSet<Lnk834W834hm2300> Lnk834W834hm2300s { get; set; }

    public virtual DbSet<Lnk834W834hm2301> Lnk834W834hm2301s { get; set; }

    public virtual DbSet<Lnk834W834hm2302> Lnk834W834hm2302s { get; set; }

    public virtual DbSet<Lnk834W834hm2303> Lnk834W834hm2303s { get; set; }

    public virtual DbSet<Lnk834W834hm9991> Lnk834W834hm9991s { get; set; }

    public virtual DbSet<Lnk834W834hm9992> Lnk834W834hm9992s { get; set; }

    public virtual DbSet<Lnk834W834hm9993> Lnk834W834hm9993s { get; set; }

    public virtual DbSet<LnkHvhWAdp10001> LnkHvhWAdp10001s { get; set; }

    public virtual DbSet<LnkHvhWAdp10002> LnkHvhWAdp10002s { get; set; }

    public virtual DbSet<LnkHvhWAdp10003> LnkHvhWAdp10003s { get; set; }

    public virtual DbSet<LnkHvhWAdp10004> LnkHvhWAdp10004s { get; set; }

    public virtual DbSet<LnkHvhWAdp10005> LnkHvhWAdp10005s { get; set; }

    public virtual DbSet<LnkHvhWAdp10006> LnkHvhWAdp10006s { get; set; }

    public virtual DbSet<LnkHvhWAdp10007> LnkHvhWAdp10007s { get; set; }

    public virtual DbSet<LnkHvhWAdp10008> LnkHvhWAdp10008s { get; set; }

    public virtual DbSet<LnkHvhWAdp10008CrTableHold> LnkHvhWAdp10008CrTableHolds { get; set; }

    public virtual DbSet<LnkHvhWhAdp10001> LnkHvhWhAdp10001s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10002> LnkHvhWhAdp10002s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10003> LnkHvhWhAdp10003s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10004> LnkHvhWhAdp10004s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10005> LnkHvhWhAdp10005s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10006> LnkHvhWhAdp10006s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10007> LnkHvhWhAdp10007s { get; set; }

    public virtual DbSet<LnkHvhWhAdp10008> LnkHvhWhAdp10008s { get; set; }

    public virtual DbSet<LnkMetlifeW50102000Dmg> LnkMetlifeW50102000Dmgs { get; set; }

    public virtual DbSet<LnkMetlifeW50102000Dtp336> LnkMetlifeW50102000Dtp336s { get; set; }

    public virtual DbSet<LnkMetlifeW50102000In> LnkMetlifeW50102000Ins { get; set; }

    public virtual DbSet<LnkMetlifeW50102000N3> LnkMetlifeW50102000N3s { get; set; }

    public virtual DbSet<LnkMetlifeW50102000N4> LnkMetlifeW50102000N4s { get; set; }

    public virtual DbSet<LnkMetlifeW50102000Nm1> LnkMetlifeW50102000Nm1s { get; set; }

    public virtual DbSet<LnkMetlifeW50102000Per> LnkMetlifeW50102000Pers { get; set; }

    public virtual DbSet<LnkMetlifeW50102000Ref0f> LnkMetlifeW50102000Ref0fs { get; set; }

    public virtual DbSet<LnkMetlifeW50102300Dtp348> LnkMetlifeW50102300Dtp348s { get; set; }

    public virtual DbSet<LnkMetlifeW50102300Dtp349> LnkMetlifeW50102300Dtp349s { get; set; }

    public virtual DbSet<LnkMetlifeW50102300Hd> LnkMetlifeW50102300Hds { get; set; }

    public virtual DbSet<LnkMetlifeW50102300Ref1l> LnkMetlifeW50102300Ref1ls { get; set; }

    public virtual DbSet<LnkMetlifeW5010Bgn> LnkMetlifeW5010Bgns { get; set; }

    public virtual DbSet<LnkMetlifeW5010G> LnkMetlifeW5010Gs { get; set; }

    public virtual DbSet<LnkMetlifeW5010Ge> LnkMetlifeW5010Ges { get; set; }

    public virtual DbSet<LnkMetlifeW5010Iea> LnkMetlifeW5010Ieas { get; set; }

    public virtual DbSet<LnkMetlifeW5010Isa> LnkMetlifeW5010Isas { get; set; }

    public virtual DbSet<LnkMetlifeW5010N1payer> LnkMetlifeW5010N1payers { get; set; }

    public virtual DbSet<LnkMetlifeW5010N1sponser> LnkMetlifeW5010N1sponsers { get; set; }

    public virtual DbSet<LnkMetlifeW5010Se> LnkMetlifeW5010Ses { get; set; }

    public virtual DbSet<LnkMetlifeW5010St> LnkMetlifeW5010Sts { get; set; }

    public virtual DbSet<LnkMetlifeW834ml0001> LnkMetlifeW834ml0001s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml0002> LnkMetlifeW834ml0002s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml0003> LnkMetlifeW834ml0003s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml0004> LnkMetlifeW834ml0004s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml1000> LnkMetlifeW834ml1000s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml1001> LnkMetlifeW834ml1001s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2000> LnkMetlifeW834ml2000s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2001> LnkMetlifeW834ml2001s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2006> LnkMetlifeW834ml2006s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2100> LnkMetlifeW834ml2100s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2101> LnkMetlifeW834ml2101s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2102> LnkMetlifeW834ml2102s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2103> LnkMetlifeW834ml2103s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2104> LnkMetlifeW834ml2104s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2300> LnkMetlifeW834ml2300s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2301> LnkMetlifeW834ml2301s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2302> LnkMetlifeW834ml2302s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml2303> LnkMetlifeW834ml2303s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml9991> LnkMetlifeW834ml9991s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml9992> LnkMetlifeW834ml9992s { get; set; }

    public virtual DbSet<LnkMetlifeW834ml9993> LnkMetlifeW834ml9993s { get; set; }

    public virtual DbSet<LnkUhcW50102000Dmg> LnkUhcW50102000Dmgs { get; set; }

    public virtual DbSet<LnkUhcW50102000Dtp300> LnkUhcW50102000Dtp300s { get; set; }

    public virtual DbSet<LnkUhcW50102000Dtp336> LnkUhcW50102000Dtp336s { get; set; }

    public virtual DbSet<LnkUhcW50102000In> LnkUhcW50102000Ins { get; set; }

    public virtual DbSet<LnkUhcW50102000N3> LnkUhcW50102000N3s { get; set; }

    public virtual DbSet<LnkUhcW50102000N4> LnkUhcW50102000N4s { get; set; }

    public virtual DbSet<LnkUhcW50102000Nm1> LnkUhcW50102000Nm1s { get; set; }

    public virtual DbSet<LnkUhcW50102000Per> LnkUhcW50102000Pers { get; set; }

    public virtual DbSet<LnkUhcW50102000Ref0f> LnkUhcW50102000Ref0fs { get; set; }

    public virtual DbSet<LnkUhcW50102000Ref1l> LnkUhcW50102000Ref1ls { get; set; }

    public virtual DbSet<LnkUhcW50102300Dtp348> LnkUhcW50102300Dtp348s { get; set; }

    public virtual DbSet<LnkUhcW50102300Dtp349> LnkUhcW50102300Dtp349s { get; set; }

    public virtual DbSet<LnkUhcW50102300Hd> LnkUhcW50102300Hds { get; set; }

    public virtual DbSet<LnkUhcW5010Bgn> LnkUhcW5010Bgns { get; set; }

    public virtual DbSet<LnkUhcW5010G> LnkUhcW5010Gs { get; set; }

    public virtual DbSet<LnkUhcW5010Ge> LnkUhcW5010Ges { get; set; }

    public virtual DbSet<LnkUhcW5010Iea> LnkUhcW5010Ieas { get; set; }

    public virtual DbSet<LnkUhcW5010Isa> LnkUhcW5010Isas { get; set; }

    public virtual DbSet<LnkUhcW5010N1payer> LnkUhcW5010N1payers { get; set; }

    public virtual DbSet<LnkUhcW5010N1sponser> LnkUhcW5010N1sponsers { get; set; }

    public virtual DbSet<LnkUhcW5010Ref38> LnkUhcW5010Ref38s { get; set; }

    public virtual DbSet<LnkUhcW5010Se> LnkUhcW5010Ses { get; set; }

    public virtual DbSet<LnkUhcW5010St> LnkUhcW5010Sts { get; set; }

    public virtual DbSet<LnkUpmcW50102000Dmg> LnkUpmcW50102000Dmgs { get; set; }

    public virtual DbSet<LnkUpmcW50102000Dtp336> LnkUpmcW50102000Dtp336s { get; set; }

    public virtual DbSet<LnkUpmcW50102000In> LnkUpmcW50102000Ins { get; set; }

    public virtual DbSet<LnkUpmcW50102000N3> LnkUpmcW50102000N3s { get; set; }

    public virtual DbSet<LnkUpmcW50102000N4> LnkUpmcW50102000N4s { get; set; }

    public virtual DbSet<LnkUpmcW50102000Nm1> LnkUpmcW50102000Nm1s { get; set; }

    public virtual DbSet<LnkUpmcW50102000Per> LnkUpmcW50102000Pers { get; set; }

    public virtual DbSet<LnkUpmcW50102000Ref0f> LnkUpmcW50102000Ref0fs { get; set; }

    public virtual DbSet<LnkUpmcW50102300Dtp348> LnkUpmcW50102300Dtp348s { get; set; }

    public virtual DbSet<LnkUpmcW50102300Dtp349> LnkUpmcW50102300Dtp349s { get; set; }

    public virtual DbSet<LnkUpmcW50102300Hd> LnkUpmcW50102300Hds { get; set; }

    public virtual DbSet<LnkUpmcW50102300Ref1l> LnkUpmcW50102300Ref1ls { get; set; }

    public virtual DbSet<LnkUpmcW5010Bgn> LnkUpmcW5010Bgns { get; set; }

    public virtual DbSet<LnkUpmcW5010G> LnkUpmcW5010Gs { get; set; }

    public virtual DbSet<LnkUpmcW5010Ge> LnkUpmcW5010Ges { get; set; }

    public virtual DbSet<LnkUpmcW5010Iea> LnkUpmcW5010Ieas { get; set; }

    public virtual DbSet<LnkUpmcW5010Isa> LnkUpmcW5010Isas { get; set; }

    public virtual DbSet<LnkUpmcW5010N1payer> LnkUpmcW5010N1payers { get; set; }

    public virtual DbSet<LnkUpmcW5010N1sponser> LnkUpmcW5010N1sponsers { get; set; }

    public virtual DbSet<LnkUpmcW5010Se> LnkUpmcW5010Ses { get; set; }

    public virtual DbSet<LnkUpmcW5010St> LnkUpmcW5010Sts { get; set; }

    public virtual DbSet<LnkUpmcW834upmc0001> LnkUpmcW834upmc0001s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc0002> LnkUpmcW834upmc0002s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc0003> LnkUpmcW834upmc0003s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc0004> LnkUpmcW834upmc0004s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc1000> LnkUpmcW834upmc1000s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc1001> LnkUpmcW834upmc1001s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2000> LnkUpmcW834upmc2000s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2001> LnkUpmcW834upmc2001s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2006> LnkUpmcW834upmc2006s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2100> LnkUpmcW834upmc2100s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2101> LnkUpmcW834upmc2101s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2102> LnkUpmcW834upmc2102s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2103> LnkUpmcW834upmc2103s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2104> LnkUpmcW834upmc2104s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2300> LnkUpmcW834upmc2300s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2301> LnkUpmcW834upmc2301s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2302> LnkUpmcW834upmc2302s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc2303> LnkUpmcW834upmc2303s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc9991> LnkUpmcW834upmc9991s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc9992> LnkUpmcW834upmc9992s { get; set; }

    public virtual DbSet<LnkUpmcW834upmc9993> LnkUpmcW834upmc9993s { get; set; }

    public virtual DbSet<LnkV1gWAdp10001> LnkV1gWAdp10001s { get; set; }

    public virtual DbSet<LnkV1gWAdp10002> LnkV1gWAdp10002s { get; set; }

    public virtual DbSet<LnkV1gWAdp10003> LnkV1gWAdp10003s { get; set; }

    public virtual DbSet<LnkV1gWAdp10004> LnkV1gWAdp10004s { get; set; }

    public virtual DbSet<LnkV1gWAdp10005> LnkV1gWAdp10005s { get; set; }

    public virtual DbSet<LnkV1gWAdp10006> LnkV1gWAdp10006s { get; set; }

    public virtual DbSet<LnkV1gWAdp10007> LnkV1gWAdp10007s { get; set; }

    public virtual DbSet<LnkV1gWAdp10008> LnkV1gWAdp10008s { get; set; }

    public virtual DbSet<LnkV1gWAdp10008CrTableHold> LnkV1gWAdp10008CrTableHolds { get; set; }

    public virtual DbSet<LnkV1gWAdptime100027> LnkV1gWAdptime100027s { get; set; }

    public virtual DbSet<LnkV1gWAdptime100028> LnkV1gWAdptime100028s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10001> LnkV1gWhAdp10001s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10002> LnkV1gWhAdp10002s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10003> LnkV1gWhAdp10003s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10004> LnkV1gWhAdp10004s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10005> LnkV1gWhAdp10005s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10006> LnkV1gWhAdp10006s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10007> LnkV1gWhAdp10007s { get; set; }

    public virtual DbSet<LnkV1gWhAdp10008> LnkV1gWhAdp10008s { get; set; }

    public virtual DbSet<LnkVbaW> LnkVbaWs { get; set; }

    public virtual DbSet<LnkVbaW50102000Dmg> LnkVbaW50102000Dmgs { get; set; }

    public virtual DbSet<LnkVbaW50102000In> LnkVbaW50102000Ins { get; set; }

    public virtual DbSet<LnkVbaW50102000N3> LnkVbaW50102000N3s { get; set; }

    public virtual DbSet<LnkVbaW50102000N4> LnkVbaW50102000N4s { get; set; }

    public virtual DbSet<LnkVbaW50102000Nm1> LnkVbaW50102000Nm1s { get; set; }

    public virtual DbSet<LnkVbaW50102000Per> LnkVbaW50102000Pers { get; set; }

    public virtual DbSet<LnkVbaW50102000Ref0f> LnkVbaW50102000Ref0fs { get; set; }

    public virtual DbSet<LnkVbaW50102300Dtp348> LnkVbaW50102300Dtp348s { get; set; }

    public virtual DbSet<LnkVbaW50102300Dtp349> LnkVbaW50102300Dtp349s { get; set; }

    public virtual DbSet<LnkVbaW50102300Hd> LnkVbaW50102300Hds { get; set; }

    public virtual DbSet<LnkVbaW50102300Ref1l> LnkVbaW50102300Ref1ls { get; set; }

    public virtual DbSet<LnkVbaW5010Bgn> LnkVbaW5010Bgns { get; set; }

    public virtual DbSet<LnkVbaW5010Dtp007> LnkVbaW5010Dtp007s { get; set; }

    public virtual DbSet<LnkVbaW5010G> LnkVbaW5010Gs { get; set; }

    public virtual DbSet<LnkVbaW5010Ge> LnkVbaW5010Ges { get; set; }

    public virtual DbSet<LnkVbaW5010Iea> LnkVbaW5010Ieas { get; set; }

    public virtual DbSet<LnkVbaW5010Isa> LnkVbaW5010Isas { get; set; }

    public virtual DbSet<LnkVbaW5010N1payer> LnkVbaW5010N1payers { get; set; }

    public virtual DbSet<LnkVbaW5010N1sponser> LnkVbaW5010N1sponsers { get; set; }

    public virtual DbSet<LnkVbaW5010Se> LnkVbaW5010Ses { get; set; }

    public virtual DbSet<LnkVbaW5010St> LnkVbaW5010Sts { get; set; }

    public virtual DbSet<SalaryAllocation> SalaryAllocations { get; set; }

    public virtual DbSet<TAbsenceAdjustmentReason> TAbsenceAdjustmentReasons { get; set; }

    public virtual DbSet<TAbsencePlan> TAbsencePlans { get; set; }

    public virtual DbSet<TAbsencePlanDetailHist> TAbsencePlanDetailHists { get; set; }

    public virtual DbSet<TAbsencePlanRule> TAbsencePlanRules { get; set; }

    public virtual DbSet<TAbsencePlanRuleSetHist> TAbsencePlanRuleSetHists { get; set; }

    public virtual DbSet<TAbsencePlanType> TAbsencePlanTypes { get; set; }

    public virtual DbSet<TAbsencePointAdjustmentType> TAbsencePointAdjustmentTypes { get; set; }

    public virtual DbSet<TAbsencePointCorrectiveAction> TAbsencePointCorrectiveActions { get; set; }

    public virtual DbSet<TAbsencePointEvent> TAbsencePointEvents { get; set; }

    public virtual DbSet<TAbsencePointIncident> TAbsencePointIncidents { get; set; }

    public virtual DbSet<TAbsenceReason> TAbsenceReasons { get; set; }

    public virtual DbSet<TAbsenceRule> TAbsenceRules { get; set; }

    public virtual DbSet<TAbsenceRuleSet> TAbsenceRuleSets { get; set; }

    public virtual DbSet<TAbsenceRuleSetCommunicationRecipient> TAbsenceRuleSetCommunicationRecipients { get; set; }

    public virtual DbSet<TAbsenceRuleSetOwner> TAbsenceRuleSetOwners { get; set; }

    public virtual DbSet<TAbsenceRuleSetRule> TAbsenceRuleSetRules { get; set; }

    public virtual DbSet<TAddressType> TAddressTypes { get; set; }

    public virtual DbSet<TAlternateCompetency> TAlternateCompetencies { get; set; }

    public virtual DbSet<TApplicationAnswer> TApplicationAnswers { get; set; }

    public virtual DbSet<TApplicationAnswerType> TApplicationAnswerTypes { get; set; }

    public virtual DbSet<TApplicationQuestion> TApplicationQuestions { get; set; }

    public virtual DbSet<TApplicationStatus> TApplicationStatuses { get; set; }

    public virtual DbSet<TAttendance> TAttendances { get; set; }

    public virtual DbSet<TBargainingUnit> TBargainingUnits { get; set; }

    public virtual DbSet<TBasePayReason> TBasePayReasons { get; set; }

    public virtual DbSet<TBenefitCarrierHist> TBenefitCarrierHists { get; set; }

    public virtual DbSet<TBenefitEligibilityParameterHist> TBenefitEligibilityParameterHists { get; set; }

    public virtual DbSet<TBenefitEligibilityParameterHistCode> TBenefitEligibilityParameterHistCodes { get; set; }

    public virtual DbSet<TBenefitFutureEnrollmentPersonStatus> TBenefitFutureEnrollmentPersonStatuses { get; set; }

    public virtual DbSet<TBenefitFutureEnrollmentStatus> TBenefitFutureEnrollmentStatuses { get; set; }

    public virtual DbSet<TBenefitGroup> TBenefitGroups { get; set; }

    public virtual DbSet<TBenefitHist> TBenefitHists { get; set; }

    public virtual DbSet<TBenefitOpenEnrollmentGroup> TBenefitOpenEnrollmentGroups { get; set; }

    public virtual DbSet<TBenefitOpenEnrollmentGroupPlanOption> TBenefitOpenEnrollmentGroupPlanOptions { get; set; }

    public virtual DbSet<TBenefitOpenEnrollmentGroupStep> TBenefitOpenEnrollmentGroupSteps { get; set; }

    public virtual DbSet<TBenefitOpenEnrollmentGroupStepBenefitPlan> TBenefitOpenEnrollmentGroupStepBenefitPlans { get; set; }

    public virtual DbSet<TBenefitParametersHist> TBenefitParametersHists { get; set; }

    public virtual DbSet<TBenefitPlan> TBenefitPlans { get; set; }

    public virtual DbSet<TBenefitPlanAdministrator> TBenefitPlanAdministrators { get; set; }

    public virtual DbSet<TBenefitPlanOption> TBenefitPlanOptions { get; set; }

    public virtual DbSet<TBenefitPlanOptionAutoEnroll> TBenefitPlanOptionAutoEnrolls { get; set; }

    public virtual DbSet<TBenefitPlanTermination> TBenefitPlanTerminations { get; set; }

    public virtual DbSet<TBenefitRangeHist> TBenefitRangeHists { get; set; }

    public virtual DbSet<TBenefitRangeValue> TBenefitRangeValues { get; set; }

    public virtual DbSet<TBenefitStatementParameter> TBenefitStatementParameters { get; set; }

    public virtual DbSet<TBenefitStatus> TBenefitStatuses { get; set; }

    public virtual DbSet<TBenefitType> TBenefitTypes { get; set; }

    public virtual DbSet<TBenefitWaiveReason> TBenefitWaiveReasons { get; set; }

    public virtual DbSet<TBloodType> TBloodTypes { get; set; }

    public virtual DbSet<TBodyPart> TBodyParts { get; set; }

    public virtual DbSet<TCarrier> TCarriers { get; set; }

    public virtual DbSet<TCensusMetropolitanArea> TCensusMetropolitanAreas { get; set; }

    public virtual DbSet<TCertification> TCertifications { get; set; }

    public virtual DbSet<TCertificationType> TCertificationTypes { get; set; }

    public virtual DbSet<TClass> TClasses { get; set; }

    public virtual DbSet<TClassSchedule> TClassSchedules { get; set; }

    public virtual DbSet<TClassStatus> TClassStatuses { get; set; }

    public virtual DbSet<TClassTrainingMaterial> TClassTrainingMaterials { get; set; }

    public virtual DbSet<TClassTrainingResource> TClassTrainingResources { get; set; }

    public virtual DbSet<TCobraevent> TCobraevents { get; set; }

    public virtual DbSet<TCobraeventType> TCobraeventTypes { get; set; }

    public virtual DbSet<TCobrastatus> TCobrastatuses { get; set; }

    public virtual DbSet<TCompany> TCompanies { get; set; }

    public virtual DbSet<TCompetency> TCompetencies { get; set; }

    public virtual DbSet<TCompetencyCategory> TCompetencyCategories { get; set; }

    public virtual DbSet<TCompetencyCluster> TCompetencyClusters { get; set; }

    public virtual DbSet<TCorporateGoal> TCorporateGoals { get; set; }

    public virtual DbSet<TCostCenter> TCostCenters { get; set; }

    public virtual DbSet<TCountry> TCountries { get; set; }

    public virtual DbSet<TCourse> TCourses { get; set; }

    public virtual DbSet<TCourseCertification> TCourseCertifications { get; set; }

    public virtual DbSet<TCourseCompetency> TCourseCompetencies { get; set; }

    public virtual DbSet<TCourseCourse> TCourseCourses { get; set; }

    public virtual DbSet<TCourseLanguage> TCourseLanguages { get; set; }

    public virtual DbSet<TCourseTrainingMaterial> TCourseTrainingMaterials { get; set; }

    public virtual DbSet<TCourseTrainingResource> TCourseTrainingResources { get; set; }

    public virtual DbSet<TCourseType> TCourseTypes { get; set; }

    public virtual DbSet<TCurrency> TCurrencies { get; set; }

    public virtual DbSet<TCurrencyConversion> TCurrencyConversions { get; set; }

    public virtual DbSet<TCustom1> TCustom1s { get; set; }

    public virtual DbSet<TCustom11> TCustom11s { get; set; }

    public virtual DbSet<TCustom12> TCustom12s { get; set; }

    public virtual DbSet<TCustom13> TCustom13s { get; set; }

    public virtual DbSet<TCustom14> TCustom14s { get; set; }

    public virtual DbSet<TCustom2> TCustom2s { get; set; }

    public virtual DbSet<TCustom3> TCustom3s { get; set; }

    public virtual DbSet<TCustom4> TCustom4s { get; set; }

    public virtual DbSet<TDegree> TDegrees { get; set; }

    public virtual DbSet<TDeliveryMethod> TDeliveryMethods { get; set; }

    public virtual DbSet<TDepartment> TDepartments { get; set; }

    public virtual DbSet<TDepartureReason> TDepartureReasons { get; set; }

    public virtual DbSet<TDependent834Type> TDependent834Types { get; set; }

    public virtual DbSet<TDependentType> TDependentTypes { get; set; }

    public virtual DbSet<TDependentTypeRelationship> TDependentTypeRelationships { get; set; }

    public virtual DbSet<TDirectDepositAccountType> TDirectDepositAccountTypes { get; set; }

    public virtual DbSet<TDisability> TDisabilities { get; set; }

    public virtual DbSet<TDisciplineAction> TDisciplineActions { get; set; }

    public virtual DbSet<TDisciplinePrimaryPolicy> TDisciplinePrimaryPolicies { get; set; }

    public virtual DbSet<TDisciplineReason> TDisciplineReasons { get; set; }

    public virtual DbSet<TDisciplineType> TDisciplineTypes { get; set; }

    public virtual DbSet<TDivision> TDivisions { get; set; }

    public virtual DbSet<TDriverStatus> TDriverStatuses { get; set; }

    public virtual DbSet<TDrugTestReason> TDrugTestReasons { get; set; }

    public virtual DbSet<TDrugTestResult> TDrugTestResults { get; set; }

    public virtual DbSet<TDrugTestType> TDrugTestTypes { get; set; }

    public virtual DbSet<TEducationStatus> TEducationStatuses { get; set; }

    public virtual DbSet<TEeacategory> TEeacategories { get; set; }

    public virtual DbSet<TEeocategory> TEeocategories { get; set; }

    public virtual DbSet<TEmploymentContract> TEmploymentContracts { get; set; }

    public virtual DbSet<TEmploymentDocument> TEmploymentDocuments { get; set; }

    public virtual DbSet<TEthnicGroup> TEthnicGroups { get; set; }

    public virtual DbSet<TEvaluationResult> TEvaluationResults { get; set; }

    public virtual DbSet<TEvaluationType> TEvaluationTypes { get; set; }

    public virtual DbSet<TEvaluator> TEvaluators { get; set; }

    public virtual DbSet<TEventType> TEventTypes { get; set; }

    public virtual DbSet<TExpenseType> TExpenseTypes { get; set; }

    public virtual DbSet<TExportTriggerAction> TExportTriggerActions { get; set; }

    public virtual DbSet<TExportTriggerStatus> TExportTriggerStatuses { get; set; }

    public virtual DbSet<TExternalRecruiter> TExternalRecruiters { get; set; }

    public virtual DbSet<TFacility> TFacilities { get; set; }

    public virtual DbSet<TFamilyStatus> TFamilyStatuses { get; set; }

    public virtual DbSet<TFileAttachmentType> TFileAttachmentTypes { get; set; }

    public virtual DbSet<TFormType> TFormTypes { get; set; }

    public virtual DbSet<TFrequency> TFrequencies { get; set; }

    public virtual DbSet<TFrequencyConversion> TFrequencyConversions { get; set; }

    public virtual DbSet<TFunctionalArea> TFunctionalAreas { get; set; }

    public virtual DbSet<TFundingSource> TFundingSources { get; set; }

    public virtual DbSet<TGender> TGenders { get; set; }

    public virtual DbSet<TGeographicArea> TGeographicAreas { get; set; }

    public virtual DbSet<TGoalObjective> TGoalObjectives { get; set; }

    public virtual DbSet<TGoalType> TGoalTypes { get; set; }

    public virtual DbSet<TGovFormAdditionalFile> TGovFormAdditionalFiles { get; set; }

    public virtual DbSet<TGradeHist> TGradeHists { get; set; }

    public virtual DbSet<THealthAndSafetyChecklist> THealthAndSafetyChecklists { get; set; }

    public virtual DbSet<THealthAndSafetyChecklistDetail> THealthAndSafetyChecklistDetails { get; set; }

    public virtual DbSet<THealthAndSafetyChecklistQuestion> THealthAndSafetyChecklistQuestions { get; set; }

    public virtual DbSet<THealthAndSafetyChecklistQuestionCategory> THealthAndSafetyChecklistQuestionCategories { get; set; }

    public virtual DbSet<THireSource> THireSources { get; set; }

    public virtual DbSet<THoliday> THolidays { get; set; }

    public virtual DbSet<THolidayOccurrence> THolidayOccurrences { get; set; }

    public virtual DbSet<THowAcquired> THowAcquireds { get; set; }

    public virtual DbSet<TIllnessInjury> TIllnessInjuries { get; set; }

    public virtual DbSet<TIllnessInjuryStatus> TIllnessInjuryStatuses { get; set; }

    public virtual DbSet<TIllnessType> TIllnessTypes { get; set; }

    public virtual DbSet<TIncident> TIncidents { get; set; }

    public virtual DbSet<TIncidentType> TIncidentTypes { get; set; }

    public virtual DbSet<TIndustrySector> TIndustrySectors { get; set; }

    public virtual DbSet<TInstructor> TInstructors { get; set; }

    public virtual DbSet<TInternationalType> TInternationalTypes { get; set; }

    public virtual DbSet<TJob> TJobs { get; set; }

    public virtual DbSet<TJobCategory> TJobCategories { get; set; }

    public virtual DbSet<TJobCertification> TJobCertifications { get; set; }

    public virtual DbSet<TJobCompetency> TJobCompetencies { get; set; }

    public virtual DbSet<TJobCourse> TJobCourses { get; set; }

    public virtual DbSet<TJobDescription> TJobDescriptions { get; set; }

    public virtual DbSet<TJobFamily> TJobFamilies { get; set; }

    public virtual DbSet<TJobGroup> TJobGroups { get; set; }

    public virtual DbSet<TJobLanguage> TJobLanguages { get; set; }

    public virtual DbSet<TJobReason> TJobReasons { get; set; }

    public virtual DbSet<TJobTrainingProgram> TJobTrainingPrograms { get; set; }

    public virtual DbSet<TLanguage> TLanguages { get; set; }

    public virtual DbSet<TLanguageProficiency> TLanguageProficiencies { get; set; }

    public virtual DbSet<TLeaveReason> TLeaveReasons { get; set; }

    public virtual DbSet<TLeaveType> TLeaveTypes { get; set; }

    public virtual DbSet<TLifeEventStatus> TLifeEventStatuses { get; set; }

    public virtual DbSet<TLifeEventType> TLifeEventTypes { get; set; }

    public virtual DbSet<TLocation> TLocations { get; set; }

    public virtual DbSet<TLocationReason> TLocationReasons { get; set; }

    public virtual DbSet<TMajor> TMajors { get; set; }

    public virtual DbSet<TMassChange> TMassChanges { get; set; }

    public virtual DbSet<TMassChangeField> TMassChangeFields { get; set; }

    public virtual DbSet<TMassChangeOperation> TMassChangeOperations { get; set; }

    public virtual DbSet<TMassChangeReason> TMassChangeReasons { get; set; }

    public virtual DbSet<TMedicalFacility> TMedicalFacilities { get; set; }

    public virtual DbSet<TMilitaryBranch> TMilitaryBranches { get; set; }

    public virtual DbSet<TMilitaryConflict> TMilitaryConflicts { get; set; }

    public virtual DbSet<TMilitaryStatus> TMilitaryStatuses { get; set; }

    public virtual DbSet<TMobilityStatus> TMobilityStatuses { get; set; }

    public virtual DbSet<TNameType> TNameTypes { get; set; }

    public virtual DbSet<TNominationQuestion> TNominationQuestions { get; set; }

    public virtual DbSet<TNominationQuestionSection> TNominationQuestionSections { get; set; }

    public virtual DbSet<TNoteType> TNoteTypes { get; set; }

    public virtual DbSet<TNoticePeriodEmployerIndicator> TNoticePeriodEmployerIndicators { get; set; }

    public virtual DbSet<TOccupationalIllnessCategory> TOccupationalIllnessCategories { get; set; }

    public virtual DbSet<TOccupationalIncidentType> TOccupationalIncidentTypes { get; set; }

    public virtual DbSet<TOfferType> TOfferTypes { get; set; }

    public virtual DbSet<TOrgPublisherPositionType> TOrgPublisherPositionTypes { get; set; }

    public virtual DbSet<TOrganizationUnit> TOrganizationUnits { get; set; }

    public virtual DbSet<TOrganizationUnitLevel> TOrganizationUnitLevels { get; set; }

    public virtual DbSet<TOtherPayReason> TOtherPayReasons { get; set; }

    public virtual DbSet<TOtherPayType> TOtherPayTypes { get; set; }

    public virtual DbSet<TOvertimeRule> TOvertimeRules { get; set; }

    public virtual DbSet<TOvertimeRuleDetail> TOvertimeRuleDetails { get; set; }

    public virtual DbSet<TOvertimeStatus> TOvertimeStatuses { get; set; }

    public virtual DbSet<TPayStub> TPayStubs { get; set; }

    public virtual DbSet<TPayStubLayout> TPayStubLayouts { get; set; }

    public virtual DbSet<TPayStubNote> TPayStubNotes { get; set; }

    public virtual DbSet<TPayroll> TPayrolls { get; set; }

    public virtual DbSet<TPayrollAccumulator> TPayrollAccumulators { get; set; }

    public virtual DbSet<TPayrollAccumulatorRollup> TPayrollAccumulatorRollups { get; set; }

    public virtual DbSet<TPayrollVendorAccumulatorFrequency> TPayrollVendorAccumulatorFrequencies { get; set; }

    public virtual DbSet<TPayrollVendorAccumulatorType> TPayrollVendorAccumulatorTypes { get; set; }

    public virtual DbSet<TPayrollVendorCompany> TPayrollVendorCompanies { get; set; }

    public virtual DbSet<TPayrollVendorCompanyAccumulator> TPayrollVendorCompanyAccumulators { get; set; }

    public virtual DbSet<TPerformanceAssessment> TPerformanceAssessments { get; set; }

    public virtual DbSet<TPerformanceAssessmentType> TPerformanceAssessmentTypes { get; set; }

    public virtual DbSet<TPerformanceParticipant> TPerformanceParticipants { get; set; }

    public virtual DbSet<TPerformanceParticipantRuleType> TPerformanceParticipantRuleTypes { get; set; }

    public virtual DbSet<TPerformanceParticipantType> TPerformanceParticipantTypes { get; set; }

    public virtual DbSet<TPerformanceQuestion> TPerformanceQuestions { get; set; }

    public virtual DbSet<TPerformanceQuestionGroup> TPerformanceQuestionGroups { get; set; }

    public virtual DbSet<TPerformanceQuestionJob> TPerformanceQuestionJobs { get; set; }

    public virtual DbSet<TPerformanceQuestionJournalType> TPerformanceQuestionJournalTypes { get; set; }

    public virtual DbSet<TPerformanceQuestionParticipant> TPerformanceQuestionParticipants { get; set; }

    public virtual DbSet<TPerformanceQuestionPosition> TPerformanceQuestionPositions { get; set; }

    public virtual DbSet<TPerformanceQuestionReviewType> TPerformanceQuestionReviewTypes { get; set; }

    public virtual DbSet<TPerformanceRating> TPerformanceRatings { get; set; }

    public virtual DbSet<TPerformanceReviewType> TPerformanceReviewTypes { get; set; }

    public virtual DbSet<TPerson> TPeople { get; set; }

    public virtual DbSet<TPerson9BoxHist> TPerson9BoxHists { get; set; }

    public virtual DbSet<TPersonAbsenceEligibility> TPersonAbsenceEligibilities { get; set; }

    public virtual DbSet<TPersonAbsenceHist> TPersonAbsenceHists { get; set; }

    public virtual DbSet<TPersonAbsenceHistErp> TPersonAbsenceHistErps { get; set; }

    public virtual DbSet<TPersonAbsenceHistFile> TPersonAbsenceHistFiles { get; set; }

    public virtual DbSet<TPersonAbsenceOverrideHist> TPersonAbsenceOverrideHists { get; set; }

    public virtual DbSet<TPersonAbsencePlan> TPersonAbsencePlans { get; set; }

    public virtual DbSet<TPersonAbsencePoint> TPersonAbsencePoints { get; set; }

    public virtual DbSet<TPersonAchievement> TPersonAchievements { get; set; }

    public virtual DbSet<TPersonAddress> TPersonAddresses { get; set; }

    public virtual DbSet<TPersonApplication> TPersonApplications { get; set; }

    public virtual DbSet<TPersonApplicationAnswer> TPersonApplicationAnswers { get; set; }

    public virtual DbSet<TPersonApplicationCommunication> TPersonApplicationCommunications { get; set; }

    public virtual DbSet<TPersonApplicationEvaluation> TPersonApplicationEvaluations { get; set; }

    public virtual DbSet<TPersonApplicationFile> TPersonApplicationFiles { get; set; }

    public virtual DbSet<TPersonApplicationOffer> TPersonApplicationOffers { get; set; }

    public virtual DbSet<TPersonApplicationStatusHist> TPersonApplicationStatusHists { get; set; }

    public virtual DbSet<TPersonAward> TPersonAwards { get; set; }

    public virtual DbSet<TPersonBasePayHist> TPersonBasePayHists { get; set; }

    public virtual DbSet<TPersonBenefitBeneficiaryHist> TPersonBenefitBeneficiaryHists { get; set; }

    public virtual DbSet<TPersonBenefitClaim> TPersonBenefitClaims { get; set; }

    public virtual DbSet<TPersonBenefitCobrapayment> TPersonBenefitCobrapayments { get; set; }

    public virtual DbSet<TPersonBenefitContributionHist> TPersonBenefitContributionHists { get; set; }

    public virtual DbSet<TPersonBenefitGroupHist> TPersonBenefitGroupHists { get; set; }

    public virtual DbSet<TPersonBenefitHist> TPersonBenefitHists { get; set; }

    public virtual DbSet<TPersonBenefitOffer> TPersonBenefitOffers { get; set; }

    public virtual DbSet<TPersonBenefitOptOut> TPersonBenefitOptOuts { get; set; }

    public virtual DbSet<TPersonCertification> TPersonCertifications { get; set; }

    public virtual DbSet<TPersonCobra> TPersonCobras { get; set; }

    public virtual DbSet<TPersonCommunityActivity> TPersonCommunityActivities { get; set; }

    public virtual DbSet<TPersonCompetencyHist> TPersonCompetencyHists { get; set; }

    public virtual DbSet<TPersonCustomBase> TPersonCustomBases { get; set; }

    public virtual DbSet<TPersonCustomHist> TPersonCustomHists { get; set; }

    public virtual DbSet<TPersonDependent> TPersonDependents { get; set; }

    public virtual DbSet<TPersonDirectDeposit> TPersonDirectDeposits { get; set; }

    public virtual DbSet<TPersonDiscipline> TPersonDisciplines { get; set; }

    public virtual DbSet<TPersonDrugTest> TPersonDrugTests { get; set; }

    public virtual DbSet<TPersonEducationHist> TPersonEducationHists { get; set; }

    public virtual DbSet<TPersonEmergency> TPersonEmergencies { get; set; }

    public virtual DbSet<TPersonEmploymentDocument> TPersonEmploymentDocuments { get; set; }

    public virtual DbSet<TPersonEmploymentHist> TPersonEmploymentHists { get; set; }

    public virtual DbSet<TPersonErp> TPersonErps { get; set; }

    public virtual DbSet<TPersonFile> TPersonFiles { get; set; }

    public virtual DbSet<TPersonFmlaadjustment> TPersonFmlaadjustments { get; set; }

    public virtual DbSet<TPersonForwardedApplication> TPersonForwardedApplications { get; set; }

    public virtual DbSet<TPersonFutureEnrollment> TPersonFutureEnrollments { get; set; }

    public virtual DbSet<TPersonFutureEnrollmentBeneficiary> TPersonFutureEnrollmentBeneficiaries { get; set; }

    public virtual DbSet<TPersonFutureEnrollmentStatus> TPersonFutureEnrollmentStatuses { get; set; }

    public virtual DbSet<TPersonGoal> TPersonGoals { get; set; }

    public virtual DbSet<TPersonGovFormHist> TPersonGovFormHists { get; set; }

    public virtual DbSet<TPersonI9> TPersonI9s { get; set; }

    public virtual DbSet<TPersonI9file> TPersonI9files { get; set; }

    public virtual DbSet<TPersonIncident> TPersonIncidents { get; set; }

    public virtual DbSet<TPersonIncidentBodyPart> TPersonIncidentBodyParts { get; set; }

    public virtual DbSet<TPersonIncidentLostTimeHist> TPersonIncidentLostTimeHists { get; set; }

    public virtual DbSet<TPersonIncidentRestrictedTimeHist> TPersonIncidentRestrictedTimeHists { get; set; }

    public virtual DbSet<TPersonIncidentTreatment> TPersonIncidentTreatments { get; set; }

    public virtual DbSet<TPersonJobHist> TPersonJobHists { get; set; }

    public virtual DbSet<TPersonLanguage> TPersonLanguages { get; set; }

    public virtual DbSet<TPersonLeaveRequest> TPersonLeaveRequests { get; set; }

    public virtual DbSet<TPersonLeaveRequestDesignation> TPersonLeaveRequestDesignations { get; set; }

    public virtual DbSet<TPersonLeaveRequestDesignationFile> TPersonLeaveRequestDesignationFiles { get; set; }

    public virtual DbSet<TPersonLeaveRequestEligibility> TPersonLeaveRequestEligibilities { get; set; }

    public virtual DbSet<TPersonLeaveRequestEligibilityFile> TPersonLeaveRequestEligibilityFiles { get; set; }

    public virtual DbSet<TPersonLifeEvent> TPersonLifeEvents { get; set; }

    public virtual DbSet<TPersonLocationHist> TPersonLocationHists { get; set; }

    public virtual DbSet<TPersonMedical> TPersonMedicals { get; set; }

    public virtual DbSet<TPersonMilitaryHist> TPersonMilitaryHists { get; set; }

    public virtual DbSet<TPersonNationalId> TPersonNationalIds { get; set; }

    public virtual DbSet<TPersonNomination> TPersonNominations { get; set; }

    public virtual DbSet<TPersonNominationQuestion> TPersonNominationQuestions { get; set; }

    public virtual DbSet<TPersonNominationQuestionSection> TPersonNominationQuestionSections { get; set; }

    public virtual DbSet<TPersonNote> TPersonNotes { get; set; }

    public virtual DbSet<TPersonOtherName> TPersonOtherNames { get; set; }

    public virtual DbSet<TPersonOtherPayHist> TPersonOtherPayHists { get; set; }

    public virtual DbSet<TPersonOvertimeHist> TPersonOvertimeHists { get; set; }

    public virtual DbSet<TPersonPassport> TPersonPassports { get; set; }

    public virtual DbSet<TPersonPayStubArchive> TPersonPayStubArchives { get; set; }

    public virtual DbSet<TPersonPerformanceHist> TPersonPerformanceHists { get; set; }

    public virtual DbSet<TPersonPerformanceOverallComment> TPersonPerformanceOverallComments { get; set; }

    public virtual DbSet<TPersonPerformanceParticipant> TPersonPerformanceParticipants { get; set; }

    public virtual DbSet<TPersonPerformanceQuestion> TPersonPerformanceQuestions { get; set; }

    public virtual DbSet<TPersonPerformanceQuestionAnswer> TPersonPerformanceQuestionAnswers { get; set; }

    public virtual DbSet<TPersonPerformanceQuestionAnswerJournal> TPersonPerformanceQuestionAnswerJournals { get; set; }

    public virtual DbSet<TPersonPhone> TPersonPhones { get; set; }

    public virtual DbSet<TPersonProfessionalAffiliation> TPersonProfessionalAffiliations { get; set; }

    public virtual DbSet<TPersonProjectHist> TPersonProjectHists { get; set; }

    public virtual DbSet<TPersonPropertyCardHist> TPersonPropertyCardHists { get; set; }

    public virtual DbSet<TPersonPropertyHist> TPersonPropertyHists { get; set; }

    public virtual DbSet<TPersonPublishedWork> TPersonPublishedWorks { get; set; }

    public virtual DbSet<TPersonReference> TPersonReferences { get; set; }

    public virtual DbSet<TPersonScheduleDate> TPersonScheduleDates { get; set; }

    public virtual DbSet<TPersonSocialNetwork> TPersonSocialNetworks { get; set; }

    public virtual DbSet<TPersonSpeakingEngagement> TPersonSpeakingEngagements { get; set; }

    public virtual DbSet<TPersonSpecialAccommodation> TPersonSpecialAccommodations { get; set; }

    public virtual DbSet<TPersonStatusHist> TPersonStatusHists { get; set; }

    public virtual DbSet<TPersonTax> TPersonTaxes { get; set; }

    public virtual DbSet<TPersonTermination> TPersonTerminations { get; set; }

    public virtual DbSet<TPersonTimeDetail> TPersonTimeDetails { get; set; }

    public virtual DbSet<TPersonTimeDetailErp> TPersonTimeDetailErps { get; set; }

    public virtual DbSet<TPersonTimeGroupHist> TPersonTimeGroupHists { get; set; }

    public virtual DbSet<TPersonTimeGroupPeriod> TPersonTimeGroupPeriods { get; set; }

    public virtual DbSet<TPersonTimeGroupPeriodOvertime> TPersonTimeGroupPeriodOvertimes { get; set; }

    public virtual DbSet<TPersonTraining> TPersonTrainings { get; set; }

    public virtual DbSet<TPersonTrainingExpense> TPersonTrainingExpenses { get; set; }

    public virtual DbSet<TPersonTrainingProgram> TPersonTrainingPrograms { get; set; }

    public virtual DbSet<TPersonUnionHist> TPersonUnionHists { get; set; }

    public virtual DbSet<TPersonVeteran> TPersonVeterans { get; set; }

    public virtual DbSet<TPersonVisa> TPersonVisas { get; set; }

    public virtual DbSet<TPersonW2> TPersonW2s { get; set; }

    public virtual DbSet<TPersonWaitList> TPersonWaitLists { get; set; }

    public virtual DbSet<TPersonWorkEligibility> TPersonWorkEligibilities { get; set; }

    public virtual DbSet<TPersonWorkEligibilityFile> TPersonWorkEligibilityFiles { get; set; }

    public virtual DbSet<TPersonWorksCouncilHist> TPersonWorksCouncilHists { get; set; }

    public virtual DbSet<TPersonYearToDateEarning> TPersonYearToDateEarnings { get; set; }

    public virtual DbSet<TPersonal> TPersonals { get; set; }

    public virtual DbSet<TPhoneType> TPhoneTypes { get; set; }

    public virtual DbSet<TPhysician> TPhysicians { get; set; }

    public virtual DbSet<TPhysicianType> TPhysicianTypes { get; set; }

    public virtual DbSet<TPosition> TPositions { get; set; }

    public virtual DbSet<TPositionBudgetHist> TPositionBudgetHists { get; set; }

    public virtual DbSet<TPositionFundingHist> TPositionFundingHists { get; set; }

    public virtual DbSet<TPositionHist> TPositionHists { get; set; }

    public virtual DbSet<TPositionStatus> TPositionStatuses { get; set; }

    public virtual DbSet<TPrimaryPolicy> TPrimaryPolicies { get; set; }

    public virtual DbSet<TProfessionalLevel> TProfessionalLevels { get; set; }

    public virtual DbSet<TProficiency> TProficiencies { get; set; }

    public virtual DbSet<TProject> TProjects { get; set; }

    public virtual DbSet<TProperty> TProperties { get; set; }

    public virtual DbSet<TPropertyCardType> TPropertyCardTypes { get; set; }

    public virtual DbSet<TPropertyReason> TPropertyReasons { get; set; }

    public virtual DbSet<TPropertyType> TPropertyTypes { get; set; }

    public virtual DbSet<TPublishedWorkType> TPublishedWorkTypes { get; set; }

    public virtual DbSet<TRecruitingAgreement> TRecruitingAgreements { get; set; }

    public virtual DbSet<TRecruitingAgreementType> TRecruitingAgreementTypes { get; set; }

    public virtual DbSet<TRecruitingExpense> TRecruitingExpenses { get; set; }

    public virtual DbSet<TRecruitingExpenseAllocation> TRecruitingExpenseAllocations { get; set; }

    public virtual DbSet<TRecruitingExpenseCategory> TRecruitingExpenseCategories { get; set; }

    public virtual DbSet<TRecruitingFirm> TRecruitingFirms { get; set; }

    public virtual DbSet<TRecruitingSpecialty> TRecruitingSpecialties { get; set; }

    public virtual DbSet<TReferralSource> TReferralSources { get; set; }

    public virtual DbSet<TRegion> TRegions { get; set; }

    public virtual DbSet<TRelationship> TRelationships { get; set; }

    public virtual DbSet<TRequisition> TRequisitions { get; set; }

    public virtual DbSet<TRequisitionEmployeesHired> TRequisitionEmployeesHireds { get; set; }

    public virtual DbSet<TRequisitionEmployeesReplaced> TRequisitionEmployeesReplaceds { get; set; }

    public virtual DbSet<TRequisitionJobDescriptionHist> TRequisitionJobDescriptionHists { get; set; }

    public virtual DbSet<TScale> TScales { get; set; }

    public virtual DbSet<TSchedule> TSchedules { get; set; }

    public virtual DbSet<TScheduleType> TScheduleTypes { get; set; }

    public virtual DbSet<TSection> TSections { get; set; }

    public virtual DbSet<TShift> TShifts { get; set; }

    public virtual DbSet<TSignatureQuestion> TSignatureQuestions { get; set; }

    public virtual DbSet<TSocialNetworkType> TSocialNetworkTypes { get; set; }

    public virtual DbSet<TStateProvince> TStateProvinces { get; set; }

    public virtual DbSet<TStatus> TStatuses { get; set; }

    public virtual DbSet<TStatusCategory> TStatusCategories { get; set; }

    public virtual DbSet<TStatusGroup> TStatusGroups { get; set; }

    public virtual DbSet<TStatusReason> TStatusReasons { get; set; }

    public virtual DbSet<TSuisditax> TSuisditaxes { get; set; }

    public virtual DbSet<TSurvey> TSurveys { get; set; }

    public virtual DbSet<TSurveyCompanySize> TSurveyCompanySizes { get; set; }

    public virtual DbSet<TSurveyDatum> TSurveyData { get; set; }

    public virtual DbSet<TSurveyFilterSet> TSurveyFilterSets { get; set; }

    public virtual DbSet<TSurveyFilterSetCompanySize> TSurveyFilterSetCompanySizes { get; set; }

    public virtual DbSet<TSurveyFilterSetGeographicArea> TSurveyFilterSetGeographicAreas { get; set; }

    public virtual DbSet<TSurveyFilterSetGrade> TSurveyFilterSetGrades { get; set; }

    public virtual DbSet<TSurveyFilterSetIndustrySector> TSurveyFilterSetIndustrySectors { get; set; }

    public virtual DbSet<TSurveyFilterSetJob> TSurveyFilterSetJobs { get; set; }

    public virtual DbSet<TSurveyFilterSetJobFamily> TSurveyFilterSetJobFamilies { get; set; }

    public virtual DbSet<TSurveyFilterSetSurveySource> TSurveyFilterSetSurveySources { get; set; }

    public virtual DbSet<TSurveySource> TSurveySources { get; set; }

    public virtual DbSet<TTerminationReason> TTerminationReasons { get; set; }

    public virtual DbSet<TTerminationType> TTerminationTypes { get; set; }

    public virtual DbSet<TTimeGroup> TTimeGroups { get; set; }

    public virtual DbSet<TTimeGroupHoliday> TTimeGroupHolidays { get; set; }

    public virtual DbSet<TTimeGroupPeriod> TTimeGroupPeriods { get; set; }

    public virtual DbSet<TTimeGroupTimeType> TTimeGroupTimeTypes { get; set; }

    public virtual DbSet<TTimeType> TTimeTypes { get; set; }

    public virtual DbSet<TTimeZone> TTimeZones { get; set; }

    public virtual DbSet<TTrainingCompletion> TTrainingCompletions { get; set; }

    public virtual DbSet<TTrainingMaterial> TTrainingMaterials { get; set; }

    public virtual DbSet<TTrainingProgram> TTrainingPrograms { get; set; }

    public virtual DbSet<TTrainingProgramCertification> TTrainingProgramCertifications { get; set; }

    public virtual DbSet<TTrainingProgramCompetency> TTrainingProgramCompetencies { get; set; }

    public virtual DbSet<TTrainingProgramGroup> TTrainingProgramGroups { get; set; }

    public virtual DbSet<TTrainingProgramGroupCourse> TTrainingProgramGroupCourses { get; set; }

    public virtual DbSet<TTrainingProgramLanguage> TTrainingProgramLanguages { get; set; }

    public virtual DbSet<TTrainingProgramTrainingProgram> TTrainingProgramTrainingPrograms { get; set; }

    public virtual DbSet<TTrainingProvider> TTrainingProviders { get; set; }

    public virtual DbSet<TTrainingResource> TTrainingResources { get; set; }

    public virtual DbSet<TTransmitter> TTransmitters { get; set; }

    public virtual DbSet<TUnion> TUnions { get; set; }

    public virtual DbSet<TVendor> TVendors { get; set; }

    public virtual DbSet<TVendorUserField> TVendorUserFields { get; set; }

    public virtual DbSet<TVeteran> TVeterans { get; set; }

    public virtual DbSet<TVisaType> TVisaTypes { get; set; }

    public virtual DbSet<TWesleyCalendar> TWesleyCalendars { get; set; }

    public virtual DbSet<TWorkEligibilityDocumentType> TWorkEligibilityDocumentTypes { get; set; }

    public virtual DbSet<TWorkersCompensation> TWorkersCompensations { get; set; }

    public virtual DbSet<TWorkersCompensationCategory> TWorkersCompensationCategories { get; set; }

    public virtual DbSet<TWorkersCompensationRate> TWorkersCompensationRates { get; set; }

    public virtual DbSet<TWorksCouncil> TWorksCouncils { get; set; }

    public virtual DbSet<TWorksCouncilRole> TWorksCouncilRoles { get; set; }

    public virtual DbSet<TWsPersonExportDatum> TWsPersonExportData { get; set; }

    public virtual DbSet<UsysAbsenceTransactionType> UsysAbsenceTransactionTypes { get; set; }

    public virtual DbSet<UsysAcareportParameter> UsysAcareportParameters { get; set; }

    public virtual DbSet<UsysAlert> UsysAlerts { get; set; }

    public virtual DbSet<UsysAlertInstance> UsysAlertInstances { get; set; }

    public virtual DbSet<UsysAlertRecipient> UsysAlertRecipients { get; set; }

    public virtual DbSet<UsysAlertSchedule> UsysAlertSchedules { get; set; }

    public virtual DbSet<UsysAlertScheduleRecipient> UsysAlertScheduleRecipients { get; set; }

    public virtual DbSet<UsysAnnouncement> UsysAnnouncements { get; set; }

    public virtual DbSet<UsysArchiveTable> UsysArchiveTables { get; set; }

    public virtual DbSet<UsysAttachmentColumn> UsysAttachmentColumns { get; set; }

    public virtual DbSet<UsysAudit> UsysAudits { get; set; }

    public virtual DbSet<UsysAuditRecord> UsysAuditRecords { get; set; }

    public virtual DbSet<UsysBatchJob> UsysBatchJobs { get; set; }

    public virtual DbSet<UsysBatchJobLog> UsysBatchJobLogs { get; set; }

    public virtual DbSet<UsysBenefitEnrollment> UsysBenefitEnrollments { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentContribution> UsysBenefitEnrollmentContributions { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentContributionFailed> UsysBenefitEnrollmentContributionFaileds { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentDependent> UsysBenefitEnrollmentDependents { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentEligibility> UsysBenefitEnrollmentEligibilities { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentFailed> UsysBenefitEnrollmentFaileds { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentPerson> UsysBenefitEnrollmentPeople { get; set; }

    public virtual DbSet<UsysBenefitEnrollmentPlanOption> UsysBenefitEnrollmentPlanOptions { get; set; }

    public virtual DbSet<UsysBusinessObjectFunction> UsysBusinessObjectFunctions { get; set; }

    public virtual DbSet<UsysChecklist> UsysChecklists { get; set; }

    public virtual DbSet<UsysChecklistInstance> UsysChecklistInstances { get; set; }

    public virtual DbSet<UsysChecklistInstanceStep> UsysChecklistInstanceSteps { get; set; }

    public virtual DbSet<UsysChecklistStep> UsysChecklistSteps { get; set; }

    public virtual DbSet<UsysCodeFilterDetail> UsysCodeFilterDetails { get; set; }

    public virtual DbSet<UsysCodeFilterGroup> UsysCodeFilterGroups { get; set; }

    public virtual DbSet<UsysCodeFilterTable> UsysCodeFilterTables { get; set; }

    public virtual DbSet<UsysCodeTable> UsysCodeTables { get; set; }

    public virtual DbSet<UsysColumnTranslation> UsysColumnTranslations { get; set; }

    public virtual DbSet<UsysCommunicationTemplate> UsysCommunicationTemplates { get; set; }

    public virtual DbSet<UsysCounterValue> UsysCounterValues { get; set; }

    public virtual DbSet<UsysCountryFormat> UsysCountryFormats { get; set; }

    public virtual DbSet<UsysCsf> UsysCsfs { get; set; }

    public virtual DbSet<UsysCsfcountry> UsysCsfcountries { get; set; }

    public virtual DbSet<UsysCsfentity> UsysCsfentities { get; set; }

    public virtual DbSet<UsysCsffield> UsysCsffields { get; set; }

    public virtual DbSet<UsysCsflocation> UsysCsflocations { get; set; }

    public virtual DbSet<UsysCsfmoduleDefinition> UsysCsfmoduleDefinitions { get; set; }

    public virtual DbSet<UsysCsfstateProvince> UsysCsfstateProvinces { get; set; }

    public virtual DbSet<UsysCsfuser> UsysCsfusers { get; set; }

    public virtual DbSet<UsysDataDictionary> UsysDataDictionaries { get; set; }

    public virtual DbSet<UsysDatabaseChange> UsysDatabaseChanges { get; set; }

    public virtual DbSet<UsysDraft> UsysDrafts { get; set; }

    public virtual DbSet<UsysEeocategory> UsysEeocategories { get; set; }

    public virtual DbSet<UsysEmailLog> UsysEmailLogs { get; set; }

    public virtual DbSet<UsysEmailProfile> UsysEmailProfiles { get; set; }

    public virtual DbSet<UsysEntity> UsysEntities { get; set; }

    public virtual DbSet<UsysEntityGroup> UsysEntityGroups { get; set; }

    public virtual DbSet<UsysFlag> UsysFlags { get; set; }

    public virtual DbSet<UsysFmlaLeaveFrequency> UsysFmlaLeaveFrequencies { get; set; }

    public virtual DbSet<UsysFmlaLeaveReason> UsysFmlaLeaveReasons { get; set; }

    public virtual DbSet<UsysGlobalConstant> UsysGlobalConstants { get; set; }

    public virtual DbSet<UsysGlobalConstantGroup> UsysGlobalConstantGroups { get; set; }

    public virtual DbSet<UsysGlobalConstantGroupRecord> UsysGlobalConstantGroupRecords { get; set; }

    public virtual DbSet<UsysHtmlText> UsysHtmlTexts { get; set; }

    public virtual DbSet<UsysI9documentType> UsysI9documentTypes { get; set; }

    public virtual DbSet<UsysIdAutoPopulation> UsysIdAutoPopulations { get; set; }

    public virtual DbSet<UsysInstallation> UsysInstallations { get; set; }

    public virtual DbSet<UsysIntegrationTemplateKey> UsysIntegrationTemplateKeys { get; set; }

    public virtual DbSet<UsysLanguageUser> UsysLanguageUsers { get; set; }

    public virtual DbSet<UsysLink> UsysLinks { get; set; }

    public virtual DbSet<UsysLnk834RecordSort> UsysLnk834RecordSorts { get; set; }

    public virtual DbSet<UsysLnk834SortTable> UsysLnk834SortTables { get; set; }

    public virtual DbSet<UsysLnkCodeConv> UsysLnkCodeConvs { get; set; }

    public virtual DbSet<UsysLnkDataGrouping> UsysLnkDataGroupings { get; set; }

    public virtual DbSet<UsysLnkDataGroupingField> UsysLnkDataGroupingFields { get; set; }

    public virtual DbSet<UsysLnkDataGroupingRecord> UsysLnkDataGroupingRecords { get; set; }

    public virtual DbSet<UsysLnkDataSorting> UsysLnkDataSortings { get; set; }

    public virtual DbSet<UsysLnkDataSortingDataGrouping> UsysLnkDataSortingDataGroupings { get; set; }

    public virtual DbSet<UsysLnkDataSortingRecord> UsysLnkDataSortingRecords { get; set; }

    public virtual DbSet<UsysLnkExportFile> UsysLnkExportFiles { get; set; }

    public virtual DbSet<UsysLnkExportGroup> UsysLnkExportGroups { get; set; }

    public virtual DbSet<UsysLnkExportGroupRule> UsysLnkExportGroupRules { get; set; }

    public virtual DbSet<UsysLnkExportLog> UsysLnkExportLogs { get; set; }

    public virtual DbSet<UsysLnkExportMaster> UsysLnkExportMasters { get; set; }

    public virtual DbSet<UsysLnkExportMasterParameter> UsysLnkExportMasterParameters { get; set; }

    public virtual DbSet<UsysLnkExportPersonHist> UsysLnkExportPersonHists { get; set; }

    public virtual DbSet<UsysLnkExportRecordDataError> UsysLnkExportRecordDataErrors { get; set; }

    public virtual DbSet<UsysLnkExportRecordLog> UsysLnkExportRecordLogs { get; set; }

    public virtual DbSet<UsysLnkExportScheduleHist> UsysLnkExportScheduleHists { get; set; }

    public virtual DbSet<UsysLnkExportStatusCode> UsysLnkExportStatusCodes { get; set; }

    public virtual DbSet<UsysLnkExportTrigger> UsysLnkExportTriggers { get; set; }

    public virtual DbSet<UsysLnkExportTriggerLog> UsysLnkExportTriggerLogs { get; set; }

    public virtual DbSet<UsysLnkExportTriggerPerson> UsysLnkExportTriggerPeople { get; set; }

    public virtual DbSet<UsysLnkExportTriggerRecordLog> UsysLnkExportTriggerRecordLogs { get; set; }

    public virtual DbSet<UsysLnkFieldAssoc> UsysLnkFieldAssocs { get; set; }

    public virtual DbSet<UsysLnkFieldDef> UsysLnkFieldDefs { get; set; }

    public virtual DbSet<UsysLnkImportDataErpPayrollAccum> UsysLnkImportDataErpPayrollAccums { get; set; }

    public virtual DbSet<UsysLnkImportDataError> UsysLnkImportDataErrors { get; set; }

    public virtual DbSet<UsysLnkImportDate> UsysLnkImportDates { get; set; }

    public virtual DbSet<UsysLnkImportDestinationTable> UsysLnkImportDestinationTables { get; set; }

    public virtual DbSet<UsysLnkImportFieldDataType> UsysLnkImportFieldDataTypes { get; set; }

    public virtual DbSet<UsysLnkImportFieldDef> UsysLnkImportFieldDefs { get; set; }

    public virtual DbSet<UsysLnkImportFieldTranslation> UsysLnkImportFieldTranslations { get; set; }

    public virtual DbSet<UsysLnkImportGroup> UsysLnkImportGroups { get; set; }

    public virtual DbSet<UsysLnkImportGroupAssignment> UsysLnkImportGroupAssignments { get; set; }

    public virtual DbSet<UsysLnkImportLog> UsysLnkImportLogs { get; set; }

    public virtual DbSet<UsysLnkImportMaster> UsysLnkImportMasters { get; set; }

    public virtual DbSet<UsysLnkImportScheduleHist> UsysLnkImportScheduleHists { get; set; }

    public virtual DbSet<UsysLnkImportSource> UsysLnkImportSources { get; set; }

    public virtual DbSet<UsysLnkImportSourceParameter> UsysLnkImportSourceParameters { get; set; }

    public virtual DbSet<UsysLnkImportSourceType> UsysLnkImportSourceTypes { get; set; }

    public virtual DbSet<UsysLnkImportStatusCode> UsysLnkImportStatusCodes { get; set; }

    public virtual DbSet<UsysLnkImportType> UsysLnkImportTypes { get; set; }

    public virtual DbSet<UsysLnkRecord> UsysLnkRecords { get; set; }

    public virtual DbSet<UsysLnkRollupBenefit> UsysLnkRollupBenefits { get; set; }

    public virtual DbSet<UsysLnkRollupCode> UsysLnkRollupCodes { get; set; }

    public virtual DbSet<UsysLnkTable> UsysLnkTables { get; set; }

    public virtual DbSet<UsysLnkTableCriterion> UsysLnkTableCriteria { get; set; }

    public virtual DbSet<UsysLog> UsysLogs { get; set; }

    public virtual DbSet<UsysLogConfig> UsysLogConfigs { get; set; }

    public virtual DbSet<UsysLuceneIndexChange> UsysLuceneIndexChanges { get; set; }

    public virtual DbSet<UsysMassChangeError> UsysMassChangeErrors { get; set; }

    public virtual DbSet<UsysMassChangeSql> UsysMassChangeSqls { get; set; }

    public virtual DbSet<UsysMobileComponent> UsysMobileComponents { get; set; }

    public virtual DbSet<UsysModule> UsysModules { get; set; }

    public virtual DbSet<UsysModuleDefinition> UsysModuleDefinitions { get; set; }

    public virtual DbSet<UsysModuleField> UsysModuleFields { get; set; }

    public virtual DbSet<UsysModuleSetting> UsysModuleSettings { get; set; }

    public virtual DbSet<UsysNavigator> UsysNavigators { get; set; }

    public virtual DbSet<UsysNightlyRun> UsysNightlyRuns { get; set; }

    public virtual DbSet<UsysOrgChart> UsysOrgCharts { get; set; }

    public virtual DbSet<UsysPortal> UsysPortals { get; set; }

    public virtual DbSet<UsysPortalHomePageModule> UsysPortalHomePageModules { get; set; }

    public virtual DbSet<UsysPortalType> UsysPortalTypes { get; set; }

    public virtual DbSet<UsysQueryBuilderQuery> UsysQueryBuilderQueries { get; set; }

    public virtual DbSet<UsysRecipient> UsysRecipients { get; set; }

    public virtual DbSet<UsysRecipientDesignator> UsysRecipientDesignators { get; set; }

    public virtual DbSet<UsysRecipientOverride> UsysRecipientOverrides { get; set; }

    public virtual DbSet<UsysRecipientType> UsysRecipientTypes { get; set; }

    public virtual DbSet<UsysReportParameter> UsysReportParameters { get; set; }

    public virtual DbSet<UsysResource> UsysResources { get; set; }

    public virtual DbSet<UsysResourceType> UsysResourceTypes { get; set; }

    public virtual DbSet<UsysResumeSearch> UsysResumeSearches { get; set; }

    public virtual DbSet<UsysResumeSearchParameter> UsysResumeSearchParameters { get; set; }

    public virtual DbSet<UsysRole> UsysRoles { get; set; }

    public virtual DbSet<UsysRoleCodeFilterGroup> UsysRoleCodeFilterGroups { get; set; }

    public virtual DbSet<UsysRoleEntity> UsysRoleEntities { get; set; }

    public virtual DbSet<UsysRoleFlag> UsysRoleFlags { get; set; }

    public virtual DbSet<UsysRoleModuleDefinition> UsysRoleModuleDefinitions { get; set; }

    public virtual DbSet<UsysRolePortal> UsysRolePortals { get; set; }

    public virtual DbSet<UsysRoleRule> UsysRoleRules { get; set; }

    public virtual DbSet<UsysRouting> UsysRoutings { get; set; }

    public virtual DbSet<UsysRoutingInstance> UsysRoutingInstances { get; set; }

    public virtual DbSet<UsysRoutingInstanceHistory> UsysRoutingInstanceHistories { get; set; }

    public virtual DbSet<UsysRoutingInstanceStep> UsysRoutingInstanceSteps { get; set; }

    public virtual DbSet<UsysRoutingInstanceStepHistory> UsysRoutingInstanceStepHistories { get; set; }

    public virtual DbSet<UsysRoutingResponse> UsysRoutingResponses { get; set; }

    public virtual DbSet<UsysRoutingStatus> UsysRoutingStatuses { get; set; }

    public virtual DbSet<UsysRoutingStep> UsysRoutingSteps { get; set; }

    public virtual DbSet<UsysRoutingStepGroup> UsysRoutingStepGroups { get; set; }

    public virtual DbSet<UsysRowSecurity> UsysRowSecurities { get; set; }

    public virtual DbSet<UsysRowSecurityRule> UsysRowSecurityRules { get; set; }

    public virtual DbSet<UsysRule> UsysRules { get; set; }

    public virtual DbSet<UsysRuleSet> UsysRuleSets { get; set; }

    public virtual DbSet<UsysRuleSetRule> UsysRuleSetRules { get; set; }

    public virtual DbSet<UsysSalaryPlan> UsysSalaryPlans { get; set; }

    public virtual DbSet<UsysSalaryPlanBasePayDetail> UsysSalaryPlanBasePayDetails { get; set; }

    public virtual DbSet<UsysSalaryPlanBasePayPersonDetail> UsysSalaryPlanBasePayPersonDetails { get; set; }

    public virtual DbSet<UsysSalaryPlanOtherPayDetail> UsysSalaryPlanOtherPayDetails { get; set; }

    public virtual DbSet<UsysSalaryPlanOtherPayPersonDetail> UsysSalaryPlanOtherPayPersonDetails { get; set; }

    public virtual DbSet<UsysSalaryPlanPerformanceMatrix> UsysSalaryPlanPerformanceMatrices { get; set; }

    public virtual DbSet<UsysSalaryPlanPerformanceMatrixRuleSet> UsysSalaryPlanPerformanceMatrixRuleSets { get; set; }

    public virtual DbSet<UsysSalaryPlanPerson> UsysSalaryPlanPeople { get; set; }

    public virtual DbSet<UsysSalaryPlanStatus> UsysSalaryPlanStatuses { get; set; }

    public virtual DbSet<UsysServiceAccessLog> UsysServiceAccessLogs { get; set; }

    public virtual DbSet<UsysSynchronizationEntity> UsysSynchronizationEntities { get; set; }

    public virtual DbSet<UsysSynchronizationPerson> UsysSynchronizationPeople { get; set; }

    public virtual DbSet<UsysTab> UsysTabs { get; set; }

    public virtual DbSet<UsysTaskDataLog> UsysTaskDataLogs { get; set; }

    public virtual DbSet<UsysTaskDatum> UsysTaskData { get; set; }

    public virtual DbSet<UsysTimeCostModel> UsysTimeCostModels { get; set; }

    public virtual DbSet<UsysTimeCostModelPerson> UsysTimeCostModelPeople { get; set; }

    public virtual DbSet<UsysTimeCostModelPersonDetail> UsysTimeCostModelPersonDetails { get; set; }

    public virtual DbSet<UsysUploadedFile> UsysUploadedFiles { get; set; }

    public virtual DbSet<UsysUser> UsysUsers { get; set; }

    public virtual DbSet<UsysUserAccessLog> UsysUserAccessLogs { get; set; }

    public virtual DbSet<UsysUserHomePageModule> UsysUserHomePageModules { get; set; }

    public virtual DbSet<UsysUserRole> UsysUserRoles { get; set; }

    public virtual DbSet<UsysUserSignatureAnswer> UsysUserSignatureAnswers { get; set; }

    public virtual DbSet<UsysVendorEmployeeIdentifier> UsysVendorEmployeeIdentifiers { get; set; }

    public virtual DbSet<UsysVendorType> UsysVendorTypes { get; set; }

    public virtual DbSet<V834Hm> V834Hms { get; set; }

    public virtual DbSet<V834HmDistinct> V834HmDistincts { get; set; }

    public virtual DbSet<V834Ml> V834Mls { get; set; }

    public virtual DbSet<V834MlDistinct> V834MlDistincts { get; set; }

    public virtual DbSet<V834Standard> V834Standards { get; set; }

    public virtual DbSet<V834StandardDistinct> V834StandardDistincts { get; set; }

    public virtual DbSet<V834Upmc> V834Upmcs { get; set; }

    public virtual DbSet<V834UpmcDistinct> V834UpmcDistincts { get; set; }

    public virtual DbSet<VAbsencePointsParameter> VAbsencePointsParameters { get; set; }

    public virtual DbSet<VAcaparameter> VAcaparameters { get; set; }

    public virtual DbSet<VAlertParameter> VAlertParameters { get; set; }

    public virtual DbSet<VApplicantParameter> VApplicantParameters { get; set; }

    public virtual DbSet<VBenefitEnrollmentParameter> VBenefitEnrollmentParameters { get; set; }

    public virtual DbSet<VBtwbcactiveSuperview> VBtwbcactiveSuperviews { get; set; }

    public virtual DbSet<VCobrareportParameter> VCobrareportParameters { get; set; }

    public virtual DbSet<VCodeFilteringParameter> VCodeFilteringParameters { get; set; }

    public virtual DbSet<VCurrencyParameter> VCurrencyParameters { get; set; }

    public virtual DbSet<VDirectDepositParameter> VDirectDepositParameters { get; set; }

    public virtual DbSet<VFieldMask> VFieldMasks { get; set; }

    public virtual DbSet<VJobOpeningsParameter> VJobOpeningsParameters { get; set; }

    public virtual DbSet<VLeaveParameter> VLeaveParameters { get; set; }

    public virtual DbSet<VLnkAbsencePlansErp> VLnkAbsencePlansErps { get; set; }

    public virtual DbSet<VLnkAddress> VLnkAddresses { get; set; }

    public virtual DbSet<VLnkBasePayHist> VLnkBasePayHists { get; set; }

    public virtual DbSet<VLnkBroadbeanRequisition> VLnkBroadbeanRequisitions { get; set; }

    public virtual DbSet<VLnkCmsemployee> VLnkCmsemployees { get; set; }

    public virtual DbSet<VLnkCompanyTango> VLnkCompanyTangos { get; set; }

    public virtual DbSet<VLnkDirectDeposit> VLnkDirectDeposits { get; set; }

    public virtual DbSet<VLnkDirectDepositWithType> VLnkDirectDepositWithTypes { get; set; }

    public virtual DbSet<VLnkE10payrollDeductionCode> VLnkE10payrollDeductionCodes { get; set; }

    public virtual DbSet<VLnkE9payrollDeductionCode> VLnkE9payrollDeductionCodes { get; set; }

    public virtual DbSet<VLnkJobHist> VLnkJobHists { get; set; }

    public virtual DbSet<VLnkJobHistMax> VLnkJobHistMaxes { get; set; }

    public virtual DbSet<VLnkMobilePhone> VLnkMobilePhones { get; set; }

    public virtual DbSet<VLnkNationalId> VLnkNationalIds { get; set; }

    public virtual DbSet<VLnkOtherPayAdpx> VLnkOtherPayAdpxes { get; set; }

    public virtual DbSet<VLnkOtherPayDev> VLnkOtherPayDevs { get; set; }

    public virtual DbSet<VLnkPersonAbsenceHistErp> VLnkPersonAbsenceHistErps { get; set; }

    public virtual DbSet<VLnkPersonBasePayHistDeduct> VLnkPersonBasePayHistDeducts { get; set; }

    public virtual DbSet<VLnkPersonBasePayHistE10prempRt> VLnkPersonBasePayHistE10prempRts { get; set; }

    public virtual DbSet<VLnkPersonBasePayHistMax> VLnkPersonBasePayHistMaxes { get; set; }

    public virtual DbSet<VLnkPersonBenefitEnrollmentOfferTango> VLnkPersonBenefitEnrollmentOfferTangos { get; set; }

    public virtual DbSet<VLnkPersonBenefitHistoryActiveHealthTango> VLnkPersonBenefitHistoryActiveHealthTangos { get; set; }

    public virtual DbSet<VLnkPersonBenefitHistoryWaiveHealthTango> VLnkPersonBenefitHistoryWaiveHealthTangos { get; set; }

    public virtual DbSet<VLnkPersonLocationHistMax> VLnkPersonLocationHistMaxes { get; set; }

    public virtual DbSet<VLnkPhone> VLnkPhones { get; set; }

    public virtual DbSet<VLnkPreferredLanguage> VLnkPreferredLanguages { get; set; }

    public virtual DbSet<VLnkRollupPlanAmount> VLnkRollupPlanAmounts { get; set; }

    public virtual DbSet<VLnkRollupPlanAmountDev> VLnkRollupPlanAmountDevs { get; set; }

    public virtual DbSet<VLnkTimeDetailAdp> VLnkTimeDetailAdps { get; set; }

    public virtual DbSet<VLoginParameter> VLoginParameters { get; set; }

    public virtual DbSet<VNonZeroBenefitContributionHist> VNonZeroBenefitContributionHists { get; set; }

    public virtual DbSet<VOlapparameter> VOlapparameters { get; set; }

    public virtual DbSet<VOpenEnrollmentParameter> VOpenEnrollmentParameters { get; set; }

    public virtual DbSet<VOrgPublisherPerson> VOrgPublisherPeople { get; set; }

    public virtual DbSet<VOrgPublisherPosition> VOrgPublisherPositions { get; set; }

    public virtual DbSet<VOrgPublisherPositionWithIncumbent> VOrgPublisherPositionWithIncumbents { get; set; }

    public virtual DbSet<VPerformanceReviewParameter> VPerformanceReviewParameters { get; set; }

    public virtual DbSet<VPersonGoalParameter> VPersonGoalParameters { get; set; }

    public virtual DbSet<VPersonParameter> VPersonParameters { get; set; }

    public virtual DbSet<VRecruitingExpenseParameter> VRecruitingExpenseParameters { get; set; }

    public virtual DbSet<VRegistrationParameter> VRegistrationParameters { get; set; }

    public virtual DbSet<VReportingServicesParameter> VReportingServicesParameters { get; set; }

    public virtual DbSet<VSystemImageParameter> VSystemImageParameters { get; set; }

    public virtual DbSet<VSystemPerformanceParameter> VSystemPerformanceParameters { get; set; }

    public virtual DbSet<VSystemPitreportingParameter> VSystemPitreportingParameters { get; set; }

    public virtual DbSet<VTimesheetParameter> VTimesheetParameters { get; set; }

    public virtual DbSet<VWesleyActiveSuperview> VWesleyActiveSuperviews { get; set; }

    public virtual DbSet<VWesleyActiveSuperviewFix> VWesleyActiveSuperviewFixes { get; set; }

    public virtual DbSet<VWesleyActiveSuperviewWithUsername> VWesleyActiveSuperviewWithUsernames { get; set; }

    public virtual DbSet<VWfsactiveSuperview> VWfsactiveSuperviews { get; set; }

    public virtual DbSet<VWfsopenRec> VWfsopenRecs { get; set; }

    public virtual DbSet<VWfsopenRoute> VWfsopenRoutes { get; set; }

    public virtual DbSet<VlnkPersonBasePayHistWss> VlnkPersonBasePayHistWsses { get; set; }

    public virtual DbSet<VolapPersonAbsenceOccurrenceFactTable> VolapPersonAbsenceOccurrenceFactTables { get; set; }

    public virtual DbSet<VolapPersonAbsencePlanFactTable> VolapPersonAbsencePlanFactTables { get; set; }

    public virtual DbSet<VolapPersonApplicationFactTable> VolapPersonApplicationFactTables { get; set; }

    public virtual DbSet<VolapPersonBasePayFactTable> VolapPersonBasePayFactTables { get; set; }

    public virtual DbSet<VolapPersonBenefitFactTable> VolapPersonBenefitFactTables { get; set; }

    public virtual DbSet<VolapPersonCertificationFactTable> VolapPersonCertificationFactTables { get; set; }

    public virtual DbSet<VolapPersonCompetencyFactTable> VolapPersonCompetencyFactTables { get; set; }

    public virtual DbSet<VolapPersonEducationFactTable> VolapPersonEducationFactTables { get; set; }

    public virtual DbSet<VolapPersonFactTable> VolapPersonFactTables { get; set; }

    public virtual DbSet<VolapPersonIllnessInjuryFactTable> VolapPersonIllnessInjuryFactTables { get; set; }

    public virtual DbSet<VolapPersonOtherPayFactTable> VolapPersonOtherPayFactTables { get; set; }

    public virtual DbSet<VolapPersonPreviousEmploymentFactTable> VolapPersonPreviousEmploymentFactTables { get; set; }

    public virtual DbSet<VolapPersonPropertyCardFactTable> VolapPersonPropertyCardFactTables { get; set; }

    public virtual DbSet<VolapPersonPropertyFactTable> VolapPersonPropertyFactTables { get; set; }

    public virtual DbSet<VolapPersonTerminationFactTable> VolapPersonTerminationFactTables { get; set; }

    public virtual DbSet<VolapPersonTrainingExpenseFactTable> VolapPersonTrainingExpenseFactTables { get; set; }

    public virtual DbSet<VolapPersonTrainingFactTable> VolapPersonTrainingFactTables { get; set; }

    public virtual DbSet<VolapPropertyFactTable> VolapPropertyFactTables { get; set; }

    public virtual DbSet<VolapRecruitingExpenseFactTable> VolapRecruitingExpenseFactTables { get; set; }

    public virtual DbSet<VolapRequisitionFactTable> VolapRequisitionFactTables { get; set; }

    public virtual DbSet<VrptActiveBenefit> VrptActiveBenefits { get; set; }

    public virtual DbSet<VrptActiveCalculation> VrptActiveCalculations { get; set; }

    public virtual DbSet<VrptActiveSuperview> VrptActiveSuperviews { get; set; }

    public virtual DbSet<VrptAllApplicant> VrptAllApplicants { get; set; }

    public virtual DbSet<VrptAllPerson> VrptAllPersons { get; set; }

    public virtual DbSet<VrptAllPersonsAllPosition> VrptAllPersonsAllPositions { get; set; }

    public virtual DbSet<VrptAllPersonsPreviou> VrptAllPersonsPrevious { get; set; }

    public virtual DbSet<VrptArchiveAbsence> VrptArchiveAbsences { get; set; }

    public virtual DbSet<VrptArchiveApplication> VrptArchiveApplications { get; set; }

    public virtual DbSet<VrptArchiveTimeDetail> VrptArchiveTimeDetails { get; set; }

    public virtual DbSet<VrptBaseCalculation> VrptBaseCalculations { get; set; }

    public virtual DbSet<VrptBaseCalculationsConverted> VrptBaseCalculationsConverteds { get; set; }

    public virtual DbSet<VrptHistorySuperview> VrptHistorySuperviews { get; set; }

    public virtual DbSet<VrptPersonCalculation> VrptPersonCalculations { get; set; }

    public virtual DbSet<VrptPersonFutureEnrollmentBeneficiary> VrptPersonFutureEnrollmentBeneficiaries { get; set; }

    public virtual DbSet<VrptPersonFutureoEnrolledDependent> VrptPersonFutureoEnrolledDependents { get; set; }

    public virtual DbSet<VrptPitallPerson> VrptPitallPersons { get; set; }

    public virtual DbSet<VrptPitbenefit> VrptPitbenefits { get; set; }

    public virtual DbSet<VrptPitcalculation> VrptPitcalculations { get; set; }

    public virtual DbSet<VrptPitsuperview> VrptPitsuperviews { get; set; }

    public virtual DbSet<VrptgcPitallPerson> VrptgcPitallPersons { get; set; }

    public virtual DbSet<VrptgcPitbenefit> VrptgcPitbenefits { get; set; }

    public virtual DbSet<VrptgcPitcalculation> VrptgcPitcalculations { get; set; }

    public virtual DbSet<VrptgcPitsuperview> VrptgcPitsuperviews { get; set; }

    public virtual DbSet<WesleyAbsenceCutover> WesleyAbsenceCutovers { get; set; }

    public virtual DbSet<WfsIbhsPostHist> WfsIbhsPostHists { get; set; }

    public virtual DbSet<WfsRoutingOverrideRoutingInstanceStep> WfsRoutingOverrideRoutingInstanceSteps { get; set; }

    public virtual DbSet<WfsgcPitsuperview> WfsgcPitsuperviews { get; set; }

    public virtual DbSet<WfspendingTermRoute> WfspendingTermRoutes { get; set; }

    public virtual DbSet<Zschooldistrict> Zschooldistricts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DcConfigLinkTable>(entity =>
        {
            entity.Property(e => e.DeleteOnlyFlag).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<DcForeignKey>(entity =>
        {
            entity.ToView("dcForeignKeys");
        });

        modelBuilder.Entity<Lnk6bvWAdp10007>(entity =>
        {
            entity.Property(e => e.Earnings3Amount).IsFixedLength();
            entity.Property(e => e.Earnings4Code).IsFixedLength();
        });

        modelBuilder.Entity<LnkHvhWAdp10007>(entity =>
        {
            entity.Property(e => e.Earnings3Amount).IsFixedLength();
            entity.Property(e => e.Earnings4Code).IsFixedLength();
        });

        modelBuilder.Entity<LnkHvhWhAdp10007>(entity =>
        {
            entity.Property(e => e.Earnings3Amount).IsFixedLength();
            entity.Property(e => e.Earnings4Code).IsFixedLength();
        });

        modelBuilder.Entity<LnkV1gWAdp10007>(entity =>
        {
            entity.Property(e => e.Earnings3Amount).IsFixedLength();
            entity.Property(e => e.Earnings4Code).IsFixedLength();
        });

        modelBuilder.Entity<LnkV1gWhAdp10007>(entity =>
        {
            entity.Property(e => e.Earnings3Amount).IsFixedLength();
            entity.Property(e => e.Earnings4Code).IsFixedLength();
        });

        modelBuilder.Entity<TAbsenceAdjustmentReason>(entity =>
        {
            entity.Property(e => e.AbsenceAdjustmentReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsenceAdjustmentReason','AbsenceAdjustmentReasonDescription',[AbsenceAdjustmentReasonGUID]))", false);
        });

        modelBuilder.Entity<TAbsencePlan>(entity =>
        {
            entity.Property(e => e.AbsencePlanDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePlan','AbsencePlanDescription',[AbsencePlanGUID]))", false);
        });

        modelBuilder.Entity<TAbsencePlanDetailHist>(entity =>
        {
            entity.HasKey(e => e.AbsencePlanDetailGuid).IsClustered(false);

            entity.HasIndex(e => new { e.AbsencePlanCode, e.AbsencePlanStartDate }, "AK_tAbsencePlanDetailHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AbsencePlanDetailGuid).ValueGeneratedNever();
            entity.Property(e => e.AbsencePlanDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePlanDetailHist','AbsencePlanDescription',[AbsencePlanDetailGUID]))", false);
            entity.Property(e => e.AbsenceUnits).HasDefaultValueSql("('HR')");
            entity.Property(e => e.AccrualPeriod).HasDefaultValueSql("('YR')");
            entity.Property(e => e.BeginEndAccrual).HasDefaultValueSql("('Begin')");
            entity.Property(e => e.EligibilityChangeRule).HasDefaultValueSql("('New')");
            entity.Property(e => e.PlanYearType).HasDefaultValueSql("('Calendar')");
            entity.Property(e => e.TimeInServiceField).HasDefaultValueSql("('AdjustedHireDate')");

            entity.HasOne(d => d.AbsencePlanCodeNavigation).WithMany(p => p.TAbsencePlanDetailHists).HasConstraintName("FK_tAbsencePlanDetailHist_tAbsencePlan");

            entity.HasOne(d => d.AbsencePlanTypeCodeNavigation).WithMany(p => p.TAbsencePlanDetailHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAbsencePlanDetailHist_tAbsencePlanType");
        });

        modelBuilder.Entity<TAbsencePlanRule>(entity =>
        {
            entity.Property(e => e.AbsencePlanRuleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AbsencePlanDetail).WithMany(p => p.TAbsencePlanRules).HasConstraintName("FK_tAbsencePlanRule_tAbsencePlanDetailHist");
        });

        modelBuilder.Entity<TAbsencePlanRuleSetHist>(entity =>
        {
            entity.HasKey(e => e.AbsencePlanRuleSetGuid).IsClustered(false);

            entity.HasIndex(e => new { e.AbsenceRuleSetCode, e.AbsencePlanCode, e.AbsencePlanRuleSetStartDate }, "AK_tAbsencePlanRuleSetHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AbsencePlanRuleSetGuid).ValueGeneratedNever();
            entity.Property(e => e.AbsencePlanRuleSetDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePlanRuleSetHist','AbsencePlanRuleSetDescription',[AbsencePlanRuleSetGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AbsencePlanCodeNavigation).WithMany(p => p.TAbsencePlanRuleSetHists).HasConstraintName("FK_tAbsencePlanRuleSetHist_tAbsencePlan");

            entity.HasOne(d => d.AbsenceRuleSetCodeNavigation).WithMany(p => p.TAbsencePlanRuleSetHists).HasConstraintName("FK_tAbsencePlanRuleSetHist_tAbsenceRuleSet");
        });

        modelBuilder.Entity<TAbsencePlanType>(entity =>
        {
            entity.Property(e => e.AbsencePlanTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePlanType','AbsencePlanTypeDescription',[AbsencePlanTypeGUID]))", false);
        });

        modelBuilder.Entity<TAbsencePointAdjustmentType>(entity =>
        {
            entity.HasKey(e => e.AbsencePointAdjustmentTypeCode).HasName("PK_AbsencePointAdjustmentType");

            entity.Property(e => e.AbsencePointAdjustmentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePointAdjustmentType','AbsencePointAdjustmentTypeDescription',[AbsencePointAdjustmentTypeGUID]))", false);
        });

        modelBuilder.Entity<TAbsencePointCorrectiveAction>(entity =>
        {
            entity.HasKey(e => e.AbsencePointCorrectiveActionCode).HasName("PK_AbsenceCorrectiveAction");

            entity.Property(e => e.AbsencePointCorrectiveActionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePointCorrectiveAction','AbsencePointCorrectiveActionDescription',[AbsencePointCorrectiveActionGUID]))", false);
        });

        modelBuilder.Entity<TAbsencePointEvent>(entity =>
        {
            entity.HasKey(e => e.AbsencePointEventGuid).HasName("PK_AbsencePointEvent");

            entity.Property(e => e.AbsencePointEventGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TAbsencePointIncident>(entity =>
        {
            entity.HasKey(e => e.AbsencePointIncidentCode).HasName("PK_AbsenceIncident");

            entity.Property(e => e.AbsencePointIncidentDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsencePointIncident','AbsencePointIncidentDescription',[AbsencePointIncidentGUID]))", false);
        });

        modelBuilder.Entity<TAbsenceReason>(entity =>
        {
            entity.Property(e => e.AbsenceReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsenceReason','AbsenceReasonDescription',[AbsenceReasonGUID]))", false);

            entity.HasOne(d => d.AbsenceAdjustmentReasonCodeNavigation).WithMany(p => p.TAbsenceReasons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAbsenceReason_tAbsenceAdjustmentReason");
        });

        modelBuilder.Entity<TAbsenceRule>(entity =>
        {
            entity.HasKey(e => e.AbsenceRuleCode).IsClustered(false);

            entity.Property(e => e.AbsenceRuleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsenceRule','AbsenceRuleDescription',[AbsenceRuleGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.TAbsenceRules).HasConstraintName("FK_tAbsenceRule_USysEntity");
        });

        modelBuilder.Entity<TAbsenceRuleSet>(entity =>
        {
            entity.HasKey(e => e.AbsenceRuleSetCode).IsClustered(false);

            entity.Property(e => e.AbsenceRuleSetDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAbsenceRuleSet','AbsenceRuleSetDescription',[AbsenceRuleSetGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CommunicationTemplate).WithMany(p => p.TAbsenceRuleSets)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tAbsenceRuleSet_USysCommunicationTemplate");

            entity.HasOne(d => d.CreatedByPerson).WithMany(p => p.TAbsenceRuleSets)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tAbsenceRuleSet_tPerson");
        });

        modelBuilder.Entity<TAbsenceRuleSetCommunicationRecipient>(entity =>
        {
            entity.HasKey(e => e.AbsenceRuleSetCommunicationRecipientGuid).IsClustered(false);

            entity.Property(e => e.AbsenceRuleSetCommunicationRecipientGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AbsenceRuleSetCodeNavigation).WithMany(p => p.TAbsenceRuleSetCommunicationRecipients).HasConstraintName("FK_tAbsenceRuleSetCommunicationRecipient_tAbsenceRuleSet");

            entity.HasOne(d => d.Recipient).WithMany(p => p.TAbsenceRuleSetCommunicationRecipients).HasConstraintName("FK_tAbsenceRuleSetCommunicationRecipient_USysRecipient");
        });

        modelBuilder.Entity<TAbsenceRuleSetOwner>(entity =>
        {
            entity.HasKey(e => e.AbsenceRuleSetOwnerGuid).IsClustered(false);

            entity.HasIndex(e => new { e.AbsenceRuleSetCode, e.OwnerPersonGuid }, "AK_tAbsenceRuleSetOwner")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AbsenceRuleSetOwnerGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AbsenceRuleSetCodeNavigation).WithMany(p => p.TAbsenceRuleSetOwners)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAbsenceRuleSetOwner_tAbsenceRuleSet");

            entity.HasOne(d => d.OwnerPerson).WithMany(p => p.TAbsenceRuleSetOwners).HasConstraintName("FK_tAbsenceRuleSetOwner_tPerson");
        });

        modelBuilder.Entity<TAbsenceRuleSetRule>(entity =>
        {
            entity.HasKey(e => e.AbsenceRuleSetRuleGuid).IsClustered(false);

            entity.HasIndex(e => new { e.AbsenceRuleSetCode, e.AbsenceRuleCode }, "AK_tAbsenceRuleSetRule")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AbsenceRuleSetRuleGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AbsenceRuleCodeNavigation).WithMany(p => p.TAbsenceRuleSetRules).HasConstraintName("FK_tAbsenceRuleSetRule_tAbsenceRule");

            entity.HasOne(d => d.AbsenceRuleSetCodeNavigation).WithMany(p => p.TAbsenceRuleSetRules).HasConstraintName("FK_tAbsenceRuleSetRule_tAbsenceRuleSet");
        });

        modelBuilder.Entity<TAddressType>(entity =>
        {
            entity.Property(e => e.AddressTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAddressType','AddressTypeDescription',[AddressTypeGUID]))", false);
        });

        modelBuilder.Entity<TAlternateCompetency>(entity =>
        {
            entity.HasKey(e => e.AlternateCompetencyGuid).IsClustered(false);

            entity.HasIndex(e => e.CompetencyCode, "CIX_tAlternateCompetency_CompetencyCode").IsClustered();

            entity.Property(e => e.AlternateCompetencyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AlternateCompetencyCodeNavigation).WithMany(p => p.TAlternateCompetencyAlternateCompetencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAlternateCompetency_tCompetency_Alternate");

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TAlternateCompetencyCompetencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tAlternateCompetency_tCompetency");
        });

        modelBuilder.Entity<TApplicationAnswer>(entity =>
        {
            entity.HasKey(e => e.ApplicationAnswerGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ApplicationAnswerTypeCode, e.SortOrder }, "CIX_tApplicationAnswer").IsClustered();

            entity.Property(e => e.ApplicationAnswerGuid).ValueGeneratedNever();
            entity.Property(e => e.Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tApplicationAnswer','Description',[ApplicationAnswerGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ApplicationAnswerTypeCodeNavigation).WithMany(p => p.TApplicationAnswers).HasConstraintName("FK_tApplicationAnswer_tApplicationAnswerType");
        });

        modelBuilder.Entity<TApplicationAnswerType>(entity =>
        {
            entity.Property(e => e.ApplicationAnswerTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tApplicationAnswerType','ApplicationAnswerTypeDescription',[ApplicationAnswerTypeGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TApplicationQuestion>(entity =>
        {
            entity.Property(e => e.ApplicationQuestionText).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tApplicationQuestion','ApplicationQuestionText',[ApplicationQuestionGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ApplicationAnswerTypeCodeNavigation).WithMany(p => p.TApplicationQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tApplicationQuestion_tApplicationAnswerType");
        });

        modelBuilder.Entity<TApplicationStatus>(entity =>
        {
            entity.Property(e => e.ApplicationStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tApplicationStatus','ApplicationStatusDescription',[ApplicationStatusGUID]))", false);
            entity.Property(e => e.CandidateStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tApplicationStatus','CandidateStatusDescription',[ApplicationStatusGUID]))", false);
        });

        modelBuilder.Entity<TAttendance>(entity =>
        {
            entity.Property(e => e.AttendanceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tAttendance','AttendanceDescription',[AttendanceGUID]))", false);
        });

        modelBuilder.Entity<TBargainingUnit>(entity =>
        {
            entity.Property(e => e.BargainingUnitDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBargainingUnit','BargainingUnitDescription',[BargainingUnitGuid]))", false);

            entity.HasOne(d => d.UnionCodeNavigation).WithMany(p => p.TBargainingUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBargainingUnit_tUnion");
        });

        modelBuilder.Entity<TBasePayReason>(entity =>
        {
            entity.Property(e => e.BasePayReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBasePayReason','BasePayReasonDescription',[BasePayReasonGUID]))", false);
        });

        modelBuilder.Entity<TBenefitCarrierHist>(entity =>
        {
            entity.HasKey(e => e.BenefitCarrierGuid).IsClustered(false);

            entity.HasIndex(e => new { e.BenefitPlanCode, e.BenefitCarrierStartDate }, "CIX_tBenefitCarrierHist_BenefitPlanCode_BenefitCarrierStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.BenefitCarrierGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanCodeNavigation).WithMany(p => p.TBenefitCarrierHists).HasConstraintName("FK_tBenefitCarrierHist_tBenefitPlan");

            entity.HasOne(d => d.CarrierCodeNavigation).WithMany(p => p.TBenefitCarrierHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitCarrierHist_tCarrier");
        });

        modelBuilder.Entity<TBenefitEligibilityParameterHist>(entity =>
        {
            entity.HasKey(e => e.BenefitEligibilityParameterHistGuid).IsClustered(false);

            entity.HasIndex(e => new { e.BenefitPlanOptionGuid, e.BenefitEligibilityParameterStartDate }, "AK_tBenefitEligibilityParameterHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEligibilityParameterHistGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TBenefitEligibilityParameterHists).HasConstraintName("FK_tBenefitEligibilityParameterHist_tBenefitPlanOption");
        });

        modelBuilder.Entity<TBenefitEligibilityParameterHistCode>(entity =>
        {
            entity.HasKey(e => e.BenefitEligibilityParameterHistCodeGuid).IsClustered(false);

            entity.HasIndex(e => e.BenefitEligibilityParameterGuid, "CIX_tBenefitEligibilityParameterHistCode_BenefitEligibilityParameterGUID").IsClustered();

            entity.Property(e => e.BenefitEligibilityParameterHistCodeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitEligibilityParameter).WithMany(p => p.TBenefitEligibilityParameterHistCodes).HasConstraintName("FK_tBenefitEligibilityParameterHistCode_1");
        });

        modelBuilder.Entity<TBenefitFutureEnrollmentPersonStatus>(entity =>
        {
            entity.Property(e => e.BenefitFutureEnrollmentPersonStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitFutureEnrollmentPersonStatus','BenefitFutureEnrollmentPersonStatusDescription',[BenefitFutureEnrollmentPersonStatusGUID]))", false);
        });

        modelBuilder.Entity<TBenefitFutureEnrollmentStatus>(entity =>
        {
            entity.Property(e => e.BenefitFutureEnrollmentStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitFutureEnrollmentStatus','BenefitFutureEnrollmentStatusDescription',[BenefitFutureEnrollmentStatusGUID]))", false);
        });

        modelBuilder.Entity<TBenefitGroup>(entity =>
        {
            entity.Property(e => e.BenefitGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitGroup','BenefitGroupDescription',[BenefitGroupGUID]))", false);
        });

        modelBuilder.Entity<TBenefitHist>(entity =>
        {
            entity.HasKey(e => e.BenefitHistGuid).IsClustered(false);

            entity.HasIndex(e => new { e.BenefitPlanOptionGuid, e.BenefitStartDate }, "CIX_tBenefitHist_BenefitPlanOptionGuid_BenefitStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.BenefitHistGuid).ValueGeneratedNever();
            entity.Property(e => e.BenefitDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitHist','BenefitDescription',[BenefitHistGUID]))", false);
            entity.Property(e => e.ContributionFunction).HasDefaultValueSql("('-')");
            entity.Property(e => e.EligibilityFunction).HasDefaultValueSql("('-')");
            entity.Property(e => e.TaxMethod).IsFixedLength();

            entity.HasOne(d => d.AutoEnrollmentEffectiveFromHireFrequencyCodeNavigation).WithMany(p => p.TBenefitHistAutoEnrollmentEffectiveFromHireFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_tFrequency");

            entity.HasOne(d => d.AutoEnrollmentStartStatusCodeNavigation).WithMany(p => p.TBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_tBenefitStatus");

            entity.HasOne(d => d.BenefitCurrencyCodeNavigation).WithMany(p => p.TBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_tCurrency");

            entity.HasOne(d => d.BenefitFrequencyCodeNavigation).WithMany(p => p.TBenefitHistBenefitFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_Coverage_tFrequency");

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TBenefitHists).HasConstraintName("FK_tBenefitHist_tBenefitPlanOption");

            entity.HasOne(d => d.Dependent834TypeCodeNavigation).WithMany(p => p.TBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_tDependent834Type");

            entity.HasOne(d => d.DependentTypeCodeNavigation).WithMany(p => p.TBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_tDependentType");

            entity.HasOne(d => d.EmployeeContributionFrequencyCodeNavigation).WithMany(p => p.TBenefitHistEmployeeContributionFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_EmployeeContribution_tFrequency");

            entity.HasOne(d => d.EmployerContributionFrequencyCodeNavigation).WithMany(p => p.TBenefitHistEmployerContributionFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_EmployerContribution_tFrequency");

            entity.HasOne(d => d.FlexCreditFrequencyCodeNavigation).WithMany(p => p.TBenefitHistFlexCreditFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_FlexCredit_tFrequency");

            entity.HasOne(d => d.ImputedFrequencyCodeNavigation).WithMany(p => p.TBenefitHistImputedFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_Imputed_tFrequency");

            entity.HasOne(d => d.PhysicianTypeCodeNavigation).WithMany(p => p.TBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_tPhysicianType");

            entity.HasOne(d => d.PremiumFrequencyCodeNavigation).WithMany(p => p.TBenefitHistPremiumFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_Premium_tFrequency");

            entity.HasOne(d => d.WaitingPeriodFrequencyCodeNavigation).WithMany(p => p.TBenefitHistWaitingPeriodFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitHist_WaitingPeriod_tFrequency");
        });

        modelBuilder.Entity<TBenefitOpenEnrollmentGroup>(entity =>
        {
            entity.Property(e => e.BenefitOpenEnrollmentGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitOpenEnrollmentGroup','BenefitOpenEnrollmentGroupDescription',[BenefitOpenEnrollmentGroupGUID]))", false);
            entity.Property(e => e.DetailComments).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitOpenEnrollmentGroup','DetailComments',[BenefitOpenEnrollmentGroupGUID]))", false);
            entity.Property(e => e.SummaryComments).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitOpenEnrollmentGroup','SummaryComments',[BenefitOpenEnrollmentGroupGUID]))", false);

            entity.HasOne(d => d.BasedOnTemplateCodeNavigation).WithMany(p => p.InverseBasedOnTemplateCodeNavigation).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_tBenefitOpenEnrollmentGroup");

            entity.HasOne(d => d.BenefitOpenEnrollmentEmployeeApprovedEmailTemplateNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeApprovedEmailTemplateNavigations).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_BenefitOpenEnrollmentEmployeeApprovedEmailTemplate");

            entity.HasOne(d => d.BenefitOpenEnrollmentEmployeeCompletedEmailTemplateNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeCompletedEmailTemplateNavigations).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_BenefitOpenEnrollmentEmployeeCompletedEmailTemplate");

            entity.HasOne(d => d.BenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplateNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplateNavigations).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_BenefitOpenEnrollmentEmployeeCompletedToAdminEmailTemplate");

            entity.HasOne(d => d.BenefitOpenEnrollmentEmployeeDeniedEmailTemplateNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentEmployeeDeniedEmailTemplateNavigations).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_BenefitOpenEnrollmentEmployeeDeniedEmailTemplate");

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupConfirmationEmailTemplateNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentGroupConfirmationEmailTemplateNavigations).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_BenefitOpenEnrollmentGroupConfirmationEmailTemplate");

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupCreatedEmailTemplateNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupBenefitOpenEnrollmentGroupCreatedEmailTemplateNavigations).HasConstraintName("FK_tBenefitOpenEnrollmentGroup_BenefitOpenEnrollmentGroupCreatedEmailTemplate");
        });

        modelBuilder.Entity<TBenefitOpenEnrollmentGroupPlanOption>(entity =>
        {
            entity.HasKey(e => e.BenefitOpenEnrollmentGroupPlanOptionGuid).IsClustered(false);

            entity.HasIndex(e => e.BenefitPlanOptionGuid, "CIX_tBenefitOpenEnrollmentGroupPlanOption_BenefitPlanOptionGuid").IsClustered();

            entity.Property(e => e.BenefitOpenEnrollmentGroupPlanOptionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupCodeNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupPlanOptions).HasConstraintName("FK_tBenefitOEGroupPlanOption_tBenefitOEGroup");

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TBenefitOpenEnrollmentGroupPlanOptions).HasConstraintName("FK_tBenefitOpenEnrollmentGroupPlanOption_tBenefitPlanOption");
        });

        modelBuilder.Entity<TBenefitOpenEnrollmentGroupStep>(entity =>
        {
            entity.Property(e => e.BenefitOpenEnrollmentGroupStepGuid).ValueGeneratedNever();
            entity.Property(e => e.StepDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitOpenEnrollmentGroupStep','StepDescription',[BenefitOpenEnrollmentGroupStepGUID]))", false);

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupCodeNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupSteps).HasConstraintName("FK_tBenefitOpenEnrollmentGroupStep_tBenefitOpenEnrollmentGroup");
        });

        modelBuilder.Entity<TBenefitOpenEnrollmentGroupStepBenefitPlan>(entity =>
        {
            entity.Property(e => e.BenefitOpenEnrollmentGroupStepBenefitPlanGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupStep).WithMany(p => p.TBenefitOpenEnrollmentGroupStepBenefitPlans).HasConstraintName("FK_tBenefitOpenEnrollmentGroupStepBenefitPlan_tBenefitOpenEnrollmentGroupStep");

            entity.HasOne(d => d.BenefitPlanCodeNavigation).WithMany(p => p.TBenefitOpenEnrollmentGroupStepBenefitPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitOpenEnrollmentGroupStepBenefitPlan_tBenefitPlan");
        });

        modelBuilder.Entity<TBenefitParametersHist>(entity =>
        {
            entity.HasKey(e => e.BenefitParametersHistGuid).IsClustered(false);

            entity.HasIndex(e => new { e.BenefitPlanOptionGuid, e.BenefitParametersStartDate }, "CIX_tBenefitParametersHist_BenefitPlanOptionGuid_BenefitParametersStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.BenefitParametersHistGuid).ValueGeneratedNever();
            entity.Property(e => e.Comments).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitParametersHist','Comments',[BenefitParametersHistGUID]))", false);

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TBenefitParametersHists).HasConstraintName("FK_tBenefitParametersHist_tBenefitPlanOption");

            entity.HasOne(d => d.CoverageMaxCompareToPlanCodeNavigation).WithMany(p => p.TBenefitParametersHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitParametersHist_tBenefitPlan");
        });

        modelBuilder.Entity<TBenefitPlan>(entity =>
        {
            entity.Property(e => e.BenefitPlanDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitPlan','BenefitPlanDescription',[BenefitPlanGUID]))", false);
            entity.Property(e => e.Notes).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitPlan','Notes',[BenefitPlanGUID]))", false);

            entity.HasOne(d => d.BenefitPlanAdministratorCodeNavigation).WithMany(p => p.TBenefitPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitPlan_tBenefitPlanAdministrator");

            entity.HasOne(d => d.BenefitTypeCodeNavigation).WithMany(p => p.TBenefitPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitPlan_tBenefitType");
        });

        modelBuilder.Entity<TBenefitPlanAdministrator>(entity =>
        {
            entity.Property(e => e.BenefitPlanAdministratorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitPlanAdministrator','BenefitPlanAdministratorDescription',[BenefitPlanAdministratorGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TBenefitPlanAdministrators)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitPlanAdministrator_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TBenefitPlanAdministrators)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitPlanAdministrator_tStateProvince");
        });

        modelBuilder.Entity<TBenefitPlanOption>(entity =>
        {
            entity.HasKey(e => e.BenefitPlanOptionGuid).IsClustered(false);

            entity.HasIndex(e => e.BenefitPlanCode, "CIX_tBenefitPlanOption_BenefitPlanCode").IsClustered();

            entity.Property(e => e.BenefitPlanOptionGuid).ValueGeneratedNever();
            entity.Property(e => e.BenefitPlanOptionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitPlanOption','BenefitPlanOptionDescription',[BenefitPlanOptionGUID]))", false);

            entity.HasOne(d => d.BenefitPlanCodeNavigation).WithMany(p => p.TBenefitPlanOptions).HasConstraintName("FK_tBenefitPlanOption_tBenefitPlan");
        });

        modelBuilder.Entity<TBenefitPlanOptionAutoEnroll>(entity =>
        {
            entity.HasKey(e => e.BenefitPlanOptionGuid).IsClustered(false);

            entity.Property(e => e.BenefitPlanOptionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanOption).WithOne(p => p.TBenefitPlanOptionAutoEnroll)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tBenefitPlanOptionAutoEnroll_tBenefitPlanOption");

            entity.HasOne(d => d.StartBenefitStatusCodeNavigation).WithMany(p => p.TBenefitPlanOptionAutoEnrolls).HasConstraintName("FK_tBenefitPlanOptionAutoEnroll_Start_tBenefitStatus");
        });

        modelBuilder.Entity<TBenefitPlanTermination>(entity =>
        {
            entity.HasKey(e => e.BenefitPlanTerminationGuid).IsClustered(false);

            entity.Property(e => e.BenefitPlanTerminationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanCodeNavigation).WithOne(p => p.TBenefitPlanTermination).HasConstraintName("FK_tBenefitPlanTermination_tBenefitPlan");
        });

        modelBuilder.Entity<TBenefitRangeHist>(entity =>
        {
            entity.HasKey(e => e.BenefitRangeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.BenefitPlanOptionGuid, e.BenefitRangeStartDate }, "CIX_tBenefitRangeHist_BenefitPlanOptionGuid_BenefitRangeStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.BenefitRangeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TBenefitRangeHists).HasConstraintName("FK_tBenefitRangeHist_tBenefitPlanOption");
        });

        modelBuilder.Entity<TBenefitRangeValue>(entity =>
        {
            entity.HasKey(e => e.BenefitRangeValueGuid).IsClustered(false);

            entity.HasIndex(e => e.BenefitRangeGuid, "CIX_tBenefitRangeValue_BenefitRangeGUID").IsClustered();

            entity.Property(e => e.BenefitRangeValueGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitRange).WithMany(p => p.TBenefitRangeValues).HasConstraintName("FK_tBenefitRangeValue_tBenefitRangeHist");
        });

        modelBuilder.Entity<TBenefitStatementParameter>(entity =>
        {
            entity.Property(e => e.BenefitStatementParametersGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TBenefitStatus>(entity =>
        {
            entity.Property(e => e.BenefitStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitStatus','BenefitStatusDescription',[BenefitStatusGUID]))", false);
        });

        modelBuilder.Entity<TBenefitType>(entity =>
        {
            entity.Property(e => e.BenefitTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitType','BenefitTypeDescription',[BenefitTypeGUID]))", false);
            entity.Property(e => e.ShowCoverageAmountsInOe).HasDefaultValueSql("((1))");
            entity.Property(e => e.ShowFlexAmountsInOe).HasDefaultValueSql("((1))");
            entity.Property(e => e.ShowImputedAmountsInOe).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TBenefitWaiveReason>(entity =>
        {
            entity.Property(e => e.BenefitWaiveReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBenefitWaiveReason','BenefitWaiveReasonDescription',[BenefitWaiveReasonGUID]))", false);
        });

        modelBuilder.Entity<TBloodType>(entity =>
        {
            entity.Property(e => e.BloodTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBloodType','BloodTypeDescription',[BloodTypeGUID]))", false);
        });

        modelBuilder.Entity<TBodyPart>(entity =>
        {
            entity.Property(e => e.BodyPartDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tBodyPart','BodyPartDescription',[BodyPartGUID]))", false);
        });

        modelBuilder.Entity<TCarrier>(entity =>
        {
            entity.Property(e => e.CarrierDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCarrier','CarrierDescription',[CarrierGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TCarriers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCarrier_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TCarriers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCarrier_tStateProvince");
        });

        modelBuilder.Entity<TCensusMetropolitanArea>(entity =>
        {
            entity.Property(e => e.CensusMetropolitanAreaDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCensusMetropolitanArea','CensusMetropolitanAreaDescription',[CensusMetropolitanAreaGUID]))", false);
        });

        modelBuilder.Entity<TCertification>(entity =>
        {
            entity.Property(e => e.CertificationDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCertification','CertificationDescription',[CertificationGUID]))", false);

            entity.HasOne(d => d.CertificationTypeCodeNavigation).WithMany(p => p.TCertifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCertification_tCertificationType");
        });

        modelBuilder.Entity<TCertificationType>(entity =>
        {
            entity.Property(e => e.CertificationTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCertificationType','CertificationTypeDescription',[CertificationTypeGUID]))", false);
        });

        modelBuilder.Entity<TClass>(entity =>
        {
            entity.HasKey(e => e.ClassGuid).IsClustered(false);

            entity.HasIndex(e => e.CourseCode, "CIX_tClass").IsClustered();

            entity.Property(e => e.ClassGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ClassCurrencyCodeNavigation).WithMany(p => p.TClasses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tCurrency");

            entity.HasOne(d => d.ClassStatusCodeNavigation).WithMany(p => p.TClasses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tClassStatus");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TClasses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tCourse");

            entity.HasOne(d => d.FacilityCodeNavigation).WithMany(p => p.TClasses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tFacility");

            entity.HasOne(d => d.PrimaryInstructorCodeNavigation).WithMany(p => p.TClassPrimaryInstructorCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tInstructor_Primary");

            entity.HasOne(d => d.SecondaryInstructorCodeNavigation).WithMany(p => p.TClassSecondaryInstructorCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tInstructor_Secondary");

            entity.HasOne(d => d.TrainingProviderCodeNavigation).WithMany(p => p.TClasses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClass_tTrainingProvider");
        });

        modelBuilder.Entity<TClassSchedule>(entity =>
        {
            entity.HasKey(e => e.ClassScheduleGuid).IsClustered(false);

            entity.HasIndex(e => e.FacilityCode, "CIX_tClassSchedule_FacilityCode").IsClustered();

            entity.Property(e => e.ClassScheduleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Class).WithMany(p => p.TClassSchedules).HasConstraintName("FK_tClassSchedule_tClass");

            entity.HasOne(d => d.EventTypeCodeNavigation).WithMany(p => p.TClassSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClassSchedule_tEventType");

            entity.HasOne(d => d.FacilityCodeNavigation).WithMany(p => p.TClassSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClassSchedule_tFacility");
        });

        modelBuilder.Entity<TClassStatus>(entity =>
        {
            entity.Property(e => e.ClassStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tClassStatus','ClassStatusDescription',[ClassStatusGUID]))", false);
        });

        modelBuilder.Entity<TClassTrainingMaterial>(entity =>
        {
            entity.Property(e => e.ClassTrainingMaterialGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Class).WithMany(p => p.TClassTrainingMaterials).HasConstraintName("FK_tClassTrainingMaterial_tClass");

            entity.HasOne(d => d.TrainingMaterialCodeNavigation).WithMany(p => p.TClassTrainingMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClassTrainingMaterial_tTrainingMaterial");
        });

        modelBuilder.Entity<TClassTrainingResource>(entity =>
        {
            entity.Property(e => e.ClassTrainingResourceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Class).WithMany(p => p.TClassTrainingResources).HasConstraintName("FK_tClassTrainingResource_tClass");

            entity.HasOne(d => d.TrainingResourceCodeNavigation).WithMany(p => p.TClassTrainingResources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tClassTrainingResource_tTrainingResource");
        });

        modelBuilder.Entity<TCobraevent>(entity =>
        {
            entity.Property(e => e.CobraeventDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCOBRAEvent','COBRAEventDescription',[COBRAEventGUID]))", false);

            entity.HasOne(d => d.CobraeventTypeCodeNavigation).WithMany(p => p.TCobraevents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCOBRAEvent_tCOBRAEventType");
        });

        modelBuilder.Entity<TCobraeventType>(entity =>
        {
            entity.Property(e => e.CobraeventTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCOBRAEventType','COBRAEventTypeDescription',[COBRAEventTypeGUID]))", false);
        });

        modelBuilder.Entity<TCobrastatus>(entity =>
        {
            entity.Property(e => e.CobrastatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCOBRAStatus','COBRAStatusDescription',[COBRAStatusGUID]))", false);
        });

        modelBuilder.Entity<TCompany>(entity =>
        {
            entity.Property(e => e.CompanyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCompany','CompanyDescription',[CompanyGUID]))", false);
            entity.Property(e => e.IndustryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCompany','IndustryDescription',[CompanyGUID]))", false);

            entity.HasOne(d => d.AcadgecountryCodeNavigation).WithMany(p => p.TCompanyAcadgecountryCodeNavigations).HasConstraintName("FK_tCompanyACADGE_tCountry");

            entity.HasOne(d => d.AcadgestateProvinceCodeNavigation).WithMany(p => p.TCompanyAcadgestateProvinceCodeNavigations).HasConstraintName("FK_tCompanyACADGE_tStateProvince");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TCompanyCountryCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompany_tCountry");

            entity.HasOne(d => d.MailCountryCodeNavigation).WithMany(p => p.TCompanyMailCountryCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompany_MailCountryCode_tCountry");

            entity.HasOne(d => d.MailStateProvinceCodeNavigation).WithMany(p => p.TCompanyMailStateProvinceCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompany_MailStateProvinceCode_tStateProvince");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TCompanyStateProvinceCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompany_tStateProvince");
        });

        modelBuilder.Entity<TCompetency>(entity =>
        {
            entity.Property(e => e.CompetencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCompetency','CompetencyDescription',[CompetencyGUID]))", false);
            entity.Property(e => e.ExpandedDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCompetency','ExpandedDescription',[CompetencyGUID]))", false);

            entity.HasOne(d => d.CompetencyCategoryCodeNavigation).WithMany(p => p.TCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompetency_tCompetencyCategory");

            entity.HasOne(d => d.CompetencyClusterCodeNavigation).WithMany(p => p.TCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompetency_tCompetencyCluster");

            entity.HasOne(d => d.FunctionalAreaCodeNavigation).WithMany(p => p.TCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompetency_tFunctionalArea");

            entity.HasOne(d => d.ScaleCodeNavigation).WithMany(p => p.TCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompetency_tScale");
        });

        modelBuilder.Entity<TCompetencyCategory>(entity =>
        {
            entity.Property(e => e.CompetencyCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCompetencyCategory','CompetencyCategoryDescription',[CompetencyCategoryGUID]))", false);
        });

        modelBuilder.Entity<TCompetencyCluster>(entity =>
        {
            entity.Property(e => e.CompetencyClusterDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCompetencyCluster','CompetencyClusterDescription',[CompetencyClusterGUID]))", false);
        });

        modelBuilder.Entity<TCorporateGoal>(entity =>
        {
            entity.Property(e => e.CorporateGoalGuid).ValueGeneratedNever();
            entity.Property(e => e.OtherGoalDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCorporateGoal','OtherGoalDescription',[CorporateGoalGUID]))", false);

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tCertification");

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tCompetency");

            entity.HasOne(d => d.CompetencyProficiencyCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tProficiency");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tCourse");

            entity.HasOne(d => d.CreatedByPerson).WithMany(p => p.TCorporateGoals).HasConstraintName("FK_tCorporateGoal_tPerson");

            entity.HasOne(d => d.GoalObjectiveCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tGoalObjective");

            entity.HasOne(d => d.GoalTypeCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tGoalType");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tLanguage");

            entity.HasOne(d => d.ParentCorporateGoal).WithMany(p => p.InverseParentCorporateGoal).HasConstraintName("FK_tCorporateGoal_tCorporateGoal");

            entity.HasOne(d => d.PayoutCurrencyCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tCurrency");

            entity.HasOne(d => d.ReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TCorporateGoalReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tLanguageProficiency_Reading");

            entity.HasOne(d => d.SpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TCorporateGoalSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tLanguageProficiency_Spoken");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TCorporateGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tTrainingProgram");

            entity.HasOne(d => d.TranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TCorporateGoalTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tLanguageProficiency_Translation");

            entity.HasOne(d => d.WrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TCorporateGoalWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCorporateGoal_tLanguageProficiency_Written");
        });

        modelBuilder.Entity<TCostCenter>(entity =>
        {
            entity.Property(e => e.CostCenterDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCostCenter','CostCenterDescription',[CostCenterGUID]))", false);
        });

        modelBuilder.Entity<TCountry>(entity =>
        {
            entity.Property(e => e.CountryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCountry','CountryDescription',[CountryGUID]))", false);

            entity.HasOne(d => d.CountryCurrencyCodeNavigation).WithMany(p => p.TCountries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCountry_tCurrency");
        });

        modelBuilder.Entity<TCourse>(entity =>
        {
            entity.Property(e => e.CourseDetail).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCourse','CourseDetail',[CourseGUID]))", false);
            entity.Property(e => e.CourseTitle).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCourse','CourseTitle',[CourseGUID]))", false);

            entity.HasOne(d => d.CourseCompanyCodeNavigation).WithMany(p => p.TCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCompany_tCourse");

            entity.HasOne(d => d.CourseCurrencyCodeNavigation).WithMany(p => p.TCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCurrency_tCourse");

            entity.HasOne(d => d.CourseTypeCodeNavigation).WithMany(p => p.TCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourse_tCourseType");

            entity.HasOne(d => d.TrainingProviderCodeNavigation).WithMany(p => p.TCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourse_tTrainingProvider");
        });

        modelBuilder.Entity<TCourseCertification>(entity =>
        {
            entity.HasKey(e => e.CourseCertificationGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CourseCode, e.CertificationCode, e.AchievementFlag, e.PrerequisiteFlag }, "AK_tCourseCertification")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CourseCertificationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TCourseCertifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseCertification_tCertification");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCourseCertifications).HasConstraintName("FK_tCourseCertification_tCourse");
        });

        modelBuilder.Entity<TCourseCompetency>(entity =>
        {
            entity.HasKey(e => e.CourseCompetencyGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CourseCode, e.CompetencyCode, e.AchievementFlag, e.PrerequisiteFlag }, "AK_tCourseCompetency")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CourseCompetencyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TCourseCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseCompetency_tCompetency");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCourseCompetencies).HasConstraintName("FK_tCourseCompetency_tCourse");

            entity.HasOne(d => d.ProficiencyCodeNavigation).WithMany(p => p.TCourseCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseCompetency_tProficiency");
        });

        modelBuilder.Entity<TCourseCourse>(entity =>
        {
            entity.HasKey(e => e.CourseCourseGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CourseCode, e.ParentCourseCode, e.AchievementFlag, e.PrerequisiteFlag }, "AK_tCourseCourse")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CourseCourseGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCourseCourseCourseCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseCourse_tCourse_1");

            entity.HasOne(d => d.ParentCourseCodeNavigation).WithMany(p => p.TCourseCourseParentCourseCodeNavigations).HasConstraintName("FK_tCourseCourse_tCourse_2");
        });

        modelBuilder.Entity<TCourseLanguage>(entity =>
        {
            entity.HasKey(e => e.CourseLanguageGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CourseCode, e.LanguageCode, e.AchievementFlag, e.PrerequisiteFlag }, "AK_tCourseLanguage")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CourseLanguageGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCourseLanguages).HasConstraintName("FK_tCourseLanguage_tCourse");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TCourseLanguages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseLanguage_tLanguage");

            entity.HasOne(d => d.ReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TCourseLanguageReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseLanguage_tLanguageProficiency_Reading");

            entity.HasOne(d => d.SpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TCourseLanguageSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseLanguage_tLanguageProficiency_Spoken");

            entity.HasOne(d => d.TranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TCourseLanguageTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseLanguage_tLanguageProficiency_Translation");

            entity.HasOne(d => d.WrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TCourseLanguageWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseLanguage_tLanguageProficiency_Written");
        });

        modelBuilder.Entity<TCourseTrainingMaterial>(entity =>
        {
            entity.HasKey(e => e.CourseTrainingMaterialGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CourseCode, e.TrainingMaterialCode }, "AK_tCourseTrainingMaterial")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CourseTrainingMaterialGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCourseTrainingMaterials).HasConstraintName("FK_tCourseTrainingMaterial_tCourse");

            entity.HasOne(d => d.TrainingMaterialCodeNavigation).WithMany(p => p.TCourseTrainingMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseTrainingMaterial_tTrainingMaterial");
        });

        modelBuilder.Entity<TCourseTrainingResource>(entity =>
        {
            entity.HasKey(e => e.CourseTrainingResourceGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CourseCode, e.TrainingResourceCode }, "AK_tCourseTrainingResource")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CourseTrainingResourceGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TCourseTrainingResources).HasConstraintName("FK_tCourseTrainingResource_tCourse");

            entity.HasOne(d => d.TrainingResourceCodeNavigation).WithMany(p => p.TCourseTrainingResources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCourseTrainingResource_tTrainingResource");
        });

        modelBuilder.Entity<TCourseType>(entity =>
        {
            entity.Property(e => e.CourseTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCourseType','CourseTypeDescription',[CourseTypeGUID]))", false);
        });

        modelBuilder.Entity<TCurrency>(entity =>
        {
            entity.Property(e => e.CurrencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCurrency','CurrencyDescription',[CurrencyGUID]))", false);
        });

        modelBuilder.Entity<TCurrencyConversion>(entity =>
        {
            entity.HasKey(e => e.CurrencyConversionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CurrencyCode, e.EffectiveDate }, "AK_tCurrencyConversion")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CurrencyConversionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.TCurrencyConversions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tCurrencyConversion_tCurrency");
        });

        modelBuilder.Entity<TCustom1>(entity =>
        {
            entity.Property(e => e.Custom1Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom1','Custom1Description',[Custom1GUID]))", false);
        });

        modelBuilder.Entity<TCustom11>(entity =>
        {
            entity.Property(e => e.Custom11Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom11','Custom11Description',[Custom11GUID]))", false);
        });

        modelBuilder.Entity<TCustom12>(entity =>
        {
            entity.Property(e => e.Custom12Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom12','Custom12Description',[Custom12GUID]))", false);
        });

        modelBuilder.Entity<TCustom13>(entity =>
        {
            entity.Property(e => e.Custom13Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom13','Custom13Description',[Custom13GUID]))", false);
        });

        modelBuilder.Entity<TCustom14>(entity =>
        {
            entity.Property(e => e.Custom14Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom14','Custom14Description',[Custom14GUID]))", false);
        });

        modelBuilder.Entity<TCustom2>(entity =>
        {
            entity.Property(e => e.Custom2Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom2','Custom2Description',[Custom2GUID]))", false);
        });

        modelBuilder.Entity<TCustom3>(entity =>
        {
            entity.Property(e => e.Custom3Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom3','Custom3Description',[Custom3GUID]))", false);
        });

        modelBuilder.Entity<TCustom4>(entity =>
        {
            entity.Property(e => e.Custom4Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tCustom4','Custom4Description',[Custom4GUID]))", false);
        });

        modelBuilder.Entity<TDegree>(entity =>
        {
            entity.Property(e => e.DegreeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDegree','DegreeDescription',[DegreeGUID]))", false);
        });

        modelBuilder.Entity<TDeliveryMethod>(entity =>
        {
            entity.Property(e => e.DeliveryMethodDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDeliveryMethod','DeliveryMethodDescription',[DeliveryMethodGUID]))", false);
        });

        modelBuilder.Entity<TDepartment>(entity =>
        {
            entity.Property(e => e.DepartmentDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDepartment','DepartmentDescription',[DepartmentGUID]))", false);
        });

        modelBuilder.Entity<TDepartureReason>(entity =>
        {
            entity.Property(e => e.DepartureReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDepartureReason','DepartureReasonDescription',[DepartureReasonGUID]))", false);
        });

        modelBuilder.Entity<TDependent834Type>(entity =>
        {
            entity.Property(e => e.Dependent834TypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDependent834Type','Dependent834TypeDescription',[Dependent834TypeGUID]))", false);
        });

        modelBuilder.Entity<TDependentType>(entity =>
        {
            entity.Property(e => e.DependentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDependentType','DependentTypeDescription',[DependentTypeGUID]))", false);
        });

        modelBuilder.Entity<TDependentTypeRelationship>(entity =>
        {
            entity.HasKey(e => e.DependentTypeRelationshipGuid).IsClustered(false);

            entity.HasIndex(e => new { e.DependentTypeCode, e.RelationshipCode }, "AK_tDependentTypeRelationship")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.DependentTypeRelationshipGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DependentTypeCodeNavigation).WithMany(p => p.TDependentTypeRelationships)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tDependentTypeRelationship_tDependentType");

            entity.HasOne(d => d.RelationshipCodeNavigation).WithMany(p => p.TDependentTypeRelationships)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tDependentTypeRelationship_tRelationship");
        });

        modelBuilder.Entity<TDirectDepositAccountType>(entity =>
        {
            entity.Property(e => e.DirectDepositAccountTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDirectDepositAccountType','DirectDepositAccountTypeDescription',[DirectDepositAccountTypeGUID]))", false);
        });

        modelBuilder.Entity<TDisability>(entity =>
        {
            entity.Property(e => e.DisabilityDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDisability','DisabilityDescription',[DisabilityGUID]))", false);
        });

        modelBuilder.Entity<TDisciplineAction>(entity =>
        {
            entity.Property(e => e.DisciplineActionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDisciplineAction','DisciplineActionDescription',[DisciplineActionGUID]))", false);
        });

        modelBuilder.Entity<TDisciplinePrimaryPolicy>(entity =>
        {
            entity.Property(e => e.DisciplinePrimaryPolicyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDisciplinePrimaryPolicy','DisciplinePrimaryPolicyDescription',[DisciplinePrimaryPolicyGUID]))", false);
        });

        modelBuilder.Entity<TDisciplineReason>(entity =>
        {
            entity.Property(e => e.DisciplineReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDisciplineReason','DisciplineReasonDescription',[DisciplineReasonGUID]))", false);
        });

        modelBuilder.Entity<TDisciplineType>(entity =>
        {
            entity.Property(e => e.DisciplineTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDisciplineType','DisciplineTypeDescription',[DisciplineTypeGUID]))", false);
        });

        modelBuilder.Entity<TDivision>(entity =>
        {
            entity.Property(e => e.DivisionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDivision','DivisionDescription',[DivisionGUID]))", false);
        });

        modelBuilder.Entity<TDriverStatus>(entity =>
        {
            entity.Property(e => e.DriverStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDriverStatus','DriverStatusDescription',[DriverStatusGUID]))", false);
        });

        modelBuilder.Entity<TDrugTestReason>(entity =>
        {
            entity.Property(e => e.DrugTestReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDrugTestReason','DrugTestReasonDescription',[DrugTestReasonGUID]))", false);
        });

        modelBuilder.Entity<TDrugTestResult>(entity =>
        {
            entity.Property(e => e.DrugTestResultDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDrugTestResult','DrugTestResultDescription',[DrugTestResultGUID]))", false);
        });

        modelBuilder.Entity<TDrugTestType>(entity =>
        {
            entity.Property(e => e.DrugTestTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tDrugTestType','DrugTestTypeDescription',[DrugTestTypeGUID]))", false);
        });

        modelBuilder.Entity<TEducationStatus>(entity =>
        {
            entity.Property(e => e.EducationStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEducationStatus','EducationStatusDescription',[EducationStatusGUID]))", false);
        });

        modelBuilder.Entity<TEeacategory>(entity =>
        {
            entity.Property(e => e.EeacategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEEACategory','EEACategoryDescription',[EEACategoryGuid]))", false);
        });

        modelBuilder.Entity<TEeocategory>(entity =>
        {
            entity.Property(e => e.EeocategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEEOCategory','EEOCategoryDescription',[EEOCategoryGUID]))", false);
        });

        modelBuilder.Entity<TEmploymentContract>(entity =>
        {
            entity.Property(e => e.EmploymentContractDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEmploymentContract','EmploymentContractDescription',[EmploymentContractGUID]))", false);

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.TEmploymentContracts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tEmploymentContract_tCompany");
        });

        modelBuilder.Entity<TEmploymentDocument>(entity =>
        {
            entity.Property(e => e.EmploymentDocumentDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEmploymentDocument','EmploymentDocumentDescription',[EmploymentDocumentGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TEthnicGroup>(entity =>
        {
            entity.Property(e => e.EthnicGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEthnicGroup','EthnicGroupDescription',[EthnicGroupGUID]))", false);
        });

        modelBuilder.Entity<TEvaluationResult>(entity =>
        {
            entity.Property(e => e.EvaluationResultDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEvaluationResult','EvaluationResultDescription',[EvaluationResultGUID]))", false);
        });

        modelBuilder.Entity<TEvaluationType>(entity =>
        {
            entity.Property(e => e.EvaluationTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEvaluationType','EvaluationTypeDescription',[EvaluationTypeGUID]))", false);
        });

        modelBuilder.Entity<TEvaluator>(entity =>
        {
            entity.Property(e => e.EvaluatorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEvaluator','EvaluatorDescription',[EvaluatorGUID]))", false);
        });

        modelBuilder.Entity<TEventType>(entity =>
        {
            entity.Property(e => e.EventTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tEventType','EventTypeDescription',[EventTypeGUID]))", false);
        });

        modelBuilder.Entity<TExpenseType>(entity =>
        {
            entity.Property(e => e.ExpenseTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tExpenseType','ExpenseTypeDescription',[ExpenseTypeGUID]))", false);
        });

        modelBuilder.Entity<TExportTriggerAction>(entity =>
        {
            entity.Property(e => e.ExportTriggerActionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tExportTriggerAction','ExportTriggerActionDescription',[ExportTriggerActionGUID]))", false);
        });

        modelBuilder.Entity<TExportTriggerStatus>(entity =>
        {
            entity.Property(e => e.ExportTriggerStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tExportTriggerStatus','ExportTriggerStatusDescription',[ExportTriggerStatusGUID]))", false);
        });

        modelBuilder.Entity<TExternalRecruiter>(entity =>
        {
            entity.Property(e => e.ExternalRecruiterDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tExternalRecruiter','ExternalRecruiterDescription',[ExternalRecruiterGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TExternalRecruiters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tExternalRecruiter_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TExternalRecruiters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tExternalRecruiter_tStateProvince");
        });

        modelBuilder.Entity<TFacility>(entity =>
        {
            entity.Property(e => e.FacilityDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFacility','FacilityDescription',[FacilityGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tFacility_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tFacility_tStateProvince");

            entity.HasOne(d => d.TimeZoneCodeNavigation).WithMany(p => p.TFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tFacility_tTimeZone");

            entity.HasOne(d => d.TrainingProviderCodeNavigation).WithMany(p => p.TFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tFacility_tTrainingProvider");
        });

        modelBuilder.Entity<TFamilyStatus>(entity =>
        {
            entity.Property(e => e.FamilyStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFamilyStatus','FamilyStatusDescription',[FamilyStatusGUID]))", false);
        });

        modelBuilder.Entity<TFileAttachmentType>(entity =>
        {
            entity.Property(e => e.FileAttachmentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFileAttachmentType','FileAttachmentTypeDescription',[FileAttachmentTypeGUID]))", false);
        });

        modelBuilder.Entity<TFormType>(entity =>
        {
            entity.HasKey(e => e.FormTypeCode).HasName("PK_tForm");

            entity.Property(e => e.FormTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFormType','FormTypeDescription',[FormTypeGUID]))", false);
        });

        modelBuilder.Entity<TFrequency>(entity =>
        {
            entity.Property(e => e.FrequencyAdjective).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFrequency','FrequencyAdjective',[FrequencyGUID]))", false);
            entity.Property(e => e.FrequencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFrequency','FrequencyDescription',[FrequencyGUID]))", false);
        });

        modelBuilder.Entity<TFrequencyConversion>(entity =>
        {
            entity.HasKey(e => e.FrequencyConversionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.FromFrequencyCode, e.ToFrequencyCode, e.ScheduleCode }, "AK_tFrequencyConversion")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.FrequencyConversionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.FromFrequencyCodeNavigation).WithMany(p => p.TFrequencyConversionFromFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tFrequencyConversion_From_tFrequency");

            entity.HasOne(d => d.ScheduleCodeNavigation).WithMany(p => p.TFrequencyConversions).HasConstraintName("FK_tFrequencyConversion_tSchedule");

            entity.HasOne(d => d.ToFrequencyCodeNavigation).WithMany(p => p.TFrequencyConversionToFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tFrequencyConversion_To_tFrequency");
        });

        modelBuilder.Entity<TFunctionalArea>(entity =>
        {
            entity.Property(e => e.FunctionalAreaDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFunctionalArea','FunctionalAreaDescription',[FunctionalAreaGUID]))", false);
        });

        modelBuilder.Entity<TFundingSource>(entity =>
        {
            entity.Property(e => e.FundingSourceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tFundingSource','FundingSourceDescription',[FundingSourceGUID]))", false);
        });

        modelBuilder.Entity<TGender>(entity =>
        {
            entity.Property(e => e.GenderDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tGender','GenderDescription',[GenderGUID]))", false);
        });

        modelBuilder.Entity<TGeographicArea>(entity =>
        {
            entity.Property(e => e.GeographicAreaDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tGeographicArea','GeographicAreaDescription',[GeographicAreaGUID]))", false);
            entity.Property(e => e.SurveyAdjustmentFactor).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TGoalObjective>(entity =>
        {
            entity.Property(e => e.GoalObjectiveDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tGoalObjective','GoalObjectiveDescription',[GoalObjectiveGUID]))", false);
        });

        modelBuilder.Entity<TGoalType>(entity =>
        {
            entity.Property(e => e.GoalTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tGoalType','GoalTypeDescription',[GoalTypeGUID]))", false);
        });

        modelBuilder.Entity<TGovFormAdditionalFile>(entity =>
        {
            entity.Property(e => e.GovFormAdditionalFileGuid).ValueGeneratedNever();
            entity.Property(e => e.GovFormAdditionalFileDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tGovFormAdditionalFile','GovFormAdditionalFileDescription',[GovFormAdditionalFileGUID]))", false);

            entity.HasOne(d => d.FormTypeCodeNavigation).WithMany(p => p.TGovFormAdditionalFiles).HasConstraintName("FK_tGovFormAdditionalFile_FormTypeCode");
        });

        modelBuilder.Entity<TGradeHist>(entity =>
        {
            entity.HasKey(e => e.GradeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.GradeCode, e.GradeLocationCode, e.Step, e.GradeStartDate }, "AK_tGradeHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.GradeGuid).ValueGeneratedNever();
            entity.Property(e => e.Step).HasDefaultValueSql("('-')");

            entity.HasOne(d => d.GradeCurrencyCodeNavigation).WithMany(p => p.TGradeHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tGradeHist_tCurrency");

            entity.HasOne(d => d.GradeFrequencyCodeNavigation).WithMany(p => p.TGradeHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tGradeHist_tFrequency");

            entity.HasOne(d => d.GradeLocationCodeNavigation).WithMany(p => p.TGradeHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tGradeHist_tLocation");
        });

        modelBuilder.Entity<THealthAndSafetyChecklist>(entity =>
        {
            entity.Property(e => e.HealthAndSafetyChecklistDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tHealthAndSafetyChecklist','HealthAndSafetyChecklistDescription',[HealthAndSafetyChecklistGUID]))", false);

            entity.HasOne(d => d.EmployeePerson).WithMany(p => p.THealthAndSafetyChecklistEmployeePeople).HasConstraintName("FK_tHealthAndSafetyChecklist_tPerson_Employee");

            entity.HasOne(d => d.PersonWhoCompletedChecklistPerson).WithMany(p => p.THealthAndSafetyChecklistPersonWhoCompletedChecklistPeople).HasConstraintName("FK_tHealthAndSafetyChecklist_tPerson");
        });

        modelBuilder.Entity<THealthAndSafetyChecklistDetail>(entity =>
        {
            entity.Property(e => e.HealthAndSafetyChecklistDetailGuid).ValueGeneratedNever();

            entity.HasOne(d => d.HealthAndSafetyChecklistCodeNavigation).WithMany(p => p.THealthAndSafetyChecklistDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tHealthAndSafetyChecklist_tHealthAndSafetyChecklistDetail");

            entity.HasOne(d => d.HealthAndSafetyChecklistQuestionCodeNavigation).WithMany(p => p.THealthAndSafetyChecklistDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tHealthAndSafetyChecklistQuestion_tHealthAndSafetyChecklistDetail");
        });

        modelBuilder.Entity<THealthAndSafetyChecklistQuestion>(entity =>
        {
            entity.HasKey(e => e.HealthAndSafetyChecklistQuestionCode).IsClustered(false);

            entity.HasIndex(e => new { e.HealthAndSafetyChecklistQuestionCategoryCode, e.HealthAndSafetyChecklistQuestionSubCategoryCode }, "CIX_tHealthAndSafetyChecklistQuestion_Category_SubCategory").IsClustered();

            entity.Property(e => e.HealthAndSafetyChecklistQuestionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tHealthAndSafetyChecklistQuestion','HealthAndSafetyChecklistQuestionDescription',[HealthAndSafetyChecklistQuestionGUID]))", false);

            entity.HasOne(d => d.HealthAndSafetyChecklistQuestionCategoryCodeNavigation).WithMany(p => p.THealthAndSafetyChecklistQuestionHealthAndSafetyChecklistQuestionCategoryCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tHealthAndSafetyChecklistQuestion_tHealthAndSafetyChecklistQuestionCategory");

            entity.HasOne(d => d.HealthAndSafetyChecklistQuestionSubCategoryCodeNavigation).WithMany(p => p.THealthAndSafetyChecklistQuestionHealthAndSafetyChecklistQuestionSubCategoryCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tHealthAndSafetyChecklistQuestion_tHealthAndSafetyChecklistQuestionCategory_SubCategory");
        });

        modelBuilder.Entity<THealthAndSafetyChecklistQuestionCategory>(entity =>
        {
            entity.Property(e => e.HealthAndSafetyChecklistQuestionCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tHealthAndSafetyChecklistQuestionCategory','HealthAndSafetyChecklistQuestionCategoryDescription',[HealthAndSafetyChecklistQuestionCategoryGUID]))", false);
        });

        modelBuilder.Entity<THireSource>(entity =>
        {
            entity.Property(e => e.HireSourceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tHireSource','HireSourceDescription',[HireSourceGUID]))", false);
        });

        modelBuilder.Entity<THoliday>(entity =>
        {
            entity.Property(e => e.HolidayDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tHoliday','HolidayDescription',[HolidayGUID]))", false);
        });

        modelBuilder.Entity<THolidayOccurrence>(entity =>
        {
            entity.HasKey(e => e.HolidayOccurrenceGuid).IsClustered(false);

            entity.HasIndex(e => new { e.HolidayCode, e.HolidayDate }, "AK_tHolidayOccurrence")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.HolidayOccurrenceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.HolidayCodeNavigation).WithMany(p => p.THolidayOccurrences).HasConstraintName("FK_tHolidayOccurrence_tHoliday");
        });

        modelBuilder.Entity<THowAcquired>(entity =>
        {
            entity.Property(e => e.HowAcquiredDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tHowAcquired','HowAcquiredDescription',[HowAcquiredGUID]))", false);
        });

        modelBuilder.Entity<TIllnessInjury>(entity =>
        {
            entity.Property(e => e.IllnessInjuryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tIllnessInjury','IllnessInjuryDescription',[IllnessInjuryGUID]))", false);

            entity.HasOne(d => d.IllnessTypeCodeNavigation).WithMany(p => p.TIllnessInjuries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIllnessInjury_tIllnessType");
        });

        modelBuilder.Entity<TIllnessInjuryStatus>(entity =>
        {
            entity.Property(e => e.IllnessInjuryStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tIllnessInjuryStatus','IllnessInjuryStatusDescription',[IllnessInjuryStatusGUID]))", false);
        });

        modelBuilder.Entity<TIllnessType>(entity =>
        {
            entity.Property(e => e.IllnessTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tIllnessType','IllnessTypeDescription',[IllnessTypeGUID]))", false);
        });

        modelBuilder.Entity<TIncident>(entity =>
        {
            entity.HasKey(e => e.IncidentGuid).IsClustered(false);

            entity.HasIndex(e => e.IncidentId, "AK_tIncident").IsClustered();

            entity.Property(e => e.IncidentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tCompany");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tCountry");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tDepartment");

            entity.HasOne(d => d.IncidentTypeCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tIncidentType");

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tLocation");

            entity.HasOne(d => d.OccupationalIncidentTypeCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tOccupationalIncidentType");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tIncident_tStateProvince");

            entity.HasOne(d => d.SupervisorOnLocationPerson).WithMany(p => p.TIncidents).HasConstraintName("FK_tIncident_tSupervisorOnLocationPerson");
        });

        modelBuilder.Entity<TIncidentType>(entity =>
        {
            entity.Property(e => e.IncidentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tIncidentType','IncidentTypeDescription',[IncidentTypeGUID]))", false);
        });

        modelBuilder.Entity<TIndustrySector>(entity =>
        {
            entity.Property(e => e.IndustrySectorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tIndustrySector','IndustrySectorDescription',[IndustrySectorGUID]))", false);
            entity.Property(e => e.SurveyAdjustmentFactor).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TInstructor>(entity =>
        {
            entity.Property(e => e.InstructorName).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tInstructor','InstructorName',[InstructorGUID]))", false);

            entity.HasOne(d => d.TrainingProviderCodeNavigation).WithMany(p => p.TInstructors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tInstructor_tTrainingProvider");
        });

        modelBuilder.Entity<TInternationalType>(entity =>
        {
            entity.Property(e => e.InternationalTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tInternationalType','InternationalTypeDescription',[InternationalTypeGUID]))", false);
        });

        modelBuilder.Entity<TJob>(entity =>
        {
            entity.Property(e => e.JobTitle).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJob','JobTitle',[JobGUID]))", false);

            entity.HasOne(d => d.EeacategoryCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tEEACategory");

            entity.HasOne(d => d.EeocategoryCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tEEOCategory");

            entity.HasOne(d => d.JobCategoryCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tJobCategory");

            entity.HasOne(d => d.JobFamilyCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tJobFamily");

            entity.HasOne(d => d.JobGroupCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tJobGroup");

            entity.HasOne(d => d.JobReportsToJobCodeNavigation).WithMany(p => p.InverseJobReportsToJobCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tJob");

            entity.HasOne(d => d.OrgPublisherPositionTypeCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tOrgPublisherPositionType");

            entity.HasOne(d => d.OvertimeStatusCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tOvertimeStatus");

            entity.HasOne(d => d.WorkersCompensationCodeNavigation).WithMany(p => p.TJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJob_tWorkersCompensation");
        });

        modelBuilder.Entity<TJobCategory>(entity =>
        {
            entity.Property(e => e.JobCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobCategory','JobCategoryDescription',[JobCategoryGUID]))", false);
        });

        modelBuilder.Entity<TJobCertification>(entity =>
        {
            entity.HasKey(e => e.JobCertificationGuid).IsClustered(false);

            entity.HasIndex(e => e.JobCode, "CIX_tJobCertification_JobCode").IsClustered();

            entity.Property(e => e.JobCertificationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TJobCertifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobCertification_tCertification");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TJobCertifications).HasConstraintName("FK_tJobCertification_tJob");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TJobCertifications).HasConstraintName("FK_tJobCertification_tPosition");
        });

        modelBuilder.Entity<TJobCompetency>(entity =>
        {
            entity.HasKey(e => e.JobCompetencyGuid).IsClustered(false);

            entity.HasIndex(e => e.JobCode, "CIX_tJobCompetency_JobCode").IsClustered();

            entity.Property(e => e.JobCompetencyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TJobCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobCompetency_tCompetency");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TJobCompetencies).HasConstraintName("FK_tJobCompetency_tJob");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TJobCompetencies).HasConstraintName("FK_tJobCompetency_tPosition");

            entity.HasOne(d => d.ProficiencyCodeNavigation).WithMany(p => p.TJobCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobCompetency_tProficiency");
        });

        modelBuilder.Entity<TJobCourse>(entity =>
        {
            entity.HasKey(e => e.JobCourseGuid).IsClustered(false);

            entity.HasIndex(e => e.JobCode, "CIX_tJobCourse_JobCode").IsClustered();

            entity.Property(e => e.JobCourseGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TJobCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobCourse_tCourse");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TJobCourses).HasConstraintName("FK_tJobCourse_tJob");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TJobCourses).HasConstraintName("FK_tJobCourse_tPosition");
        });

        modelBuilder.Entity<TJobDescription>(entity =>
        {
            entity.HasKey(e => e.JobDescriptionGuid).IsClustered(false);

            entity.HasIndex(e => e.JobCode, "CIX_tJobDescription_JobCode").IsClustered();

            entity.Property(e => e.JobDescriptionGuid).ValueGeneratedNever();
            entity.Property(e => e.CertificationsRequired).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','CertificationsRequired',[JobDescriptionGUID]))", false);
            entity.Property(e => e.DesiredDegree).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','DesiredDegree',[JobDescriptionGUID]))", false);
            entity.Property(e => e.DesiredEducation).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','DesiredEducation',[JobDescriptionGUID]))", false);
            entity.Property(e => e.DesiredJobExperience).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','DesiredJobExperience',[JobDescriptionGUID]))", false);
            entity.Property(e => e.DesiredMajor).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','DesiredMajor',[JobDescriptionGUID]))", false);
            entity.Property(e => e.EssentialFunctions).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','EssentialFunctions',[JobDescriptionGUID]))", false);
            entity.Property(e => e.MinimumPhysicalRequirements).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','MinimumPhysicalRequirements',[JobDescriptionGUID]))", false);
            entity.Property(e => e.OtherQualifications).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','OtherQualifications',[JobDescriptionGUID]))", false);
            entity.Property(e => e.PrimaryResponsibilities).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','PrimaryResponsibilities',[JobDescriptionGUID]))", false);
            entity.Property(e => e.TasksPerformed).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobDescription','TasksPerformed',[JobDescriptionGUID]))", false);

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TJobDescriptions).HasConstraintName("FK_tJobDescription_tJob");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TJobDescriptions).HasConstraintName("FK_tJobDescription_tPosition");
        });

        modelBuilder.Entity<TJobFamily>(entity =>
        {
            entity.Property(e => e.JobFamilyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobFamily','JobFamilyDescription',[JobFamilyGUID]))", false);
        });

        modelBuilder.Entity<TJobGroup>(entity =>
        {
            entity.Property(e => e.JobGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobGroup','JobGroupDescription',[JobGroupGUID]))", false);
        });

        modelBuilder.Entity<TJobLanguage>(entity =>
        {
            entity.HasKey(e => e.JobLanguageGuid).IsClustered(false);

            entity.HasIndex(e => e.JobCode, "CIX_tJobLanguage_JobCode").IsClustered();

            entity.Property(e => e.JobLanguageGuid).ValueGeneratedNever();

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TJobLanguages).HasConstraintName("FK_tJobLanguage_tJob");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TJobLanguages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobLanguage_tLanguage");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TJobLanguages).HasConstraintName("FK_tJobLanguage_tPosition");

            entity.HasOne(d => d.ReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TJobLanguageReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobLanguage_tLanguageProficiency_Reading");

            entity.HasOne(d => d.SpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TJobLanguageSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobLanguage_tLanguageProficiency_Spoken");

            entity.HasOne(d => d.TranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TJobLanguageTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobLanguage_tLanguageProficiency_Translation");

            entity.HasOne(d => d.WrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TJobLanguageWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobLanguage_tLanguageProficiency_Written");
        });

        modelBuilder.Entity<TJobReason>(entity =>
        {
            entity.Property(e => e.JobReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tJobReason','JobReasonDescription',[JobReasonGUID]))", false);
        });

        modelBuilder.Entity<TJobTrainingProgram>(entity =>
        {
            entity.Property(e => e.JobTrainingProgramGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TJobTrainingPrograms).HasConstraintName("FK_tJobTrainingProgram_tJob");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TJobTrainingPrograms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobTrainingProgram_tPosition");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TJobTrainingPrograms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tJobTrainingProgram_tTrainingProgram");
        });

        modelBuilder.Entity<TLanguage>(entity =>
        {
            entity.Property(e => e.LanguageDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLanguage','LanguageDescription',[LanguageGUID]))", false);
        });

        modelBuilder.Entity<TLanguageProficiency>(entity =>
        {
            entity.Property(e => e.LanguageProficiencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLanguageProficiency','LanguageProficiencyDescription',[LanguageProficiencyGUID]))", false);
        });

        modelBuilder.Entity<TLeaveReason>(entity =>
        {
            entity.Property(e => e.LeaveReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLeaveReason','LeaveReasonDescription',[LeaveReasonGUID]))", false);
        });

        modelBuilder.Entity<TLeaveType>(entity =>
        {
            entity.Property(e => e.LeaveTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLeaveType','LeaveTypeDescription',[LeaveTypeGUID]))", false);

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.TLeaveTypes).HasConstraintName("FK_tLeaveTypeCSF_USysCSF");
        });

        modelBuilder.Entity<TLifeEventStatus>(entity =>
        {
            entity.Property(e => e.LifeEventStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLifeEventStatus','LifeEventStatusDescription',[LifeEventStatusGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TLifeEventType>(entity =>
        {
            entity.Property(e => e.LifeEventTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLifeEventType','LifeEventTypeDescription',[LifeEventTypeGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupTemplateNavigation).WithMany(p => p.TLifeEventTypes).HasConstraintName("FK_tLifeEventType_tBenefitOpenEnrollmentGroup");
        });

        modelBuilder.Entity<TLocation>(entity =>
        {
            entity.Property(e => e.LocationDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLocation','LocationDescription',[LocationGUID]))", false);

            entity.HasOne(d => d.CensusMetropolitanAreaCodeNavigation).WithMany(p => p.TLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLocation_tCensusMetropolitanArea");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLocation_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TLocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tLocation_tStateProvince");
        });

        modelBuilder.Entity<TLocationReason>(entity =>
        {
            entity.Property(e => e.LocationReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tLocationReason','LocationReasonDescription',[LocationReasonGUID]))", false);
        });

        modelBuilder.Entity<TMajor>(entity =>
        {
            entity.Property(e => e.MajorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMajor','MajorDescription',[MajorGUID]))", false);
        });

        modelBuilder.Entity<TMassChange>(entity =>
        {
            entity.HasKey(e => e.MassChangeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserFullName, e.MassChangeDateTime }, "AK_tMassChange")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.MassChangeGuid).ValueGeneratedNever();
            entity.Property(e => e.ChangeType).IsFixedLength();
            entity.Property(e => e.MassChangeDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.MassChangeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMassChange','MassChangeDescription',[MassChangeGUID]))", false);

            entity.HasOne(d => d.MassChangeReasonCodeNavigation).WithMany(p => p.TMassChanges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMassChange_tMassChangeReason");
        });

        modelBuilder.Entity<TMassChangeField>(entity =>
        {
            entity.HasKey(e => e.MassChangeFieldGuid).IsClustered(false);

            entity.HasIndex(e => e.MassChangeOperationGuid, "CIX_tMassChangeField_MassChangeOperationGUID").IsClustered();

            entity.Property(e => e.MassChangeFieldGuid).ValueGeneratedNever();

            entity.HasOne(d => d.MassChangeOperation).WithMany(p => p.TMassChangeFields).HasConstraintName("FK_tMassChangeField_tMassChangeOperation");
        });

        modelBuilder.Entity<TMassChangeOperation>(entity =>
        {
            entity.HasKey(e => e.MassChangeOperationGuid).IsClustered(false);

            entity.HasIndex(e => e.MassChangeGuid, "CIX_tMassChangeOperation_MassChangeGUID").IsClustered();

            entity.Property(e => e.MassChangeOperationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.MassChange).WithMany(p => p.TMassChangeOperations).HasConstraintName("FK_tMassChangeOperation_tMassChange");

            entity.HasOne(d => d.Person).WithMany(p => p.TMassChangeOperations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tMassChangeOperation_tPerson");
        });

        modelBuilder.Entity<TMassChangeReason>(entity =>
        {
            entity.Property(e => e.MassChangeReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMassChangeReason','MassChangeReasonDescription',[MassChangeReasonGUID]))", false);
        });

        modelBuilder.Entity<TMedicalFacility>(entity =>
        {
            entity.Property(e => e.Name).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMedicalFacility','Name',[MedicalFacilityGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TMedicalFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMedicalFacility_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TMedicalFacilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tMedicalFacility_tStateProvince");
        });

        modelBuilder.Entity<TMilitaryBranch>(entity =>
        {
            entity.Property(e => e.MilitaryBranchDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMilitaryBranch','MilitaryBranchDescription',[MilitaryBranchGUID]))", false);
        });

        modelBuilder.Entity<TMilitaryConflict>(entity =>
        {
            entity.Property(e => e.MilitaryConflictDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMilitaryConflict','MilitaryConflictDescription',[MilitaryConflictGUID]))", false);
        });

        modelBuilder.Entity<TMilitaryStatus>(entity =>
        {
            entity.Property(e => e.MilitaryStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMilitaryStatus','MilitaryStatusDescription',[MilitaryStatusGUID]))", false);
        });

        modelBuilder.Entity<TMobilityStatus>(entity =>
        {
            entity.Property(e => e.MobilityStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tMobilityStatus','MobilityStatusDescription',[MobilityStatusGUID]))", false);
        });

        modelBuilder.Entity<TNameType>(entity =>
        {
            entity.Property(e => e.NameTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tNameType','NameTypeDescription',[NameTypeGUID]))", false);
        });

        modelBuilder.Entity<TNominationQuestion>(entity =>
        {
            entity.HasKey(e => e.NominationQuestionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.NominationQuestionSectionCode, e.QuestionSortOrder }, "CIX_tNominationQuestion").IsClustered();

            entity.Property(e => e.NominationQuestionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.NominationQuestionSectionCodeNavigation).WithMany(p => p.TNominationQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tNominationQuestion_tNominationQuestionSection");
        });

        modelBuilder.Entity<TNominationQuestionSection>(entity =>
        {
            entity.Property(e => e.NominationQuestionSectionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tNominationQuestionSection','NominationQuestionSectionDescription',[NominationQuestionSectionGUID]))", false);
        });

        modelBuilder.Entity<TNoteType>(entity =>
        {
            entity.Property(e => e.NoteTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tNoteType','NoteTypeDescription',[NoteTypeGUID]))", false);
        });

        modelBuilder.Entity<TNoticePeriodEmployerIndicator>(entity =>
        {
            entity.Property(e => e.NoticePeriodEmployerIndicatorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tNoticePeriodEmployerIndicator','NoticePeriodEmployerIndicatorDescription',[NoticePeriodEmployerIndicatorGUID]))", false);
        });

        modelBuilder.Entity<TOccupationalIllnessCategory>(entity =>
        {
            entity.Property(e => e.OccupationalIllnessCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOccupationalIllnessCategory','OccupationalIllnessCategoryDescription',[OccupationalIllnessCategoryGUID]))", false);
        });

        modelBuilder.Entity<TOccupationalIncidentType>(entity =>
        {
            entity.Property(e => e.OccupationalIncidentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOccupationalIncidentType','OccupationalIncidentTypeDescription',[OccupationalIncidentTypeGUID]))", false);
        });

        modelBuilder.Entity<TOfferType>(entity =>
        {
            entity.Property(e => e.OfferTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOfferType','OfferTypeDescription',[OfferTypeGUID]))", false);
        });

        modelBuilder.Entity<TOrgPublisherPositionType>(entity =>
        {
            entity.Property(e => e.OrgPublisherPositionTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOrgPublisherPositionType','OrgPublisherPositionTypeDescription',[OrgPublisherPositionTypeGUID]))", false);
        });

        modelBuilder.Entity<TOrganizationUnit>(entity =>
        {
            entity.Property(e => e.OrganizationUnitDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOrganizationUnit','OrganizationUnitDescription',[OrganizationUnitGUID]))", false);

            entity.HasOne(d => d.OrganizationUnitLevelCodeNavigation).WithMany(p => p.TOrganizationUnits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tOrganizationUnit_tOrganizationUnitLevel");

            entity.HasOne(d => d.ParentOrganizationUnitCodeNavigation).WithMany(p => p.InverseParentOrganizationUnitCodeNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tOrganizationUnit_tOrganizationUnit");
        });

        modelBuilder.Entity<TOrganizationUnitLevel>(entity =>
        {
            entity.Property(e => e.OrganizationUnitLevelDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOrganizationUnitLevel','OrganizationUnitLevelDescription',[OrganizationUnitLevelGUID]))", false);
        });

        modelBuilder.Entity<TOtherPayReason>(entity =>
        {
            entity.Property(e => e.OtherPayReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOtherPayReason','OtherPayReasonDescription',[OtherPayReasonGUID]))", false);
        });

        modelBuilder.Entity<TOtherPayType>(entity =>
        {
            entity.Property(e => e.OtherPayTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOtherPayType','OtherPayTypeDescription',[OtherPayTypeGUID]))", false);
        });

        modelBuilder.Entity<TOvertimeRule>(entity =>
        {
            entity.Property(e => e.OvertimeRuleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOvertimeRule','OvertimeRuleDescription',[OvertimeRuleGUID]))", false);
        });

        modelBuilder.Entity<TOvertimeRuleDetail>(entity =>
        {
            entity.HasKey(e => e.OvertimeRuleDetailGuid).IsClustered(false);

            entity.HasIndex(e => e.OvertimeRuleCode, "CIX_tOvertimeRuleDays_OvertimeRuleCode").IsClustered();

            entity.Property(e => e.OvertimeRuleDetailGuid).ValueGeneratedNever();

            entity.HasOne(d => d.OvertimeRuleCodeNavigation).WithMany(p => p.TOvertimeRuleDetails).HasConstraintName("FK_tOvertimeRuleDetail_tOvertimeRule");

            entity.HasOne(d => d.ToTimeTypeCodeNavigation).WithMany(p => p.TOvertimeRuleDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tOvertimeRuleDetail_tTimeType");
        });

        modelBuilder.Entity<TOvertimeStatus>(entity =>
        {
            entity.Property(e => e.OvertimeStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tOvertimeStatus','OvertimeStatusDescription',[OvertimeStatusGUID]))", false);
        });

        modelBuilder.Entity<TPayStub>(entity =>
        {
            entity.Property(e => e.PayStubDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayStub','PayStubDescription',[PayStubGUID]))", false);
        });

        modelBuilder.Entity<TPayStubLayout>(entity =>
        {
            entity.Property(e => e.PayStubLayoutGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PayStubCodeNavigation).WithMany(p => p.TPayStubLayouts).HasConstraintName("FK_tPayStubLayout_tPayStub");
        });

        modelBuilder.Entity<TPayStubNote>(entity =>
        {
            entity.Property(e => e.PayStubNoteGuid).ValueGeneratedNever();
            entity.Property(e => e.NoteText).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayStubNote','NoteText',[PayStubNoteGUID]))", false);
        });

        modelBuilder.Entity<TPayroll>(entity =>
        {
            entity.Property(e => e.PayrollDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayroll','PayrollDescription',[PayrollGUID]))", false);
        });

        modelBuilder.Entity<TPayrollAccumulator>(entity =>
        {
            entity.Property(e => e.PayrollAccumulatorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayrollAccumulator','PayrollAccumulatorDescription',[PayrollAccumulatorGUID]))", false);
        });

        modelBuilder.Entity<TPayrollAccumulatorRollup>(entity =>
        {
            entity.Property(e => e.PayrollAccumulatorRollupGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PayrollAccumulatorCodeNavigation).WithMany(p => p.TPayrollAccumulatorRollups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPayrollAccumulatorRollup_tPayrollAccumulator");

            entity.HasOne(d => d.PayrollVendorCompanyAccumulator).WithMany(p => p.TPayrollAccumulatorRollups).HasConstraintName("FK_tPayrollAccumulatorRollup_tPayrollVendorCompanyAccumulator");
        });

        modelBuilder.Entity<TPayrollVendorAccumulatorFrequency>(entity =>
        {
            entity.Property(e => e.PayrollVendorAccumulatorFrequencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayrollVendorAccumulatorFrequency','PayrollVendorAccumulatorFrequencyDescription',[PayrollVendorAccumulatorFrequencyGUID]))", false);
        });

        modelBuilder.Entity<TPayrollVendorAccumulatorType>(entity =>
        {
            entity.Property(e => e.PayrollVendorAccumulatorTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayrollVendorAccumulatorType','PayrollVendorAccumulatorTypeDescription',[PayrollVendorAccumulatorTypeGUID]))", false);

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.TPayrollVendorAccumulatorTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPayrollVendorAccumulatorType_tCurrency");
        });

        modelBuilder.Entity<TPayrollVendorCompany>(entity =>
        {
            entity.Property(e => e.PayrollVendorCompanyGuid).ValueGeneratedNever();
            entity.Property(e => e.PayrollVendorCompanyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayrollVendorCompany','PayrollVendorCompanyDescription',[PayrollVendorCompanyGUID]))", false);

            entity.HasOne(d => d.PayrollCodeNavigation).WithMany(p => p.TPayrollVendorCompanies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPayrollVendorCompany_PayrollCode");

            entity.HasOne(d => d.VendorCodeNavigation).WithMany(p => p.TPayrollVendorCompanies).HasConstraintName("FK_tPayrollVendorCompany_tVendor");
        });

        modelBuilder.Entity<TPayrollVendorCompanyAccumulator>(entity =>
        {
            entity.Property(e => e.PayrollVendorCompanyAccumulatorGuid).ValueGeneratedNever();
            entity.Property(e => e.PayrollVendorCompanyAccumulatorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPayrollVendorCompanyAccumulator','PayrollVendorCompanyAccumulatorDescription',[PayrollVendorCompanyAccumulatorGUID]))", false);

            entity.HasOne(d => d.PayrollVendorAccumulatorFrequencyCodeNavigation).WithMany(p => p.TPayrollVendorCompanyAccumulators)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPayrollVendorCompanyAccumulator_tPayrollVendorAccumulatorFrequency");

            entity.HasOne(d => d.PayrollVendorAccumulatorTypeCodeNavigation).WithMany(p => p.TPayrollVendorCompanyAccumulators)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPayrollVendorCompanyAccumulator_tPayrollVendorAccumulatorType");

            entity.HasOne(d => d.PayrollVendorCompany).WithMany(p => p.TPayrollVendorCompanyAccumulators).HasConstraintName("FK_tPayrollVendorCompanyAccumulator_tPayrollVendorCompany");
        });

        modelBuilder.Entity<TPerformanceAssessment>(entity =>
        {
            entity.Property(e => e.PerformanceAssessmentDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceAssessment','PerformanceAssessmentDescription',[PerformanceAssessmentGUID]))", false);

            entity.HasOne(d => d.PerformanceAssessmentTypeCodeNavigation).WithMany(p => p.TPerformanceAssessments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceAssessment_tPerformanceAssessmentType");
        });

        modelBuilder.Entity<TPerformanceAssessmentType>(entity =>
        {
            entity.Property(e => e.PerformanceAssessmentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceAssessmentType','PerformanceAssessmentTypeDescription',[PerformanceAssessmentTypeGUID]))", false);
        });

        modelBuilder.Entity<TPerformanceParticipant>(entity =>
        {
            entity.Property(e => e.PerformanceParticipantGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPerformanceParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceParticipant_tCountry");

            entity.HasOne(d => d.PerformanceParticipantTypeCodeNavigation).WithMany(p => p.TPerformanceParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceParticipant_tPerformanceParticipantType");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPerformanceParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceParticipant_tStateProvince");
        });

        modelBuilder.Entity<TPerformanceParticipantRuleType>(entity =>
        {
            entity.Property(e => e.PerformanceParticipantRuleTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceParticipantRuleType','PerformanceParticipantRuleTypeDescription',[PerformanceParticipantRuleTypeGUID]))", false);
        });

        modelBuilder.Entity<TPerformanceParticipantType>(entity =>
        {
            entity.HasKey(e => e.PerformanceParticipantTypeCode).HasName("PK_tPerformanceParticipantTypeCode");

            entity.Property(e => e.PerformanceParticipantTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceParticipantType','PerformanceParticipantTypeDescription',[PerformanceParticipantTypeGUID]))", false);

            entity.HasOne(d => d.PerformanceParticipantRuleTypeCodeNavigation).WithMany(p => p.TPerformanceParticipantTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceParticipantType_tPerformanceParticipantRuleType");
        });

        modelBuilder.Entity<TPerformanceQuestion>(entity =>
        {
            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TPerformanceQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestion_tLanguage");

            entity.HasOne(d => d.PerformanceAssessmentTypeCodeNavigation).WithMany(p => p.TPerformanceQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestion_tPerformanceAssessmentType");

            entity.HasOne(d => d.PerformanceQuestionGroupCodeNavigation).WithMany(p => p.TPerformanceQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestion_tPerformanceQuestionGroup");

            entity.HasOne(d => d.RuleSetCodeNavigation).WithMany(p => p.TPerformanceQuestions).HasConstraintName("FK_tPerformanceQuestion_USysRuleSet");
        });

        modelBuilder.Entity<TPerformanceQuestionGroup>(entity =>
        {
            entity.HasKey(e => e.PerformanceQuestionGroupCode).HasName("PK_tPerformanceReviewGroup");

            entity.Property(e => e.PerformanceQuestionGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceQuestionGroup','PerformanceQuestionGroupDescription',[PerformanceQuestionGroupGUID]))", false);
        });

        modelBuilder.Entity<TPerformanceQuestionJob>(entity =>
        {
            entity.Property(e => e.PerformanceQuestionJobGuid).ValueGeneratedNever();

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TPerformanceQuestionJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionJob_tJob");

            entity.HasOne(d => d.PerformanceQuestionCodeNavigation).WithMany(p => p.TPerformanceQuestionJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionJob_tPerformanceQuestion");
        });

        modelBuilder.Entity<TPerformanceQuestionJournalType>(entity =>
        {
            entity.Property(e => e.PerformanceQuestionJournalTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceQuestionJournalType','PerformanceQuestionJournalTypeDescription',[PerformanceQuestionJournalTypeGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TPerformanceQuestionParticipant>(entity =>
        {
            entity.HasKey(e => e.PerformanceQuestionParticipantGuid).IsClustered(false);

            entity.HasIndex(e => e.PerformanceQuestionCode, "CIX_tPerformanceQuestionParticipant_PerformanceQuestionCode").IsClustered();

            entity.Property(e => e.PerformanceQuestionParticipantGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PerformanceParticipantTypeCodeNavigation).WithMany(p => p.TPerformanceQuestionParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionParticipant_tPerformanceParticipantType");

            entity.HasOne(d => d.PerformanceQuestionCodeNavigation).WithMany(p => p.TPerformanceQuestionParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionParticipant_tPerformanceQuestion");
        });

        modelBuilder.Entity<TPerformanceQuestionPosition>(entity =>
        {
            entity.Property(e => e.PerformanceQuestionPositionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PerformanceQuestionCodeNavigation).WithMany(p => p.TPerformanceQuestionPositions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionPosition_tPerformanceQuestion");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPerformanceQuestionPositions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionPosition_tPosition");
        });

        modelBuilder.Entity<TPerformanceQuestionReviewType>(entity =>
        {
            entity.HasKey(e => e.PerformanceQuestionReviewTypeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PerformanceQuestionCode, e.PerformanceReviewTypeCode }, "AK_tPerformanceQuestionReviewType")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PerformanceQuestionReviewTypeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PerformanceQuestionCodeNavigation).WithMany(p => p.TPerformanceQuestionReviewTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionReviewType_tPerformanceQuestion");

            entity.HasOne(d => d.PerformanceReviewTypeCodeNavigation).WithMany(p => p.TPerformanceQuestionReviewTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerformanceQuestionReviewType_tPerformanceReviewType");
        });

        modelBuilder.Entity<TPerformanceRating>(entity =>
        {
            entity.Property(e => e.PerformanceRatingDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceRating','PerformanceRatingDescription',[PerformanceRatingGUID]))", false);
        });

        modelBuilder.Entity<TPerformanceReviewType>(entity =>
        {
            entity.Property(e => e.PerformanceReviewTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPerformanceReviewType','PerformanceReviewTypeDescription',[PerformanceReviewTypeGUID]))", false);
        });

        modelBuilder.Entity<TPerson>(entity =>
        {
            entity.Property(e => e.PersonGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PrimaryLanguageCodeNavigation).WithMany(p => p.TPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPerson_tLanguage");
        });

        modelBuilder.Entity<TPerson9BoxHist>(entity =>
        {
            entity.Property(e => e.Person9BoxGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPerson9BoxHists).HasConstraintName("FK_tPerson9BoxHist_Person");
        });

        modelBuilder.Entity<TPersonAbsenceEligibility>(entity =>
        {
            entity.HasKey(e => e.PersonAbsenceEligibilityGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonAbsenceEligibility_PersonGUID").IsClustered();

            entity.Property(e => e.PersonAbsenceEligibilityGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AbsencePlanCodeNavigation).WithMany(p => p.TPersonAbsenceEligibilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAbsenceEligibility_tAbsencePlan");

            entity.HasOne(d => d.AbsencePlanRule).WithMany(p => p.TPersonAbsenceEligibilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAbsenceEligibility_tAbsencePlanRule");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonAbsenceEligibilities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAbsenceEligibility_tPerson");
        });

        modelBuilder.Entity<TPersonAbsenceHist>(entity =>
        {
            entity.HasKey(e => e.PersonAbsenceGuid).IsClustered(false);

            entity.Property(e => e.PersonAbsenceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AbsenceReasonCodeNavigation).WithMany(p => p.TPersonAbsenceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAbsenceHist_tAbsenceReason");

            entity.HasOne(d => d.AbsenceTransactionTypeCodeNavigation).WithMany(p => p.TPersonAbsenceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAbsenceHist_USysAbsenceTransactionType");

            entity.HasOne(d => d.LeaveTypeCodeNavigation).WithMany(p => p.TPersonAbsenceHists).HasConstraintName("FK_tPersonAbsenceHistLeaveType_tLeaveType");

            entity.HasOne(d => d.PersonAbsencePlan).WithMany(p => p.TPersonAbsenceHists).HasConstraintName("FK_tPersonAbsenceHist_tPersonAbsencePlan");

            entity.HasOne(d => d.PersonLeaveRequest).WithMany(p => p.TPersonAbsenceHists).HasConstraintName("FK_tPersonAbsenceHist_tPersonLeaveRequest");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonAbsenceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAbsenceHist_tPosition");
        });

        modelBuilder.Entity<TPersonAbsenceHistErp>(entity =>
        {
            entity.Property(e => e.PersonAbsenceHistErpguid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TPersonAbsenceHistFile>(entity =>
        {
            entity.Property(e => e.PersonAbsenceHistFileGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonAbsence).WithMany(p => p.TPersonAbsenceHistFiles).HasConstraintName("FK_tPersonAbsenceHistFile_tPersonAbsenceHist");
        });

        modelBuilder.Entity<TPersonAbsenceOverrideHist>(entity =>
        {
            entity.HasKey(e => e.PersonAbsenceOverrideGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonAbsencePlanGuid, e.PersonAbsenceOverrideStartDate }, "AK_tPersonAbsenceOverrideHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonAbsenceOverrideGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonAbsencePlan).WithMany(p => p.TPersonAbsenceOverrideHists).HasConstraintName("FK_tPersonAbsenceOverrideHist_tPersonAbsencePlan");
        });

        modelBuilder.Entity<TPersonAbsencePlan>(entity =>
        {
            entity.HasKey(e => e.PersonAbsencePlanGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonAbsencePlan_PersonGUID").IsClustered();

            entity.Property(e => e.PersonAbsencePlanGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AbsencePlanCodeNavigation).WithMany(p => p.TPersonAbsencePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPAbsencePlan_tAbsencePlan");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonAbsencePlans).HasConstraintName("FK_tPersonAbsencePlan_tPerson");
        });

        modelBuilder.Entity<TPersonAbsencePoint>(entity =>
        {
            entity.Property(e => e.PersonAbsencePointGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AbsencePointAdjustmentTypeCodeNavigation).WithMany(p => p.TPersonAbsencePoints).HasConstraintName("FK_tPersonAbsencePoint_tAbsencePointAdjustmentType");

            entity.HasOne(d => d.AbsencePointCorrectiveActionCodeNavigation).WithMany(p => p.TPersonAbsencePoints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonAbsencePoint_tAbsencePointCorrectiveAction");

            entity.HasOne(d => d.AbsencePointIncidentCodeNavigation).WithMany(p => p.TPersonAbsencePoints)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonAbsencePoint_tAbsencePointIncident");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonAbsencePoints).HasConstraintName("FK_tPersonAbsencePoint_Person");
        });

        modelBuilder.Entity<TPersonAchievement>(entity =>
        {
            entity.HasKey(e => e.PersonAchievementGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonAchievement_PersonGUID").IsClustered();

            entity.Property(e => e.PersonAchievementGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonAchievements).HasConstraintName("FK_tPersonAchievement_tPerson");
        });

        modelBuilder.Entity<TPersonAddress>(entity =>
        {
            entity.HasKey(e => e.PersonAddressGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonAddress_PersonGUID").IsClustered();

            entity.Property(e => e.PersonAddressGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AddressTypeCodeNavigation).WithMany(p => p.TPersonAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAddress_tAddressType");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonAddress_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonAddresses).HasConstraintName("FK_tPersonAddress_tPerson");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonAddresses).HasConstraintName("FK_tPersonAddress_tStateProvince");
        });

        modelBuilder.Entity<TPersonApplication>(entity =>
        {
            entity.HasKey(e => e.PersonApplicationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonApplication_PersonGUID").IsClustered();

            entity.Property(e => e.PersonApplicationGuid).ValueGeneratedNever();
            entity.Property(e => e.InternalApplicantFlag).HasComputedColumnSql("([dbo].[shrfnPITIsActiveEmployee]([PersonGuid],[ApplicationDate]))", false);

            entity.HasOne(d => d.ApplicationStatusCodeNavigation).WithMany(p => p.TPersonApplications).HasConstraintName("FK_tPersonApplication_tApplicationStatus");

            entity.HasOne(d => d.LastModifiedByUserNavigation).WithMany(p => p.TPersonApplications).HasConstraintName("FK_tPersonApplication_USysUser");

            entity.HasOne(d => d.MajorNavigation).WithMany(p => p.TPersonApplications).HasConstraintName("FK_tPersonApplication_Major_tMajor");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonApplicationPeople).HasConstraintName("FK_tPersonApplication_tPerson");

            entity.HasOne(d => d.PersonNomination).WithMany(p => p.TPersonApplications).HasConstraintName("FK_tPersonApplication_tPersonNomination");

            entity.HasOne(d => d.RecruitingFirmCodeNavigation).WithMany(p => p.TPersonApplications).HasConstraintName("FK_tPersonApplication_tRecruitingFirm");

            entity.HasOne(d => d.ReferralSourceCodeNavigation).WithMany(p => p.TPersonApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplication_tReferralSource");

            entity.HasOne(d => d.ReferralSourcePerson).WithMany(p => p.TPersonApplicationReferralSourcePeople).HasConstraintName("FK_tPersonApplicationReferralSource_tPerson");

            entity.HasOne(d => d.RequestedPayCurrencyCodeNavigation).WithMany(p => p.TPersonApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplication_tCurrency");

            entity.HasOne(d => d.RequestedPayFrequencyCodeNavigation).WithMany(p => p.TPersonApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplication_tFrequency");

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TPersonApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplication_tRequisition");
        });

        modelBuilder.Entity<TPersonApplicationAnswer>(entity =>
        {
            entity.Property(e => e.PersonApplicationAnswerGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ApplicationQuestionCodeNavigation).WithMany(p => p.TPersonApplicationAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationAnswer_tApplicationQuestion");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonApplicationAnswers).HasConstraintName("FK_tPersonApplicationAnswer_tPersonApplication");
        });

        modelBuilder.Entity<TPersonApplicationCommunication>(entity =>
        {
            entity.HasKey(e => e.PersonApplicationCommunicationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonApplicationGuid, "CIX_tPersonApplicationCommunication_PersonApplicationGUID").IsClustered();

            entity.Property(e => e.PersonApplicationCommunicationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CommunicationTemplate).WithMany(p => p.TPersonApplicationCommunications).HasConstraintName("FK_tPersonApplicationCommunication_USysCommunicationTemplate");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonApplicationCommunications).HasConstraintName("FK_tPersonApplicationCommunication_tPersonApplication");

            entity.HasOne(d => d.PersonApplicationOffer).WithMany(p => p.TPersonApplicationCommunications).HasConstraintName("FK_tPersonApplicationCommunication_tPersonApplicationOffer");

            entity.HasOne(d => d.SentByPerson).WithMany(p => p.TPersonApplicationCommunications).HasConstraintName("FK_tPersonApplicationCommunication_tPerson");
        });

        modelBuilder.Entity<TPersonApplicationEvaluation>(entity =>
        {
            entity.HasKey(e => e.PersonApplicationEvaluationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonApplicationGuid, "CIX_tPersonApplicationEvaluation_PersonApplicationGUID").IsClustered();

            entity.Property(e => e.PersonApplicationEvaluationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.EvaluationResultCodeNavigation).WithMany(p => p.TPersonApplicationEvaluations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationEvaluation_tEvaluationResult");

            entity.HasOne(d => d.EvaluationTypeCodeNavigation).WithMany(p => p.TPersonApplicationEvaluations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationEvaluation_tEvaluationType");

            entity.HasOne(d => d.EvaluatorCodeNavigation).WithMany(p => p.TPersonApplicationEvaluations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationEvaluation_tEvaluator");

            entity.HasOne(d => d.EvaluatorPerson).WithMany(p => p.TPersonApplicationEvaluationEvaluatorPeople).HasConstraintName("FK_tPersonApplicationEvaluation_tPerson_Evaluator");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonApplicationEvaluations).HasConstraintName("FK_tPersonApplicationEvaluation_tPersonApplication");

            entity.HasOne(d => d.PersonApplicationStatus).WithMany(p => p.TPersonApplicationEvaluations).HasConstraintName("FK_tPersonApplicationEvaluation_tPersonApplicationStatusHist");

            entity.HasOne(d => d.ScheduledEvaluatorPerson).WithMany(p => p.TPersonApplicationEvaluationScheduledEvaluatorPeople).HasConstraintName("FK_tPersonApplicationEvaluation_tPerson_ScheduledEvaluator");
        });

        modelBuilder.Entity<TPersonApplicationFile>(entity =>
        {
            entity.HasKey(e => e.PersonApplicationFileGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonApplicationGuid, "CIX_tPersonApplicationFile_PersonApplicationGUID").IsClustered();

            entity.Property(e => e.PersonApplicationFileGuid).ValueGeneratedNever();

            entity.HasOne(d => d.FileAttachmentTypeCodeNavigation).WithMany(p => p.TPersonApplicationFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationFile_tFileAttachmentType");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonApplicationFiles).HasConstraintName("FK_tPersonApplicationFile_tPersonApplication");

            entity.HasOne(d => d.PersonFile).WithMany(p => p.TPersonApplicationFiles).HasConstraintName("FK_tPersonApplicationFile_tPersonFile");
        });

        modelBuilder.Entity<TPersonApplicationOffer>(entity =>
        {
            entity.HasKey(e => e.PersonApplicationOfferGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonApplicationGuid, "CIX_tPersonApplicationOffer_PersonApplicationGUID").IsClustered();

            entity.Property(e => e.PersonApplicationOfferGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AmountCurrencyCodeNavigation).WithMany(p => p.TPersonApplicationOffers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationOffer_tCurrency");

            entity.HasOne(d => d.AmountFrequencyCodeNavigation).WithMany(p => p.TPersonApplicationOffers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationOffer_tFrequency");

            entity.HasOne(d => d.ApprovedByPerson).WithMany(p => p.TPersonApplicationOfferApprovedByPeople).HasConstraintName("FK_tPersonApplicationOffer_tPerson1");

            entity.HasOne(d => d.DeliveryMethodCodeNavigation).WithMany(p => p.TPersonApplicationOffers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationOffer_tDeliveryMethod");

            entity.HasOne(d => d.OfferTypeCodeNavigation).WithMany(p => p.TPersonApplicationOffers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationOffer_tOfferType");

            entity.HasOne(d => d.OfferedByPerson).WithMany(p => p.TPersonApplicationOfferOfferedByPeople).HasConstraintName("FK_tPersonApplicationOffer_tPerson");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonApplicationOffers).HasConstraintName("FK_tPersonApplicationOffer_tPersonApplication");

            entity.HasOne(d => d.PersonApplicationStatus).WithMany(p => p.TPersonApplicationOffers).HasConstraintName("FK_tPersonApplicationOffer_tPersonApplicationStatusHist");
        });

        modelBuilder.Entity<TPersonApplicationStatusHist>(entity =>
        {
            entity.HasKey(e => e.PersonApplicationStatusGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonApplicationGuid, e.PersonApplicationStatusStartDate }, "CIX_tPersonApplicationStatusHist_PersonApplicationGUID_PersonApplicationStatusGUID")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonApplicationStatusGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ApplicationStatusCodeNavigation).WithMany(p => p.TPersonApplicationStatusHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonApplicationStatusHist_tApplicationStatus");

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.TPersonApplicationStatusHists).HasConstraintName("FK_tPersonApplicationStatusHist_tUSysUser");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonApplicationStatusHists).HasConstraintName("FK_tPersonApplicationStatusHist_tPersonApplication");
        });

        modelBuilder.Entity<TPersonAward>(entity =>
        {
            entity.HasKey(e => e.PersonAwardGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonAward_PersonGUID").IsClustered();

            entity.Property(e => e.PersonAwardGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonAwards).HasConstraintName("FK_tPersonAward_tPerson");
        });

        modelBuilder.Entity<TPersonBasePayHist>(entity =>
        {
            entity.HasKey(e => e.PersonBasePayGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonBasePayStartDate }, "CIX_tPersonBasePayHist_PersonGUID_PersonBasePayStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonBasePayGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ApprovedByPerson).WithMany(p => p.TPersonBasePayHistApprovedByPeople).HasConstraintName("FK_tPersonBasePayHist_tPerson_ApprovedByPerson");

            entity.HasOne(d => d.BasePayReasonCodeNavigation).WithMany(p => p.TPersonBasePayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_tBasePayReason");

            entity.HasOne(d => d.PayrollCodeNavigation).WithMany(p => p.TPersonBasePayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_tPayroll");

            entity.HasOne(d => d.PersonBasePayCurrencyCodeNavigation).WithMany(p => p.TPersonBasePayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_tCurrency");

            entity.HasOne(d => d.PersonBasePayFrequencyCodeNavigation).WithMany(p => p.TPersonBasePayHistPersonBasePayFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_tFrequency");

            entity.HasOne(d => d.PersonBasePayPayrollFrequencyCodeNavigation).WithMany(p => p.TPersonBasePayHistPersonBasePayPayrollFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_Payroll_tFrequency");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonBasePayHistPeople).HasConstraintName("FK_tPersonBasePayHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonBasePayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_tPosition");

            entity.HasOne(d => d.ScheduleCodeNavigation).WithMany(p => p.TPersonBasePayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBasePayHist_tSchedule");
        });

        modelBuilder.Entity<TPersonBenefitBeneficiaryHist>(entity =>
        {
            entity.HasKey(e => e.PersonBenefitBeneficiaryGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonBenefitGuid, e.PersonBenefitBeneficiaryStartDate }, "CIX_tPersonBenefitBeneficiaryHist_PersonBenefitGUID_PersonBenefitBenficiaryStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonBenefitBeneficiaryGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonBenefit).WithMany(p => p.TPersonBenefitBeneficiaryHists).HasConstraintName("FK_tPersonBenefitBeneficiaryHist_tPersonBenefitHist");

            entity.HasOne(d => d.RelationshipCodeNavigation).WithMany(p => p.TPersonBenefitBeneficiaryHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitBeneficiaryHist_tRelationship");
        });

        modelBuilder.Entity<TPersonBenefitClaim>(entity =>
        {
            entity.HasKey(e => e.PersonBenefitClaimGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonBenefitGuid, e.ClaimDate }, "CIX_tPersonBenefitClaim_PersonBenefitGUID_ClaimDate").IsClustered();

            entity.Property(e => e.PersonBenefitClaimGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonBenefitClaimCurrencyCodeNavigation).WithMany(p => p.TPersonBenefitClaims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitClaim_tCurrency");

            entity.HasOne(d => d.PersonBenefit).WithMany(p => p.TPersonBenefitClaims).HasConstraintName("FK_tPersonBenefitClaim_tPersonBenefitHist");
        });

        modelBuilder.Entity<TPersonBenefitCobrapayment>(entity =>
        {
            entity.HasKey(e => e.PersonBenefitCobrapaymentGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonBenefitGuid, "CIX_tPersonBenefitCOBRAPayment").IsClustered();

            entity.Property(e => e.PersonBenefitCobrapaymentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PaymentCurrencyCodeNavigation).WithMany(p => p.TPersonBenefitCobrapayments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitCOBRAPayment_tCurrency");

            entity.HasOne(d => d.PersonBenefit).WithMany(p => p.TPersonBenefitCobrapayments).HasConstraintName("FK_tPersonBenefitCOBRAPayment_tPersonBenefitHist");
        });

        modelBuilder.Entity<TPersonBenefitContributionHist>(entity =>
        {
            entity.HasKey(e => e.PersonBenefitContributionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonBenefitGuid, e.PersonBenefitContributionStartDate }, "AK_tPersonBenefitContributionHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonBenefitContributionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonBenefit).WithMany(p => p.TPersonBenefitContributionHists).HasConstraintName("FK_tPersonBenefitContributionHist_tPersonBenefitHist");
        });

        modelBuilder.Entity<TPersonBenefitGroupHist>(entity =>
        {
            entity.HasKey(e => e.PersonBenefitGroupGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonBenefitGroupStartDate }, "AK_tPersonBenefitGroupHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonBenefitGroupGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitGroupCodeNavigation).WithMany(p => p.TPersonBenefitGroupHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitGroupHist_BenefitGroup");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonBenefitGroupHists).HasConstraintName("FK_tPersonBenefitGroupHist_Person");
        });

        modelBuilder.Entity<TPersonBenefitHist>(entity =>
        {
            entity.HasKey(e => e.PersonBenefitHistGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonBenefitStartDate }, "CIX_tPersonBenefitHist_PersonGUID_PersonBenefitStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonBenefitHistGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TPersonBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitHist_tBenefitPlanOption");

            entity.HasOne(d => d.BenefitWaiveReasonCodeNavigation).WithMany(p => p.TPersonBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitHist_tBenefitWaiveReason");

            entity.HasOne(d => d.EndBenefitStatusCodeNavigation).WithMany(p => p.TPersonBenefitHistEndBenefitStatusCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitHist_End_tBenefitStatus");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonBenefitHistPeople).HasConstraintName("FK_tPersonBenefitHist_tPerson");

            entity.HasOne(d => d.PrimaryPhysicianCodeNavigation).WithMany(p => p.TPersonBenefitHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitHist_tPhysician");

            entity.HasOne(d => d.ResponsiblePerson).WithMany(p => p.TPersonBenefitHistResponsiblePeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitHist_Responsible_tPerson");

            entity.HasOne(d => d.StartBenefitStatusCodeNavigation).WithMany(p => p.TPersonBenefitHistStartBenefitStatusCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitHist_Start_tBenefitStatus");
        });

        modelBuilder.Entity<TPersonBenefitOffer>(entity =>
        {
            entity.Property(e => e.PersonBenefitOfferGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonBenefitOffers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitOffer_tPerson");
        });

        modelBuilder.Entity<TPersonBenefitOptOut>(entity =>
        {
            entity.Property(e => e.PersonBenefitOptOutGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TPersonBenefitOptOuts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitOptOut_tBenefitPlanOption");

            entity.HasOne(d => d.FailedOptOutReasonCodeNavigation).WithMany(p => p.TPersonBenefitOptOuts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitOptOut_tBenefitWaiveReason");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonBenefitOptOuts).HasConstraintName("FK_tPersonBenefitOptOut_tPerson");

            entity.HasOne(d => d.StartBenefitStatusCodeNavigation).WithMany(p => p.TPersonBenefitOptOuts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonBenefitOptOut_tBenefitStatus");
        });

        modelBuilder.Entity<TPersonCertification>(entity =>
        {
            entity.HasKey(e => e.PersonCertificationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonCertification_PersonGUID").IsClustered();

            entity.Property(e => e.PersonCertificationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TPersonCertifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCertification_tCertification");

            entity.HasOne(d => d.PersonGoal).WithMany(p => p.TPersonCertifications).HasConstraintName("FK_tPersonCertification_tPersonGoal");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonCertifications).HasConstraintName("FK_tPersonCertification_tPerson");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonCertifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCertification_tStateProvince");
        });

        modelBuilder.Entity<TPersonCobra>(entity =>
        {
            entity.HasKey(e => e.PersonCobraguid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonCOBRA_PersonGUID").IsClustered();

            entity.Property(e => e.PersonCobraguid).ValueGeneratedNever();

            entity.HasOne(d => d.CobraeventCodeNavigation).WithMany(p => p.TPersonCobras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCOBRA_tCOBRAEvent");

            entity.HasOne(d => d.CobrastatusCodeNavigation).WithMany(p => p.TPersonCobras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCOBRA_tCOBRAStatus");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonCobras).HasConstraintName("FK_tPersonCOBRA_tPerson");
        });

        modelBuilder.Entity<TPersonCommunityActivity>(entity =>
        {
            entity.HasKey(e => e.PersonCommunityActivityGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonCommunityActivity_PersonGUID").IsClustered();

            entity.Property(e => e.PersonCommunityActivityGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonCommunityActivities).HasConstraintName("FK_tPersonCommunityActivity_tPerson");
        });

        modelBuilder.Entity<TPersonCompetencyHist>(entity =>
        {
            entity.HasKey(e => e.PersonCompetencyGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonCompetencyStartDate }, "CIX_tPersonCompetencyHist_PersonGUID_PersonCompetencyStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonCompetencyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TPersonCompetencyHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCompetencyHist_tCompetency");

            entity.HasOne(d => d.EmployeeProficiencyCodeNavigation).WithMany(p => p.TPersonCompetencyHistEmployeeProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCompetencyHist_tProficiency_Employee");

            entity.HasOne(d => d.HowAcquiredCodeNavigation).WithMany(p => p.TPersonCompetencyHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCompetencyHist_tHowAcquired");

            entity.HasOne(d => d.OtherProficiencyCodeNavigation).WithMany(p => p.TPersonCompetencyHistOtherProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCompetencyHist_tProficiency_Other");

            entity.HasOne(d => d.PersonGoal).WithMany(p => p.TPersonCompetencyHists).HasConstraintName("FK_tPersonCompetencyHist_tPersonGoal");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonCompetencyHistPeople).HasConstraintName("FK_tPersonCompetencyHist_tPerson");

            entity.HasOne(d => d.ProficiencyCodeNavigation).WithMany(p => p.TPersonCompetencyHistProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCompetencyHist_tProficiency");

            entity.HasOne(d => d.SupervisorProficiencyAssessedByPerson).WithMany(p => p.TPersonCompetencyHistSupervisorProficiencyAssessedByPeople).HasConstraintName("FK_tPersonCompetencyHist_tPerson_Supervisor");

            entity.HasOne(d => d.SupervisorProficiencyCodeNavigation).WithMany(p => p.TPersonCompetencyHistSupervisorProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCompetencyHist_tProficiency_Supervisor");
        });

        modelBuilder.Entity<TPersonCustomBase>(entity =>
        {
            entity.HasKey(e => e.PersonCustomBaseGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "AK_tPersonCustomBase")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonCustomBaseGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Custom1CodeNavigation).WithMany(p => p.TPersonCustomBases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomBase_tCustom1");

            entity.HasOne(d => d.Custom2CodeNavigation).WithMany(p => p.TPersonCustomBases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomBase_tCustom2");

            entity.HasOne(d => d.Custom3CodeNavigation).WithMany(p => p.TPersonCustomBases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomBase_tCustom3");

            entity.HasOne(d => d.Custom4CodeNavigation).WithMany(p => p.TPersonCustomBases)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomBase_tCustom4");

            entity.HasOne(d => d.Person).WithOne(p => p.TPersonCustomBase).HasConstraintName("FK_tPersonCustomBase_tPerson");
        });

        modelBuilder.Entity<TPersonCustomHist>(entity =>
        {
            entity.HasKey(e => e.PersonCustomGuid).IsClustered(false);

            entity.ToTable("tPersonCustomHist", tb => tb.HasTrigger("WFS_tPersonCustomHist_Insert_Update_Title_Feild_Fix"));

            entity.HasIndex(e => new { e.PersonGuid, e.PersonCustomStartDate }, "AK_tPersonCustomHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonCustomGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Custom11CodeNavigation).WithMany(p => p.TPersonCustomHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomHist_tCustom11");

            entity.HasOne(d => d.Custom12CodeNavigation).WithMany(p => p.TPersonCustomHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomHist_tCustom12");

            entity.HasOne(d => d.Custom13CodeNavigation).WithMany(p => p.TPersonCustomHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomHist_tCustom13");

            entity.HasOne(d => d.Custom14CodeNavigation).WithMany(p => p.TPersonCustomHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonCustomHist_tCustom14");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonCustomHists).HasConstraintName("FK_tPersonCustomHist_tPerson");
        });

        modelBuilder.Entity<TPersonDependent>(entity =>
        {
            entity.HasKey(e => e.PersonDependentGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonDependent_PersonGUID").IsClustered();

            entity.Property(e => e.PersonDependentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DependentPerson).WithMany(p => p.TPersonDependentDependentPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDependent_Dependent_tPerson");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonDependentPeople).HasConstraintName("FK_tPersonDependent_tPerson");

            entity.HasOne(d => d.RelationshipCodeNavigation).WithMany(p => p.TPersonDependents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDependent_tRelationship");
        });

        modelBuilder.Entity<TPersonDirectDeposit>(entity =>
        {
            entity.HasKey(e => e.PersonDirectDepositGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonDirectDeposit_PersonGUID").IsClustered();

            entity.Property(e => e.PersonDirectDepositGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DirectDepositAccountTypeCodeNavigation).WithMany(p => p.TPersonDirectDeposits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDirectDeposit_tDirectDepositAccountType");

            entity.HasOne(d => d.InstitutionCountryCodeNavigation).WithMany(p => p.TPersonDirectDeposits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDirectDeposit_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonDirectDepositPeople).HasConstraintName("FK_tPersonDirectDeposit_tPerson");

            entity.HasOne(d => d.SignedByPerson).WithMany(p => p.TPersonDirectDepositSignedByPeople).HasConstraintName("FK_tPersonDirectDeposit_SignedBy_tPerson");
        });

        modelBuilder.Entity<TPersonDiscipline>(entity =>
        {
            entity.HasKey(e => e.PersonDisciplineGuid).IsClustered(false);

            entity.Property(e => e.PersonDisciplineGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DisciplineActionCodeNavigation).WithMany(p => p.TPersonDisciplines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDiscipline_tDisciplineAction");

            entity.HasOne(d => d.DisciplinePrimaryPolicyCodeNavigation).WithMany(p => p.TPersonDisciplines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDiscipline_tDisciplinePrimaryPolicy");

            entity.HasOne(d => d.DisciplineReasonCodeNavigation).WithMany(p => p.TPersonDisciplines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDiscipline_tDisciplineReason");

            entity.HasOne(d => d.DisciplineTypeCodeNavigation).WithMany(p => p.TPersonDisciplines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDiscipline_tDisciplineType");

            entity.HasOne(d => d.HandledByPerson).WithMany(p => p.TPersonDisciplineHandledByPeople).HasConstraintName("FK_tPersonDiscipline_HandledBy_tPerson");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonDisciplinePeople).HasConstraintName("FK_tPersonDiscipline_tPerson");
        });

        modelBuilder.Entity<TPersonDrugTest>(entity =>
        {
            entity.HasKey(e => e.PersonDrugTestGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonDrugTest_PersonGUID").IsClustered();

            entity.Property(e => e.PersonDrugTestGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DrugTestReasonCodeNavigation).WithMany(p => p.TPersonDrugTests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDrugTest_tDrugTestReason");

            entity.HasOne(d => d.DrugTestResultCodeNavigation).WithMany(p => p.TPersonDrugTests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDrugTest_tDrugTestResult");

            entity.HasOne(d => d.DrugTestTypeCodeNavigation).WithMany(p => p.TPersonDrugTests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDrugTest_tDrugTestType");

            entity.HasOne(d => d.MedicalFacilityCodeNavigation).WithMany(p => p.TPersonDrugTestMedicalFacilityCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDrugTest_tMedicalFacility");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonDrugTestPeople).HasConstraintName("FK_tPersonDrugTest_tPerson");

            entity.HasOne(d => d.RequestedByPerson).WithMany(p => p.TPersonDrugTestRequestedByPeople).HasConstraintName("FK_tPersonDrugTest_RequestedBy_tPerson");

            entity.HasOne(d => d.ScheduledMedicalFacilityCodeNavigation).WithMany(p => p.TPersonDrugTestScheduledMedicalFacilityCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonDrugTest_tMedicalFacility_Scheduled");
        });

        modelBuilder.Entity<TPersonEducationHist>(entity =>
        {
            entity.HasKey(e => e.PersonEducationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonEducationHist").IsClustered();

            entity.Property(e => e.PersonEducationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DegreeCodeNavigation).WithMany(p => p.TPersonEducationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEducationHist_tDegree");

            entity.HasOne(d => d.EducationStatusCodeNavigation).WithMany(p => p.TPersonEducationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEducationHist_tEducationStatus");

            entity.HasOne(d => d.MajorCodeNavigation).WithMany(p => p.TPersonEducationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEducationHist_tMajor");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonEducationHists).HasConstraintName("FK_tPersonEducationHist_tPerson");
        });

        modelBuilder.Entity<TPersonEmergency>(entity =>
        {
            entity.HasKey(e => e.PersonEmergencyGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonEmergency_PersonGUID").IsClustered();

            entity.Property(e => e.PersonEmergencyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonEmergencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmergency_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonEmergencies).HasConstraintName("FK_tPersonEmergency_tPerson");

            entity.HasOne(d => d.RelationshipCodeNavigation).WithMany(p => p.TPersonEmergencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmergency_tRelationship");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonEmergencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmergency_tStateProvince");
        });

        modelBuilder.Entity<TPersonEmploymentDocument>(entity =>
        {
            entity.Property(e => e.PersonEmploymentDocumentGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.EmploymentDocumentCodeNavigation).WithMany(p => p.TPersonEmploymentDocuments).HasConstraintName("FK_tPersonEmploymentDocument_tEmploymentDocument");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonEmploymentDocumentPeople).HasConstraintName("FK_tPersonEmploymentDocument_tPerson_Person");

            entity.HasOne(d => d.SignedByPerson).WithMany(p => p.TPersonEmploymentDocumentSignedByPeople).HasConstraintName("FK_tPersonEmploymentDocument_tPerson_SignedByPerson");
        });

        modelBuilder.Entity<TPersonEmploymentHist>(entity =>
        {
            entity.HasKey(e => e.PersonEmploymentGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonEmploymentHist").IsClustered();

            entity.Property(e => e.PersonEmploymentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonEmploymentHists).HasConstraintName("FK_tPersonEmploymentHist_tCountry");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.TPersonEmploymentHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmploymentHist_tCurrency");

            entity.HasOne(d => d.DepartureReasonCodeNavigation).WithMany(p => p.TPersonEmploymentHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmploymentHist_tDepartureReason");

            entity.HasOne(d => d.EndingPayFrequencyCodeNavigation).WithMany(p => p.TPersonEmploymentHistEndingPayFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmploymentHist_tFrequency2");

            entity.HasOne(d => d.FunctionalAreaCodeNavigation).WithMany(p => p.TPersonEmploymentHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmploymentHist_tFunctionalArea");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonEmploymentHists).HasConstraintName("FK_tPersonEmploymentHist_tPerson");

            entity.HasOne(d => d.ProfessionalLevelCodeNavigation).WithMany(p => p.TPersonEmploymentHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmploymentHist_tProfessionalLevel");

            entity.HasOne(d => d.StartingPayFrequencyCodeNavigation).WithMany(p => p.TPersonEmploymentHistStartingPayFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonEmploymentHist_tFrequency");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonEmploymentHists).HasConstraintName("FK_tPersonEmploymentHist_tStateProvince");
        });

        modelBuilder.Entity<TPersonErp>(entity =>
        {
            entity.Property(e => e.PersonGuid).ValueGeneratedNever();
            entity.Property(e => e.ErpemployeeId).HasComputedColumnSql("([dbo].[shrfnGeneratePersonErpId]([ERPEmployeeIDGenerated]))", false);
            entity.Property(e => e.ErpemployeeIdgenerated).ValueGeneratedOnAdd();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Person).WithOne(p => p.TPersonErp).HasConstraintName("FK_tPersonERP_tPerson");
        });

        modelBuilder.Entity<TPersonFile>(entity =>
        {
            entity.Property(e => e.PersonFileGuid).ValueGeneratedNever();

            entity.HasOne(d => d.FileAttachmentTypeCodeNavigation).WithMany(p => p.TPersonFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFile_tFileAttachmentType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonFiles).HasConstraintName("FK_tPersonFile_tPerson");
        });

        modelBuilder.Entity<TPersonFmlaadjustment>(entity =>
        {
            entity.HasKey(e => e.PersonFmlaadjustmentGuid)
                .HasName("PK_tPersonFMLAAdjustments")
                .IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonFMLAAdjustment_PersonGUID").IsClustered();

            entity.Property(e => e.PersonFmlaadjustmentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonFmlaadjustments).HasConstraintName("FK_tPersonFMLAAdjustment_tPerson");
        });

        modelBuilder.Entity<TPersonForwardedApplication>(entity =>
        {
            entity.Property(e => e.PersonForwardedApplicationGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ForwardedByPerson).WithMany(p => p.TPersonForwardedApplicationForwardedByPeople).HasConstraintName("FK_tPersonForwardedApplication_ForwardedBy_tPerson");

            entity.HasOne(d => d.ForwardedToPerson).WithMany(p => p.TPersonForwardedApplicationForwardedToPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonForwardedApplication_ForwardedTo_tPerson");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TPersonForwardedApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonForwardedApplication_tPersonApplication");

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TPersonForwardedApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonForwardedApplication_tRequisition");
        });

        modelBuilder.Entity<TPersonFutureEnrollment>(entity =>
        {
            entity.HasKey(e => e.PersonFutureEnrollmentGuid).IsClustered(false);

            entity.HasIndex(e => e.EnrolledPersonGuid, "CIX_tPersonFutureEnrollment_PersonGUID").IsClustered();

            entity.Property(e => e.PersonFutureEnrollmentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitFutureEnrollmentStatusCodeNavigation).WithMany(p => p.TPersonFutureEnrollments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_tBenefitFutureEnrollmentStatus");

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.TPersonFutureEnrollments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_tBenefitPlanOption");

            entity.HasOne(d => d.BenefitWaiveReasonCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentBenefitWaiveReasonCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_tBenefitWaiveReason");

            entity.HasOne(d => d.BenefitWaiveReasonCodeOriginalNavigation).WithMany(p => p.TPersonFutureEnrollmentBenefitWaiveReasonCodeOriginalNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_tBenefitWaiveReasonOriginal");

            entity.HasOne(d => d.EndBenefitStatusCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentEndBenefitStatusCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_End_tBenefitStatus");

            entity.HasOne(d => d.EnrolledPerson).WithMany(p => p.TPersonFutureEnrollmentEnrolledPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_tPerson");

            entity.HasOne(d => d.PersonFutureEnrollmentStatus).WithMany(p => p.TPersonFutureEnrollments).HasConstraintName("FK_tPersonFutureEnrollment_tPersonFutureEnrollmentStatus");

            entity.HasOne(d => d.PrimaryPhysicianCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentPrimaryPhysicianCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_tPhysician");

            entity.HasOne(d => d.PrimaryPhysicianCodeOriginalNavigation).WithMany(p => p.TPersonFutureEnrollmentPrimaryPhysicianCodeOriginalNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_Original_tPhysician");

            entity.HasOne(d => d.ResponsiblePerson).WithMany(p => p.TPersonFutureEnrollmentResponsiblePeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_Responsible_tPerson");

            entity.HasOne(d => d.StartBenefitStatusCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentStartBenefitStatusCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollment_Start_tBenefitStatus");
        });

        modelBuilder.Entity<TPersonFutureEnrollmentBeneficiary>(entity =>
        {
            entity.HasKey(e => e.PersonFutureEnrollmentBeneficiaryGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonFutureEnrollmentGuid, "CIX_tPersonFutureEnrollmentBeneficiary_PersonFutureEnrollmentGUID").IsClustered();

            entity.Property(e => e.PersonFutureEnrollmentBeneficiaryGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonFutureEnrollment).WithMany(p => p.TPersonFutureEnrollmentBeneficiaries).HasConstraintName("FK_tPersonFutureEnrollmentBeneficiary_tPersonFutureEnrollment");

            entity.HasOne(d => d.RelationshipCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentBeneficiaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollmentBeneficiary_tRelationship");
        });

        modelBuilder.Entity<TPersonFutureEnrollmentStatus>(entity =>
        {
            entity.HasKey(e => e.PersonFutureEnrollmentStatusGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonFutureEnrollmentStatus_PersonGUID").IsClustered();

            entity.Property(e => e.PersonFutureEnrollmentStatusGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BenefitFutureEnrollmentPersonStatusCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonFutureEnrollmentStatus_tBenefitFutureEnrollmentPersonStatus");

            entity.HasOne(d => d.BenefitOpenEnrollmentGroupCodeNavigation).WithMany(p => p.TPersonFutureEnrollmentStatuses).HasConstraintName("FK_tPersonFutureEnrollmentStatus_tBenefitOpenEnrollmentGroup");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonFutureEnrollmentStatuses).HasConstraintName("FK_tPersonFutureEnrollmentStatus_tPerson");
        });

        modelBuilder.Entity<TPersonGoal>(entity =>
        {
            entity.HasKey(e => e.PersonGoalGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonGoal_PersonGUID").IsClustered();

            entity.Property(e => e.PersonGoalGuid).ValueGeneratedNever();
            entity.Property(e => e.OtherGoalDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPersonGoal','OtherGoalDescription',[PersonGoalGUID]))", false);

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tCertification");

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tCompetency");

            entity.HasOne(d => d.CompetencyProficiencyCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tProficiency");

            entity.HasOne(d => d.CorporateGoal).WithMany(p => p.TPersonGoals).HasConstraintName("FK_tPersonGoal_tCorporateGoal");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tCourse");

            entity.HasOne(d => d.CreatedByPerson).WithMany(p => p.TPersonGoalCreatedByPeople).HasConstraintName("FK_tPersonGoal_tPerson_CreatedBy");

            entity.HasOne(d => d.GoalObjectiveCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tGoalObjective");

            entity.HasOne(d => d.GoalTypeCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tGoalType");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tLanguage");

            entity.HasOne(d => d.MobilityStatusCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tMobilityStatus");

            entity.HasOne(d => d.ParentPersonGoal).WithMany(p => p.InverseParentPersonGoal).HasConstraintName("FK_tPersonGoal_tPersonGoal");

            entity.HasOne(d => d.PayoutCurrencyCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tCurrency");

            entity.HasOne(d => d.PerformanceReviewPositionCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tPosition");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonGoalPeople).HasConstraintName("FK_tPersonGoal_tPerson");

            entity.HasOne(d => d.PersonOtherPay).WithMany(p => p.TPersonGoals).HasConstraintName("FK_tPersonGoal_tPersonOtherPayHist");

            entity.HasOne(d => d.ReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonGoalReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tLanguageProficiency_Reading");

            entity.HasOne(d => d.SpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonGoalSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tLanguageProficiency_Spoken");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TPersonGoals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tTrainingProgram");

            entity.HasOne(d => d.TranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonGoalTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tLanguageProficiency_Translation");

            entity.HasOne(d => d.WrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonGoalWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonGoal_tLanguageProficiency_Written");
        });

        modelBuilder.Entity<TPersonGovFormHist>(entity =>
        {
            entity.Property(e => e.PersonGovFormHistGuid).ValueGeneratedNever();
            entity.Property(e => e.FormDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPersonGovFormHist','FormDescription',[PersonGovFormHistGUID]))", false);

            entity.HasOne(d => d.FormTypeCodeNavigation).WithMany(p => p.TPersonGovFormHists).HasConstraintName("FK_tPersonGovFormHist_FormTypeCode");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonGovFormHists).HasConstraintName("FK_tPersonGovFormHist_Person");
        });

        modelBuilder.Entity<TPersonI9>(entity =>
        {
            entity.Property(e => e.PersonI9guid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.EmployerSignedByPerson).WithMany(p => p.TPersonI9EmployerSignedByPeople).HasConstraintName("FK_tPersonI9_EmployerSignedBy_tPerson");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonI9People).HasConstraintName("FK_tPersonI9_tPerson");

            entity.HasOne(d => d.PreparerStateProvinceCodeNavigation).WithMany(p => p.TPersonI9PreparerStateProvinceCodeNavigations).HasConstraintName("FK_tPersonI9PreparerStateProvince_tStateProvince");

            entity.HasOne(d => d.RehireOrReverificationEmployerSignedByPerson).WithMany(p => p.TPersonI9RehireOrReverificationEmployerSignedByPeople).HasConstraintName("FK_tPersonI9RehireOrReverificationEmployerSignedByPerson_tPerson");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonI9StateProvinceCodeNavigations).HasConstraintName("FK_tPersonI9_tStateProvinceCode");
        });

        modelBuilder.Entity<TPersonI9file>(entity =>
        {
            entity.Property(e => e.PersonI9fileGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.I9documentTypeCodeNavigation).WithMany(p => p.TPersonI9files).HasConstraintName("FK_tPersonI9File_USysI9DocumentType");

            entity.HasOne(d => d.PersonI9).WithMany(p => p.TPersonI9files).HasConstraintName("FK_tPersonI9File_tPersonI9");
        });

        modelBuilder.Entity<TPersonIncident>(entity =>
        {
            entity.HasKey(e => e.PersonIncidentGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonIncident_PersonGUID").IsClustered();

            entity.Property(e => e.PersonIncidentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tDepartment");

            entity.HasOne(d => d.FirstReportCompletedByPerson).WithMany(p => p.TPersonIncidentFirstReportCompletedByPeople).HasConstraintName("FK_tPersonIncident_FirstReportCompletedBy_tPerson");

            entity.HasOne(d => d.FirstReportCompletedByPersonJobCodeNavigation).WithMany(p => p.TPersonIncidentFirstReportCompletedByPersonJobCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_FirstReportCompletedBy_tJob");

            entity.HasOne(d => d.IllnessInjuryCodeNavigation).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tIllnessInjury");

            entity.HasOne(d => d.IllnessInjuryStatusCodeNavigation).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tIllnessInjuryStatus");

            entity.HasOne(d => d.Incident).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tIncident");

            entity.HasOne(d => d.OccupationalIllnessCategoryCodeNavigation).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tOccupationalIllnessCategory");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonIncidentPeople).HasConstraintName("FK_tPersonIncident_tPerson");

            entity.HasOne(d => d.RegularJobCodeNavigation).WithMany(p => p.TPersonIncidentRegularJobCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_RegularJob_tJob");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tShift");

            entity.HasOne(d => d.SupervisorPerson).WithMany(p => p.TPersonIncidentSupervisorPeople).HasConstraintName("FK_tPersonIncident_Supervisor_tPerson");

            entity.HasOne(d => d.WorkersCompensationCodeNavigation).WithMany(p => p.TPersonIncidents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncident_tWorkersCompensation");
        });

        modelBuilder.Entity<TPersonIncidentBodyPart>(entity =>
        {
            entity.HasKey(e => e.PersonIncidentBodyPartGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonIncidentGuid, "CIX_tPersonIncidentBodyPart_PersonIncidentGUID").IsClustered();

            entity.Property(e => e.PersonIncidentBodyPartGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BodyPartCodeNavigation).WithMany(p => p.TPersonIncidentBodyParts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncidentBodyPart_tBodyPart");

            entity.HasOne(d => d.IllnessInjuryCodeNavigation).WithMany(p => p.TPersonIncidentBodyParts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncidentBodyPart_tIllnessInjury");

            entity.HasOne(d => d.PersonIncident).WithMany(p => p.TPersonIncidentBodyParts).HasConstraintName("FK_tPersonIncidentBodyPart_tPersonIncident");
        });

        modelBuilder.Entity<TPersonIncidentLostTimeHist>(entity =>
        {
            entity.HasKey(e => e.PersonIncidentLostTimeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonIncidentGuid, e.PersonIncidentLostTimeStartDate }, "AK_tPersonIncidentLostTimeHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonIncidentLostTimeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonIncident).WithMany(p => p.TPersonIncidentLostTimeHists).HasConstraintName("FK_tPersonIncidentLostTimeHist_tPersonIncident");
        });

        modelBuilder.Entity<TPersonIncidentRestrictedTimeHist>(entity =>
        {
            entity.HasKey(e => e.PersonIncidentRestrictedTimeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonIncidentGuid, e.PersonIncidentRestrictedTimeStartDate }, "AK_tPersonIncidentRestrictedTimeHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonIncidentRestrictedTimeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonIncident).WithMany(p => p.TPersonIncidentRestrictedTimeHists).HasConstraintName("FK_tPersonIncidentRestrictedTimeHist_tPersonIncident");
        });

        modelBuilder.Entity<TPersonIncidentTreatment>(entity =>
        {
            entity.HasKey(e => e.PersonIncidentTreatmentGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonIncidentGuid, "CIX_tPersonIncidentTreatment_PersonIncidentGUID").IsClustered();

            entity.Property(e => e.PersonIncidentTreatmentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.MedicalFacilityCodeNavigation).WithMany(p => p.TPersonIncidentTreatments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncidentTreatment_tMedicalFacility");

            entity.HasOne(d => d.PersonIncident).WithMany(p => p.TPersonIncidentTreatments).HasConstraintName("FK_tPersonIncidentTreatment_tPersonIncident");

            entity.HasOne(d => d.PhysicianCodeNavigation).WithMany(p => p.TPersonIncidentTreatments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonIncidentTreatment_tPhysician");
        });

        modelBuilder.Entity<TPersonJobHist>(entity =>
        {
            entity.HasKey(e => e.PersonJobGuid).IsClustered(false);

            entity.ToTable("tPersonJobHist", tb => tb.HasTrigger("tPersonJobHist_Insert"));

            entity.HasIndex(e => new { e.PersonGuid, e.PersonJobStartDate }, "CIX_tPersonJobHist_PersonGUID_PersonJobStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonJobGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DriverStatusNavigation).WithMany(p => p.TPersonJobHists).HasConstraintName("FK_tPersonJobHist_DriverStatus_tDriverStatus");

            entity.HasOne(d => d.GradeLocationCodeNavigation).WithMany(p => p.TPersonJobHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonJobHist_tLocation");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TPersonJobHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonJobHist_tJob");

            entity.HasOne(d => d.JobReasonCodeNavigation).WithMany(p => p.TPersonJobHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonJobHist_tJobReason");

            entity.HasOne(d => d.NoticePeriodEmployeeIndicatorNavigation).WithMany(p => p.TPersonJobHistNoticePeriodEmployeeIndicatorNavigations).HasConstraintName("FK_tPersonJobHist_tNoticePeriodEmployeeIndicator");

            entity.HasOne(d => d.NoticePeriodEmployerIndicatorNavigation).WithMany(p => p.TPersonJobHistNoticePeriodEmployerIndicatorNavigations).HasConstraintName("FK_tPersonJobHist_tNoticePeriodEmployerIndicator");

            entity.HasOne(d => d.OrgPublisherPositionTypeCodeNavigation).WithMany(p => p.TPersonJobHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonJobHist_tOrgPublisherPositionType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonJobHists).HasConstraintName("FK_tPersonJobHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonJobHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonJobHist_tPosition");

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TPersonJobHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonJobHist_tRequisition");
        });

        modelBuilder.Entity<TPersonLanguage>(entity =>
        {
            entity.HasKey(e => e.PersonLanguageGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonLanguage_PersonGUID").IsClustered();

            entity.Property(e => e.PersonLanguageGuid).ValueGeneratedNever();

            entity.HasOne(d => d.EmployeeReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageEmployeeReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_EmployeeReading");

            entity.HasOne(d => d.EmployeeSpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageEmployeeSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_EmployeeSpoken");

            entity.HasOne(d => d.EmployeeTranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageEmployeeTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_EmployeeTranslation");

            entity.HasOne(d => d.EmployeeWrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageEmployeeWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_EmployeeWritten");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TPersonLanguages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguage");

            entity.HasOne(d => d.OtherReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageOtherReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_OtherReading");

            entity.HasOne(d => d.OtherSpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageOtherSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_OtherSpoken");

            entity.HasOne(d => d.OtherTranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageOtherTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_OtherTranslation");

            entity.HasOne(d => d.OtherWrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageOtherWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_OtherWritten");

            entity.HasOne(d => d.PersonGoal).WithMany(p => p.TPersonLanguages).HasConstraintName("FK_tPersonLanguage_tPersonGoal");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonLanguagePeople).HasConstraintName("FK_tPersonLanguage_tPerson");

            entity.HasOne(d => d.ReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency");

            entity.HasOne(d => d.SpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency1");

            entity.HasOne(d => d.SupervisorProficiencyAssessedByPerson).WithMany(p => p.TPersonLanguageSupervisorProficiencyAssessedByPeople).HasConstraintName("FK_tPersonLanguage_tPerson_Supervisor");

            entity.HasOne(d => d.SupervisorReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageSupervisorReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_SupervisorReading");

            entity.HasOne(d => d.SupervisorSpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageSupervisorSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_SupervisorSpoken");

            entity.HasOne(d => d.SupervisorTranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageSupervisorTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_SupervisorTranslation");

            entity.HasOne(d => d.SupervisorWrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageSupervisorWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency_SupervisorWritten");

            entity.HasOne(d => d.TranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency2");

            entity.HasOne(d => d.WrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TPersonLanguageWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLanguage_tLanguageProficiency3");
        });

        modelBuilder.Entity<TPersonLeaveRequest>(entity =>
        {
            entity.HasKey(e => e.PersonLeaveRequestGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonLeaveRequest_PersonGUID").IsClustered();

            entity.Property(e => e.PersonLeaveRequestGuid).ValueGeneratedNever();

            entity.HasOne(d => d.FmlaLeaveFrequencyCodeNavigation).WithMany(p => p.TPersonLeaveRequests).HasConstraintName("FK_tPersonLeaveRequest_USysFmlaLeaveFrequency");

            entity.HasOne(d => d.FmlaLeaveReasonCodeNavigation).WithMany(p => p.TPersonLeaveRequests).HasConstraintName("FK_tPersonLeaveRequest_USysFmlaLeaveReason");

            entity.HasOne(d => d.LeaveReasonCodeNavigation).WithMany(p => p.TPersonLeaveRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLeaveRequest_tLeaveReason");

            entity.HasOne(d => d.LeaveTypeCodeNavigation).WithMany(p => p.TPersonLeaveRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLeaveRequest_tLeaveType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonLeaveRequests).HasConstraintName("FK_tPersonLeaveRequest_tPerson");
        });

        modelBuilder.Entity<TPersonLeaveRequestDesignation>(entity =>
        {
            entity.Property(e => e.PersonLeaveRequestDesignationGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.PersonLeaveRequest).WithMany(p => p.TPersonLeaveRequestDesignations).HasConstraintName("FK_tPersonLeaveRequestDesignation_tPersonLeaveRequest");
        });

        modelBuilder.Entity<TPersonLeaveRequestDesignationFile>(entity =>
        {
            entity.Property(e => e.PersonLeaveRequestDesignationFileGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FileAttachmentTypeCodeNavigation).WithMany(p => p.TPersonLeaveRequestDesignationFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLeaveRequestDesignationFile_tFileAttachmentType");

            entity.HasOne(d => d.PersonLeaveRequestDesignation).WithMany(p => p.TPersonLeaveRequestDesignationFiles).HasConstraintName("FK_tPersonLeaveRequestDesignationFile_tPersonLeaveRequestDesignation");
        });

        modelBuilder.Entity<TPersonLeaveRequestEligibility>(entity =>
        {
            entity.Property(e => e.PersonLeaveRequestEligibilityGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.PersonLeaveRequest).WithMany(p => p.TPersonLeaveRequestEligibilities).HasConstraintName("FK_tPersonLeaveRequestEligibility_tPersonLeaveRequest");
        });

        modelBuilder.Entity<TPersonLeaveRequestEligibilityFile>(entity =>
        {
            entity.Property(e => e.PersonLeaveRequestEligibilityFileGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.FileAttachmentTypeCodeNavigation).WithMany(p => p.TPersonLeaveRequestEligibilityFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLeaveRequestEligibilityFile_tFileAttachmentType");

            entity.HasOne(d => d.PersonLeaveRequestEligibility).WithMany(p => p.TPersonLeaveRequestEligibilityFiles).HasConstraintName("FK_tPersonLeaveRequestEligibilityFile_tPersonLeaveRequestEligibility");
        });

        modelBuilder.Entity<TPersonLifeEvent>(entity =>
        {
            entity.HasKey(e => e.PersonLifeEventGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonLifeEventEventDate, e.LifeEventTypeCode }, "CIX_tPersonLifeEvent")
                .IsDescending(false, true, false)
                .IsClustered();

            entity.Property(e => e.PersonLifeEventGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.LifeEventStatusCodeNavigation).WithMany(p => p.TPersonLifeEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLifeEvent_tLifeEventStatus");

            entity.HasOne(d => d.LifeEventTypeCodeNavigation).WithMany(p => p.TPersonLifeEvents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLifeEvent_tLifeEventType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonLifeEventPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLifeEvent_tPerson");

            entity.HasOne(d => d.ResponseByPerson).WithMany(p => p.TPersonLifeEventResponseByPeople).HasConstraintName("FK_tPersonLifeEvent_tPerson_ApprovedByPersonGUID");
        });

        modelBuilder.Entity<TPersonLocationHist>(entity =>
        {
            entity.HasKey(e => e.PersonLocationGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonLocationStartDate }, "CIX_tPersonLocationHist_PersonGUID_PersonLocationStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonLocationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tCompany");

            entity.HasOne(d => d.CostCenterCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tCostCenter");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tDepartment");

            entity.HasOne(d => d.DivisionCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tDivision");

            entity.HasOne(d => d.FunctionalAreaCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tFunctionalArea");

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tLocation");

            entity.HasOne(d => d.LocationReasonCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tLocationReason");

            entity.HasOne(d => d.OrganizationUnitCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tOrganizationUnit");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonLocationHistPeople).HasConstraintName("FK_tPersonLocationHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tPosition");

            entity.HasOne(d => d.ProjectCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tProject");

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tRegion");

            entity.HasOne(d => d.SectionCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tSection");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.TPersonLocationHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonLocationHist_tShift");

            entity.HasOne(d => d.SupervisorPerson).WithMany(p => p.TPersonLocationHistSupervisorPeople).HasConstraintName("FK_tPersonLocationHist_Supervisor_tPerson");
        });

        modelBuilder.Entity<TPersonMedical>(entity =>
        {
            entity.Property(e => e.PersonGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BloodTypeCodeNavigation).WithMany(p => p.TPersonMedicals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonMedical_tBloodType");

            entity.HasOne(d => d.Person).WithOne(p => p.TPersonMedical).HasConstraintName("FK_tPersonMedical_tPerson");

            entity.HasOne(d => d.PrimaryMedicalFacilityCodeNavigation).WithMany(p => p.TPersonMedicals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonMedical_tMedicalFacility");

            entity.HasOne(d => d.PrimaryPhysicianCodeNavigation).WithMany(p => p.TPersonMedicals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonMedical_tPhysician");
        });

        modelBuilder.Entity<TPersonMilitaryHist>(entity =>
        {
            entity.HasKey(e => e.PersonMilitaryGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonMilitaryStartDate }, "CIX_tPersonMilitaryHist_PersonGUID_PersonMilitaryStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonMilitaryGuid).ValueGeneratedNever();

            entity.HasOne(d => d.MilitaryBranchCodeNavigation).WithMany(p => p.TPersonMilitaryHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonMilitaryHist_MilitaryBranch");

            entity.HasOne(d => d.MilitaryConflictCodeNavigation).WithMany(p => p.TPersonMilitaryHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonMilitaryHist_MilitaryConflict");

            entity.HasOne(d => d.MilitaryStatusCodeNavigation).WithMany(p => p.TPersonMilitaryHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonMilitaryHist_MilitaryStatus");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonMilitaryHists).HasConstraintName("FK_tPersonMilitaryHist_Person");

            entity.HasOne(d => d.ServiceCountryCodeNavigation).WithMany(p => p.TPersonMilitaryHists).HasConstraintName("FK_tPersonMilitaryHist_tCountry");
        });

        modelBuilder.Entity<TPersonNationalId>(entity =>
        {
            entity.HasKey(e => e.PersonNationalIdguid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonNationalID_PersonGUID").IsClustered();

            entity.Property(e => e.PersonNationalIdguid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonNationalIds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNationalID_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonNationalIds).HasConstraintName("FK_tPersonNationalID_tPerson");
        });

        modelBuilder.Entity<TPersonNomination>(entity =>
        {
            entity.HasKey(e => e.PersonNominationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonNomination_PersonGUID").IsClustered();

            entity.Property(e => e.PersonNominationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TPersonNominations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNomination_tJob");

            entity.HasOne(d => d.LastUpdatedByPerson).WithMany(p => p.TPersonNominationLastUpdatedByPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNomination_tPerson2");

            entity.HasOne(d => d.NominatedByPerson).WithMany(p => p.TPersonNominationNominatedByPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNomination_tPerson1");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonNominationPeople).HasConstraintName("FK_tPersonNomination_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonNominations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNomination_tPosition");
        });

        modelBuilder.Entity<TPersonNominationQuestion>(entity =>
        {
            entity.HasKey(e => e.PersonNominationQuestionGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonNominationGuid, "CIX_tPersonNominationQuestion_PersonNominationGUID").IsClustered();

            entity.Property(e => e.PersonNominationQuestionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.NominationQuestionSectionCodeNavigation).WithMany(p => p.TPersonNominationQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNominationQuestion_tNominationQuestionSection");

            entity.HasOne(d => d.PersonNomination).WithMany(p => p.TPersonNominationQuestions).HasConstraintName("FK_tPersonNominationQuestion_tPersonNomination");
        });

        modelBuilder.Entity<TPersonNominationQuestionSection>(entity =>
        {
            entity.HasKey(e => e.PersonNominationQuestionSectionGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonNominationGuid, "CIX_tPersonNominationQuestionSection_PersonNominationGUID").IsClustered();

            entity.Property(e => e.PersonNominationQuestionSectionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonNomination).WithMany(p => p.TPersonNominationQuestionSections).HasConstraintName("FK_tPersonNominationQuestionSection_tPersonNomination");
        });

        modelBuilder.Entity<TPersonNote>(entity =>
        {
            entity.HasKey(e => e.PersonNotesGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonNotes_PersonGUID").IsClustered();

            entity.Property(e => e.PersonNotesGuid).ValueGeneratedNever();
            entity.Property(e => e.Source).HasDefaultValueSql("('-')");

            entity.HasOne(d => d.NoteTypeCodeNavigation).WithMany(p => p.TPersonNotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonNotes_tNoteType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonNotes).HasConstraintName("FK_tPersonNotes_tPerson");
        });

        modelBuilder.Entity<TPersonOtherName>(entity =>
        {
            entity.HasKey(e => e.PersonOtherNameGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonOtherName_PersonGUID").IsClustered();

            entity.Property(e => e.PersonOtherNameGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonOtherNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherName_tCountry");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TPersonOtherNames).HasConstraintName("FK_tPersonOtherName_tLanguage");

            entity.HasOne(d => d.NameTypeCodeNavigation).WithMany(p => p.TPersonOtherNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonName_tNameType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonOtherNames).HasConstraintName("FK_tPersonOtherName_tPerson");
        });

        modelBuilder.Entity<TPersonOtherPayHist>(entity =>
        {
            entity.HasKey(e => e.PersonOtherPayGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonOtherPayStartDate }, "CIX_tPersonOtherPayHist_PersonGUID_PersonOtherPayStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonOtherPayGuid).ValueGeneratedNever();

            entity.HasOne(d => d.OtherPayReasonCodeNavigation).WithMany(p => p.TPersonOtherPayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_tOtherPayReason");

            entity.HasOne(d => d.OtherPayTypeCodeNavigation).WithMany(p => p.TPersonOtherPayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_tOtherPayType");

            entity.HasOne(d => d.PayrollCodeNavigation).WithMany(p => p.TPersonOtherPayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_tPayroll");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonOtherPayHistPeople).HasConstraintName("FK_tPersonOtherPayHist_tPerson");

            entity.HasOne(d => d.PersonOtherPayCurrencyCodeNavigation).WithMany(p => p.TPersonOtherPayHistPersonOtherPayCurrencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_tCurrency");

            entity.HasOne(d => d.PersonOtherPayFrequencyCodeNavigation).WithMany(p => p.TPersonOtherPayHistPersonOtherPayFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_tFrequency");

            entity.HasOne(d => d.PersonOtherPayPayrollFrequencyCodeNavigation).WithMany(p => p.TPersonOtherPayHistPersonOtherPayPayrollFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_Payroll_tFrequency");

            entity.HasOne(d => d.PlannedCurrencyCodeNavigation).WithMany(p => p.TPersonOtherPayHistPlannedCurrencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_Planned_tCurrency");

            entity.HasOne(d => d.PlannedFrequencyCodeNavigation).WithMany(p => p.TPersonOtherPayHistPlannedFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_Planned_tFrequency");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonOtherPayHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonOtherPayHist_tPosition");

            entity.HasOne(d => d.ReferringEmployeeNavigation).WithMany(p => p.TPersonOtherPayHistReferringEmployeeNavigations).HasConstraintName("FK_tPersonOtherPayHist_ReferringEmployee_tPerson");
        });

        modelBuilder.Entity<TPersonOvertimeHist>(entity =>
        {
            entity.HasKey(e => e.PersonOvertimeGuid).IsClustered(false);

            entity.Property(e => e.PersonOvertimeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonOvertimeHists).HasConstraintName("FK_tPersonOvertimeHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonOvertimeHists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonOvertimeHist_tPosition");

            entity.HasOne(d => d.ProjectCodeNavigation).WithMany(p => p.TPersonOvertimeHists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonOvertimeHist_tProject");

            entity.HasOne(d => d.TempDepartmentCodeNavigation).WithMany(p => p.TPersonOvertimeHists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonOvertimeHist_tDepartment");

            entity.HasOne(d => d.TimeGroupCodeNavigation).WithMany(p => p.TPersonOvertimeHists)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonOvertimeHist_tTimeGroup");
        });

        modelBuilder.Entity<TPersonPassport>(entity =>
        {
            entity.HasKey(e => e.PersonPassportGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonPassport_PersonGUID").IsClustered();

            entity.Property(e => e.PersonPassportGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonPassports)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPassport_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPassports).HasConstraintName("FK_tPersonPassport_tPerson");
        });

        modelBuilder.Entity<TPersonPayStubArchive>(entity =>
        {
            entity.HasKey(e => e.PersonPayStubArchiveGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonPayStubArchive_PersonGUID").IsClustered();

            entity.Property(e => e.PersonPayStubArchiveGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPayStubArchives).HasConstraintName("FK_tPersonPayStubArchive_tPerson");
        });

        modelBuilder.Entity<TPersonPerformanceHist>(entity =>
        {
            entity.HasKey(e => e.PersonPerformanceGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonPerformanceStartDate }, "CIX_tPersonPerformanceHist_PersonGUID_PersonPerformanceStartDate").IsClustered();

            entity.Property(e => e.PersonPerformanceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TPersonPerformanceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceHist_tJob");

            entity.HasOne(d => d.PerformanceRatingCodeNavigation).WithMany(p => p.TPersonPerformanceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceHist_tPerformanceRating");

            entity.HasOne(d => d.PerformanceReviewTypeCodeNavigation).WithMany(p => p.TPersonPerformanceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceHist_tPerformanceReviewType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPerformanceHistPeople).HasConstraintName("FK_tPersonPerformanceHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonPerformanceHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceHist_tPosition");

            entity.HasOne(d => d.RatedByPerson).WithMany(p => p.TPersonPerformanceHistRatedByPeople).HasConstraintName("FK_tPersonPerformanceHist_RatedBy_tPerson");

            entity.HasOne(d => d.SupervisorPerson).WithMany(p => p.TPersonPerformanceHistSupervisorPeople).HasConstraintName("FK_tPersonPerformanceHist_Supervisor_tPerson");
        });

        modelBuilder.Entity<TPersonPerformanceOverallComment>(entity =>
        {
            entity.HasKey(e => e.PersonPerformanceOverallCommentsGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonPerformanceGuid, e.PerformanceParticipantTypeCode }, "CIX_tPersonPerformanceOverallComments").IsClustered();

            entity.Property(e => e.PersonPerformanceOverallCommentsGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();

            entity.HasOne(d => d.PerformanceParticipantTypeCodeNavigation).WithMany(p => p.TPersonPerformanceOverallComments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceOverallComments_tPerformanceParticipantType");

            entity.HasOne(d => d.PersonPerformance).WithMany(p => p.TPersonPerformanceOverallComments).HasConstraintName("FK_tPersonPerformanceOverallComments_tPersonPerformanceHist");
        });

        modelBuilder.Entity<TPersonPerformanceParticipant>(entity =>
        {
            entity.HasKey(e => e.PersonPerformanceParticipantGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonPerformanceGuid, "CIX_tPersonPerformanceParticipant_PersonPerformanceGUID").IsClustered();

            entity.Property(e => e.PersonPerformanceParticipantGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ParticipantPerson).WithMany(p => p.TPersonPerformanceParticipants).HasConstraintName("FK_tPersonPerformanceParticipant_tPerson");

            entity.HasOne(d => d.PerformanceParticipant).WithMany(p => p.TPersonPerformanceParticipants).HasConstraintName("FK_tPersonPerformanceParticipant_tPerformanceParticipant");

            entity.HasOne(d => d.PerformanceParticipantTypeCodeNavigation).WithMany(p => p.TPersonPerformanceParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceParticipant_tPerformanceParticipantType");

            entity.HasOne(d => d.PersonPerformance).WithMany(p => p.TPersonPerformanceParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceParticipant_tPersonPerformanceHist");
        });

        modelBuilder.Entity<TPersonPerformanceQuestion>(entity =>
        {
            entity.HasKey(e => e.PerformanceQuestionGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonPerformanceGuid, "CIX_tPersonPerformanceQuestion_PersonPerformanceGUID").IsClustered();

            entity.Property(e => e.PerformanceQuestionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tCertification");

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tCompetency");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tCourse");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TPersonPerformanceQuestionLanguageCodeNavigations).HasConstraintName("FK_tPersonPerformanceQuestion_tLanguage");

            entity.HasOne(d => d.OverrideAssessmentTypeCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tPerformanceAssessmentType");

            entity.HasOne(d => d.PerformanceQuestionCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tPerformanceQuestion");

            entity.HasOne(d => d.PerformanceQuestionGroupCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceQuestion_tPerformanceQuestionGroup");

            entity.HasOne(d => d.PersonGoal).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tPersonGoal");

            entity.HasOne(d => d.PersonPerformance).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tPersonPerformanceHist");

            entity.HasOne(d => d.QuestionLanguageCodeNavigation).WithMany(p => p.TPersonPerformanceQuestionQuestionLanguageCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceQuestion_tQuestionLanguage");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TPersonPerformanceQuestions).HasConstraintName("FK_tPersonPerformanceQuestion_tTrainingProgram");
        });

        modelBuilder.Entity<TPersonPerformanceQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.PerformanceQuestionAnswerGuid).IsClustered(false);

            entity.HasIndex(e => e.PerformanceQuestionGuid, "CIX_tPersonPerformanceQuestionAnswer_PerformanceQuestionGUID").IsClustered();

            entity.Property(e => e.PerformanceQuestionAnswerGuid).ValueGeneratedNever();

            entity.HasOne(d => d.GoalProficiencyCodeNavigation).WithMany(p => p.TPersonPerformanceQuestionAnswers).HasConstraintName("FK_tPersonPerformanceQuestionAnswer_tProficiency");

            entity.HasOne(d => d.PerformanceAssessmentCodeNavigation).WithMany(p => p.TPersonPerformanceQuestionAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPerformanceQuestionAnswer_tPerformanceAssessment");

            entity.HasOne(d => d.PerformanceQuestion).WithMany(p => p.TPersonPerformanceQuestionAnswers).HasConstraintName("FK_tPersonPerformanceQuestionAnswer_tPersonPerformanceQuestion");

            entity.HasOne(d => d.PersonPerformanceParticipant).WithMany(p => p.TPersonPerformanceQuestionAnswers).HasConstraintName("FK_tPersonPerformanceQuestionAnswer_tPersonPerformanceParticipant");
        });

        modelBuilder.Entity<TPersonPerformanceQuestionAnswerJournal>(entity =>
        {
            entity.HasKey(e => e.PersonPerformanceQuestionAnswerJournalGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PerformanceQuestionAnswerGuid, e.JournalDate, e.PerformanceQuestionJournalTypeCode }, "CIX_tPersonPerformanceQuestionAnswerJournal").IsClustered();

            entity.Property(e => e.PersonPerformanceQuestionAnswerJournalGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.PerformanceQuestionAnswer).WithMany(p => p.TPersonPerformanceQuestionAnswerJournals).HasConstraintName("FK_tPersonPerformanceQuestionAnswerJournal_tPersonPerformanceQuestionAnswer");

            entity.HasOne(d => d.PerformanceQuestionJournalTypeCodeNavigation).WithMany(p => p.TPersonPerformanceQuestionAnswerJournals).HasConstraintName("FK_tPersonPerformanceQuestionAnswerJournal_tPerformanceQuestionJournalType");
        });

        modelBuilder.Entity<TPersonPhone>(entity =>
        {
            entity.HasKey(e => e.PersonPhoneGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonPhone_PersonGUID").IsClustered();

            entity.Property(e => e.PersonPhoneGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonPhones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPhone_tCountry");

            entity.HasOne(d => d.PersonAddress).WithMany(p => p.TPersonPhones).HasConstraintName("FK_tPersonPhone_tPersonAddress");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPhones).HasConstraintName("FK_tPersonPhone_tPerson");

            entity.HasOne(d => d.PhoneTypeCodeNavigation).WithMany(p => p.TPersonPhones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPhone_tPhoneType");
        });

        modelBuilder.Entity<TPersonProfessionalAffiliation>(entity =>
        {
            entity.HasKey(e => e.PersonProfessionalAffiliationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonProfessionalAffiliation_PersonGUID").IsClustered();

            entity.Property(e => e.PersonProfessionalAffiliationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonProfessionalAffiliations).HasConstraintName("FK_tPersonProfessionalAffiliation_tPerson");
        });

        modelBuilder.Entity<TPersonProjectHist>(entity =>
        {
            entity.Property(e => e.PersonProjectGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonProjectHists).HasConstraintName("FK_tPersonProjectHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonProjectHists).HasConstraintName("FK_tPersonProjectHist_tPosition");

            entity.HasOne(d => d.ProjectCodeNavigation).WithMany(p => p.TPersonProjectHists).HasConstraintName("FK_tPersonProjectHist_tProject");
        });

        modelBuilder.Entity<TPersonPropertyCardHist>(entity =>
        {
            entity.HasKey(e => e.PersonPropertyCardGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonPropertyCardStartDate }, "CIX_tPersonPropertyCardHist_PersonGUID_PersonPropertyCardStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonPropertyCardGuid).ValueGeneratedNever();

            entity.HasOne(d => d.IssueReasonCodeNavigation).WithMany(p => p.TPersonPropertyCardHistIssueReasonCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPropertyCardHist_Issue_tPropertyReason");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPropertyCardHists).HasConstraintName("FK_tPersonPropertyCardHist_tPerson");

            entity.HasOne(d => d.PropertyCardTypeCodeNavigation).WithMany(p => p.TPersonPropertyCardHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPropertyCardHist_tPropertyCardType");

            entity.HasOne(d => d.ReturnReasonCodeNavigation).WithMany(p => p.TPersonPropertyCardHistReturnReasonCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPropertyCardHist_Return_tPropertyReason");
        });

        modelBuilder.Entity<TPersonPropertyHist>(entity =>
        {
            entity.HasKey(e => e.PersonPropertyGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonPropertyStartDate }, "CIX_tPersonPropertyHist_PersonGUID_PersonPropertyStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonPropertyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.IssueReasonCodeNavigation).WithMany(p => p.TPersonPropertyHistIssueReasonCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPropertyHist_Issue_tPropertyReason");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPropertyHists).HasConstraintName("FK_tPersonPropertyHist_tPerson");

            entity.HasOne(d => d.PropertyCodeNavigation).WithMany(p => p.TPersonPropertyHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPropertyHist_tProperty");

            entity.HasOne(d => d.ReturnReasonCodeNavigation).WithMany(p => p.TPersonPropertyHistReturnReasonCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPropertyHist_Return_tPropertyReason");
        });

        modelBuilder.Entity<TPersonPublishedWork>(entity =>
        {
            entity.HasKey(e => e.PersonPublishedWorkGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonPublishedWork_PersonGUID").IsClustered();

            entity.Property(e => e.PersonPublishedWorkGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonPublishedWorks).HasConstraintName("FK_tPersonPublishedWork_tPerson");

            entity.HasOne(d => d.PublishedWorkTypeCodeNavigation).WithMany(p => p.TPersonPublishedWorks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonPublishedWork_tPublishedWorkType");
        });

        modelBuilder.Entity<TPersonReference>(entity =>
        {
            entity.HasKey(e => e.PersonReferenceGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonReference_PersonGUID").IsClustered();

            entity.Property(e => e.PersonReferenceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonReferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonReference_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonReferences).HasConstraintName("FK_tPersonReference_tPerson");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonReferences)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonReference_tStateProvince");
        });

        modelBuilder.Entity<TPersonScheduleDate>(entity =>
        {
            entity.HasKey(e => e.PersonScheduleDateGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonScheduleDate_PersonGUID").IsClustered();

            entity.Property(e => e.PersonScheduleDateGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonScheduleDates).HasConstraintName("FK_tPersonScheduleDate_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonScheduleDates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonScheduleDate_tPosition");
        });

        modelBuilder.Entity<TPersonSocialNetwork>(entity =>
        {
            entity.Property(e => e.PersonSocialNetworkGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonSocialNetworks).HasConstraintName("FK_tPersonSocialNetwork_tPerson");

            entity.HasOne(d => d.SocialNetworkTypeCodeNavigation).WithMany(p => p.TPersonSocialNetworks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonSocialNetwork_tSocialNetworkType");
        });

        modelBuilder.Entity<TPersonSpeakingEngagement>(entity =>
        {
            entity.HasKey(e => e.PersonSpeakingEngagementGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonSpeakingEngagement_PersonGUID").IsClustered();

            entity.Property(e => e.PersonSpeakingEngagementGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonSpeakingEngagements).HasConstraintName("FK_tPersonSpeakingEngagement_tPerson");
        });

        modelBuilder.Entity<TPersonSpecialAccommodation>(entity =>
        {
            entity.HasKey(e => e.PersonSpecialAccommodationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonSpecialAccommodation_PersonGUID").IsClustered();

            entity.Property(e => e.PersonSpecialAccommodationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonSpecialAccommodations).HasConstraintName("FK_tPersonSpecialAccommodation_tPerson");
        });

        modelBuilder.Entity<TPersonStatusHist>(entity =>
        {
            entity.HasKey(e => e.PersonStatusGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonStatusStartDate }, "CIX_tPersonStatusHist_PersonGUID_PersonStatusStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonStatusGuid).ValueGeneratedNever();

            entity.HasOne(d => d.HireSourceCodeNavigation).WithMany(p => p.TPersonStatusHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonStatusHist_tHireSource");

            entity.HasOne(d => d.InternationalTypeCodeNavigation).WithMany(p => p.TPersonStatusHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonStatusHist_tInternationalType");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonStatusHists).HasConstraintName("FK_tPersonStatusHist_tPerson");

            entity.HasOne(d => d.StatusCategoryCodeNavigation).WithMany(p => p.TPersonStatusHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonStatusHist_tStatusCategory");

            entity.HasOne(d => d.StatusCodeNavigation).WithMany(p => p.TPersonStatusHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonStatusHist_tStatus");

            entity.HasOne(d => d.StatusReasonCodeNavigation).WithMany(p => p.TPersonStatusHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonStatusHist_tStatusReason");

            entity.HasOne(d => d.WesleyCalendarCodeNavigation).WithMany(p => p.TPersonStatusHists).HasConstraintName("FK_tPersonStatusHist_WesleyCalendarCode_tWesleyCalendar");
        });

        modelBuilder.Entity<TPersonTax>(entity =>
        {
            entity.Property(e => e.PersonGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CsfAnzTaxCurrencyCodeNavigation).WithMany(p => p.TPersonTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTax_tCurrency");

            entity.HasOne(d => d.Person).WithOne(p => p.TPersonTaxPerson).HasConstraintName("FK_tPersonTax_tPerson");

            entity.HasOne(d => d.SignedByPerson).WithMany(p => p.TPersonTaxSignedByPeople).HasConstraintName("FK_tPersonTax_SignedBy_tPerson");

            entity.HasOne(d => d.SuisditaxCodeNavigation).WithMany(p => p.TPersonTaxes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTax_tSUISDITax");
        });

        modelBuilder.Entity<TPersonTermination>(entity =>
        {
            entity.HasKey(e => e.PersonTerminationGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonTermination_PersonGUID").IsClustered();

            entity.Property(e => e.PersonTerminationGuid).ValueGeneratedNever();
            entity.Property(e => e.RecommendForRehire).HasDefaultValueSql("('Default_Zero')");

            entity.HasOne(d => d.CheckListVerifiedByPerson).WithMany(p => p.TPersonTerminationCheckListVerifiedByPeople).HasConstraintName("FK_tPersonTermination_CheckListVerifiedBy_tPerson");

            entity.HasOne(d => d.ExitInterviewerPerson).WithMany(p => p.TPersonTerminationExitInterviewerPeople).HasConstraintName("FK_tPersonTermination_ExitInterviewer_tPerson");

            entity.HasOne(d => d.NextEmployerSalaryCurrencyCodeNavigation).WithMany(p => p.TPersonTerminationNextEmployerSalaryCurrencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTermination_tCurrency");

            entity.HasOne(d => d.NextEmployerSalaryFrequencyCodeNavigation).WithMany(p => p.TPersonTerminations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTermination_NextEmployerSalary_tFrequency");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonTerminationPeople).HasConstraintName("FK_tPersonTermination_tPerson");

            entity.HasOne(d => d.SeverancePayCurrencyCodeNavigation).WithMany(p => p.TPersonTerminationSeverancePayCurrencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTermination_SeverancePay_tCurrency");

            entity.HasOne(d => d.TerminationReasonCodeNavigation).WithMany(p => p.TPersonTerminations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTermination_tTerminationReason");

            entity.HasOne(d => d.TerminationTypeCodeNavigation).WithMany(p => p.TPersonTerminations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTermination_tTerminationType");

            entity.HasOne(d => d.UnusedVacationPayCurrencyCodeNavigation).WithMany(p => p.TPersonTerminationUnusedVacationPayCurrencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTermination_UnusedVacationPay_tCurrency");
        });

        modelBuilder.Entity<TPersonTimeDetail>(entity =>
        {
            entity.HasKey(e => e.TimeDetailGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.EntryDate, e.PositionCode }, "CIX_tPersonTimeDetail").IsClustered();

            entity.Property(e => e.TimeDetailGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tCompany");

            entity.HasOne(d => d.CostCenterCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tCostCenter");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tDepartment");

            entity.HasOne(d => d.DivisionCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tDivision");

            entity.HasOne(d => d.FunctionalAreaCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tFunctionalArea");

            entity.HasOne(d => d.HolidayOccurrence).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonTimeDetail_tHolidayOccurrence");

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tLocation");

            entity.HasOne(d => d.OrganizationUnitCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tOrganizationUnit");

            entity.HasOne(d => d.PersonAbsence).WithMany(p => p.TPersonTimeDetails).HasConstraintName("FK_tPersonTimeDetail_tPersonAbsenceHist");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonTimeDetailPeople).HasConstraintName("FK_tPersonTimeDetail_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tPosition");

            entity.HasOne(d => d.ProjectCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tProject");

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tRegion");

            entity.HasOne(d => d.RevisedByPerson).WithMany(p => p.TPersonTimeDetailRevisedByPeople).HasConstraintName("FK_tPersonTimeDetail_RevisedBy_tPerson");

            entity.HasOne(d => d.SectionCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tSection");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tShift");

            entity.HasOne(d => d.TimeTypeCodeNavigation).WithMany(p => p.TPersonTimeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeDetail_tTimeType");
        });

        modelBuilder.Entity<TPersonTimeDetailErp>(entity =>
        {
            entity.Property(e => e.PersonTimeDetailErpguid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TPersonTimeGroupHist>(entity =>
        {
            entity.HasKey(e => e.PersonTimeGroupGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonTimeGroupStartDate }, "CIX_tPersonTimeGroupHist_PersonGUID_PersonTimeGroupStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonTimeGroupGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonTimeGroupHists).HasConstraintName("FK_tPersonTimeGroupHist_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonTimeGroupHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeGroupHist_tPosition");

            entity.HasOne(d => d.TimeGroupCodeNavigation).WithMany(p => p.TPersonTimeGroupHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeGroupHist_tTimeGroup");

            entity.HasOne(d => d.TimeZoneCodeNavigation).WithMany(p => p.TPersonTimeGroupHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeGroupHist_tTimeZone");
        });

        modelBuilder.Entity<TPersonTimeGroupPeriod>(entity =>
        {
            entity.HasKey(e => e.PersonTimeGroupPeriodGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PositionCode }, "CIX_tPersonTimeGroupPeriod_PersonGUID_PositionCode").IsClustered();

            entity.Property(e => e.PersonTimeGroupPeriodGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonTimeGroupPeriods).HasConstraintName("FK_tPersonTimeGroupPeriod_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPersonTimeGroupPeriods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeGroupPeriod_tPosition");

            entity.HasOne(d => d.TimeGroupPeriod).WithMany(p => p.TPersonTimeGroupPeriods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeGroupPeriod_tTimeGroupPeriod");
        });

        modelBuilder.Entity<TPersonTimeGroupPeriodOvertime>(entity =>
        {
            entity.HasKey(e => e.PersonTimeGroupPeriodOvertimeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonTimeGroupPeriodGuid, e.EntryDate }, "CIX_tPersonTimeGroupPeriodOvertime").IsClustered();

            entity.Property(e => e.PersonTimeGroupPeriodOvertimeGuid).ValueGeneratedNever();
            entity.Property(e => e.OvertimeType).IsFixedLength();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AbsencePlanCodeNavigation).WithMany(p => p.TPersonTimeGroupPeriodOvertimes)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tPersonTimeGroupPeriodOvertime_tAbsencePlan");

            entity.HasOne(d => d.PersonTimeGroupPeriod).WithMany(p => p.TPersonTimeGroupPeriodOvertimes).HasConstraintName("FK_tPersonTimeGroupPeriodOvertime_tPersonTimeGroupPeriod");

            entity.HasOne(d => d.TimeTypeCodeNavigation).WithMany(p => p.TPersonTimeGroupPeriodOvertimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTimeGroupPeriodOvertime_tTimeType");
        });

        modelBuilder.Entity<TPersonTraining>(entity =>
        {
            entity.HasKey(e => e.PersonTrainingGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonTraining_PersonGUID").IsClustered();

            entity.Property(e => e.PersonTrainingGuid).ValueGeneratedNever();

            entity.HasOne(d => d.AttendanceCodeNavigation).WithMany(p => p.TPersonTrainings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_tAttendance");

            entity.HasOne(d => d.Class).WithMany(p => p.TPersonTrainings).HasConstraintName("FK_tPersonTraining_tClass");

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.TPersonTrainings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_tCompany");

            entity.HasOne(d => d.CostDepartmentCodeNavigation).WithMany(p => p.TPersonTrainingCostDepartmentCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_Cost_tDepartment");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TPersonTrainings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_tCourse");

            entity.HasOne(d => d.HowAcquiredCodeNavigation).WithMany(p => p.TPersonTrainings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_tHowAcquired");

            entity.HasOne(d => d.PersonGoal).WithMany(p => p.TPersonTrainings).HasConstraintName("FK_tPersonTraining_tPersonGoal");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonTrainings).HasConstraintName("FK_tPersonTraining_tPerson");

            entity.HasOne(d => d.PersonTrainingCurrencyCodeNavigation).WithMany(p => p.TPersonTrainings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_tCurrency");

            entity.HasOne(d => d.TrainingCompletionCodeNavigation).WithMany(p => p.TPersonTrainings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_tTrainingCompletion");

            entity.HasOne(d => d.TuitionDepartmentCodeNavigation).WithMany(p => p.TPersonTrainingTuitionDepartmentCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTraining_Tuition_tDepartment");
        });

        modelBuilder.Entity<TPersonTrainingExpense>(entity =>
        {
            entity.HasKey(e => e.PersonTrainingExpenseGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonTrainingGuid, "CIX_tPersonTrainingExpense_PersonTrainingGUID").IsClustered();

            entity.Property(e => e.PersonTrainingExpenseGuid).ValueGeneratedNever();

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TPersonTrainingExpenses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTrainingExpense_tDepartment");

            entity.HasOne(d => d.ExpenseTypeCodeNavigation).WithMany(p => p.TPersonTrainingExpenses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTrainingExpense_tExpense");

            entity.HasOne(d => d.PersonTrainingExpenseCurrencyCodeNavigation).WithMany(p => p.TPersonTrainingExpenses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonTrainingExpense_tCurrency");

            entity.HasOne(d => d.PersonTraining).WithMany(p => p.TPersonTrainingExpenses).HasConstraintName("FK_tPersonTrainingExpense_tPersonTraining");
        });

        modelBuilder.Entity<TPersonTrainingProgram>(entity =>
        {
            entity.Property(e => e.PersonTrainingProgramGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.PersonGoal).WithMany(p => p.TPersonTrainingPrograms).HasConstraintName("FK_tPersonTrainingProgram_tPersonGoal");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonTrainingPrograms).HasConstraintName("FK_tPersonTrainingProgram_tPerson");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TPersonTrainingPrograms).HasConstraintName("FK_tPersonTrainingProgram_tTrainingProgram");
        });

        modelBuilder.Entity<TPersonUnionHist>(entity =>
        {
            entity.HasKey(e => e.PersonUnionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.PersonUnionStartDate }, "CIX_tPersonUnionHist_PersonGUID_PersonUnionStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PersonUnionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BargainingUnitCodeNavigation).WithMany(p => p.TPersonUnionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonUnionHist_tBargainingUnit");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonUnionHists).HasConstraintName("FK_tPersonUnionHist_tPerson");

            entity.HasOne(d => d.UnionCodeNavigation).WithMany(p => p.TPersonUnionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonUnionHist_tUnion");
        });

        modelBuilder.Entity<TPersonVeteran>(entity =>
        {
            entity.HasKey(e => e.PersonVeteranGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.VeteranCode }, "AK_tPersonVeteran")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonVeteranGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonVeterans).HasConstraintName("FK_tPersonVeteran_tPerson");

            entity.HasOne(d => d.VeteranCodeNavigation).WithMany(p => p.TPersonVeterans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonVeteran_tVeteran");
        });

        modelBuilder.Entity<TPersonVisa>(entity =>
        {
            entity.HasKey(e => e.PersonVisaGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonVisa_PersonGUID").IsClustered();

            entity.Property(e => e.PersonVisaGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonVisas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonVisa_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonVisas).HasConstraintName("FK_tPersonVisa_tPerson");

            entity.HasOne(d => d.VisaTypeCodeNavigation).WithMany(p => p.TPersonVisas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonVisa_tVisaType");
        });

        modelBuilder.Entity<TPersonW2>(entity =>
        {
            entity.HasKey(e => e.PersonW2guid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.ReportingPeriodStartDate, e.ReportingPeriodEndDate, e.LocationCode }, "AK_tPersonW2")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonW2guid).ValueGeneratedNever();

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.TPersonW2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonW2_tLocation");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonW2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonW2_tPerson");
        });

        modelBuilder.Entity<TPersonWaitList>(entity =>
        {
            entity.HasKey(e => e.PersonWaitListGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonWaitList_PersonGUID").IsClustered();

            entity.Property(e => e.PersonWaitListGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Class).WithMany(p => p.TPersonWaitLists).HasConstraintName("FK_tPersonWaitList_tClass");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TPersonWaitLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonWaitList_tCourse");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonWaitLists).HasConstraintName("FK_tPersonWaitList_tPerson");
        });

        modelBuilder.Entity<TPersonWorkEligibility>(entity =>
        {
            entity.HasKey(e => e.PersonWorkEligibilityGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.EffectiveDate }, "AK_tPersonWorkEligibility")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonWorkEligibilityGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPersonWorkEligibilities).HasConstraintName("FK_tPersonWorkEligibility_tCountry");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonWorkEligibilityPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonWorkEligibility_tPerson");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPersonWorkEligibilities).HasConstraintName("FK_tPersonWorkEligibility_tStateProvince");

            entity.HasOne(d => d.VerifiedByPerson).WithMany(p => p.TPersonWorkEligibilityVerifiedByPeople).HasConstraintName("FK_tPersonWorkEligibility_tPerson_VerifiedBy");
        });

        modelBuilder.Entity<TPersonWorkEligibilityFile>(entity =>
        {
            entity.Property(e => e.PersonWorkEligibilityFileGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonWorkEligibility).WithMany(p => p.TPersonWorkEligibilityFiles).HasConstraintName("FK_tPersonWorkEligibilityFile_tPersonWorkEligibility");

            entity.HasOne(d => d.WorkEligibilityDocumentTypeCodeNavigation).WithMany(p => p.TPersonWorkEligibilityFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonWorkEligibilityFile_tWorkEligibilityDocumentType");
        });

        modelBuilder.Entity<TPersonWorksCouncilHist>(entity =>
        {
            entity.HasKey(e => e.PersonWorksCouncilGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.WorksCouncilCode, e.PersonWorksCouncilStartDate }, "AK_tPersonWorksCouncilHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PersonWorksCouncilGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonWorksCouncilHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonWorksCouncilHist_tPerson");

            entity.HasOne(d => d.WorksCouncilCodeNavigation).WithMany(p => p.TPersonWorksCouncilHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonWorksCouncilHist_tWorksCouncil");

            entity.HasOne(d => d.WorksCouncilRoleCodeNavigation).WithMany(p => p.TPersonWorksCouncilHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonWorksCouncilHist_tWorksCouncilRole");
        });

        modelBuilder.Entity<TPersonYearToDateEarning>(entity =>
        {
            entity.HasKey(e => e.PersonYearToDateEarningsGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonGuid, "CIX_tPersonYearToDateEarnings_PersonGUID").IsClustered();

            entity.Property(e => e.PersonYearToDateEarningsGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PayrollAccumulatorCodeNavigation).WithMany(p => p.TPersonYearToDateEarnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonYearToDateEarnings_tPayrollAccumulator");

            entity.HasOne(d => d.PayrollCodeNavigation).WithMany(p => p.TPersonYearToDateEarnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonYearToDateEarnings_tPayroll");

            entity.HasOne(d => d.Person).WithMany(p => p.TPersonYearToDateEarnings).HasConstraintName("FK_tPersonYearToDateEarnings_tPerson");

            entity.HasOne(d => d.PersonYearToDateEarningsCurrencyCodeNavigation).WithMany(p => p.TPersonYearToDateEarnings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonYearToDateEarnings_tCurrency");
        });

        modelBuilder.Entity<TPersonal>(entity =>
        {
            entity.Property(e => e.PersonGuid).ValueGeneratedNever();

            entity.HasOne(d => d.BirthCountryCodeNavigation).WithMany(p => p.TPersonalBirthCountryCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_Birth_tCountry");

            entity.HasOne(d => d.CitizenCountryCodeNavigation).WithMany(p => p.TPersonalCitizenCountryCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_Citizen_tCountry");

            entity.HasOne(d => d.DisabilityCodeNavigation).WithMany(p => p.TPersonals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_tDisability");

            entity.HasOne(d => d.DriversLicenseStateProvinceCodeNavigation).WithMany(p => p.TPersonals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_tStateProvince");

            entity.HasOne(d => d.EthnicGroupCodeNavigation).WithMany(p => p.TPersonals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_tEthnicGroup");

            entity.HasOne(d => d.FamilyStatusCodeNavigation).WithMany(p => p.TPersonals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_tFamilyStatus");

            entity.HasOne(d => d.GenderCodeNavigation).WithMany(p => p.TPersonals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPersonal_tGender");

            entity.HasOne(d => d.Person).WithOne(p => p.TPersonal).HasConstraintName("FK_tPersonal_tPerson");
        });

        modelBuilder.Entity<TPhoneType>(entity =>
        {
            entity.Property(e => e.PhoneTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPhoneType','PhoneTypeDescription',[PhoneTypeGUID]))", false);
        });

        modelBuilder.Entity<TPhysician>(entity =>
        {
            entity.Property(e => e.Name).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPhysician','Name',[PhysicianGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TPhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPhysician_tCountry");

            entity.HasOne(d => d.PhysicianTypeCodeNavigation).WithMany(p => p.TPhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPhysician_tPhysicianType");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TPhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPhysician_tStateProvince");
        });

        modelBuilder.Entity<TPhysicianType>(entity =>
        {
            entity.Property(e => e.PhysicianTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPhysicianType','PhysicianTypeDescription',[PhysicianTypeGUID]))", false);
        });

        modelBuilder.Entity<TPosition>(entity =>
        {
            entity.Property(e => e.PositionTitle).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPosition','PositionTitle',[PositionGUID]))", false);
        });

        modelBuilder.Entity<TPositionBudgetHist>(entity =>
        {
            entity.HasKey(e => e.PositionBudgetGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PositionCode, e.PositionBudgetStartDate }, "AK_tPositionBudgetHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PositionBudgetGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PayRateFrequencyCodeNavigation).WithMany(p => p.TPositionBudgetHists).HasConstraintName("FK_tPositionBudgetHist_tFrequency");

            entity.HasOne(d => d.PositionBudgetCurrencyCodeNavigation).WithMany(p => p.TPositionBudgetHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionBudgetHist_tCurrency");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPositionBudgetHists).HasConstraintName("FK_tPositionBudgetHist_tPosition");
        });

        modelBuilder.Entity<TPositionFundingHist>(entity =>
        {
            entity.HasKey(e => e.PositionFundingGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PositionBudgetGuid, e.PositionFundingStartDate }, "CIX_tPositionFundingHist_PositionBudgetGUID_PositionFundingStartDate")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.PositionFundingGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ContactCountryCodeNavigation).WithMany(p => p.TPositionFundingHists).HasConstraintName("FK_tPositionFundingHist_tCountry");

            entity.HasOne(d => d.FundingSourceCodeNavigation).WithMany(p => p.TPositionFundingHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionFundingHist_tFundingSource");

            entity.HasOne(d => d.PositionBudget).WithMany(p => p.TPositionFundingHists).HasConstraintName("FK_tPositionFundingHist_tPosition");

            entity.HasOne(d => d.PositionFundingFrequencyCodeNavigation).WithMany(p => p.TPositionFundingHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionFundingHist_tFrequency");
        });

        modelBuilder.Entity<TPositionHist>(entity =>
        {
            entity.HasKey(e => e.PositionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PositionCode, e.PositionStartDate }, "AK_tPositionHist")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PositionGuid).ValueGeneratedNever();
            entity.Property(e => e.PositionTitle).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPositionHist','PositionTitle',[PositionGUID]))", false);

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tCompany");

            entity.HasOne(d => d.CostCenterCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tCostCenter");

            entity.HasOne(d => d.CurrentPositionStatusCodeNavigation).WithMany(p => p.TPositionHistCurrentPositionStatusCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tPositionStatus_CurrentStatus");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tDepartment");

            entity.HasOne(d => d.DivisionCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tDivision");

            entity.HasOne(d => d.FunctionalAreaCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tFunctionalArea");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tJob");

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tLocation");

            entity.HasOne(d => d.OrgPublisherPositionTypeCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tOrgPublisherPositionType");

            entity.HasOne(d => d.OrganizationUnitCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tOrganizationUnit");

            entity.HasOne(d => d.PitpositionStatusCodeNavigation).WithMany(p => p.TPositionHistPitpositionStatusCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tPositionStatus_PITStatus");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TPositionHistPositionCodeNavigations).HasConstraintName("FK_tPositionHist_tPosition");

            entity.HasOne(d => d.ProjectCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tProject");

            entity.HasOne(d => d.RegionCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tRegion");

            entity.HasOne(d => d.ReportsToPositionCodeNavigation).WithMany(p => p.TPositionHistReportsToPositionCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tPosition_ReportsTo");

            entity.HasOne(d => d.SectionCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tSection");

            entity.HasOne(d => d.ShiftCodeNavigation).WithMany(p => p.TPositionHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tPositionHist_tShift");
        });

        modelBuilder.Entity<TPositionStatus>(entity =>
        {
            entity.Property(e => e.PositionStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPositionStatus','PositionStatusDescription',[PositionStatusGUID]))", false);
        });

        modelBuilder.Entity<TPrimaryPolicy>(entity =>
        {
            entity.Property(e => e.PrimaryPolicyGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<TProfessionalLevel>(entity =>
        {
            entity.Property(e => e.ProfessionalLevelDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tProfessionalLevel','ProfessionalLevelDescription',[ProfessionalLevelGUID]))", false);
        });

        modelBuilder.Entity<TProficiency>(entity =>
        {
            entity.Property(e => e.ProficiencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tProficiency','ProficiencyDescription',[ProficiencyGUID]))", false);

            entity.HasOne(d => d.ScaleCodeNavigation).WithMany(p => p.TProficiencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tProficiency_tScale");
        });

        modelBuilder.Entity<TProject>(entity =>
        {
            entity.Property(e => e.ProjectDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tProject','ProjectDescription',[ProjectGUID]))", false);

            entity.HasOne(d => d.CreatedByPerson).WithMany(p => p.TProjects).HasConstraintName("FK_tProject_tPerson");

            entity.HasOne(d => d.ProjectBudgetCurrencyCodeNavigation).WithMany(p => p.TProjects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tProject_tCurrency");
        });

        modelBuilder.Entity<TProperty>(entity =>
        {
            entity.Property(e => e.PropertyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tProperty','PropertyDescription',[PropertyGUID]))", false);

            entity.HasOne(d => d.PropertyTypeCodeNavigation).WithMany(p => p.TProperties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tProperty_tPropertyType");
        });

        modelBuilder.Entity<TPropertyCardType>(entity =>
        {
            entity.Property(e => e.PropertyCardTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPropertyCardType','PropertyCardTypeDescription',[PropertyCardTypeGUID]))", false);
        });

        modelBuilder.Entity<TPropertyReason>(entity =>
        {
            entity.Property(e => e.PropertyReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPropertyReason','PropertyReasonDescription',[PropertyReasonGUID]))", false);
        });

        modelBuilder.Entity<TPropertyType>(entity =>
        {
            entity.Property(e => e.PropertyTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPropertyType','PropertyTypeDescription',[PropertyTypeGUID]))", false);
        });

        modelBuilder.Entity<TPublishedWorkType>(entity =>
        {
            entity.Property(e => e.PublishedWorkTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tPublishedWorkType','PublishedWorkTypeDescription',[PublishedWorkTypeGUID]))", false);
        });

        modelBuilder.Entity<TRecruitingAgreement>(entity =>
        {
            entity.HasKey(e => e.RecruitingAgreementGuid).IsClustered(false);

            entity.HasIndex(e => e.RecruitingFirmCode, "CIX_tRecruitingAgreement_RecruitingFirmCode").IsClustered();

            entity.Property(e => e.RecruitingAgreementGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PaymentAmountCurrencyCodeNavigation).WithMany(p => p.TRecruitingAgreements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRecruitingFirmAgreement_tCurrency");

            entity.HasOne(d => d.RecruitingAgreementTypeCodeNavigation).WithMany(p => p.TRecruitingAgreements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSearchFirmAgreement_tSearchFirmAgreementType1");

            entity.HasOne(d => d.RecruitingFirmCodeNavigation).WithMany(p => p.TRecruitingAgreements).HasConstraintName("FK_tRecruitingFirmAgreement_tSearchFirm");
        });

        modelBuilder.Entity<TRecruitingAgreementType>(entity =>
        {
            entity.Property(e => e.RecruitingAgreementTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRecruitingAgreementType','RecruitingAgreementTypeDescription',[RecruitingAgreementTypeGUID]))", false);
        });

        modelBuilder.Entity<TRecruitingExpense>(entity =>
        {
            entity.HasKey(e => e.RecruitingExpenseGuid).IsClustered(false);

            entity.HasIndex(e => e.PersonApplicationGuid, "CIX_tRecruitingExpense_PersonApplicationGUID").IsClustered();

            entity.Property(e => e.RecruitingExpenseGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ApprovedByPerson).WithMany(p => p.TRecruitingExpenses).HasConstraintName("FK_tRecruitingExpense_tPerson");

            entity.HasOne(d => d.ExpenseAmountCurrencyCodeNavigation).WithMany(p => p.TRecruitingExpenses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRecruitingExpense_tCurrency");

            entity.HasOne(d => d.PersonApplication).WithMany(p => p.TRecruitingExpenses)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tRecruitingExpense_tPersonApplication");

            entity.HasOne(d => d.RecruitingExpenseCategoryCodeNavigation).WithMany(p => p.TRecruitingExpenses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRequisitionExpense_tRequisitionExpenseType");

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TRecruitingExpenses).HasConstraintName("FK_tRequisitionExpense_tRequisition");
        });

        modelBuilder.Entity<TRecruitingExpenseAllocation>(entity =>
        {
            entity.HasKey(e => e.RecruitingExpenseAllocationGuid).IsClustered(false);

            entity.HasIndex(e => e.RecruitingExpenseGuid, "CIX_tRecruitingExpenseAllocation_RecruitingExpenseGUID").IsClustered();

            entity.Property(e => e.RecruitingExpenseAllocationGuid).ValueGeneratedNever();
            entity.Property(e => e.AllocationDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRecruitingExpenseAllocation','AllocationDescription',[RecruitingExpenseAllocationGUID]))", false);

            entity.HasOne(d => d.AllocationAmountCurrencyCodeNavigation).WithMany(p => p.TRecruitingExpenseAllocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRecruitingExpenseAllocation_tCurrency");

            entity.HasOne(d => d.AllocationPerson).WithMany(p => p.TRecruitingExpenseAllocations).HasConstraintName("FK_tRecruitingExpenseAllocation_tPerson");

            entity.HasOne(d => d.RecruitingExpense).WithMany(p => p.TRecruitingExpenseAllocations).HasConstraintName("FK_tRequisitionExpenseAllocation_tRequisitionExpense");
        });

        modelBuilder.Entity<TRecruitingExpenseCategory>(entity =>
        {
            entity.HasKey(e => e.RecruitingExpenseCategoryCode).HasName("PK_tRequisitionExpenseCategory");

            entity.Property(e => e.RecruitingExpenseCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRecruitingExpenseCategory','RecruitingExpenseCategoryDescription',[RecruitingExpenseCategoryGUID]))", false);
        });

        modelBuilder.Entity<TRecruitingFirm>(entity =>
        {
            entity.Property(e => e.Name).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRecruitingFirm','Name',[RecruitingFirmGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TRecruitingFirms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRecruitingFirm_tCountry");

            entity.HasOne(d => d.RecruitingSpecialtyCodeNavigation).WithMany(p => p.TRecruitingFirms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRecruitingFirm_tRecruitingSpecialty");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TRecruitingFirms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRecruitingFirm_tStateProvince");
        });

        modelBuilder.Entity<TRecruitingSpecialty>(entity =>
        {
            entity.Property(e => e.RecruitingSpecialtyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRecruitingSpecialty','RecruitingSpecialtyDescription',[RecruitingSpecialtyGUID]))", false);
        });

        modelBuilder.Entity<TReferralSource>(entity =>
        {
            entity.Property(e => e.ReferralSourceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tReferralSource','ReferralSourceDescription',[ReferralSourceGUID]))", false);
        });

        modelBuilder.Entity<TRegion>(entity =>
        {
            entity.Property(e => e.RegionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRegion','RegionDescription',[RegionGUID]))", false);
        });

        modelBuilder.Entity<TRelationship>(entity =>
        {
            entity.Property(e => e.RelationshipDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRelationship','RelationshipDescription',[RelationshipGUID]))", false);
        });

        modelBuilder.Entity<TRequisition>(entity =>
        {
            entity.Property(e => e.OpenFlag).HasComputedColumnSql("(CONVERT([bit],case when [CloseDate] IS NOT NULL AND [CloseDate]<=getdate() then (0) else (1) end,(0)))", false);
            entity.Property(e => e.RequisitionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisition','RequisitionDescription',[RequisitionGUID]))", false);

            entity.HasOne(d => d.ApprovedByPerson).WithMany(p => p.TRequisitionApprovedByPeople).HasConstraintName("FK_tRequisition_ApprovedBy_tPerson");

            entity.HasOne(d => d.CreatedByPerson).WithMany(p => p.TRequisitionCreatedByPeople).HasConstraintName("FK_tRequisition_CreatedBy_tPerson");

            entity.HasOne(d => d.DepartmentCodeNavigation).WithMany(p => p.TRequisitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRequisition_tDepartment");

            entity.HasOne(d => d.ExternalRecruiterCodeNavigation).WithMany(p => p.TRequisitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRequisition_tExternalRecruiter");

            entity.HasOne(d => d.ExternalTaskData).WithMany(p => p.TRequisitionExternalTaskData).HasConstraintName("FK_tRequisition_USysTaskData_External");

            entity.HasOne(d => d.InternalRecruiterPerson).WithMany(p => p.TRequisitionInternalRecruiterPeople).HasConstraintName("FK_tRequisition_InternalRecruiter_tPerson");

            entity.HasOne(d => d.InternalTaskData).WithMany(p => p.TRequisitionInternalTaskData).HasConstraintName("FK_tRequisition_USysTaskData_Internal");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TRequisitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRequisition_tJob");

            entity.HasOne(d => d.LastModifiedByPerson).WithMany(p => p.TRequisitionLastModifiedByPeople).HasConstraintName("FK_tRequisition_LastModifiedBy_tPerson");

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.TRequisitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRequisition_tLocation");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.TRequisitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tRequisition_tPosition");

            entity.HasOne(d => d.ReportsToPerson).WithMany(p => p.TRequisitionReportsToPeople).HasConstraintName("FK_tRequisition_ReportsTo_tPerson");

            entity.HasOne(d => d.StatusCategoryCodeNavigation).WithMany(p => p.TRequisitions).HasConstraintName("FK_tRequisition_StatusCategoryCode");

            entity.HasOne(d => d.TaskData).WithMany(p => p.TRequisitionTaskData).HasConstraintName("FK_tRequisition_USysTaskData");
        });

        modelBuilder.Entity<TRequisitionEmployeesHired>(entity =>
        {
            entity.Property(e => e.RequisitionEmployeesHiredGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.HiredPerson).WithMany(p => p.TRequisitionEmployeesHireds).HasConstraintName("FK_tRequisitionEmployeesHired_tPerson");

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TRequisitionEmployeesHireds).HasConstraintName("FK_tRequisitionEmployeesHired_tRequisition");
        });

        modelBuilder.Entity<TRequisitionEmployeesReplaced>(entity =>
        {
            entity.Property(e => e.RequisitionEmployeesReplacedGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ReplacedPerson).WithMany(p => p.TRequisitionEmployeesReplaceds).HasConstraintName("FK_tRequisitionEmployeesReplaced_tPerson");

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TRequisitionEmployeesReplaceds).HasConstraintName("FK_tRequisitionEmployeesReplaced_tRequisition");
        });

        modelBuilder.Entity<TRequisitionJobDescriptionHist>(entity =>
        {
            entity.Property(e => e.RequisitionJobDescriptionGuid).ValueGeneratedNever();
            entity.Property(e => e.BroadbeanJobPostingDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','BroadbeanJobPostingDescription',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.BroadbeanJobPostingSkills).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','BroadbeanJobPostingSkills',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.CertificationsRequired).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','CertificationsRequired',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.DesiredDegree).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','DesiredDegree',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.DesiredEducation).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','DesiredEducation',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.DesiredJobExperience).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','DesiredJobExperience',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.DesiredMajor).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','DesiredMajor',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.EssentialFunctions).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','EssentialFunctions',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.MinimumPhysicalRequirements).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','MinimumPhysicalRequirements',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.OtherQualifications).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','OtherQualifications',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.PrimaryResponsibilities).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','PrimaryResponsibilities',[RequisitionJobDescriptionGuid]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TasksPerformed).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tRequisitionJobDescriptionHist','TasksPerformed',[RequisitionJobDescriptionGuid]))", false);

            entity.HasOne(d => d.RequisitionCodeNavigation).WithMany(p => p.TRequisitionJobDescriptionHists).HasConstraintName("FK_tRequisitionJobDescriptionHist_tRequisition");
        });

        modelBuilder.Entity<TScale>(entity =>
        {
            entity.Property(e => e.ScaleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tScale','ScaleDescription',[ScaleGUID]))", false);
        });

        modelBuilder.Entity<TSchedule>(entity =>
        {
            entity.Property(e => e.ScheduleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSchedule','ScheduleDescription',[ScheduleGUID]))", false);

            entity.HasOne(d => d.ScheduleTypeCodeNavigation).WithMany(p => p.TSchedules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSchedule_tScheduleType");
        });

        modelBuilder.Entity<TScheduleType>(entity =>
        {
            entity.Property(e => e.ScheduleTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tScheduleType','ScheduleTypeDescription',[ScheduleTypeGUID]))", false);
        });

        modelBuilder.Entity<TSection>(entity =>
        {
            entity.Property(e => e.SectionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSection','SectionDescription',[SectionGUID]))", false);
        });

        modelBuilder.Entity<TShift>(entity =>
        {
            entity.Property(e => e.ShiftDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tShift','ShiftDescription',[ShiftGUID]))", false);
        });

        modelBuilder.Entity<TSignatureQuestion>(entity =>
        {
            entity.Property(e => e.SignatureQuestionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSignatureQuestion','SignatureQuestionDescription',[SignatureQuestionGUID]))", false);
        });

        modelBuilder.Entity<TSocialNetworkType>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.SocialNetworkTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSocialNetworkType','SocialNetworkTypeDescription',[SocialNetworkTypeGUID]))", false);
        });

        modelBuilder.Entity<TStateProvince>(entity =>
        {
            entity.Property(e => e.StateProvinceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tStateProvince','StateProvinceDescription',[StateProvinceGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TStateProvinces)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tStateProvince_tCountry");
        });

        modelBuilder.Entity<TStatus>(entity =>
        {
            entity.Property(e => e.StatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tStatus','StatusDescription',[StatusGUID]))", false);

            entity.HasOne(d => d.StatusGroupCodeNavigation).WithMany(p => p.TStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tStatus_tStatusGroup");
        });

        modelBuilder.Entity<TStatusCategory>(entity =>
        {
            entity.Property(e => e.StatusCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tStatusCategory','StatusCategoryDescription',[StatusCategoryGUID]))", false);
        });

        modelBuilder.Entity<TStatusGroup>(entity =>
        {
            entity.Property(e => e.StatusGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tStatusGroup','StatusGroupDescription',[StatusGroupGUID]))", false);
        });

        modelBuilder.Entity<TStatusReason>(entity =>
        {
            entity.Property(e => e.StatusReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tStatusReason','StatusReasonDescription',[StatusReasonGUID]))", false);
        });

        modelBuilder.Entity<TSuisditax>(entity =>
        {
            entity.Property(e => e.SuisditaxDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSUISDITax','SUISDITaxDescription',[SUISDITaxGUID]))", false);
        });

        modelBuilder.Entity<TSurvey>(entity =>
        {
            entity.HasKey(e => e.SurveyGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveySourceCode, e.SurveyDate }, "AK_tSurvey")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyGuid).ValueGeneratedNever();
            entity.Property(e => e.SurveyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSurvey','SurveyDescription',[SurveyGUID]))", false);

            entity.HasOne(d => d.SurveySourceCodeNavigation).WithMany(p => p.TSurveys)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurvey_tSurveySource");
        });

        modelBuilder.Entity<TSurveyCompanySize>(entity =>
        {
            entity.Property(e => e.SurveyCompanySizeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSurveyCompanySize','SurveyCompanySizeDescription',[SurveyCompanySizeGUID]))", false);
        });

        modelBuilder.Entity<TSurveyDatum>(entity =>
        {
            entity.HasKey(e => e.SurveyDataGuid).IsClustered(false);

            entity.HasIndex(e => e.SurveyGuid, "CIX_tSurveyData_SurveyGUID").IsClustered();

            entity.Property(e => e.SurveyDataGuid).ValueGeneratedNever();
            entity.Property(e => e.GoodFitAdjustmentFactor).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.GeographicAreaCodeNavigation).WithMany(p => p.TSurveyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyData_tGeographicArea");

            entity.HasOne(d => d.IndustrySectorCodeNavigation).WithMany(p => p.TSurveyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyData_tIndustrySector");

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TSurveyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyData_tJob");

            entity.HasOne(d => d.SurveyCompanySizeCodeNavigation).WithMany(p => p.TSurveyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyData_tSurveyCompanySize");

            entity.HasOne(d => d.SurveyCurrencyCodeNavigation).WithMany(p => p.TSurveyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyData_tCurrency");

            entity.HasOne(d => d.SurveyFrequencyCodeNavigation).WithMany(p => p.TSurveyData)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyData_tFrequency");

            entity.HasOne(d => d.Survey).WithMany(p => p.TSurveyData).HasConstraintName("FK_tSurveyData_tSurvey");
        });

        modelBuilder.Entity<TSurveyFilterSet>(entity =>
        {
            entity.Property(e => e.DataAgingFactor).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TargetFrequencyCodeNavigation).WithMany(p => p.TSurveyFilterSets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSet_tFrequencyCode");

            entity.HasOne(d => d.TargetGeographicAreaCodeNavigation).WithMany(p => p.TSurveyFilterSets).HasConstraintName("FK_tSurveyFilterSet_tGeographicArea");
        });

        modelBuilder.Entity<TSurveyFilterSetCompanySize>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetCompanySizeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.SurveyCompanySizeCode }, "AK_tSurveyFilterSetCompanySize")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetCompanySizeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.SurveyCompanySizeCodeNavigation).WithMany(p => p.TSurveyFilterSetCompanySizes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSetCompanySize_tSurveyCompanySizeCode");

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetCompanySizes).HasConstraintName("FK_tSurveyFilterSetCompanySize_tSurveyFilterSet");
        });

        modelBuilder.Entity<TSurveyFilterSetGeographicArea>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetGeographicAreaGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.GeographicAreaCode }, "AK_tSurveyFilterSetGeographicArea")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetGeographicAreaGuid).ValueGeneratedNever();

            entity.HasOne(d => d.GeographicAreaCodeNavigation).WithMany(p => p.TSurveyFilterSetGeographicAreas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSetGeographicArea_tGeographicAreaCode");

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetGeographicAreas).HasConstraintName("FK_tSurveyFilterSetGeographicArea_tSurveyFilterSet");
        });

        modelBuilder.Entity<TSurveyFilterSetGrade>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetGradeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.GradeCode }, "AK_tSurveyFilterSetGrade")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetGradeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetGrades).HasConstraintName("FK_tSurveyFilterSetGrade_tSurveyFilterSet");
        });

        modelBuilder.Entity<TSurveyFilterSetIndustrySector>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetIndustrySectorGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.IndustrySectorCode }, "AK_tSurveyFilterSetIndustrySector")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetIndustrySectorGuid).ValueGeneratedNever();

            entity.HasOne(d => d.IndustrySectorCodeNavigation).WithMany(p => p.TSurveyFilterSetIndustrySectors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSetIndustrySector_tIndustrySectorCode");

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetIndustrySectors).HasConstraintName("FK_tSurveyFilterSetIndustrySector_tSurveyFilterSet");
        });

        modelBuilder.Entity<TSurveyFilterSetJob>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetJobGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.JobCode }, "AK_tSurveyFilterSetJob")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetJobGuid).ValueGeneratedNever();

            entity.HasOne(d => d.JobCodeNavigation).WithMany(p => p.TSurveyFilterSetJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSetJob_tJobCode");

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetJobs).HasConstraintName("FK_tSurveyFilterSetJob_tSurveyFilterSet");
        });

        modelBuilder.Entity<TSurveyFilterSetJobFamily>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetJobFamilyGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.JobFamilyCode }, "AK_tSurveyFilterSetJobFamily")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetJobFamilyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.JobFamilyCodeNavigation).WithMany(p => p.TSurveyFilterSetJobFamilies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSetJobFamily_tJobFamilyCode");

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetJobFamilies).HasConstraintName("FK_tSurveyFilterSetJobFamily_tSurveyFilterSet");
        });

        modelBuilder.Entity<TSurveyFilterSetSurveySource>(entity =>
        {
            entity.HasKey(e => e.SurveyFilterSetSurveySourceGuid).IsClustered(false);

            entity.HasIndex(e => new { e.SurveyFilterSetName, e.SurveySourceCode }, "AK_tSurveyFilterSetSurveySource")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SurveyFilterSetSurveySourceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.SurveyFilterSetNameNavigation).WithMany(p => p.TSurveyFilterSetSurveySources).HasConstraintName("FK_tSurveyFilterSetSurveySource_tSurveyFilterSet");

            entity.HasOne(d => d.SurveySourceCodeNavigation).WithMany(p => p.TSurveyFilterSetSurveySources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tSurveyFilterSetSurveySource_tSurveySource");
        });

        modelBuilder.Entity<TSurveySource>(entity =>
        {
            entity.Property(e => e.SurveySourceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tSurveySource','SurveySourceDescription',[SurveySourceGUID]))", false);
        });

        modelBuilder.Entity<TTerminationReason>(entity =>
        {
            entity.Property(e => e.TerminationReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTerminationReason','TerminationReasonDescription',[TerminationReasonGUID]))", false);
        });

        modelBuilder.Entity<TTerminationType>(entity =>
        {
            entity.Property(e => e.TerminationTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTerminationType','TerminationTypeDescription',[TerminationTypeGUID]))", false);
        });

        modelBuilder.Entity<TTimeGroup>(entity =>
        {
            entity.Property(e => e.AutoGenFrequencyCode).IsFixedLength();
            entity.Property(e => e.TimeGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTimeGroup','TimeGroupDescription',[TimeGroupGUID]))", false);
            entity.Property(e => e.TimesheetEntryMethod).HasDefaultValueSql("('H')");

            entity.HasOne(d => d.DefaultOvertimeRuleCodeNavigation).WithMany(p => p.TTimeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeGroup_DefaultOvertimeRule_tOvertimeRule");

            entity.HasOne(d => d.HolidayTimeTypeCodeNavigation).WithMany(p => p.TTimeGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeGroup_HolidayTimeType_tTimeType");
        });

        modelBuilder.Entity<TTimeGroupHoliday>(entity =>
        {
            entity.HasKey(e => e.TimeGroupHolidayGuid).IsClustered(false);

            entity.HasIndex(e => new { e.TimeGroupCode, e.HolidayCode }, "AK_tTimeGroupHoliday")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TimeGroupHolidayGuid).ValueGeneratedNever();

            entity.HasOne(d => d.HolidayCodeNavigation).WithMany(p => p.TTimeGroupHolidays)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeGroupHoliday_tHoliday");

            entity.HasOne(d => d.TimeGroupCodeNavigation).WithMany(p => p.TTimeGroupHolidays).HasConstraintName("FK_tTimeGroupHoliday_tTimeGroup");
        });

        modelBuilder.Entity<TTimeGroupPeriod>(entity =>
        {
            entity.HasKey(e => e.TimeGroupPeriodGuid).IsClustered(false);

            entity.HasIndex(e => new { e.TimeGroupCode, e.TimeGroupPeriodStartDate }, "AK_tTimeGroupPeriod")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TimeGroupPeriodGuid).ValueGeneratedNever();

            entity.HasOne(d => d.OvertimeRuleCodeNavigation).WithMany(p => p.TTimeGroupPeriods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeGroupPeriod_tOvertimeRule");

            entity.HasOne(d => d.TimeGroupCodeNavigation).WithMany(p => p.TTimeGroupPeriods).HasConstraintName("FK_tTimeGroupPeriod_tTimeGroup");
        });

        modelBuilder.Entity<TTimeGroupTimeType>(entity =>
        {
            entity.HasKey(e => e.TimeGroupTimeTypeGuid).IsClustered(false);

            entity.HasIndex(e => new { e.TimeGroupCode, e.TimeTypeCode }, "AK_tTimeGroupTimeType")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TimeGroupTimeTypeGuid).ValueGeneratedNever();

            entity.HasOne(d => d.TimeGroupCodeNavigation).WithMany(p => p.TTimeGroupTimeTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeGroupTimeType_tTimeGroup");

            entity.HasOne(d => d.TimeTypeCodeNavigation).WithMany(p => p.TTimeGroupTimeTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeGroupTimeType_tTimeType");
        });

        modelBuilder.Entity<TTimeType>(entity =>
        {
            entity.Property(e => e.TimeTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTimeType','TimeTypeDescription',[TimeTypeGUID]))", false);

            entity.HasOne(d => d.AbsencePlanCodeNavigation).WithMany(p => p.TTimeTypes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTimeType_tAbsencePlan");
        });

        modelBuilder.Entity<TTimeZone>(entity =>
        {
            entity.Property(e => e.TimeZoneDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTimeZone','TimeZoneDescription',[TimeZoneGUID]))", false);
        });

        modelBuilder.Entity<TTrainingCompletion>(entity =>
        {
            entity.Property(e => e.TrainingCompletionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingCompletion','TrainingCompletionDescription',[TrainingCompletionGUID]))", false);
        });

        modelBuilder.Entity<TTrainingMaterial>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TrainingMaterialDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingMaterial','TrainingMaterialDescription',[TrainingMaterialGUID]))", false);
        });

        modelBuilder.Entity<TTrainingProgram>(entity =>
        {
            entity.Property(e => e.ProgramSummary).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingProgram','ProgramSummary',[TrainingProgramGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TrainingProgramDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingProgram','TrainingProgramDescription',[TrainingProgramGUID]))", false);
        });

        modelBuilder.Entity<TTrainingProgramCertification>(entity =>
        {
            entity.Property(e => e.TrainingProgramCertificationGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CertificationCodeNavigation).WithMany(p => p.TTrainingProgramCertifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramCertification_tCertification");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TTrainingProgramCertifications).HasConstraintName("FK_tTrainingProgramCertification_tTrainingProgram");
        });

        modelBuilder.Entity<TTrainingProgramCompetency>(entity =>
        {
            entity.Property(e => e.TrainingProgramCompetencyGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CompetencyCodeNavigation).WithMany(p => p.TTrainingProgramCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramCompetency_tCompetency");

            entity.HasOne(d => d.ProficiencyCodeNavigation).WithMany(p => p.TTrainingProgramCompetencies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramCompetency_tProficiency");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TTrainingProgramCompetencies).HasConstraintName("FK_tTrainingProgramCompetency_tTrainingProgram");
        });

        modelBuilder.Entity<TTrainingProgramGroup>(entity =>
        {
            entity.Property(e => e.TrainingProgramGroupGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TrainingProgramGroupName).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingProgramGroup','TrainingProgramGroupName',[TrainingProgramGroupGUID]))", false);

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TTrainingProgramGroups).HasConstraintName("FK_tTrainingProgramGroup_tTrainingProgram");
        });

        modelBuilder.Entity<TTrainingProgramGroupCourse>(entity =>
        {
            entity.Property(e => e.TrainingProgramGroupCourseGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CourseCodeNavigation).WithMany(p => p.TTrainingProgramGroupCourses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramGroupCourse_tCourse");

            entity.HasOne(d => d.TrainingProgramGroup).WithMany(p => p.TTrainingProgramGroupCourses).HasConstraintName("FK_tTrainingProgramGroupCourse_tTrainingProgramGroup");
        });

        modelBuilder.Entity<TTrainingProgramLanguage>(entity =>
        {
            entity.Property(e => e.TrainingProgramLanguageGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.TTrainingProgramLanguages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramLanguage_tLanguage");

            entity.HasOne(d => d.ReadingLanguageProficiencyCodeNavigation).WithMany(p => p.TTrainingProgramLanguageReadingLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramLanguage_tLangaugeProficiency_Reading");

            entity.HasOne(d => d.SpokenLanguageProficiencyCodeNavigation).WithMany(p => p.TTrainingProgramLanguageSpokenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramLanguage_tLangaugeProficiency_Spoken");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TTrainingProgramLanguages).HasConstraintName("FK_tTrainingProgramLanguage_tTrainingProgram");

            entity.HasOne(d => d.TranslationLanguageProficiencyCodeNavigation).WithMany(p => p.TTrainingProgramLanguageTranslationLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramLanguage_tLangaugeProficiency_Translation");

            entity.HasOne(d => d.WrittenLanguageProficiencyCodeNavigation).WithMany(p => p.TTrainingProgramLanguageWrittenLanguageProficiencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramLanguage_tLangaugeProficiency_Written");
        });

        modelBuilder.Entity<TTrainingProgramTrainingProgram>(entity =>
        {
            entity.HasKey(e => e.TrainingProgramTrainingProgramGuid).IsClustered(false);

            entity.HasIndex(e => new { e.TrainingProgramCode, e.ParentTrainingProgramCode }, "AK_tTrainingProgramTrainingProgram")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TrainingProgramTrainingProgramGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ParentTrainingProgramCodeNavigation).WithMany(p => p.TTrainingProgramTrainingProgramParentTrainingProgramCodeNavigations).HasConstraintName("FK_tTrainingProgramTrainingProgram_tTrainingProgram_2");

            entity.HasOne(d => d.TrainingProgramCodeNavigation).WithMany(p => p.TTrainingProgramTrainingProgramTrainingProgramCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tTrainingProgramTrainingProgram_tTrainingProgram_1");
        });

        modelBuilder.Entity<TTrainingProvider>(entity =>
        {
            entity.Property(e => e.TrainingProviderDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingProvider','TrainingProviderDescription',[TrainingProviderGUID]))", false);
        });

        modelBuilder.Entity<TTrainingResource>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TrainingResourceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTrainingResource','TrainingResourceDescription',[TrainingResourceGUID]))", false);
        });

        modelBuilder.Entity<TTransmitter>(entity =>
        {
            entity.Property(e => e.TransmitterDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tTransmitter','TransmitterDescription',[TransmitterGUID]))", false);
        });

        modelBuilder.Entity<TUnion>(entity =>
        {
            entity.Property(e => e.UnionDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tUnion','UnionDescription',[UnionGUID]))", false);
        });

        modelBuilder.Entity<TVendor>(entity =>
        {
            entity.Property(e => e.VendorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tVendor','VendorDescription',[VendorGUID]))", false);

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.TVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVendor_tCountry");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVendor_tStateProvince");

            entity.HasOne(d => d.VendorEmployeeIdentifierCodeNavigation).WithMany(p => p.TVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVendor_USysVendorEmployeeIdentifier");

            entity.HasOne(d => d.VendorTypeCodeNavigation).WithMany(p => p.TVendors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tVendor_USysVendorType");
        });

        modelBuilder.Entity<TVendorUserField>(entity =>
        {
            entity.Property(e => e.VendorUserFieldGuid).ValueGeneratedNever();
            entity.Property(e => e.VendorUserFieldDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tVendorUserField','VendorUserFieldDescription',[VendorUserFieldGUID]))", false);

            entity.HasOne(d => d.VendorCodeNavigation).WithMany(p => p.TVendorUserFields).HasConstraintName("FK_tVendorUserField_tVendor");
        });

        modelBuilder.Entity<TVeteran>(entity =>
        {
            entity.Property(e => e.VeteranDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tVeteran','VeteranDescription',[VeteranGUID]))", false);
        });

        modelBuilder.Entity<TVisaType>(entity =>
        {
            entity.Property(e => e.VisaTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tVisaType','VisaTypeDescription',[VisaTypeGUID]))", false);
        });

        modelBuilder.Entity<TWesleyCalendar>(entity =>
        {
            entity.Property(e => e.WesleyCalendarDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tWesleyCalendar','WesleyCalendarDescription',[WesleyCalendarGUID]))", false);
        });

        modelBuilder.Entity<TWorkEligibilityDocumentType>(entity =>
        {
            entity.Property(e => e.WorkEligibilityDocumentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tWorkEligibilityDocumentType','WorkEligibilityDocumentTypeDescription',[WorkEligibilityDocumentTypeGUID]))", false);

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.TWorkEligibilityDocumentTypes).HasConstraintName("FK_tWorkEligibilityDocumentType_USysCSF");
        });

        modelBuilder.Entity<TWorkersCompensation>(entity =>
        {
            entity.Property(e => e.WorkersCompensationDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tWorkersCompensation','WorkersCompensationDescription',[WorkersCompensationGUID]))", false);

            entity.HasOne(d => d.WorkersCompensationCategoryCodeNavigation).WithMany(p => p.TWorkersCompensations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tWorkersCompensation_tWorkersCompensationCategory");
        });

        modelBuilder.Entity<TWorkersCompensationCategory>(entity =>
        {
            entity.Property(e => e.WorkersCompensationCategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tWorkersCompensationCategory','WorkersCompensationCategoryDescription',[WorkersCompensationCategoryGUID]))", false);
        });

        modelBuilder.Entity<TWorkersCompensationRate>(entity =>
        {
            entity.HasKey(e => e.WorkersCompensationRateGuid).IsClustered(false);

            entity.HasIndex(e => e.WorkersCompensationCode, "CIX_tWorkersCompensationRate_WorkersCompensationCode").IsClustered();

            entity.Property(e => e.WorkersCompensationRateGuid).ValueGeneratedNever();

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.TWorkersCompensationRates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tWorkersCompensationRate_tStateProvince");

            entity.HasOne(d => d.WorkersCompensationCodeNavigation).WithMany(p => p.TWorkersCompensationRates).HasConstraintName("FK_tWorkersCompensationRate_tWorkersCompensation");
        });

        modelBuilder.Entity<TWorksCouncil>(entity =>
        {
            entity.Property(e => e.WorksCouncilDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tWorksCouncil','WorksCouncilDescription',[WorksCouncilGUID]))", false);
        });

        modelBuilder.Entity<TWorksCouncilRole>(entity =>
        {
            entity.Property(e => e.WorksCouncilRoleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('tWorksCouncilRole','WorksCouncilRoleDescription',[WorksCouncilRoleGUID]))", false);
        });

        modelBuilder.Entity<TWsPersonExportDatum>(entity =>
        {
            entity.Property(e => e.Tscol)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<UsysAbsenceTransactionType>(entity =>
        {
            entity.Property(e => e.AbsenceTransactionTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysAbsenceTransactionType','AbsenceTransactionTypeDescription',[AbsenceTransactionTypeGUID]))", false);
            entity.Property(e => e.AbsenceTransactionTypeGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysAcareportParameter>(entity =>
        {
            entity.Property(e => e.UsysAcareportParameterGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysAlert>(entity =>
        {
            entity.HasKey(e => e.AlertGuid).IsClustered(false);

            entity.HasIndex(e => e.AlertCode, "AK_USysAlert")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AlertGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AlertDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysAlert','AlertDescription',[AlertGUID]))", false);

            entity.HasOne(d => d.CommunicationTemplate).WithMany(p => p.UsysAlerts).HasConstraintName("FK_USysAlert_USysCommunicationTemplate");

            entity.HasOne(d => d.TableEntityNavigation).WithMany(p => p.UsysAlerts).HasConstraintName("FK_USysAlert_USysEntity");
        });

        modelBuilder.Entity<UsysAlertInstance>(entity =>
        {
            entity.HasKey(e => e.AlertInstanceGuid).IsClustered(false);

            entity.HasIndex(e => e.AlertScheduleGuid, "CIX_USysAlertInstance_AlertOccurenceGUID").IsClustered();

            entity.Property(e => e.AlertInstanceGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Alert).WithMany(p => p.UsysAlertInstances).HasConstraintName("FK_USysAlertInstance_USysAlert");

            entity.HasOne(d => d.AlertSchedule).WithMany(p => p.UsysAlertInstances)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysAlertInstance_USysAlertSchedule");
        });

        modelBuilder.Entity<UsysAlertRecipient>(entity =>
        {
            entity.HasKey(e => e.AlertRecipientGuid)
                .HasName("PK_tAlertRecipient")
                .IsClustered(false);

            entity.HasIndex(e => e.AlertGuid, "CIX_USysAlertRecipient_AlertGUID").IsClustered();

            entity.Property(e => e.AlertRecipientGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Alert).WithMany(p => p.UsysAlertRecipients).HasConstraintName("FK_USysAlertRecipient_USysAlert");

            entity.HasOne(d => d.Recipient).WithMany(p => p.UsysAlertRecipients).HasConstraintName("FK_tAlertRecipient_USysRecipient");
        });

        modelBuilder.Entity<UsysAlertSchedule>(entity =>
        {
            entity.HasKey(e => e.AlertScheduleGuid).IsClustered(false);

            entity.HasIndex(e => e.AlertGuid, "CIX_USysAlertSchedule_AlertGUID").IsClustered();

            entity.Property(e => e.AlertScheduleGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Alert).WithMany(p => p.UsysAlertSchedules).HasConstraintName("FK_USysAlertSchedule_USysAlert");
        });

        modelBuilder.Entity<UsysAlertScheduleRecipient>(entity =>
        {
            entity.HasKey(e => e.AlertScheduleRecipientGuid).IsClustered(false);

            entity.HasIndex(e => e.AlertScheduleGuid, "CIX_USysAlertScheduleRecipient_AlertScheduleGUID").IsClustered();

            entity.Property(e => e.AlertScheduleRecipientGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AlertSchedule).WithMany(p => p.UsysAlertScheduleRecipients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysAlertScheduleRecipient_USysAlertSchedule");

            entity.HasOne(d => d.Recipient).WithMany(p => p.UsysAlertScheduleRecipients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysAlertScheduleRecipient_USysRecipient");
        });

        modelBuilder.Entity<UsysAnnouncement>(entity =>
        {
            entity.Property(e => e.AnnouncementsGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysAnnouncements','Description',[AnnouncementsGUID]))", false);
            entity.Property(e => e.Title).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysAnnouncements','Title',[AnnouncementsGUID]))", false);

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.UsysAnnouncements).HasConstraintName("FK_USysAnnouncements_USysUser");

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysAnnouncements)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysAnnouncements_USysModuleDefinition");
        });

        modelBuilder.Entity<UsysAttachmentColumn>(entity =>
        {
            entity.Property(e => e.AttachmentColumnGuid).ValueGeneratedNever();
            entity.Property(e => e.AttachmentColumnDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysAttachmentColumn','AttachmentColumnDescription',[AttachmentColumnGUID]))", false);
            entity.Property(e => e.EntityDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysAttachmentColumn','EntityDescription',[AttachmentColumnGUID]))", false);

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysAttachmentColumns).HasConstraintName("FK_USysAttachmentColumn_EntityName");
        });

        modelBuilder.Entity<UsysAuditRecord>(entity =>
        {
            entity.HasKey(e => e.AuditRecordGuid).IsClustered(false);

            entity.HasIndex(e => e.Date, "CIX_USysAuditRecord_Date").IsClustered();

            entity.Property(e => e.AuditRecordGuid).ValueGeneratedNever();
            entity.Property(e => e.AuditRecordType).IsFixedLength();
        });

        modelBuilder.Entity<UsysBatchJob>(entity =>
        {
            entity.HasKey(e => e.BatchJobGuid).IsClustered(false);

            entity.HasIndex(e => new { e.JobType, e.BatchJobStartDate }, "CIX_USysBatchJob")
                .IsDescending(false, true)
                .IsClustered();

            entity.Property(e => e.BatchJobGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysBatchJobLog>(entity =>
        {
            entity.HasKey(e => e.BatchJobLogGuid).IsClustered(false);

            entity.HasIndex(e => new { e.BatchJobGuid, e.BatchJobLogEventDate }, "CIX_USysBatchJobLog").IsClustered();

            entity.Property(e => e.BatchJobLogGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BatchJob).WithMany(p => p.UsysBatchJobLogs).HasConstraintName("FK_USysBatchJobLog_USysBatchJob");
        });

        modelBuilder.Entity<UsysBenefitEnrollment>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.BenefitPlanOptionGuid }, "AK_USysBenefitEnrollment")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentContribution>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentContributionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.PersonBenefitGuid, e.BenefitContributionStartDate }, "AK_USysBenefitEnrollmentContribution")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentContributionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysBenefitEnrollmentContributions).HasConstraintName("FK_USysBenefitEnrollmentContribution_tPerson");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentContributionFailed>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentContributionFailedGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.PersonBenefitGuid, e.BenefitContributionStartDate }, "AK_USysBenefitEnrollmentContributionFailed")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentContributionFailedGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentDependent>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentDependentGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.PersonGuid, e.DependentPersonGuid }, "AK_USysBenefitEnrollmentDependent")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentDependentGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysBenefitEnrollmentDependents).HasConstraintName("FK_USysBenefitEnrollmentDependent_tPerson");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentEligibility>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentEligibilityGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.PersonGuid, e.BenefitPlanOptionGuid, e.ResponsiblePersonGuid }, "AK_USysBenefitEnrollmentEligibility")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentEligibilityGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysBenefitEnrollmentEligibilities).HasConstraintName("FK_USysBenefitEnrollmentEligibility_tPerson");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentFailed>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentFailedGuid).IsClustered(false);

            entity.Property(e => e.BenefitEnrollmentFailedGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentPerson>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentPersonGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.PersonGuid }, "AK_USysBenefitEnrollmentPerson")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentPersonGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysBenefitEnrollmentPlanOption>(entity =>
        {
            entity.HasKey(e => e.BenefitEnrollmentPlanOptionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserName, e.BenefitPlanOptionGuid }, "AK_USysBenefitEnrollmentPlanOption")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.BenefitEnrollmentPlanOptionGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysBusinessObjectFunction>(entity =>
        {
            entity.HasKey(e => e.BusinessObjectFunctionGuid).IsClustered(false);

            entity.HasIndex(e => e.BusinessObjectCode, "CIX_USysBusinessObjectFunction_BusinessObjectCode").IsClustered();

            entity.Property(e => e.BusinessObjectFunctionGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysChecklist>(entity =>
        {
            entity.Property(e => e.ChecklistDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysChecklist','ChecklistDescription',[ChecklistGUID]))", false);
            entity.Property(e => e.ChecklistGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ChecklistTab).WithMany(p => p.UsysChecklists).HasConstraintName("FK_USysChecklist_USysTab");

            entity.HasOne(d => d.OwnerRecipient).WithMany(p => p.UsysChecklistOwnerRecipients).HasConstraintName("FK_USysChecklist_USysRecipient_OwnerRecipient");

            entity.HasOne(d => d.SubjectRecipient).WithMany(p => p.UsysChecklistSubjectRecipients).HasConstraintName("FK_USysChecklist_USysRecipient_SubjectRecipient");
        });

        modelBuilder.Entity<UsysChecklistInstance>(entity =>
        {
            entity.Property(e => e.ChecklistInstanceGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysChecklistInstance','Description',[ChecklistInstanceGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ChecklistCodeNavigation).WithMany(p => p.UsysChecklistInstances).HasConstraintName("FK_USysChecklistInstance_USysChecklist");

            entity.HasOne(d => d.ClosedByPerson).WithMany(p => p.UsysChecklistInstanceClosedByPeople).HasConstraintName("FK_USysChecklistInstance_tPerson_ClosedBy");

            entity.HasOne(d => d.OwnerPerson).WithMany(p => p.UsysChecklistInstanceOwnerPeople).HasConstraintName("FK_USysChecklistInstance_tPerson_Owner");

            entity.HasOne(d => d.SubjectPerson).WithMany(p => p.UsysChecklistInstanceSubjectPeople)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysChecklistInstance_tPerson_Subject");
        });

        modelBuilder.Entity<UsysChecklistInstanceStep>(entity =>
        {
            entity.Property(e => e.ChecklistInstanceStepGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ChecklistInstance).WithMany(p => p.UsysChecklistInstanceSteps).HasConstraintName("FK_USysChecklistInstanceStep_USysChecklistInstance");

            entity.HasOne(d => d.ChecklistStep).WithMany(p => p.UsysChecklistInstanceSteps).HasConstraintName("FK_USysChecklistInstanceStep_USysChecklistStep");

            entity.HasOne(d => d.PersonEmploymentDocument).WithMany(p => p.UsysChecklistInstanceSteps).HasConstraintName("FK_USysChecklistInstanceStep_tPersonEmploymentDocument");

            entity.HasOne(d => d.PersonFutureEnrollmentStatus).WithMany(p => p.UsysChecklistInstanceSteps).HasConstraintName("FK_USysChecklistInstanceStep_tPersonFutureEnrollmentStatus");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysChecklistInstanceSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysChecklistInstanceStep_tPerson");

            entity.HasOne(d => d.RoutingInstance).WithMany(p => p.UsysChecklistInstanceSteps).HasConstraintName("FK_USysChecklistInstanceStep_USysRoutingInstance");

            entity.HasOne(d => d.TaskEntityNameNavigation).WithMany(p => p.UsysChecklistInstanceSteps).HasConstraintName("FK_USysChecklistInstanceStep_USysEntity");
        });

        modelBuilder.Entity<UsysChecklistStep>(entity =>
        {
            entity.Property(e => e.ChecklistStepGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ChecklistStepName).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysChecklistStep','ChecklistStepName',[ChecklistStepGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.ChecklistCodeNavigation).WithMany(p => p.UsysChecklistSteps).HasConstraintName("FK_USysChecklistStep_USysChecklist");

            entity.HasOne(d => d.EmploymentDocumentCodeNavigation).WithMany(p => p.UsysChecklistSteps).HasConstraintName("FK_USysChecklistStep_tEmploymentDocument");

            entity.HasOne(d => d.Recipient).WithMany(p => p.UsysChecklistSteps).HasConstraintName("FK_USysChecklistStep_USysRecipient");

            entity.HasOne(d => d.TaskEntityNameNavigation).WithMany(p => p.UsysChecklistSteps).HasConstraintName("FK_USysChecklistStep_USysEntity");
        });

        modelBuilder.Entity<UsysCodeFilterDetail>(entity =>
        {
            entity.Property(e => e.CodeFilterDetailGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CodeFilterTable).WithMany(p => p.UsysCodeFilterDetails).HasConstraintName("FK_USysCodeFilterDetail_USysCodeFilterTable");
        });

        modelBuilder.Entity<UsysCodeFilterGroup>(entity =>
        {
            entity.Property(e => e.CodeFilterGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysCodeFilterGroup','CodeFilterGroupDescription',[CodeFilterGroupGUID]))", false);
            entity.Property(e => e.CodeFilterGroupGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysCodeFilterTable>(entity =>
        {
            entity.Property(e => e.CodeFilterTableGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CodeFilterGroupCodeNavigation).WithMany(p => p.UsysCodeFilterTables).HasConstraintName("FK_USysCodeFilterTable_USysCodeFilterGroup");
        });

        modelBuilder.Entity<UsysCodeTable>(entity =>
        {
            entity.Property(e => e.CodeTableGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysColumnTranslation>(entity =>
        {
            entity.HasKey(e => e.ColumnTranslationGuid).IsClustered(false);

            entity.HasIndex(e => new { e.TableRowGuid, e.ColumnName, e.LanguageCode }, "AK_USysColumnTranslation")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ColumnTranslationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.UsysColumnTranslations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysColumnTranslation_tLanguage");
        });

        modelBuilder.Entity<UsysCommunicationTemplate>(entity =>
        {
            entity.HasKey(e => e.CommunicationTemplateGuid).IsClustered(false);

            entity.HasIndex(e => e.EntityName, "CIX_USysCommunicationTemplate_EntityName").IsClustered();

            entity.Property(e => e.CommunicationTemplateGuid).ValueGeneratedNever();
            entity.Property(e => e.Body).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysCommunicationTemplate','Body',[CommunicationTemplateGUID]))", false);
            entity.Property(e => e.CommunicationTemplateDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysCommunicationTemplate','CommunicationTemplateDescription',[CommunicationTemplateGUID]))", false);
            entity.Property(e => e.Subject).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysCommunicationTemplate','Subject',[CommunicationTemplateGUID]))", false);

            entity.HasOne(d => d.EmailProfileCodeNavigation).WithMany(p => p.UsysCommunicationTemplates).HasConstraintName("FK_USysCommunicationTemplate_USysEmailProfile");

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysCommunicationTemplates).HasConstraintName("FK_USysCommunicationTemplate_USysEntity");
        });

        modelBuilder.Entity<UsysCounterValue>(entity =>
        {
            entity.HasKey(e => e.CounterValueGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ClassName, e.PropertyName }, "AK_USysCounterValue")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CounterValueGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysCountryFormat>(entity =>
        {
            entity.HasKey(e => e.CountryFormatGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CountryCode, e.FormatType }, "AK_USysCountryFormat")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CountryFormatGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.UsysCountryFormats).HasConstraintName("FK_USysCountryFormat_tCountry");
        });

        modelBuilder.Entity<UsysCsf>(entity =>
        {
            entity.Property(e => e.Csfguid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysCsfcountry>(entity =>
        {
            entity.HasKey(e => e.CsfcountryGuid).IsClustered(false);

            entity.HasIndex(e => new { e.CountryCode, e.Csfcode }, "AK_USysCSFCountry")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsfcountryGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CountryCodeNavigation).WithMany(p => p.UsysCsfcountries).HasConstraintName("FK_USysCSFCountry_tCountry");

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsfcountries).HasConstraintName("FK_USysCSFCountry_USysCSF");
        });

        modelBuilder.Entity<UsysCsfentity>(entity =>
        {
            entity.HasKey(e => e.CsfentityGuid).IsClustered(false);

            entity.HasIndex(e => new { e.EntityName, e.Csfcode }, "AK_USysCSFEntity")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsfentityGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsfentities).HasConstraintName("FK_USysCSFEntity_USysCSF");

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysCsfentities).HasConstraintName("FK_USysCSFEntity_USysEntity");
        });

        modelBuilder.Entity<UsysCsffield>(entity =>
        {
            entity.HasKey(e => e.CsffieldGuid).IsClustered(false);

            entity.HasIndex(e => new { e.Csfcode, e.TableName, e.ColumnName }, "AK_USysCSFField")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsffieldGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsffields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysCSFField_USysCSF");
        });

        modelBuilder.Entity<UsysCsflocation>(entity =>
        {
            entity.HasKey(e => e.CsflocationGuid).IsClustered(false);

            entity.HasIndex(e => new { e.Csfcode, e.LocationCode }, "AK_USysCSFLocation")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsflocationGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsflocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysCSFLocation_USysCSF");

            entity.HasOne(d => d.LocationCodeNavigation).WithMany(p => p.UsysCsflocations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysCSFLocation_tLocation");
        });

        modelBuilder.Entity<UsysCsfmoduleDefinition>(entity =>
        {
            entity.HasKey(e => e.CsfmoduleDefinitionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ModuleDefinitionGuid, e.Csfcode }, "AK_USysCSFModuleDefinition")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsfmoduleDefinitionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsfmoduleDefinitions).HasConstraintName("FK_USysCSFModuleDefinition_USysCSF");

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysCsfmoduleDefinitions).HasConstraintName("FK_USysCSFModuleDefinition_USysModuleDefinition");
        });

        modelBuilder.Entity<UsysCsfstateProvince>(entity =>
        {
            entity.HasKey(e => e.CsfstateProvinceGuid).IsClustered(false);

            entity.HasIndex(e => new { e.StateProvinceCode, e.Csfcode }, "AK_USysCSFStateProvince")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsfstateProvinceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsfstateProvinces).HasConstraintName("FK_USysCSFStateProvince_USysCSF");

            entity.HasOne(d => d.StateProvinceCodeNavigation).WithMany(p => p.UsysCsfstateProvinces).HasConstraintName("FK_USysCSFStateProvince_tStateProvince");
        });

        modelBuilder.Entity<UsysCsfuser>(entity =>
        {
            entity.HasKey(e => e.CsfuserGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserGuid, e.Csfcode }, "AK_USysCSFUser")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.CsfuserGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysCsfusers).HasConstraintName("FK_USysCSFUser_USysCSF");

            entity.HasOne(d => d.User).WithMany(p => p.UsysCsfusers).HasConstraintName("FK_USysCSFUser_USysUser");
        });

        modelBuilder.Entity<UsysDataDictionary>(entity =>
        {
            entity.HasKey(e => e.DataDictionaryGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ObjectName, e.DatabaseColumnName, e.TaskElementKey }, "AK_USysDataDictionary")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.DataDictionaryGuid).ValueGeneratedNever();
            entity.Property(e => e.ObjectDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysDataDictionary','ObjectDescription',[DataDictionaryGUID]))", false);
        });

        modelBuilder.Entity<UsysDatabaseChange>(entity =>
        {
            entity.HasKey(e => e.DatabaseChangeGuid).IsClustered(false);

            entity.HasIndex(e => e.ChangeDateTime, "CIX_USysDatabaseChange").IsClustered();

            entity.Property(e => e.DatabaseChangeGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.User).WithMany(p => p.UsysDatabaseChanges)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysDatabaseChange_USysUser");
        });

        modelBuilder.Entity<UsysDraft>(entity =>
        {
            entity.HasKey(e => e.DraftGuid).IsClustered(false);

            entity.HasIndex(e => e.UserGuid, "CIX_USysDraft_UserGuid").IsClustered();

            entity.Property(e => e.DraftGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Entity).WithMany(p => p.UsysDrafts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysDraft_USysEntity");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysDrafts).HasConstraintName("FK_USysDraft_USysPortal");

            entity.HasOne(d => d.User).WithMany(p => p.UsysDrafts).HasConstraintName("FK_USysDraft_USysUser");
        });

        modelBuilder.Entity<UsysEeocategory>(entity =>
        {
            entity.Property(e => e.EeocategoryDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysEEOCategory','EEOCategoryDescription',[EEOCategoryGUID]))", false);
            entity.Property(e => e.EeocategoryGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysEmailLog>(entity =>
        {
            entity.HasKey(e => e.EmailLogGuid).IsClustered(false);

            entity.HasIndex(e => e.SentDateTime, "CIX_USysEmailLog_SentDateTime").IsClustered();

            entity.Property(e => e.EmailLogGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysEmailProfile>(entity =>
        {
            entity.Property(e => e.UsysEmailProfileGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysEntity>(entity =>
        {
            entity.HasOne(d => d.EntityGroupCodeNavigation).WithMany(p => p.UsysEntities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysEntity_USysEntityGroup");

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysEntities).HasConstraintName("FK_USysEntity_USysModuleDefinition");
        });

        modelBuilder.Entity<UsysFlag>(entity =>
        {
            entity.Property(e => e.FlagGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysFmlaLeaveFrequency>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.SysFmlaLeaveFrequencyDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysFmlaLeaveFrequency','SysFmlaLeaveFrequencyDescription',[SysFmlaLeaveFrequencyGUID]))", false);
            entity.Property(e => e.SysFmlaLeaveFrequencyGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysFmlaLeaveReason>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.SysFmlaLeaveReasonDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysFmlaLeaveReason','SysFmlaLeaveReasonDescription',[SysFmlaLeaveReasonGuid]))", false);
            entity.Property(e => e.SysFmlaLeaveReasonGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysGlobalConstant>(entity =>
        {
            entity.Property(e => e.FriendlyName).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysGlobalConstant','FriendlyName',[GlobalConstantGUID]))", false);
            entity.Property(e => e.GlobalConstantGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysGlobalConstantGroup>(entity =>
        {
            entity.HasKey(e => e.GlobalConstantGroupGuid).HasName("PK_USysViewBusinessObject");

            entity.Property(e => e.GlobalConstantGroupGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysGlobalConstantGroupRecord>(entity =>
        {
            entity.HasKey(e => e.GlobalConstantGroupRecordGuid).IsClustered(false);

            entity.HasIndex(e => e.GlobalConstantGroupGuid, "CIX_USysGlobalConstantGroupRecord_GlobalConstantGroupGuid").IsClustered();

            entity.Property(e => e.GlobalConstantGroupRecordGuid).ValueGeneratedNever();

            entity.HasOne(d => d.GlobalConstantGroup).WithMany(p => p.UsysGlobalConstantGroupRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysGlobalConstantGroupRecord_USysGlobalConstantGroup");

            entity.HasOne(d => d.GlobalConstantNameNavigation).WithMany(p => p.UsysGlobalConstantGroupRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysGlobalConstantGroupRecord_USysGlobalConstant");
        });

        modelBuilder.Entity<UsysHtmlText>(entity =>
        {
            entity.Property(e => e.HtmlTextGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DesktopHtml).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysHtmlText','DesktopHtml',[HtmlTextGUID]))", false);

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysHtmlTexts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysHtmlText_USysModuleDefinitions");
        });

        modelBuilder.Entity<UsysI9documentType>(entity =>
        {
            entity.Property(e => e.I9documentTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysI9DocumentType','I9DocumentTypeDescription',[I9DocumentTypeGUID]))", false);
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysIdAutoPopulation>(entity =>
        {
            entity.Property(e => e.IdAutoPopulationGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysInstallation>(entity =>
        {
            entity.Property(e => e.InstallDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.InstallationGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysInstallations).HasConstraintName("FK_USysInstallation_USysPortal");
        });

        modelBuilder.Entity<UsysIntegrationTemplateKey>(entity =>
        {
            entity.Property(e => e.IntegrationTemplateKeyGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Export).WithMany(p => p.UsysIntegrationTemplateKeys)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysIntegrationTemplateKey_USysLnkExportMaster");
        });

        modelBuilder.Entity<UsysLanguageUser>(entity =>
        {
            entity.HasKey(e => e.LanguageUserGuid).IsClustered(false);

            entity.HasIndex(e => e.UserName, "AK_USysLanguageUser")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LanguageUserGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.UsysLanguageUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLanguageUser_tLanguage");
        });

        modelBuilder.Entity<UsysLink>(entity =>
        {
            entity.HasKey(e => e.LinksGuid).IsClustered(false);

            entity.HasIndex(e => e.CreatedByUserGuid, "IX_USysLinks_CreatedByUserGuid").IsClustered();

            entity.Property(e => e.LinksGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Title).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLinks','Title',[LinksGUID]))", false);

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.UsysLinks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLinks_USysUser");
        });

        modelBuilder.Entity<UsysLnk834RecordSort>(entity =>
        {
            entity.Property(e => e.Lnk834RecordSortGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysLnk834SortTable>(entity =>
        {
            entity.Property(e => e.Lnk834RecordSortGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysLnkCodeConv>(entity =>
        {
            entity.HasKey(e => e.LnkCodeConvGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkFieldDefGuid, e.IvancodeValue }, "AK_USysLnkCodeConv")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkCodeConvGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkFieldDef).WithMany(p => p.UsysLnkCodeConvs).HasConstraintName("FK_USysLnkCodeConv_USysLnkFieldDef");
        });

        modelBuilder.Entity<UsysLnkDataGrouping>(entity =>
        {
            entity.Property(e => e.LnkDataGroupingGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkDataGroupingParent).WithMany(p => p.InverseLnkDataGroupingParent).HasConstraintName("FK_USysLnkDataGrouping_USysLnkDataGrouping");

            entity.HasOne(d => d.LnkExportFile).WithMany(p => p.UsysLnkDataGroupings).HasConstraintName("FK_USysLnkDataGrouping_USysLnkExportFile");
        });

        modelBuilder.Entity<UsysLnkDataGroupingField>(entity =>
        {
            entity.Property(e => e.LnkDataGroupingFieldGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkDataGrouping).WithMany(p => p.UsysLnkDataGroupingFields).HasConstraintName("FK_USysLnkDataGroupingField_USysLnkDataGrouping");

            entity.HasOne(d => d.LnkFieldDef).WithMany(p => p.UsysLnkDataGroupingFields)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkDataGroupingField_USysLnkFieldDef");
        });

        modelBuilder.Entity<UsysLnkDataGroupingRecord>(entity =>
        {
            entity.Property(e => e.LnkDataGroupingRecordGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkDataGrouping).WithMany(p => p.UsysLnkDataGroupingRecords).HasConstraintName("FK_USysLnkDataGroupingRecord_USysLnkDataGrouping");

            entity.HasOne(d => d.LnkRecord).WithMany(p => p.UsysLnkDataGroupingRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkDataGroupingRecord_USysLnkRecord");
        });

        modelBuilder.Entity<UsysLnkDataSorting>(entity =>
        {
            entity.Property(e => e.LnkDataSortingGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkExportFile).WithMany(p => p.UsysLnkDataSortings).HasConstraintName("FK_USysLnkDataSorting_USysLnkExportFile");
        });

        modelBuilder.Entity<UsysLnkDataSortingDataGrouping>(entity =>
        {
            entity.Property(e => e.LnkDataSortingDataGroupingGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkDataGrouping).WithMany(p => p.UsysLnkDataSortingDataGroupings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkDataSortingDataGrouping_USysLnkDataGrouping");

            entity.HasOne(d => d.LnkDataSorting).WithMany(p => p.UsysLnkDataSortingDataGroupings).HasConstraintName("FK_USysLnkDataSortingDataGrouping_USysLnkDataSorting");

            entity.HasOne(d => d.LnkFieldDef).WithMany(p => p.UsysLnkDataSortingDataGroupings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkDataSortingDataGrouping_USysLnkFieldDef");
        });

        modelBuilder.Entity<UsysLnkDataSortingRecord>(entity =>
        {
            entity.Property(e => e.LnkDataSortingRecordGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkDataSorting).WithMany(p => p.UsysLnkDataSortingRecords).HasConstraintName("FK_USysLnkDataSortingRecord_USysLnkDataSorting");

            entity.HasOne(d => d.LnkFieldDef).WithMany(p => p.UsysLnkDataSortingRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkDataSortingRecord_USysLnkFieldDef");

            entity.HasOne(d => d.LnkRecord).WithMany(p => p.UsysLnkDataSortingRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkDataSortingRecord_USysLnkRecord");
        });

        modelBuilder.Entity<UsysLnkExportFile>(entity =>
        {
            entity.HasKey(e => e.LnkExportFileGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ExportId, e.FileDescription }, "AK_USysLnkExportFile")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkExportFileGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Export).WithMany(p => p.UsysLnkExportFiles).HasConstraintName("FK_USysLnkExportFile_USysLnkExportMaster");
        });

        modelBuilder.Entity<UsysLnkExportGroup>(entity =>
        {
            entity.HasKey(e => e.LnkExportGroupGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ExportId, e.ExportGroup }, "AK_USysLnkExportGroup")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkExportGroupGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ExportGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkExportGroup','ExportGroupDescription',[LnkExportGroupGUID]))", false);

            entity.HasOne(d => d.Export).WithMany(p => p.UsysLnkExportGroups).HasConstraintName("FK_USysLnkExportGroup_USysLnkExportMaster");
        });

        modelBuilder.Entity<UsysLnkExportGroupRule>(entity =>
        {
            entity.Property(e => e.LnkExportGroupRuleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkExportGroup).WithMany(p => p.UsysLnkExportGroupRules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportGroupRule_USysLnkExportGroup");

            entity.HasOne(d => d.RowSecurityRuleNameNavigation).WithMany(p => p.UsysLnkExportGroupRules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportGroupRule_USysRowSecurityRule");
        });

        modelBuilder.Entity<UsysLnkExportLog>(entity =>
        {
            entity.HasKey(e => e.LnkExportLogGuid).IsClustered(false);

            entity.Property(e => e.LnkExportLogGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ExportStatusCodeNavigation).WithMany(p => p.UsysLnkExportLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportLog_USysLnkExportStatusCode");

            entity.HasOne(d => d.LnkExportGroup).WithMany(p => p.UsysLnkExportLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportLog_USysLnkExportGroup");

            entity.HasOne(d => d.User).WithMany(p => p.UsysLnkExportLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportLog_USysUser");
        });

        modelBuilder.Entity<UsysLnkExportMaster>(entity =>
        {
            entity.Property(e => e.ExportDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkExportMaster','ExportDescription',[LnkExportMasterGUID]))", false);
            entity.Property(e => e.ExportType).IsFixedLength();
            entity.Property(e => e.LnkExportMasterGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysLnkExportMasterParameter>(entity =>
        {
            entity.HasKey(e => e.LnkExportMasterParameterGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ExportId, e.ParameterName }, "AK_USysLnkExportMasterParameter")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkExportMasterParameterGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Export).WithMany(p => p.UsysLnkExportMasterParameters).HasConstraintName("FK_USysLnkExportMasterParameter_USysLnkExportMaster");
        });

        modelBuilder.Entity<UsysLnkExportPersonHist>(entity =>
        {
            entity.Property(e => e.LnkExportPersonHistGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkExportGroup).WithMany(p => p.UsysLnkExportPersonHists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportPersonHist_USysLnkExportGroup");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysLnkExportPersonHists).HasConstraintName("FK_USysLnkExportPerson_tPerson");
        });

        modelBuilder.Entity<UsysLnkExportRecordDataError>(entity =>
        {
            entity.HasKey(e => e.LnkExportRecordDataErrorGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkExportRecordLogGuid, e.EventDate, e.FieldName }, "CIX_USysLnkExportRecordDataError")
                .IsDescending(false, true, false)
                .IsClustered();

            entity.Property(e => e.LnkExportRecordDataErrorGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkExportRecordLog).WithMany(p => p.UsysLnkExportRecordDataErrors).HasConstraintName("FK_USysLnkExportRecordDataError_USysLnkExportRecordLog");
        });

        modelBuilder.Entity<UsysLnkExportRecordLog>(entity =>
        {
            entity.HasKey(e => e.LnkExportRecordLogGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkExportLogGuid, e.LnkRecordGuid }, "AK_USysLnkExportRecordLog_LnkExportLogGUID_LnkRecordGUID")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkExportRecordLogGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkExportLog).WithMany(p => p.UsysLnkExportRecordLogs).HasConstraintName("FK_USysLnkExportRecordLog_USysLnkExportLog");

            entity.HasOne(d => d.LnkRecord).WithMany(p => p.UsysLnkExportRecordLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportRecordLog_USysLnkRecord");
        });

        modelBuilder.Entity<UsysLnkExportScheduleHist>(entity =>
        {
            entity.Property(e => e.LnkExportScheduleGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.LnkExportGroup).WithMany(p => p.UsysLnkExportScheduleHists).HasConstraintName("FK_USysLnkExportScheduleHist_UsysLnkExportGroup");
        });

        modelBuilder.Entity<UsysLnkExportStatusCode>(entity =>
        {
            entity.Property(e => e.ExportStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkExportStatusCode','ExportStatusDescription',[LnkExportStatusGUID]))", false);
            entity.Property(e => e.LnkExportStatusGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysLnkExportTrigger>(entity =>
        {
            entity.HasKey(e => e.LnkExportTriggerGuid).IsClustered(false);

            entity.HasIndex(e => e.ExportId, "IX_USysLnkExportTrigger_ExportID").IsClustered();

            entity.Property(e => e.LnkExportTriggerGuid).ValueGeneratedNever();
            entity.Property(e => e.TriggerType).IsFixedLength();

            entity.HasOne(d => d.Export).WithMany(p => p.UsysLnkExportTriggers).HasConstraintName("FK_USysLnkExportTrigger_USysLnkExportMaster");

            entity.HasOne(d => d.TableEntityNameNavigation).WithMany(p => p.UsysLnkExportTriggers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportTrigger_USysEntity");
        });

        modelBuilder.Entity<UsysLnkExportTriggerLog>(entity =>
        {
            entity.Property(e => e.LnkExportTriggerLogGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ExportTriggerActionCodeNavigation).WithMany(p => p.UsysLnkExportTriggerLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportTriggerLog_tExportTriggerAction");

            entity.HasOne(d => d.ExportTriggerStatusCodeNavigation).WithMany(p => p.UsysLnkExportTriggerLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportTriggerLog_tExportTriggerStatus");

            entity.HasOne(d => d.LnkExportLog).WithMany(p => p.UsysLnkExportTriggerLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkExportTriggerLog_USysLnkExportLog");
        });

        modelBuilder.Entity<UsysLnkExportTriggerPerson>(entity =>
        {
            entity.HasKey(e => e.LnkExportTriggerPersonGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ChangeDateTime, e.Status }, "IX_USysLnkExportTriggerPerson_ChangeDateTime_Status").IsClustered();

            entity.Property(e => e.LnkExportTriggerPersonGuid).ValueGeneratedNever();
            entity.Property(e => e.Status).IsFixedLength();

            entity.HasOne(d => d.Export).WithMany(p => p.UsysLnkExportTriggerPeople).HasConstraintName("FK_USysLnkExportTriggerPerson_USysLnkExportMaster");
        });

        modelBuilder.Entity<UsysLnkExportTriggerRecordLog>(entity =>
        {
            entity.Property(e => e.LnkExportTriggerRecordLogGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysLnkFieldAssoc>(entity =>
        {
            entity.HasKey(e => e.LnkFieldAssocGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkFieldDefGuid, e.AssocLnkFieldDefGuid }, "AK_USysLnkFieldAssoc")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkFieldAssocGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AssocLnkFieldDef).WithMany(p => p.UsysLnkFieldAssocAssocLnkFieldDefs).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.LnkFieldDef).WithMany(p => p.UsysLnkFieldAssocLnkFieldDefs).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UsysLnkFieldDef>(entity =>
        {
            entity.HasKey(e => e.LnkFieldDefGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkRecordGuid, e.StartPosition }, "AK_USysLnkFieldDef")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkFieldDefGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.FillChar).IsFixedLength();
            entity.Property(e => e.Justification).IsFixedLength();

            entity.HasOne(d => d.LnkRecord).WithMany(p => p.UsysLnkFieldDefs).HasConstraintName("FK_USysLnkFieldDef_USysLnkRecord");
        });

        modelBuilder.Entity<UsysLnkImportDataErpPayrollAccum>(entity =>
        {
            entity.Property(e => e.LnkImportDataErpPayrollAccumGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysLnkImportDataError>(entity =>
        {
            entity.Property(e => e.LnkImportDataErrorGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkImportLog).WithMany(p => p.UsysLnkImportDataErrors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportDataError_USysLnkImportLog");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysLnkImportDataErrors).HasConstraintName("FK_USysLnkImportDataError_tPerson");
        });

        modelBuilder.Entity<UsysLnkImportDate>(entity =>
        {
            entity.Property(e => e.LnkImportDateGuid).ValueGeneratedNever();
            entity.Property(e => e.ImportDateDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportDate','ImportDateDescription',[LnkImportDateGUID]))", false);

            entity.HasOne(d => d.LnkImportMaster).WithMany(p => p.UsysLnkImportDates).HasConstraintName("FK_USysLnkImportDate_USysLnkImportMaster");
        });

        modelBuilder.Entity<UsysLnkImportDestinationTable>(entity =>
        {
            entity.Property(e => e.LnkImportDestinationTableGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysLnkImportFieldDataType>(entity =>
        {
            entity.Property(e => e.ImportFieldDataTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportFieldDataType','ImportFieldDataTypeDescription',[LnkImportFieldDataTypeGUID]))", false);
        });

        modelBuilder.Entity<UsysLnkImportFieldDef>(entity =>
        {
            entity.Property(e => e.LnkImportFieldDefGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkImportDestinationTable).WithMany(p => p.UsysLnkImportFieldDefs).HasConstraintName("FK_USysLnkImportFieldDef_USysLnkImportDestinationTable");

            entity.HasOne(d => d.LnkImportFieldDataTypeCodeNavigation).WithMany(p => p.UsysLnkImportFieldDefs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportFieldDef_USysLnkImportFieldDataType");

            entity.HasOne(d => d.LnkImportSource).WithMany(p => p.UsysLnkImportFieldDefs).HasConstraintName("FK_USysLnkImportFieldDef_USysLnkImportSource");
        });

        modelBuilder.Entity<UsysLnkImportFieldTranslation>(entity =>
        {
            entity.Property(e => e.LnkImportFieldTranslationGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkImportFieldDef).WithMany(p => p.UsysLnkImportFieldTranslations).HasConstraintName("FK_USysLnkImportFieldTranslation_USysLnkImportFieldDef");
        });

        modelBuilder.Entity<UsysLnkImportGroup>(entity =>
        {
            entity.Property(e => e.ImportGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportGroup','ImportGroupDescription',[LnkImportGroupGUID]))", false);

            entity.HasOne(d => d.LnkImportMaster).WithMany(p => p.UsysLnkImportGroups).HasConstraintName("FK_USysLnkImportGroup_USysLnkImportMaster");
        });

        modelBuilder.Entity<UsysLnkImportGroupAssignment>(entity =>
        {
            entity.Property(e => e.LnkImportGroupAssignmentGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ImportGroupCodeNavigation).WithMany(p => p.UsysLnkImportGroupAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportGroupAssignment_USysLnkImportGroup");

            entity.HasOne(d => d.PayrollVendorCompany).WithMany(p => p.UsysLnkImportGroupAssignments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysLnkImportGroupAssignment_tPayrollVendorCompany");
        });

        modelBuilder.Entity<UsysLnkImportLog>(entity =>
        {
            entity.Property(e => e.LnkImportLogGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ImportGroupCodeNavigation).WithMany(p => p.UsysLnkImportLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportLog_USysLnkImportGroup");

            entity.HasOne(d => d.ImportStatusCodeNavigation).WithMany(p => p.UsysLnkImportLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportLog_USysLnkImportStatusCode");

            entity.HasOne(d => d.User).WithMany(p => p.UsysLnkImportLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportLog_USysUser");
        });

        modelBuilder.Entity<UsysLnkImportMaster>(entity =>
        {
            entity.Property(e => e.LnkImportMasterGuid).ValueGeneratedNever();
            entity.Property(e => e.ImportMasterDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportMaster','ImportMasterDescription',[LnkImportMasterGUID]))", false);

            entity.HasOne(d => d.ImportTypeCodeNavigation).WithMany(p => p.UsysLnkImportMasters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportMaster_USysLnkImportType");

            entity.HasOne(d => d.ReportEntityNameNavigation).WithMany(p => p.UsysLnkImportMasters)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportMaster_USysEntity");

            entity.HasOne(d => d.VendorCodeNavigation).WithMany(p => p.UsysLnkImportMasters).HasConstraintName("FK_USysLnkImportMaster_tVendor");
        });

        modelBuilder.Entity<UsysLnkImportScheduleHist>(entity =>
        {
            entity.Property(e => e.LnkImportScheduleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ImportGroupCodeNavigation).WithMany(p => p.UsysLnkImportScheduleHists).HasConstraintName("FK_USysLnkImportScheduleHist_USysLnkImportGroup");
        });

        modelBuilder.Entity<UsysLnkImportSource>(entity =>
        {
            entity.Property(e => e.LnkImportSourceGuid).ValueGeneratedNever();
            entity.Property(e => e.ImportSourceDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportSource','ImportSourceDescription',[LnkImportSourceGUID]))", false);

            entity.HasOne(d => d.ImportSourceTypeCodeNavigation).WithMany(p => p.UsysLnkImportSources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkImportSource_USysLnkImportSourceType");

            entity.HasOne(d => d.LnkImportMaster).WithMany(p => p.UsysLnkImportSources).HasConstraintName("FK_USysLnkImportSource_USysLnkImportMaster");
        });

        modelBuilder.Entity<UsysLnkImportSourceParameter>(entity =>
        {
            entity.Property(e => e.LnkImportSourceParameterGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LnkImportSource).WithMany(p => p.UsysLnkImportSourceParameters).HasConstraintName("FK_USysLnkImportSourceParameter_USysLnkImportSource");
        });

        modelBuilder.Entity<UsysLnkImportSourceType>(entity =>
        {
            entity.Property(e => e.ImportSourceTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportSourceType','ImportSourceTypeDescription',[LnkImportSourceTypeGUID]))", false);
        });

        modelBuilder.Entity<UsysLnkImportStatusCode>(entity =>
        {
            entity.HasKey(e => e.ImportStatusCode).HasName("USysLnkImportStatus");

            entity.Property(e => e.ImportStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportStatus','ImportStatusDescription',[LnkImportStatusGUID]))", false);
        });

        modelBuilder.Entity<UsysLnkImportType>(entity =>
        {
            entity.Property(e => e.ImportTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysLnkImportType','ImportTypeDescription',[ImportTypeGUID]))", false);
        });

        modelBuilder.Entity<UsysLnkRecord>(entity =>
        {
            entity.HasKey(e => e.LnkRecordGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkExportFileGuid, e.Sequence }, "AK_USysLnkRecord_LnkExportFileGUID_Sequence")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkRecordGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkExportFile).WithMany(p => p.UsysLnkRecords).HasConstraintName("FK_USysLnkRecord_USysLnkExportFile");
        });

        modelBuilder.Entity<UsysLnkRollupBenefit>(entity =>
        {
            entity.Property(e => e.LnkRollupBenefitGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.BenefitPlanOption).WithMany(p => p.UsysLnkRollupBenefits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkRollupBenefit_tBenefitPlanOption");

            entity.HasOne(d => d.LnkRollupCode).WithMany(p => p.UsysLnkRollupBenefits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkRollupBenefit_USysLnkRollupCode");
        });

        modelBuilder.Entity<UsysLnkRollupCode>(entity =>
        {
            entity.Property(e => e.LnkRollupCodeGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Export).WithMany(p => p.UsysLnkRollupCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysLnkRollupCode_USysLnkExportMaster");
        });

        modelBuilder.Entity<UsysLnkTable>(entity =>
        {
            entity.HasKey(e => e.LnkTableGuid).IsClustered(false);

            entity.HasIndex(e => e.TableName, "AK_USysLnkTable_TableName")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkTableGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysLnkTableCriterion>(entity =>
        {
            entity.HasKey(e => e.LnkTableCriteriaGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LnkTableGuid, e.Sequence }, "AK_USysLnkTableCriteria_TableSequence")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.LnkTableCriteriaGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.LnkTable).WithMany(p => p.UsysLnkTableCriteria).HasConstraintName("FK_USysLnkTableCriteria_USysLnkTable");
        });

        modelBuilder.Entity<UsysLog>(entity =>
        {
            entity.HasKey(e => e.SysLogGuid).IsClustered(false);

            entity.HasIndex(e => new { e.LogDateTime, e.Severity }, "IX_USysLogBySeverity").IsClustered();

            entity.Property(e => e.SysLogGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysLogConfig>(entity =>
        {
            entity.Property(e => e.SysLogConfigGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysLuceneIndexChange>(entity =>
        {
            entity.HasKey(e => e.LuceneIndexChangeGuid).IsClustered(false);

            entity.Property(e => e.LuceneIndexChangeGuid).ValueGeneratedNever();
            entity.Property(e => e.TriggerType).IsFixedLength();
        });

        modelBuilder.Entity<UsysMassChangeError>(entity =>
        {
            entity.HasKey(e => e.MassChangeErrorGuid).IsClustered(false);

            entity.HasIndex(e => new { e.MassChangeInstanceGuid, e.PersonGuid, e.RecordGuid }, "AK_USysMassChangeError")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.MassChangeErrorGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InsertedDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MassChangeInstance).WithMany(p => p.UsysMassChangeErrors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysMassChangeError_tMassChange");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysMassChangeErrors).HasConstraintName("FK_USysMassChangeError_tPerson");
        });

        modelBuilder.Entity<UsysMassChangeSql>(entity =>
        {
            entity.HasKey(e => e.MassChangeSqlguid).IsClustered(false);

            entity.HasIndex(e => new { e.MassChangeInstanceGuid, e.PersonGuid, e.RecordGuid }, "AK_USysMassChangeSQL")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.MassChangeSqlguid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InsertedDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.MassChangeInstance).WithMany(p => p.UsysMassChangeSqls)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysMassChangeSQL_tMassChange");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysMassChangeSqls).HasConstraintName("FK_USysMassChangeSQL_tPerson");
        });

        modelBuilder.Entity<UsysMobileComponent>(entity =>
        {
            entity.Property(e => e.MobileComponentGuid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsysModule>(entity =>
        {
            entity.Property(e => e.ModuleGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysModules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysModule_USysModuleDefinition");

            entity.HasOne(d => d.SysTab).WithMany(p => p.UsysModules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysModule_USysTab");
        });

        modelBuilder.Entity<UsysModuleDefinition>(entity =>
        {
            entity.Property(e => e.ModuleDefinitionGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysModuleField>(entity =>
        {
            entity.Property(e => e.ModuleFieldGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysModuleFields).HasConstraintName("FK_USysModuleField_USysModuleDefinition");
        });

        modelBuilder.Entity<UsysModuleSetting>(entity =>
        {
            entity.HasKey(e => e.ModuleSettingGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ModuleDefinitionGuid, e.SettingName }, "AK_USysModuleSetting")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ModuleSettingGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysModuleSettings).HasConstraintName("FK_USysModuleSetting_USysModuleDefinition");
        });

        modelBuilder.Entity<UsysNavigator>(entity =>
        {
            entity.HasKey(e => e.SysNavigatorGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ParentGuid, e.SortOrder }, "CIX_USysNavigator_ParentGuidSortOrder").IsClustered();

            entity.Property(e => e.SysNavigatorGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.HoverText).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysNavigator','HoverText',[SysNavigatorGuid]))", false);

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysNavigators)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysNavigator_USysEntity");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasConstraintName("FK_USysNavigator_Parent_USysNavigator");

            entity.HasOne(d => d.SysTab).WithMany(p => p.UsysNavigators)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysNavigator_USysTab");
        });

        modelBuilder.Entity<UsysNightlyRun>(entity =>
        {
            entity.HasKey(e => e.NightlyRunGuid).IsClustered(false);

            entity.HasIndex(e => e.ServerName, "IX_USysNightlyRun_ServerName").IsClustered();

            entity.Property(e => e.NightlyRunGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysOrgChart>(entity =>
        {
            entity.Property(e => e.OrgChartGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.User).WithMany(p => p.UsysOrgCharts).HasConstraintName("FK_USysOrgChart_USysUser");
        });

        modelBuilder.Entity<UsysPortal>(entity =>
        {
            entity.Property(e => e.PortalGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PortalTypeCodeNavigation).WithMany(p => p.UsysPortals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysPortal_USysPortalType");
        });

        modelBuilder.Entity<UsysPortalHomePageModule>(entity =>
        {
            entity.HasKey(e => e.PortalHomePageModuleGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PortalGuid, e.ModuleGuid }, "CIX_USysPortalHomePageModule_PortalGUID_ModuleGUID").IsClustered();

            entity.Property(e => e.PortalHomePageModuleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Module).WithMany(p => p.UsysPortalHomePageModules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysPortalHomePageModule_USysModule");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysPortalHomePageModules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysPortalHomePageModule_USysPortal");
        });

        modelBuilder.Entity<UsysPortalType>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysQueryBuilderQuery>(entity =>
        {
            entity.HasKey(e => e.SysQueryBuilderQueryGuid).IsClustered(false);

            entity.HasIndex(e => new { e.QueryName, e.CreatedByUserGuid }, "IX_USysQueryBuilderQueryName")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SysQueryBuilderQueryGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.RowSecurityRuleNameNavigation).WithMany(p => p.UsysQueryBuilderQueries).HasConstraintName("FK_USysQueryBuilderQuery_USysRowSecurityRule");
        });

        modelBuilder.Entity<UsysRecipient>(entity =>
        {
            entity.Property(e => e.RecipientGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RecipientDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRecipient','RecipientDescription',[RecipientGUID]))", false);

            entity.HasOne(d => d.RecipientDesignatorCodeNavigation).WithMany(p => p.UsysRecipients).HasConstraintName("FK_USysRecipient_USysRecipientDesignator");

            entity.HasOne(d => d.RecipientPerson).WithMany(p => p.UsysRecipients).HasConstraintName("FK_USysRecipient_tPerson");

            entity.HasOne(d => d.RecipientPositionCodeNavigation).WithMany(p => p.UsysRecipients).HasConstraintName("FK_USysRecipient_tPosition");
        });

        modelBuilder.Entity<UsysRecipientDesignator>(entity =>
        {
            entity.Property(e => e.RecipientDesignatorDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRecipientDesignator','RecipientDesignatorDescription',[RecipientDesignatorGUID]))", false);
            entity.Property(e => e.RecipientDesignatorGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysRecipientOverride>(entity =>
        {
            entity.HasKey(e => e.OverrideGuid).IsClustered(false);

            entity.HasIndex(e => e.OriginalApproverGuid, "CIX_USysRecipientOverride_OriginalApproverGuid").IsClustered();

            entity.Property(e => e.OverrideGuid).ValueGeneratedNever();

            entity.HasOne(d => d.OriginalApprover).WithMany(p => p.UsysRecipientOverrideOriginalApprovers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRecipientOverrideOriginalApprover_tPerson");

            entity.HasOne(d => d.OverrideApprover).WithMany(p => p.UsysRecipientOverrideOverrideApprovers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRecipientOverrideOverrideApprover_tPerson");

            entity.HasOne(d => d.TaskEntityNavigation).WithMany(p => p.UsysRecipientOverrides).HasConstraintName("FK_USysRecipientOverrideTaskEntity_USysEntity");
        });

        modelBuilder.Entity<UsysRecipientType>(entity =>
        {
            entity.Property(e => e.RecipientTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRecipientType','RecipientTypeDescription',[RecipientTypeGUID]))", false);
            entity.Property(e => e.RecipientTypeGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysReportParameter>(entity =>
        {
            entity.Property(e => e.ReportParametersGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.User).WithMany(p => p.UsysReportParameters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysReportParameters_USysUser");
        });

        modelBuilder.Entity<UsysResource>(entity =>
        {
            entity.HasKey(e => e.ResourceGuid).IsClustered(false);

            entity.HasIndex(e => new { e.ResourceName, e.ResourceTypeCode, e.LanguageCode, e.Csfcode, e.PortalGuid }, "AK_USysResource")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ResourceGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CsfcodeNavigation).WithMany(p => p.UsysResources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysResource_USysCSF");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.UsysResources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysResource_tLanguage");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysResources).HasConstraintName("FK_USysResource_USysPortal");

            entity.HasOne(d => d.ResourceTypeCodeNavigation).WithMany(p => p.UsysResources)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysResource_USysResourceType");
        });

        modelBuilder.Entity<UsysResourceType>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysResumeSearch>(entity =>
        {
            entity.HasKey(e => e.SysResumeSearchGuid).HasName("PK_UsysResumeSearch");

            entity.Property(e => e.SysResumeSearchGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.User).WithMany(p => p.UsysResumeSearches).HasConstraintName("FK_USysResumeSearch_USysUser");
        });

        modelBuilder.Entity<UsysResumeSearchParameter>(entity =>
        {
            entity.Property(e => e.SysResumeSearchParameterGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.SysResumeSearch).WithMany(p => p.UsysResumeSearchParameters).HasConstraintName("FK_USysResumeSearchParameter_USysResumeSearch");
        });

        modelBuilder.Entity<UsysRole>(entity =>
        {
            entity.Property(e => e.RoleGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysRoleCodeFilterGroup>(entity =>
        {
            entity.HasKey(e => e.SysRoleCodeFilterGroupGuid).IsClustered(false);

            entity.HasIndex(e => new { e.RoleGuid, e.CodeFilterGroupCode }, "AK_USysRoleCodeFilterGroup")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SysRoleCodeFilterGroupGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CodeFilterGroupCodeNavigation).WithMany(p => p.UsysRoleCodeFilterGroups).HasConstraintName("FK_USysRoleCodeFilterGroup_USysCodeFilterGroup");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysRoleCodeFilterGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoleCodeFilterGroup_USysRole");
        });

        modelBuilder.Entity<UsysRoleEntity>(entity =>
        {
            entity.HasKey(e => e.RoleEntityGuid).IsClustered(false);

            entity.HasIndex(e => new { e.RoleGuid, e.EntityName }, "AK_USysRoleEntity")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleEntityGuid).ValueGeneratedNever();

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysRoleEntities).HasConstraintName("FK_USysRoleEntity_USysEntity");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysRoleEntities)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoleEntity_USysRole");
        });

        modelBuilder.Entity<UsysRoleFlag>(entity =>
        {
            entity.HasKey(e => e.RoleFlagGuid).IsClustered(false);

            entity.HasIndex(e => new { e.RoleGuid, e.FlagGuid }, "AK_USysRoleFlag")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleFlagGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Flag).WithMany(p => p.UsysRoleFlags)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoleFlag_USysFlag");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysRoleFlags).HasConstraintName("FK_USysRoleFlag_USysRole");
        });

        modelBuilder.Entity<UsysRoleModuleDefinition>(entity =>
        {
            entity.HasKey(e => e.RoleModuleDefinitionGuid).IsClustered(false);

            entity.HasIndex(e => new { e.RoleGuid, e.ModuleDefinitionGuid }, "AK_USysRoleModuleDefinition")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleModuleDefinitionGuid).ValueGeneratedNever();

            entity.HasOne(d => d.ModuleDefinition).WithMany(p => p.UsysRoleModuleDefinitions).HasConstraintName("FK_USysRoleModuleDefinition_USysModuleDefinition");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysRoleModuleDefinitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoleModuleDefinition_USysRole");
        });

        modelBuilder.Entity<UsysRolePortal>(entity =>
        {
            entity.HasKey(e => e.RolePortalGuid).IsClustered(false);

            entity.HasIndex(e => e.RoleGuid, "CIX_USysRolePortal_RoleGuid").IsClustered();

            entity.Property(e => e.RolePortalGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysRolePortals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRolePortal_USysPortal");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysRolePortals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRolePortal_USysRole");
        });

        modelBuilder.Entity<UsysRoleRule>(entity =>
        {
            entity.HasKey(e => e.SysRoleRulesGuid).IsClustered(false);

            entity.HasIndex(e => new { e.RoleGuid, e.RowSecurityRuleName }, "AK_USysRoleRules")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SysRoleRulesGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysRoleRules).HasConstraintName("FK_USysRoleRules_USysRole");

            entity.HasOne(d => d.RowSecurityRuleNameNavigation).WithMany(p => p.UsysRoleRules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoleRules_USysRowSecurityRule");
        });

        modelBuilder.Entity<UsysRouting>(entity =>
        {
            entity.HasKey(e => e.RoutingGuid).IsClustered(false);

            entity.HasIndex(e => e.TaskEntity, "AK_USysRouting")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoutingGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RoutingDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRouting','RoutingDescription',[RoutingGUID]))", false);

            entity.HasOne(d => d.TaskEntityNavigation).WithOne(p => p.UsysRouting)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysRouting_USysEntity");
        });

        modelBuilder.Entity<UsysRoutingInstance>(entity =>
        {
            entity.Property(e => e.RoutingInstanceGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RoutingStatusCode).HasDefaultValueSql("('I')");
            entity.Property(e => e.StartDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.OriginatorPerson).WithMany(p => p.UsysRoutingInstanceOriginatorPeople).HasConstraintName("FK_USysRoutingInstance_tPerson");

            entity.HasOne(d => d.PreviousRoutingInstance).WithMany(p => p.InversePreviousRoutingInstance).HasConstraintName("FK_USysRoutingInstance_tRoutingInstance");

            entity.HasOne(d => d.Routing).WithMany(p => p.UsysRoutingInstances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoutingInstance_tRouting");

            entity.HasOne(d => d.RoutingStatusCodeNavigation).WithMany(p => p.UsysRoutingInstances).HasConstraintName("FK_USysRoutingInstance_USysRoutingStatus");

            entity.HasOne(d => d.RoutingStepGroup).WithMany(p => p.UsysRoutingInstances).HasConstraintName("FK_USysRoutingInstance_tRoutingStepGroup");

            entity.HasOne(d => d.SubjectPerson).WithMany(p => p.UsysRoutingInstanceSubjectPeople).HasConstraintName("FK_USysRoutingInstance_tPerson1");
        });

        modelBuilder.Entity<UsysRoutingInstanceHistory>(entity =>
        {
            entity.Property(e => e.RoutingInstanceHistoryGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Routing).WithMany(p => p.UsysRoutingInstanceHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoutingInstanceHistory_tRouting");

            entity.HasOne(d => d.RoutingStatusCodeNavigation).WithMany(p => p.UsysRoutingInstanceHistories).HasConstraintName("FK_USysRoutingInstanceHistory_USysRoutingStatus");
        });

        modelBuilder.Entity<UsysRoutingInstanceStep>(entity =>
        {
            entity.HasKey(e => e.RoutingInstanceStepGuid).IsClustered(false);

            entity.HasIndex(e => new { e.RoutingInstanceGuid, e.InitiatedDateTime }, "CIX_USysRoutingInstanceStep_RoutingInstanceGUID").IsClustered();

            entity.Property(e => e.RoutingInstanceStepGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.InitiatedDateTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RoutingResponseCode).HasDefaultValueSql("('N')");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysRoutingInstanceSteps).HasConstraintName("FK_USysRoutingInstanceStep_USysPortal");

            entity.HasOne(d => d.RecipientPerson).WithMany(p => p.UsysRoutingInstanceStepRecipientPeople).HasConstraintName("FK_USysRoutingInstanceStep_tPerson");

            entity.HasOne(d => d.RoutingInstance).WithMany(p => p.UsysRoutingInstanceSteps).HasConstraintName("FK_USysRoutingInstanceStep_USysRoutingInstance");

            entity.HasOne(d => d.RoutingResponseCodeNavigation).WithMany(p => p.UsysRoutingInstanceSteps).HasConstraintName("FK_USysRoutingInstanceStep_USysRoutingResponse");

            entity.HasOne(d => d.RoutingStep).WithMany(p => p.UsysRoutingInstanceSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoutingInstanceStep_USysRoutingStep");

            entity.HasOne(d => d.SignedByPerson).WithMany(p => p.UsysRoutingInstanceStepSignedByPeople).HasConstraintName("FK_USysRoutingInstanceStep_SignedBy_tPerson");
        });

        modelBuilder.Entity<UsysRoutingInstanceStepHistory>(entity =>
        {
            entity.HasKey(e => e.RoutingInstanceStepHistoryGuid).IsClustered(false);

            entity.HasIndex(e => e.RoutingInstanceHistoryGuid, "CIX_USysRoutingInstanceStepHistory_RoutingInstanceHistoryGUID").IsClustered();

            entity.Property(e => e.RoutingInstanceStepHistoryGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysRoutingInstanceStepHistories).HasConstraintName("FK_USysRoutingInstanceStepHistory_USysPortal");

            entity.HasOne(d => d.RoutingInstanceHistory).WithMany(p => p.UsysRoutingInstanceStepHistories).HasConstraintName("FK_USysRoutingInstanceStepHistory_USysRoutingInstance");

            entity.HasOne(d => d.RoutingResponseCodeNavigation).WithMany(p => p.UsysRoutingInstanceStepHistories).HasConstraintName("FK_USysRoutingInstanceStepHistory_USysRoutingResponse");
        });

        modelBuilder.Entity<UsysRoutingResponse>(entity =>
        {
            entity.Property(e => e.RoutingResponseDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRoutingResponse','RoutingResponseDescription',[RoutingResponseGUID]))", false);
            entity.Property(e => e.RoutingResponseGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysRoutingStatus>(entity =>
        {
            entity.Property(e => e.RoutingStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRoutingStatus','RoutingStatusDescription',[RoutingStatusGUID]))", false);
            entity.Property(e => e.RoutingStatusGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysRoutingStep>(entity =>
        {
            entity.HasKey(e => e.RoutingStepGuid).IsClustered(false);

            entity.HasIndex(e => e.RoutingStepGuid, "CIX_USysRoutingStep_RecipientGUID").IsClustered();

            entity.Property(e => e.RoutingStepGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Recipient).WithMany(p => p.UsysRoutingSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoutingStep_USysRecipient");

            entity.HasOne(d => d.RecipientTypeCodeNavigation).WithMany(p => p.UsysRoutingSteps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysRoutingStep_USysRecipientType");

            entity.HasOne(d => d.RoutingStepGroup).WithMany(p => p.UsysRoutingSteps).HasConstraintName("FK_USysRoutingStep_USysRoutingStepGroup");

            entity.HasOne(d => d.RuleSetCodeNavigation).WithMany(p => p.UsysRoutingSteps).HasConstraintName("FK_USysRoutingStep_USysRuleSet");
        });

        modelBuilder.Entity<UsysRoutingStepGroup>(entity =>
        {
            entity.HasKey(e => e.RoutingStepGroupGuid).IsClustered(false);

            entity.HasIndex(e => e.RoutingGuid, "CIX_USysRoutingStepGroup_RoutingGuid").IsClustered();

            entity.Property(e => e.RoutingStepGroupGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RoutingStepGroupDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRoutingStepGroup','RoutingStepGroupDescription',[RoutingStepGroupGUID]))", false);

            entity.HasOne(d => d.Routing).WithMany(p => p.UsysRoutingStepGroups).HasConstraintName("FK_USysRoutingStepGroup_USysRouting");

            entity.HasOne(d => d.RuleSetCodeNavigation).WithMany(p => p.UsysRoutingStepGroups).HasConstraintName("FK_USysRoutingStepGroup_USysRuleSet");
        });

        modelBuilder.Entity<UsysRowSecurity>(entity =>
        {
            entity.HasKey(e => e.RowSecurityGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserGuid, e.PersonGuid }, "AK_USysRowSecurity")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RowSecurityGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysRowSecurities).HasConstraintName("FK_USysRowSecurity_tPerson");

            entity.HasOne(d => d.User).WithMany(p => p.UsysRowSecurities).HasConstraintName("FK_USysRowSecurity_USysUser");
        });

        modelBuilder.Entity<UsysRowSecurityRule>(entity =>
        {
            entity.Property(e => e.RowSecurityRuleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRowSecurityRule','RowSecurityRuleDescription',[RowSecurityRuleGUID]))", false);
        });

        modelBuilder.Entity<UsysRule>(entity =>
        {
            entity.Property(e => e.ComparisonOperator).HasDefaultValueSql("('=')");
            entity.Property(e => e.DataType).HasDefaultValueSql("('nvarchar')");
            entity.Property(e => e.RuleDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRule','RuleDescription',[RuleGUID]))", false);
            entity.Property(e => e.RuleGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysRules)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysRule_USysEntity");
        });

        modelBuilder.Entity<UsysRuleSet>(entity =>
        {
            entity.Property(e => e.RuleSetDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysRuleSet','RuleSetDescription',[RuleSetGUID]))", false);
        });

        modelBuilder.Entity<UsysRuleSetRule>(entity =>
        {
            entity.Property(e => e.RuleSetRuleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.RuleCodeNavigation).WithMany(p => p.UsysRuleSetRules).HasConstraintName("FK_USysRuleSetRule_USysRule");

            entity.HasOne(d => d.RuleSetCodeNavigation).WithMany(p => p.UsysRuleSetRules).HasConstraintName("FK_USysRuleSetRule_USysRuleSet");
        });

        modelBuilder.Entity<UsysSalaryPlan>(entity =>
        {
            entity.Property(e => e.SalaryPlanGuid).ValueGeneratedNever();

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.UsysSalaryPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlan_tCurrency");

            entity.HasOne(d => d.ModelApprovedBy).WithMany(p => p.UsysSalaryPlans).HasConstraintName("FK_USysSalaryPlan_tPerson");

            entity.HasOne(d => d.SalaryPlanPerformanceMatrixCodeNavigation).WithMany(p => p.UsysSalaryPlans).HasConstraintName("FK_USysSalaryPlan_USysSalaryPlanPerformanceMatrix");

            entity.HasOne(d => d.SalaryPlanStatusCodeNavigation).WithMany(p => p.UsysSalaryPlans).HasConstraintName("FK_USysSalaryPlan_USysSalaryPlanStatus");
        });

        modelBuilder.Entity<UsysSalaryPlanBasePayDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryPlanBasePayDetailGuid).IsClustered(false);

            entity.HasIndex(e => e.SalaryPlanGuid, "CIX_SysSalaryPlanBasePayDetail").IsClustered();

            entity.Property(e => e.SalaryPlanBasePayDetailGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AmountChangeFrequencyCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanBasePayDetail_tFrequency");

            entity.HasOne(d => d.PersonBasePayReasonCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanBasePayDetail_tBasePayReason");

            entity.HasOne(d => d.SalaryPlan).WithMany(p => p.UsysSalaryPlanBasePayDetails).HasConstraintName("FK_USysSalaryPlanBasePayDetail_USysSalaryPlan");
        });

        modelBuilder.Entity<UsysSalaryPlanBasePayPersonDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryPlanBasePayPersonDetailGuid).IsClustered(false);

            entity.HasIndex(e => e.SalaryPlanPersonGuid, "CIX_SysSalaryPlanBasePayPersonDetail").IsClustered();

            entity.Property(e => e.SalaryPlanBasePayPersonDetailGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PerformanceRatingCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayPersonDetails).HasConstraintName("FK_USysSalaryPlanBasePayPersonDetail_tPerformanceRating");

            entity.HasOne(d => d.PersonBasePayChangeAmountFrequencyCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayPersonDetailPersonBasePayChangeAmountFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanBasePayPersonDetail_tFrequency");

            entity.HasOne(d => d.PersonBasePayFrequencyCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayPersonDetailPersonBasePayFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanBasePayPersonDetail_tFrequency1");

            entity.HasOne(d => d.PersonBasePayReasonCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayPersonDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanBasePayPersonDetail_tBasePayReason");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.UsysSalaryPlanBasePayPersonDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanBasePayPersonDetail_tPosition");

            entity.HasOne(d => d.SalaryPlanPerson).WithMany(p => p.UsysSalaryPlanBasePayPersonDetails).HasConstraintName("FK_USysSalaryPlanBasePayPersonDetail_USysSalaryPlanPerson");
        });

        modelBuilder.Entity<UsysSalaryPlanOtherPayDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryPlanOtherPayDetailGuid).IsClustered(false);

            entity.HasIndex(e => e.SalaryPlanGuid, "CIX_SysSalaryPlanOtherPayDetail").IsClustered();

            entity.Property(e => e.SalaryPlanOtherPayDetailGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AmountChangeFrequencyCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayDetail_tFrequency");

            entity.HasOne(d => d.PersonOtherPayReasonCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayDetail_tOtherPayReason");

            entity.HasOne(d => d.PersonOtherPayTypeCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayDetail_tOtherPayType");

            entity.HasOne(d => d.SalaryPlan).WithMany(p => p.UsysSalaryPlanOtherPayDetails).HasConstraintName("FK_USysSalaryPlanOtherPayDetail_USysSalaryPlan");
        });

        modelBuilder.Entity<UsysSalaryPlanOtherPayPersonDetail>(entity =>
        {
            entity.HasKey(e => e.SalaryPlanOtherPayPersonDetailGuid).IsClustered(false);

            entity.HasIndex(e => e.SalaryPlanPersonGuid, "CIX_SysSalaryPlanOtherPayPersonDetail").IsClustered();

            entity.Property(e => e.SalaryPlanOtherPayPersonDetailGuid).ValueGeneratedNever();

            entity.HasOne(d => d.PersonOtherPayChangeAmountFrequencyCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayPersonDetailPersonOtherPayChangeAmountFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayPersonDetail_tFrequency");

            entity.HasOne(d => d.PersonOtherPayFrequencyCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayPersonDetailPersonOtherPayFrequencyCodeNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayPersonDetail_tFrequency1");

            entity.HasOne(d => d.PersonOtherPayReasonCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayPersonDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayPersonDetail_tOtherPayReason");

            entity.HasOne(d => d.PersonOtherPayTypeCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayPersonDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayPersonDetail_tOtherPayType");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.UsysSalaryPlanOtherPayPersonDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanOtherPayPersonDetail_tPosition");

            entity.HasOne(d => d.SalaryPlanPerson).WithMany(p => p.UsysSalaryPlanOtherPayPersonDetails).HasConstraintName("FK_USysSalaryPlanOtherPayPersonDetail_USysSalaryPlanPerson");
        });

        modelBuilder.Entity<UsysSalaryPlanPerformanceMatrix>(entity =>
        {
            entity.HasKey(e => e.SalaryPlanPerformanceMatrixCode).IsClustered(false);

            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.SalaryPlanPerformanceMatrixDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysSalaryPlanPerformanceMatrix','SalaryPlanPerformanceMatrixDescription',[SalaryPlanPerformanceMatrixGUID]))", false);

            entity.HasOne(d => d.PerformanceReviewTypeCodeNavigation).WithMany(p => p.UsysSalaryPlanPerformanceMatrices).HasConstraintName("FK_USysSalaryPlanPerformanceMatrix_tPerformanceReviewType");
        });

        modelBuilder.Entity<UsysSalaryPlanPerformanceMatrixRuleSet>(entity =>
        {
            entity.HasKey(e => e.SalaryPlanPerformanceMatrixRuleSetGuid).IsClustered(false);

            entity.Property(e => e.SalaryPlanPerformanceMatrixRuleSetGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.PerformanceRatingCodeNavigation).WithMany(p => p.UsysSalaryPlanPerformanceMatrixRuleSets).HasConstraintName("FK_USysSalaryPlanPerformanceMatrixRuleSet_tPerformanceRating");

            entity.HasOne(d => d.SalaryPlanPerformanceMatrixCodeNavigation).WithMany(p => p.UsysSalaryPlanPerformanceMatrixRuleSets)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysSalaryPlanPerformanceMatrixRuleSet_USysSalaryPlanPerformanceMatrix");
        });

        modelBuilder.Entity<UsysSalaryPlanPerson>(entity =>
        {
            entity.Property(e => e.SalaryPlanPersonGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Person).WithMany(p => p.UsysSalaryPlanPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanPerson_tPerson");

            entity.HasOne(d => d.PositionCodeNavigation).WithMany(p => p.UsysSalaryPlanPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSalaryPlanPerson_tPosition");

            entity.HasOne(d => d.SalaryPlan).WithMany(p => p.UsysSalaryPlanPeople).HasConstraintName("FK_USysSalaryPlanPerson_USysSalaryPlan");
        });

        modelBuilder.Entity<UsysSalaryPlanStatus>(entity =>
        {
            entity.Property(e => e.SalaryPlanStatusDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysSalaryPlanStatus','SalaryPlanStatusDescription',[SalaryPlanStatusGUID]))", false);
            entity.Property(e => e.SalaryPlanStatusGuid).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<UsysServiceAccessLog>(entity =>
        {
            entity.HasKey(e => e.ServiceAccessLogGuid).IsClustered(false);

            entity.HasIndex(e => e.AccessDateTime, "CIX_USysServiceAccessLog_AccessDateTime").IsClustered();

            entity.Property(e => e.ServiceAccessLogGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysSynchronizationEntity>(entity =>
        {
            entity.HasKey(e => e.SynchronizationEntityGuid).IsClustered(false);

            entity.HasIndex(e => e.EntityName, "CIX_USysSynchronizationEntity")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SynchronizationEntityGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.EntityNameNavigation).WithOne(p => p.UsysSynchronizationEntity)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysSynchronizationEntity_USysEntity");
        });

        modelBuilder.Entity<UsysSynchronizationPerson>(entity =>
        {
            entity.HasKey(e => e.SynchronizationPersonGuid).IsClustered(false);

            entity.HasIndex(e => new { e.PersonGuid, e.DataType }, "CIX_USysSynchronizationPerson")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SynchronizationPersonGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysTab>(entity =>
        {
            entity.HasKey(e => e.SysTabGuid).IsClustered(false);

            entity.HasIndex(e => e.PortalGuid, "CIX_USysTab_PortalGUID").IsClustered();

            entity.Property(e => e.SysTabGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysTabs).HasConstraintName("FK_USysTab_Portal");
        });

        modelBuilder.Entity<UsysTaskDataLog>(entity =>
        {
            entity.Property(e => e.TaskDataLogGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.LoggedByUser).WithMany(p => p.UsysTaskDataLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysTaskDataLog_USysUser");

            entity.HasOne(d => d.TaskData).WithMany(p => p.UsysTaskDataLogs).HasConstraintName("FK_USysTaskDataLog_USysTaskData");
        });

        modelBuilder.Entity<UsysTaskDatum>(entity =>
        {
            entity.HasKey(e => e.TaskDataGuid).IsClustered(false);

            entity.HasIndex(e => new { e.Name, e.Type }, "AK_USysTaskData")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TaskDataGuid).ValueGeneratedNever();

            entity.HasOne(d => d.EntityNameNavigation).WithMany(p => p.UsysTaskData)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysTaskData_USysEntity");
        });

        modelBuilder.Entity<UsysTimeCostModel>(entity =>
        {
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.TimeCostModelDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysTimeCostModel','TimeCostModelDescription',[TimeCostModelGUID]))", false);
            entity.Property(e => e.TimeCostModelGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.UsysTimeCostModels).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<UsysTimeCostModelPerson>(entity =>
        {
            entity.Property(e => e.TimeCostModelPersonGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TimeCostModelCodeNavigation).WithMany(p => p.UsysTimeCostModelPeople).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<UsysTimeCostModelPersonDetail>(entity =>
        {
            entity.Property(e => e.TimeCostModelPersonDetailGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysUploadedFile>(entity =>
        {
            entity.Property(e => e.UploadedFileGuid).ValueGeneratedNever();
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<UsysUser>(entity =>
        {
            entity.HasKey(e => e.UserGuid).IsClustered(false);

            entity.ToTable("USysUser", tb =>
                {
                    tb.HasTrigger("WFS_USysUser_Insert_Update_PasswordExpiration_Fix");
                    tb.HasTrigger("WFS_USysUser_Insert_Update_PasswordResetExpirationDate_Fix");
                });

            entity.HasIndex(e => e.UserName, "AK_USysUser")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserGuid).ValueGeneratedNever();

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.UsysUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysUser_tLanguage");

            entity.HasOne(d => d.Person).WithMany(p => p.UsysUsers).HasConstraintName("FK_USysUser_tPerson");
        });

        modelBuilder.Entity<UsysUserAccessLog>(entity =>
        {
            entity.HasKey(e => e.UserAccessLogGuid).IsClustered(false);

            entity.HasIndex(e => e.AccessDateTime, "IX_USysUserAccessLog_AccessDateTime").IsClustered();

            entity.Property(e => e.UserAccessLogGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.AccessDateTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.User).WithMany(p => p.UsysUserAccessLogs)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_USysUserAccessLog_USysUser");
        });

        modelBuilder.Entity<UsysUserHomePageModule>(entity =>
        {
            entity.HasKey(e => e.UserHomePageModuleGuid).IsClustered(false);

            entity.HasIndex(e => e.UserGuid, "CIX_USysUserHomePageModule_UserGUID").IsClustered();

            entity.Property(e => e.UserHomePageModuleGuid).ValueGeneratedNever();

            entity.HasOne(d => d.Module).WithMany(p => p.UsysUserHomePageModules).HasConstraintName("FK_USysUserHomePageModule_USysModule");

            entity.HasOne(d => d.Portal).WithMany(p => p.UsysUserHomePageModules).HasConstraintName("FK_USysUserHomePageModule_USysPortal");

            entity.HasOne(d => d.User).WithMany(p => p.UsysUserHomePageModules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysUserHomePageModule_USysUser");
        });

        modelBuilder.Entity<UsysUserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserGuid, e.RoleGuid }, "AK_USysUserRole")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserRoleGuid).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Role).WithMany(p => p.UsysUserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysUserRole_USysRole");

            entity.HasOne(d => d.User).WithMany(p => p.UsysUserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysUserRole_USysUser");
        });

        modelBuilder.Entity<UsysUserSignatureAnswer>(entity =>
        {
            entity.HasKey(e => e.UserSignatureAnswerGuid).IsClustered(false);

            entity.HasIndex(e => new { e.UserGuid, e.SignatureQuestionCode }, "IX_USysUserSignatureAnswer").IsClustered();

            entity.Property(e => e.UserSignatureAnswerGuid).HasDefaultValueSql("(newid())");
            entity.Property(e => e.RowVersion).HasDefaultValueSql("((1))");
            entity.Property(e => e.SignatureAnswerDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.SignatureQuestionCodeNavigation).WithMany(p => p.UsysUserSignatureAnswers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USysUserSignatureAnswer_tSignatureQuestion");

            entity.HasOne(d => d.User).WithMany(p => p.UsysUserSignatureAnswers).HasConstraintName("FK_USysUserSignatureAnswer_USysUser");
        });

        modelBuilder.Entity<UsysVendorEmployeeIdentifier>(entity =>
        {
            entity.Property(e => e.VendorEmployeeIdentifierDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysVendorEmployeeIdentifier','VendorEmployeeIdentifierDescription',[VendorEmployeeIdentifierGUID]))", false);
        });

        modelBuilder.Entity<UsysVendorType>(entity =>
        {
            entity.Property(e => e.VendorTypeDescription).HasComputedColumnSql("([dbo].[shrfnTranslateColumn]('USysVendorType','VendorTypeDescription',[VendorTypeGUID]))", false);
        });

        modelBuilder.Entity<V834Hm>(entity =>
        {
            entity.ToView("v834_HM");
        });

        modelBuilder.Entity<V834HmDistinct>(entity =>
        {
            entity.ToView("v834_HM_Distinct");
        });

        modelBuilder.Entity<V834Ml>(entity =>
        {
            entity.ToView("v834_ML");
        });

        modelBuilder.Entity<V834MlDistinct>(entity =>
        {
            entity.ToView("v834_ML_Distinct");
        });

        modelBuilder.Entity<V834Standard>(entity =>
        {
            entity.ToView("v834_Standard");
        });

        modelBuilder.Entity<V834StandardDistinct>(entity =>
        {
            entity.ToView("v834_Standard_Distinct");
        });

        modelBuilder.Entity<V834Upmc>(entity =>
        {
            entity.ToView("v834_UPMC");
        });

        modelBuilder.Entity<V834UpmcDistinct>(entity =>
        {
            entity.ToView("v834_UPMC_Distinct");
        });

        modelBuilder.Entity<VAbsencePointsParameter>(entity =>
        {
            entity.ToView("vAbsencePointsParameters");
        });

        modelBuilder.Entity<VAcaparameter>(entity =>
        {
            entity.ToView("vACAParameters");
        });

        modelBuilder.Entity<VAlertParameter>(entity =>
        {
            entity.ToView("vAlertParameters");
        });

        modelBuilder.Entity<VApplicantParameter>(entity =>
        {
            entity.ToView("vApplicantParameters");
        });

        modelBuilder.Entity<VBenefitEnrollmentParameter>(entity =>
        {
            entity.ToView("vBenefitEnrollmentParameters");
        });

        modelBuilder.Entity<VBtwbcactiveSuperview>(entity =>
        {
            entity.ToView("vBTWBCActiveSuperview");
        });

        modelBuilder.Entity<VCobrareportParameter>(entity =>
        {
            entity.ToView("vCOBRAReportParameters");
        });

        modelBuilder.Entity<VCodeFilteringParameter>(entity =>
        {
            entity.ToView("vCodeFilteringParameters");
        });

        modelBuilder.Entity<VCurrencyParameter>(entity =>
        {
            entity.ToView("vCurrencyParameters");
        });

        modelBuilder.Entity<VDirectDepositParameter>(entity =>
        {
            entity.ToView("vDirectDepositParameters");
        });

        modelBuilder.Entity<VFieldMask>(entity =>
        {
            entity.ToView("vFieldMasks");
        });

        modelBuilder.Entity<VJobOpeningsParameter>(entity =>
        {
            entity.ToView("vJobOpeningsParameters");
        });

        modelBuilder.Entity<VLeaveParameter>(entity =>
        {
            entity.ToView("vLeaveParameters");
        });

        modelBuilder.Entity<VLnkAbsencePlansErp>(entity =>
        {
            entity.ToView("vLnkAbsencePlans_ERP");
        });

        modelBuilder.Entity<VLnkAddress>(entity =>
        {
            entity.ToView("vLnkAddress");
        });

        modelBuilder.Entity<VLnkBasePayHist>(entity =>
        {
            entity.ToView("vLnkBasePayHist");
        });

        modelBuilder.Entity<VLnkBroadbeanRequisition>(entity =>
        {
            entity.ToView("vLnkBroadbeanRequisition");
        });

        modelBuilder.Entity<VLnkCmsemployee>(entity =>
        {
            entity.ToView("vLnkCMSEmployee");
        });

        modelBuilder.Entity<VLnkCompanyTango>(entity =>
        {
            entity.ToView("vLnkCompany_Tango");
        });

        modelBuilder.Entity<VLnkDirectDeposit>(entity =>
        {
            entity.ToView("vLnkDirectDeposit");
        });

        modelBuilder.Entity<VLnkDirectDepositWithType>(entity =>
        {
            entity.ToView("vLnkDirectDeposit_WithType");
        });

        modelBuilder.Entity<VLnkE10payrollDeductionCode>(entity =>
        {
            entity.ToView("vLnkE10PayrollDeductionCodes");
        });

        modelBuilder.Entity<VLnkE9payrollDeductionCode>(entity =>
        {
            entity.ToView("vLnkE9PayrollDeductionCodes");
        });

        modelBuilder.Entity<VLnkJobHist>(entity =>
        {
            entity.ToView("vLnkJobHist");
        });

        modelBuilder.Entity<VLnkJobHistMax>(entity =>
        {
            entity.ToView("vLnkJobHist_Max");
        });

        modelBuilder.Entity<VLnkMobilePhone>(entity =>
        {
            entity.ToView("vLnkMobilePhone");
        });

        modelBuilder.Entity<VLnkNationalId>(entity =>
        {
            entity.ToView("vLnkNationalId");
        });

        modelBuilder.Entity<VLnkOtherPayAdpx>(entity =>
        {
            entity.ToView("vLnkOtherPay_ADPX");
        });

        modelBuilder.Entity<VLnkOtherPayDev>(entity =>
        {
            entity.ToView("vLnkOtherPay_Dev");
        });

        modelBuilder.Entity<VLnkPersonAbsenceHistErp>(entity =>
        {
            entity.ToView("vLnkPersonAbsenceHist_ERP");
        });

        modelBuilder.Entity<VLnkPersonBasePayHistDeduct>(entity =>
        {
            entity.ToView("vLnkPersonBasePayHist_Deduct");
        });

        modelBuilder.Entity<VLnkPersonBasePayHistE10prempRt>(entity =>
        {
            entity.ToView("vLnkPersonBasePayHist_E10PREmpRt");
        });

        modelBuilder.Entity<VLnkPersonBasePayHistMax>(entity =>
        {
            entity.ToView("vLnkPersonBasePayHist_Max");
        });

        modelBuilder.Entity<VLnkPersonBenefitEnrollmentOfferTango>(entity =>
        {
            entity.ToView("vLnkPersonBenefitEnrollmentOffer_Tango");
        });

        modelBuilder.Entity<VLnkPersonBenefitHistoryActiveHealthTango>(entity =>
        {
            entity.ToView("vLnkPersonBenefitHistoryActiveHealth_Tango");
        });

        modelBuilder.Entity<VLnkPersonBenefitHistoryWaiveHealthTango>(entity =>
        {
            entity.ToView("vLnkPersonBenefitHistoryWaiveHealth_Tango");
        });

        modelBuilder.Entity<VLnkPersonLocationHistMax>(entity =>
        {
            entity.ToView("vLnkPersonLocationHist_Max");
        });

        modelBuilder.Entity<VLnkPhone>(entity =>
        {
            entity.ToView("vLnkPhone");
        });

        modelBuilder.Entity<VLnkPreferredLanguage>(entity =>
        {
            entity.ToView("vLnkPreferredLanguage");
        });

        modelBuilder.Entity<VLnkRollupPlanAmount>(entity =>
        {
            entity.ToView("vLnkRollupPlanAmount");
        });

        modelBuilder.Entity<VLnkRollupPlanAmountDev>(entity =>
        {
            entity.ToView("vLnkRollupPlanAmount_Dev");
        });

        modelBuilder.Entity<VLnkTimeDetailAdp>(entity =>
        {
            entity.ToView("vLnkTimeDetail_ADP");
        });

        modelBuilder.Entity<VLoginParameter>(entity =>
        {
            entity.ToView("vLoginParameters");
        });

        modelBuilder.Entity<VNonZeroBenefitContributionHist>(entity =>
        {
            entity.ToView("vNonZeroBenefitContributionHist");
        });

        modelBuilder.Entity<VOlapparameter>(entity =>
        {
            entity.ToView("vOLAPParameters");
        });

        modelBuilder.Entity<VOpenEnrollmentParameter>(entity =>
        {
            entity.ToView("vOpenEnrollmentParameters");
        });

        modelBuilder.Entity<VOrgPublisherPerson>(entity =>
        {
            entity.ToView("vOrgPublisherPerson");
        });

        modelBuilder.Entity<VOrgPublisherPosition>(entity =>
        {
            entity.ToView("vOrgPublisherPosition");
        });

        modelBuilder.Entity<VOrgPublisherPositionWithIncumbent>(entity =>
        {
            entity.ToView("vOrgPublisherPositionWithIncumbents");
        });

        modelBuilder.Entity<VPerformanceReviewParameter>(entity =>
        {
            entity.ToView("vPerformanceReviewParameters");
        });

        modelBuilder.Entity<VPersonGoalParameter>(entity =>
        {
            entity.ToView("vPersonGoalParameters");
        });

        modelBuilder.Entity<VPersonParameter>(entity =>
        {
            entity.ToView("vPersonParameters");
        });

        modelBuilder.Entity<VRecruitingExpenseParameter>(entity =>
        {
            entity.ToView("vRecruitingExpenseParameters");
        });

        modelBuilder.Entity<VRegistrationParameter>(entity =>
        {
            entity.ToView("vRegistrationParameters");
        });

        modelBuilder.Entity<VReportingServicesParameter>(entity =>
        {
            entity.ToView("vReportingServicesParameters");
        });

        modelBuilder.Entity<VSystemImageParameter>(entity =>
        {
            entity.ToView("vSystemImageParameters");
        });

        modelBuilder.Entity<VSystemPerformanceParameter>(entity =>
        {
            entity.ToView("vSystemPerformanceParameters");
        });

        modelBuilder.Entity<VSystemPitreportingParameter>(entity =>
        {
            entity.ToView("vSystemPITReportingParameters");
        });

        modelBuilder.Entity<VTimesheetParameter>(entity =>
        {
            entity.ToView("vTimesheetParameters");
        });

        modelBuilder.Entity<VWesleyActiveSuperview>(entity =>
        {
            entity.ToView("vWesleyActiveSuperview");
        });

        modelBuilder.Entity<VWesleyActiveSuperviewFix>(entity =>
        {
            entity.ToView("vWesleyActiveSuperview_fix");
        });

        modelBuilder.Entity<VWesleyActiveSuperviewWithUsername>(entity =>
        {
            entity.ToView("vWesleyActiveSuperview_with_username");
        });

        modelBuilder.Entity<VWfsactiveSuperview>(entity =>
        {
            entity.ToView("vWFSActiveSuperview");
        });

        modelBuilder.Entity<VWfsopenRec>(entity =>
        {
            entity.ToView("vWFSOpenRec");
        });

        modelBuilder.Entity<VWfsopenRoute>(entity =>
        {
            entity.ToView("vWFSOpenRoutes");
        });

        modelBuilder.Entity<VlnkPersonBasePayHistWss>(entity =>
        {
            entity.ToView("vlnkPersonBasePayHist_WSS");
        });

        modelBuilder.Entity<VolapPersonAbsenceOccurrenceFactTable>(entity =>
        {
            entity.ToView("volapPersonAbsenceOccurrenceFactTable");
        });

        modelBuilder.Entity<VolapPersonAbsencePlanFactTable>(entity =>
        {
            entity.ToView("volapPersonAbsencePlanFactTable");
        });

        modelBuilder.Entity<VolapPersonApplicationFactTable>(entity =>
        {
            entity.ToView("volapPersonApplicationFactTable");
        });

        modelBuilder.Entity<VolapPersonBasePayFactTable>(entity =>
        {
            entity.ToView("volapPersonBasePayFactTable");
        });

        modelBuilder.Entity<VolapPersonBenefitFactTable>(entity =>
        {
            entity.ToView("volapPersonBenefitFactTable");
        });

        modelBuilder.Entity<VolapPersonCertificationFactTable>(entity =>
        {
            entity.ToView("volapPersonCertificationFactTable");
        });

        modelBuilder.Entity<VolapPersonCompetencyFactTable>(entity =>
        {
            entity.ToView("volapPersonCompetencyFactTable");
        });

        modelBuilder.Entity<VolapPersonEducationFactTable>(entity =>
        {
            entity.ToView("volapPersonEducationFactTable");
        });

        modelBuilder.Entity<VolapPersonFactTable>(entity =>
        {
            entity.ToView("volapPersonFactTable");
        });

        modelBuilder.Entity<VolapPersonIllnessInjuryFactTable>(entity =>
        {
            entity.ToView("volapPersonIllnessInjuryFactTable");
        });

        modelBuilder.Entity<VolapPersonOtherPayFactTable>(entity =>
        {
            entity.ToView("volapPersonOtherPayFactTable");
        });

        modelBuilder.Entity<VolapPersonPreviousEmploymentFactTable>(entity =>
        {
            entity.ToView("volapPersonPreviousEmploymentFactTable");
        });

        modelBuilder.Entity<VolapPersonPropertyCardFactTable>(entity =>
        {
            entity.ToView("volapPersonPropertyCardFactTable");
        });

        modelBuilder.Entity<VolapPersonPropertyFactTable>(entity =>
        {
            entity.ToView("volapPersonPropertyFactTable");
        });

        modelBuilder.Entity<VolapPersonTerminationFactTable>(entity =>
        {
            entity.ToView("volapPersonTerminationFactTable");
        });

        modelBuilder.Entity<VolapPersonTrainingExpenseFactTable>(entity =>
        {
            entity.ToView("volapPersonTrainingExpenseFactTable");
        });

        modelBuilder.Entity<VolapPersonTrainingFactTable>(entity =>
        {
            entity.ToView("volapPersonTrainingFactTable");
        });

        modelBuilder.Entity<VolapPropertyFactTable>(entity =>
        {
            entity.ToView("volapPropertyFactTable");
        });

        modelBuilder.Entity<VolapRecruitingExpenseFactTable>(entity =>
        {
            entity.ToView("volapRecruitingExpenseFactTable");
        });

        modelBuilder.Entity<VolapRequisitionFactTable>(entity =>
        {
            entity.ToView("volapRequisitionFactTable");
        });

        modelBuilder.Entity<VrptActiveBenefit>(entity =>
        {
            entity.ToView("vrptActiveBenefits");
        });

        modelBuilder.Entity<VrptActiveCalculation>(entity =>
        {
            entity.ToView("vrptActiveCalculations");
        });

        modelBuilder.Entity<VrptActiveSuperview>(entity =>
        {
            entity.ToView("vrptActiveSuperview");
        });

        modelBuilder.Entity<VrptAllApplicant>(entity =>
        {
            entity.ToView("vrptAllApplicants");
        });

        modelBuilder.Entity<VrptAllPerson>(entity =>
        {
            entity.ToView("vrptAllPersons");
        });

        modelBuilder.Entity<VrptAllPersonsAllPosition>(entity =>
        {
            entity.ToView("vrptAllPersonsAllPositions");
        });

        modelBuilder.Entity<VrptAllPersonsPreviou>(entity =>
        {
            entity.ToView("vrptAllPersonsPrevious");
        });

        modelBuilder.Entity<VrptArchiveAbsence>(entity =>
        {
            entity.ToView("vrptArchive_Absences");
        });

        modelBuilder.Entity<VrptArchiveApplication>(entity =>
        {
            entity.ToView("vrptArchive_Application");
        });

        modelBuilder.Entity<VrptArchiveTimeDetail>(entity =>
        {
            entity.ToView("vrptArchive_TimeDetail");
        });

        modelBuilder.Entity<VrptBaseCalculation>(entity =>
        {
            entity.ToView("vrptBaseCalculations");
        });

        modelBuilder.Entity<VrptBaseCalculationsConverted>(entity =>
        {
            entity.ToView("vrptBaseCalculationsConverted");
        });

        modelBuilder.Entity<VrptHistorySuperview>(entity =>
        {
            entity.ToView("vrptHistorySuperview");
        });

        modelBuilder.Entity<VrptPersonCalculation>(entity =>
        {
            entity.ToView("vrptPersonCalculations");
        });

        modelBuilder.Entity<VrptPersonFutureEnrollmentBeneficiary>(entity =>
        {
            entity.ToView("vrptPersonFutureEnrollmentBeneficiary");
        });

        modelBuilder.Entity<VrptPersonFutureoEnrolledDependent>(entity =>
        {
            entity.ToView("vrptPersonFutureoEnrolledDependents");
        });

        modelBuilder.Entity<VrptPitallPerson>(entity =>
        {
            entity.ToView("vrptPITAllPersons");
        });

        modelBuilder.Entity<VrptPitbenefit>(entity =>
        {
            entity.ToView("vrptPITBenefits");
        });

        modelBuilder.Entity<VrptPitcalculation>(entity =>
        {
            entity.ToView("vrptPITCalculations");
        });

        modelBuilder.Entity<VrptPitsuperview>(entity =>
        {
            entity.ToView("vrptPITSuperview");
        });

        modelBuilder.Entity<VrptgcPitallPerson>(entity =>
        {
            entity.ToView("vrptgcPITAllPersons");
        });

        modelBuilder.Entity<VrptgcPitbenefit>(entity =>
        {
            entity.ToView("vrptgcPITBenefits");
        });

        modelBuilder.Entity<VrptgcPitcalculation>(entity =>
        {
            entity.ToView("vrptgcPITCalculations");
        });

        modelBuilder.Entity<VrptgcPitsuperview>(entity =>
        {
            entity.ToView("vrptgcPITSuperview");
        });

        modelBuilder.Entity<WfsgcPitsuperview>(entity =>
        {
            entity.ToView("WFSgcPITSuperview");
        });

        modelBuilder.Entity<WfspendingTermRoute>(entity =>
        {
            entity.ToView("WFSPendingTermRoutes");
        });

        modelBuilder.Entity<Zschooldistrict>(entity =>
        {
            entity.HasKey(e => e.Sdid).HasName("PK_schooldistrict");

            entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public async Task<List<TimeSheetListing>> GetTimeSheetListingsAsync(string managerUsername)
    {
        List<TimeSheetListing> listings = new List<TimeSheetListing>();

        using (var command = Database.GetDbConnection().CreateCommand())
        {
            command.CommandText = "EXEC dbo.WFS_Manager_TimeSheetListing @ManagerUsername";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@ManagerUsername", managerUsername));

            Database.OpenConnection();

            using (var result = await command.ExecuteReaderAsync())
            {
                while (await result.ReadAsync())
                {
                    var listing = new TimeSheetListing
                    {
                        // Map properties from result to TimeSheetListing
                    };
                    listings.Add(listing);
                }
            }
        }

        return listings;
    }



}
