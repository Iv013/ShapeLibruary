--�������� ������ � ���������� � �����������
create table Product(
	[Id] int not null identity(1,1) primary key,
	[Name] varchar(max) not null
)

create table Category(
	[Id] int not null identity(1,1) primary key,
	[Name] varchar(max) not null
)

--��� ����� ������� �� ������ ����� ��������� (�������) ������� ��� ����������, � ������ �� �������� �������.
create table ProductCategory(
[ProductId] int not null foreign key references Product(Id)  ,
	[CategoryId] int not null foreign key references Category(Id),
	primary key(ProductId, CategoryId)
)

--��������� ��������� �������
insert into Product (Name) values ('Prod 1'),( 'Prod 2'),( 'Prod 3'),( 'Prod 4') ,( 'Prod 5')
insert into Category(Name) values ('Cat 1'), ('Cat 2'),( 'Cat 3'),( 'Cat 4')
insert into ProductCategory(ProductId, CategoryId) values (1,1), (1,2), (2,2), (2,1), (1,3)



--������ ������ � left join, ����� ������������ ������ ��� ���������. 
-- ����� ���������� ��� ��������� ��� �������, ����� left �������� �� right
select Product.Name, Category.Name from Product
left join ProductCategory on ProductId = Product.Id
left join Category on CategoryId = Category.Id
