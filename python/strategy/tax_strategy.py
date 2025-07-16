from abc import ABC, abstractmethod

class TaxStrategy(ABC):
  @abstractmethod
  def calculate(self, amount: float) -> float:
    pass

class IVAStrategy(TaxStrategy):
  def calculate(self, amount: float) -> float:
    return amount * 0.15

class InatecStrategy(TaxStrategy):
  def calculate(self, amount: float) -> float:
    return amount * 0.10
  
# clase contexto
class TaxtCalculator:
  def __init__(self, strategy: TaxStrategy):
    self._strategy = strategy

  def set_strategy(self, strategy: TaxStrategy):
    self._strategy = strategy

  def calculate(self, amounts: list[float]) -> list[float]:
    taxes = []  
    for amount in amounts:
      taxes.append(self._strategy.calculate(amount))
    return taxes


amounts = [100, 20, 48]
iva_strategy = IVAStrategy()
inatec_strategy = InatecStrategy()
tax_calculator =  TaxtCalculator(iva_strategy)

print(tax_calculator.calculate(amounts))

tax_calculator.set_strategy(inatec_strategy)
print(tax_calculator.calculate(amounts))