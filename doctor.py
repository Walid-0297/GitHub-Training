# Define the Doctor class – represents a doctor in the hospital system
class Doctor:

    # Constructor method – initializes the doctor object with name and specialization
    def __init__(self, name, specialization):
        """
        This is the constructor (like in Java).
        It sets up the Doctor object with basic information.

        Parameters:
        - name: The name of the doctor (string)
        - specialization: The field the doctor specializes in (string)
        """
        self.name = name  # Stores the doctor's name
        self.specialization = specialization  # Stores the doctor's medical specialty

    # Method to simulate treating a patient
    def treat_patient(self, patient):
        """
        Simulates treating a patient by printing out a detailed treatment message.

        Parameters:
        - patient: A Patient object that the doctor will treat
        """

        # This print simulates the interaction between doctor and patient.
        # It's useful during testing or logging system behavior.
        print(f"{self.name} will treat patient ID {patient.get_id()} ({patient.get_name()}), "
              f"age {patient.get_age()}, for {patient.get_disease()} in room {patient.get_room_id()}.")

        # Note:
        # This uses getter methods from the Patient class to access the patient's data safely,
        # which is a form of encapsulation — keeping attributes private and exposing them via methods.

    # Getter method to retrieve doctor's specialization
    def get_specialization(self):
        return self.specialization

    # Getter method to retrieve doctor's name
    def get_name(self):
        return self.name

