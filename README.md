🌿 Phoenix Cancer Care Web App

📌 Overview

Phoenix Cancer Care is a healthcare-focused web application designed to:

Raise awareness about cancer types

Promote healthy living

Facilitate appointment bookings with specialists

Built for HackMS'26, the app emphasizes:

✅ Accessibility

✅ Mobile responsiveness

✅ User-friendly design

✨ Features

📚 Health Awareness Information: Educational content on major cancer types in Sri Lanka, prevention strategies, screening routines, and nutrition.

🗓️ Appointment Booking: Users can schedule appointments with doctors by submitting personal details and preferred dates.

📱 Responsive Design: Optimized for mobile and desktop devices.

🧭 Navigation: Clear menu structure linking to Home, Booking, Awareness Info, and About Us pages.

🛠️ Tech Stack

Frontend: HTML5, CSS3, JavaScript

Backend: .NET Framework with C#

Database: Microsoft SQL Server (MS SQL)

Deployment: GitHub (version control), Microsoft Azure (hosting)

🗃️ Database Structure

👤 Users Table

UserID (PK)

FullName

Username

DOB

Address

ContactNumber

EmailAddress

Gender

NIC

Password

📅 Appointments Table

AppointmentID (PK)

UserID (FK)

FullName

Email

ContactNumber

DoctorName

AppointmentDate

⚙️ Setup Instructions

📥 Clone the repository from GitHub.

🧑‍💻 Open the solution in Visual Studio.

🔗 Configure the MS SQL database connection string in the backend.

🚀 Run the backend server using IIS Express or Azure.

🌐 Open index.html or home.html in a browser to view the frontend.

📁 Folder Structure

PhoenixCancerCare/
├── frontend/
│   ├── home.html
│   ├── booking.html
│   ├── info.html
│   ├── aboutus.html
│   └── style.css
├── backend/
│   ├── Controllers/
│   ├── Models/
│   └── Services/
├── database/
│   └── schema.sql
├── README.md
└── .gitignore

👩‍💻 Contributors

Ruwani Rathnayaka

Siluni Wijesinghe

Pamoda Amarawansha

📄 License

This project is for educational and hackathon purposes only.

📞 Contact

Phoenix Cancer Care CenterNo 12, Crossroad Avenue, Colombo 8📱 (555) 123-4569📧 info@phoenixcancercare.org
