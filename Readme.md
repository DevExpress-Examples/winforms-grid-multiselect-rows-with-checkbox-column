<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632187/13.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E990)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WebStyleRowSelection/Form1.cs) (VB: [Form1.vb](./VB/WebStyleRowSelection/Form1.vb))
<!-- default file list end -->
# How to use an unbound check box column to select grid rows


<p>Starting with version 13.2, <strong>GridView</strong> provides a built-in checkbox column for multiple row selection. To enable this type of multiple row selection in newer versions, it is sufficient to enable the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsSelection.MultiSelect.property"><strong>GridViewOptionsSelection.MultiSelect</strong></a><strong> </strong>option and then set the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode.property"><strong>GridView.OptionsSelection.MultiSelectMode</strong></a><strong> </strong>property to the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.enum"><strong>GridMultiSelectMode.CheckBoxRowSelect</strong></a><strong> </strong>value. </p>

Starting with version **18.1**, in multiple row selection mode, you can sync row selected states with a Boolean field in the bound data source. The selection binding mode ensures that row selection persists whenever you filter or group grid data. Refer to the [Multiple Row Selection via Built-In Check Column and Selection Binding](https://documentation.devexpress.com/WindowsForms/16439/Controls-and-Libraries/Data-Grid/Focus-and-Selection-Handling/Multiple-Row-Selection-via-Built-In-Check-Column-and-Selection-Binding) help article for more information.

## ***If you still prefer the custom approach described below, please clarify why the built-in solution is not suitable for you. Just click   [here](https://www.devexpress.com/Support/Center/Question/Create) to submit a ticket to our Support Center.***

**For earlier versions:**
<p>Refer to the <a href="https://www.devexpress.com/Support/Center/p/E1271"><strong>Multiple selection using checkbox (web style)</strong></a><strong> </strong>example which demonstrates a method to manually create a check column for row selection. </p>

<br/>


