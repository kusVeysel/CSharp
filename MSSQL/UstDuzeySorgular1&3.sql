select * from Employees
select * from Orders
select * from [Order Details]

--1.Örnek
select emp.FirstName,emp.LastName,count(*) as siparis from Employees emp
inner join Orders ord on emp.EmployeeID=ord.EmployeeID 
where OrderDate between '1997-01-01' and '1997-12-31'
group by emp.FirstName,emp.LastName having count(emp.EmployeeID)>50

--2.Örnek
select 
	emp.FirstName,
	emp.LastName,
	convert(varchar,cast(sum(UnitPrice * Quantity) as money),1)as para 
from Employees emp join Orders ord on emp.EmployeeID=ord.EmployeeID 
join [Order Details] odeta on odeta.OrderID = ord.OrderID 
where OrderDate between '1997-01-01' and '1997-12-31' group by emp.FirstName,emp.LastName having sum(UnitPrice * Quantity)>15000

--3.Örnek
select 
	emp.FirstName +' '+emp.LastName as IsimSoyisim,
	count(emp.EmployeeID) as toplamsiparis,
	convert(varchar,cast(sum(Quantity * UnitPrice) AS money),1) as ciro,
case 
	when sum(Quantity * UnitPrice) < 10000 then 'gelişmeli'
	when sum(Quantity * UnitPrice) >= 10000 and sum(Quantity * UnitPrice) < 20000 then 'normal' 
	else 'Süperstar' 
end 
	as performans
from Employees emp 
join Orders ord on emp.EmployeeID=ord.EmployeeID 
join [Order Details] odeta on odeta.OrderID = ord.OrderID 
where OrderDate between '1997-01-01' and '1997-12-31' group by emp.FirstName,emp.LastName having count(emp.EmployeeID)>20 order by sum(UnitPrice * Quantity) desc


