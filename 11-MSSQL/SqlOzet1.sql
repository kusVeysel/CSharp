use Northwind --Notrhwind veri tabanını seçer
-- select from arası seçilecek tablo sütunları temsil eder , *: tüm sütunlar
select * from Employees where EmployeeID=1 -- where: filtreleme yapar (if görevi görür)

select * from Employees where FirstName like '%b%' -- like: içeren karakterleri getirir
-- %% başı ve sonundaki karakterler önemli değil 

select * from Employees where FirstName not like '%b%' -- not like: karakteri içermeyenleri getirir

select * from Employees	where FirstName like '_a%' -- _: bir karakter atlar (2. 3. ya da başka bir sıradan şu harfle başlasın için kullanılabilir)

select * from Employees where EmployeeID between '2' and '5' -- sadece arasındakileri getirir

select * from Employees where EmployeeID not between '2' and '5' -- sadece arasındakileri getirmez

select * from Products

select emp.EmployeeID,pro.CategoryID,pro2.SupplierID from Employees emp
join Products pro on emp.EmployeeID = pro.CategoryID
join Products pro2 on emp.EmployeeID = pro2.SupplierID
-- join: 2 ya da daha fazla tabloyu birleştirip tek tablo yapmak için kullanılır

select * from Products where SupplierID in(1,2,3) order by SupplierID asc -- in: and ile aynı görevi görür ama çok fazla veri olması durumunda in kullanılır

select * from Shippers
insert Shippers (CompanyName,Phone) values ('Selamünaleyküm','000000') -- insert: tabloya ekleme işlemi yapar

update Shippers set Phone+=1 where Phone='000000' -- update: tabloda ilgili satırı günceller

select * from Employees order by FirstName asc -- asc: küçükten büyüğe sıralar
select * from Employees order by FirstName desc -- desc: büyükten küçüğe sıralar 
-- order by: Tabloyu Sıralar

select FirstName,COUNT(*) as salamgardas from Employees group by FirstName -- group by: guplama yapar
--Count(*): satıları sayar , içindeki * da aynı mantık /tüm satırları sayar

Create table TABLO(
ID int primary key identity(1,1), -- eşsiz ve otomatik bir bir artar olarak seçilir
A nvarchar(15),
B Nvarchar(15),
C nvarChar(15),
D nvarchar(15)
)
-- Tablo oluşturur

Create table TABLO2(
ID int primary key identity(1,1), -- eşsiz ve otomatik bir bir artar olarak seçilir
A nvarchar(15),
B Nvarchar(15),
C nvarChar(15),
D nvarchar(15)
)
-- Tablo oluşturur

drop table TABLO2 -- Şebnem FERAH - HOŞÇAKAL

select * from TABLO
insert TABLO (A,B,C,D) Values('vaz','geçtim','dün','yadan')
 
delete from TABLO -- tüm tablo verilerini siler (filtreleme yapılırsa yapılan satırı siler)

truncate table TABLO -- tüm tablo verilerini siler (filtreleme yapılmaz ama sonrasında insert yapılırsa ID kaldığı yerden değil 1'den başlar)

select distinct FirstName,LastName from Employees -- distinct: tekrar eden verileri tekilleştirir

select top 50 percent CategoryName from Categories --  satırların %50'sini getirir

select top 10 CategoryName from Categories -- ilk 10 satırı getirir

select CategoryID from Categories order by CategoryID offset 5 row fetch next 7 row only -- 5'ten sonra ilk 7 satırı getirir ,order by kullanımı zorunlu

select top 6  with ties CategoryName from Categories order by CategoryName --ilk 6 satırı getirir ve son satır ile aynı veriye sahip satırları da getirir | order by kullanımı zorunlu

select CategoryName,count(CategoryName) as adet from Categories group by CategoryName having CategoryName like '%c%' 
select CategoryName,count(CategoryName) as adet from Categories where CategoryName like '%c%'  group by CategoryName 
-- Aralarında pek fark gözükmez ama kritik farklar vardır , kısaca eğer gruplama varsa having kullanılmalı


create table deneme(
a nvarchar(20) ,
b nvarchar (20),
c nvarchar (20),
d nvarchar (20),
)
insert deneme (a,b,c,d) values ('aa','aa','aa','cc')
select * from deneme

select a from deneme union 
select d from deneme
-- union: tekilleştirir ve alt alta ekler

select a from deneme union all
select d from TABLO 
-- union all: tekilleştirme yapmadan alt alta direk getirir

--select Sinif,Sube,Cinsiyet,Count(case when cinsiyet='K' then 1 end) as kari,Count(case when cinsiyet='E' then 1 end) as adam from OkulTablo group by Sinif,Sube 

-- Ünvanı Mr. olan veya yaşı 60'dan büyük olan çalışanları listeleyen kod
select * from Employees where TitleOfCourtesy ='Mr.' or YEAR(GETDATE())- YEAR(BirthDate)>60
-- GETDATE() bu zamanki tarihi  getirir