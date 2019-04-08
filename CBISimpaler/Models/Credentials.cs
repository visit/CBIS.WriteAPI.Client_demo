using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBISimpaler.Models
{
    public class Credentials
    {
        public static BasicAuthenticationCredentials credentials = new BasicAuthenticationCredentials();
        public static CBISimpaler.CBISWriteAPI client = new CBISimpaler.CBISWriteAPI(credentials);

    }
}
