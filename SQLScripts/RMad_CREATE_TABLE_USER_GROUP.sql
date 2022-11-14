CREATE TABLE USER_GROUP (
user_group_id INTEGER PRIMARY key AUTOINCREMENT,
user_group_name varchar(50) NOT NULL,
user_group_role_id int NOT NULL,
created_on Text NOT NULL,
updated_on TEXT
)