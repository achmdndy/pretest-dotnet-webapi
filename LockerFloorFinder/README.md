# LockerFloorFinder

LockerFloorFinder adalah aplikasi web API untuk menemukan lantai berdasarkan nomor loker.

## Penggunaan

Untuk menemukan lantai dari nomor loker, lakukan HTTP GET request ke endpoint `/api/locker/{lockerNumber}`.

### Contoh

**Request:**

GET /api/locker/17

**Response:**

```json
{
  "status": "Success",
  "message": "Nomor lantai berhasil ditemukan.",
  "error": null,
  "data": 3
}
```

**Error Handling:**

Jika nomor loker yang diberikan tidak valid (kurang dari 1), Anda akan menerima respons error.

```json
{
  "status": "Error",
  "message": "Nomor loker harus lebih besar dari 0.",
  "error": "InvalidLockerNumber",
  "data": null
}
```