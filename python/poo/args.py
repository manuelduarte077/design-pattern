def add(*args):
  total = 0

  for number in args:
    total += number

  return total

res1 = add(1,2,3)
res2 = add(1,7,3,4)

print(f"Resultado {res1}")