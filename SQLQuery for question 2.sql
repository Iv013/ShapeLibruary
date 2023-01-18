--Создадим табицы с продуктами и категориями
create table Product(
	[Id] int not null identity(1,1) primary key,
	[Name] varchar(max) not null
)

create table Category(
	[Id] int not null identity(1,1) primary key,
	[Name] varchar(max) not null
)

--для связи многоие ко многим нужна отдельная (главная) таблица для связывания, я создал со внешними ключами.
create table ProductCategory(
[ProductId] int not null foreign key references Product(Id)  ,
	[CategoryId] int not null foreign key references Category(Id),
	primary key(ProductId, CategoryId)
)

--заполняем тестовыми данными
insert into Product (Name) values ('Prod 1'),( 'Prod 2'),( 'Prod 3'),( 'Prod 4') ,( 'Prod 5')
insert into Category(Name) values ('Cat 1'), ('Cat 2'),( 'Cat 3'),( 'Cat 4')
insert into ProductCategory(ProductId, CategoryId) values (1,1), (1,2), (2,2), (2,1), (1,3)



--делаем запрос с left join, чтобы отобразились тавары без категорий. 
-- Чтобы отобразить еще категории без товаров, нужно left заменить на right
select Product.Name, Category.Name from Product
left join ProductCategory on ProductId = Product.Id
left join Category on CategoryId = Category.Id
