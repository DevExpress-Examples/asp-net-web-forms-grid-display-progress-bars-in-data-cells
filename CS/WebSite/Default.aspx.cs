using System;
using DevExpress.Web;
using System.Drawing;

public partial class _Default : System.Web.UI.Page {
    protected void pb_DataBound(object sender, EventArgs e) {
        ASPxProgressBar progressBar = (ASPxProgressBar)sender;

        if(progressBar.Position > 100)
            progressBar.Position = 100;

        if(progressBar.Position < 40)
            progressBar.IndicatorStyle.BackColor = Color.LightGreen;
        else if(progressBar.Position >= 40 && progressBar.Position < 75)
            progressBar.IndicatorStyle.BackColor = Color.Yellow;
        else if(progressBar.Position >= 75)
            progressBar.IndicatorStyle.BackColor = Color.Red;
    }
}