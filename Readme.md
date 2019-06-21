<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to implement ASPxProgressBar in DataCell with a custom color
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3943/)**
<!-- run online end -->


<p>This example demonstrates how to define <strong>ASPxProgressBar</strong> in a column's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>DataItemTemplate</u></a> and specify the progress bar color based on a custom criteria.</p><p>1) Define <strong>ASPxProgressBar</strong> in a grid column's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>DataItemTemplate</u></a>;</p><p>2) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxClassesASPxDataWebControlBase_DataBoundtopic"><u>ASPxProgressBar.</u><u>DataBound</u></a> event and set color via the <strong>ASPxProgressBar.IndicatorStyle.BackColor</strong> property based on a column value (or another custom criteria).</p>

<br/>


