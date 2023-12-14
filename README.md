**HIPAlert API:**<br>

This repository contains the backend implementation of HIPAlert, an application designed for continuous patient monitoring and hypertension alerting. 
The API is built using .NET 7, following the principles of Clean Architecture, incorporating various design patterns, SOLID principles, and industry-standard tools.
Clean Architecture: Organized into five layers - API, Infrastructure, Application, Persistence, and Domain - for better separation of concerns.
SOLID Principles: Adherence to SOLID principles to enhance code maintainability and scalability.
Unity Of Work & Repository Pattern: Utilization of the Unit of Work pattern along with the Repository pattern for managing data access.
CQRS Pattern & Mediator: Implementing the Command Query Responsibility Segregation pattern with Mediator for better command and query separation.
AutoMapper: Utilizing AutoMapper for object-to-object mapping.
PostgreSQL Database: Integration with PostgreSQL for data persistence.
Seeds Context: Providing seed data for the initial state of the application.
DTOs (Data Transfer Objects): Implementing DTOs to transfer data between layers.
LogHistory: Maintaining a log history for better tracking and debugging.
JWT (JSON Web Tokens): Using JWT for secure authentication and authorization.
 <br> 

**Features:** <br>

HIPAlert application might include:
User Authentication and Authorization: Allow users to register, log in, and manage their accounts securely.
Patient Registration and Management: Enable healthcare professionals to register and manage patient profiles, including personal information, medical history, and contact details.
Continuous Patient Monitoring: Implement functionality to continuously monitor patients' blood pressure, heart rate, and other relevant vitals using wearable devices or manual input.
Hypertension Alerting System: Set up an alerting system that notifies healthcare providers or patients themselves in case of abnormal blood pressure readings or critical health conditions.
Medical History Recording: Record and maintain a comprehensive medical history for each patient, including past surgeries, medical exams, allergies, medications, and lifestyle details.
Data Visualization and Analysis: Provide visual representations of patient vitals over time, facilitating analysis and decision-making for healthcare professionals.
Complaints and Grievance Management: Allow patients to raise complaints or report issues regarding their health management, enabling healthcare providers to address these concerns promptly.
Integration with Wearable Devices: Support integration with various wearable devices or apps to collect real-time health data from patients' devices.
Automated Reporting and Insights: Generate automated reports or insights based on collected data, aiding healthcare professionals in making informed decisions.
Data Security and Compliance: Ensure data security measures are in place, including encryption, access control, and compliance with healthcare data protection regulations.
These features cover a broad spectrum of functionalities that a patient monitoring and hypertension alerting system might include.
<br> 
**Author:** Marcos Fabiao Chichava: Software Developer
<br> 
**Start Date:** 14/12/2023 
