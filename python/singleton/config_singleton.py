import json

class ConfigSingleton:
  _instance = None

  def __new__(cls, file_name = "config.json"):
    if not cls._instance:
      cls._instance = super(ConfigSingleton, cls).__new__(cls)
      cls._instance.__load(file_name)
    return cls._instance
  
  def __load(self, file_name):
    try:
      with open(file_name, "r") as file:
        self.config = json.load(file)
    except FileNotFoundError:
      self.config = None
      print("File not found")    
    except json.JSONDecodeError:
      self.config = None
      print("The file json not valid")

  def get(self, key):
    return self.config.get(key)

  
config1 = ConfigSingleton("config.json")
print(config1.get("version"))
print(config1.get("name"))

config2 = ConfigSingleton()
print(config1 is config2)


