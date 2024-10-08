# Group-multiple-resources-in-MAUI-Scheduler

This sample demonstrates how to group multiple resources in MAUI Scheduler control within a .NET MAUI application. You'll also see how to assign events to these resources, add special time regions, and customize the appearance of the resource view.  

## Sample

```xaml
    <scheduler:SfScheduler x:Name="scheduler"
                           AppointmentsSource="{Binding CustomEvents}"
                           View="TimelineMonth"
                           AllowedViews="TimelineDay,TimelineWeek,TimelineMonth"
                           DisplayDate="{Binding DisplayDate}">
        <scheduler:SfScheduler.AppointmentMapping>
            <scheduler:SchedulerAppointmentMapping Subject="EventName"
                                                   StartTime="From"
                                                   EndTime="To"
                                                   Background="Background"
                                                   ResourceIds="ResourceIds"/>
        </scheduler:SfScheduler.AppointmentMapping>
        <scheduler:SfScheduler.ResourceView>
            <scheduler:SchedulerResourceView Resources="{Binding CustomResources}">
                <scheduler:SchedulerResourceView.HeaderTemplate>
                <DataTemplate>
                    <Border Background="{Binding Background}" Stroke="Black"
                            StrokeThickness="1">
                        <Label Text="{Binding Name}" VerticalOptions="CenterAndExpand"
                               HorizontalTextAlignment="Center"/>
                    </Border>
                </DataTemplate>
            </scheduler:SchedulerResourceView.HeaderTemplate>
                <scheduler:SchedulerResourceView.Mapping>
                    <scheduler:SchedulerResourceMapping Id="Id"
                                                        Name="Name"
                                                        Background="BackgroundColor"
                                                        Foreground="ForegroundColor" />
                </scheduler:SchedulerResourceView.Mapping>
            </scheduler:SchedulerResourceView>
        </scheduler:SfScheduler.ResourceView>
    </scheduler:SfScheduler>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
