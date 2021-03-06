QuikPak is a CLI tool that will take a directory and create an msi that will install a website into IIS with said directory...

## How to install

Install via chocolatey

`choco install quikpak`

You can also install it from our public feed which might have newer versions faster: `choco install quikpak -s https://www.myget.org/F/tommy-chocolatey/api/v2`

## How to use

Create a json config file that looks something like this. The upgrade code must be a unique uuid, that will identify your msi.


```json

{
    "UpgradeCode": "317e4313-2314-46e9-ae7e-6cdfee60c05d",
    "Name": "MyWebsite",
    "Version": "1.0.0",
    "Endpoints": [
        {
            "port": 80,
            "DnsName": "mywebsite.com",
            "Secure": false
        }
    ]
}

```

then call QuikPak.exe -c path\to\your\config.jsondfsa -x path\to\your\web\content

## Certificates

You can also add certificates to your json bindings.


```json

{
    "UpgradeCode": "317e4313-2314-46e9-ae7e-6cdfee60c05d",
    "Name": "terribledev",
    "Version": "1.0.0.1",
    "Endpoints": [
        {
            "port": 10000,
            "DnsName": "*",
            "Secure": false
        },
        {
            "port": 8000,
            "DnsName": "localhost",
            "Secure" :  false
        }
    ],
	"Certificates":[
		{
			"Name": "MyCert",
			"Path": "awesome.pfx",
			"Password": "password"
		}
	]
}
```
