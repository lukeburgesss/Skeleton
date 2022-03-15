USE [p2533382]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblemployee_filterByemployeeID]
		@EmployeeID = 1

SELECT	@return_value as 'Return Value'

GO
