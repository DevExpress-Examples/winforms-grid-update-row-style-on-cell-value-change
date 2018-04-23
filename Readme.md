# How to update a row's style immediately after a an inplace editor's value is changed


<p>To catch the moment when an end-user changes some value in its cell, please handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRepositoryRepositoryItem_EditValueChangedtopic">EditValueChanged </a> event of a corresponding RepositoryItem. To immediately post this value, you need to call the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsBaseBaseView_PostEditortopic">PostEditor </a> method of a corresponding container. </p><br />
<p>This example demonstrates this approach in action. Check/uncheck checkboxes and move sliders to see how rows colors will be changed.</p>

<br/>


