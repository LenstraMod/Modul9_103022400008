namespace Modul9_103022400008;

public class Program {
    public static void Main(string[] args)
    { 
    
        BankTransferConfig config = new BankTransferConfig();

        config.setDefaultJSON();

        if (config.config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer: ");
        }
        else {
            Console.Write("“Masukkan jumlah uang yang akan ditransfer: ");
        }

        double tfMoney = Convert.ToInt32(Console.ReadLine());

        double tfDefault = 0;

        if (tfMoney <= config.config.transfer.threshold) {
            tfDefault = config.config.transfer.low;
        }
        else {
            tfDefault = config.config.transfer.high;
        }

        if (config.config.lang == "en")
        {
            Console.WriteLine("Transfer Fee = " + tfDefault);
            Console.WriteLine("Amount = " + (tfMoney + tfDefault));
            Console.WriteLine("Select Transfer Method: ");
        }
        else {
            Console.WriteLine("Biaya Transfer = " + tfDefault);
            Console.WriteLine("Total Biaya = " + (tfMoney + tfDefault));
            Console.WriteLine("Pilih Metoder Transfer: ");
        }

        for (int i = 0; i < config.config.Method.Count(); i++) {
            Console.WriteLine((i + 1) + " " + config.config.Method[i]);
        }

        Console.Write("Please Choose/Silahkan Pilih : ");
        int tfMethod = Convert.ToInt32(Console.ReadLine()) - 1;

        if (config.config.lang == "en")
        {
            Console.Write("Please type " + config.config.confirm.en + " to confirm the transaction: ");
        }
        else 
        {
            Console.Write("Ketik " + config.config.confirm.id + " untuk mengkonfirmasi transakasi: ");
        }

        string userRespond = Console.ReadLine();

        if (userRespond == config.config.confirm.en)
        {
            Console.WriteLine("The transfer is completed using " + config.config.Method[tfMethod]);
        }
        else if (userRespond == config.config.confirm.id)
        {
            Console.WriteLine("Proses transfer berhasil menggunakan " + config.config.Method[tfMethod]);
        }
        else {
            if (config.config.lang == "en")
            {
                Console.Write("Transfer is cancelled");
            }
            else {
                Console.Write("Transfer dibatalkan");
            }
        }
    }    
}