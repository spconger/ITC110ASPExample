using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //postback is every time the page returns to the server
        //after the first time
        if (!IsPostBack)
        {
            PopulateEntree();
            PopulateDrinks();
        }
    }

    protected void PopulateEntree()
    {
        //create an array
        string[] entree = {"Hamburger",
            "Mac and Cheese", "Corn Dogs", "Spaghetti", "French Dip" };
        //bind the array to the checklist control
        CBLEntree.DataSource = entree;
        CBLEntree.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //declare an instance of the mealorder
        MealOrder meal = new MealOrder();
        //add the checked meaks to the meal list in the class
        foreach(ListItem item in CBLEntree.Items)
        {
            if(item.Selected)
            {
                meal.AddEntree(item.Text);
            }
        }//end of foreach
        //add the drinks
        foreach(ListItem item in CBLDrinks.Items)
        {
            if (item.Selected)
            {
                meal.AddDrink(item.Text);
            }
        }//end of foreach
        Session["Meal"] = meal;
        Response.Redirect("Receipt.aspx");
    }//end of the button

    protected void PopulateDrinks()
    {
        string[] drinks ={ "sodas", "milkshake","coffee", "tea",
        "juice"};
        CBLDrinks.DataSource = drinks;
        CBLDrinks.DataBind();
    }
}