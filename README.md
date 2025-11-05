# How to Set Desired Names for Property Items in WPF PropertyGrid Using Attributes
## Overview
In WPF applications, the PropertyGrid control is a powerful tool for displaying and editing the properties of an object. However, by default, it shows raw property names, which may not be user-friendly. To improve the user experience, you can customize these display names using attributes.

Syncfusion’s WPF PropertyGrid supports this customization through the use of the DisplayName and Name attributes.

## Customizing Property Names with DisplayName
To set a custom name for a property item, decorate the property in your model class with the DisplayName attribute from the System.ComponentModel namespace. This attribute overrides the default property name shown in the grid.
### Example
```csharp
using System.ComponentModel;

public class Employee
{
    [DisplayName("Employee Name")]
    public string Name { get; set; }

    [DisplayName("Employee Age")]
    public int Age { get; set; }

    [DisplayName("Department")]
    public string Dept { get; set; }
}
```
When this class is bound to the Syncfusion PropertyGrid, the grid will display:
- Employee Name
- Employee Age
- Department

instead of the actual property names (Name, Age, Dept). This makes the UI more intuitive and readable for end users.
