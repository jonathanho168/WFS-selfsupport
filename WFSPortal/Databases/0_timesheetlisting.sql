USE [EpicorHCMCMU2024]
GO
/****** Object:  StoredProcedure [dbo].[WFS_Manager_TimeSheetListing]    Script Date: 3/27/2024 4:18:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[WFS_Manager_TimeSheetListing] 
(
@ManagerUsername nvarchar(100)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	-- forthekids\ = 12

	SELECT PTGP.PersonTimeGroupPeriodGUID,
		   p.FullName,
		   p.EmployeeID,
		   ptgp.PositionCode,
		   ptgp.RoutingInstanceGUID,
		   tgp.TimeGroupPeriodStartDate,
		   tgp.TimeGroupPeriodEndDate,
		   was.SupervisorFullName,
		   was.SupervisorPersonGUID,
		   man.UserName as SupervisorUsername
	  FROM tPersonTimeGroupPeriod ptgp with (nolock)
	  JOIN tTimeGroupPeriod tgp with (nolock) on ptgp.TimeGroupPeriodGUID = tgp.TimeGroupPeriodGUID
	  JOIN tperson p with (nolock) on ptgp.PersonGUID = p.PersonGUID
	  JOIN vWesleyActiveSuperview was with (nolock) on ptgp.PersonGUID = was.PersonGUID and ptgp.PositionCode = was.PositionCode
	  JOIN USysUser man with (nolock) on was.SupervisorPersonGUID = man.PersonGUID
	 WHERE ptgp.SubmittedFlag = 1 and ptgp.ApprovedFlag = 1
	   AND tgp.ClosedFlag = 0
	   AND man.username = @ManagerUsername


END

