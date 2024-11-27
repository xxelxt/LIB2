## Phần mềm quản lý thư viện Học viện Ngân hàng

<details>
<summary>Thông tin chung</summary>

## Nhóm 11

- 📋 **Học phần**: Quản lý dự án công nghệ thông tin

- 💻 **Lớp học phần**: 241IS60A02

### ✊ Danh sách thành viên

| Họ và tên           | Mã sinh viên | 🔗 Link to GitHub profile                   |
| ------------------- | ------------ | -----------------------------------------   |
| Phạm Ngọc Nghiệp 🌟 | 24A4042603   | [xxelxt](https://github.com/xxelxt)         |
|     |    |    |
|     |    |    |
|     |    |    |
|     |    |    |

</details>

### 📘 Giới thiệu

### 🚀 Tiện ích sử dụng

- MaterialSkin2: Giao diện Material Design của Google cho .NET WinForm

## Tạo file kết nối với database

### 1. Tạo file cấu hình App.config

Click chuột phải vào tên ứng dụng trong Visual Studio (không phải Solution) -> Add -> New Item -> Application Configuration File

```
└📁 LIB2
  └📁 LIB2
    └📁 Class
    └📁 Forms
    └📁 Resources
    └📄 App.config
    ...
```

### 2. Sửa đổi file App.config

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <connectionStrings>
    <add name="LIBconnection" connectionString="" />
  </connectionStrings>
</configuration>
```

Với connectionString lấy từ Connection String kết nối vào database của bạn trong SQL Server.
