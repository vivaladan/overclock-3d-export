# overclock-3d-export
Post export tool for the Overclock 3d website

## Local Setup

`docker pull mysql`

`docker exec -i overclock3d-mysql -c 'exec mysql -uroot -p "pwd"' < path\overclock.sql`

or

```docker cp path\overclock.sql overclock3d-mysql:/tmp/```

Create a .env file at sln root containing:

```
OVERCLOCK_CONNECTION_STRING='server=localhost;user=root;password=pwd;database=overclock;Convert Zero Datetime=True'
OVERCLOCK_EXPORT_PATH='export-path'
```