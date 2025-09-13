from pathlib import Path

# Save the enhanced GUI code to a .py file

from tkinter import *
from tkinter import messagebox, simpledialog
from doctor import Doctor
from patient import Patient
from pathlib import Path
from PIL import Image, ImageTk

base_dir = Path(__file__).resolve().parent
patients_file = base_dir / "patients.txt"
doctors_file = base_dir / "doctors.txt"
waiting_file = base_dir / "waiting_list.txt"

patients_file.touch(exist_ok=True)
doctors_file.touch(exist_ok=True)
waiting_file.touch(exist_ok=True)

class HospitalGUI:
    def __init__(self, root):
        self.root = root
        self.root.title("🏥 Hospital Management System")
        self.root.state("zoomed")

        self.waiting_list = []
        self.doctors = self.load_doctors()
        self.patients = self.load_patients()

        self.setup_background()
        self.create_widgets()

    def load_doctors(self):
        doctors = []
        with open(doctors_file, "r") as f:
            for line in f:
                name, specialization = line.strip().split(",")
                doctors.append(Doctor(name, specialization))
        return doctors

    def load_patients(self):
        patients = []
        with open(patients_file, "r") as f:
            for line in f:
                name, age, pid, disease, room = line.strip().split(",")
                patients.append(Patient(name, int(age), int(pid), disease, int(room)))
        return patients

    def setup_background(self):
        blue_image_path = base_dir / "Background.jpg"
        self.bg_image = Image.open(blue_image_path)
        self.bg_image = self.bg_image.resize((self.root.winfo_screenwidth(), self.root.winfo_screenheight()))
        self.bg_photo = ImageTk.PhotoImage(self.bg_image)

        self.canvas = Canvas(self.root, width=self.root.winfo_screenwidth(), height=self.root.winfo_screenheight())
        self.canvas.pack(fill="both", expand=True)
        self.canvas.create_image(0, 0, image=self.bg_photo, anchor="nw")

    def create_widgets(self):
        # White panel for better structure, but no image inside
        self.panel = Frame(self.canvas, bg="white", width=360, height=400)
        self.panel.place(x=15, y=30)

        # Button frame inside the white panel
        button_frame = Frame(self.panel, bg="white", bd=0)
        button_frame.pack(padx=5, pady=5)

        button_style = {
            "width": 27,
            "height": 3,
            "font": ("Helvetica", 10, "bold"),
            "bg": "#0a2a43",
            "fg": "white",
            "relief": FLAT,
            "bd": 1
        }

        Button(button_frame, text="👨‍⚕️ View Specializations", command=self.view_specializations, **button_style).pack(
            pady=2)
        Button(button_frame, text="🔍 Doctor Inquiry", command=self.doctor_inquiry, **button_style).pack(pady=2)
        Button(button_frame, text="🧑‍🦱 Patient Inquiry", command=self.patient_inquiry, **button_style).pack(pady=2)
        Button(button_frame, text="📝 Register New Patient", command=self.new_patient, **button_style).pack(pady=2)
        Button(button_frame, text="🕓 View Waiting List", command=self.view_waiting_list, **button_style).pack(pady=2)
        Button(button_frame, text="❌ Exit", command=self.root.quit, **button_style).pack(pady=2)

    def view_specializations(self):
        specs = {doc.specialization for doc in self.doctors}
        msg = "\n".join(sorted(specs))
        messagebox.showinfo("Available Specializations", msg)

    def doctor_inquiry(self):
        specialization = simpledialog.askstring("Doctor Inquiry", "Enter specialization:")
        if not specialization:
            return
        for doctor in self.doctors:
            if doctor.specialization.lower() == specialization.lower():
                messagebox.showinfo("Doctor Found", f"{doctor.name} ({doctor.specialization})")
                return
        messagebox.showerror("Not Found", f"No doctor found with specialization: {specialization}")

    def patient_inquiry(self):
        name = simpledialog.askstring("Patient Inquiry", "Enter patient name:")
        if not name:
            return
        for patient in self.patients:
            if patient.name.lower() == name.lower():
                info = f"Name: {patient.name} \n Age: {patient.age} \nID: {patient.id} \n Disease: {patient.disease} \n Room: {patient.room_id}"
                for doc in self.doctors:
                    if doc.specialization.lower() == patient.disease.lower():
                        info += f" \n Doctor: {doc.name}"
                        break
                messagebox.showinfo("Patient Information", info)
                return
        messagebox.showerror("Not Found", f"Patient '{name}' not found.")

    def new_patient(self):
        name = simpledialog.askstring("New Patient", "Enter patient's name:")
        if not name:
            return
        try:
            age = int(simpledialog.askstring("New Patient", "Enter patient's age:"))
        except (TypeError, ValueError):
            messagebox.showerror("Error", "Invalid age.")
            return
        disease = simpledialog.askstring("New Patient", "Enter disease:")
        if not disease:
            return
        new_id = 1000 + len(self.patients) + len(self.waiting_list) + 1
        room_id = 101 + len(self.patients)
        new_patient = Patient(name, age, new_id, disease, room_id)
        assigned = False
        for doc in self.doctors:
            if doc.specialization.lower() == disease.lower():
                doc.treat_patient(new_patient)
                assigned = True
                break
        if assigned:
            self.patients.append(new_patient)
            with open(patients_file, "a") as f:
                f.write(f"{name} \n ,{age} \n ,{new_id} \n ,{disease} \n ,{room_id} \n")
            messagebox.showinfo("Success", f"Patient registered!\\nID: {new_id} | Room: {room_id}")
        else:
            self.waiting_list.append(new_patient)
            with open(waiting_file, "a") as f:
                f.write(f"{name},{age},{new_id},{disease} \n")
            messagebox.showinfo("Waiting List", f"No doctor available for {disease}.\n Patient added to waiting list.")

    def view_waiting_list(self):
        if not self.waiting_list:
            messagebox.showinfo("Waiting List", "No patients in the waiting list.")
        else:
            msg = "\n".join(f"{p.name}, Age: {p.age}, Disease: {p.disease}, ID: {p.id}" for p in self.waiting_list)
            messagebox.showinfo("Waiting List", msg)

if __name__ == "__main__":
    root = Tk()
    app = HospitalGUI(root)
    root.mainloop()

