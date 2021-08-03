# Solution Tracer
Logging almost every code.

# Steps
1. Install **Tracer.Fody** package from nuget. **FodyWeavers.xml** will be added to the project's folder.  
2. **NLog** is used to log in this project, so Install **Tracer.4NLog.Fody** package from nuget.
3. **NLog.config** is added to the project and "Copy Always" is selected from Properties.
4. **FodyWeavers.xml** is configured as desired.
5. After executing the program, **file.txt** will be found in the folder where .exe is located.

# Original Code
```csharp
static void Main(string[] args)
{
  var user1 = AddUser(1, "12345678912"); //valid phone number
  var user2 = AddUser(2, "123"); //invalid phone number

  var isPhoneValid = user1.IsPhoneValid();
  isPhoneValid = user2.IsPhoneValid();
}
```

# Generated Code (ILSpy)
```csharp
private static void Main(string[] args)
{
  string[] array = new string[1];
  object[] array2 = new object[1];
  array[0] = "args";
  array2[0] = args;
  $log.TraceEnter("Main(String[])", null, array, array2);
  long timestamp = Stopwatch.GetTimestamp();
  try
  {
    User user1 = AddUser(1, "12345678912");
    User user2 = AddUser(2, "123");
    bool isPhoneValid = user1.IsPhoneValid();
    isPhoneValid = user2.IsPhoneValid();
  }
  catch (Exception ex)
  {
    array = new string[1];
    array2 = new object[1];
    array[0] = "$exception";
    array2[0] = ex;
    $log.TraceLeave("Main(String[])", null, timestamp, Stopwatch.GetTimestamp(), array, array2);
    throw;
  }
  $log.TraceLeave("Main(String[])", null, timestamp, Stopwatch.GetTimestamp(), null, null);
}
```

# Dependencies
- NLog
- Fody
- Tracer.Fody
- Tracer.4NLog.Fody
