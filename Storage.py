# Importing Path from the pathlib module to handle file and folder paths in an object-oriented way.
from pathlib import Path

# Storage class is responsible for:
# - Creating the necessary folders and files for data persistence.
# - Saving patient data after treatment.
# - Saving patients to a waiting list when no doctor is available.
# - Loading back saved patient data if needed.
class Storage:

    def __init__(self):
        # Define the base directory for storing our files.
        # NOTE: You can customize this path based on your machine or project structure.
        self.base_dir = Path("C:/Users/USER/PycharmProjects/Hospital-Project")

        # Define full paths to the data files using the base directory.
        self.patients_file = self.base_dir / "patients.txt"        # Stores treated patients
        self.waiting_file = self.base_dir / "waiting_list.txt"     # Stores patients waiting for a doctor
        self.doctors_file = self.base_dir / "doctors.txt"          # Optional: Can be used to store doctor info

        # Ensure the base directory exists (creates it if it doesn't).
        # parents=True → allows creation of intermediate folders if they don't exist.
        # exist_ok=True → prevents errors if the folder already exists.
        self.base_dir.mkdir(parents=True, exist_ok=True)

        # Create the data files if they don't already exist.
        # .touch() creates the file if it doesn't exist but does nothing if it already exists.
        self.patients_file.touch(exist_ok=True)
        self.waiting_file.touch(exist_ok=True)
        self.doctors_file.touch(exist_ok=True)

        # Optional: This line does nothing as-is. It simply evaluates the paths to strings.
        # It may have been used for debugging or testing purposes.
        str(self.patients_file), str(self.waiting_file), str(self.doctors_file)

    # Function to save a treated patient to the patients.txt file
    def save_patient(self, patient):
        """
        Appends a patient's full record to the patients.txt file.
        This is used when the patient has been treated and assigned a room.
        """
        with open(self.patients_file, "a") as file:
            # Format: name, age, ID, disease, room number
            file.write(f"{patient.name},{patient.age},{patient.id},{patient.disease},{patient.room_id}\n")
        # Possible Interview Question: Why use "a" (append) mode instead of "w" (write)?
        # Answer: To ensure we don't erase previously saved patient data.

    # Function to save a patient to the waiting list
    def save_to_waiting_list(self, patient):
        """
        Appends a patient to the waiting_list.txt file if no doctor is currently available
        for their disease specialization.
        """
        with open(self.waiting_file, "a") as file:
            # Format: name, age, ID, disease
            file.write(f"{patient.name},{patient.age},{patient.id},{patient.disease}\n")
        # NOTE: We don’t save room_id here because the patient hasn’t been assigned a room yet.

    # Optional method to load patients from the patients.txt file
    def load_patients(self):
        """
        Reads the patients.txt file line by line and returns a list of dictionaries,
        each representing a patient's information.
        """
        patients = []

        # Open file in read mode
        with open(self.patients_file, "r") as file:
            for line in file:
                # Remove any leading/trailing spaces or newline characters
                # and split the line by commas
                data = line.strip().split(",")

                # We expect exactly 5 values: name, age, id, disease, room_id
                if len(data) == 5:
                    name, age, id_, disease, room_id = data

                    # Convert numeric values back from string to int
                    patients.append({
                        "name": name,
                        "age": int(age),
                        "id": int(id_),
                        "disease": disease,
                        "room_id": int(room_id)
                    })

        return patients
        # Possible Interview Question: Why return dictionaries instead of objects?
        # Answer: It's a simpler format for testing and flexible enough for data handling.
