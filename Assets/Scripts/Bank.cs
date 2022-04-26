using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    
    [SerializeField] int currentBalance;

     void Awake()
    {
        currentBalance = startingBalance;
    }

    public int CurrentBalance {get { return currentBalance; } }//we can access our current balance from outside the script(read) but we cant set it.
  
    public void deposit(int amount)
    {
        
        currentBalance += Mathf.Abs (amount);//returns the absolute value, if we pass in a negitive number it will be turned to a positive number and then added to our bank account.
        //currentBalance = currentBalance + amount; were depositing so were adding to are current account.
    }

    public void withdraw(int amountTwo)
    {
        currentBalance -= Mathf.Abs(amountTwo); //will do the same if its 10 it will withdrawn 10 from our accpount, but if it is -10 mathf.abs will convert it to 10 and minus it from our account.
    }
}
