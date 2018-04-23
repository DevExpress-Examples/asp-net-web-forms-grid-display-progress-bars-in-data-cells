# ASPxGridView - How to implement ASPxProgressBar in DataCell with a custom color


<p>This example demonstrates how to define <strong>ASPxProgressBar</strong> in a column's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>DataItemTemplate</u></a> and specify the progress bar color based on a custom criteria.</p><p>1) Define <strong>ASPxProgressBar</strong> in a grid column's <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewDataColumn_DataItemTemplatetopic"><u>DataItemTemplate</u></a>;</p><p>2) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxClassesASPxDataWebControlBase_DataBoundtopic"><u>ASPxProgressBar.</u><u>DataBound</u></a> event and set color via the <strong>ASPxProgressBar.IndicatorStyle.BackColor</strong> property based on a column value (or another custom criteria).</p>

<br/>

