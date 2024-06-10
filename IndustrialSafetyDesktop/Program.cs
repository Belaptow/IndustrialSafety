// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Process core = null;
Process client = null;
try
{
    core = Process.Start("IndustrialSafety.exe");
    client = Process.Start("IndustrialSafetyWrapper-win32-x64\\IndustrialSafetyWrapper.exe");
    client.WaitForExit();
}
catch(Exception ex)
{
    
}
finally
{
    if (core != null) core.Kill();
    if (client != null) client.Kill();
}