# EstateFlow System SRS and Design Document

## Problem Statement
Small real estate offices need a simple desktop system to manage properties, clients, agents, and sales without using spreadsheets.

## Objectives
- Store property records
- Store client records
- Store agent records
- Record property sales
- Search records quickly
- Generate simple reports

## User Roles
- Admin: full access to all modules

## Database Design
Main tables:
- users
- properties
- clients
- agents
- sales

Sales table links properties, clients, and agents through foreign keys.

## Architecture
UI Layer: Windows Forms
Data Access Layer: Repository and DbConnection classes
Model Layer: Property, Client, Agent, Sale classes
Database Layer: MySQL
