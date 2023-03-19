# Task #2

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

По возможности — положите ответ рядом с кодом из первого вопроса.

## Solution

Для начала создадим таблицы `Products` и `Categories`,
а затем создадим таблицу `ProductCategory` для связывания двух таблиц, используя `FOREIGN KEY`:

```sql
Create TABLE Products(
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(255)
)

CREATE TABLE Categories(
    Id INT NOT NULL PRIMARY KEY,
    Name VARCHAR(255)
);

Create TABLE ProductCategory(
    ProductId INT NOT NULL,
    CategoryId INT NOT NULL,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(Id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);
```

Теперь добавим тестовых данных в таблицы и свяжем их:

```sql
INSERT INTO Products (Id, Name) 
VALUES (1, 'Product A'),
       (2, 'Product B'),
       (3, 'Product C'),
       (4, 'Product D');
       
INSERT INTO Categories (Id, Name)
VALUES (1, 'Category A'),
       (2, 'Category B'),
       (3, 'Category C'),
       (4, 'Category D');
       
INSERT INTO ProductCategory (ProductId, CategoryId)
VALUES
   (1, 1),
   (1, 2),
   (2, 2),
   (3, 1),
   (3, 3),
   (3, 4);
```

Для выбора всех пар «Имя продукта – Имя категории», из уже связанных таблиц, мы могли бы использовать оператор `JOIN`,
но т.к наша задача состоит в том, чтобы включить продукты, у которых нет категорий, мы будем использовать `LEFT JOIN`.

Пример SQL запроса:

```sql 
SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;
```

Результат:

![Результат запроса](https://cdn.discordapp.com/attachments/1041375335150788639/1086888810132021379/image.png)