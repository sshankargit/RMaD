CREATE TABLE SHIPMENT (
shipment_id INTEGER PRIMARY key AUTOINCREMENT,
tracking_id INT NOT NULL,
sender_id INT NOT NULL, 
receiver_id INT NOT NULL,
shipped_on Text NOT NULL,
delivery_address_id INT NOT NULL,
expected_delivery_date Text NOT NULL,
shipping_company_id INT NOT NULL,
shipment_status_id INT NOT NULL,
delivered_int TEXT,
created_on Text NOT NULL,
updated_on TEXT
)