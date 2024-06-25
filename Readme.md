<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632139/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3234)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Update the row style immediately after changing a value in the cell editor

The example handles the [EditValueChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItem.EditValueChanged) event to respond to changing an editor's value. The example calls the [PostEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.PostEditor) method to save the modified value to a data source. Once the value is posted to a data source, the Data Grid control invalidates/repaints the cell. The [RowCellStyle](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.RowCellStyle) event is handled to customize row appearance settings based on a specific condition:

```csharp
void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e) {
    if (!true.Equals(gridView1.GetRowCellValue(e.RowHandle, "UseStyles")))
        return;
    e.Appearance.BackColor = GetRowBackColor(e.RowHandle);
}
```


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-update-row-style-on-cell-value-change&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-update-row-style-on-cell-value-change&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
