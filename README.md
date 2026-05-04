# Contact Book App (ContactBook_DS_)

A console-based Contact Book application written in **C#**, designed to manage contacts efficiently using lists and custom data manipulation features like sorting, searching, pagination, and deduplication.

---

## Overview

This application provides an interactive command-line interface that allows users to:

- Manage a list of contacts
- Navigate through contacts using pagination
- Search, sort, update, and delete entries
- Merge duplicate contacts

## Features

### Contact Management
- Create new contacts
- Review detailed contact information
- Update existing contacts
- Delete contacts

### Search & Organization
- Find contacts by keyword (name, phone, or email)
- Sort contacts by:
  - First Name
  - Last Name
  - Phone
  - Email

### Pagination System
- Navigate through contacts easily:
  - `+` → Next page
  - `-` → Previous page
  - `G` → Go to specific page
  - `S` → Change page size

### Deduplication
- Detect duplicate contacts
- Merge selected fields from duplicates into one contact
- Apply or discard merge results

### Input Validation
- Ensures valid commands and numeric inputs
- Confirmation prompts for critical operations

---

## Commands

| Command | Action |
|--------|--------|
| `+` | Next page |
| `-` | Previous page |
| `G` | Go to page |
| `S` | Change page size |
| `C` | Create contact |
| `R` | Review contact |
| `U` | Update contact |
| `D` | Delete contact |
| `F` | Find contacts |
| `O` | Order contacts |
| `M` | Deduplicate contacts |
| `X` | Exit |

---

## Core Components

### `ContactBook`
Main class that:
- Handles user interaction
- Displays contacts in a formatted table
- Processes commands
- Manages pagination and filtering

### Dependencies
This class relies on:
- `Contact` (data model)
- `ContactComparer` (sorting logic)
- `ContactMerger` (duplicate detection & merging)

---

## How It Works

- Contacts are stored in two lists:
  - `allContacts` → full dataset
  - `filteredContacts` → current view (after search/filter)

- Pagination is handled using:
  - Current page (`page`)
  - Page size (`size`)

- The UI continuously loops until the user confirms exit.

---

## Running the Application

### Prerequisites
- .NET SDK installed

### Steps
```bash
git clone https://github.com/KevenPaulinoFerrer/ContactBook_DS_.git
cd ContactBook_DS_
dotnet run
