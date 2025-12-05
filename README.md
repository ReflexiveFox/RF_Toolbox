# RF_Toolbox

**RF_Toolbox** is a personal utility library for Unity designed to enhance workflow and provide reusable tools for common game development tasks. This toolbox helps streamline your project setup by offering well-organized, modular, and customizable scripts.

---

## Installation (Unity Package Manager)

You can add RF_Toolbox directly through Unity's Package Manager instead of copying files into `Assets`.

- **Add from Git URL**
  1. Open **Window > Package Manager**.
  2. Click the **+** button and choose **Add package from git URL...**.
  3. Enter the repository URL, e.g.:
     ```
     https://github.com/ReflexiveFox/RF_Toolbox.git
     ```
- **Using a scoped registry (if you host the package)**
  1. Add a scoped registry entry to your project's `Packages/manifest.json`:
     ```json
     {
       "scopedRegistries": [
         {
           "name": "RF",
           "url": "https://your.registry.url/", // replace with your registry
           "scopes": ["com.rf"]
         }
       ],
       "dependencies": {
         "com.rf.toolbox": "1.0.0"
       }
     }
     ```
  2. Open **Package Manager** and install **RF Toolbox** from the **My Registries** list.

---

## Folder Structure

The current package layout is minimal and contained entirely within the **Runtime** assembly.

### `Runtime/Debugger`
- `RFLogger` provides lightweight logging helpers for runtime debugging.

---

## Usage

### Namespace
Runtime scripts live under the `RF_Toolbox` namespaces. Include the one you need in your scripts:
```csharp
using RF_Toolbox.Utilities;
```

### Example
```csharp
using RF_Toolbox.Utilities;

void LogExample()
{
    RFLogger.Log("This is a test message.");
}
```

---

## Contributing
Feel free to extend or modify RF_Toolbox to suit your project's needs. As this is a personal toolbox, it is designed to be flexible and adaptable.

---

## Future Improvements
- Add more attributes for Inspector customization.
- Expand the Helpers library with additional utilities.
- Develop more advanced Editor tools.

---

For any questions or suggestions, feel free to reach out or add new features directly to ReflexiveFox!
