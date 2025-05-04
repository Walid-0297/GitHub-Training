# 🔐 Password Strength Checker

A simple C# console app that checks the strength of a password based on its contents.

## ✅ Features

- Checks password length
- Detects uppercase letters
- Detects numbers
- Detects symbols
- Rates strength as **Weak**, **Medium**, or **Strong**

## 🔍 How It Works

The app scores the password using the following rules:

| Condition                  | Score |
|---------------------------|-------|
| Length >= 8               | +1    |
| Contains uppercase letter | +1    |
| Contains number           | +1    |
| Contains symbol           | +1    |

Final score gives a result:

- 0–1 → Weak
- 2–3 → Medium
- 4 → Strong

## 🧪 Example

