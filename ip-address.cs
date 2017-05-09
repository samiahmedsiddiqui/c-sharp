// To get the IP Address of the User in C#(.NET Framework 4.5)

var HostEntry = Dns.GetHostEntry(Dns.GetHostName());
string IPAddress = "";

foreach (var ip in HostEntry.AddressList) {
  if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
      IPAddress = ip.ToString();
  }
}

Response.Write("userIP"+ IPAddress);
