CREATE TABLE EMAILS (
email_id INTEGER PRIMARY key AUTOINCREMENT,
user_id INT  NOT NULL,
package_tracking_id INT NOT NULL,
email_subject varchar(255) NOT NULL,
email_body TEXT NOT NULL,
email_sent_on TEXT NOT NULL,
email_attachment TEXT,
email_status varchar(25) NOT NULL
)