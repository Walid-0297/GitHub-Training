# inquiry_manager.py

# InquiryManager handles:
# - Viewing available specializations
# - Viewing doctors by specialization (case-insensitive)
# - Viewing waiting list of patients

class InquiryManager:
    def __init__(self, storage):
        # Takes a Storage instance to interact with saved data
        self.storage = storage

    def view_available_specializations(self):
        # Get unique specializations from all doctors
        doctors = self.storage.load_doctors()
        specializations = sorted(set(doc.specialization.title() for doc in doctors))

        if not specializations:
            print("No specializations found.")
        else:
            print("Available Specializations:")
            for spec in specializations:
                print("-", spec)

    def view_doctors_by_specialization(self, specialization):
        # Display all doctors matching the given specialization (case-insensitive)
        doctors = self.storage.load_doctors()
        matched_doctors = [doc for doc in doctors if doc.specialization.lower() == specialization.lower()]

        if not matched_doctors:
            print(f"No doctors found for specialization: {specialization}")
        else:
            print(f"Doctors specialized in {specialization.title()}:")
            for doc in matched_doctors:
                print("-", doc.name)

    def view_waiting_list(self):
        # Display patients waiting for unavailable doctors
        waiting_patients = self.storage.load_waiting_list()

        if not waiting_patients:
            print("No patients in the waiting list.")
        else:
            print("Patients in Waiting List:")
            for patient in waiting_patients:
                print(f"- {patient.name} | Age: {patient.age} | Problem: {patient.problem}")

