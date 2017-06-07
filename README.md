# Healthcheck Tools for Windows
This repository includes tools to demonstrating Docker healthchecks for .NET applications on Windows

## Usage
To test healthchecks, we'll need to add a "killswitch" that a healthcheck can listen to

Add Kill.aspx and Healthcheck.KillSwitch.dll based on your target .NET Framework (3.5 or 4.5)
### Add KillSwitch - .NET Framework 3.5
```
#Dockerfile
...
ADD https://raw.githubusercontent.com/BrandonRoyal/healthcheck/master/build/fx35/Kill.aspx /inetpub/wwwroot/Kill.aspx
ADD https://github.com/BrandonRoyal/healthcheck/blob/master/build/fx35/bin/Healthcheck.Kill.dll?raw=true /inetpub/wwwroot/bin/Healthcheck.KillSwitch.dll
...
```

### Add KillSwitch - .NET Framework 4.6
```
#Dockerfile
...
ADD https://raw.githubusercontent.com/BrandonRoyal/healthcheck/master/build/fx35/Kill.aspx /inetpub/wwwroot/Kill.aspx
ADD https://github.com/BrandonRoyal/healthcheck/blob/master/build/fx35/bin/Healthcheck.Kill.dll?raw=true /inetpub/wwwroot/bin/Healthcheck.KillSwitch.dll
...
```

### Configure HEALTHCHECK
TODO: Copy Healthcheck from Nationstar implementation
```
# Healthcheck
HEALTHCHECK --interval=5s `
 CMD powershell -command `
    $path = 'C:\windows\temp\dead'; `
    if (Test-Path $path) { exit 1 }
```