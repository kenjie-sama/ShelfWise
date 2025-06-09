# Full path resolution based on script location
$root = Split-Path -Parent $MyInvocation.MyCommand.Path

# Paths relative to the script
$authServicePath = ".\ShelfWise.Service.Auth\ShelfWise.Service.Auth.csproj"
$frontendPath    = ".\ShelfWise.Web\ShelfWise-web"

# Start the Auth Service
Start-Process "dotnet" -ArgumentList "run --project `"$authServicePath`""

# Start the React frontend
Start-Process "cmd.exe" -ArgumentList "/k cd /d `"$frontendPath`" && npm run dev"
