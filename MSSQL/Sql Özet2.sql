create table AlterTablo(
ID int primary key identity(1,1),
A nvarchar(4),
B nvarchar(15),
C nvarchar(20),
)

select * from AlterTablo

-- ALTER : Mevcut tablonun içinde değişiklik yapmaya yarar

alter table AlterTablo add D nvarchar(10)  --Tabloya yeni sütun ekler

ALTER TABLE AlterTablo Alter column A nvarchar(10) --Tablodaki veri tipini günceller

ALTER TABLE AlterTablo DROP COLUMN D --Tablodaki sütunu siler

insert into AlterTablo (A,B,C) values ('veysel','ilos','kus')

/* CASE-WHEN-THEN-END   TEMEL YAPI
CASE
    WHEN şart1 THEN sonuç1
    WHEN şart2 THEN sonuç2
    .
    .
    .
    ELSE sonuç3
END
*/

select
A,B,C,
case
 when C='kus' then 'aa'
 when C='kus2' then 'bb' 
 else 'cc'
 end
 as selambebek
from AlterTablo 

-- COALESCE : Bu fonksiyon, parametre olarak verilen listedeki ilk NULL olmayan (dolu) değeri döndürür. Eğer tüm değerler NULL ise sonuç NULL olur.
select Coalesce(D,A,B,C) as ilkdeger from AlterTablo

-- CAST & CONVERT Her iki fonksiyonda bir veri tipini başka bir veri tipine dönüştürmek için kullanılır (örneğin; yazıyı sayıya veya tarihi yazıya çevirmek).

-- CAST(ifade AS yeni_veri_tipi) , genelde sayısal dönüşümlere uygun
SELECT CAST(25.99 AS int)+4 donustur

--CONVERT(yeni_veri_tipi, ifade, [stil]) ,stil: tarihin nasıl yazılacağını belirleyen kod AA-GG-YYYY gibi ,genelde tarih ve para için uygun
SELECT CONVERT(VARCHAR, GETDATE(), 103) as tarih
SELECT CONVERT(VARCHAR, CAST(1250.50 AS MONEY), 1) as para

--CONSTRAINT : oluşturulan tabloya sonradan kurallar(örneğin primary key,unique) eklemek için kullanılır

-- CHECK : koşul oluşturur , koşula uymayan veriyi eklemeyi önler
create table checkTablo(
A int constraint chk_sutunA check(A>20),
)
--Tablo oluşturuken bu kuralı eklemezsek şu şekilde de sonradan eklenebilir: alter table checkTablo add constraint chk_sutunA check(A>20)

select * from checkTablo
insert into checkTablo(A) values (21)

-- UNIQUE : aynı verinin eklenmesini önler , yani 1 veri 1 kere eklenir benzersizlik sağlar (örneğin 2 defa 4 olamaz)
ALTER TABLE checkTablo ADD CONSTRAINT UQ_SutunA unique (A) -- UQ_SutunA : kurala verilen isimdir

--ALTER TABLE TabloAdi DROP CONSTRAINT KuralAdi : kuralı kaldırmak için kullanılır
ALTER TABLE checkTablo DROP CONSTRAINT UQ_SutunA

--Örnek
alter table checkTablo add C int constraint chc_sutunC check(C>10) constraint UQ_sutunC unique(C)
alter table checkTablo drop constraint UQ_sutunC ,chc_sutunC