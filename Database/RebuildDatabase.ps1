Param(
   [string] $Server = "LAPTOP-TN62H4D5\SQLEXPRESS",
   [string] $Database = "560 Project"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

Write-Host "Dropping tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Schemas\Basketball.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\Basketball.Conference.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\Basketball.BasketballTeam.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\Basketball.TeamPlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\Basketball.PlayerStats.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\Basketball.BasketballGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Tables\Basketball.GameTeam.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.CreatePlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.CreatePlayerStats.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.GetTeamPlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.FetchTeamPlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.RetrieveTeamPlayers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.UpdatePlayerStats.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "Database\Sql\Procedures\Basketball.UpdateTeamPlayer.sql"

# Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrievePersons.sql"
# Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.FetchPerson.sql"
# Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.GetPerson.sql"
# Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.SavePersonAddress.sql"
# Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Person.RetrieveAddressesForPerson.sql"

Write-Host "Inserting data..."
# Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Person.AddressType.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
