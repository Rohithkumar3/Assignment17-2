using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17_2
{
    internal class HerbalProduct : Product
    {
             string herbsUsed;
             DateTime mfgDate;
             DateTime expDate;

            public void SetHerbalInformation(string herbsUsed, DateTime mfgDate, DateTime expDate)
            {
                this.herbsUsed = herbsUsed;
                this.mfgDate = mfgDate;
               this.expDate = expDate;
            }

            public override void ShowDetails()
            {
                base.ShowDetails();

                Console.WriteLine($"Herbs Used: {herbsUsed}");
                Console.WriteLine($"Manufacture Date: {mfgDate.ToShortDateString()}");
                Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
            }
        }
    }
