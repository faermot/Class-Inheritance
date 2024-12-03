using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.Utils
{
    public class BankAccount
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма депозита должна быть положительной.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Депозит: {amount}. Баланс: {Balance}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть положительной.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Недостаточно средств.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Снятие: {amount}. Баланс: {Balance}");
        }
    }

    public class SavingsAccount : BankAccount
    {
        private const decimal WithdrawalFee = 2.00m;

        public override void Withdraw(decimal amount)
        {
            decimal totalAmount = amount + WithdrawalFee;
            if (totalAmount > Balance)
            {
                Console.WriteLine($"Недостаточно средств для снятия {amount} с учетом комиссии {WithdrawalFee}.");
                return;
            }
            Balance -= totalAmount;
            Console.WriteLine($"Снятие: {amount}. Комиссия: {WithdrawalFee}. Баланс: {Balance}");
        }
    }

    public class CheckingAccount : BankAccount
    {
        private const decimal OverdraftLimit = -500.00m;

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount < OverdraftLimit)
            {
                Console.WriteLine("Превышен лимит овердрафта.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Снятие: {amount}. Баланс: {Balance}");
        }
    }
}
