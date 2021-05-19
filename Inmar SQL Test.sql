Customer:
		a. CustomerId (primary key, int, not null)
		b. Name (varchar(50))
2. Product:
		a. ProductId (primary key, int, not null)
		b. Name (varchar(100))
		c. Price (decimal(12, 2))
3. Order
		a. OrderId (primary key, int, not null)
		b. CustomerId (foreign key, int, not null)
		c. CreatedAt (datetime, not null)
4. OrderProduct
		a. OrderProductId (primary key, int, not null)
		b. OrderId (foreign key, int, not null)
		c. ProductId (foreign key, int, not null)


  all the customers whose name begins with "Joe"

  select * from Customer where Name like 'Joe%'

? all the product names ordered by customer "Joe" after '11/1/2016'

  select p.Name from Customer c
  Join Order o on c.CustomerId==o.CustomerId
  Join Product p 
  Join OrderProduct op on op.OrderId==o.OrderId and op.ProductId==p.ProductId
  where c.Name='Joe' and o.CreatedAt > '11/1/2016'

? the total amount spend by customer "Joe"

  select sum(p.Price) from Customer c
  Join Order o on c.CustomerId=o.CustomerId
  Join Product p 
  Join OrderProduct op on op.OrderId==o.OrderId and op.ProductId==p.ProductId
  where c.Name='Joe'
  

? all the customer names and count of their orders for orders containing more than one
  product

  select c.Name, count(*) from Customer c
  Join Order o on c.CustomerId=o.CustomerId
  Join Product p 
  Join OrderProduct op on op.OrderId==o.OrderId and op.ProductId==p.ProductId
  having count(p.ProductId)>1
  
