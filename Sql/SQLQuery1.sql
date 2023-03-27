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