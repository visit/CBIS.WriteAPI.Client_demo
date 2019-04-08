using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBISimpaler.Models
{
    public class Credentials
    {
        public static BasicAuthenticationCredentials credentials = new BasicAuthenticationCredentials();
        public static CBISImpaler.CBISWriteAPI client = new CBISImpaler.CBISWriteAPI(credentials);

    }
}
