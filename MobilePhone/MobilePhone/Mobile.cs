using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    internal class Mobile
    {
        public Mobile(string name,
                      CircuitBoard circuitBoard,
                      Battery battery,
                      Antenna antenna,
                      Screen screen,
                      Keyboard keyboard,
                      Microphone microphone,
                      Speaker speaker)
        {
            Name = name;
            CircuitBoard = circuitBoard;
            Battery = battery;
            Antenna = antenna;
            Screen = screen;
            Keyboard = keyboard;
            Microphone = microphone;
            Speaker = speaker;
        }

        public Mobile(string name)
        {
            Name = name;
        }
        public Mobile()
        {

        }
        public String Name { get; set; } = "NewPhone";
        public CircuitBoard CircuitBoard { get; private set; } = new CircuitBoard();
        public Battery Battery { get; private set; } = new Battery();
        public Antenna Antenna { get; private set; } = new Antenna();
        public Screen Screen { get; private set; } = new Screen();
        public Keyboard Keyboard { get; private set; } = new Keyboard();
        public Microphone Microphone { get; private set; } = new Microphone();
        public Speaker Speaker { get; private set; } = new Speaker();
    }
}
