CREATE TABLE USER_ADDRESS (
address_id INTEGER PRIMARY key AUTOINCREMENT,
address varchar(255) NOT NULL,
user_id int NOT NULL,
created_on Text NOT NULL,
updated_on TEXT
)