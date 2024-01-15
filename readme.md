# Mô tả source code
## 1. [App01 - Khởi tạo dự án đầu tiên - Phép tính 2 số](https://github.com/Cuongyd196/lab-aspnet-mvc/tree/main/App01)

- Hình ảnh minh hoạ

![App01](./App01/Content/images/Pheptinh.png)

- Video hướng dẫn: 
https://youtu.be/PYuzzSVX0Ag


# Ghi chú khác
Đọc log WriteLine:

```System.Diagnostics.Debug.WriteLine("")```

# fix lỗi khi chạy project

Gặp lỗi 'Could not find file ... bin\roslyn\csc.exe' [duplicate]

As you already mention, the quick fix is to use the package manager, Tools > Nuget Package Manager > Package Manager Console, to run:

```
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r
```