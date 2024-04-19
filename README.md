Создание таблиц:

	CREATE TABLE Products (
	    id SERIAL PRIMARY KEY,
	    name VARCHAR(50) NOT NULL
	);
	
	CREATE TABLE Categories (
	    id SERIAL PRIMARY KEY,
	    name VARCHAR(50) NOT NULL
	);
	
	CREATE TABLE Product_Categories (
	    product_id INTEGER REFERENCES Products(id),
	    category_id INTEGER REFERENCES Categories(id),
	    PRIMARY KEY (product_id, category_id)
	);

Заполнение таблиц:

	INSERT INTO Products (name) VALUES ('Монитор');
	INSERT INTO Products (name) VALUES ('Клавиатура');
	INSERT INTO Products (name) VALUES ('Мышь');
	INSERT INTO Products (name) VALUES ('Видеокарта');
	INSERT INTO Products (name) VALUES ('Процессор');
	INSERT INTO Categories (name) VALUES ('Периферия');
	INSERT INTO Categories (name) VALUES ('Косплектующие');
	INSERT INTO Product_Categories (product_id, category_id) VALUES (1, 1);
	INSERT INTO Product_Categories (product_id, category_id) VALUES (2, 1);
	INSERT INTO Product_Categories (product_id, category_id) VALUES (3, 1);
	INSERT INTO Product_Categories (product_id, category_id) VALUES (4, 2);
	INSERT INTO Product_Categories (product_id, category_id) VALUES (5, 2);

Выборка:

	SELECT P.name AS "Product Name", C.name AS "Category Name"
	FROM Products P
	LEFT JOIN Product_Categories PC ON P.id = PC.product_id
	LEFT JOIN Categories C ON PC.category_id = C.id;
