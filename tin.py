# -*- coding: utf-8 -*-

import suds.client
from sslcontext import create_ssl_context, HTTPSTransport
from suds.sudsobject import asdict

sslverify = False
cafile = None
capath = None

kwargs = {}
sslContext = create_ssl_context(sslverify, cafile, capath)
kwargs['transport'] = HTTPSTransport(sslContext)
# Add more suds client kwargs if needed.

#Verify with TIN Service from rd.go.th
url = 'https://rdws.rd.go.th/serviceRD3/checktinpinservice.asmx?wsdl'
client = suds.client.Client(url, **kwargs)

results = client.service.ServiceTIN('anonymous','anonymous','<<<ID>>>>')

if results.vIsExist:
    print "OKAY"

