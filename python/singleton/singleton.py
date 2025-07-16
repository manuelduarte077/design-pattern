class Singleton:
  _instance = None

  # Metodos Magicos
  def __new__(cls, name = None, age = None):
    if not cls._instance:
      cls._instance = super(Singleton, cls).__new__(cls)
      cls._instance.name = name
      cls._instance.age = age
    return cls._instance
  
singleton = Singleton("Manuel", 24)
singleton1 = Singleton()

print(singleton is singleton1)
print(singleton.name)
print(singleton1.name)