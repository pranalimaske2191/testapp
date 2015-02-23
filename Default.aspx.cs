using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    dataservice d = new dataservice();
    propertyservice p = new propertyservice();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fillgrid();
        }

    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
  
    public void fillgrid()
    {
        DetailsView1.DataSource = d.getdata();
        DetailsView1.DataBind();
    }



    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {

       
    }
    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        TextBox txtifname = (TextBox)DetailsView1.FindControl("TextBox4");
        TextBox txtilname = (TextBox)DetailsView1.FindControl("TextBox6");
        p.fname = txtifname.Text;
        p.lname = txtilname.Text;
        d.insertdata(p);
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
        fillgrid();
    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        TextBox txtid = (TextBox)DetailsView1.FindControl("TextBox7");
        TextBox txtefname = (TextBox)DetailsView1.FindControl("TextBox3");
        TextBox txtelname = (TextBox)DetailsView1.FindControl("TextBox5");
        p.id = Convert.ToInt16(txtid.Text);
        p.fname = txtefname.Text;
        p.lname = txtelname.Text;
        d.updatedata(p);
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
        fillgrid();
    }
    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        
        DetailsView1.ChangeMode(e.NewMode);
        fillgrid();

    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        DetailsView1.PageIndex = e.NewPageIndex;
        fillgrid();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        p.fname = TextBox1.Text;
        p.lname = TextBox2.Text;
        d.insertdata(p);
        fillgrid();
    }
}