# 🏃‍♂️ PulseTrack

**PulseTrack** is a modular, real-time fitness tracking API built with ASP.NET Core. It collects and serves health metrics such as heart rate and step count, designed for seamless integration with mobile apps and wearable devices. Built with clean architecture and extensibility in mind, PulseTrack is ideal for developers seeking a scalable backend for health data ingestion and visualization.

---

## 🚀 Features

- ✅ Real-time metric ingestion via RESTful endpoints
- ✅ In-memory database for rapid prototyping
- ✅ DTO-based validation and clean separation of concerns
- ✅ Modular service layer for business logic
- ✅ Ready for SignalR integration and mobile expansion

---

## 📦 Tech Stack

- ASP.NET Core 8
- Entity Framework Core (InMemory)
- C# 11
- RESTful API
- JSON serialization

---

## 📁 Project Structure

```plaintext
PulseTrack/
├── Controllers/         # API endpoints
├── Models/              # Domain entities
├── DTOs/                # Data transfer objects
├── Services/            # Business logic
├── Data/                # EF Core DbContext
├── Program.cs           # Entry point
├── appsettings.json     # Configuration
├── README.md            # Project overview
├── LICENSE              # MIT License
```
🧪 Quick Start
bash
dotnet restore
dotnet run
API will be available at:

Code
http://localhost:5000
📬 Sample Request
```bash
curl -X POST http://localhost:5000/api/metrics/heartrate \
-H "Content-Type: application/json" \
-d "{\"bpm\": 85, \"timestamp\": \"2025-09-25T19:30:00\"}"
```
## 📥 Sample Response

After sending a valid request to `POST /api/metrics/heartrate`, the API returns structured JSON data like this:

```json
[
  {
    "id": 1,
    "pm": 65,
    "timestamp": "2023-09-28T20:18:00"
  }
]
```

🛡️ License
This project is licensed under the MIT License. See the LICENSE file for details.

✨ Author
Built with precision and vision by Murad, a full-stack architect passionate about cyber-inspired branding and scalable systems.
