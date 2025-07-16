class SMS:
    def send(self):
        print(f"Sending SMS")

class Saver:
    def save(self):
        print(f"Saving message")

class Email:
    def send(self):
        print("Se envia mensaje por email")

class Sale(Email, SMS, Saver):
    pass

sale = Sale()
sale.send()
sale.save()
