CREATE TABLE USER_SETTINGS (
user_settings_id INTEGER PRIMARY key AUTOINCREMENT,
user_id int NOT NULL,
email_package_loc_change NUMERIC,
show_past_shipments NUMERIC,
email_shipment_delays NUMERIC,
archive_past_shipments NUMERIC,
created_on Text NOT NULL,
updated_on TEXT
)