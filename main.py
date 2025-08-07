# main.py

from doctor import Doctor
from patient import Patient
from pathlib import Path

# File paths
base_dir = Path(__file__).resolve().parent
patients_file = base_dir / "patients.txt"
waiting_file = base_dir / "waiting_list.txt"
doctors_file = base_dir / "doctors.txt"

# Make sure files exist
patients_file.touch(exist_ok=True)
waiting_file.touch(exist_ok=True)
doctors_file.touch(exist_ok=True)

# Initialize doctors
doctors = [
    Doctor("Dr. Mohamed Moustafa", "The Flu"),
    Doctor("Dr. Walid Mohamed", "Measles"),
    Doctor("Dr. Walid Hamido", "HIV"),
    Doctor("Dr. Hassan", "Strep Throat"),
    Doctor("Dr. Youssef Ahmed", "COVID-19"),
    Doctor("Dr. Mahmoud Elzeer", "Salmonella"),
    Doctor("Dr. Hazaem Gad Allah", "Corona Mutant"),
    Doctor("Dr. Amgad Moustafa", "Cancer"),
    Doctor("Dr. Amr Fathy", "Heart Disease"),
    Doctor("Dr. Ahmed Ashraf", "Diabetes")
]

# Save doctors to file (once only)
if doctors_file.stat().st_size == 0:
    with open(doctors_file, "w") as f:
        for doc in doctors:
            f.write(f"{doc.name},{doc.specialization}\n")

# Initial patients
patients = [
    Patient("Ali", 25, 1001, "The Flu", 101),
    Patient("Mona", 30, 1002, "Measles", 102),
    Patient("Omar", 35, 1003, "HIV", 103),
    Patient("Laila", 40, 1004, "Strep Throat", 104),
    Patient("Youssef", 45, 1005, "COVID-19", 105),
    Patient("Dina", 50, 1006, "Salmonella", 106),
    Patient("Karim", 55, 1007, "Corona Mutant", 107),
    Patient("Nada", 60, 1008, "Cancer", 108),
    Patient("Amr", 65, 1009, "Heart Disease", 109),
    Patient("Sara", 70, 1010, "Diabetes", 110)
]

# Save patients to file (once only)
if patients_file.stat().st_size == 0:
    with open(patients_file, "w") as f:
        for p in patients:
            f.write(f"{p.name},{p.age},{p.id},{p.disease},{p.room_id}\n")

waiting_list = []

# ------------------- Menu Logic -------------------

def save_patient_to_file(patient):
    with open(patients_file, "a") as f:
        f.write(f"{patient.name},{patient.age},{patient.id},{patient.disease},{patient.room_id}\n")

def save_to_waiting_list(patient):
    with open(waiting_file, "a") as f:
        f.write(f"{patient.name},{patient.age},{patient.id},{patient.disease}\n")

def view_specializations():
    specs = {doc.specialization.lower() for doc in doctors}
    print("Available Specializations:")
    for s in sorted(specs):
        print(f"- {s.capitalize()}")

def doctor_inquiry():
    spec = input("Enter specialization: ").strip().lower()
    found = False
    for doc in doctors:
        if doc.specialization.lower() == spec:
            print(f"Doctor: {doc.name} | Specialization: {doc.specialization}")
            found = True
    if not found:
        print("No doctor found with that specialization.")

        def patient_inquiry(patients, doctors):
            name = input("Enter patient name: ")
            found = False

            for patient in patients:
                if patient.name.lower() == name.strip().lower():
                    found = True
                    print("\nPatient Information:")
                    print(f"Name: {patient.name}")
                    print(f"Age: {patient.age}")
                    print(f"ID: {patient.id}")
                    print(f"Room: {patient.room_id}")

                    doctor_found = False
                    for doctor in doctors:
                        if doctor.specialization.lower() == patient.disease.lower():
                            doctor.treat_patient(patient)
                            doctor_found = True
                            break

                    if not doctor_found:
                        print(f"No doctor available to treat {patient.disease}.")
                    break

            if not found:
                print(f"Patient {name} is not in the system.")


def patient_inquiry(patients, doctors):
    name = input("Enter patient name: ")
    found = False

    for patient in patients:
        if patient.name.lower() == name.strip().lower():
            found = True
            print("\nPatient Information:")
            print(f"Name: {patient.name}")
            print(f"Age: {patient.age}")
            print(f"ID: {patient.id}")
            print(f"Room: {patient.room_id}")

            doctor_found = False
            for doctor in doctors:
                if doctor.specialization.lower() == patient.disease.lower():
                    doctor.treat_patient(patient)
                    doctor_found = True
                    break

            if not doctor_found:
                print(f"No doctor available to treat {patient.disease}.")
            break

    if not found:
        print(f"Patient {name} is not in the system.")

def view_waiting_list():
    if not waiting_list:
        print("No patients in the waiting list.")
    else:
        print("Waiting List:")
        for p in waiting_list:
            print(f"{p.name}, Age: {p.age}, Disease: {p.disease}, ID: {p.id}")

def register_patient():
    name = input("Patient name: ")
    try:
        age = int(input("Patient age: "))
    except ValueError:
        print("Invalid age.")
        return

    disease = input("Disease: ")
    new_id = 1000 + len(patients) + len(waiting_list) + 1
    room_id = 101 + len(patients)

    new_patient = Patient(name, age, new_id, disease, room_id)
    found = False

    for doc in doctors:
        if doc.specialization.lower() == disease.lower():
            doc.treat_patient(new_patient)
            found = True
            break

    if found:
        patients.append(new_patient)
        save_patient_to_file(new_patient)
        print("Patient registered and assigned to doctor.")
    else:
        waiting_list.append(new_patient)
        save_to_waiting_list(new_patient)
        print("No doctor available for this disease. Patient added to waiting list.")

def main_menu():
    while True:
        print("\n--- Hospital Management System ---")
        print("1. View Available Specializations")
        print("2. View Doctors by Specialization")
        print("3. Patient inquiry")
        print("4. View Waiting List")
        print("5. Register New Patient")
        print("6. Exit")

        choice = input("Enter your choice (1-6): ")

        if choice == "1":
            view_specializations()
        elif choice == "2":
            doctor_inquiry()
        elif choice == "3":
            patient_inquiry(patients, doctors)
        elif choice == "4":
            view_waiting_list()
        elif choice == "5":
            register_patient()
        elif choice == "6":
            print("Thank you for visiting!")
            break
        else:
            print("Invalid input.")

if __name__ == "__main__":
    main_menu()
