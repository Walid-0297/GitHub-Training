import tkinter as tk
from tkinter import messagebox, simpledialog
from doctor import Doctor
from patient import Patient


class HospitalGUI:
    def __init__(self, root):
        self.root = root
        self.root.title("Hospital Management System")

        self.doctors = [
            Doctor("Dr. Mohamed Moustafa", "The Flu"),
            Doctor("Dr. Walid Mohamed", "Measles"),
            Doctor("Dr. Walid Hamido", "HIV"),
            Doctor("Dr. Hassan", "Strep Throat"),
            Doctor("Dr. Youssef Ahmed", "COVID-19"),
            Doctor("Dr. Mahmoud Elzeer", "Salmonella"),
            Doctor("Dr. Haza Gad Allah", "Corona Mutant"),
            Doctor("Dr. Amgad Moustafa", "Cancer"),
            Doctor("Dr. Amr Fathy", "Heart Disease"),
            Doctor("Dr. Ahmed Ashraf", "Diabetes")
        ]

        self.patients = [
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

        self.create_widgets()

    def create_widgets(self):
        tk.Button(self.root, text="Patient Inquiry", width=30, command=self.patient_inquiry).pack(pady=10)
        tk.Button(self.root, text="Doctor Inquiry", width=30, command=self.doctor_inquiry).pack(pady=10)
        tk.Button(self.root, text="Add New Patient", width=30, command=self.new_patient).pack(pady=10)
        tk.Button(self.root, text="Exit", width=30, command=self.root.quit).pack(pady=10)

    def patient_inquiry(self):
        name = simpledialog.askstring("Patient Inquiry", "Enter patient name:")
        if not name:
            return

        for patient in self.patients:
            if patient.name.lower() == name.strip().lower():
                info = f"Name: {patient.name}\nAge: {patient.age}\nID: {patient.id}\nRoom: {patient.room_id}\n"
                for doctor in self.doctors:
                    if doctor.specialization.lower() == patient.disease.lower():
                        info += f"Doctor: {doctor.name} (Specialization: {doctor.specialization})"
                        break
                else:
                    info += "No doctor available for this disease."

                messagebox.showinfo("Patient Information", info)
                return

        messagebox.showerror("Not Found", f"Patient '{name}' is not in the system.")

    def doctor_inquiry(self):
        specialization = simpledialog.askstring("Doctor Inquiry", "Enter specialization:")
        if not specialization:
            return

        for doctor in self.doctors:
            if doctor.specialization.lower() == specialization.strip().lower():
                info = f"Name: {doctor.name}\nSpecialization: {doctor.specialization}"
                messagebox.showinfo("Doctor Information", info)
                return

        messagebox.showerror("Not Found", f"No doctor found with specialization: {specialization}")

    def new_patient(self):
        name = simpledialog.askstring("New Patient", "Enter patient's full name:")
        if not name:
            return
        try:
            age = int(simpledialog.askstring("New Patient", "Enter patient's age:"))
        except (ValueError, TypeError):
            messagebox.showerror("Invalid Input", "Age must be a number.")
            return

        disease = simpledialog.askstring("New Patient", "Enter patient's disease:")
        if not disease:
            return

        new_id = 1000 + len(self.patients) + 1
        new_room_id = 101 + len(self.patients)

        new_p = Patient(name, age, new_id, disease, new_room_id)
        self.patients.append(new_p)

        messagebox.showinfo("Success", f"Patient Registered Successfully!\nPatient ID: {new_p.id}")


if __name__ == "__main__":
    root = tk.Tk()
    app = HospitalGUI(root)
    root.mainloop()
