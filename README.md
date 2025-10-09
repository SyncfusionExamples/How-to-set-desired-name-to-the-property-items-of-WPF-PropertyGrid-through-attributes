# How-to-set-desired-name-to-the-property-items-of-WPF-PropertyGrid-through-attributes
In WPF applications, the PropertyGrid control is a powerful tool for displaying and editing properties of an object. However, by default, it shows the raw property names, which may not be user-friendly. To enhance the user experience, you can customize the display names of these properties using attributes. Syncfusion’s WPF PropertyGrid supports this customization through the use of the DisplayName and Name attributes.
To set a desired name for a property item, you decorate the property in your model class with the DisplayName attribute from the System.ComponentModel namespace. This attribute overrides the default property name shown in the grid. For example:

```csharp
using System.ComponentModel;
public class Employee
{
    [DisplayNameAttribute("Employee Name")]
    public string Name { get; set; }
    [DisplayNameAttribute("Employee Age")]
    public int Age { get; set; }
    [DisplayNameAttribute("Department")]
    public string Dept { get; set; }
}
```

When this class is bound to the Syncfusion PropertyGrid, the grid will display "Employee Name", "Employee Age", and "Department" instead of the actual property names. This makes the UI more intuitive and readable for end users.
The GitHub repository also demonstrates how to use the Name attribute to further customize the property labels. This is particularly useful when you want to localize or format property names differently depending on context.
To implement this in your WPF project, ensure you have the Syncfusion WPF toolkit installed and reference the appropriate namespaces. Then, bind your object to the PropertyGrid and use attributes as shown above.
This approach is clean, declarative, and maintains separation between your data model and UI presentation logic. It’s ideal for enterprise applications where clarity and customization are key.
