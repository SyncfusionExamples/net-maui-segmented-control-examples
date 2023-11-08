# Getting Started with .NET MAUI Segmented Control (SfSegmentedControl)
25 Sep 20234 minutes to read

This section provides a quick overview of how to get started with the .NET MAUI Segmented control (SfSegmentedControl) for .NET MAUI and a walk-through to configure the .NET MAUI Segmented control in a real-time scenario.

#  Creating an Application using the .NET MAUI Segmented Control
1. Create a new .NET MAUI application in Visual Studio.

2. Syncfusion .NET MAUI components are available in nuget.org. To add the SfDataForm to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Buttons, then install it.

3. To initialize the control, import the control namespace Syncfusion.Maui.Buttons in XAML or C# code.

4.  Initialize SfSegmentedControl.

**[XAML]**
```
<ContentPage  xmlns:buttons="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"
        <buttons:SfSegmentedControl />
</ContentPage>
```

Populating segmented items
You can use ItemsSource property of SfSegmentedControl to populate the segmented items.

**[XAML]**
```
    <buttons:SfSegmentedControl x:Name="segmentedControl">
        <buttons:SfSegmentedControl.ItemsSource>
            <x:Array Type="{x:Type x:String}">
                <x:String>Day</x:String>
                <x:String>Week</x:String>
                <x:String>Month</x:String>
                <x:String>Year</x:String>
            </x:Array>
        </buttons:SfSegmentedControl.ItemsSource>
    </buttons:SfSegmentedControl>
```

## How to run this application?

To run this application, you need to first clone the net-maui-segmented-control-examples repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
