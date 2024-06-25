<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632139/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3234)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to update a row's style immediately after a an inplace editor's value is changed


<p>To catch the moment when an end-user changes some value in its cell, please handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItem_EditValueChangedtopic">EditValueChanged </a> event of a corresponding RepositoryItem. To immediately post this value, you need to call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseBaseView_PostEditortopic">PostEditor </a> method of a corresponding container. </p><br />
<p>This example demonstrates this approach in action. Check/uncheck checkboxes and move sliders to see how rows colors will be changed.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-update-row-style-on-cell-value-change&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-update-row-style-on-cell-value-change&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
