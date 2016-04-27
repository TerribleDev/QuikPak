QuikPak is a CLI tool that will take a directory and create an msi that will install a website into IIS with said directory...

## How to install

Install via chocolatey

`choco install quikpak`

## How to use

Create a json config file that looks something like this


```json

{
    "Id": "d372b142-ea42-4cc9-8dd6-cb4ba2b0c0f3",
    "UpgradeCode": "317e4313-2314-46e9-ae7e-6cdfee60c05d",
    "Name": "MyWebsite",
    "Version": "1.0.0.0",
    "Endpoints": [
        {
            "port": 80,
            "DnsName": "mywebsite.com",
            "Secure": false
        }
    ]
}

```

then call QuikPak.exe -c path\to\your\config.json -x path\to\your\web\content
