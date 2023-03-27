select * from Customers

--Bu komut filtreleme komutudur where(koşul) getir ama lonroda yaşayanları getir
select * from Customers where City='London' 

--Case insensitivi komutlar için büyük küçük duyarsız
select * from products where categoryId=1 or CategoryId=3 --or yada demek 

select * from products where categoryId=1 and Unitprice>=10
--ahmet ve ya ayşegelsin yada sadece bir şart okey 
--ahmet ve ayşe gelsin ikiside gelsin demek 

--mesela bir elbise alırken filtirelemeler yapıyoruz

-- orderby sıralama bütün ürünleri seç ama ürünismine göre sırala dmeek 
select * from Products order by ProductName 

--Burada ilk categoriyId göre sırala 1-2-3 sonra Productname göre sıraladık
select * from Products order by CategoryID,ProductName

--asceding artan sıraya göre sıralamak demek 
select* from Products order by UnitPrice asc 

--descending azalana göre sırala
select * from Products order by UnitPrice desc 

select * from Products where CategoryID=1 order by UnitPrice desc 

--77 tüm satırları say demek yani kaç tane
--tek bir kolun tek bir satır gelmesi gerekir Buraya ProductName yazsan mantıksız olur 
select count(*) from Products --tüm datayı getirdi

select count(*) Adet from Products  where CategoryID=2

--Group By
--Hnagi kategoride kaç farklı ürünümüz var diye sorarsa
select * from Products group by CategoryID-- bu çalışmaz

---her bir grup için tablo yapabilirz
select CategoryID ,count(*)from Products group by CategoryID 

--ürün sayısı 10 dan az olan kategorileri listele derse 
--having kümülatif count lara uygularız
select CategoryID ,count(*)from Products group by CategoryID having count(*)<10 

select CategoryID ,count(*)from Products where UnitPrice>20 group by CategoryID having count(*)<10
--öncelikle her zaman where çalışır birim fiyatı 20 den fazla olan ürünleri sırala yani önce verimi filtrele
--sonra ctagoryıd göre grupla sonra onlardanda sayısı 10 dan az olanları

--INNERJOİN demek birleştirmek demek
--Inner join saedece iki tabloda da eşleşenleri bir araya getirir eşleşmeyen dataları getirmez
--form yerine sadece ürünler değil ürünler ve kategorileri birleştir ve getir
--Buradaki products sadcee ürün değil Categoriyi de getiriyor
--ne ye göre bir araya getircez on (şartında) demek eğeer eşitse getir demek
select  *
from products inner join Categories
on products.CategoryID=Categories.CategoryID

select products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from products inner join Categories
on products.CategoryID=Categories.CategoryID


select products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from products inner join Categories
on products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO DATA TRANSFORMATİON OBJECT --c# da join yapmak demek


-- [Order Details] TABLO BOŞLUKLU OLDUĞU İÇİN BÖYLE YAZILDI
--2155 değer geldi
select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID

--Hiç satış yapamadığımız ürünler nelerdir diye sorarsaa ozman left join 
--solda olup sağda olmayanarı getir ürünler tablosunda var ama hiç satışı yok ise 
--2155 çıktı bu da demekki Ben bütün ürünlerde satış yapmışım demektir
select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID

--830 kayıt geldi
select * from Customers c inner join Orders o
on c.CustomerID=O.CustomerID

--832 kayıt geldi
--Müşterilerde olup sipariş de olmayanları da getir.
select * from Customers c left join Orders o
on c.CustomerID=O.CustomerID

--sistemimize kayıt olmuş ama bizden ürün almamış kişileri getir aktif müşterim yapacağım derse
--solda olup sağda olmayan
--is null o data yok demek NULL şeklide yazar bu koşulu PK uygularız
select * from Customers c left join Orders o
on c.CustomerID=O.CustomerID
where o.CustomerID is null

--RİGHT JOİN SAĞDA OLUP SOLDA OLMAYANLARI GETİR
select * from Orders o left join Customers c 
on c.CustomerID=O.CustomerID
where o.CustomerID is null

select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join orders o
on o.OrderID=od.OrderID

