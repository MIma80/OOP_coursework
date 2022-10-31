using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL_coursework;
using DAL_coursework;
using BLL_coursework;
using System.IO;
using DataProviderContract;
using JSONProvider;

namespace OOP_coursework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

           IDataContext<Wallet> dataContextCurrentWallet_json = new DataContext<Wallet>("DataBase.json");
           dataContextCurrentWallet_json.DataProvider = new JsonDataProvider<Wallet>();
           WalletService walletService = new WalletService(dataContextCurrentWallet_json);

            Menu.Start(walletService);
        }
    }
}
