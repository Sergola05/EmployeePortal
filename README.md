# 🏢 Employee Portal

**Employee Portal** — веб-приложение для управления персоналом, разработанное на **ASP.NET Core MVC**.
Приложение позволяет администраторам добавлять, просматривать, редактировать и удалять сотрудников через удобный интерфейс.

---

## 🛠 Стек технологий

* **Backend:** ASP.NET Core 7.0 MVC
* **Frontend:** Razor Views, Bootstrap 5, Bootstrap Icons, CSS
* **База данных:** SQL Server / LocalDB (Entity Framework Core)
* **ORM:** Entity Framework Core
* **Язык:** C#
* **Среда разработки:** Visual Studio 2022+
* **Дополнительно:** jQuery, ASP.NET Tag Helpers

---

## 📁 Структура проекта

```text
EmployeePortal/
│
├─ Controllers/
│   ├─ EmployeeController.cs
│   └─ AccountController.cs
│
├─ Data/
│   └─ ApplicationDbContext.cs
│
├─ Models/
│   ├─ Department.cs
│   ├─ Designation.cs
│   ├─ Employee.cs
│   ├─ EmployeeType.cs
│   └─ ErrorViewModel.cs
│
├─ Services/
│   └─ EmployeeService.cs
│
├─ Views/
│   ├─ Employee/
│   │   ├─ List.cshtml
│   │   ├─ Create.cshtml
│   │   ├─ Success.cshtml
│   │   ├─ Details.cshtml
│   │   ├─ Update.cshtml
│   │   └─ Delete.cshtml
│   └─ Shared/
│       └─ _Layout.cshtml
│
├─ wwwroot/
│   ├─ css/
│   ├─ js/
│   └─ lib/ (Bootstrap, jQuery)
│
├─ appsettings.json
├─ Program.cs
└─ EmployeePortal.csproj
```
---

## ⚡ Функциональность

### 1️⃣ Employee List Page

* Просмотр всех сотрудников в таблице с данными: ФИО, Email, Должность, Отдел, Пол, Тип сотрудника
* Фильтрация по отделу, типу сотрудника и имени
* Пагинация
* Действия: просмотр деталей, редактирование, удаление

### 3️⃣ Employee Create Page

* Форма добавления нового сотрудника
* Обязательные поля: ФИО, Email, Должность, Отдел, Дата приема, Дата рождения, Тип, Пол, Зарплата
* Валидация данных
* Редирект на Success Page

### 4️⃣ Employee Success Page

* Подтверждение успешного создания сотрудника
* Отображение ключевых данных сотрудника
* Кнопки: создать ещё одного, вернуться к списку

### 5️⃣ Employee Details Page

* Полная информация о сотруднике
* Действия: возврат к списку, редактирование, удаление

### 6️⃣ Employee Update Page

* Форма редактирования данных сотрудника
* Поля предварительно заполнены текущими значениями
* Сохранение изменений или возврат к списку

### 7️⃣ Employee Delete Page

* Подтверждение удаления сотрудника
* Отображение ключевых данных
* Кнопки: подтвердить или отменить

---

## 🚀 Как запустить проект

### 1. Клонируйте репозиторий:

```bash
git clone https://github.com/yourusername/EmployeePortal.git
```

### 2. Откройте проект в Visual Studio 2022 и восстановите зависимости

### 3. Настройте строку подключения в `appsettings.json`:

```json
"ConnectionStrings": {
    "EmployeePortalDB": "Server=(localdb)\\mssqllocaldb;Database=EmployeePortalDB;Trusted_Connection=true;TrustServerCertificate=true;"
}
```

### 4. Примените миграции и создайте базу данных:

```bash
dotnet ef database update
```

### 5. Запустите проект:

```bash
dotnet run
```

### 6. Откройте браузер:

```
https://localhost:5001/
```

---

## 📸 Скриншоты

* 📷 Employee List Page
  <img width="1641" height="835" alt="image" src="https://github.com/user-attachments/assets/0b2bdc4e-0266-43e9-a15d-27d2bd5a3264" />

* 📷 Employee Create Page
 <img width="1220" height="786" alt="image" src="https://github.com/user-attachments/assets/e568c5e5-1830-43fa-8451-a49a45754b37" />

* 📷 Employee Success Page
 <img width="1159" height="719" alt="image" src="https://github.com/user-attachments/assets/c5cf5f8d-bb01-4894-b4a0-df723c0e22b0" />

* 📷 Employee Details Page
 <img width="1095" height="635" alt="image" src="https://github.com/user-attachments/assets/ac59b2e4-d011-484f-b5d2-74f2b1905ea0" />

* 📷 Employee Update Page
 <img width="1212" height="782" alt="image" src="https://github.com/user-attachments/assets/73651555-58e5-4177-868e-afa715c86edd" />

* 📷 Employee Delete Page
 <img width="1075" height="723" alt="image" src="https://github.com/user-attachments/assets/19545cfd-662f-4b6b-a524-dae0b4282f16" />
 
 * 📷 Employee DataBase
 <img width="266" height="269" alt="image" src="https://github.com/user-attachments/assets/ab286cd0-e181-42e2-a38e-1ea9873761e2" />




---




