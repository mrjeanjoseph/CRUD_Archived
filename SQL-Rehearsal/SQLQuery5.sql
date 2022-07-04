--Selecting with Condition

SELECT *
FROM sales.customers
WHERE phone IS NOT NULL;

SELECT COUNT(DISTINCT sc.state)
FROM sales.customers sc

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

SELECT SUM(list_price)
FROM sales.order_items

SELECT COUNT(list_price)
FROM sales.order_items

SELECT *
FROM sales.customers
WHERE first_name IN ('Debra', 'Kasha')

SELECT state
FROM sales.customers
GROUP BY state

SELECT p.brand_id, p.product_name
FROM production.products as p

SELECT p.product_name, COUNT(*) AS [Item Count]
FROM production.products as p
GROUP BY p.product_name

SELECT s.store_id, AVG(s.quantity)
FROM production.stocks s
GROUP BY s.store_id

SELECT s.store_id, AVG(s.quantity)
FROM production.stocks s
WHERE s.store_id != 1
GROUP BY s.store_id

SELECT s.store_id, AVG(s.quantity)
FROM production.stocks s
WHERE s.store_id != 1
GROUP BY s.store_id
HAVING AVG(s.quantity) > 13

SELECT *
--FROM production.products
FROM production.stocks s