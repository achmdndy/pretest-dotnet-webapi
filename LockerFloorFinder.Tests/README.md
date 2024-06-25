# LockerFloorFinder Unit Tests

Direktori ini berisi unit test untuk proyek LockerFloorFinder. Tes ditulis menggunakan framework xUnit.

## Struktur Proyek

- `LockerFloorFinder.Tests`: Berisi unit test untuk proyek LockerFloorFinder.
  - `LockerControllerTest.cs`: Berisi tes untuk kelas `LockerController`.

## Memulai

### Prasyarat

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) atau yang lebih baru
- [xUnit](https://xunit.net/)

### Menginstal Dependensi

Untuk menginstal paket yang diperlukan, jalankan perintah berikut di direktori root proyek Anda:

```sh
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
dotnet add package Microsoft.NET.Test.Sdk
```

### Menjalankan Test

Untuk menjalankan tes, navigasikan ke direktori root proyek Anda dan jalankan:

```sh
dotnet test
```

Ini akan membangun proyek dan menjalankan semua unit test.