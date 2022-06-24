create table ShoppingListItems
(
    Id int IDENTITY(1,1) primary key clustered,
    Title nvarchar(100)
)

insert into ShoppingListItems
    (Title)
values
    ('Cacao Chips'),
	('Milk'),
    ('Eggs'),
    ('Stick of Butter')

select * from ShoppingListItems;