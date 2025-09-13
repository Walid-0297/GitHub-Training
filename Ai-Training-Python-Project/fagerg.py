

import json

class Storage:
def _init_(self, filename):
self.filename = filename

def save(self, data):
with open(self.filename, 'w') as f:
json.dump(data, f)

def load(self):
with open(self.filename, 'r') as f:
return json.load(f)

# Example
store = Storage("data.json")
store.save({"patients": ["Ahmed", "Salma"]})
print(store.load()) # Result: {'patients': ['Ahmed', 'Salma']}
