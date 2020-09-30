using System;
using System.Collections.Generic;
using System.Text;

namespace PHP.Database
{
    public interface  IDatabaseAppSettings //inherit to use application settings with context class 
    {
        string URL { get; set; }
        string Port { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string DatabaseName { get; set; }
       
    }
}
