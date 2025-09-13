# patient.py

class Patient:
    """
    Represents a patient in the hospital system.
    Stores personal and medical information like name, age, ID, disease, and room ID.
    """

    def __init__(self, name: str, age: int, id: int, disease: str, room_id: int):
        """
        Initializes a new patient object with the provided attributes.

        :param name: Patient's full name
        :param age: Patient's age
        :param id: Unique identifier for the patient
        :param disease: Name of the diagnosed disease
        :param room_id: Assigned room number in the hospital
        """
        self._name = name
        self._age = age
        self._id = id
        self._disease = disease
        self._room_id = room_id

    # Getters (Pythonic way: properties)
    @property
    def name(self) -> str:
        return self._name

    @property
    def age(self) -> int:
        return self._age

    @property
    def id(self) -> int:
        return self._id

    @property
    def disease(self) -> str:
        return self._disease

    @property
    def room_id(self) -> int:
        return self._room_id
