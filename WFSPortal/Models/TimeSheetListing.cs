public class TimeSheetListing
{
    public Guid PersonTimeGroupPeriodGUID { get; set; }
    public string FullName { get; set; }
    public string EmployeeID { get; set; }
    public string PositionCode { get; set; }
    public Guid RoutingInstanceGUID { get; set; }
    public DateTime TimeGroupPeriodStartDate { get; set; }
    public DateTime TimeGroupPeriodEndDate { get; set; }
    public string SupervisorFullName { get; set; }
    public Guid SupervisorPersonGUID { get; set; }
    public string SupervisorUsername { get; set; }
}

