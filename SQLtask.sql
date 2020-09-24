CREATE TABLE products (
	Id BIGINT PRIMARY KEY,
	"name" TEXT
);

CREATE TABLE categories (
	Id BIGINT PRIMARY KEY,
	"name" TEXT
);

CREATE TABLE product_category_relation (
        productId BIGINT,
        FOREIGN KEY (productId) REFERENCES  products(Id),
        categoryId BIGINT,
        FOREIGN KEY (categoryId) REFERENCES  categories(Id)

);

INSERT INTO categories
VALUES
	    (1, 'Cheese'),
	    (2, 'PC'),
	    (3, 'Animals'),
        (4, 'Soft_Drinks');

INSERT INTO products
VALUES
	    (1, 'iMac 2016'),
	    (2, 'Brie'),
	    (3, 'Ham'),
        (4, 'Hamster'),
        (5, 'Cheese_water');


INSERT INTO product_category_relation
VALUES
        (1, 2),
        (2, 1),
        (3, null),
        (4, 3),
        (5, 1),
        (5, 4);



SELECT p.name AS product_name, c.name as category_name
FROM products AS p
LEFT JOIN product_category_relation as rel
 ON rel.productId = p.id
LEFT JOIN categories  as c
 ON c.Id = rel.categoryId;