# pasar parametros con nombres
def show(**kwargs):
  for key, value in kwargs.items():
    print(f"{key} {value}")

show(name = "Manuel", country = "Nicaragua", age = 23 )   