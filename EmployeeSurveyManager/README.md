# 👨‍💼 İdarəetmə Paneli – C# Konsol Tətbiqi  
# 👨‍💼 Management Panel – C# Console Application  

Bu layihə C# dilində yazılmış sadə bir **idarəetmə panelidir**. Layihə iki əsas bölmədən ibarətdir: **İşçilərin idarə olunması** və **anketlərin idarə olunması**. Tətbiq məlumatları .txt fayllarda saxlayır və idarə edir.
This project is a simple management panel written in C#. It consists of two main sections: employee management and survey management. The application stores and manages data using .txt files.

---

## 📁 Fayl Quruluşu / File Structure

- `iscidata.txt` – İşçi məlumatlarının saxlandığı fayl  
  `iscidata.txt` – Stores employee data

- `anketdata.txt` – Anket suallarının saxlandığı fayl  
  `anketdata.txt` – Stores survey questions

- `isimdata.txt` – Admin istifadəçi adı  
  `isimdata.txt` – Admin username

- `paroldata.txt` – Admin parolu  
  `paroldata.txt` – Admin password

- `hedata.txt`, `yoxdata.txt` – Anket cavablarının statistikası  
  `hedata.txt`, `yoxdata.txt` – Survey response statistics

---

## 🔐 Admin Girişi / Admin Login

- İlk dəfə açıldıqda yeni admin hesabı yaradılır.  
  When launched for the first time, it asks you to create an admin account.

- Giriş üçün 3 cəhd haqqı verilir.  
  You have 3 attempts to log in.

- İstifadəçi adı və şifrə `.txt` fayllarda saxlanılır.  
  Username and password are stored in `.txt` files.

---

## 👨‍💼 İşçilər Sistemi / Employee System

**Əsas funksiyalar / Main functionalities**:

- `İşçilərə bax / View Employees` – Mövcud işçiləri siyahılayır  
- `İşçi əlavə et / Add Employee` – Yeni işçi daxil edir  
- `İşçi sil / Delete Employee` – Verilən ID üzrə işçini silir

---

## 🧾 Anket Sistemi / Survey System

**Əsas funksiyalar / Main functionalities**:

- `Anketlərə bax / View Surveys` – Bütün sualları göstərir  
- `Anket əlavə et / Add Survey` – Yeni anket sualı daxil edir  
- `Anket sil / Delete Survey` – Mövcud anketi silir  
- `Anket göndər / Send Survey` – *(Hazır deyil / Not implemented yet)*  
- `Anket nəticə / Survey Results` – "Hə" və "Yox" cavablarının faizini göstərir

---

## 🧠 Gələcək Planlar / Future Plans

- Anketləri istifadəçilərə SMS və ya email vasitəsilə göndərmək  
  Send surveys via SMS or email

- Anket cavablarını fərdi istifadəçilərlə əlaqələndirmək  
  Link responses to specific users

- SQLite və ya Firebase dəstəyi əlavə etmək  
  Add SQLite or Firebase support

- Statistik analiz və vizual qrafiklər  
  Visual graphs and advanced statistics

---

## ✅ Quraşdırma / Setup

1. Layihəni klonlayın və `.cs` faylını Visual Studio ilə açın  
   Clone the project and open the `.cs` file in Visual Studio

2. `Program.cs` faylını işə salın  
   Run the `Program.cs` file

3. Əgər admin məlumatları boşdursa, sistem yeni hesab yaratmağınızı istəyəcək  
   If admin data is empty, the system will ask you to create one

4. Menyudan funksiyanı seçin  
   Choose functionality from the menu

---

## 👨‍💻 Müəllif / Author

- **Ad / Name**: Ali Süleymanlı  
- **Dil / Language**: C# (.NET 9)  
- **Layihə Tipi / Project Type**: Konsol Tətbiqi / Console App

---

## 📜 Lisenziya / License

Bu proqram tədris və şəxsi istifadə üçündür. Kommersiya məqsədli istifadə üçün müəlliflə əlaqə saxlayın.  
This application is for educational and personal use. Contact the author for commercial use.

---
