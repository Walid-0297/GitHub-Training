# ----------------- Import Statements -----------------
from patient import Patient                    # Import Patient class
from doctor import Doctor                      # Import Doctor class
from Storage import Storage                    # Import Storage handler
from inquiries import InquiryManager           # Import class handling inquiries

# ----------------- Object Creation -----------------
# Define the list of patients – hardcoded data to simulate hospital records
patients = [
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

# Define the list of doctors – each associated with a specialization
doctors = [
    Doctor("Dr. Mohamed Moustafa", "The Flu"),
    Doctor("Dr. Mostafa Al-Shetry", "Measles"),
    Doctor("Dr. Walid Hamido", "HIV"),
    Doctor("Dr. Hamza", "Strep Throat"),
    Doctor("Walid Mohammed", "COVID-19"),
    Doctor("Dr. Mahmoud Elzeer", "Salmonella"),
    Doctor("Dr. Hazaem Gad Allah", "Corona Mutant"),
    Doctor("Dr. Amgad Moustafa", "Cancer"),
    Doctor("Dr. Amr Fathy", "Heart Disease"),
    Doctor("Dr. Ahmed Ashraf", "Diabetes")
]

# Create a Storage object – responsible for saving patient data to file
storage = Storage()

# Create a waiting list – for patients who couldn’t be matched to a doctor
waiting_list = []

# Create an InquiryManager object – responsible for handling all menu actions
inquiry_manager = InquiryManager(storage)

# ----------------- Main Program Loop -----------------
# The program runs in an infinite loop until the user chooses to exit
while True:
    print("\n--- Welcome to the Hospital Management System ---")
    print("1. Inquire about a patient")
    print("2. Inquire about a doctor")
    print("3. Register a new patient")
    print("4. View available doctor specializations")
    print("5. View waiting list")
    print("6. Exit")

    # Get user input
    choice = input("Enter your choice (1-6): ").strip()

    # ------------------- Menu Options -------------------

    # Option 1: Search for a patient
    if choice == "1":
        inquiry_manager.patient_inquiry(patients, doctors)

    # Option 2: Search for a doctor by specialization
    elif choice == "2":
        inquiry_manager.doctor_inquiry(doctors)

    # Option 3: Add a new patient and assign doctor
    elif choice == "3":
        inquiry_manager.new_patient(patients, doctors)

    # Option 4: View all unique doctor specializations
    elif choice == "4":
        inquiry_manager.view_available_specializations(doctors)

    # Option 5: View patients who are waiting for available doctors
    elif choice == "5":
        inquiry_manager.view_waiting_list()

    # Option 6: Exit the program
    elif choice == "6":
        print("Exiting the system. Goodbye!")
        break

    # Invalid input fallback
    else:
        print("Invalid choice. Please enter a number between 1 and 6.")


