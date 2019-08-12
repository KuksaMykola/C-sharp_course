using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone
{
    class CircuitBoard
    {

        public Microprocessor Microprocessor=new Microprocessor(1.5f,3);
        public ReadOnlyMemory Rom=new ReadOnlyMemory(400);
        public RandomAccessMemory Ram=new RandomAccessMemory(1000);
        public Storage Storage=new Storage (4000);
        public SimCard SimCard = new SimCard();
        public CircuitBoard()
        {
        }
        public CircuitBoard(Microprocessor microprocessor,
                            ReadOnlyMemory rom,
                            RandomAccessMemory ram,
                            Storage storage,
                            SimCard simCard)
        {
            Microprocessor = microprocessor;
            Rom = rom;
            Ram = ram;
            Storage = storage;
            SimCard = simCard;
        }
           
    }
}
