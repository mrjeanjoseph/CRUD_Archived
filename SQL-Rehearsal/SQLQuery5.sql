--Selecting with Condition

SELECT *
FROM sales.customers
WHERE phone IS NOT NULL;

--Selecting with CASE

SELECT CASE WHEN city LIKE '%AL' THEN 'Happened!' ELSE 'Nothing yet' END
FROM sales.customers

SELECT COUNT(d.discount)
FROM sales.order_items d

SELECT 
	s.first_name + s.last_name AS [Full Name],
	s.email, s.phone
FROM 
	sales.orders o
JOIN 
	sales.staffs s ON o.store_id = s.store_id


SELECT * FROM sales.order_items WITH (nolock)
SELECT * FROM sales.stores

SELECT COUNT(list_price)
FROM sales.order_items
GROUP BY order_id


