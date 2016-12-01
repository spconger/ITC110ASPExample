using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MealOrder
/// </summary>
public class MealOrder
{
    /// <summary>
    /// This class bundles the information about
    /// the meal. Specifically it keeps a list
    /// of the entrees and ahd drinks
    /// it has methods for adding items to these
    /// two lists.
    /// It also has a fairly unrealistic calculate
    /// method to figure out the total
    /// </summary>
    /// 
    //create public properties of the lists
    public List<string> Entrees { set; get; }
    public List<string> Drinks { set; get; }
    //initialize lists in the constructor
    public MealOrder()
    {
        Entrees = new List<string>();
        Drinks = new List<string>();
    }

    //add entrees to list
    public void AddEntree(string item)
    {
        Entrees.Add(item);
    }

    //add drinks
    public void AddDrink(string item)
    {
        Drinks.Add(item);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach(string entree in Entrees)
        {
            total += 2.99;
        }
        foreach(string drink in Drinks)
        {
            total += .99;
        }
        return total;
    }
}