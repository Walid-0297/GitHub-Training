# 🏥 Hospital Management System

A clean, beginner-friendly **Hospital Management System** developed using **Object-Oriented Programming (OOP)** principles in Python.

This console-based app allows hospitals to manage their patient-doctor workflow efficiently, using modular design, file-based storage, and separation of logic.

---

## 🎯 Features

✅ **View Available Doctor Specializations**  
✅ **Search for Doctors by Specialization**  
✅ **Search for Patients by Name**  
✅ **Register New Patients Automatically**  
✅ **Doctor Treats Patients Based on Specialization**  
✅ **Waiting List for Unassigned Patients**  
✅ **Persistent File-Based Storage** (acts like database)  
✅ **Structured Code with Reusable Classes**

---

## 🧠 OOP Principles Used

- **Encapsulation**: Each class (like `Patient`, `Doctor`) handles its own data and methods.
- **Abstraction**: Treatment logic is handled internally inside the doctor class.
- **Modularity**: Separated classes into their own files for reusability and clarity.
- **Separation of Concerns**: Logic is split between `main.py`, `inquiries.py`, and `storage.py`.

---

## 🧱 Code Structure

hospital_management
│
- ├── main.py # Main entry point; handles user interface and program flow
- ├── patient.py # Defines the Patient class (name, age, id, disease, room)
- ├── doctor.py # Defines the Doctor class (name, specialization, treatment logic)
- ├── inquiries.py # Handles patient and doctor search/inquiry features
- ├── storage.py # Manages saving/loading patients and doctors to/from .txt files 
   - ├── patients.txt # Stores patient records (auto-created)
   - ├── doctors.txt # Stores doctor records (auto-created)
   - ├── waiting_list.txt # Stores patients awaiting assignment (optional)

 ---

## 🧠 OOP Principles Used

- **Encapsulation**: Each class (`Patient`, `Doctor`, `Storage`, `Inquiries`) encapsulates its own data and methods.
- **Abstraction**: Complex logic like data saving, reading, and searching is hidden behind clean method calls (e.g., `Storage.save_patient()` or `Inquiries.patient_inquiry()`).
- **Separation of Concerns**: The system is split across multiple classes and files:
  - `main.py` handles the interface and menu.
  - `patient.py`, `doctor.py` define the data models.
  - `storage.py` handles all file operations.
  - `inquiries.py` handles all search/inquiry logic.
- **Modularity**: Each class is defined in its own file and can be reused or extended separately.

---

## 🖼️ GUI 

We are currently working on adding a user-friendly **Graphical User Interface** using `tkinter` or `PyQt` to enhance the user experience.

Planned features for the GUI:
- Modern and intuitive patient registration form
- Visual list of available doctors
- Search bar to quickly find patients by ID
- Real-time feedback and form validation
- Menu buttons for navigation instead of CLI options

This will be implemented in a separate file (e.g., `gui.py`) without affecting the current backend logic.

---

## 💻 How to Run

1. **Make sure Python 3 is installed** on your machine.

2. **Clone the repository** or download the `.py` files directly:
   - `main.py`
   - `patient.py`
   - `doctor.py`
   - `inquiries.py`
   - `storage.py`
   - `GUI.py`









