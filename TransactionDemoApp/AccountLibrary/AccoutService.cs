﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Transactions;

namespace AccountLibrary
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    [ServiceBehavior(TransactionIsolationLevel=System.Transactions.IsolationLevel.Serializable)]
    public class AccoutService : IAccoutService
    {

        #region IAccoutService Members

        [OperationBehavior(TransactionScopeRequired=true, TransactionAutoComplete=true)]
        public void Deposit(int accountId, decimal amount)
        {
            TransactionInformation info = Transaction.Current.TransactionInformation;
            Console.WriteLine("Deposit Method distributed tx ID: {0}.", info.DistributedIdentifier);
            Console.WriteLine("Deposit Method tx status: {0}.", info.Status);
            
            SqlConnection con = new SqlConnection(Helper.ConnectionString1);
            string sql;
            sql = string.Format("Update Account set Balance = Balance + {0} where AccountId={1}", amount, accountId);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }         
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void Withdraw(int accountId, decimal amount)
        {
            TransactionInformation info = Transaction.Current.TransactionInformation;
            Console.WriteLine("Withdraw Method distributed tx ID: {0}.", info.DistributedIdentifier);
            Console.WriteLine("Withdraw Method tx status: {0}.", info.Status);
            
            SqlConnection con = new SqlConnection(Helper.ConnectionString1);
            string sql;
            sql = "Select Balance from Account where AccountId=" + accountId;
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                decimal currentBalance = Convert.ToDecimal(cmd.ExecuteScalar());
                if (currentBalance - amount < 500)
                    throw new FaultException("Insufficient funds");
                sql = string.Format("Update Account set Balance = Balance - {0} where AccountId={1}", amount, accountId);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }            
        }

        #endregion
    }
}
