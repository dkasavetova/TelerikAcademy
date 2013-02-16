using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int j = 0; j < 4; j++)
        {
            Console.Write("Dec\tChar\t\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < 32; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0}\t", (i + j * 32));
                switch ((i + j * 32))
                {
                    case 0:
                        Console.Write("NUL");
                        break;
                    case 1:
                        Console.Write("SOH");
                        break;
                    case 2:
                        Console.Write("STX");
                        break;
                    case 3:
                        Console.Write("ETX");
                        break;
                    case 4:
                        Console.Write("EOT");
                        break;
                    case 5:
                        Console.Write("ENQ");
                        break;
                    case 6:
                        Console.Write("ACK");
                        break;
                    case 7:
                        Console.Write("BEL");
                        break;
                    case 8:
                        Console.Write("BS");
                        break;
                    case 9:
                        Console.Write("TAB");
                        break;
                    case 10:
                        Console.Write("LF");
                        break;
                    case 11:
                        Console.Write("VT");
                        break;
                    case 12:
                        Console.Write("FF");
                        break;
                    case 13:
                        Console.Write("CR");
                        break;
                    case 14:
                        Console.Write("SO");
                        break;
                    case 15:
                        Console.Write("SI");
                        break;
                    case 16:
                        Console.Write("DLE");
                        break;
                    case 17:
                        Console.Write("DC1");
                        break;
                    case 18:
                        Console.Write("DC2");
                        break;
                    case 19:
                        Console.Write("DC3");
                        break;
                    case 20:
                        Console.Write("DC4");
                        break;
                    case 21:
                        Console.Write("NAK");
                        break;
                    case 22:
                        Console.Write("SYN");
                        break;
                    case 23:
                        Console.Write("ETB");
                        break;
                    case 24:
                        Console.Write("CAN");
                        break;
                    case 25:
                        Console.Write("EM");
                        break;
                    case 26:
                        Console.Write("SUB");
                        break;
                    case 27:
                        Console.Write("ESC");
                        break;
                    case 28:
                        Console.Write("FS");
                        break;
                    case 29:
                        Console.Write("GS");
                        break;
                    case 30:
                        Console.Write("RS");
                        break;
                    case 31:
                        Console.Write("US");
                        break;
                    case 32:
                        Console.Write("SPACE");
                        break;
                    case 127:
                        Console.Write("DEL");
                        break;
                        
                    default:
                        Console.Write((char)(i + j * 32));
                        break;
                }
                Console.Write("\t\t");
               
            }
            Console.WriteLine();
        }
       
       
    }
}

