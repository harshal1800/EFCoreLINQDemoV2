# EF Core LINQ Demo

This project demonstrates how LINQ queries are automatically translated into SQL queries by Entity Framework Core and executed on SQL Server.
## 🚀 What This Project Shows

✔ How to connect .NET 8 Console App with SQL Server using EF Core  
✔ How LINQ query converts into SQL (LINQ-to-SQL translation)  
✔ Deferred Execution with `.ToList()`  
✔ SQL Logging using `LogTo(Console.WriteLine)`  
✔ Filtering and Sorting with `Where()` and `OrderBy()`  

---

## 🛠️ Tech Stack

| Technology            | Version   |
|-----------            |---------  |
| .NET                  | 8.0       |
| Entity Framework Core | 8.0       |
| SQL Server            | 2019/2022 |
| C#                    | Latest    |

---

## 📂 Database Structure

**Table: Products**
| Column| Type 
|-------|------
| Id    | INT, Primary Key 
| Name  | VARCHAR(100) 
| Price | DECIMAL(10,2) 

Sample Data:
- Laptop — ₹45,000
- Mouse — ₹500
- Keyboard — ₹1,200

---

## 🔄 How LINQ Works with EF Core (Execution Flow)

This project shows how a LINQ query in C# is converted into SQL by EF Core and executed on SQL Server.

### 1️⃣ Write LINQ Query in C#
```csharp
var products = context.Products
                      .Where(p => p.Price > 1000)
                      .OrderBy(p => p.Name)
                      .ToList();
````

### 2️⃣ Expression Tree is Created

EF Core captures the query as an **Expression Tree**.
(No database call yet ❌)

### 3️⃣ SQL Provider Translation

SQL Server provider converts LINQ → SQL:

```sql
SELECT [p].[Id], [p].[Name], [p].[Price]
FROM [Products] AS [p]
WHERE [p].[Price] > 1000
ORDER BY [p].[Name]
```

### 4️⃣ Deferred Execution

Query executes **only when ToList()** or similar method is called.
This is known as **Deferred Execution**.

### 5️⃣ SQL Execution on Database

SQL query runs in SQL Server and returns results.

### 6️⃣ Data Materialization

Rows are **mapped to C# Product objects**:

```
1 - Laptop - 45000.00
3 - Keyboard - 1200.00
```

### 7️⃣ Tracking by EF Core

EF Core tracks returned objects for change detection.

---

## 🧑‍💼 Final Summary 

> EF Core converts LINQ into Expression Trees, then the SQL Provider translates those into SQL and executes the query only when a terminal operator like ToList() is used. The results are mapped back into C# objects.

---

## 🎯 Learning Outcome

You will understand:

* LINQ to SQL translation workflow
* Role of SQL Provider in EF Core
* Deferred Execution concept
* Database result → C# Object mapping
* How to log SQL in console

---

## 📌 Author

**Harshal**
Learning .NET, EF Core & SQL 🔥


LINQ Query → Expression Tree → EF Core Provider → SQL Server → C# Objects


