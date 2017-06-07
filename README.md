# Healthcheck Tools for Windows
This repository includes tools to demonstrating Docker healthchecks for .NET applications on Windows

## Usage
To test healthchecks, we'll need to add a "killswitch" that a healthcheck can listen to

Add Kill.aspx and Healthcheck.KillSwitch.dll based on your target .NET Framework (3.5 or 4.5)
### Add KillSwitch - .NET Framework 3.5
```
#Dockerfile
...
ADD <github.com/repo/Kill.aspx> /inetpub/wwwroot/Kill.aspx
ADD <github.com/repo/Healthcheck.KillSwitch.dll> /inetpub/wwwroot/bin/Healthcheck.KillSwitch.dll
...
```

### Add KillSwitch - .NET Framework 4.6
```
#Dockerfile
...
ADD <github.com/repo/Kill.aspx> /inetpub/wwwroot/Kill.aspx
ADD <github.com/repo/Healthcheck.KillSwitch.dll> /inetpub/wwwroot/bin/Healthcheck.KillSwitch.dll
...
```

### Configure HEALTHCHECK
TODO: Copy Healthcheck from Nationstar implementation
```

```