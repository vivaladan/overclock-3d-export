# overclock-3d-export
Post export tool for the Overclock 3d website

## Local Setup

Copy the sql backup file to `/tmp/overclock.sql`

```
docker pull mysql
docker run -p 3306:3306 --name overclock-mysql -e MYSQL_ROOT_PASSWORD=pwd -d mysql
docker cp path\overclock.sql overclock3d-mysql:/tmp/ (wait..)
docker exec -it overclock-mysql /bin/bash
mysql -uroot -p
(enter password - pwd)
create database overclock;
use overclock;
source /tmp/overclock.sql (wait..)
```

Create a .env file at sln root containing:

```
OVERCLOCK_CONNECTION_STRING='server=localhost;user=root;password=pwd;database=overclock;Convert Zero Datetime=True'
OVERCLOCK_EXPORT_PATH='/tmp/overclock/export'
```