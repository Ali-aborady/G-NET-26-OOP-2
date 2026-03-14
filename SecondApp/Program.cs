using System.Net.Sockets;

namespace SecondApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 : Consider the following class:
            //==================================================
            //    public class BankAccount
            //{
            //    public string Owner;
            //    public double Balance;
            //    public void Withdraw(double amount)
            //    {
            //        Balance -= amount;
            //    }
            //}
            //==================================================
            //a) Identify at least two problems with this design from an encapsulation perspective ?

            //1. Direct Field Access: The Owner and Balance fields are public.
            //This allows any external code to modify the balance to an invalid state without validation.
            //
            //2. Lack of Data Integrity: The Withdraw method does not check if the amount is greater than the current Balance, 
            //which could result in a negative balance.


            //b) Describe how you would fix this class to follow proper encapsulation
            //principles.You do not need to write the full code ?

            //1. Change the fields to private and provide public properties with logic.
            //the Balance property should have a private set to ensure it only changes through authorized methods like Withdraw or Deposit.


            //c) Explain why exposing fields directly(as public) is considered a bad
            //practice in OOP ?

            //Exposing fields directly breaks the "black box" principle of OOP.
            //It prevents you from adding validation logic later without breaking external code that relies on those fields,
            //and it exposes the internal implementation details of the class.

            #endregion

            #region Q2:Fields vs. Properties
            //field is a variable declared directly in a class to store data.
            //property is a member that provides a flexible mechanism to read, write, or compute the value of a private field
            //properties can contain logic within their get and set accessors.
            #endregion

            #region Q3 : Look at the following code and answer the questions below:
            //=====================================================================
            //    public class StudentRegister
            //    {
            //      private string[] names = new string[5];
            //      public string this[int index]
            //      {
            //          get { return names[index]; }
            //          set { names[index] = value; }
            //      }
            //    }
            //=====================================================================
            //a) What is `this[int index]` called? Explain its purpose.
            //It allows instances of a class to be indexed just like arrays,
            //making the object act as a collection of data.

            //b) What happens if someone writes `register[10] = "Ali";` ? How would you
            //make the indexer safer ?

            //c) Can a class have more than one indexer? If yes, give an example of when
            //that would be useful.




            #endregion


        }
    }
}  
   
