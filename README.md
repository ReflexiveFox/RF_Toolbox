# RF_Toolbox

**RF_Toolbox** is a personal utility library for Unity designed to enhance workflow and provide reusable tools for common game development tasks. This toolbox helps streamline your project setup by offering well-organized, modular, and customizable scripts.

---

## **Folder Structure**

The RF_Toolbox is organized into the following directories:

### **/Extensions/**
- Contains extension methods for Unity's built-in types (e.g., `Vector3`, `Transform`, `GameObject`).
- Examples:
  - `Vector3.ClampMagnitude()`
  - `Transform.ResetTransform()`

### **/Helpers/**
- Includes general-purpose utility classes and functions to simplify development.
- Examples:
  - `MathUtilities` for grid snapping and other math operations.
  - `DebugLogger` for centralized logging with additional context.

### **/Attributes/**
- Custom attributes for enhancing the Unity Inspector experience.
- Examples:
  - `ReadOnlyAttribute` for making fields non-editable in the Inspector.
  - `ButtonAttribute` for adding actionable buttons to the Inspector.

### **/Events/**
- Provides reusable classes and patterns for event management.
- Examples:
  - `EventManager` for managing custom game events.
  - `RFEvent` for passing event data.

### **/Managers/**
- Houses scripts for managing game systems like input, game states, or UI.
- Examples:
  - `InputManager` for handling player inputs.
  - `GameManager` for centralized game logic.

### **/RF_ToolboxEditor/**
- Contains custom editor tools, property drawers, and utility scripts for the Unity Editor.
- Examples:
  - Custom property drawers for attributes like `ReadOnlyAttribute`.
  - Custom editor windows for batch operations.

---

## **Usage**

### **How to Use RF_Toolbox**
1. Place the `RF_Toolbox` folder into your Unity project under the `Assets` directory.
2. Use the scripts and utilities as needed in your project.
3. Extend the toolbox with your own utilities or modifications.

### **Namespace**
All scripts are under the `RF_Toolbox` namespace. Be sure to include it in your scripts:
```csharp
using RF_Toolbox;
```

### **Examples**
#### **Using Extensions**
```csharp
using RF_Toolbox.Extensions;

void Example()
{
    Vector3 position = new Vector3(10f, 5f, 0f);
    position = position.ClampMagnitude(5f);
    Debug.Log(position);
}
```

#### **Using DebugLogger**
```csharp
using RF_Toolbox.Helpers;

void LogExample()
{
    DebugLogger.Log("This is a test message.");
}
```

---

## **Contributing**
Feel free to extend or modify RF_Toolbox to suit your project's needs. As this is a personal toolbox, it is designed to be flexible and adaptable.

---

## **Future Improvements**
- Add more attributes for Inspector customization.
- Expand the Helpers library with additional utilities.
- Develop more advanced Editor tools.

---

For any questions or suggestions, feel free to reach out or add new features directly to RF_Toolbox!
