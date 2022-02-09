<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632187/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E990)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for Windows Forms - How to use an unbound check box column to select grid rows

The [Grid View](https://docs.devexpress.com/WindowsForms/3464/controls-and-libraries/data-grid/views/grid-view) in the [Data Grid](https://docs.devexpress.com/WindowsForms/3455/controls-and-libraries/data-grid) control supports a built-in checkbox column for multiple row selection. 
Set the following properties as follows to enable this checkbox column:
- [View.OptionsSelection.MultiSelect](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect) property to `true`.
- [View.OptionsSelection.MultiSelectMode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode) property to `CheckBoxRowSelect`.

In v18.1 and later versions, you can sync row selected states with a Boolean field in the bound data source. A checkbox column's bound mode ensures that row selection persists whenever you filter or group grid data. See the following topic for more information: [Multiple Row Selection via Built-In Check Column and Selection Binding](https://docs.devexpress.com/WindowsForms/16439/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-selection-via-built-in-check-column-and-selection-binding)

## Documentation
- [Multiple Row Selection via Built-In Check Column and Selection Binding](https://docs.devexpress.com/WindowsForms/16439/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-selection-via-built-in-check-column-and-selection-binding)
- [View.OptionsSelection.MultiSelect](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect)
- [View.OptionsSelection.MultiSelectMode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode)
