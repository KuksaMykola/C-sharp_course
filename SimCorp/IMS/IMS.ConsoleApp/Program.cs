using System;
using SimCorp.IMS.MobilePhone;
using SimCorp.IMS.MobilePhone.Audio;
using SimCorp.IMS.MobilePhone.Charg;

namespace SimCorp.IMS.ConsoleApp
{
    class Program
    {
        static int GetIndexFromConsole(int leftRange, int rightRange)
        {
            var index  = -1;
            while(true)
            {
                var numberInputed = true;
                try
                {
                    var userInput = Console.ReadLine();
                    index = Int32.Parse(userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong Input. A digit is expected. Try again");
                    numberInputed = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    numberInputed = false;
                }
                if (numberInputed)
                {
                    if (index < leftRange || index > rightRange)
                    {
                       Console.WriteLine("Wrong Input. Inputed idex exceed allowed range. Try again"); 
                    }   
                    else
                   {
                      break;
                   }    
                } 
            } 
            return index;
        }

        static IPlayback GetPlayBackComponent()
        {
            var outDevice = new ConsoleOutput();
            Console.WriteLine("Select a playback component (specify index):");
            IPlayback[] allPlaybackDevices =new IPlayback[]{new iPhoneHeadset(outDevice), new SamsungHeadset(outDevice), new UnofficialPhoneHeadset(outDevice),new ExternalPhoneSpeaker(outDevice)};
            for(var i = 0; i < allPlaybackDevices.Length; i++)
            {
                Console.WriteLine($"{i+1}-{allPlaybackDevices[i]}");
            }
            var index  = GetIndexFromConsole(1,allPlaybackDevices.Length);         
            return allPlaybackDevices[index-1];
        }

        private static ICharger GetChargerDevice()
        {
            var outDevice = new ConsoleOutput();
            Console.WriteLine("Select a charger device (specify index):");
            ICharger[] allChargerDevices = new ICharger[] {new SocetCharger(outDevice), new LaptopCableCharger(outDevice), new PowerBankCharger(outDevice), new CarCharger(outDevice), new ContactlessCharger(outDevice)};
            for (var i = 0; i < allChargerDevices.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{allChargerDevices[i]}");
            }
            var index = GetIndexFromConsole(1, allChargerDevices.Length);
            return allChargerDevices[index-1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Static mobile phone information");
            Console.WriteLine("_______________________________");
            Mobile mb = new SimcorpMobile("Nokia");
            Console.WriteLine(mb);

            Console.WriteLine("Add plug-in components");
            Console.WriteLine("_______________________________");

            var playback=GetPlayBackComponent();
            Console.WriteLine($"{playback} component was selected");
            Console.WriteLine("");
     
            var charger = GetChargerDevice();
            Console.WriteLine($"{charger} component was selected");

            Console.WriteLine("");
            mb.PlayBackComponent = playback;
            Console.WriteLine("Playback component has been set to the mobile. Play sound in mobile:");
            mb.Play("Favorite music");

            mb.ChargerDevice = charger;
            Console.WriteLine("Charger device has been set to the mobile. Charging the mobile:");
            mb.Charge();

            Console.ReadKey();
        }
    }
}
