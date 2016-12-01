using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //make sure the session variable exists
        if(Session["Meal"]==null)
        {
            //otherwise return to the menu page
            Response.Redirect("Default.aspx");
        }
        DisplayReceipt();
    }

    protected void DisplayReceipt()
    {
        //the stringbuilder is an object that
        //allows you to build complex strings
        //It is easier than concatinating
        StringBuilder sb = new StringBuilder();
        //get the MealOrder class from the session
        //it has to be cast from type "object"
        MealOrder meal = (MealOrder)Session["Meal"];
        //copy the lists from the object
        List<string> entrees = meal.Entrees;
        List<string> drinks = meal.Drinks;
        //loop through to get the values
        foreach(string entree in entrees)
        {
            sb.Append(entree);
            sb.Append("<br/>");
        }
        foreach (string drink in drinks)
        {
            sb.Append(drink);
            sb.Append("<br/>");
        }
        //get the total
        sb.Append(meal.CalculateTotal().ToString());
        //display the string
        Label1.Text = sb.ToString();

    }
}