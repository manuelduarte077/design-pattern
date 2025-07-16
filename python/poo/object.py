print("Object Python")

class People:
  def __init__(self, name: str, age: int): ## Constructor
    self.name = name
    self.__age = age

  def hi(self):
    print("Hello, " + self.name)

  def get_age(self):
    return self.__age
  
  def __some(self): # Metodo privado
    print("Algo")

  @staticmethod
  def helloworld():
    print("Hello, World!")

  @classmethod
  def helloworld2(cls): 
    print("Hello World")

manuel = People("Manuel", 24) # Creando un objeto de la clase People
manuel.hi() # Llamando al método hi del objeto manuel

class Barman(People):
  pass 

  def welcome(self):
    print("Bienvenido")

class Student(People):
  def __init__(self, name, age, profession):
    super().__init__(name, age)
    self.profession = profession

  def hi(self):
    print("Hola soy " + self.name+ " y soy un " + self.profession)


def show(people):
  people.hi()

juan = People("Juan", 30)
carlos = Student("Carlos", 24, "Developer")

# Polimorfismo
show(juan)
show(carlos)


