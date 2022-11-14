CREATE TABLE USERS (
user_id INTEGER PRIMARY key AUTOINCREMENT,
user_name varchar(50) NOT NULL,
password TEXT NOT NULL,
first_name varchar(50) NOT NULL,
last_name varchar(50) NOT NULL,
email_address varchar(100) NOT NULL,
last_logged_in TEXT,
failed_logins INT,
last_pwd_update_on TEXT NOT NULL,
user_group_id int NOT NULL,
created_on Text NOT NULL,
updated_on TEXT NOT NULL
)