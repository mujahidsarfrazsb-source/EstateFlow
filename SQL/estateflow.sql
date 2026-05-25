CREATE DATABASE IF NOT EXISTS estateflow_db;
USE estateflow_db;

CREATE TABLE IF NOT EXISTS users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,
    role VARCHAR(30) NOT NULL DEFAULT 'Admin',
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS properties (
    property_id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(150) NOT NULL,
    property_type VARCHAR(80) NOT NULL,
    address VARCHAR(255) NOT NULL,
    price DECIMAL(12,2) NOT NULL DEFAULT 0,
    status VARCHAR(30) NOT NULL DEFAULT 'Available',
    is_deleted TINYINT(1) NOT NULL DEFAULT 0,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS clients (
    client_id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(120) NOT NULL,
    phone VARCHAR(30),
    email VARCHAR(120),
    client_type VARCHAR(40) NOT NULL DEFAULT 'Buyer',
    is_deleted TINYINT(1) NOT NULL DEFAULT 0,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS agents (
    agent_id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(120) NOT NULL,
    phone VARCHAR(30),
    email VARCHAR(120),
    commission_rate DECIMAL(5,2) NOT NULL DEFAULT 0,
    is_deleted TINYINT(1) NOT NULL DEFAULT 0,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS sales (
    sale_id INT AUTO_INCREMENT PRIMARY KEY,
    property_id INT NOT NULL,
    client_id INT NOT NULL,
    agent_id INT NOT NULL,
    sale_amount DECIMAL(12,2) NOT NULL,
    sale_date DATE NOT NULL,
    is_deleted TINYINT(1) NOT NULL DEFAULT 0,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_sales_property FOREIGN KEY (property_id) REFERENCES properties(property_id),
    CONSTRAINT fk_sales_client FOREIGN KEY (client_id) REFERENCES clients(client_id),
    CONSTRAINT fk_sales_agent FOREIGN KEY (agent_id) REFERENCES agents(agent_id)
);

INSERT INTO users(username,password,role) VALUES('admin','admin123','Admin')
ON DUPLICATE KEY UPDATE username=username;
INSERT INTO properties(title, property_type, address, price, status) VALUES
('Canal Road House', 'House', 'Canal Road, Faisalabad', 25000000, 'Available'),
('City Center Shop', 'Commercial', 'D Ground, Faisalabad', 12000000, 'Available');
INSERT INTO clients(full_name, phone, email, client_type) VALUES
('Ali Khan', '03001234567', 'ali@example.com', 'Buyer'),
('Sara Ahmed', '03007654321', 'sara@example.com', 'Seller');
INSERT INTO agents(full_name, phone, email, commission_rate) VALUES
('Usman Realtor', '03005551234', 'usman@example.com', 2.50);
