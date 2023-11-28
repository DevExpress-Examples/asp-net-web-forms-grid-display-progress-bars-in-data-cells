<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128534596/11.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3943)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to implement ASPxProgressBar in DataCell with a custom color
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/128534596/)**
<!-- run online end -->


<p>This example demonstrates how to define <strong>ASPxProgressBar</strong> in a column's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>DataItemTemplate</u></a> and specify the progress bar color based on a custom criteria.</p><p>1) Define <strong>ASPxProgressBar</strong> in a grid column's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>DataItemTemplate</u></a>;</p><p>2) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxClassesASPxDataWebControlBase_DataBoundtopic"><u>ASPxProgressBar.</u><u>DataBound</u></a> event and set color via the <strong>ASPxProgressBar.IndicatorStyle.BackColor</strong> property based on a column value (or another custom criteria).</p>

<br/>


