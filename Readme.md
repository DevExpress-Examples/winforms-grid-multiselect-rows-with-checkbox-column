<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632187/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E990)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - How to use an unbound checkbox column to select data rows

The [Grid View](https://docs.devexpress.com/WindowsForms/3464/controls-and-libraries/data-grid/views/grid-view) in the [Data Grid](https://docs.devexpress.com/WindowsForms/3455/controls-and-libraries/data-grid) control can display a built-in checkbox column. Users can use the checkbox column to select multiple rows.

Do the following to enable the checkbox column:
- Enable the [View.OptionsSelection.MultiSelect](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect) option.
- Set the [View.OptionsSelection.MultiSelectMode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode) property to `CheckBoxRowSelect`.

In v18.1+, you can sync row selected states with a Boolean field in the bound data source. A checkbox column's bound mode ensures that row selection persists whenever you filter or group grid data.

Read the following topic for more information: [Multiple Row Selection Using Built-In Check Column and Selection Binding](https://docs.devexpress.com/WindowsForms/16439/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-selection-via-built-in-check-column-and-selection-binding).

## Documentation

* [Multiple Row Selection Using Built-In Check Column and Selection Binding](https://docs.devexpress.com/WindowsForms/16439/controls-and-libraries/data-grid/focus-and-selection-handling/multiple-row-selection-via-built-in-check-column-and-selection-binding)
* [View.OptionsSelection.MultiSelect](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect)
* [View.OptionsSelection.MultiSelectMode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-multiselect-rows-with-checkbox-column&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-multiselect-rows-with-checkbox-column&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
