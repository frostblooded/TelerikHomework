using System;

namespace GSMProject
{
    class GSMCallHistoryTest
    {
        static public void PrintTestResults()
        {
            GSM gsm = GSM.IPhone4S;
            gsm.AddCall(new Call(new DateTime(2014, 09, 09), "0897850537", 153));
            gsm.AddCall(new Call(new DateTime(2014, 08, 09), "0897850537", 243));

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine("Total calls price is {0}", gsm.CalculateTotalCallsPrice(0.37));

            Call longestCall = gsm.CallHistory[0];
            foreach (var call in gsm.CallHistory)
            {
                if (call.DurationInSeconds >  longestCall.DurationInSeconds)
                {
                    longestCall = call;
                }
            }
            gsm.DeleteCall(longestCall);

            Console.WriteLine("Total calls price after removing the longest call is {0}", gsm.CalculateTotalCallsPrice(0.37));

            gsm.ClearCallHistory();

            Console.WriteLine("Call history after it has been cleared:");

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
