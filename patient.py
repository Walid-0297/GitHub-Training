# Define the Patient class – represents a hospital patient
class Patient:

    # Constructor method – runs automatically when creating a new Patient object
    def __init__(self, name, age, id, disease, room_id):
        # self refers to the instance of the object being created.
        # In Arabic: الكائن نفسه اللي بنتعامل معاه داخل الكلاس

        """
        Initializes a new Patient object with the provided information.

        Parameters:
        - name: The name of the patient (string)
        - age: The age of the patient (integer)
        - id: A unique identifier for the patient (integer)
        - disease: The illness the patient is suffering from (string)
        - room_id: The room number assigned to the patient (integer)
        """

        self.name = name        # Stores the patient's name
        self.age = age          # Stores the patient's age
        self.id = id            # Stores the patient's unique ID
        self.disease = disease  # Stores the name of the disease
        self.room_id = room_id  # Stores the assigned hospital room number

    # Getter method for patient's name
    def get_name(self):
        return self.name

    # Getter method for patient's age
    def get_age(self):
        return self.age

    # Getter method for patient's ID
    def get_id(self):
        return self.id

    # Getter method for patient's disease
    def get_disease(self):
        return self.disease

    # Getter method for patient's room ID
    def get_room_id(self):
        return self.room_id
