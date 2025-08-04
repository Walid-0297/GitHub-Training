# 🏥 Hospital Management System – Python OOP Project

A simple yet powerful **Hospital Management System** built using Object-Oriented Programming (OOP) principles in Python.  
This console-based application allows for managing patients, doctors, inquiries, and registration with clear separation of logic across multiple classes.

---

## 🎯 Features

- Patient inquiry based on ID
- Doctor search by specialization
- Registering new patients and auto-assigning available doctors
- Handling unmatched patients with a waiting list
- Saving patient data to file storage
- Viewing available specializations in the hospital
- Modular design using clean OOP structure

---

## 🏗️ Project Structure

hospital_management_system/
├── main.py                → Main control flow and user interface
├── patient.py             → Defines the Patient class with attributes and getters
├── doctor.py              → Defines the Doctor class with name & specialization
├── Storage.py             → Handles saving patient data to a file
├── inquiries.py           → Manages inquiries and patient registration logic
├── patients.txt           → Text file for storing newly registered patient data
├── README.md              → Project documentation (this file)
└── .gitignore             → (Optional) Files/folders ignored by Git (e.g., __pycache__, *.pyc)


---

## 🧠 OOP Principles Used

- **Encapsulation**: Each class manages its own data and responsibilities.
- **Abstraction**: The logic is hidden inside dedicated classes (`InquiryManager`, `Storage`, etc).
- **Separation of Concerns**: The UI is separated from the business logic.
- **Modularity**: Each class in its own file for easy maintenance and testing.

---

## 💻 How to Run

1. Make sure Python 3 is installed.
2. Clone the repo or download the files.
3. Open terminal or CMD and run:




