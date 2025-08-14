# 🎯 Guía de Estudio: Patrones de Diseño, SOLID y OOP en C#

## 📚 Índice
- [Programación Orientada a Objetos (OOP)](#programación-orientada-a-objetos-oop)
- [Principios SOLID](#principios-solid)
- [Patrones de Diseño](#patrones-de-diseño)
  - [Patrones Creacionales](#patrones-creacionales)
  - [Patrones Estructurales](#patrones-estructurales)
  - [Patrones de Comportamiento](#patrones-de-comportamiento)

---

## 🏗️ Programación Orientada a Objetos (OOP)

### 1. **Abstracción (Abstraction)**
La abstracción oculta la complejidad y muestra solo la funcionalidad esencial.

**Concepto Clave:** Simplificar sistemas complejos mostrando solo lo relevante.

**Ejemplo en C#:**
```csharp
public abstract class EmailService
{
    public abstract void SendEmail(string to, string subject, string body);
    public abstract bool ValidateEmail(string email);
}
```

### 2. **Encapsulación (Encapsulation)**
Agrupa datos y métodos relacionados en una sola unidad y controla el acceso.

**Concepto Clave:** "Ocultar información" - controlar cómo se accede y modifica el estado.

**Ejemplo en C#:**
```csharp
public class BankAccount
{
    private decimal _balance; // Campo privado
    
    public decimal Balance => _balance; // Propiedad de solo lectura
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            _balance += amount;
    }
}
```

### 3. **Herencia (Inheritance)**
Permite que una clase herede propiedades y métodos de otra clase.

**Concepto Clave:** Reutilización de código y establecimiento de jerarquías.

**Ejemplo en C#:**
```csharp
public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}
```

### 4. **Polimorfismo (Polymorphism)**
Permite que diferentes objetos respondan de manera diferente al mismo mensaje.

**Concepto Clave:** "Muchas formas" - un mismo método puede comportarse diferente según el objeto.

**Ejemplo en C#:**
```csharp
public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }
    public double CalculateArea() => Math.PI * Radius * Radius;
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double CalculateArea() => Width * Height;
}
```

### 5. **Composición (Composition)**
Construir objetos complejos combinando objetos más simples.

**Concepto Clave:** "Tiene-un" en lugar de "Es-un" - preferir composición sobre herencia.

**Ejemplo en C#:**
```csharp
public class Car
{
    private Engine _engine;
    private Chassis _chassis;
    
    public Car(Engine engine, Chassis chassis)
    {
        _engine = engine;
        _chassis = chassis;
    }
}
```

---

## 🔧 Principios SOLID

### 1. **S - Single Responsibility Principle (SRP)**
Una clase debe tener una sola razón para cambiar.

**Concepto Clave:** Una clase, una responsabilidad.

**❌ Mal Ejemplo:**
```csharp
public class User
{
    public void Save() { /* Lógica de persistencia */ }
    public void SendEmail() { /* Lógica de envío de email */ }
    public void Validate() { /* Lógica de validación */ }
}
```

**✅ Buen Ejemplo:**
```csharp
public class User { /* Solo propiedades del usuario */ }
public class UserService { public void Save(User user) { } }
public class EmailService { public void SendEmail(string to, string message) { } }
public class ValidationService { public bool Validate(User user) { } }
```

### 2. **O - Open/Closed Principle (OCP)**
Las entidades deben estar abiertas para extensión pero cerradas para modificación.

**Concepto Clave:** Extender sin modificar código existente.

**❌ Mal Ejemplo:**
```csharp
public class Shape
{
    public enum Type { Circle, Rectangle }
    public Type ShapeType { get; set; }
    
    public double CalculateArea()
    {
        switch (ShapeType)
        {
            case Type.Circle: return Math.PI * Radius * Radius;
            case Type.Rectangle: return Width * Height;
            default: throw new ArgumentException();
        }
    }
}
```

**✅ Buen Ejemplo:**
```csharp
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea() => Width * Height;
}
```

### 3. **L - Liskov Substitution Principle (LSP)**
Los objetos de una clase derivada deben poder sustituir objetos de la clase base.

**Concepto Clave:** Un subtipo debe ser sustituible por su tipo base.

**❌ Mal Ejemplo:**
```csharp
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
}

public class Square : Rectangle
{
    public override int Width
    {
        get => base.Width;
        set { base.Width = value; base.Height = value; }
    }
    
    public override int Height
    {
        get => base.Height;
        set { base.Width = value; base.Height = value; }
    }
}
```

**✅ Buen Ejemplo:**
```csharp
public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override double CalculateArea() => Width * Height;
}

public class Square : Shape
{
    public int Side { get; set; }
    public override double CalculateArea() => Side * Side;
}
```

### 4. **I - Interface Segregation Principle (ISP)**
Los clientes no deben verse forzados a depender de interfaces que no utilizan.

**Concepto Clave:** Interfaces pequeñas y específicas son mejores que una grande.

**❌ Mal Ejemplo:**
```csharp
public interface IShape
{
    double CalculateArea();
    double CalculateVolume(); // No todos los shapes tienen volumen
    void Draw(); // No todos los shapes se pueden dibujar
}
```

**✅ Buen Ejemplo:**
```csharp
public interface IShape2D
{
    double CalculateArea();
}

public interface IShape3D
{
    double CalculateVolume();
}

public interface IDrawable
{
    void Draw();
}
```

### 5. **D - Dependency Inversion Principle (DIP)**
Los módulos de alto nivel no deben depender de módulos de bajo nivel. Ambos deben depender de abstracciones.

**Concepto Clave:** Depender de abstracciones, no de implementaciones concretas.

**❌ Mal Ejemplo:**
```csharp
public class Car
{
    private Engine _engine = new Engine(); // Dependencia concreta
}
```

**✅ Buen Ejemplo:**
```csharp
public interface IEngine
{
    void Start();
}

public class Car
{
    private readonly IEngine _engine;
    
    public Car(IEngine engine) // Inyección de dependencia
    {
        _engine = engine;
    }
}
```

---

## 🎨 Patrones de Diseño

### 🚀 Patrones Creacionales

#### 1. **Singleton**
Asegura que una clase tenga solo una instancia y proporciona un punto de acceso global.

**Cuándo Usar:** Configuraciones globales, conexiones de base de datos, logging.

**Ejemplo:**
```csharp
public class AppSettings
{
    private static AppSettings _instance;
    private static readonly object _lock = new object();
    
    private AppSettings() { }
    
    public static AppSettings Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AppSettings();
                }
            }
            return _instance;
        }
    }
}
```

#### 2. **Factory Method**
Define una interfaz para crear objetos, pero deja que las subclases decidan qué clase instanciar.

**Cuándo Usar:** Cuando no se conoce el tipo exacto de objeto a crear.

**Ejemplo:**
```csharp
public abstract class ViewEngine
{
    public abstract string Render(string template);
}

public class BladeViewEngine : ViewEngine
{
    public override string Render(string template) => $"Blade: {template}";
}

public class TwigViewEngine : ViewEngine
{
    public override string Render(string template) => $"Twig: {template}";
}

public abstract class BackendFramework
{
    public abstract ViewEngine CreateViewEngine();
}
```

#### 3. **Abstract Factory**
Proporciona una interfaz para crear familias de objetos relacionados.

**Cuándo Usar:** Cuando necesitas crear familias de objetos relacionados.

**Ejemplo:**
```csharp
public interface IButton { void Render(); }
public interface ICheckbox { void Render(); }

public interface IUIComponentFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

public class MacUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckbox CreateCheckbox() => new MacCheckbox();
}
```

#### 4. **Builder**
Construye objetos complejos paso a paso.

**Cuándo Usar:** Cuando la construcción de un objeto es compleja o requiere muchos parámetros.

**Ejemplo:**
```csharp
public class Car
{
    public string Engine { get; set; }
    public string Transmission { get; set; }
    public string Wheels { get; set; }
}

public class CarBuilder
{
    private Car _car = new Car();
    
    public CarBuilder SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }
    
    public CarBuilder SetTransmission(string transmission)
    {
        _car.Transmission = transmission;
        return this;
    }
    
    public Car Build() => _car;
}
```

#### 5. **Prototype**
Crea nuevos objetos clonando un objeto existente.

**Cuándo Usar:** Cuando crear un objeto es costoso o complejo.

**Ejemplo:**
```csharp
public abstract class Shape : ICloneable
{
    public abstract Shape Clone();
    public abstract double CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public override Shape Clone()
    {
        return new Circle { Radius = this.Radius };
    }
    
    public override double CalculateArea() => Math.PI * Radius * Radius;
}
```

### 🏗️ Patrones Estructurales

#### 1. **Adapter**
Permite que interfaces incompatibles trabajen juntas.

**Cuándo Usar:** Cuando necesitas usar una clase existente cuya interfaz no es compatible.

**Ejemplo:**
```csharp
public interface IColor
{
    void ApplyColor();
}

public class ThirdPartyColorLibrary
{
    public void SetColor(string color) { }
}

public class ColorAdapter : IColor
{
    private ThirdPartyColorLibrary _library = new ThirdPartyColorLibrary();
    
    public void ApplyColor()
    {
        _library.SetColor("blue");
    }
}
```

#### 2. **Bridge**
Desacopla una abstracción de su implementación.

**Cuándo Usar:** Cuando quieres evitar un enlace permanente entre abstracción e implementación.

**Ejemplo:**
```csharp
public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

public abstract class RemoteControl
{
    protected IDevice _device;
    
    public RemoteControl(IDevice device)
    {
        _device = device;
    }
    
    public abstract void TurnOn();
    public abstract void TurnOff();
}
```

#### 3. **Composite**
Compose objetos en estructuras de árbol para representar jerarquías parte-todo.

**Cuándo Usar:** Cuando necesitas tratar objetos individuales y composiciones de manera uniforme.

**Ejemplo:**
```csharp
public abstract class Item
{
    public abstract double GetPrice();
    public abstract void Add(Item item);
    public abstract void Remove(Item item);
}

public class Product : Item
{
    private double _price;
    
    public Product(double price) => _price = price;
    
    public override double GetPrice() => _price;
    public override void Add(Item item) => throw new NotSupportedException();
    public override void Remove(Item item) => throw new NotSupportedException();
}

public class Box : Item
{
    private List<Item> _items = new List<Item>();
    
    public override double GetPrice() => _items.Sum(item => item.GetPrice());
    public override void Add(Item item) => _items.Add(item);
    public override void Remove(Item item) => _items.Remove(item);
}
```

#### 4. **Decorator**
Añade responsabilidades a objetos individuales dinámicamente.

**Cuándo Usar:** Cuando necesitas añadir funcionalidad a objetos sin alterar su clase.

**Ejemplo:**
```csharp
public abstract class Data
{
    public abstract string Read();
    public abstract void Write(string data);
}

public class CloudData : Data
{
    public override string Read() => "Cloud data";
    public override void Write(string data) { }
}

public abstract class DataDecorator : Data
{
    protected Data _data;
    
    public DataDecorator(Data data) => _data = data;
}

public class CompressionDecorator : DataDecorator
{
    public CompressionDecorator(Data data) : base(data) { }
    
    public override string Read() => $"Decompressed: {_data.Read()}";
    public override void Write(string data) => _data.Write($"Compressed: {data}");
}
```

#### 5. **Facade**
Proporciona una interfaz unificada a un conjunto de interfaces en un subsistema.

**Cuándo Usar:** Cuando quieres simplificar la interfaz con un subsistema complejo.

**Ejemplo:**
```csharp
public class OrderFacade
{
    private Authenticate _auth = new Authenticate();
    private Inventory _inventory = new Inventory();
    private OrderFulfillment _fulfillment = new OrderFulfillment();
    
    public bool ProcessOrder(string user, string product)
    {
        if (!_auth.ValidateUser(user)) return false;
        if (!_inventory.CheckAvailability(product)) return false;
        return _fulfillment.CreateOrder(user, product);
    }
}
```

#### 6. **Flyweight**
Comparte eficientemente objetos que son utilizados por múltiples contextos.

**Cuándo Usar:** Cuando tienes muchos objetos similares que consumen mucha memoria.

**Ejemplo:**
```csharp
public class CropIcon
{
    public string IconData { get; set; }
    
    public CropIcon(string iconData) => IconData = iconData;
}

public class CropIconFactory
{
    private Dictionary<string, CropIcon> _icons = new Dictionary<string, CropIcon>();
    
    public CropIcon GetIcon(string cropType)
    {
        if (!_icons.ContainsKey(cropType))
            _icons[cropType] = new CropIcon($"Icon for {cropType}");
        
        return _icons[cropType];
    }
}
```

#### 7. **Proxy**
Proporciona un sustituto o marcador de posición para otro objeto.

**Cuándo Usar:** Cuando quieres controlar el acceso a un objeto o añadir funcionalidad.

**Ejemplo:**
```csharp
public interface IVideo
{
    void Play();
}

public class YouTubeVideo : IVideo
{
    public void Play() => Console.WriteLine("Playing YouTube video");
}

public class YouTubeVideoProxy : IVideo
{
    private YouTubeVideo _video;
    
    public void Play()
    {
        if (_video == null)
            _video = new YouTubeVideo();
        
        _video.Play();
    }
}
```

### 🎭 Patrones de Comportamiento

#### 1. **Chain of Responsibility**
Pasa solicitudes a lo largo de una cadena de manejadores.

**Cuándo Usar:** Cuando quieres procesar una solicitud a través de múltiples objetos.

**Ejemplo:**
```csharp
public abstract class Handler
{
    protected Handler _next;
    
    public Handler SetNext(Handler next)
    {
        _next = next;
        return next;
    }
    
    public abstract void Handle(HttpRequest request);
}

public class Authenticator : Handler
{
    public override void Handle(HttpRequest request)
    {
        if (request.IsAuthenticated)
        {
            _next?.Handle(request);
        }
    }
}
```

#### 2. **Command**
Encapsula una solicitud como un objeto.

**Cuándo Usar:** Cuando quieres parametrizar objetos con operaciones.

**Ejemplo:**
```csharp
public interface ICommand
{
    void Execute();
    void Undo();
}

public class LightOnCommand : ICommand
{
    private Light _light;
    
    public LightOnCommand(Light light) => _light = light;
    
    public void Execute() => _light.TurnOn();
    public void Undo() => _light.TurnOff();
}
```

#### 3. **Interpreter**
Define una representación gramatical para un lenguaje.

**Cuándo Usar:** Cuando tienes un lenguaje simple que quieres interpretar.

**Ejemplo:**
```csharp
public interface IExpression
{
    int Interpret(Context context);
}

public class AdditionExpression : IExpression
{
    private IExpression _left;
    private IExpression _right;
    
    public AdditionExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }
    
    public int Interpret(Context context) => _left.Interpret(context) + _right.Interpret(context);
}
```

#### 4. **Iterator**
Proporciona una forma de acceder secuencialmente a los elementos de una colección.

**Cuándo Usar:** Cuando quieres acceder a una colección sin exponer su representación interna.

**Ejemplo:**
```csharp
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

public class ShoppingList
{
    private List<string> _items = new List<string>();
    
    public IIterator<string> CreateIterator() => new ShoppingListIterator(_items);
}

public class ShoppingListIterator : IIterator<string>
{
    private List<string> _items;
    private int _position = 0;
    
    public ShoppingListIterator(List<string> items) => _items = items;
    
    public bool HasNext() => _position < _items.Count;
    public string Next() => _items[_position++];
}
```

#### 5. **Mediator**
Define un objeto que encapsula cómo interactúan un conjunto de objetos.

**Cuándo Usar:** Cuando la comunicación entre objetos es compleja.

**Ejemplo:**
```csharp
public abstract class UIControl
{
    protected DialogBox _owner;
    
    public UIControl(DialogBox owner) => _owner = owner;
}

public class Button : UIControl
{
    public Button(DialogBox owner) : base(owner) { }
    
    public void Click() => _owner.ButtonClicked();
}

public class DialogBox
{
    private Button _button;
    private ListBox _listBox;
    
    public void ButtonClicked() => _listBox.Selection = "Button was clicked";
}
```

#### 6. **Memento**
Captura y externaliza el estado interno de un objeto.

**Cuándo Usar:** Cuando quieres guardar y restaurar el estado de un objeto.

**Ejemplo:**
```csharp
public class EditorState
{
    public string Content { get; }
    
    public EditorState(string content) => Content = content;
}

public class Editor
{
    private string _content = "";
    
    public void SetContent(string content) => _content = content;
    public string GetContent() => _content;
    public EditorState Save() => new EditorState(_content);
    public void Restore(EditorState state) => _content = state.Content;
}

public class History
{
    private Stack<EditorState> _states = new Stack<EditorState>();
    
    public void Push(EditorState state) => _states.Push(state);
    public EditorState Pop() => _states.Pop();
}
```

#### 7. **Observer**
Define una dependencia uno-a-muchos entre objetos.

**Cuándo Usar:** Cuando un cambio en un objeto requiere cambiar otros objetos.

**Ejemplo:**
```csharp
public interface IObserver
{
    void Update();
}

public class DataSource
{
    private List<IObserver> _observers = new List<IObserver>();
    private int _value;
    
    public void AddObserver(IObserver observer) => _observers.Add(observer);
    public void RemoveObserver(IObserver observer) => _observers.Remove(observer);
    
    public void SetValue(int value)
    {
        _value = value;
        NotifyObservers();
    }
    
    private void NotifyObservers()
    {
        foreach (var observer in _observers)
            observer.Update();
    }
}
```

#### 8. **State**
Permite que un objeto altere su comportamiento cuando su estado interno cambia.

**Cuándo Usar:** Cuando un objeto puede estar en varios estados y su comportamiento cambia.

**Ejemplo:**
```csharp
public abstract class DocumentState
{
    public abstract void Publish(Document document);
    public abstract void Review(Document document);
}

public class DraftState : DocumentState
{
    public override void Publish(Document document)
    {
        document.ChangeState(new PublishedState());
    }
    
    public override void Review(Document document)
    {
        document.ChangeState(new ModerationState());
    }
}
```

#### 9. **Strategy**
Define una familia de algoritmos, encapsula cada uno y los hace intercambiables.

**Cuándo Usar:** Cuando tienes múltiples algoritmos para la misma tarea.

**Ejemplo:**
```csharp
public interface ICompressionStrategy
{
    void Compress(string file);
}

public class MP4Compression : ICompressionStrategy
{
    public void Compress(string file) => Console.WriteLine($"Compressing {file} to MP4");
}

public class MOVCompression : ICompressionStrategy
{
    public void Compress(string file) => Console.WriteLine($"Compressing {file} to MOV");
}

public class VideoStorage
{
    private ICompressionStrategy _compressionStrategy;
    
    public void SetCompressionStrategy(ICompressionStrategy strategy)
    {
        _compressionStrategy = strategy;
    }
    
    public void Store(string file) => _compressionStrategy.Compress(file);
}
```

#### 10. **Template Method**
Define el esqueleto de un algoritmo en una operación, diferiendo algunos pasos a subclases.

**Cuándo Usar:** Cuando tienes un algoritmo con pasos que pueden variar.

**Ejemplo:**
```csharp
public abstract class Beverage
{
    public void Prepare()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }
    
    protected abstract void Brew();
    protected abstract void AddCondiments();
    
    private void BoilWater() => Console.WriteLine("Boiling water");
    private void PourInCup() => Console.WriteLine("Pouring into cup");
}

public class Coffee : Beverage
{
    protected override void Brew() => Console.WriteLine("Brewing coffee");
    protected override void AddCondiments() => Console.WriteLine("Adding sugar and milk");
}
```

#### 11. **Visitor**
Representa una operación a realizar en los elementos de una estructura de objetos.

**Cuándo Usar:** Cuando quieres añadir nuevas operaciones sin cambiar las clases de los elementos.

**Ejemplo:**
```csharp
public interface IVisitor
{
    void Visit(Client client);
    void Visit(Restaurant restaurant);
}

public class EmailVisitor : IVisitor
{
    public void Visit(Client client) => Console.WriteLine($"Sending email to client: {client.Name}");
    public void Visit(Restaurant restaurant) => Console.WriteLine($"Sending email to restaurant: {restaurant.Name}");
}

public interface IElement
{
    void Accept(IVisitor visitor);
}

public class Client : IElement
{
    public string Name { get; set; }
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}
```

---

## 🎯 Cuándo usar Cada Patrón

### **Patrones Creacionales:**
- **Singleton:** Configuraciones globales, conexiones únicas
- **Factory Method:** Creación de objetos sin especificar clases exactas
- **Abstract Factory:** Familias de objetos relacionados
- **Builder:** Objetos complejos con muchos parámetros
- **Prototype:** Clonación de objetos costosos

### **Patrones Estructurales:**
- **Adapter:** Interfaces incompatibles
- **Bridge:** Desacoplar abstracción de implementación
- **Composite:** Estructuras jerárquicas parte-todo
- **Decorator:** Añadir funcionalidad dinámicamente
- **Facade:** Simplificar subsistemas complejos
- **Flyweight:** Compartir objetos costosos
- **Proxy:** Control de acceso y funcionalidad adicional

### **Patrones de Comportamiento:**
- **Chain of Responsibility:** Procesamiento secuencial de solicitudes
- **Command:** Parametrizar objetos con operaciones
- **Interpreter:** Lenguajes simples
- **Iterator:** Acceso secuencial a colecciones
- **Mediator:** Comunicación compleja entre objetos
- **Memento:** Guardar y restaurar estado
- **Observer:** Notificaciones de cambios
- **State:** Comportamiento basado en estado
- **Strategy:** Algoritmos intercambiables
- **Template Method:** Algoritmos con pasos variables
- **Visitor:** Operaciones en estructuras de objetos

---

