# doctor.py

from patient import Patient

class Doctor:
    """
    Represents a doctor with a name and specialization.
    Can treat a Patient and display treatment information.
    """

    def __init__(self, name: str, specialization: str):
        """
        Initializes a new doctor.

        :param name: Doctor's name
        :param specialization: Doctor's medical specialization
        """
        self._name = name
        self._specialization = specialization

    @property
    def name(self) -> str:
        return self._name

    @property
    def specialization(self) -> str:
        return self._specialization

    def treat_patient(self, patient: Patient):
        """
        Prints treatment info of a patient by this doctor.

        :param patient: The Patient object to be treated
        """
        print(f"{self._name} will treat patient ID {patient.id} "
              f"({patient.name}), age {patient.age}, for {patient.disease} "
              f"in room {patient.room_id}.")
