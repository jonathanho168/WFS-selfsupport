USE [EpicorHCMCMU2024]
GO
/****** Object:  StoredProcedure [dbo].[WFS_Manager_TimeSheetListing]    Script Date: 3/27/2024 6:32:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[WFS_Manager_UnapproveTimesheet] 
(
@TimeSheetGUID uniqueidentifier,
@ManagerUsername nvarchar(100)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	-- forthekids\ = 12

	UPDATE tPersonTimeGroupPeriod
	   SET SubmittedFlag = 0, ApprovedFlag = 0
	 WHERE PersonTimeGroupPeriodGUID = @TimeSheetGUID

END

