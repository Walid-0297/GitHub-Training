# InquiryManager handles all the "inquiry-related" logic.
# It interacts with both the doctors and patients data
# and allows the user to search or view records.

class InquiryManager:
    def __init__(self, storage):
        # Store a reference to the storage instance so we can access saved files if needed.
        # This is Dependency Injection: we pass dependencies instead of creating them inside the class.
        self.storage = storage

    @staticmethod
    def inquire_doctor(doctors, specialization):
        """
        Finds available doctors for a given specialization (case-insensitive).
        If one or more doctors are found, they are displayed and returned.
        If no doctor is available, returns an empty list.
        """
        # Convert specialization to lowercase for case-insensitive comparison
        specialization = specialization.lower()

        # Use list comprehension to filter doctors by specialization
        matched_doctors = [doc for doc in doctors if doc.specialization.lower() == specialization]

        if matched_doctors:
            print("\nAvailable doctors in this specialization:")
            for doctor in matched_doctors:
                print(f"ID: {doctor.id}, Name: Dr. {doctor.name}")
        else:
            print("\nNo doctor available for this specialization at the moment.")

        return matched_doctors

    @staticmethod
    def inquire_patient(patients):
        """
        Displays a list of all patients (treated).
        Data must be passed in from storage.load_patients() or a similar source.
        """
        if not patients:
            print("No patients found.")
            return

        print("\nList of treated patients:")
        for patient in patients:
            # Each patient is expected to be a dictionary (name, age, id, disease, room_id)
            print(f"Name: {patient['name']}, Age: {patient['age']}, ID: {patient['id']}, "
                  f"Disease: {patient['disease']}, Room ID: {patient['room_id']}")
