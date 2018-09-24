SELECT i.Name,i.CatalogNumber, SUM(l.Quantity) AS TotalQuantity, sls.Minimum
FROM dbo.Items i 
INNER JOIN Lots l ON i.Id = l.Item_Id 
INNER JOIN StockLevelSettings sls ON i.Id = sls.Item_Id
GROUP BY i.Name,sls.Minimum
HAVING SUM(l.Quantity) < sls.Minimum
ORDER BY TotalQuantity


