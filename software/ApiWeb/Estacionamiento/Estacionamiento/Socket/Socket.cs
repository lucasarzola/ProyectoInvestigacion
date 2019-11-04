using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace socket
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 1234);

            byte[] payload;
            try
            {
                payload = new byte[255];
                socket.Bind(direccion);
                socket.Listen(1);
                Console.WriteLine("Escuchando...");
                Socket listen = socket.Accept();
                int a = listen.Receive(payload, 0, payload.Length, 0);
                Array.Resize(ref payload, a);
                Console.WriteLine("Cliente dice: " + Encoding.Default.GetString(payload));
                Console.WriteLine("Conectado con exito");
                socket.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
            Console.ReadLine();
        }

    }
}

