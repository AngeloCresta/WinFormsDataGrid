# WinFormsDataGrid
Legacy Windows Forms DataGrid for .Net Core

It's never a good idea to invest on a legacy deprecated control, but if you're still stuck on that for a particolar project ...
here you'll find something that let you move forward.

This Solution is based on .Net Framework (4.8.1) sources migrated to .Net Core 8 (targets: <TargetFrameworks>net481;net8.0-windows</TargetFrameworks>), and a sample demo project where you'll find how use it.

Running .Net8

![image](https://github.com/user-attachments/assets/8f27ddaf-015d-459b-a98a-deecadd9ffe3)


## The solution has been updated to .Net9 and.Net10
In .Net10, Microsoft, for binary compatibility reasons, introduced fake/empty DataGrid class (and others..); due to that, for this scenario, I've modified the Namespace.

Classes:
```
#if NET10_0_OR_GREATER
namespace System.Windows.Forms.Legacy
#else
namespace System.Windows.Forms
#endif
```
Designer file of the sample form:
```
#if NET10_0_OR_GREATER
using DataGrid = System.Windows.Forms.Legacy.DataGrid;
#else
using DataGrid = System.Windows.Forms.DataGrid;
#endif
```

Running .Net10

<img width="799" height="479" alt="image" src="https://github.com/user-attachments/assets/337b717a-5f06-4929-9282-7a7629863e0f" />

