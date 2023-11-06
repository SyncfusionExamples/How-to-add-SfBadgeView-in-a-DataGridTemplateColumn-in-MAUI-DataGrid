# How-to-add-SfBadgeView-in-a-DataGridTemplateColumn-in-MAUI-DataGrid

This article illustrates the process of integrating badges into a [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) with a [.NET MAUI BadgeView](https://www.syncfusion.com/maui-controls/maui-badge-view) application.

**Step 1: Initialize the DataGrid with ItemsSource Property**

In the .NET MAUI application, initialize the DataGrid and bind the `ItemsSource` property of the DataGrid to a respective collection in the ViewModel. This collection serves as the data source for the DataGrid.

**Step 2: Initialize Badge View within DataTemplate**

Set the [DataGridTemplateColumn](https://help.syncfusion.com/maui/datagrid/column-types#datagridtemplatecolumn) for the respective column and, within the DataTemplate of the DataGrid, initialize the [Badge View](https://www.syncfusion.com/maui-controls/maui-badge-view) control and configure its BadgeText property.

**Step 3: Customize Badge Appearance**

The BadgeView showcases a badge displaying the Count of the pending task. You can customize the badge appearance using the [BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeSettings) property.

**XAML:**

```xml

<!--?xml version="1.0" encoding="utf-8" ?-->
<contentpage xmlns="http://schemas.microsoft.com/dotnet/2021/maui" xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" xmlns:local="clr-namespace:MauiApp1" xmlns:datagrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid" xmlns:badge="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core" x:class="MauiApp1.MainPage">
   <contentpage.bindingcontext>
       <local:employeeinforepository>
   </local:employeeinforepository></contentpage.bindingcontext>

   <datagrid:sfdatagrid x:name="dataGrid" itemssource="{Binding OrderInfoCollection}" columnwidthmode="Auto">
       <datagrid:sfdatagrid.columns>
           <datagrid:datagridtemplatecolumn mappingname="TaskAssigned" headertext="Task Assigned">
               <datagrid:datagridtemplatecolumn.celltemplate>
                   <datatemplate>
                       <grid margin="50,0,0,0">
                           <grid.rowdefinitions>
                               <rowdefinition height="*">
                           </rowdefinition></grid.rowdefinitions>
                           <grid.columndefinitions>
                               <columndefinition width="50">
                               <columndefinition width="50">
                           </columndefinition></columndefinition></grid.columndefinitions>
                           <label horizontaloptions="Center" verticaloptions="Center" text="{Binding TaskAssigned}" grid.column="0" grid.row="0">
                           <badge:sfbadgeview badgetext="{Binding TaskPending}" horizontaloptions="Start" verticaloptions="Start">
                               <badge:sfbadgeview.badgesettings>
                                   <badge:badgesettings type="None" textcolor="Red" fontsize="12" fontattributes="Bold" cornerradius="10" position="TopRight" grid.column="1" grid.row="0">
                               </badge:badgesettings></badge:sfbadgeview.badgesettings>
                           </badge:sfbadgeview>
                       </label></grid>
                   </datatemplate>
               </datagrid:datagridtemplatecolumn.celltemplate>
           </datagrid:datagridtemplatecolumn>
       </datagrid:sfdatagrid.columns>
   </datagrid:sfdatagrid>
</contentpage>
```
