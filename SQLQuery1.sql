USE [p2533382]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrders_SelecrAll]

SELECT	@return_value as 'Return Value'

GO
