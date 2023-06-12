using System;
using System.Security.Policy;

public class BankAccount 
{
    private string v1;
    private int v2;

    public BankAccount(string v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public  string Number { get; } = String.Empty;

        public  string? Owner { get; set; }
            public  decimal Balance { get; }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="date"></param>
    /// <param name="note"></param>
    // paaa//
    //test//
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }
    public void MainWithdrawal ( decimal amount, DateTime date, string note )
    {

    }
}