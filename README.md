### What?
Dockerized .NET core web api that tells you the uptime of a Linux machine

### Why?
I'd like to be notified when there my home lab server restarts, usually because of a power outage. I then need to re-sync my aquarium light schedule with the lights with my smart phone.

Unfortunately the lights don't keep track of the schedule during power outages. 

### Getting Started
*Note*: Because this is dockerized, it looks for the uptime file in the following locations. You'll need to add them depending if your Windows or Linux/OSX

**Windows**: `C:/temp/uptime.txt`

**Linux**: `/data/uptime`

**Populate test file**:

`echo "9852.99 17711.51" > /data/uptime`

**Run from source code**:
```
git clone https://github.com/loonison101/Uptime.git
cd Uptime/src/Uptime.Web
dotnet run
curl http://localhost:5000/Uptime
```

**Docker Run**
```
cd Uptime
docker build -t uptime:0.0.1 .
# You need to run docker with an attached file, see above for the locations
docker run -d -v c:\temp\uptime.txt:/data/uptime -p 8080:80 uptime:0.0.1
```

**Kubernetes Run**
```
Don't forget the slow network I ha dto leav out, i cut off top of config file
```

### How?
The `/proc/uptime` file determines the machine uptime in most Linux environments.

**First number**: How long the OS has been running in seconds

**Second number**: Idle time (what is this? :confused:) 

`
9852.99 17711.51
`

A .net app reads the file, parses it, and then returns a JSON object indicating seconds, minutes, etc. regarding uptime

### Goals
1. **.NET core** - My experience in the past was with the full framework, wanted to dabble with core
2. **Dockerized**
3. **Hosted in Kubernetes** 

### Projects Explained
