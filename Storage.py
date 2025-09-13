# storage.py

from pathlib import Path
import json

# Storage class is responsible for:
# - Creating folders/files for data.
# - Saving patient data (treated or waiting).
# - Loading stored patient/doctor data.

class Storage:
    def __init__(self):
        # Define paths for data directories and files
        self.base_path = Path("data")
        self.treated_patients_path = self.base_path / "treated_patients.json"
        self.waiting_list_path = self.base_path / "waiting_list.json"
        self.doctors_path = self.base_path / "doctors.json"

        # Create data directory if not exists
        self.base_path.mkdir(parents=True, exist_ok=True)

        # Ensure all data files exist (create them empty if not)
        for file_path in [self.treated_patients_path, self.waiting_list_path, self.doctors_path]:
            if not file_path.exists():
                file_path.write_text("[]")  # Write empty list as JSON

    def save_patient(self, patient, treated=True):
        # Save patient to either treated or waiting list
        file_path = self.treated_patients_path if treated else self.waiting_list_path
        data = self._load_json(file_path)
        data.append(patient.to_dict())
        self._save_json(file_path, data)

    def save_doctors(self, doctors):
        # Save list of doctors to doctors.json
        data = [doctor.to_dict() for doctor in doctors]
        self._save_json(self.doctors_path, data)

    def load_doctors(self):
        # Load list of doctors from doctors.json
        from doctor import Doctor  # Import here to avoid circular import
        data = self._load_json(self.doctors_path)
        return [Doctor.from_dict(item) for item in data]

    def _load_json(self, file_path):
        # Helper to load JSON file into Python list/dict
        try:
            with open(file_path, "r", encoding="utf-8") as f:
                return json.load(f)
        except json.JSONDecodeError:
            return []

    def _save_json(self, file_path, data):
        # Helper to write Python data (list/dict) to JSON file
        with open(file_path, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=4)

