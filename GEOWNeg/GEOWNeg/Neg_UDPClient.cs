using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

using GEOWObj.contracts;

namespace GEOWNeg
{
    public class Neg_UDPClient : INeg_UDPClient
    {
        public bool EnviarMensaje(string Msg)
        {
            bool res = false;

            try
            {
                if (Msg.Trim().Length > 0)
                {
                    byte[] data = Encoding.ASCII.GetBytes(Msg.Trim());

                    string ipAddress = "127.0.0.1";
                    string sendPort = "11000";

                    try
                    {
                        using (var client = new UdpClient())
                        {
                            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipAddress), int.Parse(sendPort));

                            client.Connect(ep);
                            client.Send(data, data.Length);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }

            return res;

        }
    }


}
