using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIBR
{
    class Global
    {
        /*client
        * CNIC1            CNIC2           CNIC3           CNIC4    ............
        * first_name
        * last_name
        * gender
        * phone_number
        * username //"" if not registered
        * password //"" if no registered
        */
        public static List<List<string>> client = new List<List<string>>();
        public static List<string> client1 = new List<string>();

        /*account
         * IBAN1            IBAN2           IBAN3           IBAN4    ............
         * CNIC
         * type
         * status
         * transaction_password
         */
        public static List<List<string>> account = new List<List<string>>();
        public static List<string> account1 = new List<string>();
        /*balance
         * amount1            amount2           amount3           amount4    ............
         */
        public static List<int> balance = new List<int>();

        /*card
         * card_number1            card_number2           card_number3           card_number4    ............
         * CNIC
         * vin
         * pin
         */
        public static List<List<string>> card = new List<List<string>>();
        public static List<string> card1 = new List<string>();
        /*transaction
         * transactionID1            transactionID2           transactionID3           transactionID4    ............
         * senderIBAN
         * recieverIBAN
         * amount
         * purpose
         * day
         * month
         * year
         */
        public static List<List<string>> transaction = new List<List<string>>();
        public static List<string> transaction1 = new List<string>();
    }
}