using System;

// Samuel Miller
// IT112

namespace Miller_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Populate phones array:
            Phone[] phones = { new HomePhone("CompuTest", "(303) 985-5060", "1"),
                               new CellPhone("Curtis Manufacturing", "(603) 532-4123", "2"),
                               new HomePhone("Data Functions", "(800) 876-2524", "1"),
                               new HomePhone("Donnay Repair", "(708) 397-3330", "1"),
                               new HomePhone("ErgoNomic Inc", "(360) 434-3894", "1"),
                               new HomePhone("ErgoSource", "(800) 969-4374", "1"),
                               new CellPhone("Fox Bay Industries", "(800) 874-8527", "2"),
                               new CellPhone("Glare-Guard", "(800) 545-6254", "2"),
                               new CellPhone("Hazard Comm Specialists", "(407) 783-6641", "2"),
                               new CellPhone("Komfort Support", "(714) 472-4409", "2")};

            // Output appropriate message for each phone:
            for ( int i = 0; i < phones.Length; ++i )
            {
                Console.WriteLine(phones[i].Dial());
            }
        }
    }
}
